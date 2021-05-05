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
    public partial class ArticleForm : Form
    {

        /// <summary>
        /// Что за статья тут открыта
        /// </summary>
        string articleName;
        public ArticleForm(string _name)
        {
            InitializeComponent();

            try
            {
                privetusername.Text = UserForm.Login;
                userpicture.Load("../../Pictures/Users/" + UserForm.Login + ".jpg");
            }

            catch (Exception) { }

            articleName = _name;
            Text = articleName;
            try
            {
                pictureBox1.Load("../../Pictures/Статьи/" + articleName + ".jpg");
            }
            catch (Exception)
            {
                try
                {
                    pictureBox1.Load("../../Pictures/Статьи/" + articleName + ".png");
                }
                catch (Exception) { }
            }

            label1.Text = articleName;
            label2.Text =
                File.ReadAllText("../../Files/Статьи/" + articleName + "(1)" + ".txt");
            label4.Text =
                File.ReadAllText("../../Files/Статьи/" + articleName + "(2)" + ".txt");

            int x = 10;
            int y = 5;
            foreach (Person pers in MainForm.people_list)
            {
                if (pers.from.Contains(articleName))
                {
                    Panel panel = new Panel();
                    panel.BorderStyle = BorderStyle.FixedSingle;
                    panel.Location = new Point(x, y);
                    panel.Size = new Size(panel1.Width / 2 - 30, 150); 
                    panel.Name = pers.name;
                    panel1.Controls.Add(panel);


                    x = x + panel1.Width / 2;
                    if (x + panel1.Width / 2 - 30 > panel1.Width)
                    {
                        x = 10;
                        y = y + 160;
                    }
                    
                    

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

            if (MainForm.Language == "Russian")
                RenameAll(MainForm.RusWords);
            else if (MainForm.Language == "English")
                RenameAll(MainForm.EngWords);
        }

        void RenameAll(Dictionary<string, string> Words)
        {
            try
            {
                label3.Text = Words["Обзор"];
                label5.Text = Words["Известные персонажи"];
            }
            catch (Exception e)
            {
                string s = e.Message;
            }
        }

    }
}
