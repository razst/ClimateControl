using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Cloud.Firestore;


namespace ClimateControll
{


    static class Program
    {
        private static bool IS_TESTING = true;
        private static string db_key_test = @"C:\key\ClimateHistory-352e17151f9b.json";
        private static string db_key_prod = @"C:\key\CCPROD-b64060fb7bfd.json";
        static public FirestoreDb db;


        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        [STAThread]
        static void Main()
        {


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

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainFRM());
        }
    }
}
