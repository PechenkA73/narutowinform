﻿using System;
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
    public partial class MainForm : Form
    {
        //public Person[] people = new Person[800];
        public List<Person> people_list = new List<Person>();

        public MainForm()
        {
            InitializeComponent();

            people_list.Add(new Person("Наруто Узумаки", "Узумаки", "Деревня Скрытого Листа", "Хокаге"));
            people_list.Add(new Person("Саске Учиха", "Учиха", "Деревня Скрытого Листа, Деревня Скрытого Звука, Акацуки", "Глава Клана Учиха"));
            people_list.Add(new Person("Какаши Хатаке", "Хатаке", "Деревня Скрытого Листа", "Хокаге"));
            people_list.Add(new Person("Минато Намиказе", "Намиказе", "Деревня Скрытого Листа", "Хокаге"));
            people_list.Add(new Person("Итачи Учиха", "Учиха", "Деревня Скрытого Листа, Акацуки", "Анбу"));
            people_list.Add(new Person("Обито Учиха", "Учиха", "Деревня Скрытого Листа, Деревня Скрытого Тумана, Акацуки", "Лидер Акацуки, Тайный лидер Киригакуре"));
            people_list.Add(new Person("Хината Хьюга", "Хьюга, Узумаки", "Деревня Скрытого Листа", "Наследница Клана Хьюга"));
            people_list.Add(new Person("Темари", "Клан Казекаге, Нара", "Деревня Скрытого Песка, Деревня Скрытого Листа", "Телохранитель Казекаге"));


            int x = 40;
            int y = 14;
            for (int i = 0; i < people_list.Count; i++)
            {
                people_list[i].panel.BorderStyle = BorderStyle.FixedSingle;
                people_list[i].panel.Location = new Point(x, y);
                people_list[i].panel.Size = new Size(196, 234);
                people_list[i].panel.Name = people_list[i].name;
                panel1.Controls.Add(people_list[i].panel);


                x = x + 240;
                if (x + 200 > panel1.Width)
                {
                    x = 40;
                    y = y + 252;
                }


                people_list[i].picture.Location = new Point(3, 0);
                people_list[i].picture.SizeMode = PictureBoxSizeMode.Zoom;
                people_list[i].picture.Tag = people_list[i].name;
                try
                {
                    people_list[i].picture.Load("../../Pictures/" + people_list[i].name + ".jpg");
                }
                catch (Exception) { }
                people_list[i].picture.Dock = DockStyle.Fill;
                people_list[i].picture.Click += new EventHandler(heroClick);
                people_list[i].panel.Controls.Add(people_list[i].picture);

                people_list[i].label.Dock = DockStyle.Bottom;
                people_list[i].label.Margin = new Padding(4, 0, 4, 0);
                people_list[i].label.TextAlign = ContentAlignment.MiddleCenter;
                people_list[i].label.Text = people_list[i].name;
                people_list[i].panel.Controls.Add(people_list[i].label);
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
            for (int i = 0; i < people_list.Count; i++)
            {
                people_list[i].panel.Visible = true;

                bool clanExist = false;
                foreach (string clan in filterclan.CheckedItems)
                {
                    if (people_list[i].clan.Contains(clan))
                        clanExist = true;
                }
                if (!clanExist && filterclan.CheckedItems.Count > 0)
                {
                    people_list[i].panel.Visible = false;
                }

                bool fromExist = false;
                foreach (string from in filterfrom.CheckedItems)
                {
                    if (people_list[i].from.Contains(from))
                        fromExist = true;
                }
                if (!fromExist && filterfrom.CheckedItems.Count > 0)
                {
                    people_list[i].panel.Visible = false;
                }

                bool professionExist = false;
                foreach (string profession in filterprofession.CheckedItems)
                {
                    if (people_list[i].profession.Contains(profession))
                        professionExist = true;
                }
                if (!professionExist && filterprofession.CheckedItems.Count > 0)
                {
                    people_list[i].panel.Visible = false;
                }

                if (people_list[i].panel.Visible)
                {
                    people_list[i].panel.Location = new Point(x, y);

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
            for (int i = 0; i < people_list.Count; i++)
            {
                people_list[i].panel.Visible = true;
                if (textBox1.Text != "" &&
                    !people_list[i].name.Contains(textBox1.Text))
                {
                    people_list[i].panel.Visible = false;
                }


                if (people_list[i].panel.Visible)
                {
                    people_list[i].panel.Location = new Point(x, y);

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

