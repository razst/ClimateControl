using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Google.Cloud.Firestore;




namespace climate_IO
{
    public partial class HistoryPage : System.Web.UI.Page
    {
        
        private const string ASCENDING = " ASC";
        private const string DESCENDING = " DESC";
        protected async void Page_Load(object sender, EventArgs e)
        {
            if (Global.firstLoad)
            {
                Query capitalQuery = Global.db.Collection(Global.COLLECTION_NAME).OrderByDescending("WhenUNIX").Limit(100);
                QuerySnapshot capitalQuerySnapshot = await capitalQuery.GetSnapshotAsync();
                foreach (DocumentSnapshot documentSnapshot in capitalQuerySnapshot.Documents)
                {
                    TempInfo temp = documentSnapshot.ConvertTo<TempInfo>();

                    Global.table.Rows.Add(temp.WhenString, temp.Temperature, temp.Humidity);

                }
                dataGridView1.DataSource = Global.table;
                dataGridView1.DataBind();
                DataView dv = Global.table.DefaultView;
                dv.Sort = "Time";
                Global.SortTable = dv.ToTable();
                Global.x = Global.SortTable.Rows.OfType<DataRow>().Select(dr => dr.Field<string>("Time")).ToList();
                Global.yTemp = Global.SortTable.Rows.OfType<DataRow>().Select(dr => dr.Field<float>("Temp")).ToList();
                Global.yHum = Global.SortTable.Rows.OfType<DataRow>().Select(dr => dr.Field<float>("Hum")).ToList();
                Global.firstLoad = false;
            }
            chart1.Series[0].Points.DataBindXY(Global.x, Global.yTemp);
            chart1.Series[1].Points.DataBindXY(Global.x, Global.yHum);

        }

