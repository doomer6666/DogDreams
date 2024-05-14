using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogDreams
{
    public partial class End : Form
    {
        public End()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Around_Click(object sender, EventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(System.IO.Path.GetFullPath(@"Sound\fail.wav"));
            soundPlayer.Play();
            Close();
            ClassConstructs.ChangeLevel(null, null, new Menu(), this, null);
        }

        private void End_Load(object sender, EventArgs e)
        {
            ClassConstructs.PlaySound(System.IO.Path.GetFullPath(@"Sound\russia.wav"), 1);
        }

        
    }
}
