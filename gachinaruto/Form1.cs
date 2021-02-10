using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gachinaruto
{
    public struct Person
    {
        public PictureBox picture;
        public Panel panel;
        public string name;
        public string clan;
        public string from;
        public string profession;
    }
    public partial class Form1 : Form
    {
        public Person[] people = new Person[8];

        public Form1()
        {
            InitializeComponent();

            people[0] = new Person
            {
                name = "Наруто Узумаки",
                panel = panel2,
                picture = narutouzumakipic,
                clan = "Узумаки",
                from = "Деревня Скрытого Листа",
                profession = "Хокаге",


            };
            people[1] = new Person {
                name = "Саске Учиха",
                panel = panel3,
                picture = pictureBox2,
                clan = "Учиха",
                from = "Деревня Скрытого Листаб, Деревня Скрытого Звука, Акацуки",
                profession = "Глава Клана Учиха",
            };
            people[2] = new Person
            {
                name = "Какаши Хатаке",
                panel = panel4,
                picture = pictureBox4,
                clan = "Хатаке",
                from = "Деревня Скрытого Листа",
                profession = "Хокаге",
            };
            people[3] = new Person
            {
                name = "Минато Намиказе",
                panel = panel6,
                picture = pictureBox5,
                clan = "Намиказе",
                from = "Деревня Скрытого Листа",
                profession = "Хокаге",

            };
            people[4] = new Person
            {
                name = "Итачи Учиха",
                panel = panel8,
                picture = pictureBox6,
                clan = "Учиха",
                from = "Деревня Скрытого Листа, Акацуки",
                profession = "Анбу",
            };
            people[5] = new Person
            {
                name = "Обито Учиха",
                panel = panel9,
                picture = pictureBox7,
                clan = "Учиха",
                from = "Деревня Скрытого Листа, Деревня Скрытого Тумана, Акацуки",
                profession = "Лидер Акацуки, Тайный лидер Киригакуре",
            };

            people[6] = new Person
            {
                name = "Хината Хьюга",
                panel = panel10,
                picture = pictureBox8,
                clan = "Хьюга, Узумаки",
                from = "Деревня Скрытого Листа",
                profession = "Наслденица Клана Хьюга",
            };

            people[7] = new Person
            {
                name = "Темари",
                panel = panel11,
                picture = pictureBox9,
                clan = "Клан Казекаге, Нара",
                from = "Деревня Скрытого Песка, Деревня Скрытого Листа",
                profession = "Телохранитель Казекаге",
            };

        }

        private void userpicture_Click(object sender, EventArgs e)
        {

        }

        private void labelclan_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void filterclan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                people[i].panel.Visible = true;
                if (clanComboBox.Text != "" &&
                    !people[i].clan.Contains(clanComboBox.Text))
                {
                    people[i].panel.Visible = false;
                }
                if (fromComboBox.Text != "" &&
                    !people[i].from.Contains(fromComboBox.Text))
                {
                    people[i].panel.Visible = false;
                }
                if (professionComboBox.Text != "" &&
                    !people[i].profession.Contains(professionComboBox.Text))
                {
                    people[i].panel.Visible = false;
                }

            }
            /*panel2.Visible = (filterclan.GetItemCheckState(1) == CheckState.Checked || 
                filterfrom.GetItemCheckState(0) == CheckState.Checked ||
                filterprofession.GetItemCheckState(0) == CheckState.Checked);
            panel3.Visible = (filterclan.GetItemCheckState(0) == CheckState.Checked || 
                filterfrom.GetItemCheckState(0) == CheckState.Checked);
            panel4.Visible = (filterclan.GetItemCheckState(4) == CheckState.Checked || 
                filterfrom.GetItemCheckState(0) == CheckState.Checked ||
                filterprofession.GetItemCheckState(0) == CheckState.Checked);
            panel6.Visible = (filterfrom.GetItemCheckState(0) == CheckState.Checked ||
                filterprofession.GetItemCheckState(0) == CheckState.Checked);
            panel8.Visible = (filterclan.GetItemCheckState(0) == CheckState.Checked ||
                filterfrom.GetItemCheckState(0) == CheckState.Checked ||
                filterfrom.GetItemCheckState(8) == CheckState.Checked ||
                filterprofession.GetItemCheckState(9) == CheckState.Checked);
            panel9.Visible = (filterclan.GetItemCheckState(0) == CheckState.Checked ||
                filterfrom.GetItemCheckState(0) == CheckState.Checked ||
                filterfrom.GetItemCheckState(8) == CheckState.Checked ||
                filterfrom.GetItemCheckState(5) == CheckState.Checked);*/
        }
        private void heroClick(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            PersonForm pf = new PersonForm(pb.Tag.ToString());
            pf.Show();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void privetusername_Click(object sender, EventArgs e)
        {
           
        }

        private void herosearch_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Саске Учиха" || 
                textBox1.Text == "Итачи Учиха")
            {
                people[0].panel.Visible = !people[0].panel.Visible;
                people[2].panel.Visible = !people[2].panel.Visible;
                people[3].panel.Visible = !people[3].panel.Visible;
            }
        }
    }
}
