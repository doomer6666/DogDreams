using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogDreams
{
    public partial class Level4 : Form
    {
        public Level4()
        {
            InitializeComponent();          
        }
        public void FindItem(PictureBox pictureBox)
        {
            leter.Text = (Int32.Parse(leter.ToString()) - 1).ToString();
            pictureBox.Hide();
            if (leter.Text.Equals("0"))
            {
                ClassConstructs.ChangeLevel(null, null, new Level3(), this, null);
            }
        }
        private void monax_Click(object sender, EventArgs e)
        {
            FindItem(monax);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FindItem(pictureBox4);
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            FindItem(pictureBox25);
        }

        private void partizan_Click(object sender, EventArgs e)
        {
            FindItem(partizan);
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            FindItem(pictureBox13);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FindItem(pictureBox1);
        }

        private void devil_Click(object sender, EventArgs e)
        {
            FindItem(devil);
        }

        private void cola_Click(object sender, EventArgs e)
        {
            FindItem(cola);
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            FindItem(pictureBox21);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            FindItem(pictureBox8);
        }

        private void Level4_Load(object sender, EventArgs e)
        {
            if (Location.X == 0 && leter.Text.Equals("0")) Hide();
        }
    }
}
