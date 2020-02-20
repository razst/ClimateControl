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
        private DataTable table = new DataTable();

        private async void History_Load(object sender, EventArgs e)
        {
            table.Columns.Add("time    ", typeof(string));
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
        public void ReadText(float value,TextBox txb)
        {
            if(txb.Text != "")
            {
                value = float.Parse(txb.Text);
            }
        }

        private async void OKbutton_Click(object sender, EventArgs e)
        {
            table.Rows.Clear();
            float min = 0,max = 100;
            string filter = "Humidity";
            if (humRB.Checked)
            {
                filter = "Humidity";
            }
            if (tempRB.Checked)
            {
                filter = "Temperature";
            }
            if(minTxb.Text != "")
            {
                min = float.Parse(minTxb.Text);
            }
            if (maxTxb.Text != "")
            {
                max = float.Parse(maxTxb.Text);
            }
            Console.WriteLine(min+","+max);
            

            Query capitalQuery = MainFRM.db.Collection(MainFRM.COLLECTION_NAME).Limit(10).WhereGreaterThanOrEqualTo(filter,min).WhereLessThanOrEqualTo(filter, max).OrderByDescending(filter);
            QuerySnapshot capitalQuerySnapshot = await capitalQuery.GetSnapshotAsync();
            foreach (DocumentSnapshot documentSnapshot in capitalQuerySnapshot.Documents)
            {
                TempInfo temp = documentSnapshot.ConvertTo<TempInfo>();

                table.Rows.Add(temp.WhenString, temp.Temperature, temp.Humidity);

            }

        }
    }
}
