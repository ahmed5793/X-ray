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
    public partial class UpdateSalf : Form
    {
        Employee E = new Employee();
        DataTable dt = new DataTable();
        public UpdateSalf()
        {
            InitializeComponent();
        }

        private void cmb_employeeName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmb_employeeName.Text != "")
            {
                dt.Clear();
                dt = E.SelectSalaryMins(Convert.ToInt32(cmb_employeeName.SelectedValue));
                if (dt.Rows.Count > 0)
                {
                
                   
                    txt_salf.Text = dt.Rows[0][1].ToString();
                    txt_date.Text = dt.Rows[0][2].ToString();
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (Txt_UpdateSalary.Text==""||Txt_UpdateSalary.Text=="0")
            {
                MessageBox.Show("من فضلك قم باادخال مبلغ الاستلاف");
                return;
            }
            else
            {
                E.UpdateSSalaryMins(Convert.ToInt32(cmb_employeeName.SelectedValue), Convert.ToDecimal(Txt_UpdateSalary.Text));
                MessageBox.Show("تم تعديل الباينات بنجاح");
            }
        }
    }
}
