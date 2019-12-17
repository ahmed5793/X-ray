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
    public partial class Frm_ReportMasrofat : Form
    {
        Masrofat M = new Masrofat();
        public Frm_ReportMasrofat()
        {
            InitializeComponent();
            dataGridView1.DataSource = M.select_Masrofat();
            Calc_Total();
        }
        void Calc_Total()
        {
            decimal Total = 0;
            if (dataGridView1.Rows.Count>0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    Total += Convert.ToDecimal(dataGridView1.Rows[i].Cells[1].Value);
                }
                textBox1.Text = Math.Round(Total, 2).ToString();
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                dt.Clear();
                dt = M.search_Masrofat(DateFrom.Value, DateTo.Value);
                dataGridView1.DataSource = dt;
                Calc_Total();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                dt.Dispose();
            }
        }
    }
}
