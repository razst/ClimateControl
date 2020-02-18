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



namespace ClimateControll
{
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }

        private async void History_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("time", typeof(string));
            table.Columns.Add("temp", typeof(float));
            table.Columns.Add("hum", typeof(float));
            dataGridView1.DataSource = table;


            Query capitalQuery = MainFRM.db.Collection(MainFRM.COLLECTION_NAME).OrderByDescending("WhenUNIX").Limit(10);
            QuerySnapshot capitalQuerySnapshot = await capitalQuery.GetSnapshotAsync();
            foreach (DocumentSnapshot documentSnapshot in capitalQuerySnapshot.Documents)
            {
                TempInfo temp = documentSnapshot.ConvertTo<TempInfo>();

                table.Rows.Add(temp.WhenString, temp.Temperature,temp.Humidity);

            }


        }
    }
}
