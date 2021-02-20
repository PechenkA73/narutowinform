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
        public Label label;
        public string name;
        public string clan;
        public string from;
        public string profession;

        public Person(string name1, string clan1, string from1, string profession1)
        {
            picture = new PictureBox();
            panel = new Panel();
            label = new Label();
            name = name1;
            clan = clan1;
            from = from1;
            profession = profession1;
        }

    }
    public partial class Form1 : Form
    {
        public Person[] people = new Person[800];

        public Form1()
        {
            InitializeComponent();

            people[0] = new Person("Наруто Узумаки", "Узумаки", "Деревня Скрытого Листа", "Хокаге");
            people[1] = new Person("Саске Учиха", "Учиха", "Деревня Скрытого Листаб, Деревня Скрытого Звука, Акацуки", "Глава Клана Учиха");
            people[2] = new Person("Какаши Хатаке", "Хатаке", "Деревня Скрытого Листа", "Хокаге");
            people[3] = new Person("Минато Намиказе", "Намиказе", "Деревня Скрытого Листа", "Хокаге");
            people[4] = new Person("Итачи Учиха", "Учиха", "Деревня Скрытого Листа, Акацуки", "Анбу");
            people[5] = new Person("Обито Учиха", "Учиха", "Деревня Скрытого Листа, Деревня Скрытого Тумана, Акацуки", "Лидер Акацуки, Тайный лидер Киригакуре");
            people[6] = new Person("Хината Хьюга", "Хьюга, Узумаки", "Деревня Скрытого Листа", "Наследница Клана Хьюга");
            people[7] = new Person("Темари", "Клан Казекаге, Нара", "Деревня Скрытого Песка, Деревня Скрытого Листа", "Телохранитель Казекаге");

            int x = 40;
            int y = 14;
            for (int i = 0; i < 8; i++)
            {
                Panel panel = new Panel();
                people[i].panel = panel;
                panel.BorderStyle = BorderStyle.FixedSingle;
                panel.Location = new Point(x, y);
                panel.Size = new Size(196, 234);
                panel.Name = people[i].name;
                panel1.Controls.Add(panel);


                x = x + 240;
                if (x + 200 > panel1.Width)
                {
                    x = 40;
                    y = y + 252;
                }


                PictureBox pb1 = new PictureBox();
                pb1.Location = new Point(3, 0);
                pb1.Size = new Size(247, 120);
                pb1.SizeMode = PictureBoxSizeMode.Zoom;
                pb1.Tag = people[i].name;
                try
                {
                    pb1.Load("../../Pictures/" + people[i].name + ".jpg");
                }
                catch (Exception) { }
                pb1.Dock = DockStyle.Fill;
                pb1.Click += new EventHandler(heroClick);
                people[i].panel.Controls.Add(pb1);
                people[i].picture = pb1;

                Label lb1 = new Label();
                lb1.Dock = DockStyle.Bottom;
                lb1.Location = new Point(0, 207);
                lb1.Margin = new Padding(4, 0, 4, 0);
                lb1.TextAlign = ContentAlignment.MiddleCenter;
                lb1.Name = people[i].name;
                lb1.Text = people[i].name;
                people[i].panel.Controls.Add(lb1);
                people[i].label = lb1;
            }

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
            int x = 40;
            int y = 14;
            for (int i = 0; i < 8; i++)
            {
                people[i].panel.Visible = true;

                bool clanExist = false;
                foreach (string clan in filterclan.CheckedItems)
                {
                    if (people[i].clan.Contains(clan))
                        clanExist = true;
                }
                if (!clanExist && filterclan.CheckedItems.Count > 0)
                {
                    people[i].panel.Visible = false;
                }

                bool fromExist = false;
                foreach (string from in filterfrom.CheckedItems)
                {
                    if (people[i].from.Contains(from))
                        fromExist = true;
                }
                if (!fromExist && filterfrom.CheckedItems.Count > 0)
                {
                    people[i].panel.Visible = false;
                }
               
                bool professionExist = false;
                foreach (string profession in filterprofession.CheckedItems)
                {
                    if (people[i].profession.Contains(profession))
                        professionExist = true;
                }
                if (!professionExist && filterprofession.CheckedItems.Count > 0)
                {
                    people[i].panel.Visible = false;
                }
                

                if (people[i].panel.Visible)
                {
                    people[i].panel.Location = new Point(x, y);

                    x = x + 240;
                    if (x + 200 > panel1.Width)
                    {
                        x = 40;
                        y = y + 252;
                    }
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
            int x = 40;
            int y = 14;
            for (int i = 0; i < 8; i++)
            {
                people[i].panel.Visible = true;
                if (textBox1.Text != "" &&
                    !people[i].name.Contains(textBox1.Text))
                {
                    people[i].panel.Visible = false;
                }


                if (people[i].panel.Visible)
                {
                    people[i].panel.Location = new Point(x, y);

                    x = x + 240;
                    if (x + 200 > panel1.Width)
                    {
                        x = 40;
                        y = y + 252;
                    }
                }
            }
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

