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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RBalarmOff = new System.Windows.Forms.RadioButton();
            this.RBalarmOn = new System.Windows.Forms.RadioButton();
            this.RBallAlarm = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.MainGB.SuspendLayout();
            this.VarGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
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
            this.dataGridView1.Size = new System.Drawing.Size(320, 436);
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
            this.OKbutton.Location = new System.Drawing.Point(180, 691);
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
            this.MainGB.Location = new System.Drawing.Point(1, 447);
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
            this.clearBtn.Location = new System.Drawing.Point(25, 691);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 14;
            this.clearBtn.Text = "clear";
            this.clearBtn.UseVisualStyleBackColor = true;
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
            this.VarGB.Location = new System.Drawing.Point(145, 447);
            this.VarGB.Name = "VarGB";
            this.VarGB.Size = new System.Drawing.Size(176, 125);
            this.VarGB.TabIndex = 17;
            this.VarGB.TabStop = false;
            this.VarGB.Text = "Values";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(15, 734);
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
            this.label1.Location = new System.Drawing.Point(12, 655);
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
            this.limitsCB.Location = new System.Drawing.Point(64, 652);
            this.limitsCB.Name = "limitsCB";
            this.limitsCB.Size = new System.Drawing.Size(121, 21);
            this.limitsCB.TabIndex = 20;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(355, 2);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(1092, 772);
            this.chart1.TabIndex = 21;
            this.chart1.Text = "chart1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RBalarmOff);
            this.groupBox1.Controls.Add(this.RBalarmOn);
            this.groupBox1.Controls.Add(this.RBallAlarm);
            this.groupBox1.Location = new System.Drawing.Point(12, 578);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 50);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aalarm Filter";
            // 
            // RBalarmOff
            // 
            this.RBalarmOff.AutoSize = true;
            this.RBalarmOff.Location = new System.Drawing.Point(224, 19);
            this.RBalarmOff.Name = "RBalarmOff";
            this.RBalarmOff.Size = new System.Drawing.Size(65, 17);
            this.RBalarmOff.TabIndex = 24;
            this.RBalarmOff.TabStop = true;
            this.RBalarmOff.Text = "alarm off";
            this.RBalarmOff.UseVisualStyleBackColor = true;
            // 
            // RBalarmOn
            // 
            this.RBalarmOn.AutoSize = true;
            this.RBalarmOn.Location = new System.Drawing.Point(116, 17);
            this.RBalarmOn.Name = "RBalarmOn";
            this.RBalarmOn.Size = new System.Drawing.Size(65, 17);
            this.RBalarmOn.TabIndex = 23;
            this.RBalarmOn.TabStop = true;
            this.RBalarmOn.Text = "alarm on";
            this.RBalarmOn.UseVisualStyleBackColor = true;
            // 
            // RBallAlarm
            // 
            this.RBallAlarm.AutoSize = true;
            this.RBallAlarm.Location = new System.Drawing.Point(6, 19);
            this.RBallAlarm.Name = "RBallAlarm";
            this.RBallAlarm.Size = new System.Drawing.Size(35, 17);
            this.RBallAlarm.TabIndex = 22;
            this.RBallAlarm.TabStop = true;
            this.RBallAlarm.Text = "all";
            this.RBallAlarm.UseVisualStyleBackColor = true;
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.groupBox1);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton RBalarmOff;
        private System.Windows.Forms.RadioButton RBalarmOn;
        private System.Windows.Forms.RadioButton RBallAlarm;
    }
}