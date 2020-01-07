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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void config_Click(object sender, EventArgs e)
        {
            SettingsFRM frm = new SettingsFRM();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            greenBtn.Visible = !redBtn.Visible;
        }


    }
}
