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
using System.Media;
using System.Net.Mail;
using System.Net;
using Google.Cloud.Firestore;
using System.Threading;

namespace ClimateControll
{

    public partial class MainFRM : Form
    {
        

        private TempInfo t = new TempInfo();
        private DateTime lastReport = DateTime.Now;
        private long lastAlarmTime = 0;
        private SerialPort mySerialPort;
        private string indata = "";
        private string[] tempHum;
        private string temp;
        private string hum;
        static public FirestoreDb db = FirestoreDb.Create("climatehistory-3ff7e");
        static public string COLLECTION_NAME = "ClimateInfo";
        private Random rndTemp = new Random();
        private Random rndHum = new Random();
        private CancellationTokenSource source = new CancellationTokenSource();
        private bool stop = false;
        public MainFRM()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            stopSerial();
            Application.Exit();
        }

        private void config_Click(object sender, EventArgs e)
        {
            SettingsFRM frm = new SettingsFRM();
            frm.Show();
        }
        private async void TestModeData()
        {
            if (!stop)
            {
                await Task.Delay(TimeSpan.FromSeconds(2), source.Token);
                indata = rndHum.Next(70, 90) + "," + rndTemp.Next(20, 30);
                this.Invoke(new EventHandler(displayDataEvent));
            }
        }

        private void DataReceivedHandler(
                                object sender,
                                SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            indata = sp.ReadLine();

            this.Invoke(new EventHandler(displayDataEvent));

        }
        

        private async void displayDataEvent(object sender, EventArgs e)
        {
            if (indata.Contains(','))
            {
                DateTime now = DateTime.Now;
                long nowUnixTime = ((DateTimeOffset)now).ToUnixTimeSeconds();
                long lastUnixTime = ((DateTimeOffset)lastReport).ToUnixTimeSeconds();
                tempHum = indata.Split(',');
                temp = tempHum[1];
                hum = tempHum[0];
                TbxHum.Text = hum;
                TbxTemp.Text = temp;

                if (nowUnixTime - lastUnixTime > 60)//TODO: change "10"
                {
                    t.WhenUNIX = nowUnixTime;
                    t.WhenString = now.ToString("yyyy-MM-dd HH:mm:ss");
                    t.Temperature = float.Parse(temp);
                    t.Humidity = float.Parse(hum);

                    DocumentReference docRef = db.Collection(COLLECTION_NAME).Document(t.WhenUNIX.ToString());


                    await docRef.SetAsync(t);

                    lastReport = now;
                }
                
                if (checkAlaram(Properties.Settings.Default.minTemp, Properties.Settings.Default.maxTemp,
                    Properties.Settings.Default.maxHumidity,Properties.Settings.Default.minHumidity)) 
                {
                    playAlarm();
                    sendEmail();
                }
                else 
                {
                    stopAlarm();
                }
                if (Properties.Settings.Default.TestMode)
                {
                    TestModeData();
                }
            }

        }


        private void startBut_Click(object sender, EventArgs e)
        {
            stop = false;
            if (!Properties.Settings.Default.TestMode)
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
            else
            {
                TestModeData();
            }


        }

        private void stopSerial()
        {
            if (mySerialPort != null)
                mySerialPort.Close();

        }
        private void stopBut_Click(object sender, EventArgs e)
        {
            stopSerial();
            stop = !stop;
            
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

        private void sendEmail()
        {
            // CHECK IF THISIS TIME TO SEND AN EMAIL
            DateTime now = DateTime.Now;
            long nowUnixTime = ((DateTimeOffset)now).ToUnixTimeSeconds();
            int CurrectTemp = int.Parse(tempHum[1]);
            int Currecthum = int.Parse(tempHum[0]);

            if (Properties.Settings.Default.sendMail && ((nowUnixTime - lastAlarmTime) > 600))
            {
                MailMessage msg = new MailMessage("emailme.ydrive@gmail.com", Properties.Settings.Default.mailAdrees, "Climate Control Alarm", "Temperature=" + CurrectTemp+"\nHumidity="+Currecthum);
                msg.IsBodyHtml = true;
                SmtpClient sc = new SmtpClient("smtp.gmail.com", 587);
                sc.UseDefaultCredentials = false;
                NetworkCredential cre = new NetworkCredential("emailme.ydrive@gmail.com", "ydrive123");
                sc.Credentials = cre;
                sc.EnableSsl = true;
                sc.Send(msg);
                lastAlarmTime = ((DateTimeOffset)now).ToUnixTimeSeconds();
            }

        }
        private void playAlarm()
        {
            SoundPlayer soundAlarm = new SoundPlayer(ClimateControll.Properties.Resources.alarm);
            if(Properties.Settings.Default.turnOnAlert) soundAlarm.Play();
            pbGreen2.Visible = false;
        }
        private void stopAlarm()
        {
            DateTime now = DateTime.Now;
            SoundPlayer soundAlarm = new SoundPlayer(@"C:\Users\pc\Documents\GitHub\ClimateControl\alarm.wav");
            soundAlarm.Stop();
            pbGreen2.Visible = true;
        }

        private void pbGreen_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            History frm2 = new History();
            frm2.Show();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
