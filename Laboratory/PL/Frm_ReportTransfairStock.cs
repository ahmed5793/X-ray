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
    public partial class Frm_ReportTransfairStock : Form
    {
        Stock S = new Stock();
        public Frm_ReportTransfairStock()
        {
            InitializeComponent();
            dataGridView1.DataSource = S.Report_TransfairStock();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                dt.Clear();
                dt = S.Search_Report_TransfairStock( DateFrom.Value, DateTo.Value);
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
