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
    public partial class newStudent : Form
    {
        public newStudent()
        {
            InitializeComponent();
        }

        private void newStudent_Load(object sender, EventArgs e)
        {
            cb_name.Items.Clear();
            foreach (var v in Main.studs)
                cb_name.Items.Add(v.name);

            cb_group.Items.Clear();
            foreach (var v in Main.groups)
                cb_group.Items.Add(v.name);
        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void b_done_Click(object sender, EventArgs e)
        {
            Main.Open();
            Main.cmd.CommandText = "insert into student (name, idGroup, course) values('" + cb_name.Text + "', '" + (cb_group.SelectedIndex + 1) + "', '" + cb_course.Text + "')";
            Main.cmd.ExecuteNonQuery();
            Main.c.Close();
            MessageBox.Show("Операция выполнена успешно");
            Close();
        }
    }
}
