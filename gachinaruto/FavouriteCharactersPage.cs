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
    public partial class FavouriteCharactersPage : Form
    {
        public FavouriteCharactersPage()
        {
            InitializeComponent();
            int x = 40;
            int y = 14;
            foreach (Person person in MainForm.favCharacters)
            {
                Panel panel = new Panel();
                panel.BorderStyle = BorderStyle.FixedSingle;
                panel.Location = new Point(x, y);
                panel.Size = new Size(196, 234);
                panel1.Controls.Add(panel);


                x = x + 240;
                if (x + 200 > panel1.Width)
                {
                    x = 40;
                    y = y + 252;
                }

                PictureBox picture = new PictureBox();
                picture.Location = new Point(3, 0);
                picture.SizeMode = PictureBoxSizeMode.Zoom;
                picture.Tag = person.name;
                try
                {
                    picture.Load("../../Pictures/Персонажи/" + person.name + ".jpg");
                }
                catch (Exception)
                {
                    try
                    {
                        picture.Load("../../Pictures/Персонажи/" + person.name + ".png");
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
                label.Text = person.name;
                panel.Controls.Add(label);
            }
        }

    }
}

