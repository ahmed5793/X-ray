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
    public partial class Frm_AllMasrofat : Form
    {
        masrofat m = new masrofat();
        public Frm_AllMasrofat()
        {
            InitializeComponent();
            dataGridViewList.DataSource = m.Select_masrofat();
            calcTotal();
        }
        void calcTotal()
        {
            decimal total = 0;
            for (int i = 0; i < dataGridViewList.Rows.Count; i++)
            {
                total += Convert.ToDecimal(dataGridViewList.Rows[i].Cells[2].Value);
            }
            textBox1.Text = Math.Round(total, 2).ToString();
        }

        private void Frm_AllMasrofat_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Btn_search_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = m.Searech_masrofatDate(FromDate.Value, ToDate.Value);
            dataGridViewList.DataSource = dt;
            calcTotal();
        }
    }
}
