using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace CRM
{
    public partial class SendMail : Form
    {
        public SendMail()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Guimail(txtuser.Text, txtTO.Text, txtSubject.Text, txtMess.Text);
            MessageBox.Show("Gui thanh cong");
        }
        void Guimail(string from, string to, string subject, string message)
        {
            MailMessage mess = new MailMessage(from, to, subject, message);
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;

            client.Credentials = new NetworkCredential(txtuser.Text, txtpass.Text);
            client.Send(mess);

        }
    }
}
