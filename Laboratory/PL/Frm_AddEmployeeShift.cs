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
    public partial class Frm_AddEmployeeShift : Form
    {
        Employee E = new Employee();
        Branches b = new Branches();
        Users U = new Users();
        DataTable dt = new DataTable();
        public Frm_AddEmployeeShift()
        {
            InitializeComponent();
            Txt_SalesMAn.Text = Program.salesman;
            Permision();
            Btn_DeleteShift.Enabled = false;
            Btn_UpdateShift.Enabled = false;
            gridControl1.DataSource = E.Select_EmployeeShift(Convert.ToInt32(Cmb_Branch.SelectedValue));
        }
        void Permision()
        {
            dt.Clear();
            dt = U.SelectUserBranch(Txt_SalesMAn.Text);
            if (dt.Rows.Count > 0)
            {
                Cmb_Branch.DataSource = U.SelectUserBranch(Txt_SalesMAn.Text);
                Cmb_Branch.DisplayMember = "Name";
                Cmb_Branch.ValueMember = "Branch_ID";
            }
            else
            {
                Cmb_Branch.DataSource = b.SelectCompBranches();
                Cmb_Branch.DisplayMember = "Name";
                Cmb_Branch.ValueMember = "Branch_ID";
            }
            comboBox1.DataSource = E.Select_EmployeeShiftFromBranchToAddShift(Convert.ToInt32(Cmb_Branch.SelectedValue));
            comboBox1.DisplayMember = "Emp_Name";
            comboBox1.ValueMember = "id_employee";
            comboBox1.SelectedIndex = -1;
            if (comboBox1.Text != "")
            {
                textBox1.Text = E.selectEmployeeRoleshift(Convert.ToInt32(comboBox1.SelectedValue)).Rows[0][0].ToString();
            }
        }
        private void Btn_UpdateShift_Click(object sender, EventArgs e)
        {
            
        }

        private void Frm_AddEmployeeShift_Load(object sender, EventArgs e)
        {
               //comboBox1.DataSource = E.selectEmployeeGenderSalary();
            //    comboBox1.DisplayMember = "Emp_Name";
            //    comboBox1.ValueMember = "Emp_ID";


        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                textBox1.Text = E.selectEmployeeRoleshift(Convert.ToInt32(comboBox1.SelectedValue)).Rows[0][0].ToString();
            }
        }

        private void Btn_DeleteShift_Click(object sender, EventArgs e)
        {
        }

        private void Btn_AddShift_Click(object sender, EventArgs e)
        {
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
        //    dt.Clear();
        //    dt = E.Search_EmployeeShift(txt_search.Text);
        //    gridControl1.DataSource = dt;
        }
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
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

        private void Btn_AddShift_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "")
                {
                    MessageBox.Show("لا بد من تحديد إسم الموظف ");
                    return;
                }
                if (Txt_Cost.Text == "0" || Txt_Cost.Text == "")
                {
                    MessageBox.Show("يرجى تحديد سعر الشيفت");
                    return;
                }
                if (comboBox1.Text != "")
                {
                    for (int i = 0; i < gridView1.RowCount; i++)
                    {
                        DataRow row = gridView1.GetDataRow(i);
                        if (comboBox1.Text == row[1].ToString() &&
                            dateTimePicker1.Text == (row[3].ToString())
                            && dateTimePicker3.Text == (row[4].ToString())
                            && dateTimePicker2.Text == (row[5].ToString()))
                        {
                            MessageBox.Show("تم إضافة هذا الشيفت لنفس الموظف فى نفس الوقت من قبل ");
                            return;
                        }
                    }
                    E.Add_EmployeeShift(Convert.ToInt32(comboBox1.SelectedValue),
                       (dateTimePicker1.Text), (dateTimePicker3.Text), (dateTimePicker2.Text), Convert.ToDecimal(Txt_Cost.Text)
                        , Convert.ToInt32(Cmb_Branch.SelectedValue),Txt_SalesMAn.Text);
                    MessageBox.Show("تم إضافة الشيفت بنجاح");
                    Txt_Cost.Text = "0";
                    gridControl1.DataSource = E.Select_EmployeeShift(Convert.ToInt32(Cmb_Branch.SelectedValue));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {                
                if (comboBox1.Text == "")
                {
                    MessageBox.Show("لا بد من تحديد إسم الموظف ");
                    return;
                }
                if (Txt_Cost.Text == "0" || Txt_Cost.Text == "")
                {
                    MessageBox.Show("يرجى تحديد سعر الشيفت");
                    return;
                }
                if (MessageBox.Show("هل تريد تعديل الشيفت", "عملية التعديل", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    for (int i = 0; i < gridView1.RowCount; i++)
                    {
                        DataRow row = gridView1.GetDataRow(i);
                        if (comboBox1.Text == row[1].ToString() &&
                            dateTimePicker1.Text == (row[3].ToString())
                            && dateTimePicker3.Text == (row[4].ToString())
                            && dateTimePicker2.Text == (row[5].ToString()))

                        {
                            MessageBox.Show("تم إضافة هذا الشيفت لنفس الموظف فى نفس الوقت من قبل ");
                            return;
                        }
                    }
                    E.Update_EmployeeShift(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الشيفت")), Convert.ToInt32(comboBox1.SelectedValue),
                         (dateTimePicker1.Text), (dateTimePicker3.Text),
                        (dateTimePicker2.Text), Convert.ToDecimal(Txt_Cost.Text), Convert.ToInt32(Cmb_Branch.SelectedValue), Txt_SalesMAn.Text);
                    MessageBox.Show("تم تعديل الشيفت بنجاح", "عملية التعديل");
                }
                else
                {
                    MessageBox.Show("تم إلغاء تعديل الشيفت ", "عملية التعديل");
                }
                Txt_Cost.Text = "0";
                gridControl1.DataSource = E.Select_EmployeeShift(Convert.ToInt32(Cmb_Branch.SelectedValue));
                comboBox1.Enabled = true;
                Btn_AddShift.Enabled = true;
                Btn_UpdateShift.Enabled = false;
                Btn_DeleteShift.Enabled = false;
                gridControl1.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void Btn_DeleteShift_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("هل تريد مسح الشيفت", "عملية المسح", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    E.Delete_EmployeeShift(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الشيفت")));
                    MessageBox.Show("تم مسح الشيفت بنجاح");
                }
                else
                {
                    MessageBox.Show("تم إلغاء مسح الشيفت ");            
                }
                Txt_Cost.Text = "0";
                gridControl1.DataSource = E.Select_EmployeeShift(Convert.ToInt32(Cmb_Branch.SelectedValue));
                comboBox1.Enabled = true;
                Btn_AddShift.Enabled = true;
                Btn_UpdateShift.Enabled = false;
                Btn_DeleteShift.Enabled = false;
                gridControl1.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {
        }
        private void Cmb_Branch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox1.DataSource = E.Select_EmployeeShiftFromBranchToAddShift(Convert.ToInt32(Cmb_Branch.SelectedValue));
            comboBox1.DisplayMember = "Emp_Name";
            comboBox1.ValueMember = "id_employee";
            comboBox1.SelectedIndex = -1;
            gridControl1.DataSource = E.Select_EmployeeShift(Convert.ToInt32(Cmb_Branch.SelectedValue));

        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (gridView1.RowCount > 0 )
                {
                    comboBox1.Enabled = false;
                Btn_AddShift.Enabled = false;
                gridControl1.Enabled = false;
                Btn_UpdateShift.Enabled = true;
                Btn_DeleteShift.Enabled = true;
                comboBox1.Text = gridView1.GetFocusedRowCellValue("إسم الموظف").ToString();
                textBox1.Text = gridView1.GetFocusedRowCellValue("التخصص").ToString();
                Txt_Cost.Text = gridView1.GetFocusedRowCellValue("سعر الشيفت").ToString();
                //Txt_SalesMAn.Text = gridView1.GetFocusedRowCellValue("إسم المستخدم").ToString();
                dateTimePicker1.Value = Convert.ToDateTime(gridView1.GetFocusedRowCellValue("تاريخ الشيفت"));
                dateTimePicker3.Value = Convert.ToDateTime(gridView1.GetFocusedRowCellValue("من وقت"));
                dateTimePicker2.Value = Convert.ToDateTime(gridView1.GetFocusedRowCellValue("إلى وقت"));

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void Txt_Cost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar=='.'&& Txt_Cost.Text.ToString().IndexOf('.')>-1)
            {
                e.Handled = true;
            }
            if (!char.IsDigit(e.KeyChar)&& e.KeyChar!=8 && e.KeyChar!=Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                e.Handled = true;
            }
        }

        private void Txt_Cost_MouseMove(object sender, MouseEventArgs e)
        {
            if (Txt_Cost.Text == "")
            {
                Txt_Cost.Text = "0";
            }
        }
    }
}
