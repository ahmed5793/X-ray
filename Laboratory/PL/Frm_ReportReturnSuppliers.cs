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
    public partial class Frm_ReportReturnSuppliers : Form
    {
        Suppliers s = new Suppliers()
;        public Frm_ReportReturnSuppliers()
        {
            InitializeComponent();
        }

        private void Btn_Print_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount>0)
            {
                gridControl1.ShowRibbonPrintPreview();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            try
            {
                dt = s.ReportReurnSuppliers(DateFrom.Value, DateTo.Value);
                gridControl1.DataSource = dt;

                decimal total = 0;
                for (int i = 0; i < gridView1.DataRowCount; i++)
                {
                    DataRow row = gridView1.GetDataRow(i);
                    total += Convert.ToDecimal(row[5].ToString());

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

        private void Frm_ReportReturnSuppliers_Load(object sender, EventArgs e)
        {

        }
    }
}
