using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogDreams
{
    public partial class Level3 : Form
    {
        public Level3()
        {
            InitializeComponent();
        }

        int lifesCount = 3;
        int startValue = 1;
        readonly Random rnd = new Random();

        private void Timer_Tick(object sender, EventArgs e)
        {
            rocket1.Left -= 3;
            rocket2.Left -= 3;
            rocket3.Left -= 3;

            if (rocket1.Bounds.IntersectsWith(usa.Bounds) || rocket2.Bounds.IntersectsWith(usa.Bounds) || rocket3.Bounds.IntersectsWith(usa.Bounds))
            {
                lifesCount--;
                lifes.Text = "Жизни:" + lifesCount;
                Rocket1_Click(sender, e);
                Rocket2_Click(sender, e);
                Rocket3_Click(sender, e);
            }
            if (lifesCount == 0)
            {
                usa.Hide();
                rocket1.Hide();
                rocket2.Hide();
                rocket3.Hide();
                tm.Stop();
                label1.Text = "You FAIL";
            }
        }

        private void Rocket1_Click(object sender, EventArgs e) =>
            ClassConstructs.Rocket_Click(rocket1, @"Sound\rocket.wav", rnd.Next(10, 150));

        private void Rocket2_Click(object sender, EventArgs e) =>
            ClassConstructs.Rocket_Click(rocket2, @"Sound\rocket.wav", rnd.Next(200, 350));

        private void Rocket3_Click(object sender, EventArgs e) =>
            ClassConstructs.Rocket_Click(rocket3, @"Sound\rocket.wav", rnd.Next(400, 500));

        private string GetStringTime(int time)
        {
            int hours = (time - (time % (60 * 60))) / (60 * 60);
            int minutes = (time - time % 60) / 60 - hours * 60;
            int seconds = time - hours * 60 * 60 - minutes * 60;
            return String.Format("{0:00}:{1:00}:{2:00}", hours, minutes, seconds);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            startValue = 60;
            timer.Enabled = true;
            tm.Enabled = true;
            button.Enabled = false;
        }

        private void Tm_Tick(object sender, EventArgs e)
        {
            if (startValue == 0)
            {
                timer.Stop();
                tm.Stop();
                rocket1.Hide();
                rocket2.Hide();
                rocket3.Hide();
                label1.Text = "You WIN";
                missionPassed.Location = new Point(476, 148);
            }
            label1.Text = GetStringTime(startValue);
            startValue--;
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            var newLevel = new Level3();
            Close();
            newLevel.Show();
        }

        private void MissionPassed_Click(object sender, EventArgs e)
        {
            ClassConstructs.ChangeLevel(null, null, new End(), this, null);
        }
    }
}
