namespace ClimateControll
{
    partial class MainFRM
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
            this.button1 = new System.Windows.Forms.Button();
            this.config = new System.Windows.Forms.Button();
            this.startBut = new System.Windows.Forms.Button();
            this.stopBut = new System.Windows.Forms.Button();
            this.TbxHum = new System.Windows.Forms.Label();
            this.TbxTemp = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.desi = new System.Windows.Forms.Label();
            this.pbRed = new System.Windows.Forms.PictureBox();
            this.pbGreen = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGreen)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(80, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // config
            // 
            this.config.Location = new System.Drawing.Point(266, 382);
            this.config.Name = "config";
            this.config.Size = new System.Drawing.Size(75, 23);
            this.config.TabIndex = 1;
            this.config.Text = "sttenigs";
            this.config.UseVisualStyleBackColor = true;
            this.config.Click += new System.EventHandler(this.config_Click);
            // 
            // startBut
            // 
            this.startBut.Location = new System.Drawing.Point(3, 148);
            this.startBut.Name = "startBut";
            this.startBut.Size = new System.Drawing.Size(75, 23);
            this.startBut.TabIndex = 8;
            this.startBut.Text = "start";
            this.startBut.UseVisualStyleBackColor = true;
            this.startBut.Click += new System.EventHandler(this.startBut_Click);
            // 
            // stopBut
            // 
            this.stopBut.Location = new System.Drawing.Point(122, 148);
            this.stopBut.Name = "stopBut";
            this.stopBut.Size = new System.Drawing.Size(75, 23);
            this.stopBut.TabIndex = 9;
            this.stopBut.Text = "stop";
            this.stopBut.UseVisualStyleBackColor = true;
            this.stopBut.Click += new System.EventHandler(this.stopBut_Click);
            // 
            // TbxHum
            // 
            this.TbxHum.AccessibleName = "";
            this.TbxHum.AutoSize = true;
            this.TbxHum.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TbxHum.Location = new System.Drawing.Point(151, 64);
            this.TbxHum.Name = "TbxHum";
            this.TbxHum.Size = new System.Drawing.Size(16, 13);
            this.TbxHum.TabIndex = 13;
            this.TbxHum.Text = "...";
            // 
            // TbxTemp
            // 
            this.TbxTemp.AutoSize = true;
            this.TbxTemp.Location = new System.Drawing.Point(28, 64);
            this.TbxTemp.Name = "TbxTemp";
            this.TbxTemp.Size = new System.Drawing.Size(16, 13);
            this.TbxTemp.TabIndex = 14;
            this.TbxTemp.Text = "...";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.desi);
            this.panel1.Controls.Add(this.startBut);
            this.panel1.Controls.Add(this.TbxHum);
            this.panel1.Controls.Add(this.TbxTemp);
            this.panel1.Controls.Add(this.stopBut);
            this.panel1.Location = new System.Drawing.Point(203, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 174);
            this.panel1.TabIndex = 15;
            // 
            // desi
            // 
            this.desi.AutoSize = true;
            this.desi.Location = new System.Drawing.Point(19, 34);
            this.desi.Name = "desi";
            this.desi.Size = new System.Drawing.Size(55, 13);
            this.desi.TabIndex = 15;
            this.desi.Text = "Tempture:";
            // 
            // pbRed
            // 
            this.pbRed.Image = global::ClimateControll.Properties.Resources.red_button;
            this.pbRed.Location = new System.Drawing.Point(482, 174);
            this.pbRed.Name = "pbRed";
            this.pbRed.Size = new System.Drawing.Size(100, 89);
            this.pbRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRed.TabIndex = 16;
            this.pbRed.TabStop = false;
            // 
            // pbGreen
            // 
            this.pbGreen.Image = global::ClimateControll.Properties.Resources.green_button;
            this.pbGreen.Location = new System.Drawing.Point(482, 174);
            this.pbGreen.Name = "pbGreen";
            this.pbGreen.Size = new System.Drawing.Size(100, 89);
            this.pbGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGreen.TabIndex = 17;
            this.pbGreen.TabStop = false;
            this.pbGreen.Click += new System.EventHandler(this.pbGreen_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(448, 382);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // MainFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pbGreen);
            this.Controls.Add(this.pbRed);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.config);
            this.Controls.Add(this.button1);
            this.Name = "MainFRM";
            this.Text = "Climate Controll System";
            this.Load += new System.EventHandler(this.MainFRM_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGreen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button config;
        private System.Windows.Forms.Button startBut;
        private System.Windows.Forms.Button stopBut;
        private System.Windows.Forms.Label TbxHum;
        private System.Windows.Forms.Label TbxTemp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label desi;
        private System.Windows.Forms.PictureBox pbRed;
        private System.Windows.Forms.PictureBox pbGreen;
        private System.Windows.Forms.Button button2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

