using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tourism_Company.BL;

namespace Tourism_Company.PL
{
    public partial class Form_Plane : Form
    {
        Plane p = new Plane();
        public Form_Plane()
        {
            InitializeComponent();
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            try
            {

                 if (txt_name.Text == "")
                {
                    MessageBox.Show("يرجي التاكد من نوع الطيارة");
                }
                else
                {

                    p.addPlane(txt_name.Text);

                    MessageBox.Show("تم التسجيل  بنجاح", "عمليه الاضافه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                  
                    txt_name.Clear();
                 


                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
