using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace gachinaruto
{
    public partial class PersonForm : Form
    {
        public PersonForm(string name)
        {
            InitializeComponent();
            Text = name;
            pictureBox1.Load("../../Pictures/" + name + ".jpg");
            label1.Text = name;
            label2.Text =
                File.ReadAllText("../../Files/" + name + ".txt");
            foreach (Person hero in MainForm.people_list)
            {
                if (hero.name == name)
                {
                    label3.Text = "Клан: " + hero.clan;
                    label4.Text = "Принадлежность: " + hero.from;
                    label5.Text = "Профессия: " + hero.profession;
                }

            }

        } 

        private void PersonForm_Load(object sender, EventArgs e)
        {

        }

        private void userpicture_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
