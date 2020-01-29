using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Laboratory.BL;


namespace Laboratory.PL
{
    public partial class Frm_ReportTransferForCompany : Form
    {
        Tickets T = new Tickets();
        public Frm_ReportTransferForCompany()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Frm_ReportTransferForCompany_Load(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            dt.Clear();
            dt = T.ReportSelectTransferCompany(DateFrom.Value, DateTo.Value);
            dataGridView1.DataSource = dt;
                
            decimal total = 0;
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                total += Convert.ToDecimal(dataGridView1.Rows[i].Cells[8].Value);

            }
            textBox1.Text = Math.Round(total, 2).ToString();
        }
    }
}
