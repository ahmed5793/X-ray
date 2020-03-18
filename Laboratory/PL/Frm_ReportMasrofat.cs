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
            gridControl1.DataSource = M.select_Masrofat();
            Calc_Total();
        }
        void Calc_Total()
        {
            decimal total = 0;
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                DataRow row = gridView1.GetDataRow(i);
                total += Convert.ToDecimal(row[1].ToString());

            }
            textBox1.Text = total.ToString("₱ #,##0.0");

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
    
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }

        private void Frm_ReportMasrofat_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                dt.Clear();
                dt = M.search_Masrofat(DateFrom.Value, DateTo.Value);
                gridControl1.DataSource = dt;
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
