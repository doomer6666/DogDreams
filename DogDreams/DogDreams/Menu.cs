using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace DogDreams
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Dog_Click(object sender, EventArgs e)
        {          
            var timer = new Timer { Interval = 2280 };
            timer.Start();
            SoundPlayer player = new SoundPlayer(System.IO.Path.GetFullPath(@"Sound\boom.wav"));
            player.Play();
            dog.Image = Image.FromFile(System.IO.Path.GetFullPath(@"Images\iskra.gif"));
            timer.Tick += (r, u) =>
            {
                var lv1 = new Level1();
                lv1.Show();
                Hide();
                timer.Stop();
            };
            
        }
    }
}
