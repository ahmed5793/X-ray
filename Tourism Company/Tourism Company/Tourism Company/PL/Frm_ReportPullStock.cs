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
    public partial class Frm_ReportPullStock : Form
    {
        Stock s = new Stock();
        DataTable dt = new DataTable();
        public Frm_ReportPullStock()
        {
            InitializeComponent();
            dataGridView1.DataSource = s.Report_PullStock();
            total();
            dataGridView1.Columns[2].Visible = false;
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
        private void Frm_ReportPullStock_Load(object sender, EventArgs e)
        {

        }

        private void Btn_search_Click(object sender, EventArgs e)
        {
            dt = s.Search_PullStock(FromDate.Value,ToDate.Value);
            dataGridView1.DataSource = dt;
            total();
        }
    }
}
