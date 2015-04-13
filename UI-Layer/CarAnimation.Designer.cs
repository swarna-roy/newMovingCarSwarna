namespace UI_Layer
{
    partial class CarAnimation
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
            this.components = new System.ComponentModel.Container();
            this.carPanel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.StartBtn = new System.Windows.Forms.Button();
            this.StopBtn = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.Speed_comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CurrentInfo = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel24 = new System.Windows.Forms.Panel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel23 = new System.Windows.Forms.Panel();
            this.panel22 = new System.Windows.Forms.Panel();
            this.panel21 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel22.SuspendLayout();
            this.SuspendLayout();
            // 
            // carPanel
            // 
            this.carPanel.BackColor = System.Drawing.Color.Black;
            this.carPanel.Location = new System.Drawing.Point(12, 12);
            this.carPanel.Name = "carPanel";
            this.carPanel.Size = new System.Drawing.Size(307, 260);
            this.carPanel.TabIndex = 5;
            this.carPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.carPanel_Paint);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(125, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Speed :";
            // 
            // StartBtn
            // 
            this.StartBtn.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StartBtn.Location = new System.Drawing.Point(913, 8);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(103, 36);
            this.StartBtn.TabIndex = 3;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // StopBtn
            // 
            this.StopBtn.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StopBtn.Location = new System.Drawing.Point(913, 53);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(103, 34);
            this.StopBtn.TabIndex = 5;
            this.StopBtn.Text = "Stop";
            this.StopBtn.UseVisualStyleBackColor = true;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SaveButton.Location = new System.Drawing.Point(198, 46);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(122, 33);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Speed_comboBox1
            // 
            this.Speed_comboBox1.DropDownWidth = 122;
            this.Speed_comboBox1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Speed_comboBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Speed_comboBox1.FormattingEnabled = true;
            this.Speed_comboBox1.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100"});
            this.Speed_comboBox1.Location = new System.Drawing.Point(198, 13);
            this.Speed_comboBox1.Name = "Speed_comboBox1";
            this.Speed_comboBox1.Size = new System.Drawing.Size(122, 27);
            this.Speed_comboBox1.TabIndex = 5;
            this.Speed_comboBox1.SelectedIndexChanged += new System.EventHandler(this.Speed_comboBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aqua;
            this.panel1.Controls.Add(this.CurrentInfo);
            this.panel1.Controls.Add(this.StartBtn);
            this.panel1.Controls.Add(this.Speed_comboBox1);
            this.panel1.Controls.Add(this.SaveButton);
            this.panel1.Controls.Add(this.StopBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 604);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1268, 90);
            this.panel1.TabIndex = 6;
            // 
            // CurrentInfo
            // 
            this.CurrentInfo.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentInfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CurrentInfo.Location = new System.Drawing.Point(374, 32);
            this.CurrentInfo.Name = "CurrentInfo";
            this.CurrentInfo.Size = new System.Drawing.Size(494, 26);
            this.CurrentInfo.TabIndex = 6;
            this.CurrentInfo.TextChanged += new System.EventHandler(this.CurrentInfo_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.panel16);
            this.panel2.Controls.Add(this.panel14);
            this.panel2.Controls.Add(this.panel13);
            this.panel2.Location = new System.Drawing.Point(2, 452);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(387, 159);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel16.Location = new System.Drawing.Point(0, 0);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(17, 146);
            this.panel16.TabIndex = 17;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel14.Location = new System.Drawing.Point(3, 131);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(381, 19);
            this.panel14.TabIndex = 16;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel13.Controls.Add(this.panel17);
            this.panel13.Controls.Add(this.panel15);
            this.panel13.Location = new System.Drawing.Point(3, 3);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(384, 19);
            this.panel13.TabIndex = 15;
            this.panel13.Paint += new System.Windows.Forms.PaintEventHandler(this.panel13_Paint);
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel17.Location = new System.Drawing.Point(356, 28);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(12, 115);
            this.panel17.TabIndex = 18;
            // 
            // panel15
            // 
            this.panel15.Location = new System.Drawing.Point(356, 25);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(25, 100);
            this.panel15.TabIndex = 0;
            this.panel15.Paint += new System.Windows.Forms.PaintEventHandler(this.panel15_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.panel10);
            this.panel3.Location = new System.Drawing.Point(0, 21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(19, 264);
            this.panel3.TabIndex = 8;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel10
            // 
            this.panel10.Location = new System.Drawing.Point(15, 244);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(200, 20);
            this.panel10.TabIndex = 12;
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(483, 21);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(81, 31);
            this.panel7.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(227, 23);
            this.panel4.TabIndex = 9;
            // 
            // panel8
            // 
            this.panel8.Location = new System.Drawing.Point(685, 37);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(22, 15);
            this.panel8.TabIndex = 12;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel5.Controls.Add(this.panel24);
            this.panel5.Controls.Add(this.panel20);
            this.panel5.Controls.Add(this.panel19);
            this.panel5.Controls.Add(this.panel18);
            this.panel5.Location = new System.Drawing.Point(894, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(535, 240);
            this.panel5.TabIndex = 10;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint_1);
            // 
            // panel24
            // 
            this.panel24.Location = new System.Drawing.Point(46, 54);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(341, 110);
            this.panel24.TabIndex = 12;
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel20.Location = new System.Drawing.Point(32, 214);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(436, 23);
            this.panel20.TabIndex = 1;
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel19.Location = new System.Drawing.Point(3, 6);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(26, 231);
            this.panel19.TabIndex = 0;
            this.panel19.Paint += new System.Windows.Forms.PaintEventHandler(this.panel19_Paint);
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel18.Location = new System.Drawing.Point(6, 3);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(462, 17);
            this.panel18.TabIndex = 0;
            this.panel18.Paint += new System.Windows.Forms.PaintEventHandler(this.panel18_Paint);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel6.Location = new System.Drawing.Point(211, 21);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(19, 264);
            this.panel6.TabIndex = 11;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel9.Controls.Add(this.panel3);
            this.panel9.Controls.Add(this.panel4);
            this.panel9.Controls.Add(this.panel6);
            this.panel9.Location = new System.Drawing.Point(531, 145);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(227, 240);
            this.panel9.TabIndex = 13;
            this.panel9.Paint += new System.Windows.Forms.PaintEventHandler(this.panel9_Paint);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Controls.Add(this.panel23);
            this.panel11.Controls.Add(this.panel22);
            this.panel11.Location = new System.Drawing.Point(1096, 251);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(266, 347);
            this.panel11.TabIndex = 14;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel12.Location = new System.Drawing.Point(353, 20);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(24, 239);
            this.panel12.TabIndex = 15;
            // 
            // panel23
            // 
            this.panel23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel23.Location = new System.Drawing.Point(20, 0);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(360, 25);
            this.panel23.TabIndex = 2;
            // 
            // panel22
            // 
            this.panel22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel22.Controls.Add(this.panel21);
            this.panel22.Location = new System.Drawing.Point(0, 0);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(23, 340);
            this.panel22.TabIndex = 12;
            // 
            // panel21
            // 
            this.panel21.Location = new System.Drawing.Point(20, 206);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(327, 22);
            this.panel21.TabIndex = 0;
            // 
            // CarAnimation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1354, 695);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.carPanel);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.KeyPreview = true;
            this.Name = "CarAnimation";
            this.ShowIcon = false;
            this.Text = "Car Moving";
            this.Load += new System.EventHandler(this.CarAnimation_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CarAnimation_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CarAnimation_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel22.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel carPanel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button StopBtn;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.ComboBox Speed_comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox CurrentInfo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Panel panel24;
    }
}

