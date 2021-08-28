using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXTest
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            BasicForm basicForm = new BasicForm(); //创建窗体对象
            if (basicForm.InitializeDirect3D() == false) //检查Direct3D是否启动
            {
                MessageBox.Show("无法启动Direct3D！", "错误！");
                return;
            }
            basicForm.Show(); //如果一切都初始化成功，则显示窗体
            while (basicForm.Created) //设置一个循环用于实时更新渲染状态
            {
                basicForm.Render(); //保持device渲染，直到程序结束
                Application.DoEvents(); //处理键盘鼠标等输入事件
            }
        }
    }
}
