using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Google.Cloud.Firestore;




namespace climate_IO
{
    public partial class HistoryPage : System.Web.UI.Page
    {
        private CancellationTokenSource source = new CancellationTokenSource();
        private bool firstLoad = false;
        protected async void Page_Load(object sender, EventArgs e)
        {
            if (firstLoad)
            {
                await Task.Delay(TimeSpan.FromSeconds(1), source.Token);
                chart1.Series[0].Points.DataBindXY(Global.x, Global.yTemp);
                chart1.Series[1].Points.DataBindXY(Global.x, Global.yHum);
                dataGridView1.DataSource = Global.table;
                dataGridView1.DataBind();
                firstLoad = false;
            }


        }




        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("MainPage.aspx");

        }
    }
}