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
    public partial class Frm_ReportInsertStock : Form
    {
        Stock S = new Stock();
        public Frm_ReportInsertStock()
        {
            InitializeComponent();
            cmb_Stock.DataSource = S.Compo_Stock();
            cmb_Stock.DisplayMember = "Name_Stock";
            cmb_Stock.ValueMember = "ID_Stock";
            Calc_Amount();
        }
        void Calc_Amount()
        {
            decimal Total = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                Total += Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);
            }
            textBox1.Text = Math.Round(Total, 1).ToString();

        }

        private void btn_search_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            try
            {
                dt.Clear();
                dt = S.Search_Report_InsertStock(Convert.ToInt32(cmb_Stock.SelectedValue), DateFrom.Value, DateTo.Value);
                dataGridView1.DataSource = dt;
                Calc_Amount();
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

        private void cmb_Stock_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
            try
            {
                dt2.Clear();
                dt2 = S.Report_InsertStock(Convert.ToInt32(cmb_Stock.SelectedValue));
                dataGridView1.DataSource = dt2;
                Calc_Amount();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
