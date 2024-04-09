using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void monkey_Click(object sender, EventArgs e)
        {
            monkey.Hide();
            strMonkey.Font = new Font(strMonkey.Font.FontFamily, strMonkey.Font.Size, FontStyle.Strikeout);
        }

        private void cola_Click(object sender, EventArgs e)
        {
            cola.Hide();
            strCola.Font = new Font(strCola.Font.FontFamily,strCola.Font.Size,FontStyle.Strikeout); 
        }
    }
}
