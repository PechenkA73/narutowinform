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
    public partial class NewElementForm : Form
    {
        public NewElementForm()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool hasalreadybeen = false;
          
            if (comboBox1.Text == "Персонажи")
            {
                foreach(Person character in MainForm.people_list)
                {
                    if (character.name == textBox1.Text.Trim())
                    {
                        hasalreadybeen = true;
                    }
                }

                if(hasalreadybeen)
                {
                    MessageBox.Show("Такой персонаж уже существует");
                    return;
                }

                string clans = "";
                foreach (string item in filterclan.CheckedItems)
                    clans += ", " + item;
                if (clans.Length > 0)
                {
                    clans = clans.Substring(2);
                }


                string from = "";
                foreach (string item in filterfrom.CheckedItems)
                    from += ", " + item;
                if (from.Length > 0)
                {
                    from = from.Substring(2);
                }


                string professions = "";
                foreach (string item in filterprofession.CheckedItems)
                    professions += ", " + item;
                if (professions.Length > 0)
                {
                    professions = professions.Substring(2);
                }

                File.AppendAllText("CharactersFiles.txt", Environment.NewLine +
                  textBox1.Text.Trim() + "; " + clans + "; " + from + "; " + professions);
                FileStream fsc = File.Create("../../Files/Персонажи/" + textBox1.Text + ".txt");
                fsc.Close();
                File.WriteAllText("../../Files/Персонажи/" + textBox1.Text + ".txt", textBox2.Text);
            }
            else if(comboBox1.Text == "Кланы")
            {
                foreach(Clan clan in MainForm.clans_list)
                {
                    if (clan.name == textBox1.Text.Trim())
                    {
                        hasalreadybeen = true;
                    }
                }

                if (hasalreadybeen)
                {
                    MessageBox.Show("Такой клан уже существует");
                    return;
                }
                File.AppendAllText("ClansFiles.txt", Environment.NewLine + textBox1.Text);
                FileStream fsc = File.Create("../../Files/Кланы/" + textBox1.Text + ".txt");
                fsc.Close();
                File.WriteAllText("../../Files/Кланы/" + textBox1.Text + ".txt", textBox2.Text);
            }
            else if(comboBox1.Text == "Статьи")
            {
                foreach(Article article in MainForm.articles_list)
                {
                    if (article.name == textBox1.Text.Trim())
                    {
                        hasalreadybeen = true;
                    }
                }

                if (hasalreadybeen)
                {
                    MessageBox.Show("Такая статья уже существует");
                    return;
                }
                File.AppendAllText("ArticlesFiles.txt", Environment.NewLine + textBox1.Text);
                FileStream fsc = File.Create("../../Files/Статьи/" + textBox1.Text + "(1)" + ".txt");
                fsc.Close();
                File.WriteAllText("../../Files/Статьи/" + textBox1.Text + "(1)" + ".txt", textBox2.Text);

                FileStream fcc = File.Create("../../Files/Статьи/" + textBox1.Text + "(2)" + ".txt");
                fcc.Close();
                File.WriteAllText("../../Files/Статьи/" + textBox1.Text + "(2)" + ".txt", textBox3.Text);
            }
        
            if(address != "")
            {
                File.Copy(address, "../../Pictures/" + comboBox1.Text + "/" + textBox1.Text + ".jpg");
            }

            Close();
        }

        string address = "";

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text != "Персонажи")
            {
                characterpanel.Visible = false;
            }
            else if (comboBox1.Text == "Персонажи")
            {
                characterpanel.Visible = true;
            }

            if (comboBox1.Text != "Статьи")
            {
                articlepanel.Visible = false;
            }
            else if (comboBox1.Text == "Статьи")
            {
                articlepanel.Visible = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                address = openFileDialog1.FileName;
                pictureBox1.Load(address);
            }
        }

        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
            textBox6.Text = textBox6.Text.Replace(Environment.NewLine, "");
            if (e.KeyCode == Keys.Enter)
            {
                bool contains = false;
                foreach (string item in filterclan.Items)
                    if (item == textBox6.Text)
                        contains = true;

                if (!contains)
                {
                    filterclan.Items.Add(textBox6.Text);
                    textBox6.Text = "";
                }
            }
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            textBox5.Text = textBox5.Text.Replace(Environment.NewLine, "");
            if (e.KeyCode == Keys.Enter)
            {
                bool contains = false;
                foreach (string item in filterfrom.Items)
                    if (item == textBox5.Text)
                        contains = true;

                if (!contains)
                {
                    filterfrom.Items.Add(textBox5.Text);
                    textBox5.Text = "";
                }
            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            textBox4.Text = textBox4.Text.Replace(Environment.NewLine, "");
            if (e.KeyCode == Keys.Enter)
            {
                bool contains = false;
                foreach (string item in filterprofession.Items)
                    if (item == textBox4.Text)
                        contains = true;

                if (!contains)
                {
                    filterprofession.Items.Add(textBox4.Text);
                    textBox4.Text = "";
                }
            }
        }
    }
}
