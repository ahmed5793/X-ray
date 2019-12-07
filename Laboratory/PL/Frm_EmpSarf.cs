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
            cmb_employeeName.DataSource = E.SelectCompoEmployee();
            cmb_employeeName.DisplayMember = "Emp_Name";
            cmb_employeeName.ValueMember = "Emp_ID";

           


        }

        private void Frm_EmpSarf_Load(object sender, EventArgs e)
        {
            
        }

        private void cmb_employeeName_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cmb_employeeName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable dt3 = new DataTable();
            if (cmb_employeeName.Text != "")
            {
                dt.Clear();
                dt = E.SelectCHECKSalaryEmployee(Convert.ToInt32(cmb_employeeName.SelectedValue));
                if (dt.Rows.Count > 0)
                {
                    txt_branches.Text = dt.Rows[0][1].ToString();
                    Txt_salary.Text = dt.Rows[0][2].ToString();
                    txt_salf.Text = dt.Rows[0][3].ToString();
                    txt_total.Text = dt.Rows[0][4].ToString();
                }
                else
                {
                    dt3.Clear();
                    dt3 = E.SelectSalaryEmployee(Convert.ToInt32(cmb_employeeName.SelectedValue));
                    txt_branches.Text = txt_branches.Text = dt3.Rows[0][1].ToString();
                    Txt_salary.Text = dt3.Rows[0][2].ToString();
                    txt_salf.Text = "0";
                    txt_total.Text = Txt_salary.Text;
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (cmb_employeeName.Text=="")
            {
                MessageBox.Show("قم بااختيار اسم الموظف");
                return;

            }
           
          
            if (Txt_salary.Text == "")
            {
                MessageBox.Show("قم بااختيار اسم الموظف ");
                return;

            }
          
           
                E.AddEmp_Salary(Convert.ToInt32(cmb_employeeName.SelectedValue), Convert.ToDecimal(Txt_salary.Text),
                   Convert.ToDecimal(txt_salf.Text), Convert.ToDecimal(txt_total.Text), dateTimePicker1.Value,
                   txt_note.Text);
              
                E.UpdateEMPSalaryMins(Convert.ToInt32(cmb_employeeName.SelectedValue), "true");
                MessageBox.Show("تم الحفظ بنجاح");
                txt_branches.Clear();
                txt_note.Clear();
                Txt_salary.Clear();
                txt_salf.Clear();
                txt_total.Clear();


            
        }

        private void Txt_salary_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
