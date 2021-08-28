namespace DXT472
{
    partial class ControlForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlForm));
            this.gBox = new System.Windows.Forms.CheckBox();
            this.elBox = new System.Windows.Forms.CheckBox();
            this.fBox = new System.Windows.Forms.CheckBox();
            this.gravityBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fpsLbl = new System.Windows.Forms.Label();
            this.objNumLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GcBox = new System.Windows.Forms.NumericUpDown();
            this.gxBox = new System.Windows.Forms.NumericUpDown();
            this.elcBox = new System.Windows.Forms.NumericUpDown();
            this.fcBox = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gyBox = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.mLbl = new System.Windows.Forms.Label();
            this.fyLbl = new System.Windows.Forms.Label();
            this.fxLbl = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.ayLbl = new System.Windows.Forms.Label();
            this.vyLbl = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.syLbl = new System.Windows.Forms.Label();
            this.sxLbl = new System.Windows.Forms.Label();
            this.speedLbl = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.axLbl = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.vxLbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.objNumBox = new System.Windows.Forms.NumericUpDown();
            this.delBtn = new System.Windows.Forms.Button();
            this.delAllBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.scaleBox = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.leftBox = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.upBox = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.downBox = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.rightBox = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tfBox = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GcBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gxBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elcBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fcBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gyBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objNumBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfBox)).BeginInit();
            this.SuspendLayout();
            // 
            // gBox
            // 
            this.gBox.AutoSize = true;
            this.gBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gBox.Location = new System.Drawing.Point(12, 39);
            this.gBox.Name = "gBox";
            this.gBox.Size = new System.Drawing.Size(87, 21);
            this.gBox.TabIndex = 0;
            this.gBox.Text = "重力加速度";
            this.gBox.UseVisualStyleBackColor = true;
            this.gBox.CheckedChanged += new System.EventHandler(this.gBox_CheckedChanged);
            // 
            // elBox
            // 
            this.elBox.AutoSize = true;
            this.elBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.elBox.Location = new System.Drawing.Point(12, 66);
            this.elBox.Name = "elBox";
            this.elBox.Size = new System.Drawing.Size(75, 21);
            this.elBox.TabIndex = 1;
            this.elBox.Text = "弹性衰减";
            this.elBox.UseVisualStyleBackColor = true;
            this.elBox.CheckedChanged += new System.EventHandler(this.elBox_CheckedChanged);
            // 
            // fBox
            // 
            this.fBox.AutoSize = true;
            this.fBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fBox.Location = new System.Drawing.Point(12, 93);
            this.fBox.Name = "fBox";
            this.fBox.Size = new System.Drawing.Size(75, 21);
            this.fBox.TabIndex = 2;
            this.fBox.Text = "空气阻力";
            this.fBox.UseVisualStyleBackColor = true;
            this.fBox.CheckedChanged += new System.EventHandler(this.fBox_CheckedChanged);
            // 
            // gravityBox
            // 
            this.gravityBox.AutoSize = true;
            this.gravityBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gravityBox.Location = new System.Drawing.Point(12, 12);
            this.gravityBox.Name = "gravityBox";
            this.gravityBox.Size = new System.Drawing.Size(51, 21);
            this.gravityBox.TabIndex = 3;
            this.gravityBox.Text = "引力";
            this.gravityBox.UseVisualStyleBackColor = true;
            this.gravityBox.CheckedChanged += new System.EventHandler(this.gravityBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(733, 531);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "FPS:";
            // 
            // fpsLbl
            // 
            this.fpsLbl.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fpsLbl.Location = new System.Drawing.Point(770, 531);
            this.fpsLbl.Name = "fpsLbl";
            this.fpsLbl.Size = new System.Drawing.Size(31, 17);
            this.fpsLbl.TabIndex = 5;
            this.fpsLbl.Text = "/";
            // 
            // objNumLbl
            // 
            this.objNumLbl.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.objNumLbl.Location = new System.Drawing.Point(480, 9);
            this.objNumLbl.Name = "objNumLbl";
            this.objNumLbl.Size = new System.Drawing.Size(31, 17);
            this.objNumLbl.TabIndex = 7;
            this.objNumLbl.Text = "/";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(418, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "物体数量";
            // 
            // GcBox
            // 
            this.GcBox.DecimalPlaces = 3;
            this.GcBox.Location = new System.Drawing.Point(310, 14);
            this.GcBox.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.GcBox.Name = "GcBox";
            this.GcBox.Size = new System.Drawing.Size(86, 21);
            this.GcBox.TabIndex = 8;
            this.GcBox.ValueChanged += new System.EventHandler(this.GcBox_ValueChanged);
            // 
            // gxBox
            // 
            this.gxBox.DecimalPlaces = 3;
            this.gxBox.Location = new System.Drawing.Point(146, 39);
            this.gxBox.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.gxBox.Minimum = new decimal(new int[] {
            1000000000,
            0,
            0,
            -2147483648});
            this.gxBox.Name = "gxBox";
            this.gxBox.Size = new System.Drawing.Size(86, 21);
            this.gxBox.TabIndex = 9;
            this.gxBox.ValueChanged += new System.EventHandler(this.gxBox_ValueChanged);
            // 
            // elcBox
            // 
            this.elcBox.DecimalPlaces = 3;
            this.elcBox.Location = new System.Drawing.Point(310, 69);
            this.elcBox.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.elcBox.Name = "elcBox";
            this.elcBox.Size = new System.Drawing.Size(86, 21);
            this.elcBox.TabIndex = 10;
            this.elcBox.ValueChanged += new System.EventHandler(this.elcBox_ValueChanged);
            // 
            // fcBox
            // 
            this.fcBox.DecimalPlaces = 3;
            this.fcBox.Location = new System.Drawing.Point(310, 95);
            this.fcBox.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.fcBox.Name = "fcBox";
            this.fcBox.Size = new System.Drawing.Size(86, 21);
            this.fcBox.TabIndex = 11;
            this.fcBox.ValueChanged += new System.EventHandler(this.fcBox_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(248, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "引力常数";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(126, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "x";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(290, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "y";
            // 
            // gyBox
            // 
            this.gyBox.DecimalPlaces = 3;
            this.gyBox.Location = new System.Drawing.Point(310, 41);
            this.gyBox.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.gyBox.Minimum = new decimal(new int[] {
            1000000000,
            0,
            0,
            -2147483648});
            this.gyBox.Name = "gyBox";
            this.gyBox.Size = new System.Drawing.Size(86, 21);
            this.gyBox.TabIndex = 14;
            this.gyBox.ValueChanged += new System.EventHandler(this.gyBox_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(248, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "弹性系数";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(224, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "空气阻力系数";
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addBtn.Location = new System.Drawing.Point(303, 434);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(50, 36);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "添加";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.mLbl);
            this.groupBox1.Controls.Add(this.fyLbl);
            this.groupBox1.Controls.Add(this.fxLbl);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.ayLbl);
            this.groupBox1.Controls.Add(this.vyLbl);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.syLbl);
            this.groupBox1.Controls.Add(this.sxLbl);
            this.groupBox1.Controls.Add(this.speedLbl);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.axLbl);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.vxLbl);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(421, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 235);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "物理信息";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(14, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 17);
            this.label10.TabIndex = 36;
            this.label10.Text = "质量";
            // 
            // mLbl
            // 
            this.mLbl.AutoSize = true;
            this.mLbl.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mLbl.Location = new System.Drawing.Point(75, 28);
            this.mLbl.Name = "mLbl";
            this.mLbl.Size = new System.Drawing.Size(14, 17);
            this.mLbl.TabIndex = 35;
            this.mLbl.Text = "/";
            // 
            // fyLbl
            // 
            this.fyLbl.AutoSize = true;
            this.fyLbl.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fyLbl.Location = new System.Drawing.Point(218, 206);
            this.fyLbl.Name = "fyLbl";
            this.fyLbl.Size = new System.Drawing.Size(14, 17);
            this.fyLbl.TabIndex = 34;
            this.fyLbl.Text = "/";
            // 
            // fxLbl
            // 
            this.fxLbl.AutoSize = true;
            this.fxLbl.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fxLbl.Location = new System.Drawing.Point(76, 206);
            this.fxLbl.Name = "fxLbl";
            this.fxLbl.Size = new System.Drawing.Size(14, 17);
            this.fxLbl.TabIndex = 33;
            this.fxLbl.Text = "/";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label22.Location = new System.Drawing.Point(14, 206);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(44, 17);
            this.label22.TabIndex = 32;
            this.label22.Text = "合外力";
            // 
            // ayLbl
            // 
            this.ayLbl.AutoSize = true;
            this.ayLbl.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ayLbl.Location = new System.Drawing.Point(218, 176);
            this.ayLbl.Name = "ayLbl";
            this.ayLbl.Size = new System.Drawing.Size(14, 17);
            this.ayLbl.TabIndex = 30;
            this.ayLbl.Text = "/";
            // 
            // vyLbl
            // 
            this.vyLbl.AutoSize = true;
            this.vyLbl.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.vyLbl.Location = new System.Drawing.Point(218, 148);
            this.vyLbl.Name = "vyLbl";
            this.vyLbl.Size = new System.Drawing.Size(14, 17);
            this.vyLbl.TabIndex = 29;
            this.vyLbl.Text = "/";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(14, 54);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 17);
            this.label16.TabIndex = 28;
            this.label16.Text = "速率";
            // 
            // syLbl
            // 
            this.syLbl.AutoSize = true;
            this.syLbl.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.syLbl.Location = new System.Drawing.Point(219, 122);
            this.syLbl.Name = "syLbl";
            this.syLbl.Size = new System.Drawing.Size(14, 17);
            this.syLbl.TabIndex = 26;
            this.syLbl.Text = "/";
            // 
            // sxLbl
            // 
            this.sxLbl.AutoSize = true;
            this.sxLbl.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sxLbl.Location = new System.Drawing.Point(76, 122);
            this.sxLbl.Name = "sxLbl";
            this.sxLbl.Size = new System.Drawing.Size(14, 17);
            this.sxLbl.TabIndex = 25;
            this.sxLbl.Text = "/";
            // 
            // speedLbl
            // 
            this.speedLbl.AutoSize = true;
            this.speedLbl.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.speedLbl.Location = new System.Drawing.Point(75, 54);
            this.speedLbl.Name = "speedLbl";
            this.speedLbl.Size = new System.Drawing.Size(14, 17);
            this.speedLbl.TabIndex = 27;
            this.speedLbl.Text = "/";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(14, 122);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 17);
            this.label13.TabIndex = 24;
            this.label13.Text = "位置";
            // 
            // axLbl
            // 
            this.axLbl.AutoSize = true;
            this.axLbl.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.axLbl.Location = new System.Drawing.Point(76, 176);
            this.axLbl.Name = "axLbl";
            this.axLbl.Size = new System.Drawing.Size(14, 17);
            this.axLbl.TabIndex = 23;
            this.axLbl.Text = "/";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(14, 176);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "加速度";
            // 
            // vxLbl
            // 
            this.vxLbl.AutoSize = true;
            this.vxLbl.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.vxLbl.Location = new System.Drawing.Point(75, 148);
            this.vxLbl.Name = "vxLbl";
            this.vxLbl.Size = new System.Drawing.Size(14, 17);
            this.vxLbl.TabIndex = 21;
            this.vxLbl.Text = "/";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(14, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "速度";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.Location = new System.Drawing.Point(528, 10);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(80, 17);
            this.label19.TabIndex = 20;
            this.label19.Text = "选择物体编号";
            // 
            // objNumBox
            // 
            this.objNumBox.Location = new System.Drawing.Point(614, 9);
            this.objNumBox.Name = "objNumBox";
            this.objNumBox.Size = new System.Drawing.Size(47, 21);
            this.objNumBox.TabIndex = 31;
            // 
            // delBtn
            // 
            this.delBtn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.delBtn.Location = new System.Drawing.Point(667, 6);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(43, 26);
            this.delBtn.TabIndex = 20;
            this.delBtn.Text = "删除";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // delAllBtn
            // 
            this.delAllBtn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.delAllBtn.Location = new System.Drawing.Point(415, 434);
            this.delAllBtn.Name = "delAllBtn";
            this.delAllBtn.Size = new System.Drawing.Size(50, 36);
            this.delAllBtn.TabIndex = 21;
            this.delAllBtn.Text = "清屏";
            this.delAllBtn.UseVisualStyleBackColor = true;
            this.delAllBtn.Click += new System.EventHandler(this.delAllBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(421, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "坐标放缩";
            // 
            // scaleBox
            // 
            this.scaleBox.DecimalPlaces = 7;
            this.scaleBox.Location = new System.Drawing.Point(483, 42);
            this.scaleBox.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.scaleBox.Minimum = new decimal(new int[] {
            1000000000,
            0,
            0,
            -2147483648});
            this.scaleBox.Name = "scaleBox";
            this.scaleBox.Size = new System.Drawing.Size(122, 21);
            this.scaleBox.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(262, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 17);
            this.label12.TabIndex = 33;
            this.label12.Text = "右";
            // 
            // leftBox
            // 
            this.leftBox.DecimalPlaces = 3;
            this.leftBox.Location = new System.Drawing.Point(288, 50);
            this.leftBox.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.leftBox.Name = "leftBox";
            this.leftBox.Size = new System.Drawing.Size(86, 23);
            this.leftBox.TabIndex = 32;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.upBox);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.downBox);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.rightBox);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.leftBox);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(12, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 117);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "发动机推力";
            // 
            // upBox
            // 
            this.upBox.DecimalPlaces = 3;
            this.upBox.Location = new System.Drawing.Point(154, 81);
            this.upBox.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.upBox.Name = "upBox";
            this.upBox.Size = new System.Drawing.Size(86, 23);
            this.upBox.TabIndex = 38;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(128, 83);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(20, 17);
            this.label17.TabIndex = 39;
            this.label17.Text = "下";
            // 
            // downBox
            // 
            this.downBox.DecimalPlaces = 3;
            this.downBox.Location = new System.Drawing.Point(154, 20);
            this.downBox.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.downBox.Name = "downBox";
            this.downBox.Size = new System.Drawing.Size(86, 23);
            this.downBox.TabIndex = 36;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(128, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 17);
            this.label15.TabIndex = 37;
            this.label15.Text = "上";
            // 
            // rightBox
            // 
            this.rightBox.DecimalPlaces = 3;
            this.rightBox.Location = new System.Drawing.Point(33, 52);
            this.rightBox.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.rightBox.Name = "rightBox";
            this.rightBox.Size = new System.Drawing.Size(86, 23);
            this.rightBox.TabIndex = 34;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(7, 54);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(20, 17);
            this.label14.TabIndex = 35;
            this.label14.Text = "左";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(648, 43);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(32, 17);
            this.label18.TabIndex = 36;
            this.label18.Text = "倍速";
            // 
            // tfBox
            // 
            this.tfBox.DecimalPlaces = 2;
            this.tfBox.Location = new System.Drawing.Point(686, 42);
            this.tfBox.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.tfBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.tfBox.Name = "tfBox";
            this.tfBox.Size = new System.Drawing.Size(122, 21);
            this.tfBox.TabIndex = 35;
            this.tfBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(359, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 36);
            this.button1.TabIndex = 37;
            this.button1.Text = "test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 560);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.tfBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.scaleBox);
            this.Controls.Add(this.delAllBtn);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.objNumBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gyBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fcBox);
            this.Controls.Add(this.elcBox);
            this.Controls.Add(this.gxBox);
            this.Controls.Add(this.GcBox);
            this.Controls.Add(this.objNumLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fpsLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gravityBox);
            this.Controls.Add(this.fBox);
            this.Controls.Add(this.elBox);
            this.Controls.Add(this.gBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ControlForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control";
            ((System.ComponentModel.ISupportInitialize)(this.GcBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gxBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elcBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fcBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gyBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objNumBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckBox gBox;
        public System.Windows.Forms.CheckBox elBox;
        public System.Windows.Forms.CheckBox fBox;
        public System.Windows.Forms.CheckBox gravityBox;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label fpsLbl;
        public System.Windows.Forms.Label objNumLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown GcBox;
        private System.Windows.Forms.NumericUpDown gxBox;
        private System.Windows.Forms.NumericUpDown elcBox;
        private System.Windows.Forms.NumericUpDown fcBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown gyBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label vxLbl;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label axLbl;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label sxLbl;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label syLbl;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.Label speedLbl;
        public System.Windows.Forms.Label ayLbl;
        public System.Windows.Forms.Label vyLbl;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown objNumBox;
        private System.Windows.Forms.Button delBtn;
        public System.Windows.Forms.Label fyLbl;
        public System.Windows.Forms.Label fxLbl;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button delAllBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown scaleBox;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label mLbl;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown leftBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown upBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown downBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown rightBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown tfBox;
        private System.Windows.Forms.Button button1;
    }
}