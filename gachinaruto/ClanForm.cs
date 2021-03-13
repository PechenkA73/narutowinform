using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gachinaruto
{
    public partial class ClanForm : Form
    {
        /// <summary>
        /// Что за клан тут открыт
        /// </summary>
        string clanName;
        public ClanForm(string _name)
        {
            clanName = _name;
            InitializeComponent();
            Text = "Клан " + clanName;
            try
            {
                pictureBox1.Load("../../Pictures/Кланы/" + clanName + ".jpg");
            }
            catch (Exception)
            {
                try
                {
                    pictureBox1.Load("../../Pictures/Кланы/" + clanName + ".png");
                }
                catch (Exception) { }
            }

            label1.Text = "Клан " + clanName;
            label2.Text =
                File.ReadAllText("../../Files/Кланы/" + clanName + ".txt");

            int x = 10;
            foreach(Person pers in MainForm.people_list)
            {
                if (pers.clan.Contains(clanName))
                {
                    Panel panel = new Panel();
                    panel.BorderStyle = BorderStyle.FixedSingle;
                    panel.Location = new Point(x, 0);
                    panel.Size = new Size(190, 230);
                    panel.Name = pers.name;
                    panel1.Controls.Add(panel);


                    x = x + 200;

                    PictureBox picture = new PictureBox();
                    picture.Location = new Point(3, 0);
                    picture.SizeMode = PictureBoxSizeMode.Zoom;
                    picture.Tag = pers.name;
                    try
                    {
                        picture.Load("../../Pictures/Персонажи/" + pers.name + ".jpg");
                    }
                    catch (Exception)
                    {
                        try
                        {
                            picture.Load("../../Pictures/Персонажи/" + pers.name + ".png");
                        }
                        catch (Exception) { }
                    }
                    picture.Dock = DockStyle.Fill;
                    picture.Click += new EventHandler(MainForm.heroClick);
                    panel.Controls.Add(picture);

                    Label label = new Label();
                    label.Dock = DockStyle.Bottom;
                    label.Margin = new Padding(4, 0, 4, 0);
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.Text = pers.name;
                    panel.Controls.Add(label);
                }
            }
        }

       
    }
}
