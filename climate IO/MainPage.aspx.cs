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
        private settings curSet = new settings();
        protected async void Page_Load(object sender, EventArgs e)
        {
            DocumentReference docRef = Global.db.Collection("settings").Document("settings_data");
            DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();
            if (snapshot.Exists)
            {
                 curSet = snapshot.ConvertTo<settings>();
            }

            TempInfo temp = new TempInfo();
            Query capitalQuery = Global.db.Collection(Global.COLLECTION_NAME).OrderByDescending("WhenUNIX").Limit(1);
            QuerySnapshot capitalQuerySnapshot = await capitalQuery.GetSnapshotAsync();
            foreach (DocumentSnapshot documentSnapshot in capitalQuerySnapshot.Documents)
            {
                temp = documentSnapshot.ConvertTo<TempInfo>();
            }
            curTemp.Text = "" + temp.Temperature;
            curHum.Text = "" + temp.Humidity;
            timeLB.Text = "" + temp.WhenString;
            if (temp.Temperature<curSet.minTemp|| temp.Temperature > curSet.maxTemp||temp.Humidity<curSet.minHum|| temp.Humidity < curSet.maxHum)
            {
                redL.Visible = true;
                greenL.Visible = false;
            }
            else
            {
                redL.Visible = false;
                greenL.Visible = true;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("HistoryPage.aspx",false);
            Context.ApplicationInstance.CompleteRequest();
        }


    }
}