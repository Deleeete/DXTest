using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.DirectX.Direct3D;
using Microsoft.DirectX;

namespace DXTest
{
    public partial class BasicForm : Form
    {
        Device device = null;
        public bool InitializeDirect3D()
        {
            try
            {
                PresentParameters presentParams = new PresentParameters();
                presentParams.Windowed = true; //指定以Windows窗体形式显示
                presentParams.SwapEffect = SwapEffect.Discard; //当前屏幕绘制后它将自动从内存中删除
                device = new Device(0, DeviceType.Hardware, this, CreateFlags.SoftwareVertexProcessing, presentParams); //实例化device对象
                return true;
            }
            catch (DirectXException e)
            {
                MessageBox.Show(e.ToString(), "Error"); //处理异常
                return false;
            }
        }
        public bool Render()
        {
            if (device == null) return false;
            device.Clear(ClearFlags.Target, Color.DarkSlateBlue, 1.0f, 0);  //清除windows界面为深蓝色
            device.BeginScene();
            //在此添加渲染图形代码
            device.EndScene();
            device.Present();
            return true;
        }

        public BasicForm()
        {
            ClientSize = new Size(800, 800);
            Text = "DXTest";
        }
    }
}
