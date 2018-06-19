using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ocenki
{
    public partial class Greet : Form
    {
        public Greet()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Auth f = new Auth();
            f.Show();
            Hide();
            timer1.Stop();
        }

        private void Greet_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
