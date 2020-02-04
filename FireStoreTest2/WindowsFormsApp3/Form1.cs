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

namespace WindowsFormsApp3
{

    public partial class Form1 : Form
    {
        private FirestoreDb db = FirestoreDb.Create("climatehistory-3ff7e");
        private string COLLECTION_NAME = "ClimateInfo";

        public Form1()
        {
            InitializeComponent();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            long unixTime = ((DateTimeOffset)now).ToUnixTimeSeconds();

            TempInfo t = new TempInfo();
            t.WhenUNIX = unixTime;
            t.WhenString = now.ToString("yyyy-MM-dd HH:mm:ss");
            t.Temperature = 10;
            t.Humidity = 70;

            DocumentReference docRef = db.Collection(COLLECTION_NAME).Document(t.WhenUNIX.ToString());
            
            
            await docRef.SetAsync(t);

        }
    }
}
