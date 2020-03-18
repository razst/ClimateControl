namespace ClimateControll
{
    partial class SettingsFRM
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
            this.CbAlert = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TbxMailAdress = new System.Windows.Forms.TextBox();
            this.CbMail = new System.Windows.Forms.CheckBox();
            this.TbMaxHumidity = new System.Windows.Forms.TextBox();
            this.TbMinHumidity = new System.Windows.Forms.TextBox();
            this.TbMaxTemp = new System.Windows.Forms.TextBox();
            this.TbMinTemp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPortName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CbTestMode = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.RanMinTemp = new System.Windows.Forms.TextBox();
            this.RanMaxTemp = new System.Windows.Forms.TextBox();
            this.RanMinHum = new System.Windows.Forms.TextBox();
            this.RanMaxHum = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // CbAlert
            // 
            this.CbAlert.AutoSize = true;
            this.CbAlert.Location = new System.Drawing.Point(12, 54);
            this.CbAlert.Name = "CbAlert";
            this.CbAlert.Size = new System.Drawing.Size(69, 17);
            this.CbAlert.TabIndex = 25;
            this.CbAlert.Text = "start alert";
            this.CbAlert.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "in case of deviation:";
            // 
            // TbxMailAdress
            // 
            this.TbxMailAdress.Location = new System.Drawing.Point(103, 18);
            this.TbxMailAdress.Name = "TbxMailAdress";
            this.TbxMailAdress.Size = new System.Drawing.Size(141, 20);
            this.TbxMailAdress.TabIndex = 23;
            this.TbxMailAdress.TextChanged += new System.EventHandler(this.TbMailAdress_TextChanged);
            // 
            // CbMail
            // 
            this.CbMail.AutoSize = true;
            this.CbMail.Location = new System.Drawing.Point(12, 21);
            this.CbMail.Name = "CbMail";
            this.CbMail.Size = new System.Drawing.Size(85, 17);
            this.CbMail.TabIndex = 22;
            this.CbMail.Text = "send mail to:";
            this.CbMail.UseVisualStyleBackColor = true;
            // 
            // TbMaxHumidity
            // 
            this.TbMaxHumidity.Location = new System.Drawing.Point(95, 130);
            this.TbMaxHumidity.Name = "TbMaxHumidity";
            this.TbMaxHumidity.Size = new System.Drawing.Size(100, 20);
            this.TbMaxHumidity.TabIndex = 21;
            // 
            // TbMinHumidity
            // 
            this.TbMinHumidity.Location = new System.Drawing.Point(95, 86);
            this.TbMinHumidity.Name = "TbMinHumidity";
            this.TbMinHumidity.Size = new System.Drawing.Size(100, 20);
            this.TbMinHumidity.TabIndex = 20;
            // 
            // TbMaxTemp
            // 
            this.TbMaxTemp.Location = new System.Drawing.Point(95, 47);
            this.TbMaxTemp.Name = "TbMaxTemp";
            this.TbMaxTemp.Size = new System.Drawing.Size(100, 20);
            this.TbMaxTemp.TabIndex = 19;
            // 
            // TbMinTemp
            // 
            this.TbMinTemp.Location = new System.Drawing.Point(95, 11);
            this.TbMinTemp.Name = "TbMinTemp";
            this.TbMinTemp.Size = new System.Drawing.Size(100, 20);
            this.TbMinTemp.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "max humidity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "min humidity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "max temp:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "min temp:";
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(37, 8);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 26;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(185, 8);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 27;
            this.CancelButton.Text = "cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "port:";
            // 
            // tbPortName
            // 
            this.tbPortName.Location = new System.Drawing.Point(95, 173);
            this.tbPortName.Name = "tbPortName";
            this.tbPortName.Size = new System.Drawing.Size(100, 20);
            this.tbPortName.TabIndex = 28;
            this.tbPortName.Text = "COM";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbPortName);
            this.panel1.Controls.Add(this.TbMaxHumidity);
            this.panel1.Controls.Add(this.TbMinHumidity);
            this.panel1.Controls.Add(this.TbMaxTemp);
            this.panel1.Controls.Add(this.TbMinTemp);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(29, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 361);
            this.panel1.TabIndex = 30;
            // 
            // CbTestMode
            // 
            this.CbTestMode.AutoSize = true;
            this.CbTestMode.Checked = true;
            this.CbTestMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbTestMode.Location = new System.Drawing.Point(396, 18);
            this.CbTestMode.Name = "CbTestMode";
            this.CbTestMode.Size = new System.Drawing.Size(76, 17);
            this.CbTestMode.TabIndex = 31;
            this.CbTestMode.Text = "Test mode";
            this.CbTestMode.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.CbAlert);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.TbxMailAdress);
            this.panel2.Controls.Add(this.CbMail);
            this.panel2.Location = new System.Drawing.Point(14, 270);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(262, 86);
            this.panel2.TabIndex = 30;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.CancelButton);
            this.panel3.Controls.Add(this.OKButton);
            this.panel3.Location = new System.Drawing.Point(29, 371);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(293, 39);
            this.panel3.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(343, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "temp:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(340, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "humidity:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(430, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "to:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(430, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "to:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(343, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "from:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(340, 150);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 36;
            this.label12.Text = "from:";
            // 
            // RanMinTemp
            // 
            this.RanMinTemp.Location = new System.Drawing.Point(379, 81);
            this.RanMinTemp.Name = "RanMinTemp";
            this.RanMinTemp.Size = new System.Drawing.Size(45, 20);
            this.RanMinTemp.TabIndex = 37;
            // 
            // RanMaxTemp
            // 
            this.RanMaxTemp.Location = new System.Drawing.Point(455, 81);
            this.RanMaxTemp.Name = "RanMaxTemp";
            this.RanMaxTemp.Size = new System.Drawing.Size(45, 20);
            this.RanMaxTemp.TabIndex = 38;
            // 
            // RanMinHum
            // 
            this.RanMinHum.Location = new System.Drawing.Point(379, 143);
            this.RanMinHum.Name = "RanMinHum";
            this.RanMinHum.Size = new System.Drawing.Size(45, 20);
            this.RanMinHum.TabIndex = 39;
            // 
            // RanMaxHum
            // 
            this.RanMaxHum.Location = new System.Drawing.Point(455, 142);
            this.RanMaxHum.Name = "RanMaxHum";
            this.RanMaxHum.Size = new System.Drawing.Size(45, 20);
            this.RanMaxHum.TabIndex = 40;
            // 
            // SettingsFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 477);
            this.Controls.Add(this.RanMaxHum);
            this.Controls.Add(this.RanMinHum);
            this.Controls.Add(this.RanMaxTemp);
            this.Controls.Add(this.RanMinTemp);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CbTestMode);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingsFRM";
            this.Text = "SettingsFRM";
            this.Load += new System.EventHandler(this.SettingsFRM_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CbAlert;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TbxMailAdress;
        private System.Windows.Forms.CheckBox CbMail;
        private System.Windows.Forms.TextBox TbMaxHumidity;
        private System.Windows.Forms.TextBox TbMinHumidity;
        private System.Windows.Forms.TextBox TbMaxTemp;
        private System.Windows.Forms.TextBox TbMinTemp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPortName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox CbTestMode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox RanMinTemp;
        private System.Windows.Forms.TextBox RanMaxTemp;
        private System.Windows.Forms.TextBox RanMinHum;
        private System.Windows.Forms.TextBox RanMaxHum;
    }
}