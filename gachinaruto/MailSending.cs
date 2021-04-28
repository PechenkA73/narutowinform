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

namespace gachinaruto
{
    public partial class MailSending : Form
    {
        public MailSending()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MailAddress fromMailAddress = new MailAddress("datwasjoke@gmail.com", textBox1.Text);
            MailAddress toAddress = new MailAddress("datwasjoke@gmail.com");
            MailMessage m = new MailMessage(fromMailAddress, toAddress);
            
            m.Subject = "Письмо из программы NarutoWinForm";
            m.Body = textBox2.Text;
            m.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential("datwasjoke@gmail.com", "321654987datwasjoke");
            smtp.EnableSsl = true;
            smtp.Send(m);
            Close();
            MessageBox.Show("Письмо отправлено");
        }
    }
}
