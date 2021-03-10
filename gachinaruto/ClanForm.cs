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
    public partial class ClanForm : Form
    {
        public ClanForm()
        {
            InitializeComponent();

            int x = 40;
            int y = 14;
            foreach (Clan clan in MainForm.clans_list)
            {
                clan.panel.BorderStyle = BorderStyle.FixedSingle;
                clan.panel.Location = new Point(x, y);
                clan.panel.Size = new Size(196, 234);
                clan.panel.Name = clan.name;
                panel1.Controls.Add(clan.panel);


                x = x + 240;
                if (x + 200 > panel1.Width)
                {
                    x = 40;
                    y = y + 252;
                }


                clan.picture.Location = new Point(3, 0);
                clan.picture.SizeMode = PictureBoxSizeMode.Zoom;
                clan.picture.Tag = clan.name;
                try
                {
                    clan.picture.Load("../../Pictures/Кланы/" + clan.name + ".jpg");
                }
                catch (Exception)
                {
                    try
                    {
                        clan.picture.Load("../../Pictures/Кланы/" + clan.name + ".png");
                    }
                    catch (Exception) { }
                }
                clan.picture.Dock = DockStyle.Fill;
                //clan_list[i].picture.Click += new EventHandler(heroClick);
                clan.panel.Controls.Add(clan.picture);

                clan.label.Dock = DockStyle.Bottom;
                clan.label.Margin = new Padding(4, 0, 4, 0);
                clan.label.TextAlign = ContentAlignment.MiddleCenter;
                clan.label.Text = clan.name;
                clan.panel.Controls.Add(clan.label);
            }
        }
    }
}
