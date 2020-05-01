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
    public partial class SettingsFRM : Form
    {
        public SettingsFRM()
        {
            InitializeComponent();
        }
        private settings s = new settings();

        private void SettingsFRM_Load(object sender, EventArgs e)
        {
            TbMaxTemp.Text = "" + Properties.Settings.Default.maxTemp;
            TbMinTemp.Text = "" + Properties.Settings.Default.minTemp;
            TbMaxHumidity.Text = "" + Properties.Settings.Default.maxHumidity;
            TbMinHumidity.Text = "" + Properties.Settings.Default.minHumidity;
            TbxMailAdress.Text = Properties.Settings.Default.mailAdrees;
            CbMail.Checked = Properties.Settings.Default.sendMail;
            CbAlert.Checked = Properties.Settings.Default.turnOnAlert;
            tbPortName.Text = Properties.Settings.Default.port;
            CbTestMode.Checked = Properties.Settings.Default.TestMode;
            RanMaxHum.Text = ""+Properties.Settings.Default.ranMaxHum;
            RanMaxTemp.Text =""+ Properties.Settings.Default.ranMaxTemp;
            RanMinHum.Text = "" + Properties.Settings.Default.ranMinHum;
            RanMinTemp.Text = "" + Properties.Settings.Default.ranMinTemp;
            updateDBTxb.Text = "" + Properties.Settings.Default.updateDB;

        }

        private async void OKButton_Click(object sender, EventArgs e)
        {
            bool currect = true;
            int cheak;
            label1.ForeColor = System.Drawing.Color.Black;
            label2.ForeColor = System.Drawing.Color.Black;
            label3.ForeColor = System.Drawing.Color.Black;
            label4.ForeColor = System.Drawing.Color.Black;

            if (!int.TryParse(TbMinTemp.Text, out cheak))
            {
                currect = false;
                label1.ForeColor = System.Drawing.Color.Red;
            }

            if (!int.TryParse(TbMaxTemp.Text, out cheak))
            {
                currect = false;
                label2.ForeColor = System.Drawing.Color.Red;
            }

            if (!int.TryParse(TbMinHumidity.Text, out cheak))
            {
                currect = false;
                label3.ForeColor = System.Drawing.Color.Red;
            }

            if (!int.TryParse(TbMaxHumidity.Text, out cheak))
            {
                currect = false;
                label4.ForeColor = System.Drawing.Color.Red;
            }

            if (currect && (TbxMailAdress.Text != "" || CbMail.Checked == false))
            {
                Properties.Settings.Default.maxTemp = int.Parse(TbMaxTemp.Text);
                Properties.Settings.Default.minTemp = int.Parse(TbMinTemp.Text);
                Properties.Settings.Default.maxHumidity = int.Parse(TbMaxHumidity.Text);
                Properties.Settings.Default.minHumidity = int.Parse(TbMinHumidity.Text);
                Properties.Settings.Default.mailAdrees = TbxMailAdress.Text;
                Properties.Settings.Default.sendMail = CbMail.Checked;
                Properties.Settings.Default.turnOnAlert = CbAlert.Checked;
                Properties.Settings.Default.port = tbPortName.Text;
                Properties.Settings.Default.TestMode = CbTestMode.Checked;
                Properties.Settings.Default.ranMaxHum = int.Parse(RanMaxHum.Text);
                Properties.Settings.Default.ranMaxTemp = int.Parse(RanMaxTemp.Text);
                Properties.Settings.Default.ranMinHum = int.Parse(RanMinHum.Text);
                Properties.Settings.Default.ranMinTemp = int.Parse(RanMinTemp.Text);
                Properties.Settings.Default.updateDB = int.Parse(updateDBTxb.Text);


                Properties.Settings.Default.Save();


                s.maxTemp = Properties.Settings.Default.maxTemp;
                s.minTemp = Properties.Settings.Default.minTemp;
                s.maxHum = Properties.Settings.Default.maxHumidity;
                s.minHum = Properties.Settings.Default.minHumidity;
                s.mailAdress = Properties.Settings.Default.mailAdrees;
                s.sendMail = Properties.Settings.Default.sendMail;
                s.turnOnAlert = Properties.Settings.Default.turnOnAlert;
                s.port = Properties.Settings.Default.port;
                s.testMode = Properties.Settings.Default.TestMode;
                s.ranMaxHum = Properties.Settings.Default.ranMaxHum;
                s.ranMaxTemp = Properties.Settings.Default.ranMaxTemp;
                s.ranMinHum = Properties.Settings.Default.ranMinHum;
                s.ranMinTemp = Properties.Settings.Default.ranMinTemp;
                s.updateDB = Properties.Settings.Default.updateDB;
                DocumentReference docRef = Program.db.Collection("settings").Document("settings_data");
                await docRef.SetAsync(s);


                MessageBox.Show("all values are saved");
            }
            else if (TbxMailAdress.Text == "" && CbMail.Checked == true)
            {
                MessageBox.Show("email adress box is empty", "error");
            }
            else
            {
                MessageBox.Show("values in red are bed", "error");
            }

            Close();

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you don't want to save changes?", "Cancel", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }

            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void CbTestMode_CheckedChanged(object sender, EventArgs e)
        {
            if (CbTestMode.Checked == true)
            {
                TestSetPnl.Visible = true;
            }
            else
            {
                TestSetPnl.Visible = false;
            }
        }
    }
}
