using System.Windows.Forms;
using Microsoft.DirectX.Direct3D;
using Microsoft.DirectX;
using Microsoft.DirectX.DirectInput;
using System.Drawing;
using Device = Microsoft.DirectX.Direct3D.Device;
using KDevice = Microsoft.DirectX.DirectInput.Device;
using DeviceType = Microsoft.DirectX.Direct3D.DeviceType;
using System;
using System.Diagnostics;
using Tracy = DXT472.Tracy;
using Font = Microsoft.DirectX.Direct3D.Font;
using DXT472;
using System.Collections.Generic;

namespace DXTest
{
    public partial class PhysForm : Form
    {
        public PhysForm()
        {
            ClientSize = new Size(800, 800);
            Text = "DXTest";
            CheckForIllegalCrossThreadCalls = false;
        }
        #region Init
        public static Device device = null;
        public static KDevice kb = null;
        public static KDevice ms = null;
        public static Texture ship, torpedo;
        public static Sprite sprite = new Sprite(device);
        public static bool[] flames = {false,false,false,false};
        public static Texture[] fts = new Texture[8];
        public bool InitializeDirect3D()
        {
            try
            {
                PresentParameters presentParams = new PresentParameters();
                presentParams.Windowed = true; //指定以Windows窗体形式显示
                presentParams.SwapEffect = SwapEffect.Discard; //当前屏幕绘制后它将自动从内存中删除
                device = new Device(0, DeviceType.Hardware, this, CreateFlags.SoftwareVertexProcessing, presentParams); //实例化device对象
                Debug.Print("DXDevice init success.");
                ship = TextureLoader.FromFile(device, "../ship.png");
                torpedo = TextureLoader.FromFile(device, "../torpedo.png");
                fts[0] = TextureLoader.FromFile(device, "../flameu.png");
                fts[1] = TextureLoader.FromFile(device, "../flamer.png");
                fts[2] = TextureLoader.FromFile(device, "../flamed.png");
                fts[3] = TextureLoader.FromFile(device, "../flamel.png");
                fts[4] = TextureLoader.FromFile(device, "../flameu2.png");
                fts[5] = TextureLoader.FromFile(device, "../flamer2.png");
                fts[6] = TextureLoader.FromFile(device, "../flamed2.png");
                fts[7] = TextureLoader.FromFile(device, "../flamel2.png");
                Sprite fus = new Sprite(device);
                Sprite fls = new Sprite(device);
                Sprite frs = new Sprite(device);
                Sprite fds = new Sprite(device);
                Debug.Print("Texture loading success.");
                return true;
            }
            catch (DirectXException ex)
            {
                MessageBox.Show(ex.Message, "Initailization Failed");
                return false;
            }
        }
        public bool InitializeKm()
        {
            try
            {
                kb = new KDevice(SystemGuid.Keyboard);
                ms = new KDevice(SystemGuid.Mouse);
                kb.SetCooperativeLevel(this, CooperativeLevelFlags.Background | CooperativeLevelFlags.NonExclusive);
                ms.SetCooperativeLevel(this, CooperativeLevelFlags.Background | CooperativeLevelFlags.NonExclusive);
                ms.Properties.AxisModeAbsolute = true;
                kb.Acquire();//链接键盘设备
                ms.Acquire();
                Debug.Print("KBDevices init success.");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Keyboard/Mouse Initailization Failed");
                return false;
            }
        }
        #endregion
        //*****************GVs**********************
        public static int frame = 0;
        public static int controlNum = 0;
        public static double timeflow = 1;
        public static double tc = timeflow/144; //时间常数delta t
        public static double scale = 1; //坐标映射放缩
        public static double k = 0.11; //空阻系数
        public static Vector g = new Vector(0,-9.8); //重力加速度
        public static double el = 0.7; //弹性衰减系数
        public static double G = 1;     //引力常数
        public static Vector key = Vector.Zero; //  键盘推力
        public static double kforceUp = 300, kforceDown = 300, kforceLeft = 300, kforceRight = 300;//键盘推力
        public static double tforce = 30000;//鱼雷引擎推力
        public static bool isG = true, isFriction = false, isEl = true, isGravity = false;
        public static bool fired = false;
        //-----------------Debug-------------------------
        public static List<Object> objs = new List<Object>();
        public static bool showBox = false;  //  显示矩形盒
        //******************************************
        public bool Render()
        {
            if (device == null) return false;
            device.Clear(ClearFlags.Target, Color.FromArgb(37, 37, 38), 1.0f, 0);
            device.BeginScene();
            /***************Rendering code*******************/
            //更新状态
            for (int n = 0; n < objs.Count; n++)
            {
                Vector friction = objs[n].v.x == 0 && objs[n].v.y == 0 ? Vector.Zero : k * (-objs[n].v);    //大气摩擦力
                //边缘碰撞检测
                objs[n].edgeContact(el);
                Vector outer = Vector.Zero;
                for (int i = 0; i < objs.Count; i++)
                {
                    if (i == n) continue;
                    //物体碰撞检测
                    objs[n].objContact(objs[i]);        
                    outer += objs[i].gravity(G,
                        new Vector(objs[i].s.x + 0.5 * objs[i].width, objs[i].s.y + 0.5 * objs[i].height)
                        - new Vector(objs[n].s.x + 0.5 * objs[n].width, objs[n].s.y + 0.5 * objs[n].height), objs[n].m);
                }
                if (n == controlNum)        //是控制的对象
                {
                    objs[n].f = outer + key;
                    if (fired) objs[n].fire(Vector.Right);
                    fired = false;
                } 
                else objs[n].f = outer;
                if (isG) objs[n].f += g * objs[n].m;
                if (isFriction) objs[n].f += friction;
                //绘制
                objs[n].nextState();
                objs[n].draw(device);//,fts);
            }
            /************************************************/
            device.EndScene();
            device.Present();
            frame++;
            frame = frame == 999999999 ? 0 : frame;
            return true;
        }
        public void KeyboardListen()    //通过操作flag来影响
        {
            KeyboardState keys = kb.GetCurrentKeyboardState();
            if (keys[Key.Escape])
            {
                DialogResult result = MessageBox.Show("Are you sure you want to quit?", "Exit", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes) Application.Exit();
            }
            if (keys[Key.UpArrow] || keys[Key.DownArrow] || keys[Key.LeftArrow] || keys[Key.RightArrow])
            {
                key = Vector.Zero;
                if (keys[Key.UpArrow])
                {
                    key += new Vector(0, kforceUp);
                    flames[0] = true;
                }
                else flames[0] = false;
                if (keys[Key.RightArrow])
                {
                    key += new Vector(kforceRight, 0);
                    flames[1] = true;
                }
                else flames[1] = false;
                if (keys[Key.DownArrow])
                {
                    key += new Vector(0, -kforceDown);
                    flames[2] = true;
                }
                else flames[2] = false;
                if (keys[Key.LeftArrow])
                {
                    key += new Vector(-kforceLeft, 0);
                    flames[3] = true;
                }
                else flames[3] = false;
            }
            else
            {
                key = Vector.Zero;
                for (int i = 0; i < 4; i++) flames[i] = false;
            }
            if (keys[Key.F])
            {
                fired = true;
            }
        }
        public void MouseListen()
        {
            MouseState mState = ms.CurrentMouseState;
            MouseEvent me = null;
            byte[] buttons = mState.GetMouseButtons();
            if (buttons[0]!=0)      me = new MouseEvent(mState.X, mState.Y, mState.Z, 0);
            else if (buttons[1]!=0) me = new MouseEvent(mState.X, mState.Y, mState.Z, 1);
            else if (buttons[2] != 0) me = new MouseEvent(mState.X, mState.Y, mState.Z, 2);

        }

