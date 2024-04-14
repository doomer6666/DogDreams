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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DogDreams
{
    public partial class Level1 : Form
    {
        public Level1()
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            InitializeComponent();
        }

        private int counterOfEnd = 0;
        private void ClickEventConstruct(PictureBox name, string sound, string image, Label strName)
        {
            new SoundPlayer(System.IO.Path.GetFullPath(sound)).Play();
            name.Image = Image.FromFile(System.IO.Path.GetFullPath(image));
            counterOfEnd++;
            Timer timer = new Timer { Interval = 1500 };
            timer.Start();
            timer.Tick += (e, a) =>
            {
                name.Hide();
                timer.Stop();
            };
            strName.Font = new Font(strMonkey.Font.FontFamily, strMonkey.Font.Size, FontStyle.Strikeout);
            if (counterOfEnd == 5)
            {
                missionPassed.Location = new Point(429, 157);
                SoundPlayer player1 = new SoundPlayer(System.IO.Path.GetFullPath(@"Sound\gta.wav"));
                player1.Play();
                timer.Stop();
            }
        }

        private void Monkey_Click(object sender, EventArgs e) =>
            ClickEventConstruct(monkey, @"Sound\shimpanze.wav", @"Images\monkey.png", strMonkey);

        private void Cola_Click(object sender, EventArgs e) =>
            ClickEventConstruct(cola, @"Sound\win1.wav", @"Images\cola.png", strCola);

        private void Monax_Click(object sender, EventArgs e) =>
            ClickEventConstruct(monax, @"Sound\win2.wav", @"Images\monax.png", strMonax);

        private void Capybara_Click(object sender, EventArgs e) =>
            ClickEventConstruct(capybara, @"Sound\win3.wav", @"Images\capybara.png", strCapybara);

        private void Partizan_Click(object sender, EventArgs e) =>
            ClickEventConstruct(partizan, @"Sound\tada.wav", @"Images\vietnam.png", strPartizan);

        private void MissionPassed_Click(object sender, EventArgs e)
        {
            Hide();
        }

    }
}
