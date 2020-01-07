using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using WMPLib;

namespace ClimateControll
{
    class units
    {
       public void Alarm()
        {
            WindowsMediaPlayer player = new WindowsMediaPlayer();
            player.URL = "alarm.mp3";
        }


        public void Send_Email(string emailAdress, string subject, string textBody)
        {
            MailMessage msg = new MailMessage("emailme.ydrive@gmail.com", emailAdress, subject, textBody);
            msg.IsBodyHtml = true;
            SmtpClient sc = new SmtpClient("smtp.gmail.com", 587);
            sc.UseDefaultCredentials = false;
            NetworkCredential cre = new NetworkCredential("emailme.ydrive@gmail.com", "ydrive123");
            sc.Credentials = cre;
            sc.EnableSsl = true;
            sc.Send(msg);
           // MessageBox.Show("massage send");
        }

    }
}
