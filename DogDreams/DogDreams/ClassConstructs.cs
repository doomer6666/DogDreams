using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogDreams
{
    internal static class ClassConstructs
    {
        public static void ChangeLevel(string sound, string name, Form newLevel, Form oldLevel, PictureBox nextLvlPicBox)
        {
            var timer = new Timer { Interval = 2280 };
            timer.Start();
            if (sound != null)
            {
                SoundPlayer player = new SoundPlayer(System.IO.Path.GetFullPath(sound));
                player.Play();
            }
            if (nextLvlPicBox != null && name != null)
                nextLvlPicBox.Image = Image.FromFile(System.IO.Path.GetFullPath(name));
            timer.Tick += (r, u) =>
            {
                newLevel.Show();
                oldLevel.Hide();
                timer.Stop();
            };
            counterOfEnd = 0;
        }
        private static int counterOfEnd = 0;
        public static void ClickEventConstruct(PictureBox name, string sound, string image, Label strName,
             PictureBox missionPassed)
        {
            new SoundPlayer(System.IO.Path.GetFullPath(sound)).Play();
            name.Image = Image.FromFile(System.IO.Path.GetFullPath(image));
            int tick = 0;
            Timer timer = new Timer { Interval = 1500 };
            timer.Start();
            timer.Tick += (e, a) =>
            {
                name.Hide();
                if (tick == 2) 
                {
                    timer.Interval = 9000;
                    missionPassed.Location = new Point(429, 157);
                    timer.Stop();
                }
            };
            counterOfEnd++;
            strName.Font = new Font(strName.Font.FontFamily, strName.Font.Size, FontStyle.Strikeout);
            if (counterOfEnd == 5)
            {
                
                timer = new Timer { Interval = 2000 };
                timer.Start();
                timer.Tick += (e, a) =>
                {
                    name.Hide();
                    tick++;
                    if (tick == 2) timer.Stop();
                };

            }
        }
        public static void Rocket_Click(PictureBox rocket, string sound, int random)
        {
            SoundPlayer player = new SoundPlayer(System.IO.Path.GetFullPath(sound));
            player.Play();
            rocket.Left = 1200;
            rocket.Top = random;
        }

        [DllImport("winmm.dll", EntryPoint = "sndPlaySound")]
        public static extern long PlaySound(string fileName, long flags);
    }
}
