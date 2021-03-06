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
        string name;
        public CharacterForm(string _name)
        {
            name = _name;
            InitializeComponent();
            Text = name;
            try
            {
                pictureBox1.Load("../../Pictures/" + name + ".jpg");
            }
            catch (Exception)
            {
                try
                {
                    pictureBox1.Load("../../Pictures/" + name + ".png");
                }
                catch (Exception) { }
            }

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

        private void button1_Click(object sender, EventArgs e)
        {
            //Бегаем по всем
            foreach(Person person in MainForm.people_list)
            {
                //Если нашли нужного
                if (button1.Text == "Добавить в любимых персонажей" &&
                    person.name == name &&
                    !MainForm.favCharacters.Contains(person))
                {
                    //Добавляем в список любимых
                    MainForm.favCharacters.Add(person);
                    button1.Text = "Убрать из любимых персонажей";
                }
                else if (button1.Text == "Убрать из любимых персонажей" &&
                         person.name == name &&
                         MainForm.favCharacters.Contains(person))
                {
                    //Убираем из списка любимых
                    MainForm.favCharacters.Remove(person);
                    button1.Text = "Добавить в любимых персонажей";
                }
                
            }
        }
    }
}
