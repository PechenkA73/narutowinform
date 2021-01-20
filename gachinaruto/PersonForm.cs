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
    public partial class PersonForm : Form
    {
        public PersonForm(string name)
        {
            InitializeComponent();
            Text = name;

            if(name == "Наруто Узумаки")
            {
                label1.Text = "Наруто Узумаки";
                pictureBox1.Load("../../Pictures/narutouzumaki.jpg");
            }

            if (name == "Саске Учиха")
            {
                label1.Text = "Саске Учиха";
                pictureBox1.Load("../../Pictures/sasukeuchiha.jpg");
            }
        }

        private void PersonForm_Load(object sender, EventArgs e)
        {

        }

        private void userpicture_Click(object sender, EventArgs e)
        {

        }
    }
}
