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
    public partial class Frm_GenderJob : Form
    {
        Employee E = new Employee();
        public Frm_GenderJob()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_GenderJob_Load(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "")
            {
                MessageBox.Show("");
                return;
            }
            E.AddEmployeeRole(txt_name.Text);
            MessageBox.Show("تم الاضافة");
            txt_name.Clear();
            Frm_Employee.getmain.cmb_department.DataSource = E.SelectEmpRole();
            Frm_Employee.getmain.cmb_department.DisplayMember = "Roles";
            Frm_Employee.getmain.cmb_department.ValueMember = "ID_EmpRole";
         
        }
       
    }
}
