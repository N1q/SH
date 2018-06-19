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
    public partial class Main : Form
    {
        public static MySqlConnection c = new MySqlConnection("Server=localhost; Database=ocenki; User id = root; password=;");
        public static MySqlCommand cmd = c.CreateCommand();
        public static MySqlDataReader r;

        public static List<Mark> marks = new List<Mark>();
        public static List<Student> studs = new List<Student>();
        public static List<Group> groups = new List<Group>();
        public static List<Subject> subjs = new List<Subject>();
        public Main()
        {
            InitializeComponent();
        }
        public static void Refill()
        {
            //get marks
            Open();
            cmd.CommandText = "select * from ocenki";
            r = cmd.ExecuteReader();
            marks.Clear();
            Mark m;
            while (r.Read())
            {
                m = new Mark();
                m.id = r[0];
                m.idStud = r[1];
                m.idSubj = r[2];
                m.course = r[3];
                m.mark = r[4];

                marks.Add(m);
            }
            r.Close();
            c.Close();

            //get students
            Open();
            cmd.CommandText = "select * from student";
            r = cmd.ExecuteReader();
            studs.Clear();
            Student s;
            while (r.Read())
            {
                s = new Student();
                s.id = r[0];
                s.name = r[1];
                s.idGroup = r[2];
                s.course = r[3];

                studs.Add(s);
            }
            r.Close();
            c.Close();

            //get groups
            Open();
            cmd.CommandText = "select * from ocenki.`group`";
            r = cmd.ExecuteReader();
            groups.Clear();
            Group g;
            while (r.Read())
            {
                g = new Group();
                g.id = r[0];
                g.name = r[1];
                g.zavka = r[2];

                groups.Add(g);
            }
            r.Close();
            c.Close();

            //get subjs
            Open();
            cmd.CommandText = "select * from subj";
            r = cmd.ExecuteReader();
            subjs.Clear();
            Subject sbj;
            while (r.Read())
            {
                sbj = new Subject();
                sbj.id = r[0];
                sbj.name = r[1];
                sbj.teacher = r[2];

                subjs.Add(sbj);
            }
            r.Close();
            c.Close();
        }
        void Update()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Код");
            dt.Columns.Add("Студент");
            dt.Columns.Add("Предмет");
            dt.Columns.Add("Курс");
            dt.Columns.Add("Оценка");

            Refill();

            //fill dgv
            foreach (var v in marks)
            {
                dt.Rows.Add(new object[] {
                    v.id,
                    studs.Find(x => x.id.ToString() == v.idStud.ToString()).name,
                    subjs.Find(x => x.id.ToString() == v.idSubj.ToString()).name,
                    v.course,
                    v.mark
                });
            }
            dgv.DataSource = dt;
        }
        private void изменитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var row = dgv.SelectedCells[0].OwningRow.Cells;
            Edit f = new Edit();
            f.title.Text = (sender as ToolStripMenuItem).Text;
            f.id = Convert.ToInt32(row[0].Value);
            f.defStud = row[1].Value.ToString();
            f.defSubj = row[2].Value.ToString();
            f.defCourse = row[3].Value.ToString();
            f.ShowDialog();
            Update();
        }

        private void добавитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit f = new Edit();
            f.title.Text = (sender as ToolStripMenuItem).Text;
            f.ShowDialog();
            Update();
        }

        private void добавитьСтудентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newStudent f = new newStudent();
            f.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Update();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void факультетыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Facs f = new Facs();
            f.ShowDialog();
        }

        private void студентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Students f = new Students();
            f.ShowDialog();
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            dgv.ClearSelection();
            if (search.Text != "")
            {
                for (int i = 0; i < dgv.RowCount; i++)
                {
                    if (dgv.Rows[i].Cells[1].Value.ToString().Contains(search.Text))
                        dgv.Rows[i].Selected = true;
                }
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string res = "\tУчет успеваемости студентов колледжа\n\n";
            for(int i = 0; i < dgv.RowCount; i++)
            {
                res += "Студент: " + dgv.Rows[i].Cells[1].Value.ToString() + "\n";
                res += "предмет: " + dgv.Rows[i].Cells[2].Value.ToString() + "\n";
                res += "Курс: " + dgv.Rows[i].Cells[3].Value.ToString() + "\n";
                res += "Оценка: " + dgv.Rows[i].Cells[4].Value.ToString() + "\n";
                res += "----------------------------------";
            }
            e.Graphics.DrawString(res
                , DefaultFont, Brushes.Black, 50, 50);
        }

        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }
        public static void Open()
        {
            if (c.State != ConnectionState.Open)
                c.Open();
        }
    }
    public class Mark
    {
        public object id,
            idStud,
            idSubj,
            course,
            mark;
    }
    public class Student
    {
        public object id,
            name,
            idGroup,
            course;
    }
    public class Group
    {
        public object id,
            name,
            zavka;
    }
    public class Subject
    {
        public object id,
            name,
            teacher;
    }
}
