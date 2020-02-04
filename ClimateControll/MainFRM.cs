using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

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





        private SerialPort mySerialPort;
        private string indata = "";
        private string[] tempHum;
        private string temp;
        private string hum;
        private void DataReceivedHandler(
                                object sender,
                                SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            indata = sp.ReadLine();

            this.Invoke(new EventHandler(displayDataEvent));

        }

        private void displayDataEvent(object sender, EventArgs e)
        {
            if (indata.Contains(','))
            {
                tempHum = indata.Split(',');
                temp = tempHum[1];
                hum = tempHum[0];
                TbxHum.Text = hum;
                TbxTemp.Text = temp;
            }
        }


        private void startBut_Click(object sender, EventArgs e)
        {


            mySerialPort = new SerialPort(Properties.Settings.Default.port);

            mySerialPort.BaudRate = 9600;
            mySerialPort.Parity = Parity.None;
            mySerialPort.StopBits = StopBits.One;
            mySerialPort.DataBits = 8;
            mySerialPort.Handshake = Handshake.None;
            mySerialPort.RtsEnable = true;

            try
            {
                mySerialPort.Open();
            }
            catch
            {
                MessageBox.Show("unable to connect to temp sensor, check COM number in settings", "error");
            }


            mySerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
        }

        private void stopBut_Click(object sender, EventArgs e)
        {
            if (mySerialPort != null)
                mySerialPort.Close();
        }

        private void ArduConnect_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (mySerialPort != null)
                mySerialPort.Close();
        }

        private void MainFRM_Load(object sender, EventArgs e)
        {

        }
    }
}
