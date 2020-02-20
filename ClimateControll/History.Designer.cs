namespace ClimateControll
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
            this.humRB = new System.Windows.Forms.RadioButton();
            this.tempRB = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(340, 397);
            this.dataGridView1.TabIndex = 0;
            // 
            // to
            // 
            this.to.AutoSize = true;
            this.to.Location = new System.Drawing.Point(210, 36);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(19, 13);
            this.to.TabIndex = 2;
            this.to.Text = "to:";
            // 
            // from
            // 
            this.from.AutoSize = true;
            this.from.Location = new System.Drawing.Point(125, 36);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(33, 13);
            this.from.TabIndex = 3;
            this.from.Text = "from: ";
            // 
            // minTxb
            // 
            this.minTxb.Location = new System.Drawing.Point(164, 32);
            this.minTxb.Name = "minTxb";
            this.minTxb.Size = new System.Drawing.Size(40, 20);
            this.minTxb.TabIndex = 4;
            // 
            // maxTxb
            // 
            this.maxTxb.Location = new System.Drawing.Point(235, 33);
            this.maxTxb.Name = "maxTxb";
            this.maxTxb.Size = new System.Drawing.Size(40, 20);
            this.maxTxb.TabIndex = 5;
            // 
            // OKbutton
            // 
            this.OKbutton.Location = new System.Drawing.Point(643, 350);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(75, 23);
            this.OKbutton.TabIndex = 6;
            this.OKbutton.Text = "show";
            this.OKbutton.UseVisualStyleBackColor = true;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tempRB);
            this.groupBox1.Controls.Add(this.humRB);
            this.groupBox1.Controls.Add(this.minTxb);
            this.groupBox1.Controls.Add(this.to);
            this.groupBox1.Controls.Add(this.from);
            this.groupBox1.Controls.Add(this.maxTxb);
            this.groupBox1.Location = new System.Drawing.Point(362, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 100);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter by";
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
            // tempRB
            // 
            this.tempRB.AutoSize = true;
            this.tempRB.Location = new System.Drawing.Point(34, 60);
            this.tempRB.Name = "tempRB";
            this.tempRB.Size = new System.Drawing.Size(76, 17);
            this.tempRB.TabIndex = 1;
            this.tempRB.Text = "Tempeture";
            this.tempRB.UseVisualStyleBackColor = true;
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.dataGridView1);
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
    }
}