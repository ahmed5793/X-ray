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
        Users U = new Users();
        Branches b = new Branches();
        DataTable dt = new DataTable();
        public Frm_EmployeeDiscount()
        {
            InitializeComponent();
            txt_UserName.Text = Program.salesman;
            Permision();
            //cmb_Employee.DataSource = E.SelectCompoEmployee();
            //cmb_Employee.DisplayMember = "Emp_Name";
            //cmb_Employee.ValueMember = "Emp_ID";
        }
        void Permision()
        {
            try
            {            
            dt.Clear();
            dt = U.SelectUserBranch(txt_UserName.Text);
            if (dt.Rows.Count > 0)
            {
                Cmb_Branch.DataSource = U.SelectUserBranch(txt_UserName.Text);
                Cmb_Branch.DisplayMember = "Name";
                Cmb_Branch.ValueMember = "Branch_ID";
            }
            else
            {
                Cmb_Branch.DataSource = b.SelectCompBranches();
                Cmb_Branch.DisplayMember = "Name";
                Cmb_Branch.ValueMember = "Branch_ID";
            }
            cmb_Employee.DataSource = E.Select_EmployeeFromBranchToAddShift(Convert.ToInt32(Cmb_Branch.SelectedValue));
            cmb_Employee.DisplayMember = "Emp_Name";
            cmb_Employee.ValueMember = "id_employee";
            cmb_Employee.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Frm_EmployeeDiscount_Load(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            
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

        private void Btn_AddShift_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_Employee.Text == "")
                {
                    MessageBox.Show("من فضلك قم بااختيار اسم العميل");
                    return;
                }
                if (txt_Money.Text == "" || txt_Money.Text == "0")
                {
                    MessageBox.Show("من فضلك قم باادخال المبلغ الذى تريد خصمة");
                    return;
                }
                if (txt_reason.Text == "")
                {
                    MessageBox.Show("من فضلك قم باادخال سبب الخصم");
                    return;
                }
                E.AddEmployeeDiscount(Convert.ToInt32(cmb_Employee.SelectedValue), Convert.ToDecimal(txt_Money.Text),
                    txt_reason.Text, Date_insert.Value, txt_UserName.Text,Convert.ToInt32(Cmb_Branch.SelectedValue));
                MessageBox.Show("تم الحفظ بنجاح");
                txt_reason.Clear();
                txt_Money.Text = "0";
                cmb_Employee.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void Cmb_Branch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                cmb_Employee.DataSource = E.Select_EmployeeFromBranchToAddShift(Convert.ToInt32(Cmb_Branch.SelectedValue));
                cmb_Employee.DisplayMember = "Emp_Name";
                cmb_Employee.ValueMember = "id_employee";
                cmb_Employee.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
         
        }

        private void Cmb_Branch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
