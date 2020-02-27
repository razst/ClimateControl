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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFRM));
            this.button1 = new System.Windows.Forms.Button();
            this.startBut = new System.Windows.Forms.Button();
            this.stopBut = new System.Windows.Forms.Button();
            this.TbxHum = new System.Windows.Forms.Label();
            this.TbxTemp = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.desi = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pbGreen = new System.Windows.Forms.PictureBox();
            this.config = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGreen)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("Aharoni", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(585, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // startBut
            // 
            this.startBut.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.startBut.Font = new System.Drawing.Font("Aharoni", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBut.Location = new System.Drawing.Point(22, 222);
            this.startBut.Name = "startBut";
            this.startBut.Size = new System.Drawing.Size(75, 32);
            this.startBut.TabIndex = 8;
            this.startBut.Text = "start";
            this.startBut.UseVisualStyleBackColor = false;
            this.startBut.Click += new System.EventHandler(this.startBut_Click);
            // 
            // stopBut
            // 
            this.stopBut.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stopBut.Font = new System.Drawing.Font("Aharoni", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopBut.Location = new System.Drawing.Point(211, 222);
            this.stopBut.Name = "stopBut";
            this.stopBut.Size = new System.Drawing.Size(75, 32);
            this.stopBut.TabIndex = 9;
            this.stopBut.Text = "stop";
            this.stopBut.UseVisualStyleBackColor = false;
            this.stopBut.Click += new System.EventHandler(this.stopBut_Click);
            // 
            // TbxHum
            // 
            this.TbxHum.AccessibleName = "";
            this.TbxHum.AutoSize = true;
            this.TbxHum.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TbxHum.Font = new System.Drawing.Font("Microsoft YaHei", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxHum.Location = new System.Drawing.Point(185, 97);
            this.TbxHum.Name = "TbxHum";
            this.TbxHum.Size = new System.Drawing.Size(91, 86);
            this.TbxHum.TabIndex = 13;
            this.TbxHum.Text = "...";
            // 
            // TbxTemp
            // 
            this.TbxTemp.AutoSize = true;
            this.TbxTemp.Font = new System.Drawing.Font("Microsoft YaHei", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxTemp.Location = new System.Drawing.Point(21, 97);
            this.TbxTemp.Name = "TbxTemp";
            this.TbxTemp.Size = new System.Drawing.Size(91, 86);
            this.TbxTemp.TabIndex = 14;
            this.TbxTemp.Text = "...";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.desi);
            this.panel1.Controls.Add(this.startBut);
            this.panel1.Controls.Add(this.TbxHum);
            this.panel1.Controls.Add(this.TbxTemp);
            this.panel1.Controls.Add(this.stopBut);
            this.panel1.Location = new System.Drawing.Point(205, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 278);
            this.panel1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "Humidity:";
            // 
            // desi
            // 
            this.desi.AutoSize = true;
            this.desi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desi.Location = new System.Drawing.Point(17, 59);
            this.desi.Name = "desi";
            this.desi.Size = new System.Drawing.Size(133, 29);
            this.desi.TabIndex = 15;
            this.desi.Text = "Tempture:";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ClimateControll.Properties.Resources.Aqua_Ball_Green_icon1;
            this.pictureBox1.Location = new System.Drawing.Point(33, 165);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(585, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 40);
            this.button2.TabIndex = 18;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pbGreen
            // 
            this.pbGreen.Image = global::ClimateControll.Properties.Resources.red_button2;
            this.pbGreen.Location = new System.Drawing.Point(33, 165);
            this.pbGreen.Name = "pbGreen";
            this.pbGreen.Size = new System.Drawing.Size(137, 136);
            this.pbGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGreen.TabIndex = 17;
            this.pbGreen.TabStop = false;
            this.pbGreen.Click += new System.EventHandler(this.pbGreen_Click);
            // 
            // config
            // 
            this.config.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.config.Image = ((System.Drawing.Image)(resources.GetObject("config.Image")));
            this.config.Location = new System.Drawing.Point(585, 80);
            this.config.Name = "config";
            this.config.Size = new System.Drawing.Size(75, 40);
            this.config.TabIndex = 1;
            this.config.UseVisualStyleBackColor = false;
            this.config.Click += new System.EventHandler(this.config_Click);
            // 
            // MainFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(703, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pbGreen);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.config);
            this.Controls.Add(this.button1);
            this.Name = "MainFRM";
            this.Text = "Climate Controll System";
            this.Load += new System.EventHandler(this.MainFRM_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pbGreen;
        private System.Windows.Forms.Button button2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