        public class Object
        {
            public bool fix = false;
            public double m;
            public Vector s, v, a, f;
            public int width, height, left, top, right, buttom, cx, cy;
            public double rx, ry;
            public Sprite sprite;
            public Texture texture;
            public bool isTorpedo = false;
            public Object(Texture texture)
            {
                this.texture = texture;
                m = 30;
                a = Vector.Zero;
                v = Vector.Zero;
                s = Vector.Zero;
                f = Vector.Zero;
                width = 60;
                height = 60;
                left = round(s.x);
                right = left + width;
                top = round(s.y);
                buttom = top + height;
                cx = left + width / 2;
                cy = top + height / 2;
                rx = rx(s.x);
                ry = ry(s.y);
                fix = false;
            }
            public Object(Vector s, Vector e)
            {
                texture = torpedo;
                sprite = new Sprite(device);
                m = 100;    //鱼雷质量
                a = Vector.Zero;
                v = 10*e;
                this.s = s;
                f = Vector.Zero;
                width = 4;
                height = 4;
                left = round(s.x);
                right = left + width;
                top = round(s.y);
                buttom = top + height;
                cx = left + width / 2;
                cy = top + height / 2;
                rx = rx(s.x);
                ry = ry(s.y);
                fix = false;
                isTorpedo = true;
            }
            public Object(double m, Vector s, Vector v, Vector a, int width, int height, Texture texture)
            {
                this.texture = texture;
                sprite = new Sprite(device);
                this.m = m;
                this.a = a;
                this.v = v;
                this.s = s;
                f = Vector.Zero;
                this.width = width;
                this.height = height;
                left = round(s.x);
                right = left + width;
                top = round(s.y);
                buttom = top + height;
                cx = left + width / 2;
                cy = top + height / 2;
                rx = rx(s.x);
                ry = ry(s.y);
                fix = false;
            }
            public void nextState()
            {
                if (fix) return;
                a = f / m;
                if (frame % 2 == 0)
                {
                    v = v + a * tc;
                    s = s + v * tc + (a * tc * tc) / 2;
                }
                else
                {
                    s = s + v * tc + (a * tc * tc) / 2;
                    v = v + a * tc;
                }

                rx = rx(s.x);
                ry = ry(s.y);
                left = round(rx);
                right = left + width;
                top = round(ry);
                buttom = top + height;
                cx = left + width / 2;
                cy = top + height / 2;
            }
            public void draw(Device device)//, Texture[] fts)
            {
                int x = round(rx);
                int y = round(ry);
                if (!showBox)
                {
                    CustomVertex.TransformedColored[] vertices;
                    vertices = new CustomVertex.TransformedColored[8];//定义顶点
                    Vector4 a = new Vector4(x, y, 0, 1);
                    Vector4 b = new Vector4(x + width, y, 0, 1f);
                    Vector4 c = new Vector4(x + width, y + height, 0, 1f);
                    Vector4 d = new Vector4(x, y + height, 0, 1);
                    vertices[0].Position = a;
                    vertices[0].Color = Color.Red.ToArgb();
                    vertices[1].Position = b;
                    vertices[1].Color = Color.Green.ToArgb();

                    vertices[2] = vertices[1];
                    vertices[3].Position = c;
                    vertices[3].Color = Color.Yellow.ToArgb();

                    vertices[4] = vertices[3];
                    vertices[5].Position = d;
                    vertices[5].Color = Color.Blue.ToArgb();

                    vertices[6] = vertices[5];
                    vertices[6].Color = Color.Red.ToArgb();
                    vertices[7] = vertices[0];
                    device.VertexFormat = CustomVertex.TransformedColored.Format;
                    device.DrawUserPrimitives(PrimitiveType.LineList, 4, vertices);
                }
                if (isTorpedo)
                {
                    sprite.Begin(SpriteFlags.AlphaBlend);
                    Point rp = new Point();
                    sprite.Draw2D(texture, rp, 0f, new Point(x, y), Color.White);
                    sprite.End();
                }
                else
                {
                    sprite.Begin(SpriteFlags.AlphaBlend);
                    Point rp = new Point();
                    sprite.Draw2D(texture, rp, 0f, new Point(x, y), Color.White);
                    if (flames[0])
                    {
                        if (frame % 28 < 14) sprite.Draw2D(fts[0], rp, 0f, new Point(x + 24, y + 60), Color.White);
                        else sprite.Draw2D(fts[4], rp, 0f, new Point(x + 24, y + 60), Color.White);
                    }
                    if (flames[1])
                    {
                        if (frame % 28 < 14) sprite.Draw2D(fts[1], rp, 0f, new Point(x - 31, y + 23), Color.White);
                        else sprite.Draw2D(fts[5], rp, 0f, new Point(x - 31, y + 23), Color.White);
                    }
                    if (flames[2])
                    {
                        if (frame % 28 < 14) sprite.Draw2D(fts[2], rp, 0f, new Point(x + 24, y - 31), Color.White);
                        else sprite.Draw2D(fts[6], rp, 0f, new Point(x + 24, y - 31), Color.White);
                    }
                    if (flames[3])
                    {
                        if (frame % 28 < 14) sprite.Draw2D(fts[3], rp, 0f, new Point(x + 60, y + 23), Color.White);
                        else sprite.Draw2D(fts[7], rp, 0f, new Point(x + 60, y + 23), Color.White);
                    }
                    sprite.End();
                }
            }
            public void fire(Vector r)
            {
                objs.Add(new Object(s,r));
            }
            public void edgeContact(double el)
            {
                double k = isEl ? el : 1;
                if (rx < 0 || right >= 800)
                {
                    v.x = -(v.x * k);
                    s.x = rx < 0 ? sx(0) : sx(799 - width) ;
                }
                if (buttom >= 800 || ry < 0)
                {
                    v.y = -(v.y * k);
                    s.y = ry < 0 ? sy(0) : sy(799 - height) ;
                }
            }
            public void objContact(Object o2)
            {
                if (Math.Abs(o2.left - left) > o2.width + width) return;
                if (Math.Abs(o2.top - top) > o2.height + height) return;
                bool lr = Math.Max(Math.Abs(buttom - o2.top), Math.Abs(top - o2.buttom)) < Math.Max(Math.Abs(left - o2.right), Math.Abs(right - o2.left));
                int ints = 0;
                if (within(o2.top, o2.buttom, top) && within(o2.left, o2.right, left)) ints = 1;
                else if (within(o2.top, o2.buttom, top) && within(o2.left, o2.right, right)) ints = 2;
                else if (within(o2.top, o2.buttom, buttom) && within(o2.left, o2.right, left)) ints = 3;
                else if (within(o2.top, o2.buttom, buttom) && within(o2.left, o2.right, right)) ints = 4;
            }
            public double distance(double ax, double ay)
            {
                double dx = ax - s.x;
                double dy = ay - s.y;
                return Math.Sqrt(dx * dx + dy * dy); ;
            }
            public Vector gravity(double G, Vector r, double m)
            {
                double rs = (r.x * r.x + r.y * r.y) < width*width ? (width*width) : (r.x * r.x + r.y * r.y);
                double magnitude = G * this.m * m / rs;
                Vector force = magnitude * r / Math.Sqrt(rs);
                return force;
            }
        }
        public class Engine
        {
            public double m;
            public Vector e;
            public double maxForce;
            public float valve = 1;
            public Engine(string type, Vector e)
            {
                this.e = e;
                if (type == "mk1")
                {
                    m = 30;
                    maxForce = 1000;
                }
                else if (type == "mk2")
                {
                    m = 60;
                    maxForce = 3000;
                }
            }
            public void changeThrottle(float valve)
            {
                this.valve = valve;
            }
        }
        public partial class Torpedo:Object
        {
            
        }
        public static int round(double x)
        {
            if (x > int.MaxValue) x = int.MaxValue;
            else if (x < int.MinValue) x = int.MinValue;
            return Convert.ToInt32(Math.Round(x, 0));
        }
        public static bool within(double l, double r, double x)
        {
            return (x > l && x < r);
        }
        public static double rx(double sx)
        {
            return scale*sx + 399;
        }
        public static double ry(double sy)
        {
            return 400 - scale*sy;   //-399<=ry<=400
        }
        public static double sx(double rx)
        {
            return (rx - 399) / scale;
        }
        public static double sy(double ry)
        {
            return (400 - ry) / scale;
        }
    }

