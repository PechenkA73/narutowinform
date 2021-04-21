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
    public partial class ArticlesPage : Form
    {
        public ArticlesPage()
        {
            InitializeComponent();

            privetusername.Text = UserForm.Login;
            userpicture.Load("../../Pictures/Users/" + UserForm.Login + ".jpg");

            int x = 30;
            int y = 14;
            foreach (Article article in MainForm.articles_list)
            {
                article.panel.BorderStyle = BorderStyle.FixedSingle;
                article.panel.Location = new Point(x, y);
                article.panel.Size = new Size(panel1.Width / 2 - 50, 234);
                article.panel.Name = article.name;
                panel1.Controls.Add(article.panel);


                x = x + panel1.Width / 2;
                if (x + panel1.Width / 2 - 50 > panel1.Width)
                {
                    x = 30;
                    y = y + 252;
                }


                article.picture.Location = new Point(3, 0);
                article.picture.SizeMode = PictureBoxSizeMode.Zoom;
                article.picture.Tag = article.name;
                try
                {
                    article.picture.Load("../../Pictures/Статьи/" + article.name + ".jpg");
                }
                catch (Exception)
                {
                    try
                    {
                        article.picture.Load("../../Pictures/Статьи/" + article.name + ".png");
                    }
                    catch (Exception) { }
                }
                article.picture.Dock = DockStyle.Fill;
                article.picture.Click += new EventHandler(articleClick);
                article.panel.Controls.Add(article.picture);

                article.label.Dock = DockStyle.Bottom;
                article.label.Margin = new Padding(4, 0, 4, 0);
                article.label.TextAlign = ContentAlignment.MiddleCenter;
                article.label.Text = article.name;
                article.panel.Controls.Add(article.label);
            }

            if (MainForm.Language == "Russian")
                RenameAll(MainForm.RusWords);
            else if (MainForm.Language == "English")
                RenameAll(MainForm.EngWords);
        }
        public static void articleClick(object sender, EventArgs e)
        {
                PictureBox pb = (PictureBox)sender;
            ArticleForm af = new ArticleForm(pb.Tag.ToString());
                af.Show();
        }

        private void articlesearch_Click(object sender, EventArgs e)
        {
            int x = 30;
            int y = 14;
            foreach (Article article in MainForm.articles_list)
            {
                article.panel.Visible = true;
                if (textBox1.Text != "" &&
                    !article.name.Contains(textBox1.Text))
                {
                    article.panel.Visible = false;
                }


                if (article.panel.Visible)
                {
                    article.panel.Location = new Point(x, y);

                    x = x + panel1.Width / 2;
                    if (x + panel1.Width / 2 - 50 > panel1.Width)
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
                Text = Words["Страница со статьями"];
                label1.Text = Words["Найти статью:"];
                articlesearch.Text = Words["Поиск"];
               
             
            }
            catch (Exception e)
            {
                string s = e.Message;
            }
        }
    }
}
