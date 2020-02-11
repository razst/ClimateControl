using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClimateControll
{
    public partial class SettingsFRM : Form
    {
        public SettingsFRM()
        {
            InitializeComponent();
        }

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
        }

        private void OKButton_Click(object sender, EventArgs e)
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
                Properties.Settings.Default.Save();
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

        private void TbMailAdress_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
