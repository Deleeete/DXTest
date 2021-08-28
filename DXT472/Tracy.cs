using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace DXT472
{
    public static class Tracy
    {
        public const double TAU = 6.283185307;
        public const byte R = 0, G = 1, B = 2;
        public const short N = 64;
        public static bool JG = true;
        public static int MAX_STEP = 724;

        public partial class Circle : Shape
        {
            public int x,y,r;
            public Circle(int x, int y, int r, float k, Color color)
            {
                this.x = x; this.y = y; this.r = r; base.k = k; base.color = color;
            }
            public double sdf(int px, int py)
            {
                return distance(x, y, px, py) - r;
            }
        }
        public partial class Plane : Shape
        {
            public double A, B, C;
            public double ax, ay, bx, by;
            public int reverse;//默认发光区域为下方
            public Plane(double A, double B, double C, int reverse, float k, Color color)//一般式
            {
                this.A = A; this.B = B; this.C = C; this.color = color; this.k = k; this.reverse = reverse;
            }
            public Plane(double ax, double ay, double bx, double by, int reverse, float k, Color color)//两点到一般式
            {
                A = by - ay;
                B = ax - bx;
                C = bx * ay - ax* by;
                this.color = color; this.k = k; this.reverse = reverse;
            }
            public double sdf(int x, int y)
            {
                return (A * x + B * y + C) * reverse / Math.Sqrt(A * A + B * B);//点到直线距离
            }
        }
        public partial class Rect:Shape
        {
            public double cx, cy, width, height, left, right, top, buttom;
            public Plane ab, bc, cd, da;
            public Rect(int cx, int cy, int width, int height, Color color, float k)
            {
                left = cx - width / 2;
                right = left + width;
                top = cy - height / 2;
                buttom = top + height;
                this.cx = cx; this.cy = cy;this.width = width; this.height = height;
                this.color = color;
                this.k = k;
                ab = new Plane(left,top,right,top, 1, k, color);
                bc = new Plane(right,top,right,buttom, 1, k, color);
                cd = new Plane(right,buttom,left,buttom, 1, k, color);
                da = new Plane(left, buttom, left, top, 1, k, color);
            }
            public double sdf(int dx, int dy)
            {
                double[] r = new double[4];
                r[0] = ab.sdf(dx, dy);
                r[1] = bc.sdf(dx, dy);
                r[2] = cd.sdf(dx, dy);
                r[3] = da.sdf(dx, dy);
                return r.Max();
            }
        }

        public class Shape
        {
            public Color color;
            public float k;
            public double sdf()
            {
                return 0;
            }
        }

        public static double distance(int ax, int ay, int bx, int by)
        {
            int dx = ax - bx;
            int dy = ay - by;
            return Math.Sqrt(dx*dx+dy*dy);
        }
        public static double max(double[] array)
        {
            double max = 0;
            for (int n = 0; n < array.Length; n++)
            {
                max = array[n] > max ? array[n] : max; 
            }
            return max;
        }
        public static int rx(double x)
        {
            return round(x+400);
        }
        public static int ry(double y)
        {
            return round(400-y);
        }
        public static int round(double x)
        {
            return Convert.ToInt32(Math.Round(x, 0));
        }
    }
}
