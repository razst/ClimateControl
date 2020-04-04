using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using Google.Cloud.Firestore;

namespace climate_IO
{
    public class Global : System.Web.HttpApplication
    {
        static public FirestoreDb db = FirestoreDb.Create("climatehistory-3ff7e");
        static public string COLLECTION_NAME = "ClimateInfo";
        static public DataTable table = new DataTable();
        static public DataTable SortTable = new DataTable();
        static public List<string> x = new List<string>();
        static public List<float> yTemp = new List<float>();
        static public List<float> yHum = new List<float>();
        protected void Application_Start(object sender, EventArgs e)
        {
                table.Columns.Add("Time", typeof(string));
                table.Columns.Add("Temp", typeof(float));
                table.Columns.Add("Hum", typeof(float));
        }
    }
}