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
    public partial class Frm_ReportTechnicalData : Form
    {
        Techincal t = new Techincal();

        public Frm_ReportTechnicalData()
        {
            InitializeComponent();

            funncation();
        }
        void funncation()
        {
            try
            {

          
            gridControl1.DataSource = t.SelectTechincal();
            gridView1.Columns[3].Visible = false;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
        }

        private void Frm_ReportTechnicalData_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }
    }
}
