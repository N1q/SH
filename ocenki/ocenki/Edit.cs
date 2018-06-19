using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ocenki
{
    public partial class Edit : Form
    {
        public int id;
        public string defStud, defSubj, defCourse;
        public Edit()
        {
            InitializeComponent();
        }

        private void b_done_Click(object sender, EventArgs e)
        {
            //check
            if (title.Text.ToLower().Contains("изменить"))
            {
                //update if exists
                Main.Open();
                Main.cmd.CommandText = "update ocenki set idStudent = " + Main.studs.Find(x => x.name.ToString() == cb_student.Text).id +
                    ", idSubj = " + Main.subjs.Find(x => x.name.ToString() == cb_subj.Text).id + ", course = " + cb_course.Text + ", mark = " + n_mark.Value + " where id = " + id;
                Main.cmd.ExecuteNonQuery();
                Main.c.Close();
                MessageBox.Show("Операция выполнена");
            }
            else
            {
                //else insert
                Main.Open();
                Main.cmd.CommandText = "insert into ocenki (idStudent, idSubj, course, mark) values(" + 
                    Main.studs.Find(x => x.name.ToString() == cb_student.Text).id + ", " + 
                    Main.subjs.Find(x => x.name.ToString() == cb_subj.Text).id + ", " +
                    cb_course.Text + ", " +
                    n_mark.Value + ")";
                Main.cmd.ExecuteNonQuery();
                Main.c.Close();
                MessageBox.Show("Операция выполнена");
            }
            Close();
        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newStudent_Click(object sender, EventArgs e)
        {
            newStudent f = new newStudent();
            f.ShowDialog();
            Main.Refill();
            Edit_Load(sender, e);
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            if (title.Text.ToLower().Contains("изменить"))
            {
                cb_student.Text = defStud;
                cb_subj.Text = defSubj;
                cb_course.Text = defCourse;
            }
            cb_student.Items.Clear();
            foreach (var v in Main.studs)
                cb_student.Items.Add(v.name);

            cb_subj.Items.Clear();
            foreach (var v in Main.subjs)
                cb_subj.Items.Add(v.name);
        }
    }
}
