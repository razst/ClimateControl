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
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static async void Main()
        {
            DocumentReference docRef = MainFRM.db.Collection("settings").Document("settings_data");
            DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();
            if (snapshot.Exists)
            {
                settings curSet = snapshot.ConvertTo<settings>();
                Properties.Settings.Default.maxTemp = curSet.maxTemp;
                Properties.Settings.Default.minTemp = curSet.minTemp;
                Properties.Settings.Default.maxHumidity = curSet.maxHum;
                Properties.Settings.Default.minHumidity = curSet.minHum;
                Properties.Settings.Default.mailAdrees = curSet.mailAdress;
                Properties.Settings.Default.sendMail = curSet.sendMail;
                Properties.Settings.Default.turnOnAlert = curSet.turnOnAlert;
                Properties.Settings.Default.port = curSet.port;
                Properties.Settings.Default.TestMode = curSet.testMode;
                Properties.Settings.Default.ranMaxHum = curSet.ranMaxHum;
                Properties.Settings.Default.ranMaxTemp = curSet.ranMaxTemp;
                Properties.Settings.Default.ranMinHum = curSet.ranMinHum;
                Properties.Settings.Default.ranMinTemp = curSet.ranMinTemp;
            }
            //start code here

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainFRM());
        }
    }
}
