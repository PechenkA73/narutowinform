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
        public static string Login = "";
        public static string Image = "";

        public UserForm()
        {
            InitializeComponent();
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
            }
            else
            {
                Height = 500;
                Width = 800;
                panel1.Location = new Point(285, 34);
                panel2.Visible = false;
                button1.Text = "Зарегестрироваться";
                button2.Text = "Войти";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;
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
            else if(button2.Text == "Войти")
            {
                string[] lines = File.ReadAllLines("../../Files/Data Files.txt");
                for(int i = 0; i < lines.Length; i += 2)
                {
                    Login = textBox1.Text;
                    if(textBox1.Text == lines[i] && textBox2.Text == lines[i+1])
                    {
                        MessageBox.Show("Приветсвуем," + Login + "!");
                        Close();
                    }
                }

            }

            if (address != "")
            {
                File.Copy(address, "../../Pictures/Users/" + textBox1.Text + ".jpg");
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
    }
}
