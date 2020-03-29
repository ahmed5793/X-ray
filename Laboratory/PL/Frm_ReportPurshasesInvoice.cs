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
    public partial class Frm_ReportPurshasesInvoice : Form
    {
        Suppliers Suppliers = new Suppliers();
        public Frm_ReportPurshasesInvoice()
        {
            InitializeComponent();
            //gridControl1.DataSource = Suppliers.Report_PurshasesInvoice();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
           
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = Suppliers.SearchReport_PurshasesInvoice(DateFrom.Value, DateTo.Value);
                gridControl1.DataSource = dt;
                decimal total = 0;
                for (int i = 0; i < gridView1.DataRowCount; i++)
                {
                    DataRow row = gridView1.GetDataRow(i);
                    total += Convert.ToDecimal(row[3].ToString());

                }
                txt_totalpay.Text = total.ToString("₱ #,##0.0");
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

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn_Print_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount>0)
            {
                gridControl1.ShowRibbonPrintPreview();
            }
        }
    }
}
