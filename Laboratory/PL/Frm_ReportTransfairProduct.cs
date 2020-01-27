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
    public partial class Frm_ReportTransfairProduct : Form
    {
        Product Product = new Product();
        public Frm_ReportTransfairProduct()
        {
            InitializeComponent();
            dataGridView1.DataSource = Product.Report_TransfairProduct();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = Product.SearchReport_TransfairProduct(DateFrom.Value, DateTo.Value);
                dataGridView1.DataSource = dt;
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
