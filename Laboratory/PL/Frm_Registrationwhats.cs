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

namespace Laboratory.PL
{
    public partial class Frm_Registrationwhats : DevExpress.XtraEditors.XtraForm
    {
        string password;
        public Frm_Registrationwhats()
        {
            InitializeComponent();
        }

        private void Frm_Registrationwhats_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (WhatsAppApi.Register.WhatsRegisterV2.RequestCode(txt_Number.Text,out password,"sms"))
            {
                
            }
        }
    }
}