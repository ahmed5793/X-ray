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
    public partial class Frm_Arba7 : Form
    {
        Booking b = new Booking();
        DataTable dt = new DataTable();
        public Frm_Arba7()
        {
            InitializeComponent();
            dataGridView1.DataSource = b.Select_rba7();
            dataGridView1.Columns[6].Visible = false;
            ToTal_Arba7();
        }
        void ToTal_Arba7()
        {
            decimal total = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                total += Convert.ToDecimal(dataGridView1.Rows[i].Cells[6].Value);
            }
            textBox1.Text = Math.Round(total, 2).ToString();
        }
        private void Frm_Arba7_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_search_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dt = b.Search_arba7(FromDate.Value, ToDate.Value);
            dataGridView1.DataSource = dt;
            ToTal_Arba7();
        }

        private void DateFrom_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
