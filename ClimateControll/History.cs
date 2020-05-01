using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Cloud.Firestore;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.SqlClient;
using System.Configuration;


namespace ClimateControll
{

    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }
        private DataTable table = new DataTable();
        private DataTable SortTable = new DataTable();
        private List<string> x = new List<string>();
        private List<float> yTemp = new List<float>();
        private List<float> yHum = new List<float>();

        private async void History_Load(object sender, EventArgs e)
        {
            limitsCB.SelectedItem = "100";
            chart1.Series.Add("Tempeture");
            chart1.Series.Add("Humiditiy");
            table.Columns.Add("Time", typeof(string));
            table.Columns.Add("Temp", typeof(float));
            table.Columns.Add("Hum", typeof(float));
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = table;
            dataGridView1.Sort(dataGridView1.Columns["time"],ListSortDirection.Descending);
            chart1.Series[0].ChartType = SeriesChartType.FastLine;
            chart1.Series[1].ChartType = SeriesChartType.FastLine;

            //chart1.Series[0].Points.DataBindXY(x, y);



            Query capitalQuery = Program.db.Collection(MainFRM.COLLECTION_NAME).OrderByDescending("WhenUNIX").Limit(100);
            QuerySnapshot capitalQuerySnapshot = await capitalQuery.GetSnapshotAsync();
            foreach (DocumentSnapshot documentSnapshot in capitalQuerySnapshot.Documents)
            {
                TempInfo temp = documentSnapshot.ConvertTo<TempInfo>();

                table.Rows.Add(temp.WhenString, temp.Temperature,temp.Humidity);

            }
            DataView dv = table.DefaultView;
            dv.Sort = "Time";
            SortTable = dv.ToTable();
            x = SortTable.Rows.OfType<DataRow>().Select(dr => dr.Field<string>("Time")).ToList();
            yTemp = SortTable.Rows.OfType<DataRow>().Select(dr => dr.Field<float>("Temp")).ToList();
            yHum = SortTable.Rows.OfType<DataRow>().Select(dr => dr.Field<float>("Hum")).ToList();


            chart1.Series[0].Points.DataBindXY(x, yTemp);
            chart1.Series[1].Points.DataBindXY(x, yHum);
            dataGridView1.AutoResizeColumns();



        }

        private async void OKbutton_Click(object sender, EventArgs e)
        {
            table.Rows.Clear();
            float min = 0,max = 100;
            string filter = "Humidity";
            int limit = 100;
            bool isLimit = true;
            x.Clear();
            yTemp.Clear();
            yHum.Clear();
            chart1.Series[0].Points.DataBindXY(x, yTemp);
            chart1.Series[1].Points.DataBindXY(x, yHum);

            if (limitsCB.SelectedItem.ToString() != "no limit")
            {
                limit = int.Parse(limitsCB.SelectedItem.ToString());
                isLimit = true;
            }
            else
            {
                isLimit = false;
            }

            if (humRB.Checked)
            {
                filter = "Humidity";
            }
            if (tempRB.Checked)
            {
                filter = "Temperature";
            }
            if(minTxb.Text != "")
            {
                min = float.Parse(minTxb.Text);
            }
            if (maxTxb.Text != "")
            {
                max = float.Parse(maxTxb.Text);
            }




            if (timeRD.Checked)
            {
                if (isLimit)
                {
                    long minUnixTime = ((DateTimeOffset)minDatePicker.Value).ToUnixTimeSeconds() - 86400;
                    long maxUnixTime = ((DateTimeOffset)maxDatePicker.Value).ToUnixTimeSeconds();
                    Query capitalQuery = Program.db.Collection(MainFRM.COLLECTION_NAME).WhereGreaterThanOrEqualTo("WhenUNIX", minUnixTime).WhereLessThanOrEqualTo("WhenUNIX", maxUnixTime).Limit(limit);
                    QuerySnapshot capitalQuerySnapshot = await capitalQuery.GetSnapshotAsync();
                    foreach (DocumentSnapshot documentSnapshot in capitalQuerySnapshot.Documents)
                    {
                        TempInfo temp = documentSnapshot.ConvertTo<TempInfo>();

                        table.Rows.Add(temp.WhenString, temp.Temperature, temp.Humidity);


                    }
                    DataView dv = table.DefaultView;
                    dv.Sort = "Time";
                    SortTable = dv.ToTable();
                    x = SortTable.Rows.OfType<DataRow>().Select(dr => dr.Field<string>("Time")).ToList();
                    yTemp = SortTable.Rows.OfType<DataRow>().Select(dr => dr.Field<float>("Temp")).ToList();
                    yHum = SortTable.Rows.OfType<DataRow>().Select(dr => dr.Field<float>("Hum")).ToList();
                    chart1.Series[0].Points.DataBindXY(x, yTemp);
                    chart1.Series[1].Points.DataBindXY(x, yHum);

                }
                else
                {

                    long minUnixTime = ((DateTimeOffset)minDatePicker.Value).ToUnixTimeSeconds() - 86400;
                    long maxUnixTime = ((DateTimeOffset)maxDatePicker.Value).ToUnixTimeSeconds();
                    Query capitalQuery = Program.db.Collection(MainFRM.COLLECTION_NAME).WhereGreaterThanOrEqualTo("WhenUNIX", minUnixTime).WhereLessThanOrEqualTo("WhenUNIX", maxUnixTime);
                    QuerySnapshot capitalQuerySnapshot = await capitalQuery.GetSnapshotAsync();
                    foreach (DocumentSnapshot documentSnapshot in capitalQuerySnapshot.Documents)
                    {
                        TempInfo temp = documentSnapshot.ConvertTo<TempInfo>();

                        table.Rows.Add(temp.WhenString, temp.Temperature, temp.Humidity);

                    }
                    DataView dv = table.DefaultView;
                    dv.Sort = "Time";
                    SortTable = dv.ToTable();
                    x = SortTable.Rows.OfType<DataRow>().Select(dr => dr.Field<string>("Time")).ToList();
                    yTemp = SortTable.Rows.OfType<DataRow>().Select(dr => dr.Field<float>("Temp")).ToList();
                    yHum = SortTable.Rows.OfType<DataRow>().Select(dr => dr.Field<float>("Hum")).ToList();
                    chart1.Series[0].Points.DataBindXY(x, yTemp);
                    chart1.Series[1].Points.DataBindXY(x, yHum);
                }
            }
            else
            {
                if (isLimit)
                {
                    Query capitalQuery = Program.db.Collection(MainFRM.COLLECTION_NAME).WhereGreaterThanOrEqualTo(filter, min).WhereLessThanOrEqualTo(filter, max).Limit(limit);
                    QuerySnapshot capitalQuerySnapshot = await capitalQuery.GetSnapshotAsync();
                    foreach (DocumentSnapshot documentSnapshot in capitalQuerySnapshot.Documents)
                    {
                        TempInfo temp = documentSnapshot.ConvertTo<TempInfo>();

                        table.Rows.Add(temp.WhenString, temp.Temperature, temp.Humidity);

                    }
                    DataView dv = table.DefaultView;
                    dv.Sort = "Time";
                    SortTable = dv.ToTable();
                    x = SortTable.Rows.OfType<DataRow>().Select(dr => dr.Field<string>("Time")).ToList();
                    yTemp = SortTable.Rows.OfType<DataRow>().Select(dr => dr.Field<float>("Temp")).ToList();
                    yHum = SortTable.Rows.OfType<DataRow>().Select(dr => dr.Field<float>("Hum")).ToList();
                    chart1.Series[0].Points.DataBindXY(x, yTemp);
                    chart1.Series[1].Points.DataBindXY(x, yHum);

                }
                else
                {

                    Query capitalQuery = Program.db.Collection(MainFRM.COLLECTION_NAME).WhereGreaterThanOrEqualTo(filter, min).WhereLessThanOrEqualTo(filter, max);
                    QuerySnapshot capitalQuerySnapshot = await capitalQuery.GetSnapshotAsync();
                    foreach (DocumentSnapshot documentSnapshot in capitalQuerySnapshot.Documents)
                    {
                        TempInfo temp = documentSnapshot.ConvertTo<TempInfo>();

                        table.Rows.Add(temp.WhenString, temp.Temperature, temp.Humidity);



                    }
                    DataView dv = table.DefaultView;
                    dv.Sort = "Time";
                    SortTable = dv.ToTable();
                    x = SortTable.Rows.OfType<DataRow>().Select(dr => dr.Field<string>("Time")).ToList();
                    yTemp = SortTable.Rows.OfType<DataRow>().Select(dr => dr.Field<float>("Temp")).ToList();
                    yHum = SortTable.Rows.OfType<DataRow>().Select(dr => dr.Field<float>("Hum")).ToList();
                    chart1.Series[0].Points.DataBindXY(x, yTemp);
                    chart1.Series[1].Points.DataBindXY(x, yHum);
                }
            }


        }


        private void clearBtn_Click(object sender, EventArgs e)
        {
            minTxb.Text = "";
            maxTxb.Text = "";

        }

        private void timeRD_CheckedChanged(object sender, EventArgs e)
        {
            if (timeRD.Checked)
            {
                minTxb.Visible = false;
                maxTxb.Visible = false;
                minDatePicker.Visible = true;
                maxDatePicker.Visible = true;

            }
            else
            {
                minTxb.Visible = true;
                maxTxb.Visible = true;
                minDatePicker.Visible = false;
                maxDatePicker.Visible = false;

            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
