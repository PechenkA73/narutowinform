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
    public partial class FavCharacterUC : UserControl
    {
        Person person;
        public FavCharacterUC(Person pers)
        {
            person = pers;
            InitializeComponent();

            label1.Text = pers.name;
            pictureBox1.Image = pers.picture.Image;
            pictureBox1.Click += new EventHandler(MainForm.heroClick);
            pictureBox1.Tag = pers.name;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MainForm.favCharacters.Remove(person);
            this.Parent = null;
        }
    }
}