    public class MouseEvent
    {
        public int x, y, z, k;
        public MouseEvent(int x, int y, int z, int k)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.k = k;
        }
    }
    public struct Vector
    {
        public double x, y;
        public static Vector Zero = new Vector(0, 0);
        public static Vector Up = new Vector(0, 1);
        public static Vector Right = new Vector(1, 0);
        public static Vector Down = new Vector(0, -1);
        public static Vector Left = new Vector(-1, 0);
        public Vector(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public static Vector operator +(Vector a, Vector b)
        {
            return new Vector(a.x + b.x, a.y + b.y);
        }
        public static Vector operator -(Vector a, Vector b)
        {
            return new Vector(a.x - b.x, a.y - b.y);
        }
        public static Vector operator -(Vector a)
        {
            return new Vector(-a.x, -a.y);
        }
        public static Vector operator *(double a, Vector b)
        {
            return new Vector(a * b.x, a * b.y);
        }
        public static Vector operator *(Vector b, double a)
        {
            return new Vector(a * b.x, a * b.y);
        }
        public static Vector operator /(Vector a, double b)
        {
            return new Vector(a.x / b, a.y / b);
        }
        public static double operator *(Vector a, Vector b)
        {
            return a.x * b.x + a.y * b.y;
        }
        public static Vector RandomVector(Random ro, int min, int max)
        {
            return new Vector(ro.Next(min,max),ro.Next(min,max));
        }
    }
    public class GravitySource
    {
        public int x, y, M, radius;
        public int rx, ry;
        public GravitySource(int x, int y, int M, int radius)
        {
            this.x = x;
            this.y = y;
            this.M = M;
            this.radius = radius;
            rx = 400 + x;
            ry = 400 - y;
        }
        public double distance(double ax, double ay)
        {
            double dx = ax - x;
            double dy = ay - y;
            return Math.Sqrt(dx * dx + dy * dy); ;
        }
        public Vector gravity(double G, Vector r, double m)
        {
            double magnitude = G * M * m / (r * r);
            Vector force = magnitude * r / Math.Sqrt(r.x * r.x + r.y * r.y);
            return force;
        }
        public void draw(Device device)
        {
            CustomVertex.TransformedColored[] vertices = new CustomVertex.TransformedColored[4*radius*radius];//定义顶点
            int R = rx + 2 * radius;
            int B = ry + 2 * radius;
            int count = 0;
            for (int i = 0; i < 800; i++)
            {
                for (int j = 0; j < 800; j++)
                {
                    if (i < rx-radius || i > R || j < ry-radius || j > B) continue;
                    else
                    {
                        int ax = i - 400;
                        int ay = 400 - j;
                        if (distance(ax, ay) <= radius)
                        {
                            vertices[count].Position = new Vector4(i,j,0,1f);
                            vertices[count].Color = Color.DarkOrange.ToArgb();
                            device.VertexFormat = CustomVertex.TransformedColored.Format;
                            count++;
                        }
                    }
                }
            }
            device.DrawUserPrimitives(PrimitiveType.PointList, count, vertices);
        }
    }
}