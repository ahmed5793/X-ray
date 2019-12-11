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
    public partial class Validate_Users : Form
    {
        Frm_Main Frm = new Frm_Main();
        Employee E = new Employee();
        public Validate_Users()
        {
            InitializeComponent();
            cmb_Users1.DataSource = E.SelectCompoEmployee();
            cmb_Users1.DisplayMember = "Emp_Name";
            cmb_Users1.ValueMember = "Emp_ID";
            ///////
            Cmb_user2.DataSource = E.SelectCompoEmployee();
            Cmb_user2.DisplayMember = "Emp_Name";
            Cmb_user2.ValueMember = "Emp_ID";
            ///////
            cmb_user3.DataSource = E.SelectCompoEmployee();
            cmb_user3.DisplayMember = "Emp_Name";
            cmb_user3.ValueMember = "Emp_ID";
            //////
            cmb_user3.DataSource = E.SelectCompoEmployee();
            cmb_user3.DisplayMember = "Emp_Name";
            cmb_user3.ValueMember = "Emp_ID";
            //////
            Cmb_User4.DataSource = E.SelectCompoEmployee();
            Cmb_User4.DisplayMember = "Emp_Name";
            Cmb_User4.ValueMember = "Emp_ID";
            /////
            cmb_user5.DataSource = E.SelectCompoEmployee();
            cmb_user5.DisplayMember = "Emp_Name";
            cmb_user5.ValueMember = "Emp_ID";

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void check_RepoDoctor_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void check_AddSupplier_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_Users1.Text == "")
                {
                    MessageBox.Show("لا بد من تحديد إسم المستخدم");
                    return;
                }
                else
                {
                    int Add_Branch =0, Validate_User =0, Add_CategoryXray =0, Add_Xrays = 0;
                    if (check_AddBranch.Checked==true)
                    {
                        Add_Branch = 1;
                        Frm.Add_Branche.Enabled = true;
                    }
                    if (check_AddBranch.Checked == false)
                    {
                        Add_Branch = 0;
                        Frm.Add_Branche.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
