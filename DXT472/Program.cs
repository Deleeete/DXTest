using DXT472;
using System;
using System.Threading;
using System.Windows.Forms;

namespace DXTest
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Random ro = new Random();
            PhysForm main = new PhysForm();
            if (!main.InitializeDirect3D()) return;
            if (!main.InitializeKm()) return;
            for (int n = 0; n < PhysForm.objs.Count; n++)
            {
                PhysForm.objs.Add( new PhysForm.Object(30, Vector.RandomVector(ro,-10,10), Vector.Zero, Vector.Zero, 60, 60, PhysForm.torpedo));
            }
            main.Show();
            new Thread((ThreadStart)delegate
            {
                Application.Run(new ControlForm(main));
            }).Start();
            while (main.Created) //设置一个循环用于实时更新渲染状态
            {
                main.KeyboardListen();
                main.Render();
                //basicForm.MouseListen();
                Application.DoEvents();
            }
        }
    }
}
