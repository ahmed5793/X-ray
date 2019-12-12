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
        //Frm_Main Frm = new Frm_Main();
        Employee E = new Employee();
        Users U = new Users();
        Permession p = new Permession();
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
                        Frm_Main.getmain.Add_Branche.Enabled = true;
                    }
                    else if (check_AddBranch.Checked == false)
                    {
                        Add_Branch = 0;
                        Frm_Main.getmain.Add_Branche.Enabled = false;
                    }
                    ////////////////////
                    if (check_USerVaildate.Checked==true)
                    {
                        Validate_User = 1;
                        Frm_Main.getmain.Validate_Users.Enabled = true;
                    }
                    else if (check_USerVaildate.Checked == false)
                    {
                        Validate_User = 0;
                        Frm_Main.getmain.Validate_Users.Enabled = false;
                    }
                    /////////
                    if (Check_Add_CategoryXray.Checked == true)
                    {
                        Add_CategoryXray = 1;
                        Frm_Main.getmain.Category_XRay.Enabled = true;
                    }
                    else if (Check_Add_CategoryXray.Checked == false)
                    {
                        Add_CategoryXray = 0;
                        Frm_Main.getmain.Category_XRay.Enabled = false;
                    }
                    ////////
                    if (Check_Add_Xray.Checked == true)
                    {
                        Add_Xrays = 1;
                        Frm_Main.getmain.Add_XRays.Enabled = true;
                    }
                  else if (Check_Add_Xray.Checked == false)
                  {
                        Add_Xrays = 0;
                        Frm_Main.getmain.Add_XRays.Enabled = false;
                  }

                    p.Update_UserBAsicInformation(textBox1.Text, Add_Branch, Validate_User, Add_CategoryXray, Add_Xrays);
                    MessageBox.Show(" تم حفظ الصلاحيات للمستخدم");

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void cmb_Users1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
            DataTable dt10 = new DataTable();
            try
            {
                dt10.Clear();
                dt10 = U.Select_UserName(Convert.ToInt32(cmb_Users1.SelectedValue));
                textBox1.Text = dt10.Rows[0][0].ToString();
                dt2.Clear();
                dt2 = p.Select_UserBAsicInformation(textBox1.Text);
                if (dt2.Rows.Count >= 1)
                {
                    if (Convert.ToInt32(dt2.Rows[0][0]) == 0)
                    {
                        check_AddBranch.Checked = false;
                        Frm_Main.getmain.Add_Branche.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][0]) == 1)
                    {
                        check_AddBranch.Checked = true;
                        Frm_Main.getmain.Add_Branche.Enabled = true;
                    }
                    ///////
                    if (Convert.ToInt32(dt2.Rows[0][1]) == 0)
                    {
                        check_USerVaildate.Checked = false;
                        Frm_Main.getmain.Validate_Users.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][1]) == 1)
                    {
                        check_USerVaildate.Checked = true;
                        Frm_Main.getmain.Validate_Users.Enabled = true;
                    }
                    ///////
                    if (Convert.ToInt32(dt2.Rows[0][2]) == 0)
                    {
                        Check_Add_CategoryXray.Checked = false;
                        Frm_Main.getmain.Category_XRay.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][2]) == 1)
                    {
                        Check_Add_CategoryXray.Checked = true;
                        Frm_Main.getmain.Category_XRay.Enabled = true;
                    }
                    /////////
                    if (Convert.ToInt32(dt2.Rows[0][3]) == 0)
                    {
                        Check_Add_Xray.Checked = false;
                        Frm_Main.getmain.Add_XRays.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][3]) == 1)
                    {
                        Check_Add_Xray.Checked = true;
                        Frm_Main.getmain.Add_XRays.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dt10.Dispose();
            }
        }

        private void Btn_save2_Click(object sender, EventArgs e)
        {

        }

        private void Doctor_Centers_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void check_ٌReportDoctorOfCenter_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
