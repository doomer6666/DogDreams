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

        private void Monkey_Click(object sender, EventArgs e) =>
            ClassConstructs.ClickEventConstruct(monkey, @"Sound\shimpanze.wav",
                @"Images\monkey.png", strMonkey, missionPassed);

        private void Cola_Click(object sender, EventArgs e) =>
            ClassConstructs.ClickEventConstruct(cola, @"Sound\win1.wav",
                @"Images\cola.png", strCola, missionPassed);

        private void Monax_Click(object sender, EventArgs e) =>
            ClassConstructs.ClickEventConstruct(monax, @"Sound\win2.wav",
                @"Images\monax.png", strMonax, missionPassed);

        private void Capybara_Click(object sender, EventArgs e) =>
            ClassConstructs.ClickEventConstruct(capybara, @"Sound\win3.wav",
                @"Images\capybara.png", strCapybara, missionPassed);

        private void Partizan_Click(object sender, EventArgs e) =>
            ClassConstructs.ClickEventConstruct(partizan, @"Sound\tada.wav",
                @"Images\vietnam.png", strPartizan, missionPassed);

        private void MissionPassed_Click(object sender, EventArgs e)=>
            ClassConstructs.ChangeLevel(null, null, new Level2(), this, null);      
    }
}
