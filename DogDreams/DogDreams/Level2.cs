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
    public partial class Level2 : Form
    {
        public Level2()
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            InitializeComponent();
        }

        private void Devil_Click(object sender, EventArgs e) =>
            ClassConstructs.ClickEventConstruct(devil, @"Sound\devilWords.wav",
                @"Images\devil.png", strDevil, missionPassed);


        private void Maxwell_Click(object sender, EventArgs e) =>
            ClassConstructs.ClickEventConstruct(maxwell, @"Sound\win3.wav",
                @"Images\maxwell-cat.gif", strMaxwell, missionPassed);


        private void Papa_Click(object sender, EventArgs e) =>
            ClassConstructs.ClickEventConstruct(papa, @"Sound\kolokol.wav",
                @"Images\papa.png", strPapa, missionPassed);


        private void Taro_Click(object sender, EventArgs e) =>
            ClassConstructs.ClickEventConstruct(taro, @"Sound\tada.wav",
                @"Images\taro.jpg", strTaro, missionPassed);


        private void Harvi_Click(object sender, EventArgs e) =>
            ClassConstructs.ClickEventConstruct(harvi, @"Sound\police.wav",
                @"Images\harvi.png", strHarvi, missionPassed);


        private void MissionPassed_Click(object sender, EventArgs e)
        {
            Close();
            ClassConstructs.ChangeLevel(null, null, new Level3(), this, null);
        }
    }
}
