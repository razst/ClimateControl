﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Media;
using System.Net.Mail;
using System.Net;

namespace ClimateControll
{
    public partial class MainFRM : Form
    {
        private SerialPort mySerialPort;
        private string indata = "";
        private string[] tempHum;
        private string temp;
        private string hum;
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
               
                if (true/*checkAlaram(Properties.Settings.Default.minTemp, Properties.Settings.Default.maxTemp,
                    Properties.Settings.Default.maxHumidity,Properties.Settings.Default.minHumidity)*/) 
                {
                    playAlarm();
                }
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
        private Boolean checkAlaram(int minTemp, int maxTemp, int maxHum, int minHum)
        {
            int CurrectTemp = int.Parse(tempHum[1]);
            int Currecthum = int.Parse(tempHum[0]);
            if (CurrectTemp > maxTemp || CurrectTemp < minTemp || Currecthum > maxHum || Currecthum < minHum)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        private void playAlarm()
        {
            DateTime now = DateTime.Now;

            SoundPlayer soundAlarm = new SoundPlayer(@"C:\Users\pc\Documents\alarm.wav");
            soundAlarm.Play();
            if (Properties.Settings.Default.sendMail) { 
           /* MailMessage msg = new MailMessage("emailme.ydrive@gmail.com", Properties.Settings.Default.mailAdrees, "satlite", "azaka");
            msg.IsBodyHtml = true;
            SmtpClient sc = new SmtpClient("smtp.gmail.com", 587);
            sc.UseDefaultCredentials = false;
            NetworkCredential cre = new NetworkCredential("emailme.ydrive@gmail.com", "ydrive123");
            sc.Credentials = cre;
            sc.EnableSsl = true;
            sc.Send(msg);
            MessageBox.Show("massage send");*/
        }
            pbGreen.Visible = !pbGreen.Visible;
        }

        private void pbGreen_Click(object sender, EventArgs e)
        {

        }
    }
}
