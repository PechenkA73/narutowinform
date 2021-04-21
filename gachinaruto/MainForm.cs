using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gachinaruto
{
    public struct Person
    {
        public PictureBox picture;
        public Panel panel;
        public Label label;
        /// <summary>
        /// Имя персонажа
        /// </summary>
        public string name;
        public string clan;
        public string from;
        public string profession;

        public Person(string name1, string clan1, string from1, string profession1)
        {
            picture = new PictureBox();
            panel = new Panel();
            label = new Label();
            name = name1;
            clan = clan1;
            from = from1;
            profession = profession1;
        }
    }

    public struct Clan
    {
        public PictureBox picture;
        public Panel panel;
        public Label label;
        /// <summary>
        /// Название клана
        /// </summary>
        public string name;

        public Clan(string name1)
        {
            picture = new PictureBox();
            panel = new Panel();
            label = new Label();
            name = name1;
        }
    }

    public struct Article
    {
        public PictureBox picture;
        public Panel panel;
        public Label label;
        /// <summary>
        /// Название статьи
        /// </summary>
        public string name;

        public Article(string name1)
        {
            picture = new PictureBox();
            panel = new Panel();
            label = new Label();
            name = name1;
        }
    }

    public partial class MainForm : Form
    {
        /// <summary>
        /// Все персонажи
        /// </summary>
        public static List<Person> people_list = new List<Person>();

        /// <summary>
        /// Любимые
        /// </summary>
        public static List<Person> favCharacters = new List<Person>();

        /// <summary>
        /// Все кланы
        /// </summary>
        public static List<Clan> clans_list = new List<Clan>();

        /// <summary>
        /// Все статьи
        /// </summary>
        public static List<Article> articles_list = new List<Article>();

        public static string Language = "Russian";
        /// <summary>
        /// Перевод на Русский
        /// </summary>
        public static Dictionary<string, string> RusWords = new Dictionary<string, string>();
        /// <summary>
        /// Перевод на Английский
        /// </summary>
        public static Dictionary<string, string> EngWords = new Dictionary<string, string>();

        void FillWords()
        {
            /// <summary>
            /// Перевод главной страницы
            /// </summary>
            RusWords.Add("Главная страница", "Главная страница");
            RusWords.Add("Найти персонажа:", "Найти персонажа:");
            RusWords.Add("Поиск", "Поиск");
            RusWords.Add("Клан:", "Клан:");
            RusWords.Add("Принадлежность:", "Принадлежность:");         
            RusWords.Add("Профессия:", "Профессия:");
            RusWords.Add("Применить", "Применить");
            RusWords.Add("Любимые персонажи", "Любимые персонажи");
            RusWords.Add("Кланы", "Кланы");
            RusWords.Add("Статьи", "Статьи");
            
            EngWords.Add("Главная страница", "Main page");
            EngWords.Add("Найти персонажа:", "Find character:");
            EngWords.Add("Поиск", "Search");
            EngWords.Add("Клан:", "Clan:");
            EngWords.Add("Принадлежность:", "From:");
            EngWords.Add("Профессия:", "Profession:");
            EngWords.Add("Применить", "Apply");
            EngWords.Add("Любимые персонажи", "Favourite characters");
            EngWords.Add("Кланы", "Clans");
            EngWords.Add("Статьи", "Articles");

            /// <summary>
            /// Перевод страницы с кланом
            /// </summary>
            RusWords.Add("Известные члены клана:", "Известные члены клана:");
            RusWords.Add("Клан", "Клан");
            RusWords.Add("Описание:", "Описание:");

            EngWords.Add("Известные члены клана:", "Famous clan members:");
            EngWords.Add("Клан", "Clan");
            EngWords.Add("Описание:", "Description:");

            /// <summary>
            /// Перевод страницы с любимыми персонажами
            /// </summary>
            RusWords.Add("Страница с любимыми персонажами", "Страница с любимыми персонажами");
            EngWords.Add("Страница с любимыми персонажами", "Favourite characters page");

            /// <summary>
            /// Перевод страницы с поиском кланов
            /// </summary>
            RusWords.Add("Страница с кланами", "Страница с кланами");
            EngWords.Add("Страница с кланами", "Clans page");

            /// <summary>
            /// Перевод страницы с поиском статей
            /// </summary>
            RusWords.Add("Страница со статьями", "Страница со статьями");
            RusWords.Add("Найти статью:", "Найти статью:");

            EngWords.Add("Страница со статьями", "Articles page");
            EngWords.Add("Найти статью:", "Find article:");

            /// <summary>
            /// Перевод страницы со статьёй
            /// </summary>
            RusWords.Add("Обзор", "Обзор");
            RusWords.Add("Известные персонажи", "Известные персонажи");

            EngWords.Add("Обзор", "Review");
            EngWords.Add("Известные персонажи", "Famous characters");
        }

        /// <summary>
        /// Перевод всего на какой-то язык
        /// </summary>
        void RenameAll(Dictionary<string, string> Words)
        {
            try
            {
                Text = Words["Главная страница"];
                naitipersonaja.Text = Words["Найти персонажа:"];
                herosearch.Text = Words["Поиск"];
                labelclan.Text = Words["Клан:"];
                labelfrom.Text = Words["Принадлежность:"];
                labelprofession.Text = Words["Профессия:"];
                button1.Text = Words["Применить"];
                toolTip1.SetToolTip(articleicon, Words ["Статьи"]);
                toolTip1.SetToolTip(clanpagebutton, Words ["Кланы"]);
                string FavPersons = Words["Любимые персонажи"];
                toolTip1.SetToolTip(favouritepersonpagebutton, FavPersons);
            }
            catch (Exception e)
            {
                string s = e.Message;
            }
        }

        private void RussianClick(object sender, EventArgs e)
        {
            RenameAll(RusWords);
            Language = "Russian";
        }
        private void EnglishClick(object sender, EventArgs e)
        {
            RenameAll(EngWords);
            Language = "English";
        }

        public MainForm()
        {
            InitializeComponent(); 
            
            FillWords();

            string[] lines = File.ReadAllLines("ArticlesFiles.txt");
            foreach (string line in lines)
            {
                string[] articles = line.Split(new string[] { "," }, StringSplitOptions.None);
                articles_list.Add(new Article(articles[0]));
            }



            lines = File.ReadAllLines("ClansFiles.txt");
            foreach (string line in lines)
            {
                string[] clans = line.Split(new string[] { "," }, StringSplitOptions.None);
                clans_list.Add(new Clan(clans[0]));
            }



            lines = File.ReadAllLines("CharactersFiles.txt");
            foreach (string line in lines)
            {
                string[] people = line.Split(new string[] { "; " }, StringSplitOptions.None);
                if (people.Length > 3)
                    people_list.Add(new Person(people[0], people[1], people[2], people[3]));
            }


            




            int x = 40;
            int y = 14;
            for (int i = 0; i < people_list.Count; i++)
            {
                people_list[i].panel.BorderStyle = BorderStyle.FixedSingle;
                people_list[i].panel.Location = new Point(x, y);
                people_list[i].panel.Size = new Size(196, 234);
                people_list[i].panel.Name = people_list[i].name;
                panel1.Controls.Add(people_list[i].panel);


                x = x + 240;
                if (x + 200 > panel1.Width)
                {
                    x = 40;
                    y = y + 252;
                }


                people_list[i].picture.Location = new Point(3, 0);
                people_list[i].picture.SizeMode = PictureBoxSizeMode.Zoom;
                people_list[i].picture.Tag = people_list[i].name;
                try
                {
                    people_list[i].picture.Load("../../Pictures/Персонажи/" + people_list[i].name + ".jpg");
                }
                catch (Exception) 
                {
                    try
                    {
                        people_list[i].picture.Load("../../Pictures/Персонажи/" + people_list[i].name + ".png");
                    }
                    catch (Exception) { }
                }
                people_list[i].picture.Dock = DockStyle.Fill;
                people_list[i].picture.Click += new EventHandler(heroClick);
                people_list[i].panel.Controls.Add(people_list[i].picture);

                people_list[i].label.Dock = DockStyle.Bottom;
                people_list[i].label.Margin = new Padding(4, 0, 4, 0);
                people_list[i].label.TextAlign = ContentAlignment.MiddleCenter;
                people_list[i].label.Text = people_list[i].name;
                people_list[i].panel.Controls.Add(people_list[i].label);
            }

        }

        private void userpicture_Click(object sender, EventArgs e)
        {
            UserForm uf = new UserForm();
            uf.ShowDialog();

            newelementicon.Visible = (UserForm.Login == "абоба");

            privetusername.Text = UserForm.Login;
            userpicture.Load("../../Pictures/Users/" + UserForm.Login + ".jpg");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 40;
            int y = 14;
            for (int i = 0; i < people_list.Count; i++)
            {
                people_list[i].panel.Visible = true;

                bool clanExist = false;
                foreach (string clan in filterclan.CheckedItems)
                {
                    if (people_list[i].clan.Contains(clan))
                        clanExist = true;
                }
                if (!clanExist && filterclan.CheckedItems.Count > 0)
                {
                    people_list[i].panel.Visible = false;
                }

                bool fromExist = false;
                foreach (string from in filterfrom.CheckedItems)
                {
                    if (people_list[i].from.Contains(from))
                        fromExist = true;
                }
                if (!fromExist && filterfrom.CheckedItems.Count > 0)
                {
                    people_list[i].panel.Visible = false;
                }

                bool professionExist = false;
                foreach (string profession in filterprofession.CheckedItems)
                {
                    if (people_list[i].profession.Contains(profession))
                        professionExist = true;
                }
                if (!professionExist && filterprofession.CheckedItems.Count > 0)
                {
                    people_list[i].panel.Visible = false;
                }

                if (people_list[i].panel.Visible)
                {
                    people_list[i].panel.Location = new Point(x, y);

                    x = x + 240;
                    if (x + 200 > panel1.Width)
                    {
                        x = 40;
                        y = y + 252;
                    }
                }
            }
           
        }
        public static void heroClick(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            CharacterForm pf = new CharacterForm(pb.Tag.ToString());
            pf.Show();
        }
        
        private void herosearch_Click(object sender, EventArgs e)
        {
            int x = 40;
            int y = 14;
            for (int i = 0; i < people_list.Count; i++)
            {
                people_list[i].panel.Visible = true;
                if (textBox1.Text != "" &&
                    !people_list[i].name.Contains(textBox1.Text))
                {
                    people_list[i].panel.Visible = false;
                }


                if (people_list[i].panel.Visible)
                {
                    people_list[i].panel.Location = new Point(x, y);

                    x = x + 240;
                    if (x + 200 > panel1.Width)
                    {
                        x = 40;
                        y = y + 252;
                    }
                }
            }
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FavouriteCharactersPage fpp = new FavouriteCharactersPage();
            fpp.ShowDialog();
        }

        private void clanpagebutton_Click(object sender, EventArgs e)
        {
            ClansPage cpf = new ClansPage();
            cpf.ShowDialog();
        }

        private void articleicon_Click(object sender, EventArgs e)
        {
            ArticlesPage app = new ArticlesPage();
            app.ShowDialog();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            NewElementForm nel = new NewElementForm();
            nel.ShowDialog();
        }
    }
}