        protected async void OKbutton_Click(object sender, EventArgs e)
        {
            Global.table.Rows.Clear();
            float min = 0, max = 100;
            string filter = "Humidity";
            int limit = 100;
            bool isLimit = true;
            Global.x.Clear();
            Global.yTemp.Clear();
            Global.yHum.Clear();
            chart1.Series[0].Points.DataBindXY(Global.x, Global.yTemp);
            chart1.Series[1].Points.DataBindXY(Global.x, Global.yHum);

            if (limitsCB.SelectedItem.ToString() != "no limit")
            {
                limit = int.Parse(limitsCB.SelectedItem.ToString());
                isLimit = true;
            }
            else
            {
                isLimit = false;
            }

            if (filterRBbox.SelectedIndex == 0)
            {
                filter = "Humidity";
            }
            if (filterRBbox.SelectedIndex == 1)
            {
                filter = "Temperature";
            }
            if (minTempTxb.Text != "")
            {
                min = float.Parse(minTempTxb.Text);
            }
            if (maxTempTxb.Text != "")
            {
                max = float.Parse(maxTempTxb.Text);
            }
            if (minHumTxb.Text != "")
            {
                min = float.Parse(minHumTxb.Text);
            }
            if (maxHumTxb.Text != "")
            {
                max = float.Parse(maxHumTxb.Text);
            }



            if (filterRBbox.SelectedIndex == 2)
            {
                if (isLimit)
                {
                    Console.WriteLine(minDatePicker.Text);
                    string[] dueDateSplit = minDatePicker.Text.Split('-');
                    DateTime minTime = new DateTime(int.Parse(dueDateSplit[0]), int.Parse(dueDateSplit[1]), int.Parse(dueDateSplit[2]));
                    dueDateSplit = maxDatePicker.Text.Split('-');
                    DateTime maxTime = new DateTime(int.Parse(dueDateSplit[0]), int.Parse(dueDateSplit[1]), int.Parse(dueDateSplit[2]));
                    long minUnixTime = ((DateTimeOffset)minTime).ToUnixTimeSeconds();
                    long maxUnixTime = ((DateTimeOffset)maxTime).ToUnixTimeSeconds() + 86400;


                    Query capitalQuery = Global.db.Collection(Global.COLLECTION_NAME).WhereGreaterThanOrEqualTo("WhenUNIX", minUnixTime).WhereLessThanOrEqualTo("WhenUNIX", maxUnixTime).Limit(limit);
                    QuerySnapshot capitalQuerySnapshot = await capitalQuery.GetSnapshotAsync();
                    foreach (DocumentSnapshot documentSnapshot in capitalQuerySnapshot.Documents)
                    {
                        TempInfo temp = documentSnapshot.ConvertTo<TempInfo>();

                        Global.table.Rows.Add(temp.WhenString, temp.Temperature, temp.Humidity);

                    }
                    DataView dv = Global.table.DefaultView;
                    dv.Sort = "Time";
                    Global.SortTable = dv.ToTable();
                    Global.x = Global.SortTable.Rows.OfType<DataRow>().Select(dr => dr.Field<string>("Time")).ToList();
                    Global.yTemp = Global.SortTable.Rows.OfType<DataRow>().Select(dr => dr.Field<float>("Temp")).ToList();
                    Global.yHum = Global.SortTable.Rows.OfType<DataRow>().Select(dr => dr.Field<float>("Hum")).ToList();
                    chart1.Series[0].Points.DataBindXY(Global.x, Global.yTemp);
                    chart1.Series[1].Points.DataBindXY(Global.x, Global.yHum);
                    dataGridView1.DataSource = Global.table;
                    dataGridView1.DataBind();


                }
                else
                {
                    string[] dueDateSplit = minDatePicker.Text.Split('-');
                    DateTime minTime = new DateTime(int.Parse(dueDateSplit[0]), int.Parse(dueDateSplit[1]), int.Parse(dueDateSplit[2]));
                    dueDateSplit = maxDatePicker.Text.Split('-');
                    DateTime maxTime = new DateTime(int.Parse(dueDateSplit[0]), int.Parse(dueDateSplit[1]), int.Parse(dueDateSplit[2]));
                    long minUnixTime = ((DateTimeOffset)minTime).ToUnixTimeSeconds();
                    long maxUnixTime = ((DateTimeOffset)maxTime).ToUnixTimeSeconds() + 86400;

                    Query capitalQuery = Global.db.Collection(Global.COLLECTION_NAME).WhereGreaterThanOrEqualTo("WhenUNIX", minUnixTime).WhereLessThanOrEqualTo("WhenUNIX", maxUnixTime);
                    QuerySnapshot capitalQuerySnapshot = await capitalQuery.GetSnapshotAsync();
                    foreach (DocumentSnapshot documentSnapshot in capitalQuerySnapshot.Documents)
                    {
                        TempInfo temp = documentSnapshot.ConvertTo<TempInfo>();

                        Global.table.Rows.Add(temp.WhenString, temp.Temperature, temp.Humidity);

                    }
                    DataView dv = Global.table.DefaultView;
                    dv.Sort = "Time";
                    Global.SortTable = dv.ToTable();
                    Global.x = Global.SortTable.Rows.OfType<DataRow>().Select(dr => dr.Field<string>("Time")).ToList();
                    Global.yTemp = Global.SortTable.Rows.OfType<DataRow>().Select(dr => dr.Field<float>("Temp")).ToList();
                    Global.yHum = Global.SortTable.Rows.OfType<DataRow>().Select(dr => dr.Field<float>("Hum")).ToList();
                    chart1.Series[0].Points.DataBindXY(Global.x, Global.yTemp);
                    chart1.Series[1].Points.DataBindXY(Global.x, Global.yHum);
                    dataGridView1.DataSource = Global.table;
                    dataGridView1.DataBind();


                }
            }
            else
            {
                if (isLimit)
                {
                    Query capitalQuery = Global.db.Collection(Global.COLLECTION_NAME).WhereGreaterThanOrEqualTo(filter, min).WhereLessThanOrEqualTo(filter, max).Limit(limit);
                    QuerySnapshot capitalQuerySnapshot = await capitalQuery.GetSnapshotAsync();
                    foreach (DocumentSnapshot documentSnapshot in capitalQuerySnapshot.Documents)
                    {
                        TempInfo temp = documentSnapshot.ConvertTo<TempInfo>();

                        Global.table.Rows.Add(temp.WhenString, temp.Temperature, temp.Humidity);

                    }
                    DataView dv = Global.table.DefaultView;
                    dv.Sort = "Time";
                    Global.SortTable = dv.ToTable();
                    Global.x = Global.SortTable.Rows.OfType<DataRow>().Select(dr => dr.Field<string>("Time")).ToList();
                    Global.yTemp = Global.SortTable.Rows.OfType<DataRow>().Select(dr => dr.Field<float>("Temp")).ToList();
                    Global.yHum = Global.SortTable.Rows.OfType<DataRow>().Select(dr => dr.Field<float>("Hum")).ToList();
                    chart1.Series[0].Points.DataBindXY(Global.x, Global.yTemp);
                    chart1.Series[1].Points.DataBindXY(Global.x, Global.yHum);
                    dataGridView1.DataSource = Global.table;
                    dataGridView1.DataBind();


                }
                else
                {

                    Query capitalQuery = Global.db.Collection(Global.COLLECTION_NAME).WhereGreaterThanOrEqualTo(filter, min).WhereLessThanOrEqualTo(filter, max);
                    QuerySnapshot capitalQuerySnapshot = await capitalQuery.GetSnapshotAsync();
                    foreach (DocumentSnapshot documentSnapshot in capitalQuerySnapshot.Documents)
                    {
                        TempInfo temp = documentSnapshot.ConvertTo<TempInfo>();

                        Global.table.Rows.Add(temp.WhenString, temp.Temperature, temp.Humidity);



                    }
                    DataView dv = Global.table.DefaultView;
                    dv.Sort = "Time";
                    Global.SortTable = dv.ToTable();
                    Global.x = Global.SortTable.Rows.OfType<DataRow>().Select(dr => dr.Field<string>("Time")).ToList();
                    Global.yTemp = Global.SortTable.Rows.OfType<DataRow>().Select(dr => dr.Field<float>("Temp")).ToList();
                    Global.yHum = Global.SortTable.Rows.OfType<DataRow>().Select(dr => dr.Field<float>("Hum")).ToList();
                    chart1.Series[0].Points.DataBindXY(Global.x, Global.yTemp);
                    chart1.Series[1].Points.DataBindXY(Global.x, Global.yHum);
                    dataGridView1.DataSource = Global.table;
                    dataGridView1.DataBind();

                }
            }

        }




        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("MainPage.aspx",false);
            Context.ApplicationInstance.CompleteRequest();

        }

        protected void dataGridView1_Sorting(object sender, GridViewSortEventArgs e)
        {
            string sortExpression = e.SortExpression;

            if (GridViewSortDirection == SortDirection.Ascending)
            {
                GridViewSortDirection = SortDirection.Descending;
                SortGridView(sortExpression, DESCENDING);
            }
            else
            {
                GridViewSortDirection = SortDirection.Ascending;
                SortGridView(sortExpression, ASCENDING);
            }
        }









        public SortDirection GridViewSortDirection
        {
            get
            {
                if (ViewState["sortDirection"] == null)
                    ViewState["sortDirection"] = SortDirection.Ascending;

                return (SortDirection)ViewState["sortDirection"];
            }
            set { ViewState["sortDirection"] = value; }
        }




        private void SortGridView(string sortExpression, string direction)
        {
            //  You can cache the DataTable for improving performance

            DataView dgv = new DataView(Global.table);
            dgv.Sort = sortExpression + direction;

            dataGridView1.DataSource = dgv;
            dataGridView1.DataBind();
        }

    }
}