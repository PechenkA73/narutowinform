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

            privetusername.Text = UserForm.Login;
            userpicture.Load("../../Pictures/Users/" + UserForm.Login + ".jpg");

            int x = 40;
            int y = 14;
            foreach (Person person in MainForm.favCharacters)
            {
                FavCharacterUC fav = new FavCharacterUC(person);

                fav.Location = new Point(x, y);
                panel1.Controls.Add(fav);


                x = x + 240;
                if (x + 200 > panel1.Width)
                {
                    x = 40;
                    y = y + 252;
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
                Text = Words["Страница с любимыми персонажами"];
                label1.Text = Words["Любимые персонажи"] + ":";
            }
            catch (Exception e)
            {
                string s = e.Message;
            }
        }
    }
}

