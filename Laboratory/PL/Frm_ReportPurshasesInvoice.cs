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
            dataGridView1.DataSource = Suppliers.Report_PurshasesInvoice();
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
