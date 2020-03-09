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
            gridControl1.DataSource = Product.Report_TransfairProduct();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = Product.SearchReport_TransfairProduct(DateFrom.Value, DateTo.Value);
                gridControl1.DataSource = dt;
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

        private void Frm_ReportTransfairProduct_Load(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            try
            {
                dt = Product.SearchReport_TransfairProduct(DateFrom.Value, DateTo.Value);
                gridControl1.DataSource = dt;
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
