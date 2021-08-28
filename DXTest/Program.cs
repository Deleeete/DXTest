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
            BasicForm basicForm = new BasicForm(); //�����������
            if (basicForm.InitializeDirect3D() == false) //���Direct3D�Ƿ�����
            {
                MessageBox.Show("�޷�����Direct3D��", "����");
                return;
            }
            basicForm.Show(); //���һ�ж���ʼ���ɹ�������ʾ����
            while (basicForm.Created) //����һ��ѭ������ʵʱ������Ⱦ״̬
            {
                basicForm.Render(); //����device��Ⱦ��ֱ���������
                Application.DoEvents(); //����������������¼�
            }
        }
    }
}
