using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show(" GAME OVER ");
        }

        private void pictureBox38_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show(" Winner Winner Chicken Diner ");
        }
    }
}
