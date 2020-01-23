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
    public partial class Frm_EmpSarf : Form
    {
        Employee E = new Employee();

        DataTable dt = new DataTable();
        public Frm_EmpSarf()
        {
            InitializeComponent();
            //cmb_employeeName.DataSource = E.SelectCompoEmployee();
            //cmb_employeeName.DisplayMember = "Emp_Name";
            //cmb_employeeName.ValueMember = "Emp_ID";




        }

        private void Frm_EmpSarf_Load(object sender, EventArgs e)
        {
            textBox1.Text = Program.salesman;
        }

        private void cmb_employeeName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void calc()
        {
            decimal x;
            x = Convert.ToDecimal(Txt_salary.Text) - Convert.ToDecimal(txt_salf.Text);
            txt_total.Text = x.ToString();
        }
        private void cmb_employeeName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable dt3 = new DataTable();
            if (cmb_employeeName.Text != "")
            {
                if (comboBox1.Text == "مرتبات")
                {
                    Txt_salary.Enabled = false;


                dt.Clear();
                dt = E.SelectCHECKSalaryEmployee(Convert.ToInt32(cmb_employeeName.SelectedValue));
                if (dt.Rows.Count > 0)
                {

                    Txt_salary.Text = dt.Rows[0][1].ToString();
                    txt_salf.Text = dt.Rows[0][2].ToString();
                    txt_total.Text = dt.Rows[0][3].ToString();
                }
                else
                {
                    dt3.Clear();
                    dt3 = E.SelectSalaryEmployee(Convert.ToInt32(cmb_employeeName.SelectedValue));
                    //txt_branches.Text = txt_branches.Text = dt3.Rows[0][1].ToString();
                    Txt_salary.Text = dt3.Rows[0][1].ToString();
                    txt_salf.Text = "0";
                    txt_total.Text = Txt_salary.Text;
                }

            }



            else if (comboBox1.Text == "شيفتات")
            {
               

                DataTable dt5 = new DataTable();
                dt5.Clear();
                dt5 = E.SelectCHECKSalaryEmployee(Convert.ToInt32(cmb_employeeName.SelectedValue));
                if (dt5.Rows.Count > 0)
                {
                    Txt_salary.Text = "0";
                    txt_salf.Text = dt5.Rows[0][2].ToString();
                    calc();

                }
                else
                {

                    //txt_branches.Text = txt_branches.Text = dt3.Rows[0][1].ToString();
                    Txt_salary.Text = "0";
                    txt_salf.Text = "0";
                    txt_total.Text = Txt_salary.Text;

                }
                    calc();

            }
        }
    }

    

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("قم بااختيار نوع الصرف");
                return;

            }
            if (cmb_employeeName.Text=="")
            {
                MessageBox.Show("قم بااختيار اسم الموظف");
                return;

            }
           
          
            if (Txt_salary.Text == "0"|| Txt_salary.Text == "")
            {
                MessageBox.Show("قم بكتابه المرتب الذي تريد صرفة ");
                return;

            }
            dt.Clear();
            dt = E.vildateEmployeeSalary(Convert.ToInt32(cmb_employeeName.SelectedValue), dateTimePicker2.Text);
            if (dt.Rows.Count>0)
            {
                MessageBox.Show("عزيزي المستخدم يرجي العلم بان هذا الموظف تم صرف مرتبة في هذا الشهر لايمكن اتمام العمليه","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
           
                E.AddEmp_Salary(Convert.ToInt32(cmb_employeeName.SelectedValue), Convert.ToDecimal(Txt_salary.Text),
                   Convert.ToDecimal(txt_salf.Text), Convert.ToDecimal(txt_total.Text), dateTimePicker1.Value,
                   txt_note.Text,textBox1.Text,dateTimePicker2.Text);
              
                E.UpdateEMPSalaryMins(Convert.ToInt32(cmb_employeeName.SelectedValue), "true");
                MessageBox.Show("تم الحفظ بنجاح");
              
                txt_note.Clear();
                Txt_salary.Clear();
                txt_salf.Clear();
                txt_total.Clear();


            
        }

        private void Txt_salary_TextChanged(object sender, EventArgs e)
        {
            if (Txt_salary.Text=="")
            {
                Txt_salary.Text = "0";
            }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox1.Text== "مرتبات")
            {

                cmb_employeeName.DataSource = E.selectEmployeeGenderSalaryMonthe();
                cmb_employeeName.DisplayMember = "Emp_Name";
                cmb_employeeName.ValueMember = "Emp_ID";

            }
            else if (comboBox1.Text == "شيفتات")
            {
                Txt_salary.Text = "0";
                Txt_salary.Enabled = true;
                txt_total.Text = "0";
                txt_salf.Text = "0";

                cmb_employeeName.DataSource = E.selectEmployeeGenderSalaryShift();
                    cmb_employeeName.DisplayMember = "Emp_Name";
                    cmb_employeeName.ValueMember = "Emp_ID";

               
            }


        }

        private void Txt_salary_KeyUp(object sender, KeyEventArgs e)
        {
            calc();
        }

        private void Txt_salary_Leave(object sender, EventArgs e)
        {
            if (Txt_salary.Text=="")
            {
                Txt_salary.Text = "0";
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}
