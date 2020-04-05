using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Google.Cloud.Firestore;


namespace climate_IO
{
    public partial class MainPage : System.Web.UI.Page
    {
        protected async void Page_Load(object sender, EventArgs e)
        {


            TempInfo temp = new TempInfo();
            Query capitalQuery = Global.db.Collection(Global.COLLECTION_NAME).OrderByDescending("WhenUNIX").Limit(1);
            QuerySnapshot capitalQuerySnapshot = await capitalQuery.GetSnapshotAsync();
            foreach (DocumentSnapshot documentSnapshot in capitalQuerySnapshot.Documents)
            {
                temp = documentSnapshot.ConvertTo<TempInfo>();
            }
            curTemp.Text = "" + temp.Temperature;
            curHum.Text = "" + temp.Humidity;

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("HistoryPage.aspx",false);
            Context.ApplicationInstance.CompleteRequest();
        }


    }
}