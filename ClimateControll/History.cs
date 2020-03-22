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
        private List<string> x = new List<string>();
        private List<float> y = new List<float>();

        private async void History_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Time", typeof(string));
            table.Columns.Add("Temp", typeof(float));
            table.Columns.Add("Hum", typeof(float));
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = table;
            dataGridView1.Sort(dataGridView1.Columns["time"],ListSortDirection.Descending);


            var Series = new Series("temp");
            Series.ChartType = SeriesChartType.FastLine;
            chart1.Series[0] = Series;
            //chart1.Series[0].Points.DataBindXY(x, y);



            Query capitalQuery = MainFRM.db.Collection(MainFRM.COLLECTION_NAME).OrderByDescending("WhenUNIX").Limit(100);
            QuerySnapshot capitalQuerySnapshot = await capitalQuery.GetSnapshotAsync();
            foreach (DocumentSnapshot documentSnapshot in capitalQuerySnapshot.Documents)
            {
                TempInfo temp = documentSnapshot.ConvertTo<TempInfo>();

                table.Rows.Add(temp.WhenString, temp.Temperature,temp.Humidity);

            }
            dataGridView1.AutoResizeColumns();



        }

        private async void OKbutton_Click(object sender, EventArgs e)
        {
            table.Rows.Clear();
            float min = 0,max = 100;
            string filter = "Humidity";
            string graph = "";
            int limit = 100;
            bool isLimit = true;
            x.Clear();
            y.Clear();
            chart1.Series[0].Points.DataBindXY(x, y);

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
            if (HumGraRD.Checked)
            {
                graph = "Humidity";
            }
            if (TempGraRD.Checked)
            {
                graph = "Temperature";
            }

            
           
            
            if (GraphCB.Checked)
            {
                if (isLimit)
                {
                    dataGridView1.Visible = false;
                    chart1.Visible = true;
                    long minUnixTime = ((DateTimeOffset)minDatePicker.Value).ToUnixTimeSeconds() - 86400;
                    long maxUnixTime = ((DateTimeOffset)maxDatePicker.Value).ToUnixTimeSeconds();
                    Query capitalQuery = MainFRM.db.Collection(MainFRM.COLLECTION_NAME).WhereGreaterThanOrEqualTo("WhenUNIX", minUnixTime).WhereLessThanOrEqualTo("WhenUNIX", maxUnixTime).Limit(limit);
                    QuerySnapshot capitalQuerySnapshot = await capitalQuery.GetSnapshotAsync();
                    foreach (DocumentSnapshot documentSnapshot in capitalQuerySnapshot.Documents)
                    {
                        TempInfo temp = documentSnapshot.ConvertTo<TempInfo>();

                        x.Add(temp.WhenString);
                        if (graph == "Humidity")
                        {
                            y.Add(temp.Humidity);
                        }
                        else
                        {
                            y.Add(temp.Temperature);
                        }

                    }
                    chart1.Series[0].Points.DataBindXY(x, y);
                }
                else
                {
                    dataGridView1.Visible = false;
                    chart1.Visible = true;
                    long minUnixTime = ((DateTimeOffset)minDatePicker.Value).ToUnixTimeSeconds() - 86400;
                    long maxUnixTime = ((DateTimeOffset)maxDatePicker.Value).ToUnixTimeSeconds();
                    Query capitalQuery = MainFRM.db.Collection(MainFRM.COLLECTION_NAME).WhereGreaterThanOrEqualTo("WhenUNIX", minUnixTime).WhereLessThanOrEqualTo("WhenUNIX", maxUnixTime);
                    QuerySnapshot capitalQuerySnapshot = await capitalQuery.GetSnapshotAsync();
                    foreach (DocumentSnapshot documentSnapshot in capitalQuerySnapshot.Documents)
                    {
                        TempInfo temp = documentSnapshot.ConvertTo<TempInfo>();

                        x.Add(temp.WhenString);
                        if (graph == "Humidity")
                        {
                            y.Add(temp.Humidity);
                        }
                        else
                        {
                            y.Add(temp.Temperature);
                        }

                    }
                    chart1.Series[0].Points.DataBindXY(x, y);
                }
            }




            if (!GraphCB.Checked)
            {


                if (!timeRD.Checked)
                {
                    if (isLimit)
                    {
                        Query capitalQuery = MainFRM.db.Collection(MainFRM.COLLECTION_NAME).WhereGreaterThanOrEqualTo(filter, min).WhereLessThanOrEqualTo(filter, max).Limit(limit);
                        QuerySnapshot capitalQuerySnapshot = await capitalQuery.GetSnapshotAsync();
                        foreach (DocumentSnapshot documentSnapshot in capitalQuerySnapshot.Documents)
                        {
                            TempInfo temp = documentSnapshot.ConvertTo<TempInfo>();

                            table.Rows.Add(temp.WhenString, temp.Temperature, temp.Humidity);

                        }
                    }
                    else
                    {
                        Query capitalQuery = MainFRM.db.Collection(MainFRM.COLLECTION_NAME).WhereGreaterThanOrEqualTo(filter, min).WhereLessThanOrEqualTo(filter, max);
                        QuerySnapshot capitalQuerySnapshot = await capitalQuery.GetSnapshotAsync();
                        foreach (DocumentSnapshot documentSnapshot in capitalQuerySnapshot.Documents)
                        {
                            TempInfo temp = documentSnapshot.ConvertTo<TempInfo>();

                            table.Rows.Add(temp.WhenString, temp.Temperature, temp.Humidity);

                        }
                    }
                }

                else
                {
                    if (isLimit)
                    {
                        long minUnixTime = ((DateTimeOffset)minDatePicker.Value).ToUnixTimeSeconds() - 86400;
                        long maxUnixTime = ((DateTimeOffset)maxDatePicker.Value).ToUnixTimeSeconds();
                        Query capitalQuery = MainFRM.db.Collection(MainFRM.COLLECTION_NAME).WhereGreaterThanOrEqualTo("WhenUNIX", minUnixTime).WhereLessThanOrEqualTo("WhenUNIX", maxUnixTime).Limit(limit);
                        QuerySnapshot capitalQuerySnapshot = await capitalQuery.GetSnapshotAsync();
                        foreach (DocumentSnapshot documentSnapshot in capitalQuerySnapshot.Documents)
                        {
                            TempInfo temp = documentSnapshot.ConvertTo<TempInfo>();

                            table.Rows.Add(temp.WhenString, temp.Temperature, temp.Humidity);

                        }
                    }
                    else
                    {
                        long minUnixTime = ((DateTimeOffset)minDatePicker.Value).ToUnixTimeSeconds() - 86400;
                        long maxUnixTime = ((DateTimeOffset)maxDatePicker.Value).ToUnixTimeSeconds();
                        Query capitalQuery = MainFRM.db.Collection(MainFRM.COLLECTION_NAME).WhereGreaterThanOrEqualTo("WhenUNIX", minUnixTime).WhereLessThanOrEqualTo("WhenUNIX", maxUnixTime);
                        QuerySnapshot capitalQuerySnapshot = await capitalQuery.GetSnapshotAsync();
                        foreach (DocumentSnapshot documentSnapshot in capitalQuerySnapshot.Documents)
                        {
                            TempInfo temp = documentSnapshot.ConvertTo<TempInfo>();

                            table.Rows.Add(temp.WhenString, temp.Temperature, temp.Humidity);

                        }
                    }
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

        private void TempGraRD_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Graph_CheckedChanged(object sender, EventArgs e)
        {
            if (GraphCB.Checked)
            {
                GraphGB.Visible = true;
                humRB.Visible = false;
                tempRB.Visible = false;
                timeRD.Checked = true;
                MainGB.Visible = false;
                dataGridView1.Visible = !true;
                chart1.Visible = !false;
            }
            else
            {
                GraphGB.Visible = !true;
                humRB.Visible = !false;
                tempRB.Visible = !false;
                MainGB.Visible = !false;
                dataGridView1.Visible = true;
                chart1.Visible = false;

            }
        }
    }
}
