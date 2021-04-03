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
            if (comboBox1.Text == "Персонажи")
            {
                File.AppendAllText("CharactersFiles.txt", Environment.NewLine +
                  textBox1.Text + "; " + filterclan.Text + "; " + filterfrom.Text + "; " + filterprofession.Text);
                FileStream fsc = File.Create("../../Files/" + comboBox1.Text + "/" + textBox1.Text + ".txt");
                fsc.Close();
                File.WriteAllText("../../Files/" + comboBox1.Text + "/" + textBox1.Text + ".txt", textBox2.Text);
            }
            else if(comboBox1.Text == "Кланы")
            {
                File.AppendAllText("ClansFiles.txt", Environment.NewLine + textBox1.Text);
                FileStream fsc = File.Create("../../Files/" + comboBox1.Text + "/" + textBox1.Text + ".txt");
                fsc.Close();
                File.WriteAllText("../../Files/" + comboBox1.Text + "/" + textBox1.Text + ".txt", textBox2.Text);
            }
            else if(comboBox1.Text == "Статьи")
            {
                File.AppendAllText("ArticlesFiles.txt", Environment.NewLine + textBox1.Text);
                FileStream fsc = File.Create("../../Files/" + comboBox1.Text + "/" + textBox1.Text + "(1)" + ".txt");
                fsc.Close();
                File.WriteAllText("../../Files/" + comboBox1.Text + "/" + textBox1.Text + "(1)" + ".txt", textBox2.Text);

                FileStream fcc = File.Create("../../Files/" + comboBox1.Text + "/" + textBox1.Text + "(2)" + ".txt");
                fcc.Close();
                File.WriteAllText("../../Files/" + comboBox1.Text + "/" + textBox1.Text + "(2)" + ".txt", textBox3.Text);
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
    }
}
