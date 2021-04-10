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
    public partial class CharacterForm : Form
    {
        /// <summary>
        /// Что за персонаж тут открыт
        /// </summary>
        Person hero;
        public CharacterForm(string name)
        {
            InitializeComponent();
            Text = name;
            try
            {
                pictureBox1.Load("../../Pictures/Персонажи/" + name + ".jpg");
            }
            catch (Exception)
            {
                try
                {
                    pictureBox1.Load("../../Pictures/Персонажи/" + name + ".png");
                }
                catch (Exception) { }
            }

            label1.Text = name;
            label2.Text =
                File.ReadAllText("../../Files/Персонажи/" + name + ".txt");
            foreach (Person hero1 in MainForm.people_list)
            {
                if (hero1.name == name)
                {
                    hero = hero1;
                    label3.Text = "Клан:" + " " + hero.clan;
                    label4.Text = "Принадлежность:" + " " + hero.from;
                    label5.Text = "Профессия:" + " " + hero.profession;

                    if (MainForm.favCharacters.Contains(hero))
                    {
                        button1.Text = "Убрать из любимых персонажей";
                    }
                }

            }

            if (MainForm.Language == "Russian")
                RenameAll(MainForm.RusWords);
            else if (MainForm.Language == "English")
                RenameAll(MainForm.EngWords);
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

        private void button1_Click(object sender, EventArgs e)
        {
            //Если нашли нужного
            if (button1.Text == "Добавить в любимых персонажей" &&
                !MainForm.favCharacters.Contains(hero))
            {
                //Добавляем в список любимых
                MainForm.favCharacters.Add(hero);
                button1.Text = "Убрать из любимых персонажей";
            }
            else if (button1.Text == "Убрать из любимых персонажей" &&
                        MainForm.favCharacters.Contains(hero))
            {
                //Убираем из списка любимых
                MainForm.favCharacters.Remove(hero);
                button1.Text = "Добавить в любимых персонажей";
            }
        }

        void RenameAll(Dictionary<string, string> Words)
        {
            try
            {
                
                label3.Text = Words["Клан:"] + " "  + hero.clan;
                label4.Text = Words["Принадлежность:"] + " "  + hero.from;
                label5.Text = Words["Профессия:"] + " "  + hero.profession;
                label6.Text = Words["Описание:"];
            }
            catch (Exception e)
            {
                string s = e.Message;
            }
        }
    }
}
