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
    public partial class Auth : Form
    {


        public Auth()
        {
            InitializeComponent();
        }

        private void Auth_Load(object sender, EventArgs e)
        {
            tb_log.Text = "user";
            tb_pwd.Text = "user";
        }        

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Auth_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (tb_log.Text == "user" && tb_pwd.Text == "user")
            {
                Main f = new Main();
                Hide();
                f.Show();
            }
            else
                MessageBox.Show("Проверьте данные еще раз. Что-то тут не так");

        }


    }
}
