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
    public partial class Frm_checkTimeUserName : DevExpress.XtraEditors.XtraForm
    {
        Users u = new Users();

        public Frm_checkTimeUserName()
        {
            InitializeComponent();
            u.SelectAllCheckUserName();
        }

        private void Frm_checkTimeUserName_Load(object sender, EventArgs e)
        {

        }
    }
}