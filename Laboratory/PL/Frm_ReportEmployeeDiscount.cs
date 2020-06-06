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
    public partial class Frm_ReportEmployeeDiscount : Form
    {
        Employee E = new Employee();
        Users U = new Users();
        Branches b = new Branches();
        DataTable dt = new DataTable();
        void Permision()
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
            comboBox1.DataSource = E.Select_EmployeeFromBranchToAddShift();
            comboBox1.DisplayMember = "Emp_Name";
            comboBox1.ValueMember = "Emp_ID";
            comboBox1.SelectedIndex = -1;
        }
        public Frm_ReportEmployeeDiscount()
        {
            InitializeComponent();
            Function();
            //comboBox1.DataSource = E.SelectCompoEmployee();
            //comboBox1.DisplayMember = "Emp_Name";
            //comboBox1.ValueMember = "Emp_ID";
        }
        void Function()
        {
            try
            {
                checkBox1.Checked = true;
                txt_UserName.Text = Program.salesman;
                Permision();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void btn_search_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                comboBox1.Enabled = true;
                comboBox1.DataSource = E.Select_EmployeeFromBranchToAddShift();
                comboBox1.DisplayMember = "Emp_Name";
                comboBox1.ValueMember = "Emp_ID";
                comboBox1.SelectedIndex = -1;
            }
            else
            {
                comboBox1.Enabled = false;
                comboBox1.DataSource = null;
            }
            gridControl1.DataSource = null;
        }

        private void Frm_ReportEmployeeDiscount_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                dt.Clear();
                dt = E.VildateEmployeeShift(Convert.ToInt32(comboBox1.SelectedValue));
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("يرجي العلم بان اسم الموظف غير مسجل من قبل يرجي تسجيل هذا الاسم في شاشه الموظفين", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                    comboBox1.Focus();
                    comboBox1.SelectAll();
                    return;
                }
                dt.Dispose();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked == true)
            {
                gridControl1.DataSource = E.ReportselecEmployeetDiscount(Convert.ToInt32(comboBox1.SelectedValue), 
                                                                          DateFrom.Value, DateTo.Value);          
            }
            else if (checkBox1.Checked == false)
            {
                gridControl1.DataSource = E.ReportselecDateEmployeetDiscount(Convert.ToInt32(Cmb_Branch.SelectedValue),
                                                    DateFrom.Value, DateTo.Value);
            }
            decimal total = 0;
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                DataRow row = gridView1.GetDataRow(i);
                total += Convert.ToDecimal(row[1].ToString());
            }
            txt_totalpay.Text = total.ToString("₱ #,##0.0");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Cmb_Branch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //comboBox1.DataSource = E.Select_EmployeeFromBranchToAddShift(Convert.ToInt32(Cmb_Branch.SelectedValue));
            //comboBox1.DisplayMember = "Emp_Name";
            //comboBox1.ValueMember = "id_employee";
            //comboBox1.SelectedIndex = -1;
        }
    }
}
