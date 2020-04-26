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
    public partial class Frm_Employee : Form
    {
        Employee E = new Employee();
        DataTable dt = new DataTable();
        Branches b = new Branches();
        private static Frm_Employee farm;

        static void STATUESCllosed(object sender, FormClosedEventArgs e)
        {
            farm = null;
        }
        public static Frm_Employee getmain
        {
            get
            {
                if (farm == null)
                {
                    farm = new Frm_Employee();
                    farm.FormClosed += new FormClosedEventHandler(STATUESCllosed);
                }
                return farm;
            }
        }

        public Frm_Employee()
        {
            InitializeComponent();
            txt_name.Focus() ;
            if (farm == null)
            {
                farm = this;
            }
            Function();
        }
        void Function()
        {
            try
            {
                clears();
                dateTimePicker1.Value = DateTime.Now;
                gridControlInsert.DataSource = E.SelectEmployee();

                cmb_department.DataSource = E.SelectEmpRoleCompo();
                cmb_department.DisplayMember = "Roles";
                cmb_department.ValueMember = "ID_EmpRole";
                cmb_department.SelectedIndex = -1;
                cmb_branch.DataSource = b.SelectCompBranches();
                cmb_branch.DisplayMember = "Name";
                cmb_branch.ValueMember = "Branch_ID";
                cmb_branch.SelectedIndex = -1;
                txt_IdEmploye.Hide();
            }
            catch (Exception)
            {
                return;
                //MessageBox.Show(ex.Message);
            }
        }
        void clears()
        {
            Btn_Add.Enabled = true;
            Btn_Update.Enabled = false;
            txt_address.Clear();
            txt_name.Clear();
            txt_NationalID.Clear();
            txt_phone.Clear();
            Txt_Salary.Text="0";
            checkBox1.Checked = false;
            cmb_branch.Enabled = false;
            cmb_branch.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;
            cmb_department.SelectedIndex = -1;
            Txt_Salary.Hide();
            txt_name.Focus();
        }
        private void btn_GenderJob_Click(object sender, EventArgs e)
        {
            Frm_GenderJob fg = new Frm_GenderJob();
            fg.ShowDialog();
            cmb_department.DataSource = E.SelectEmpRoleCompo();
        }

        private void Frm_Employee_Load(object sender, EventArgs e)
        {
            Txt_Salary.Hide();
            checkBox1.Checked = false;
            cmb_branch.Enabled = false;
            if (checkBox1.Checked == false)
            {
                cmb_branch.SelectedIndex = -1;
            }
            else if (checkBox1.Checked == true)
            {
                cmb_branch.DataSource = b.SelectCompBranches();
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
 
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            //dt.Clear();
            //dt = E.SearchEmployes(txt_search.Text);
            //dataGridView1.DataSource = dt;
        }

        private void txt_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txt_NationalID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void Txt_Salary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && Txt_Salary.Text.ToString().IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar((System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)))
            {
                e.Handled = true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
   
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }
        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox1.Text == "شيفت")
            {
                Txt_Salary.Hide();
            }
            else if (comboBox1.Text == "مرتب شهرى")
            {
                Txt_Salary.Show();
            }
            Txt_Salary.Text = "0";

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            clears();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "")
                {
                    MessageBox.Show("من فضلك قم بااختيار نوع الراتب");
                    
                    return;
                }

                if (txt_name.Text == "")
                {
                    MessageBox.Show("من فضلك قم بكتابة اسم الموظف");
                    txt_name.Focus();
                    return;
                }

                if (cmb_department.Text == "")
                {
                    MessageBox.Show("من فضلك قم بااختيار التخصص");
                    cmb_department.Focus();
                    return;

                }
                if (comboBox1.Text=="مرتب شهرى" && Txt_Salary.Text == "0")
                {
                    MessageBox.Show("من فضلك قم بتحديد المرتب");
                    Txt_Salary.Focus();
                    return;
       
                }
                else
                {
                    E.AddEmployee(txt_name.Text, Convert.ToDecimal(Txt_Salary.Text), comboBox1.Text,
                        txt_NationalID.Text, txt_phone.Text, txt_address.Text, dateTimePicker1.Value, Convert.ToInt32(cmb_department.SelectedValue));
                    dt.Clear();
                    dt = E.Select_LastId_Employee();
                    if (checkBox1.Checked==true)
                    {
                        if (cmb_branch.Text=="")
                        {
                            MessageBox.Show("لا بد من تحديد الفرع ");
                            cmb_branch.Focus();
                            return;
                        }
                        else if (cmb_branch.Text != "")

                        {
                            E.AddEmployeeBranch(Convert.ToInt32(cmb_branch.SelectedValue), Convert.ToInt32(dt.Rows[0][0]));
                        }
                    }
                 
                  

                    MessageBox.Show("تم حفظ بيانات الموظف بنجاح");
                    clears();
                    gridControlInsert.DataSource = E.SelectEmployee();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "")
                {
                    MessageBox.Show("من فضلك قم بااختيار نوع الراتب");
                    return;
                }
                if (txt_name.Text == "")
                {
                    MessageBox.Show("من فضلك قم بكتابة اسم الموظف");
                    return;
                }
                if (cmb_department.Text == "")
                {
                    MessageBox.Show("من فضلك قم بااختيار التخصص");
                    return;
                }
                if (comboBox1.Text == "مرتب شهرى" && Txt_Salary.Text == "0.00")
                {
                    MessageBox.Show("من فضلك قم بتحديد المرتب");
                    Txt_Salary.Focus();
                    return;
                }
                else if(MessageBox.Show(" هل تريد تعديل البيانات للموظف","عملية التعديل" , MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
                {
                    E.UpdateEmployee(txt_name.Text, Convert.ToDecimal(Txt_Salary.Text), comboBox1.Text,
                        txt_NationalID.Text, txt_phone.Text, txt_address.Text, dateTimePicker1.Value, 
                        Convert.ToInt32(cmb_department.SelectedValue), Convert.ToInt32(txt_IdEmploye.Text));

                    dt.Clear();
                    dt = E.VildateEmployeeBranch(Convert.ToInt32(txt_IdEmploye.Text));
                    if (checkBox1.Checked==true)
                    {
                        if (cmb_branch.Text == "")
                        {
                            MessageBox.Show("لا بد من تحديد الفرع ");
                            cmb_branch.Focus();
                            return;
                        }
                        if (dt.Rows.Count > 0)
                        {
                            E.UpdateEmployeeBranch(Convert.ToInt32(cmb_branch.SelectedValue),
                                Convert.ToInt32(txt_IdEmploye.Text));
                        }
                        else
                        {
                            E.AddEmployeeBranch(Convert.ToInt32(cmb_branch.SelectedValue), 
                                Convert.ToInt32(txt_IdEmploye.Text));
                        }
                    }
                    else if(checkBox1.Checked==false)
                    {
                        if (dt.Rows.Count > 0)
                        {
                            E.Delete_EmployeeBranch(Convert.ToInt32(txt_IdEmploye.Text));
                        }
                    }
                    MessageBox.Show("تم تعديل بيانات الموظف بنجاح");
                    
                }
                else
                {
                    MessageBox.Show("تم إلغاء التعديل ");
                }
                clears();
                gridControlInsert.DataSource = E.SelectEmployee();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                MessageBox.Show(ex.StackTrace);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                cmb_branch.Enabled = true;

                //cmb_branch.DataSource = b.SelectCompBranches();
            }
            else if(checkBox1.Checked==false)
            {
                cmb_branch.Enabled = false;
            }
            cmb_branch.SelectedIndex = -1;

        }

        private void Txt_Salary_Leave(object sender, EventArgs e)
        {
            if (Txt_Salary.Text=="")
            {
                Txt_Salary.Text = "0";
            }
        }
        private void Txt_Salary_TextChanged(object sender, EventArgs e)
        {         
        }
        private void Txt_Salary_Click(object sender, EventArgs e)
        {           
            Txt_Salary.SelectAll();           
        }
        private void Txt_Salary_MouseLeave(object sender, EventArgs e)
        {
            if (Txt_Salary.Text == "")
            {
                Txt_Salary.Text = "0";
            }
        }

        private void gridControlInsert_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (gridViewInsert.RowCount > 0)
                {
                    Txt_Salary.Show();
                    Btn_Update.Enabled = true;
                    Btn_Add.Enabled = false;
                    txt_IdEmploye.Text = gridViewInsert.GetFocusedRowCellValue("رقم الموظف").ToString();
                    txt_name.Text = gridViewInsert.GetFocusedRowCellValue("اسم الموظف").ToString();
                    cmb_department.Text = gridViewInsert.GetFocusedRowCellValue("التخصص").ToString();
                    dateTimePicker1.Text = gridViewInsert.GetFocusedRowCellValue("تاريخ التسجيل").ToString();
                    txt_phone.Text = gridViewInsert.GetFocusedRowCellValue("موبايل").ToString();
                    txt_address.Text = gridViewInsert.GetFocusedRowCellValue("العنوان").ToString();
                    txt_NationalID.Text = gridViewInsert.GetFocusedRowCellValue("الرقم القومي").ToString();
                    if (gridViewInsert.GetFocusedRowCellValue("نوع الراتب").ToString() == "شيفت")
                    {
                        Txt_Salary.Hide();
                    }
                    else if (gridViewInsert.GetFocusedRowCellValue("نوع الراتب").ToString() == "مرتب شهرى")
                    {
                        Txt_Salary.Show();
                        Txt_Salary.Text = gridViewInsert.GetFocusedRowCellValue("الراتب").ToString();

                    }
                    comboBox1.Text = gridViewInsert.GetFocusedRowCellValue("نوع الراتب").ToString();
                    if (gridViewInsert.GetFocusedRowCellValue("الفرع").ToString() == "")
                    {
                        cmb_branch.Text = gridViewInsert.GetFocusedRowCellValue("الفرع").ToString();
                        checkBox1.Checked = false;
                        cmb_branch.Enabled = false;
                    }
                    else if (gridViewInsert.GetFocusedRowCellValue("الفرع").ToString() != "")
                    {
                        //cmb_branch.DataSource = b.SelectCompBranches();
                        checkBox1.Checked = true;
                        cmb_branch.Enabled = true; 
                        cmb_branch.Text = gridViewInsert.GetFocusedRowCellValue("الفرع").ToString();

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }
    }
}
