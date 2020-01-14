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
    public partial class MainFRM : Form
    {
        public MainFRM()
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
            ArduConnect frm2 = new ArduConnect();
            frm2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string s = "34,56";
            string [] s1;
            s1 = s.Split(',');
            Console.WriteLine(s1[0]);
            Console.WriteLine(s1[1]);

        }
    }
}
