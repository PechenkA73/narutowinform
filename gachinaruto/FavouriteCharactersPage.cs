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
using System.IO;

namespace gachinaruto
{
    public partial class FavouriteCharactersPage : Form
    {
        public FavouriteCharactersPage()
        {
            InitializeComponent();

            try
            {
                privetusername.Text = UserForm.Login;
                userpicture.Load("../../Pictures/Users/" + UserForm.Login + ".jpg");
            }

            catch (Exception) { }

            int x = 40;
            int y = 14;
            foreach (Person person in MainForm.favCharacters)
            {
                FavCharacterUC fav = new FavCharacterUC(person);

                fav.Location = new Point(x, y);
                panel1.Controls.Add(fav);


                x = x + 240;
                if (x + 200 > panel1.Width)
                {
                    x = 40;
                    y = y + 252;
                }

            }

            if (MainForm.Language == "Russian")
                RenameAll(MainForm.RusWords);
            else if (MainForm.Language == "English")
                RenameAll(MainForm.EngWords);
        }
        void RenameAll(Dictionary<string, string> Words)
        {
            try
            {
                Text = Words["Страница с любимыми персонажами"];
                label1.Text = Words["Любимые персонажи"] + ":";
                label2.Text = Words["Ваша почта:"];
            }
            catch (Exception e)
            {
                string s = e.Message;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MailAddress fromMailAddress = new MailAddress("datwasjoke@gmail.com", "Программа по аниме Наруто");
            MailAddress toAddress = new MailAddress(textBox1.Text);
            MailMessage m = new MailMessage(fromMailAddress, toAddress);

            m.Subject = "Ваши любимые персонажи";
            m.Body = "Привет!" +
                Environment.NewLine + "Вот ваши любимые персонажи" +
                Environment.NewLine;

            File.WriteAllText("Ваши любимые персонажи.csv", 
                "Имя,Клан,Принадлежность,Профессия");
            foreach (Person person in MainForm.favCharacters)
            {
                m.Body = m.Body +
                    Environment.NewLine +
                    person.name + "( Клан " + person.clan + " )";

                File.AppendAllText("Ваши любимые персонажи.csv",
                    Environment.NewLine +
                    person.name + "," +
                    "\"" + person.clan + "\"," +
                    "\"" + person.from + "\"," +
                    "\"" + person.profession + "\"");

                try
                {
                    Attachment attachment = new Attachment("../../Pictures/Персонажи/" + person.name + ".jpg");
                    attachment.Name = person.name + ".jpg";
                    m.Attachments.Add(attachment);
                }
                catch (Exception)
                {
                    Attachment attachment = new Attachment("../../Pictures/Персонажи/" + person.name + ".png");
                    attachment.Name = person.name + ".jpg";
                    m.Attachments.Add(attachment);
                }
            }

            m.Attachments.Add(new Attachment("Ваши любимые персонажи.csv"));

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential("datwasjoke@gmail.com", "321654987datwasjoke");
            smtp.EnableSsl = true;
            smtp.Send(m);
            MessageBox.Show("Письмо отправлено");
            textBox1.Text = "";
        }
    }
}

