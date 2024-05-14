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
            ClassConstructs.ChangeLevel(@"Sound\boom.wav", @"Images\iskra.gif", new Level1(), this,dog);
        }
    }
}
