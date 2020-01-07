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
    public partial class ArduConnect : Form
    {
        public ArduConnect()
        {
            InitializeComponent();
        }

        private SerialPort mySerialPort;
        private string indata = "";


        private void Form1_Load(object sender, EventArgs e)
        {
        }

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
            data.Text = indata;
        }


        private void button1_Click(object sender, EventArgs e)
        {


            mySerialPort = new SerialPort(tbPortName.Text);

            mySerialPort.BaudRate = 9600;
            mySerialPort.Parity = Parity.None;
            mySerialPort.StopBits = StopBits.One;
            mySerialPort.DataBits = 8;
            mySerialPort.Handshake = Handshake.None;
            mySerialPort.RtsEnable = true;

            mySerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

            mySerialPort.Open();




        }

        private void button2_Click(object sender, EventArgs e)
        {
            mySerialPort.Close();
        }
    }
}
