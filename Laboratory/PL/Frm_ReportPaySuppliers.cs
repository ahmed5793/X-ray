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
    public partial class Frm_ReportPaySuppliers : Form
    {
        Suppliers Suppliers = new Suppliers();

        public Frm_ReportPaySuppliers()
        {
            InitializeComponent();
            dataGridViewList.DataSource = Suppliers.Report_PaySupplier();
            Calc();
        }

        void Calc()
        {
            Decimal total = 0;
            for (int i = 0; i < dataGridViewList.Rows.Count; i++)
            {
                total += Convert.ToDecimal(dataGridViewList.Rows[i].Cells[2].Value);
            }
            txt_TotalPurshacing.Text = Math.Round(total, 2).ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            try
            {
                dt.Clear();
                dt = Suppliers.Search_PaySupplier(textBox1.Text);
                dataGridViewList.DataSource = dt;
                Calc();

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
