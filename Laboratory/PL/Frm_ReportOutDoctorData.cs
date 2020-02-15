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
    public partial class Frm_ReportOutDoctorData : Form
    {
        Doctors d = new Doctors();

        public Frm_ReportOutDoctorData()
        {
            InitializeComponent();
            gridControl1.DataSource = d.SelectDoctor();
        }

        private void Frm_ReportOutDoctorData_Load(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }
    }
}
