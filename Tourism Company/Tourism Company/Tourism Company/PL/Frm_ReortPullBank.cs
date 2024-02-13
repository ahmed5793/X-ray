using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tourism_Company.BL;

namespace Tourism_Company.PL
{
    public partial class Frm_ReortPullBank : Form
    {
        Bank b = new Bank();
        DataTable dt = new DataTable();
        public Frm_ReortPullBank()
        {
            InitializeComponent();
            dataGridView1.DataSource = b.Report_PullBank();
            total();
            dataGridView1.Columns[2].Visible = false;
        }

        private void Frm_ReortPullBank_Load(object sender, EventArgs e)
        {

        }
    
        internal void total()
        {
            decimal total = 0;
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                total += Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);

            }
            txt_rent.Text = Math.Round(total, 2).ToString();
        }
        private void Btn_search_Click(object sender, EventArgs e)
        {
            dt = b.Search_PullBank(FromDate.Value, ToDate.Value);
            dataGridView1.DataSource = dt;
            total();
        }
    }
}
