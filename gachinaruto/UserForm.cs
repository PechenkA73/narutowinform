using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gachinaruto
{
    public partial class UserForm : Form
    {
        /// <summary>
        /// Зарегистрироваться / войти
        /// </summary>
        bool isRegister = false;
        public static string Login = "";
        public static string Image = "";

        public UserForm()
        {
            InitializeComponent();

            if (MainForm.Language == "Russian")
                RenameAll(MainForm.RusWords);
            else if (MainForm.Language == "English")
                RenameAll(MainForm.EngWords);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Height == 500 && Width == 800)
            {
                Height = 650;
                Width = 1000;
                panel1.Location = new Point(435, 34);
                panel2.Visible = true;
                button2.Text = "Подтвердить";
                button1.Text = "Вернуться назад";
                isRegister = false;
            }
            else
            {
                Height = 500;
                Width = 800;
                panel1.Location = new Point(285, 34);
                panel2.Visible = false;
                button1.Text = "Зарегестрироваться";
                button2.Text = "Войти";
                isRegister = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            textBox2.UseSystemPasswordChar = !textBox2.UseSystemPasswordChar;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Подтвердить")
            {
                File.AppendAllText("../../Files/Data Files.txt",
                    Environment.NewLine + textBox1.Text +
                    Environment.NewLine + textBox2.Text);
                button1_Click(sender, e);
                textBox1.Text = "";
                textBox2.Text = "";
            }
            else if (button2.Text == "Войти")
            {
                string[] lines = File.ReadAllLines("../../Files/Data Files.txt");
                for (int i = 0; i < lines.Length; i += 2)
                {
                    if (textBox1.Text == lines[i] && textBox2.Text == lines[i + 1])
                    {
                        Login = textBox1.Text;
                        if (MainForm.Language == "Russian")
                            MessageBox.Show("Приветсвуем," + Login + "!");
                        else
                            MessageBox.Show("Hello," + Login + "!");


                        if (File.Exists(Login + ".txt"))
                        {
                            string[] lines2 = File.ReadAllLines(Login + ".txt");
                            MainForm.favCharacters.Clear();
                            foreach (Person p in MainForm.people_list)
                            {
                                if (lines2.Contains(p.name))
                                    MainForm.favCharacters.Add(p);
                            }
                        }
                        Close();
                        return;
                    }
                }

                if (MainForm.Language == "Russian")
                    MessageBox.Show("Неправильный логин или пароль, попробуйте ещё раз!");
                else
                    MessageBox.Show("Wrong user login or password, try again!");

                textBox1.Text = "";
                textBox2.Text = "";
            }

            if (address != "")
            {
                File.Copy(address, "../../Pictures/Users/" + UserForm.Login + ".jpg");
            }
        }

        string address = "";
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                address = openFileDialog1.FileName;
                pictureBox1.Load(address);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MailSending ms = new MailSending();
            ms.ShowDialog();
        }

        void RenameAll(Dictionary<string, string> Words)
        {
            try
            {
                Text = Words["Страница логина"];
                label1.Text = Words["Логин:"];
                label2.Text = Words["Пароль:"];
                label3.Text = Words["Добавьте картинку профиля"];
                toolTip1.RemoveAll();
                toolTip1.SetToolTip(pictureBox3, Words["Обратная связь"]);
                linkLabel1.Text = Words["Показать пароль"];
                if (isRegister)
                {
                    button1.Text = Words["Зарегестрироваться"];
                    button2.Text = Words["Войти"];
                }
                else
                {
                    button1.Text = Words["Вернуться назад"];
                    button2.Text = Words["Подтвердить"];
                }
                
            }
            catch (Exception e)
            {
                string s = e.Message;
            } 
            
        }

            
      
    }
}
