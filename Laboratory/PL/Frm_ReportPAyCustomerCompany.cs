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
    public partial class Frm_ReportPAyCustomerCompany : Form
    {
        Customer C = new Customer();
        public Frm_ReportPAyCustomerCompany()
        {
            InitializeComponent();
            dataGridViewList.DataSource = C.Select_AllPayCustomerCompany();
            Calc();
        }
        void Calc()
        {
            Decimal total = 0;
            for (int i = 0; i < dataGridViewList.Rows.Count; i++)
            {
                total += Convert.ToDecimal(dataGridViewList.Rows[i].Cells[3].Value);
            }
            txt_TotalPurshacing.Text = Math.Round(total,1).ToString();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                dt.Clear();
                dt = C.Search_AllPayCustomerCompany(textBox1.Text);
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

        private void Frm_ReportPAyCustomerCompany_Load(object sender, EventArgs e)
        {

        }
    }
}
