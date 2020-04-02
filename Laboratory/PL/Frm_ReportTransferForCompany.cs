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
    public partial class Frm_ReportTransferForCompany : Form
    {
        Tickets T = new Tickets();
        public Frm_ReportTransferForCompany()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Frm_ReportTransferForCompany_Load(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            dt.Clear();
            dt = T.ReportSelectTransferCompany(DateFrom.Value, DateTo.Value);
            gridControl1.DataSource = dt;

            decimal total = 0;
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                DataRow row = gridView1.GetDataRow(i);
                total += Convert.ToDecimal(row[8].ToString());

            }
            textBox1.Text = total.ToString("₱ #,##0.0");

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }
    }
}
