﻿namespace ClimateControll
{
    partial class History
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.to = new System.Windows.Forms.Label();
            this.from = new System.Windows.Forms.Label();
            this.minTxb = new System.Windows.Forms.TextBox();
            this.maxTxb = new System.Windows.Forms.TextBox();
            this.OKbutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timeRD = new System.Windows.Forms.RadioButton();
            this.clearBtn = new System.Windows.Forms.Button();
            this.tempRB = new System.Windows.Forms.RadioButton();
            this.humRB = new System.Windows.Forms.RadioButton();
            this.minDatePicker = new System.Windows.Forms.DateTimePicker();
            this.maxDatePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(278, 436);
            this.dataGridView1.TabIndex = 0;
            // 
            // to
            // 
            this.to.AutoSize = true;
            this.to.Location = new System.Drawing.Point(261, 16);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(19, 13);
            this.to.TabIndex = 2;
            this.to.Text = "to:";
            // 
            // from
            // 
            this.from.AutoSize = true;
            this.from.Location = new System.Drawing.Point(143, 20);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(33, 13);
            this.from.TabIndex = 3;
            this.from.Text = "from: ";
            // 
            // minTxb
            // 
            this.minTxb.Location = new System.Drawing.Point(146, 36);
            this.minTxb.Name = "minTxb";
            this.minTxb.Size = new System.Drawing.Size(40, 20);
            this.minTxb.TabIndex = 4;
            // 
            // maxTxb
            // 
            this.maxTxb.Location = new System.Drawing.Point(264, 36);
            this.maxTxb.Name = "maxTxb";
            this.maxTxb.Size = new System.Drawing.Size(40, 20);
            this.maxTxb.TabIndex = 5;
            // 
            // OKbutton
            // 
            this.OKbutton.Location = new System.Drawing.Point(187, 111);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(75, 23);
            this.OKbutton.TabIndex = 6;
            this.OKbutton.Text = "show";
            this.OKbutton.UseVisualStyleBackColor = true;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maxDatePicker);
            this.groupBox1.Controls.Add(this.minDatePicker);
            this.groupBox1.Controls.Add(this.timeRD);
            this.groupBox1.Controls.Add(this.clearBtn);
            this.groupBox1.Controls.Add(this.OKbutton);
            this.groupBox1.Controls.Add(this.tempRB);
            this.groupBox1.Controls.Add(this.humRB);
            this.groupBox1.Controls.Add(this.minTxb);
            this.groupBox1.Controls.Add(this.to);
            this.groupBox1.Controls.Add(this.from);
            this.groupBox1.Controls.Add(this.maxTxb);
            this.groupBox1.Location = new System.Drawing.Point(285, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 152);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter by";
            // 
            // timeRD
            // 
            this.timeRD.AutoSize = true;
            this.timeRD.Location = new System.Drawing.Point(34, 88);
            this.timeRD.Name = "timeRD";
            this.timeRD.Size = new System.Drawing.Size(51, 17);
            this.timeRD.TabIndex = 15;
            this.timeRD.TabStop = true;
            this.timeRD.Text = "dates";
            this.timeRD.UseVisualStyleBackColor = true;
            this.timeRD.CheckedChanged += new System.EventHandler(this.timeRD_CheckedChanged);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(89, 111);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 14;
            this.clearBtn.Text = "clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // tempRB
            // 
            this.tempRB.AutoSize = true;
            this.tempRB.Location = new System.Drawing.Point(34, 54);
            this.tempRB.Name = "tempRB";
            this.tempRB.Size = new System.Drawing.Size(76, 17);
            this.tempRB.TabIndex = 1;
            this.tempRB.Text = "Tempeture";
            this.tempRB.UseVisualStyleBackColor = true;
            // 
            // humRB
            // 
            this.humRB.AutoSize = true;
            this.humRB.Checked = true;
            this.humRB.Location = new System.Drawing.Point(34, 20);
            this.humRB.Name = "humRB";
            this.humRB.Size = new System.Drawing.Size(65, 17);
            this.humRB.TabIndex = 0;
            this.humRB.TabStop = true;
            this.humRB.Text = "Humidity";
            this.humRB.UseVisualStyleBackColor = true;
            // 
            // minDatePicker
            // 
            this.minDatePicker.Location = new System.Drawing.Point(116, 36);
            this.minDatePicker.Name = "minDatePicker";
            this.minDatePicker.Size = new System.Drawing.Size(104, 20);
            this.minDatePicker.TabIndex = 14;
            this.minDatePicker.Visible = false;
            // 
            // maxDatePicker
            // 
            this.maxDatePicker.Location = new System.Drawing.Point(235, 36);
            this.maxDatePicker.Name = "maxDatePicker";
            this.maxDatePicker.Size = new System.Drawing.Size(104, 20);
            this.maxDatePicker.TabIndex = 16;
            this.maxDatePicker.Visible = false;
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "History";
            this.Text = "History";
            this.Load += new System.EventHandler(this.History_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label to;
        private System.Windows.Forms.Label from;
        private System.Windows.Forms.TextBox minTxb;
        private System.Windows.Forms.TextBox maxTxb;
        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton tempRB;
        private System.Windows.Forms.RadioButton humRB;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.RadioButton timeRD;
        private System.Windows.Forms.DateTimePicker minDatePicker;
        private System.Windows.Forms.DateTimePicker maxDatePicker;
    }
}