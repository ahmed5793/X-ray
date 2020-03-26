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
    public partial class Frm_ReportDoctorOfCenterData : Form
    {
        DoctorOfCenter d = new DoctorOfCenter();

        public Frm_ReportDoctorOfCenterData()
        {
            InitializeComponent();
            gridControl1.DataSource = d.SelectDoctor_OFCENTER();
            gridView1.Columns[3].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }

        private void Frm_ReportDoctorOfCenterData_Load(object sender, EventArgs e)
        {

        }
    }
}
