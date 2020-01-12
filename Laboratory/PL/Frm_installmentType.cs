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
    public partial class Frm_installmentType : Form
    {
        Installment i = new Installment();
        public Frm_installmentType()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "")
            {
                MessageBox.Show("");
                return;
            }
            i.AddinstallmentType(txt_name.Text);
            MessageBox.Show("تم الاضافة");
            txt_name.Clear();
     
        }
    }
}
