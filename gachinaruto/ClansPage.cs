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
    public partial class ClansPage : Form
    {
        public ClansPage()
        {
            InitializeComponent();

            int x = 30;
            int y = 14;
            foreach (Clan clan in MainForm.clans_list)
            {
                clan.panel.BorderStyle = BorderStyle.FixedSingle;
                clan.panel.Location = new Point(x, y);
                clan.panel.Size = new Size(panel1.Width / 3 - 50, 234);
                clan.panel.Name = clan.name;
                panel1.Controls.Add(clan.panel);


                x = x + panel1.Width / 3;
                if (x + panel1.Width / 3 - 50 > panel1.Width)
                {
                    x = 30;
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
                clan.picture.Click += new EventHandler(clanClick);
                clan.panel.Controls.Add(clan.picture);

                clan.label.Dock = DockStyle.Bottom;
                clan.label.Margin = new Padding(4, 0, 4, 0);
                clan.label.TextAlign = ContentAlignment.MiddleCenter;
                clan.label.Text = clan.name;
                clan.panel.Controls.Add(clan.label);
            }

            if (MainForm.Language == "Russian")
                RenameAll(MainForm.RusWords);
            else if (MainForm.Language == "English")
                RenameAll(MainForm.EngWords);
        }
        public static void clanClick(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            ClanForm pf = new ClanForm(pb.Tag.ToString());
            pf.Show();
        }

        private void clansearch_Click(object sender, EventArgs e)
        {
            int x = 30;
            int y = 14;
            foreach (Clan clans in MainForm.clans_list)
            {
                clans.panel.Visible = true;
                if (textBox1.Text != "" &&
                    !clans.name.Contains(textBox1.Text))
                {
                    clans.panel.Visible = false;
                }


                if (clans.panel.Visible)
                {
                    clans.panel.Location = new Point(x, y);

                    x = x + panel1.Width / 3;
                    if (x + panel1.Width / 3 - 50 > panel1.Width)
                    {
                        x = 30;
                        y = y + 252;
                    }
                }
            }

        }
        void RenameAll(Dictionary<string, string> Words)
        {
            try
            {
                Text = Words["Страница с кланами"];
                label1.Text = Words["Кланы"];
                clansearch.Text = Words["Поиск"];
            }
            catch (Exception e)
            {
                string s = e.Message;
            }
        }
    }
}
