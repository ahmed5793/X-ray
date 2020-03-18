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
    public partial class Frm_TypeShift : Form
    {
        Techincal Techincal = new Techincal();

        public Frm_TypeShift()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {

            try
            {
                if (Txt_Salary.Text != "")
                {
                    Techincal.Add_TypeShift(Txt_Salary.Text);
                    MessageBox.Show("تمت  الاضافة بنجاح");
                    Txt_Salary.Clear();
                    Txt_Salary.Focus();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
