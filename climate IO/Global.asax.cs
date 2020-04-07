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

        private Boolean IS_TESTING = false;
            
        private string db_key_test = @"C:\key\ClimateHistory-352e17151f9b.json"; // test DB
        private string db_key_prod = @"C:\key\CCPROD-b64060fb7bfd.json"; // prod DB


        static public FirestoreDb db = null;
        static public string COLLECTION_NAME = "ClimateInfo";
        static public DataTable table = new DataTable();
        static public DataTable SortTable = new DataTable();
        static public List<string> x = new List<string>();
        static public List<float> yTemp = new List<float>();
        static public List<float> yHum = new List<float>();
        protected void Application_Start(object sender, EventArgs e)
        {
            //if (Environment.GetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS") == null)
            if (IS_TESTING)
            {
                System.Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", db_key_test);
                db = FirestoreDb.Create("climatehistory-3ff7e");
            }
            else
            {
                System.Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", db_key_prod);
                db = FirestoreDb.Create("ccprod-a2946");
            }
            table.Columns.Add("Time", typeof(string));
            table.Columns.Add("Temp", typeof(float));
            table.Columns.Add("Hum", typeof(float));
        }
    }
}