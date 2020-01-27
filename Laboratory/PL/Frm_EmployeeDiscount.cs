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
    public partial class Frm_EmployeeDiscount : Form
    {
        Employee E = new Employee();
        public Frm_EmployeeDiscount()
        {
            InitializeComponent();
            txt_UserName.Text = Program.salesman;
            cmb_Employee.DataSource = E.SelectCompoEmployee();
            cmb_Employee.DisplayMember = "Emp_Name";
            cmb_Employee.ValueMember = "Emp_ID";
        }

        private void Frm_EmployeeDiscount_Load(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (cmb_Employee.Text=="")
            {
                MessageBox.Show("من فضلك قم بااختيار اسم العميل");
                return;
            }
            if (txt_Money.Text==""||txt_Money.Text=="0")
            {
                MessageBox.Show("من فضلك قم باادخال المبلغ الذى تريد خصمة");
                return;
            }
            if (txt_reason.Text=="")
            {
                MessageBox.Show("من فضلك قم باادخال سبب الخصم");
                return;
            }
            E.AddEmployeeDiscount(Convert.ToInt32(cmb_Employee.SelectedValue), Convert.ToDecimal(txt_Money.Text), txt_reason.Text, Date_insert.Value, txt_UserName.Text);
            MessageBox.Show("تم الحفظ بنجاح");
            txt_reason.Clear();
            txt_Money.Text = "0";

        }

        private void txt_Money_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && txt_Money.Text.ToString().IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar((System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)))
            {
                e.Handled = true;
            }
        }

        private void cmb_Employee_Leave(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (cmb_Employee.Text != "")
            {
                dt.Clear();
                dt = E.VildateEmployeeShift(Convert.ToInt32(cmb_Employee.SelectedValue));
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("يرجي العلم بان اسم الموظف غير مسجل من قبل يرجي تسجيل هذا الاسم في شاشه الموظفين", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                    cmb_Employee.Focus();
                    cmb_Employee.SelectAll();
                    return;
                }
                dt.Dispose();
            }
        }
    }
}
