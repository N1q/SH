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
    public partial class Facs : Form
    {
        public Facs()
        {
            InitializeComponent();
        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        
        private void Facs_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Группа");
            dt.Columns.Add("Заведующий(-ая) отделения");
            foreach(var v in Main.groups)
            {
                dt.Rows.Add(new object[] { v.name, v.zavka });
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
