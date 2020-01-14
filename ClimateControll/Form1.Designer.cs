<<<<<<< HEAD:ClimateControll/MainFRM.Designer.cs
<<<<<<< HEAD:ClimateControll/Form1.Designer.cs
﻿namespace ClimateControll
{
    partial class Form1
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
            this.config = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnChange = new System.Windows.Forms.Button();
            this.redBtn = new System.Windows.Forms.PictureBox();
            this.greenBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.redBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // config
            // 
            this.config.Location = new System.Drawing.Point(485, 382);
            this.config.Name = "config";
            this.config.Size = new System.Drawing.Size(75, 23);
            this.config.TabIndex = 1;
            this.config.Text = "open";
            this.config.UseVisualStyleBackColor = true;
            this.config.Click += new System.EventHandler(this.config_Click);
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
            // BtnChange
            // 
            this.BtnChange.Location = new System.Drawing.Point(363, 214);
            this.BtnChange.Name = "BtnChange";
            this.BtnChange.Size = new System.Drawing.Size(75, 23);
            this.BtnChange.TabIndex = 2;
            this.BtnChange.Text = "change";
            this.BtnChange.UseVisualStyleBackColor = true;
            this.BtnChange.Click += new System.EventHandler(this.button2_Click);
            // 
            // redBtn
            // 
            this.redBtn.Image = global::ClimateControll.Properties.Resources.redBtn;
            this.redBtn.Location = new System.Drawing.Point(201, 160);
            this.redBtn.Name = "redBtn";
            this.redBtn.Size = new System.Drawing.Size(127, 105);
            this.redBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.redBtn.TabIndex = 4;
            this.redBtn.TabStop = false;
            // 
            // greenBtn
            // 
            this.greenBtn.Image = global::ClimateControll.Properties.Resources.greenBtn;
            this.greenBtn.Location = new System.Drawing.Point(201, 160);
            this.greenBtn.Name = "greenBtn";
            this.greenBtn.Size = new System.Drawing.Size(127, 105);
            this.greenBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.greenBtn.TabIndex = 5;
            this.greenBtn.TabStop = false;
         //   this.greenBtn.Click += new System.EventHandler(this.greenBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.greenBtn);
            this.Controls.Add(this.redBtn);
            this.Controls.Add(this.BtnChange);
            this.Controls.Add(this.config);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Climate Controll System";
            ((System.ComponentModel.ISupportInitialize)(this.redBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button config;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnChange;
        private System.Windows.Forms.PictureBox redBtn;
        private System.Windows.Forms.PictureBox greenBtn;
    }
}

=======
﻿namespace ClimateControll
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
            this.config.Location = new System.Drawing.Point(485, 382);
            this.config.Name = "config";
            this.config.Size = new System.Drawing.Size(75, 23);
            this.config.TabIndex = 1;
            this.config.Text = "open";
            this.config.UseVisualStyleBackColor = true;
            this.config.Click += new System.EventHandler(this.config_Click);
            // 
            // MainFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.config);
            this.Controls.Add(this.button1);
            this.Name = "MainFRM";
            this.Text = "Climate Controll System";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button config;
    }
}

>>>>>>> b40f0576c7e8db8ed8a11891e54baf9a3ec38da2:ClimateControll/MainFRM.Designer.cs
=======
﻿namespace ClimateControll
{
    partial class Form1
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
            this.config.Location = new System.Drawing.Point(485, 382);
            this.config.Name = "config";
            this.config.Size = new System.Drawing.Size(75, 23);
            this.config.TabIndex = 1;
            this.config.Text = "open";
            this.config.UseVisualStyleBackColor = true;
            this.config.Click += new System.EventHandler(this.config_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.config);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Climate Controll System";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button config;
    }
}

>>>>>>> parent of b40f057... more windows:ClimateControll/Form1.Designer.cs
