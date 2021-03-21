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

        public MainForm()
        {
            InitializeComponent();

            articles_list.Add(new Article("Акацуки"));
            articles_list.Add(new Article("Лес Шиккоцу"));
            articles_list.Add(new Article("Пещера Рьючи"));
            articles_list.Add(new Article("Гора Мьёбоку"));
            articles_list.Add(new Article("Союзные Силы Шиноби"));



            clans_list.Add(new Clan("Учиха"));
            clans_list.Add(new Clan("Узумаки"));
            clans_list.Add(new Clan("Казекаге"));
            clans_list.Add(new Clan("Сенджу"));
            clans_list.Add(new Clan("Нара"));
            clans_list.Add(new Clan("Сарутоби"));
            clans_list.Add(new Clan("Хьюга"));



            people_list.Add(new Person("Наруто Узумаки", "Узумаки", "Деревня Скрытого Листа, Гора Мьёбоку, Союзные Силы Шиноби", "Хокаге"));
            people_list.Add(new Person("Саске Учиха", "Учиха", "Деревня Скрытого Листа, Деревня Скрытого Звука, Пещера Рьючи, Акацуки", "Глава Клана Учиха"));
            people_list.Add(new Person("Какаши Хатаке", "Хатаке", "Деревня Скрытого Листа, Союзные Силы Шиноби", "Хокаге, Командир Третьей Дивизии Союзных Войск Шиноби"));
            people_list.Add(new Person("Минато Намиказе", "Намиказе", "Деревня Скрытого Листа, Гора Мьёбоку, Союзные Силы Шиноби", "Хокаге"));
            people_list.Add(new Person("Итачи Учиха", "Учиха", "Деревня Скрытого Листа, Акацуки", "Анбу"));
            people_list.Add(new Person("Обито Учиха", "Учиха", "Деревня Скрытого Листа, Деревня Скрытого Тумана, Акацуки", "Лидер Акацуки, Тайный лидер Киригакуре"));
            people_list.Add(new Person("Хината Хьюга", "Хьюга, Узумаки", "Деревня Скрытого Листа, Союзные Силы Шиноби", "Наследница Клана Хьюга"));
            people_list.Add(new Person("Темари", "Казекаге, Нара", "Деревня Скрытого Песка, Деревня Скрытого Листа", "Телохранитель Казекаге"));
            people_list.Add(new Person("Цунаде Сенджу", "Сенджу, Узумаки", "Деревня Скрытого Листа, Лес Шиккоцу, Союзные Силы Шиноби", "Хокаге, Ниндзя-медик"));
            people_list.Add(new Person("Сакура Харуно", "Харуно, Учиха", "Деревня Скрытого Листа, Лес Шиккоцу, Союзные Силы Шиноби", "Ниндзя-медик, Доктор, Директор Детско Психиатрической Клиники Листа"));
            people_list.Add(new Person("Канкуро", "Казекаге", "Деревня Скрытого Песка, Союзные Силы Шиноби", "Телохранитель Казекаге, Капитан Подразделения Внезапного Нападения Союзных Войск Шиноби"));
            people_list.Add(new Person("Тобирама Сенджу", "Сенджу", "Деревня Скрытого Листа, Союзные Силы Шиноби", "Хокаге"));
            people_list.Add(new Person("Хаширама Сенджу", "Сенджу", "Деревня Скрытого Листа, Союзные Силы Шиноби", "Хокаге, Глава Клана Сенджу, Сооснователь  Деревни Скрытого Листа"));
            people_list.Add(new Person("Мито Узумаки", "Сенджу, Узумаки", "Деревня Скрытых Водоворотов, Деревня Скрытого Листа", "Шиноби"));
            people_list.Add(new Person("Гаара", "Казекаге", "Деревня Скрытого Песка, Союзные Силы Шиноби", "Казекаге, Полковой Командир Союзных Войск Шиноби, Командир Четвёртого Подразделения"));
            people_list.Add(new Person("Карин", "Узумаки", "Деревня Скрытой Травы, Деревня Скрытого Звука, Акацуки", "Ниндзя-медик"));
            people_list.Add(new Person("Нагато", "Узумаки", "Деревня Скрытого Дождя, Акацуки",""));
            people_list.Add(new Person("Кушина Узумаки", "Узумаки", "Деревня Скрытого Листа, Деревня Скрытых Водоворотов", "Шиноби"));
            people_list.Add(new Person("Шикамару Нара", "Нара", "Деревня Скрытого Листа, Союзные Силы Шиноби", "Помощник Хокаге, Специалист по планированию для Союза Шиноби, Косвенный Командир Четвёртой Дивизии Союзных Войск Шиноби, Проктор Экзаменов на Чуунина, Глава Клана Нара"));
            people_list.Add(new Person("Шикаку Нара", "Нара", "Деревня Скрытого Листа, Союзные Силы Шиноби", "Шиноби"));
            people_list.Add(new Person("Хирузен Сарутоби", "Сарутоби", "Деревня Скрытого Листа, Союзные Силы Шиноби", "Хокаге"));
            people_list.Add(new Person("Конохамару Сарутоби", "Сарутоби", "Деревня Скрытого Листа, Гора Мьёбоку", "Учитель Академии"));
            people_list.Add(new Person("Асума Сарутоби", "Сарутоби", "Деревня Скрытого Листа", "Шиноби"));
            people_list.Add(new Person("Бивако Сарутоби", "Сарутоби", "Деревня Скрытого Листа", "Ниндзя-медик"));
            people_list.Add(new Person("Куренай Юхи", "Сарутоби", "Деревня Скрытого Листа", "Шиноби"));
            people_list.Add(new Person("Рок Ли", "", "Деревня Скрытого Листа, Союзные Силы Шиноби", "Шиноби"));
            people_list.Add(new Person("Майто Гай", "", "Деревня Скрытого Листа, Союзные Силы Шиноби", "Шиноби"));
            people_list.Add(new Person("Неджи Хьюга", "Хьюга", "Деревня Скрытого Листа, Союзные Силы Шиноби", "Шиноби"));
            people_list.Add(new Person("Ханаби Хьюга", "Хьюга", "Деревня Скрытого Листа", "Шиноби"));
            people_list.Add(new Person("Хиаши Хьюга", "Хьюга", "Деревня Скрытого Листа, Союзные Силы Шиноби", "Глава Клана Хьюга"));
            people_list.Add(new Person("Шисуи Учиха", "Учиха", "Деревня Скрытого Листа", "Шиноби"));
            people_list.Add(new Person("Мадара Учиха", "Учиха", "Деревня Скрытого Листа, Акацуки", "Сооснователь Деревни Скрытого Листа, Глава Клана Учиха(Ранее)"));
            people_list.Add(new Person("Изуна Учиха", "Учиха", "", "Шиноби"));
            people_list.Add(new Person("Фугаку Учиха", "Учиха", "Деревня Скрытого Листа", "Глава Военной Полиции Конохи"));
            people_list.Add(new Person("Микото Учиха", "Учиха", "Деревня Скрытого Листа", "Домохозяйка"));
            people_list.Add(new Person("Джирайя", "", "Деревня Скрытого Листа, Гора Мьёбоку", "Писатель"));






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

        }

        private void labelclan_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void filterclan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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
            /*panel2.Visible = (filterclan.GetItemCheckState(1) == CheckState.Checked || 
                filterfrom.GetItemCheckState(0) == CheckState.Checked ||
                filterprofession.GetItemCheckState(0) == CheckState.Checked);
            panel3.Visible = (filterclan.GetItemCheckState(0) == CheckState.Checked || 
                filterfrom.GetItemCheckState(0) == CheckState.Checked);
            panel4.Visible = (filterclan.GetItemCheckState(4) == CheckState.Checked || 
                filterfrom.GetItemCheckState(0) == CheckState.Checked ||
                filterprofession.GetItemCheckState(0) == CheckState.Checked);
            panel6.Visible = (filterfrom.GetItemCheckState(0) == CheckState.Checked ||
                filterprofession.GetItemCheckState(0) == CheckState.Checked);
            panel8.Visible = (filterclan.GetItemCheckState(0) == CheckState.Checked ||
                filterfrom.GetItemCheckState(0) == CheckState.Checked ||
                filterfrom.GetItemCheckState(8) == CheckState.Checked ||
                filterprofession.GetItemCheckState(9) == CheckState.Checked);
            panel9.Visible = (filterclan.GetItemCheckState(0) == CheckState.Checked ||
                filterfrom.GetItemCheckState(0) == CheckState.Checked ||
                filterfrom.GetItemCheckState(8) == CheckState.Checked ||
                filterfrom.GetItemCheckState(5) == CheckState.Checked);*/
        }
        public static void heroClick(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            CharacterForm pf = new CharacterForm(pb.Tag.ToString());
            pf.Show();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void privetusername_Click(object sender, EventArgs e)
        {

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

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FavouriteCharactersPage fpp = new FavouriteCharactersPage();
            fpp.Show();
        }

        private void clanpagebutton_Click(object sender, EventArgs e)
        {
            ClansPage cpf = new ClansPage();
            cpf.Show();
        }

        private void articleicon_Click(object sender, EventArgs e)
        {
            ArticlesPage app = new ArticlesPage();
            app.Show();
        }
    }
}

