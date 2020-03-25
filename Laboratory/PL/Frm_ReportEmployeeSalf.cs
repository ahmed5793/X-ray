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
    public partial class Frm_ReportEmployeeSalf : Form
    {
        Employee E = new Employee();
        DataTable dt = new DataTable();
        Users U = new Users();
        Branches b = new Branches();
        public Frm_ReportEmployeeSalf()
        {
            InitializeComponent();
            checkBox1.Checked = true;
            txt_UserName.Text = Program.salesman;
            Permision();


        }
        void Permision()
        {

            dt.Clear();
            dt = U.SelectUserBranch(txt_UserName.Text);
            if (dt.Rows.Count > 0)
            {
                cmb_Branch.DataSource = U.SelectUserBranch(txt_UserName.Text);
                cmb_Branch.DisplayMember = "Name";
                cmb_Branch.ValueMember = "Branch_ID";
            }
            else
            {
                cmb_Branch.DataSource = b.SelectCompBranches();
                cmb_Branch.DisplayMember = "Name";
                cmb_Branch.ValueMember = "Branch_ID";
            }
            cmb_employeeName.DataSource = E.Select_EmployeeFromBranchToAddShift(Convert.ToInt32(cmb_Branch.SelectedValue));
            cmb_employeeName.DisplayMember = "Emp_Name";
            cmb_employeeName.ValueMember = "id_employee";
            cmb_employeeName.SelectedIndex = -1;

        }
        private void Frm_ReportEmployeeSalf_Load(object sender, EventArgs e)
        {
         

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
          
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
            
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                cmb_employeeName.Enabled = true;

                Permision();
            }
            else
            {
                cmb_employeeName.Enabled = false;
              
                cmb_employeeName.DataSource = null;
                gridControl1.DataSource = null;
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (cmb_employeeName.Text != "")
            {
                dt.Clear();
                dt = E.VildateEmployeeShift(Convert.ToInt32(cmb_employeeName.SelectedValue));
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("يرجي العلم بان اسم الموظف غير مسجل من قبل يرجي تسجيل هذا الاسم في شاشه الموظفين", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                    cmb_employeeName.Focus();
                    cmb_employeeName.SelectAll();
                    return;
                }
                dt.Dispose();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked == true)
            {
                if (cmb_employeeName.Text == "")
                {

                    MessageBox.Show("من فضلك قم بااختيار اسم الموظف ");
                    return;
                }
                gridControl1.DataSource = E.ReportSearchEmployeeSalf(Convert.ToInt32(cmb_employeeName.SelectedValue), DateFrom.Value, DateTo.Value);

            }
            else
            {
                gridControl1.DataSource = E.ReportSearchDateEmployeeSalf(DateFrom.Value, DateTo.Value,Convert.ToInt32(cmb_Branch.SelectedValue));

            }
            decimal total = 0;
            for (int i = 0; i < gridView1.DataRowCount; i++)
            {
                DataRow row = gridView1.GetDataRow(i);
                total += Convert.ToDecimal(row[3].ToString());

            }
            txt_totalpay.Text = total.ToString("₱ #,##0.0");
        }

        private void cmb_employeeName_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
        }

        private void cmb_Branch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmb_employeeName.DataSource = E.Select_EmployeeFromBranchToAddShift(Convert.ToInt32(cmb_Branch.SelectedValue));
            cmb_employeeName.DisplayMember = "Emp_Name";
            cmb_employeeName.ValueMember = "id_employee";
            cmb_employeeName.SelectedIndex = -1;
        }
    }
    }
