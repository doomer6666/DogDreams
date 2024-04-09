using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogDreams
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\qazpl\Downloads\silnyiy-raskatistyiy-vzryiv.wav");
            player.Play();
            dog.Image = Image.FromFile(@"C:\Users\qazpl\OneDrive\Изображения\iskra-7-0.gif");
            ClickEvent();
        }

        private void ClickEvent()
        {
            Timer timer = new Timer();
            timer.Interval = 2200;
            timer.Start();
            timer.Tick += (sender, args) =>
            {
                var lv1 = new Level1();
                lv1.Show();
                Hide();
                timer.Stop();
            };
        }
    }
}
