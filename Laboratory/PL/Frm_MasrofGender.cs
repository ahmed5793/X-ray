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
    public partial class Frm_MasrofGender : Form
    {
        Masrofat m = new Masrofat();
        public Frm_MasrofGender()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void btn_save_Click(object sender, EventArgs e)
        {


        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            if (txt_name.Text != string.Empty)
            {
                m.AddReserve(txt_name.Text);
                MessageBox.Show("تم التسجيل بنجاح", "عمليه التسجيل", MessageBoxButtons.OK);

                Frm_Masrofat.getmain.comboBox1.DataSource = m.SelectReserve();

                Frm_Masrofat.getmain.comboBox1.DisplayMember = "masrof_type";
                Frm_Masrofat.getmain.comboBox1.ValueMember = "ID_masrof";
                this.Close();
            }

            else
            {
                MessageBox.Show("من فضلك لابد من كتابه نوع المصروف");
            }
        }

        private void btn_prod_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
