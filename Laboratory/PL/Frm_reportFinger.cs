using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Laboratory.BL;

namespace Laboratory.PL
{
    public partial class Frm_reportFinger : DevExpress.XtraEditors.XtraForm
    {
        Finger f = new Finger();
        public Frm_reportFinger()
        {
            InitializeComponent();
            comboBox2.DataSource = f.selectidfingeremployee();
            comboBox2.DisplayMember = "IDEmployee";
            comboBox2.ValueMember = "IDEmployee";
        }

        private void Frm_reportFinger_Load(object sender, EventArgs e)
        {

        }

        private void Btn_AddShift_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            DataTable dtall = new DataTable();
            dt  = f.SELECTFingerIDemployee(Convert.ToInt32(comboBox2.SelectedValue));
            dt1= f.SELECTFingerIDemployeeOut(Convert.ToInt32(comboBox2.SelectedValue));
            dtall = dt.Copy();
            dtall.Merge(dt1);
            gridControl1.DataSource = dtall;

        }
    }
}