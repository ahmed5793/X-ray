using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratory.PL
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
            PL.Frm_Order frm = new Frm_Order();
            frm.MdiParent = this;
            frm.Show();
        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
            
                PL.Frm_Tickets frm = new Frm_Tickets();
                frm.MdiParent = this;
                frm.Show();
            }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PL.Frm_Branches frm = new Frm_Branches();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
