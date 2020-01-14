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
            this.TbMailAdress = new System.Windows.Forms.TextBox();
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
            this.SuspendLayout();
            // 
            // CbAlert
            // 
            this.CbAlert.AutoSize = true;
            this.CbAlert.Location = new System.Drawing.Point(57, 313);
            this.CbAlert.Name = "CbAlert";
            this.CbAlert.Size = new System.Drawing.Size(69, 17);
            this.CbAlert.TabIndex = 25;
            this.CbAlert.Text = "start alert";
            this.CbAlert.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "in case of deviation:";
            // 
            // TbMailAdress
            // 
            this.TbMailAdress.Location = new System.Drawing.Point(148, 277);
            this.TbMailAdress.Name = "TbMailAdress";
            this.TbMailAdress.Size = new System.Drawing.Size(100, 20);
            this.TbMailAdress.TabIndex = 23;
            // 
            // CbMail
            // 
            this.CbMail.AutoSize = true;
            this.CbMail.Location = new System.Drawing.Point(57, 280);
            this.CbMail.Name = "CbMail";
            this.CbMail.Size = new System.Drawing.Size(85, 17);
            this.CbMail.TabIndex = 22;
            this.CbMail.Text = "send mail to:";
            this.CbMail.UseVisualStyleBackColor = true;
            // 
            // TbMaxHumidity
            // 
            this.TbMaxHumidity.Location = new System.Drawing.Point(125, 186);
            this.TbMaxHumidity.Name = "TbMaxHumidity";
            this.TbMaxHumidity.Size = new System.Drawing.Size(100, 20);
            this.TbMaxHumidity.TabIndex = 21;
            // 
            // TbMinHumidity
            // 
            this.TbMinHumidity.Location = new System.Drawing.Point(125, 142);
            this.TbMinHumidity.Name = "TbMinHumidity";
            this.TbMinHumidity.Size = new System.Drawing.Size(100, 20);
            this.TbMinHumidity.TabIndex = 20;
            // 
            // TbMaxTemp
            // 
            this.TbMaxTemp.Location = new System.Drawing.Point(125, 103);
            this.TbMaxTemp.Name = "TbMaxTemp";
            this.TbMaxTemp.Size = new System.Drawing.Size(100, 20);
            this.TbMaxTemp.TabIndex = 19;
            // 
            // TbMinTemp
            // 
            this.TbMinTemp.Location = new System.Drawing.Point(125, 67);
            this.TbMinTemp.Name = "TbMinTemp";
            this.TbMinTemp.Size = new System.Drawing.Size(100, 20);
            this.TbMinTemp.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "max humidity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "min humidity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "max temp:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "min temp:";
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(125, 386);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 26;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(341, 386);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 27;
            this.CancelButton.Text = "cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "port:";
            // 
            // tbPortName
            // 
            this.tbPortName.Location = new System.Drawing.Point(125, 229);
            this.tbPortName.Name = "tbPortName";
            this.tbPortName.Size = new System.Drawing.Size(100, 20);
            this.tbPortName.TabIndex = 28;
            this.tbPortName.Text = "COM";
            // 
            // SettingsFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbPortName);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.CbAlert);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TbMailAdress);
            this.Controls.Add(this.CbMail);
            this.Controls.Add(this.TbMaxHumidity);
            this.Controls.Add(this.TbMinHumidity);
            this.Controls.Add(this.TbMaxTemp);
            this.Controls.Add(this.TbMinTemp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SettingsFRM";
            this.Text = "SettingsFRM";
            this.Load += new System.EventHandler(this.SettingsFRM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CbAlert;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TbMailAdress;
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
    }
}