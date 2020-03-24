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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(History));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.to = new System.Windows.Forms.Label();
            this.from = new System.Windows.Forms.Label();
            this.minTxb = new System.Windows.Forms.TextBox();
            this.maxTxb = new System.Windows.Forms.TextBox();
            this.OKbutton = new System.Windows.Forms.Button();
            this.MainGB = new System.Windows.Forms.GroupBox();
            this.timeRD = new System.Windows.Forms.RadioButton();
            this.tempRB = new System.Windows.Forms.RadioButton();
            this.humRB = new System.Windows.Forms.RadioButton();
            this.maxDatePicker = new System.Windows.Forms.DateTimePicker();
            this.minDatePicker = new System.Windows.Forms.DateTimePicker();
            this.clearBtn = new System.Windows.Forms.Button();
            this.VarGB = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.limitsCB = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.MainGB.SuspendLayout();
            this.VarGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
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
            this.dataGridView1.Size = new System.Drawing.Size(287, 436);
            this.dataGridView1.TabIndex = 0;
            // 
            // to
            // 
            this.to.AutoSize = true;
            this.to.Location = new System.Drawing.Point(32, 87);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(19, 13);
            this.to.TabIndex = 2;
            this.to.Text = "to:";
            // 
            // from
            // 
            this.from.AutoSize = true;
            this.from.Location = new System.Drawing.Point(23, 42);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(33, 13);
            this.from.TabIndex = 3;
            this.from.Text = "from: ";
            // 
            // minTxb
            // 
            this.minTxb.Location = new System.Drawing.Point(52, 41);
            this.minTxb.Name = "minTxb";
            this.minTxb.Size = new System.Drawing.Size(40, 20);
            this.minTxb.TabIndex = 4;
            // 
            // maxTxb
            // 
            this.maxTxb.Location = new System.Drawing.Point(52, 83);
            this.maxTxb.Name = "maxTxb";
            this.maxTxb.Size = new System.Drawing.Size(40, 20);
            this.maxTxb.TabIndex = 5;
            // 
            // OKbutton
            // 
            this.OKbutton.Location = new System.Drawing.Point(494, 250);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(75, 23);
            this.OKbutton.TabIndex = 6;
            this.OKbutton.Text = "show";
            this.OKbutton.UseVisualStyleBackColor = true;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // MainGB
            // 
            this.MainGB.Controls.Add(this.timeRD);
            this.MainGB.Controls.Add(this.tempRB);
            this.MainGB.Controls.Add(this.humRB);
            this.MainGB.Location = new System.Drawing.Point(305, 28);
            this.MainGB.Name = "MainGB";
            this.MainGB.Size = new System.Drawing.Size(138, 125);
            this.MainGB.TabIndex = 13;
            this.MainGB.TabStop = false;
            this.MainGB.Text = "Filter by";
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
            // maxDatePicker
            // 
            this.maxDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.maxDatePicker.Location = new System.Drawing.Point(52, 83);
            this.maxDatePicker.Name = "maxDatePicker";
            this.maxDatePicker.Size = new System.Drawing.Size(104, 20);
            this.maxDatePicker.TabIndex = 16;
            this.maxDatePicker.Visible = false;
            // 
            // minDatePicker
            // 
            this.minDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.minDatePicker.Location = new System.Drawing.Point(52, 41);
            this.minDatePicker.Name = "minDatePicker";
            this.minDatePicker.Size = new System.Drawing.Size(104, 20);
            this.minDatePicker.TabIndex = 14;
            this.minDatePicker.Visible = false;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(368, 250);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 14;
            this.clearBtn.Text = "clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Visible = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // VarGB
            // 
            this.VarGB.Controls.Add(this.minDatePicker);
            this.VarGB.Controls.Add(this.maxDatePicker);
            this.VarGB.Controls.Add(this.to);
            this.VarGB.Controls.Add(this.minTxb);
            this.VarGB.Controls.Add(this.maxTxb);
            this.VarGB.Controls.Add(this.from);
            this.VarGB.Location = new System.Drawing.Point(459, 28);
            this.VarGB.Name = "VarGB";
            this.VarGB.Size = new System.Drawing.Size(176, 125);
            this.VarGB.TabIndex = 17;
            this.VarGB.TabStop = false;
            this.VarGB.Text = "Values";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(560, 415);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "items:";
            // 
            // limitsCB
            // 
            this.limitsCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.limitsCB.FormattingEnabled = true;
            this.limitsCB.Items.AddRange(new object[] {
            "20",
            "100",
            "200",
            "no limit"});
            this.limitsCB.Location = new System.Drawing.Point(376, 167);
            this.limitsCB.Name = "limitsCB";
            this.limitsCB.Size = new System.Drawing.Size(121, 21);
            this.limitsCB.TabIndex = 20;
//            this.limitsCB.SelectedIndexChanged += new System.EventHandler(this.limitsCB_SelectedIndexChanged);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(1, 444);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1472, 327);
            this.chart1.TabIndex = 21;
            this.chart1.Text = "chart1";
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1473, 769);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.limitsCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.VarGB);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.MainGB);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "History";
            this.Text = "History";
            this.Load += new System.EventHandler(this.History_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.MainGB.ResumeLayout(false);
            this.MainGB.PerformLayout();
            this.VarGB.ResumeLayout(false);
            this.VarGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label to;
        private System.Windows.Forms.Label from;
        private System.Windows.Forms.TextBox minTxb;
        private System.Windows.Forms.TextBox maxTxb;
        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.GroupBox MainGB;
        private System.Windows.Forms.RadioButton tempRB;
        private System.Windows.Forms.RadioButton humRB;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.RadioButton timeRD;
        private System.Windows.Forms.DateTimePicker minDatePicker;
        private System.Windows.Forms.DateTimePicker maxDatePicker;
        private System.Windows.Forms.GroupBox VarGB;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox limitsCB;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}