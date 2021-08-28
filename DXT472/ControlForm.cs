using DXTest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace infexn
{
    public partial class ControlForm : Form
    {
        public PhysForm physForm;
        public ControlForm(PhysForm physForm)
        {
            InitializeComponent();
            this.physForm = physForm;
            gravityBox.Checked = PhysForm.isGravity;
            gBox.Checked = PhysForm.isG;
            elBox.Checked = PhysForm.isEl;
            fBox.Checked = PhysForm.isFriction;
            GcBox.Value = Convert.ToDecimal(PhysForm.G);
            gxBox.Value = Convert.ToDecimal(PhysForm.g.x);
            gyBox.Value = Convert.ToDecimal(PhysForm.g.y);
            elcBox.Value = Convert.ToDecimal(PhysForm.el);
            fcBox.Value = Convert.ToDecimal(PhysForm.k);
            scaleBox.Value = Convert.ToDecimal(PhysForm.scale);
            upBox.Value = Convert.ToDecimal(PhysForm.kforceUp);
            downBox.Value = Convert.ToDecimal(PhysForm.kforceDown);
            rightBox.Value = Convert.ToDecimal(PhysForm.kforceRight);
            leftBox.Value = Convert.ToDecimal(PhysForm.kforceLeft);
            tfBox.Value = Convert.ToDecimal(PhysForm.timeflow);
            Thread fpsT = new Thread(update);
            fpsT.Start();
        }

        private void gravityBox_CheckedChanged(object sender, EventArgs e)
        {
            PhysForm.isGravity = gravityBox.Checked;
        }
        private void gBox_CheckedChanged(object sender, EventArgs e)
        {
            PhysForm.isG = gBox.Checked;
        }
        private void elBox_CheckedChanged(object sender, EventArgs e)
        {
            PhysForm.isEl = elBox.Checked;
        }
        private void fBox_CheckedChanged(object sender, EventArgs e)
        {
            PhysForm.isFriction = fBox.Checked;
        }
        private void GcBox_ValueChanged(object sender, EventArgs e)
        {
            PhysForm.G = Convert.ToDouble(GcBox.Value);
        }
        private void gxBox_ValueChanged(object sender, EventArgs e)
        {
            PhysForm.g.x = Convert.ToDouble(gxBox.Value);
        }
        private void gyBox_ValueChanged(object sender, EventArgs e)
        {
            PhysForm.g.y = Convert.ToDouble(gyBox.Value);
        }
        private void elcBox_ValueChanged(object sender, EventArgs e)
        {
            PhysForm.el = Convert.ToDouble(elcBox.Value);
        }
        private void fcBox_ValueChanged(object sender, EventArgs e)
        {
            PhysForm.k = Convert.ToDouble(fcBox.Value);
        }

        public void update()
        {
            Stopwatch sw = new Stopwatch();
            while (true)
            {
                sw.Start();
                int x0 = PhysForm.frame;
                Thread.Sleep(221);
                sw.Stop();
                int xt = PhysForm.frame;
                long fpsValue = 1000 * (xt - x0) /sw.ElapsedMilliseconds;
                fpsLbl.Text = fpsValue.ToString();
                sw.Reset();
                objNumLbl.Text = PhysForm.objs.Count.ToString();
                objNumBox.Maximum = PhysForm.objs.Count;
                PhysForm.scale = Convert.ToDouble(scaleBox.Value);
                PhysForm.kforceUp = Convert.ToDouble(upBox.Value);
                PhysForm.kforceDown = Convert.ToDouble(downBox.Value);
                PhysForm.kforceRight = Convert.ToDouble(rightBox.Value);
                PhysForm.kforceLeft = Convert.ToDouble(leftBox.Value);
                PhysForm.timeflow = Convert.ToDouble(tfBox.Value);
                PhysForm.controlNum = Convert.ToInt32(objNumBox.Value);
                if (PhysForm.objs.Count != 0)
                {
                    int n = PhysForm.controlNum;
                    if (n >= PhysForm.objs.Count)
                    {
                        n = PhysForm.objs.Count - 1;
                        objNumBox.Value = PhysForm.objs.Count - 1;
                    }
                    mLbl.Text = PhysForm.objs[n].m+" kg";
                    speedLbl.Text = Math.Round(Math.Sqrt(Math.Pow(PhysForm.objs[n].v.x, 2) + Math.Pow(PhysForm.objs[n].v.y, 2)),4) + " m/s";
                    sxLbl.Text = Math.Round(PhysForm.objs[n].s.x,4) + " m";
                    syLbl.Text = Math.Round(PhysForm.objs[n].s.y,4) + " m";
                    vxLbl.Text = Math.Round(PhysForm.objs[n].v.x,4) + " m/s";
                    vyLbl.Text = Math.Round(PhysForm.objs[n].v.y,4) + " m/s";
                    axLbl.Text = Math.Round(PhysForm.objs[n].a.x,4) + " m/s^2";
                    ayLbl.Text = Math.Round(PhysForm.objs[n].a.y,4) + " m/s^2";
                    fxLbl.Text = Math.Round(PhysForm.objs[n].f.x,4) + " N";
                    fyLbl.Text = Math.Round(PhysForm.objs[n].f.y,4) + " N";
                }
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            PhysForm.objs.Add(new PhysForm.Object(30,Vector.Zero,Vector.Zero,Vector.Zero,60,60, PhysForm.ship));
        }
        private void delBtn_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(objNumBox.Value);
            if (n >= PhysForm.objs.Count) MessageBox.Show("该编号的物体不存在","错误");
            else PhysForm.objs.RemoveAt(n);
        }
        private void delAllBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < PhysForm.objs.Count;i++)
            {
                PhysForm.objs.RemoveAt(i);
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Up:
                    return true;
                case Keys.Down:
                    return true;
                case Keys.Left:
                    return true;
                case Keys.Right:
                    return true;
                case Keys.Enter:
                    physForm.Focus();
                    return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            PhysForm.objs.Add(new PhysForm.Object(Vector.Zero, new Vector(0,1)));
        }
    }
}
