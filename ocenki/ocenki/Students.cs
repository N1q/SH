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
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Students_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ФИО");
            dt.Columns.Add("Группа");
            dt.Columns.Add("Курс");
            foreach (var v in Main.studs)
            {
                dt.Rows.Add(new object[] { v.name, Main.groups.Find(x => x.id.ToString() == v.idGroup.ToString()).name, v.course });
            }
            dgv.DataSource = dt;
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            dgv.ClearSelection();
            if (search.Text != "")
            {
                for (int i = 0; i < dgv.RowCount; i++)
                {
                    if (dgv.Rows[i].Cells[0].Value.ToString().Contains(search.Text))
                        dgv.Rows[i].Selected = true;
                }
            }
        }
    }
}
