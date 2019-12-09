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
            if (farm == null)
            {
                farm = this;
            }
            clears();
            dataGridView1.DataSource = E.SelectEmployee();
            cmb_department.DataSource = E.SelectEmpRole();
            cmb_department.DisplayMember = "Roles";
            cmb_department.ValueMember = "ID_EmpRole";
            
            
        }
        void clears()
        {
            btn_new.Hide();
            btn_save.Show();
            btn_update.Enabled = false;
            txt_address.Clear();
            txt_name.Clear();
            txt_NationalID.Clear();
            txt_phone.Clear();
            Txt_Salary.Clear();
           
        }
        private void btn_GenderJob_Click(object sender, EventArgs e)
        {
            Frm_GenderJob fg = new Frm_GenderJob();
            fg.ShowDialog();
            cmb_department.DataSource = E.SelectEmpRole();
            fg.Dispose();
        }

        private void Frm_Employee_Load(object sender, EventArgs e)
        {

            //cmb_branches.DataSource = b.SelectCompBranches();
            //cmb_branches.DisplayMember = "Name";
            //cmb_branches.ValueMember = "Branch_ID";
           

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            clears();

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_address.Text=="")
                {
                    MessageBox.Show("من فضلك قم بكتابة العنوان");
                    return;
                }
                if (txt_name.Text=="")
                {
                    MessageBox.Show("من فضلك قم بكتابة اسم الموظف");
                    return;
                }
                if (txt_phone.Text=="")
                {
                    MessageBox.Show("من فضلك قم بكتابة رقم الموبايل");
                    return;
                }
                if (cmb_department.Text == "")
                {
                    MessageBox.Show("من فضلك قم بااختيار التخصص");
                    return;
                   
                }
              
                else
                {
                    E.AddEmployee(txt_name.Text, Convert.ToDecimal(Txt_Salary.Text), dateTimePicker2.Value,
                        txt_NationalID.Text, txt_phone.Text, txt_address.Text, dateTimePicker1.Value,Convert.ToInt32(cmb_department.SelectedValue));
                    MessageBox.Show("تم تسجيل الموظف بنجاح");
                    clears();
                    dataGridView1.DataSource = E.SelectEmployee();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_address.Text == "")
                {
                    MessageBox.Show("من فضلك قم بكتابة العنوان");
                    return;
                }
                if (txt_name.Text == "")
                {
                    MessageBox.Show("من فضلك قم بكتابة اسم الموظف");
                    return;
                }
                if (txt_phone.Text == "")
                {
                    MessageBox.Show("من فضلك قم بكتابة رقم الموبايل");
                    return;
                }
                if (cmb_department.Text == "")
                {
                    MessageBox.Show("من فضلك قم بااختيار التخصص");
                    return;

                }
              
                else
                {
                    E.UpdateEmployee(txt_name.Text, Convert.ToDecimal(Txt_Salary.Text), dateTimePicker2.Value,
                        txt_NationalID.Text, txt_phone.Text, txt_address.Text, dateTimePicker1.Value,Convert.ToInt32(cmb_department.SelectedValue),Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                    MessageBox.Show("تم تعديل بيانات الموظف بنجاح");
                    clears();
              
                    dataGridView1.DataSource = E.SelectEmployee();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count>0)
            {
                btn_new.Show();
                btn_save.Hide();
                btn_update.Enabled = true;
                txt_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                cmb_department.Text= dataGridView1.CurrentRow.Cells[2].Value.ToString();
                dateTimePicker1.Text= dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txt_phone.Text= dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txt_address.Text= dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txt_NationalID.Text= dataGridView1.CurrentRow.Cells[6].Value.ToString();
                Txt_Salary.Text= dataGridView1.CurrentRow.Cells[7].Value.ToString();
                dateTimePicker2.Text= dataGridView1.CurrentRow.Cells[8].Value.ToString();
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            dt.Clear();
            dt = E.SearchEmployes(txt_search.Text);
            dataGridView1.DataSource = dt;
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
    }
}
