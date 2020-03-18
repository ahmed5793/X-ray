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

            cmb_User6.DataSource = E.SelectCompoEmployee();
            cmb_User6.DisplayMember = "Emp_Name";
            cmb_User6.ValueMember = "Emp_ID";

            cmb_User7.DataSource = E.SelectCompoEmployee();
            cmb_User7.DisplayMember = "Emp_Name";
            cmb_User7.ValueMember = "Emp_ID";

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
        }

        private void cmb_Users1_SelectionChangeCommitted(object sender, EventArgs e)
        {
          
            DataTable dt10 = new DataTable();
            try
            {
                dt10.Clear();
                dt10 = U.Select_UserName(Convert.ToInt32(cmb_Users1.SelectedValue));
                txt_Baisc.Text = dt10.Rows[0][0].ToString();

                DataTable dt2 = new DataTable();
                dt2.Clear();
                dt2 = p.Select_UserBAsicInformation(txt_Baisc.Text);
                if (dt2.Rows.Count >= 1)
                {
                    if (Convert.ToInt32(dt2.Rows[0][0]) == 0)
                    {
                        check_AddEmployee.Checked = false;
                        //Main.getmain.add_employee.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][0]) == 1)
                    {
                        check_AddEmployee.Checked = true;
                        //Main.getmain.add_employee.Enabled = true;
                    }
                    ///////
                    if (Convert.ToInt32(dt2.Rows[0][1]) == 0)
                    {
                        check_AddEmployeeBranch.Checked = false;
                        //Main.getmain.add_employeeBranche.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][1]) == 1)
                    {
                        check_AddEmployeeBranch.Checked = true;
                        //Main.getmain.add_employeeBranche.Enabled = true;
                    }
                    ////////
                    if (Convert.ToInt32(dt2.Rows[0][2]) == 0)
                    {
                        check_AddBranch.Checked = false;
                        //Main.getmain.add_branch.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][2]) == 1)
                    {
                        check_AddBranch.Checked = true;
                        //Main.getmain.add_branch.Enabled = true;
                    }

                    ///////
                    if (Convert.ToInt32(dt2.Rows[0][3]) == 0)
                    {
                        Check_Add_CategoryXray.Checked = false;
                        //Main.getmain.Xray_Category.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][3]) == 1)
                    {
                        Check_Add_CategoryXray.Checked = true;
                        //Main.getmain.Xray_Category.Enabled = true;
                    }
                    /////////
                    if (Convert.ToInt32(dt2.Rows[0][4]) == 0)
                    {
                        Check_Add_Xray.Checked = false;
                        //Main.getmain.XrayName.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][4]) == 1)
                    {
                        Check_Add_Xray.Checked = true;
                        //Main.getmain.XrayName.Enabled = true;
                    }
                    ///////
                    if (Convert.ToInt32(dt2.Rows[0][5]) == 0)
                    {
                        check_DownloadFinger.Checked = false;
                        //Main.getmain.Download_finger.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][5]) == 1)
                    {
                        check_DownloadFinger.Checked = true;
                        //Main.getmain.Download_finger.Enabled = true;
                    }
                    ///////
                    if (Convert.ToInt32(dt2.Rows[0][6]) == 0)
                    {
                        check_ReportFinger.Checked = false;
                        //Main.getmain.report_finger.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][6]) == 1)
                    {
                        check_ReportFinger.Checked = true;
                        //Main.getmain.report_finger.Enabled = true;
                    }
                    //////
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

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void Validate_Users_Load(object sender, EventArgs e)
        {
            txt_Account.Hide();
            txt_Baisc.Hide();
            txt_Company.Hide();
            txt_Employee.Hide();
            txt_Store.Hide();
            txt_Tickets.Hide();
            txt_User.Hide();
        }

        private void Cmb_user2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
            DataTable dt10 = new DataTable();
            try
            {
                dt10.Clear();
                dt10 = U.Select_UserName(Convert.ToInt32(Cmb_user2.SelectedValue));
                txt_Employee.Text = dt10.Rows[0][0].ToString();

         

                dt2.Clear();
                dt2 = p.Select_UserEmployee(txt_Employee.Text);
                if (dt2.Rows.Count >= 1)
                {
                    if (Convert.ToInt32(dt2.Rows[0][0]) == 0)
                    {
                        Check_Add_ShiftEmployee.Checked = false;
                        //Main.getmain.add_shiftEmployee.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][0]) == 1)
                    {
                        Check_Add_ShiftEmployee.Checked = true;
                        //Main.getmain.add_shiftEmployee.Enabled = true;
                    }
                    ///////
                    if (Convert.ToInt32(dt2.Rows[0][1]) == 0)
                    {
                        Check_Discount.Checked = false;
                        //Main.getmain.discountEmployee.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][1]) == 1)
                    {
                        Check_Discount.Checked = true;
                        //Main.getmain.discountEmployee.Enabled = true;
                    }
                    ////////
                    if (Convert.ToInt32(dt2.Rows[0][2]) == 0)
                    {
                        Check_Salf.Checked = false;
                        //Main.getmain.add_salfEmployee.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][2]) == 1)
                    {
                        Check_Salf.Checked = true;
                        //Main.getmain.add_salfEmployee.Enabled = true;
                    }

                    ///////
                
                    /////////
                    if (Convert.ToInt32(dt2.Rows[0][3]) == 0)
                    {
                        Check_Sarf_Mortbat.Checked = false;
                        //Main.getmain.sarf_SalaryEmployee.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][3]) == 1)
                    {
                        Check_Sarf_Mortbat.Checked = true;
                        //Main.getmain.sarf_SalaryEmployee.Enabled = true;
                    }
                    ///////
                    if (Convert.ToInt32(dt2.Rows[0][4]) == 0)
                    {
                        check_ReportEmployee.Checked = false;
                        //Main.getmain.Report_Employee.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][4]) == 1)
                    {
                        check_ReportEmployee.Checked = true;
                        //Main.getmain.Report_Employee.Enabled = true;
                    }
                    ///////
                    if (Convert.ToInt32(dt2.Rows[0][5]) == 0)
                    {
                        Check_AddDoctor_Centers.Checked = false;
                        //Main.getmain.add_DoctortCenter.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][5]) == 1)
                    {
                        Check_AddDoctor_Centers.Checked = true;
                        //Main.getmain.add_DoctortCenter.Enabled = true;
                    }
                    //////
                    if (Convert.ToInt32(dt2.Rows[0][6]) == 0)
                    {
                        check_ReportDoctorOfCenter.Checked = false;
                        //Main.getmain.Report_DoctorCenter.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][6]) == 1)
                    {
                        check_ReportDoctorOfCenter.Checked = true;
                        //Main.getmain.Report_DoctorCenter.Enabled = true;
                    }
                    ///
                    if (Convert.ToInt32(dt2.Rows[0][7]) == 0)
                    {
                        check_AddTechnical.Checked = false;
                        //Main.getmain.add_Techincal.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][7]) == 1)
                    {
                        check_AddTechnical.Checked = true;
                        //Main.getmain.add_Techincal.Enabled = true;
                    }
                    ///
                    if (Convert.ToInt32(dt2.Rows[0][8]) == 0)
                    {
                        Check_AddShiftTechincal.Checked = false;
                        //Main.getmain.add_shiftTechincal.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][8]) == 1)
                    {
                        Check_AddShiftTechincal.Checked = true;
                        //Main.getmain.add_shiftTechincal.Enabled = true;
                    }
                         if (Convert.ToInt32(dt2.Rows[0][9]) == 0)
                    {
                        check_ReportTechnical.Checked = false;
                        //Main.getmain.report_Techincal.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][9]) == 1)
                    {
                        check_ReportTechnical.Checked = true;
                        //Main.getmain.report_Techincal.Enabled = true;
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

        private void btn_save3_Click(object sender, EventArgs e)
        {
          
        }

        private void cmb_user3_SelectionChangeCommitted(object sender, EventArgs e)
        {

            DataTable dt2 = new DataTable();
            DataTable dt10 = new DataTable();
            try
            {
                dt10.Clear();
                dt10 = U.Select_UserName(Convert.ToInt32(cmb_user3.SelectedValue));
                txt_Company.Text = dt10.Rows[0][0].ToString();
                dt2.Clear();
                dt2 = p.SelectUserCompany(txt_Company.Text);
                if (dt2.Rows.Count >= 1)
                {
                    if (Convert.ToInt32(dt2.Rows[0][0]) == 0)
                    {
                        check_AddCompany.Checked = false;
                        //Main.getmain.add_company.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][0]) == 1)
                    {
                        check_AddCompany.Checked = true;
                        //Main.getmain.add_company.Enabled = true;
                    }
                    ///////
                    if (Convert.ToInt32(dt2.Rows[0][1]) == 0)
                    {
                        check_AddItemCompany.Checked = false;
                        //Main.getmain.add_XrayCompany.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][1]) == 1)
                    {
                        check_AddItemCompany.Checked = true;
                        //Main.getmain.add_XrayCompany.Enabled = true;
                    }
                    ////////
                    if (Convert.ToInt32(dt2.Rows[0][2]) == 0)
                    {
                        check_DebitCompany.Checked = false;
                        //Main.getmain.Depit_Company.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][2]) == 1)
                    {
                        check_DebitCompany.Checked = true;
                        //Main.getmain.Depit_Company.Enabled = true;
                    }

                    ///////
                    if (Convert.ToInt32(dt2.Rows[0][3]) == 0)
                    {
                        check_PayCompany.Checked = false;
                        //Main.getmain.pay_Company.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][3]) == 1)
                    {
                        check_PayCompany.Checked = true;
                        //Main.getmain.pay_Company.Enabled = true;
                    }
                    /////////
                    if (Convert.ToInt32(dt2.Rows[0][4]) == 0)
                    {
                        check_REportCompany.Checked = false;
                        //Main.getmain.Report_Company.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][4]) == 1)
                    {
                        check_REportCompany.Checked = true;
                        //Main.getmain.Report_Company.Enabled = true;
                    }
                    ///////
                    if (Convert.ToInt32(dt2.Rows[0][5]) == 0)
                    {
                        Check_AddDoctor.Checked = false;
                        //Main.getmain.add_doctorOut.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][5]) == 1)
                    {
                        Check_AddDoctor.Checked = true;
                        //Main.getmain.add_doctorOut.Enabled = true;
                    }
                    ///////
                    if (Convert.ToInt32(dt2.Rows[0][6]) == 0)
                    {
                        check_RepoDoctorOut.Checked = false;
                        //Main.getmain.report_DoctorOut.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][6]) == 1)
                    {
                        check_RepoDoctorOut.Checked = true;
                        //Main.getmain.report_DoctorOut.Enabled = true;
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

        private void btn_save4_Click(object sender, EventArgs e)
        {

            try
            {
                if (Cmb_User4.Text == "")
                {
                    MessageBox.Show("لا بد من تحديد إسم المستخدم");
                    return;
                }
                else
                {
                    int AddMasrof = 0, ReportMasrof = 0, AddStock = 0, InsertStock = 0, PullStock = 0,
                        TransfierStock = 0, ReportStock = 0, AddInstalment = 0, reportInstalment = 0;

                    if (check_AddMasrof.Checked == true)
                    {
                        AddMasrof = 1;
                        //Main.getmain.add_masrof.Enabled = true;
                    }
                    else if (check_AddMasrof.Checked == false)
                    {
                        AddMasrof = 0;
                        //Main.getmain.add_masrof.Enabled = false;
                    }

                    if (check_ReportMarofat.Checked == true)
                    {
                        ReportMasrof = 1;
                        //Main.getmain.report_masrof.Enabled = true;
                    }
                    else if (check_ReportMarofat.Checked == false)
                    {
                        ReportMasrof = 0;
                        //Main.getmain.report_masrof.Enabled = false;
                    }
                    if (check_AddStore.Checked == true)
                    {
                        AddStock = 1;
                        //Main.getmain.add_store.Enabled = true;
                    }
                    else if (check_AddStore.Checked == false)
                    {
                        AddStock = 0;
                        //Main.getmain.add_store.Enabled = false;
                    }

                    if (check_InsertIntoStock.Checked == true)
                    {
                        InsertStock = 1;
                        //Main.getmain.insert_stock.Enabled = true;
                    }
                    else if (check_InsertIntoStock.Checked == false)
                    {
                        InsertStock = 0;
                        //Main.getmain.insert_stock.Enabled = false;
                    }
                    ////////
                    if (check_PullStock.Checked == true)
                    {
                        PullStock = 1;
                        //Main.getmain.pull_stock.Enabled = true;
                    }
                    else if (check_PullStock.Checked == false)
                    {
                        PullStock= 0;
                        //Main.getmain.pull_stock.Enabled = false;
                    }



                    if (check_TranfairStockToStock.Checked == true)
                    {
                        TransfierStock = 1;
                        //Main.getmain.trnasferStore.Enabled = true;
                    }
                    else if (check_TranfairStockToStock.Checked == false)
                    {
                        TransfierStock = 0;
                        //Main.getmain.trnasferStore.Enabled = false;

                    }
                    if (check_Reportstock.Checked == true)
                    {
                        ReportStock = 1;
                        //Main.getmain.report_stock.Enabled = true;
                    }
                    else if (check_Reportstock.Checked == false)
                    {
                        ReportStock = 0;
                        //Main.getmain.report_stock.Enabled = false;
                    }

                    if (check_AddInstalment.Checked == true)
                    {
                        AddInstalment = 1;
                        //Main.getmain.add_installment.Enabled = true;
                    }
                    else if (check_AddInstalment.Checked == false)
                    {
                        AddInstalment = 0;
                        //Main.getmain.add_installment.Enabled = false;
                    }
                    if (check_ReportInstalment.Checked == true)
                    {
                        reportInstalment = 1;
                        //Main.getmain.report_installment.Enabled = true;
                    }
                    else if (check_ReportInstalment.Checked == false)
                    {
                        reportInstalment = 0;
                        //Main.getmain.report_installment.Enabled = false;
                    }
                


                    p.UpdateUserAccount(txt_Baisc.Text, AddMasrof, ReportMasrof, AddStock, InsertStock, PullStock,
                        TransfierStock, ReportStock, AddInstalment, reportInstalment);


               
                    MessageBox.Show(" تم حفظ الصلاحيات للمستخدم");

                        
                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Cmb_User4_SelectionChangeCommitted(object sender, EventArgs e)
        {

            DataTable dt2 = new DataTable();
            DataTable dt10 = new DataTable();
            try
            {
                dt10.Clear();
                dt10 = U.Select_UserName(Convert.ToInt32(Cmb_User4.SelectedValue));
                txt_Account.Text = dt10.Rows[0][0].ToString();
                dt2.Clear();
                dt2 = p.SelectUserAccount(txt_Account.Text);
                if (dt2.Rows.Count >= 1)
                {
                    if (Convert.ToInt32(dt2.Rows[0][0]) == 0)
                    {
                        check_AddMasrof.Checked = false;
                        //Main.getmain.add_masrof.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][0]) == 1)
                    {
                        check_AddMasrof.Checked = true;
                        //Main.getmain.add_masrof.Enabled = true;
                    }
                    ///////
                    if (Convert.ToInt32(dt2.Rows[0][1]) == 0)
                    {
                        check_ReportMarofat.Checked = false;
                        //Main.getmain.report_masrof.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][1]) == 1)
                    {
                        check_ReportMarofat.Checked = true;
                        //Main.getmain.report_masrof.Enabled = true;
                    }
                    ////////
                    if (Convert.ToInt32(dt2.Rows[0][2]) == 0)
                    {
                        check_AddStock.Checked = false;
                        //Main.getmain.add_stock.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][2]) == 1)
                    {
                        check_AddStock.Checked = true;
                        //Main.getmain.add_stock.Enabled = true;
                    }

                    ///////
                    if (Convert.ToInt32(dt2.Rows[0][3]) == 0)
                    {
                        check_PullStock.Checked = false;
                        //Main.getmain.pull_stock.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][3]) == 1)
                    {
                        check_PullStock.Checked = true;
                        //Main.getmain.pull_stock.Enabled = true;
                    }
                    /////////
                    if (Convert.ToInt32(dt2.Rows[0][4]) == 0)
                    {
                        check_InsertIntoStock.Checked = false;
                        //Main.getmain.insert_stock.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][4]) == 1)
                    {
                        check_InsertIntoStock.Checked = true;
                        //Main.getmain.insert_stock.Enabled = true;
                    }
                    ///////
                    if (Convert.ToInt32(dt2.Rows[0][5]) == 0)
                    {
                        check_TranfairStockToStock.Checked = false;
                        //Main.getmain.transfer_stock.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][5]) == 1)
                    {
                        check_TranfairStockToStock.Checked = true;
                        //Main.getmain.transfer_stock.Enabled = true;
                    }
                    ///////
                    if (Convert.ToInt32(dt2.Rows[0][6]) == 0)
                    {
                        check_Reportstock.Checked = false;
                        //Main.getmain.report_stock.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][6]) == 1)
                    {
                        check_Reportstock.Checked = true;
                        //Main.getmain.report_stock.Enabled = true;
                    }

                    if (Convert.ToInt32(dt2.Rows[0][7]) == 0)
                    {
                        check_AddInstalment.Checked = false;
                        //Main.getmain.add_installment.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][7]) == 1)
                    {
                        check_AddInstalment.Checked = true;
                        //Main.getmain.add_installment.Enabled = true;
                    }
                    if (Convert.ToInt32(dt2.Rows[0][8]) == 0)
                    {
                        check_ReportInstalment.Checked = false;
                        //Main.getmain.report_installment.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][8]) == 1)
                    {
                        check_ReportInstalment.Checked = true;
                        //Main.getmain.report_installment.Enabled = true;
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

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                if (cmb_user5.Text == "")
                {
                    MessageBox.Show("لا بد من تحديد إسم المستخدم");
                    return;
                }
                else
                {
                    int AddStore = 0, AddProudect = 0, AddProudectStore = 0, items_consumption = 0, TransferStore = 0, reportProudect=0,
                        AddSuppliers = 0, PaySuppliers = 0, DepitSuppliers = 0, ReportSupplier = 0,
                        AddInvoicePurchise = 0,returnInvlicePurchise=0,ReportPurchise=0;

                    if (check_AddStore.Checked == true)
                    {
                        AddStore = 1;
                        //Main.getmain.add_store.Enabled = true;
                    }
                    else if (check_AddStore.Checked == false)
                    {
                        AddStore = 0;
                        //Main.getmain.add_store.Enabled = false;
                    }

                    if (check_AddProudect.Checked == true)
                    {
                        AddProudect = 1;
                        //Main.getmain.add_items.Enabled = true;
                    }
                    else if (check_AddProudect.Checked == false)
                    {
                        AddProudect = 0;
                        //Main.getmain.add_items.Enabled = false;
                    }
                    if (check_AddStoreProduct.Checked == true)
                    {
                        AddProudectStore = 1;
                        //Main.getmain.add_ItemStore.Enabled = true;
                    }
                    else if (check_AddStoreProduct.Checked == false)
                    {
                        AddProudectStore = 0;
                        //Main.getmain.add_ItemStore.Enabled = false;
                    }

                    if (check_Order.Checked == true)
                    {
                        items_consumption = 1;
                        //Main.getmain.items_consumption.Enabled = true;
                    }
                    else if (check_Order.Checked == false)
                    {
                        items_consumption = 0;
                        //Main.getmain.items_consumption.Enabled = false;
                    }
                    ////////
                    if (check_TransfairProduct.Checked == true)
                    {
                        TransferStore = 1;
                        //Main.getmain.trnasferStore.Enabled = true;
                    }
                    else if (check_TransfairProduct.Checked == false)
                    {
                        TransferStore = 0;
                        //Main.getmain.trnasferStore.Enabled = false;
                    }



                    if (check_ReportProudect.Checked == true)
                    {
                        reportProudect = 1;
                        //Main.getmain.report_items.Enabled = true;
                    }
                    else if (check_ReportProudect.Checked == false)
                    {
                        reportProudect = 0;
                        //Main.getmain.report_items.Enabled = false;
                    }


                    if (check_AddSuppliers.Checked == true)
                    {
                        AddSuppliers = 1;
                        //Main.getmain.add_suppliers.Enabled = true;
                    }
                    else if (check_AddSuppliers.Checked == false)
                    {
                        AddSuppliers = 0;
                        //Main.getmain.add_suppliers.Enabled = false;
                    }
                    ///////

                    if (check_PaySupplies.Checked == true)
                    {
                        PaySuppliers = 1;
                        //Main.getmain.pay_suppliers.Enabled = true;
                    }
                    else if (check_PaySupplies.Checked == false)
                    {
                        PaySuppliers = 0;
                        //Main.getmain.pay_suppliers.Enabled = false;
                    }
                    ///////

                    if (check_DepitSuppliuers.Checked == true)
                    {
                        DepitSuppliers = 1;
                        //Main.getmain.Depit_suppliers.Enabled = true;
                    }
                    else if (check_DepitSuppliuers.Checked == false)
                    {
                        DepitSuppliers = 0;
                        //Main.getmain.Depit_suppliers.Enabled = false;
                    }
                    //////

                    if (check_ReportSuppliers.Checked == true)
                    {
                        ReportSupplier = 1;
                        //Main.getmain.report_suppliers.Enabled = true;
                    }
                    else if (check_ReportSuppliers.Checked == false)
                    {
                        ReportSupplier = 0;
                        //Main.getmain.report_suppliers.Enabled = false;
                    }
                    ////
                    if (check_AddPurshase.Checked == true)
                    {
                        AddInvoicePurchise = 1;
                        //Main.getmain.add_invoiceSuppliers.Enabled = true;
                    }
                    else if (check_AddPurshase.Checked == false)
                    {
                        AddInvoicePurchise = 0;
                        //Main.getmain.add_invoiceSuppliers.Enabled = false;
                    }
                    /////
                    if (check_ReurnPurchise.Checked == true)
                    {
                        returnInvlicePurchise = 1;
                        //Main.getmain.return_suppliers.Enabled = true;
                    }
                    else if (check_ReurnPurchise.Checked == false)
                    {
                        returnInvlicePurchise = 0;
                        //Main.getmain.return_suppliers.Enabled = false;
                    }
                    ////
                    if (check_ReportPurshases.Checked == true)
                    {
                        ReportPurchise = 1;
                        //Main.getmain.report_invoicePurchise.Enabled = true;
                    }
                    else if (check_ReportPurshases.Checked == false)
                    {
                        ReportPurchise = 0;
                        //Main.getmain.report_invoicePurchise.Enabled = false;
                    }
                    ///
                    ///
                       

                    ///
                    p.UpdateUser_Store(txt_Baisc.Text, AddStore, AddProudect, AddProudectStore, TransferStore, items_consumption, reportProudect,
                        AddInvoicePurchise, returnInvlicePurchise, ReportPurchise, AddSuppliers, PaySuppliers, DepitSuppliers, ReportPurchise);




                    MessageBox.Show(" تم حفظ الصلاحيات للمستخدم");

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void cmb_user5_SelectionChangeCommitted(object sender, EventArgs e)
        {

            DataTable dt2 = new DataTable();
            DataTable dt10 = new DataTable();
            try
            {
                dt10.Clear();
                dt10 = U.Select_UserName(Convert.ToInt32(cmb_user5.SelectedValue));
                txt_Store.Text = dt10.Rows[0][0].ToString();
                dt2.Clear();
                dt2 = p.selectUser_Store(txt_Store.Text);
                if (dt2.Rows.Count >= 1)
                {
                    if (Convert.ToInt32(dt2.Rows[0][0]) == 0)
                    {
                        check_AddStore.Checked = false;
                        //Main.getmain.add_store.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][0]) == 1)
                    {
                        check_AddStore.Checked = true;
                        //Main.getmain.add_store.Enabled = true;
                    }
                    ///////
                    if (Convert.ToInt32(dt2.Rows[0][1]) == 0)
                    {
                        check_AddProudect.Checked = false;
                        //Main.getmain.add_items.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][1]) == 1)
                    {
                        check_AddProudect.Checked = true;
                        //Main.getmain.add_items.Enabled = true;
                    }
                    ////////
                    if (Convert.ToInt32(dt2.Rows[0][2]) == 0)
                    {
                        check_AddStoreProduct.Checked = false;
                        //Main.getmain.add_ItemStore.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][2]) == 1)
                    {
                        check_AddStoreProduct.Checked = true;
                        //Main.getmain.add_ItemStore.Enabled = true;
                    }

                    ///////
                    if (Convert.ToInt32(dt2.Rows[0][3]) == 0)
                    {
                        check_TransfairProduct.Checked = false;
                        //Main.getmain.trnasferStore.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][3]) == 1)
                    {
                        check_TransfairProduct.Checked = true;
                        //Main.getmain.trnasferStore.Enabled = true;
                    }
                    /////////
                    if (Convert.ToInt32(dt2.Rows[0][4]) == 0)
                    {
                        check_Order.Checked = false;
                        //Main.getmain.items_consumption.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][4]) == 1)
                    {
                        check_Order.Checked = true;
                        //Main.getmain.items_consumption.Enabled = true;
                    }
                    ///////
                    if (Convert.ToInt32(dt2.Rows[0][5]) == 0)
                    {
                        check_ReportProudect.Checked = false;
                        //Main.getmain.report_items.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][5]) == 1)
                    {
                        check_ReportProudect.Checked = true;
                        //Main.getmain.report_items.Enabled = true;
                    }
                    ///////
                    if (Convert.ToInt32(dt2.Rows[0][6]) == 0)
                    {
                        check_AddPurshase.Checked = false;
                        //Main.getmain.add_invoiceSuppliers.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][6]) == 1)
                    {
                        check_AddPurshase.Checked = true;
                        //Main.getmain.add_invoiceSuppliers.Enabled = true;
                    }

                    if (Convert.ToInt32(dt2.Rows[0][7]) == 0)
                    {
                        check_ReurnPurchise.Checked = false;
                        //Main.getmain.return_suppliers.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][7]) == 1)
                    {
                        check_ReurnPurchise.Checked = true;
                        //Main.getmain.return_suppliers.Enabled = true;
                    }
                    if (Convert.ToInt32(dt2.Rows[0][8]) == 0)
                    {
                        check_ReportPurshases.Checked = false;
                        //Main.getmain.report_invoicePurchise.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][8]) == 1)
                    {
                        check_ReportPurshases.Checked = true;
                        //Main.getmain.report_invoicePurchise.Enabled = true;
                    }

                    if (Convert.ToInt32(dt2.Rows[0][9]) == 0)
                    {
                        check_AddSuppliers.Checked = false;
                        //Main.getmain.add_suppliers.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][9]) == 1)
                    {
                        check_AddSuppliers.Checked = true;
                        //Main.getmain.add_suppliers.Enabled = true;
                    }
                    if (Convert.ToInt32(dt2.Rows[0][10]) == 0)
                    {
                        check_PaySupplies.Checked = false;
                        //Main.getmain.pay_suppliers.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][10]) == 1)
                    {
                        check_PaySupplies.Checked = true;
                        //Main.getmain.pay_suppliers.Enabled = true;
                    }
                    if (Convert.ToInt32(dt2.Rows[0][11]) == 0)
                    {
                        check_DepitSuppliuers.Checked = false;
                        //Main.getmain.Depit_suppliers.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][11]) == 1)
                    {
                        check_DepitSuppliuers.Checked = true;
                        //Main.getmain.Depit_suppliers.Enabled = true;
                    }


                    if (Convert.ToInt32(dt2.Rows[0][12]) == 0)
                    {
                        check_ReportSuppliers.Checked = false;
                        //Main.getmain.report_suppliers.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][12]) == 1)
                    {
                        check_ReportSuppliers.Checked = true;
                        //Main.getmain.report_suppliers.Enabled = true;
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

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                if (cmb_User6.Text == "")
                {
                    MessageBox.Show("لا بد من تحديد إسم المستخدم");
                    return;
                }
                else
                {
                    int AddTickets = 0, ManagmentTickets = 0, SearchAllTickets = 0, AddClient = 0, PayClient = 0,
                        PayClientCompay = 0, DepitClient = 0, ReportClient = 0;

                    if (check_AddTickets.Checked == true)
                    {
                        AddTickets = 1;
                        //Main.getmain.add_tickets.Enabled = true;
                        //Main.getmain.accordion_Tickets.Enabled = true;

                    }
                    else if (check_AddTickets.Checked == false)
                    {
                        AddTickets = 0;
                        //Main.getmain.add_tickets.Enabled = false;
                        //Main.getmain.accordion_Tickets.Enabled = false;

                    }

                    if (check_ManagmentTickets.Checked == true)
                    {
                        ManagmentTickets = 1;
                        //Main.getmain.managment_tickets.Enabled = true;
                    }
                    else if (check_ManagmentTickets.Checked == false)
                    {
                        ManagmentTickets = 0;
                        //Main.getmain.managment_tickets.Enabled = false;
                    }
                    if (check_SearchTickets.Checked == true)
                    {
                        SearchAllTickets = 1;
                        //Main.getmain.search_tickets.Enabled = true;
                        //Main.getmain.accordion_SerachTickrets.Enabled = true;

                    }
                    else if (check_SearchTickets.Checked == false)
                    {
                        SearchAllTickets = 0;
                        //Main.getmain.search_tickets.Enabled = false;
                        //Main.getmain.accordion_SerachTickrets.Enabled = false;

                    }

                    if (check_AddClients.Checked == true)
                    {
                        AddClient = 1;
                        //Main.getmain.accordion_AddClient.Enabled = true;
                        //Main.getmain.add_patient.Enabled = true;
                    }
                    else if (check_AddClients.Checked == false)
                    {
                        AddClient = 0;
                        //Main.getmain.accordion_AddClient.Enabled = false;
                        //Main.getmain.add_patient.Enabled = false;
                    }
                    ////////
                    if (check_PayClients.Checked == true)
                    {
                        PayClient = 1;
                        //Main.getmain.pay_patient.Enabled = true;
                        //Main.getmain.accordion_PayClient.Enabled = true;

                    }
                    else if (check_PayClients.Checked == false)
                    {
                        PayClient = 0;
                        //Main.getmain.pay_patient.Enabled = false;
                        //Main.getmain.accordion_PayClient.Enabled = false;
                    }



                    if (check_PayClientsCompany.Checked == true)
                    {
                        PayClientCompay = 1;
                        //Main.getmain.pay_patientCompany.Enabled = true;
                        //Main.getmain.accordion_PayCompany.Enabled = true;

                    }
                    else if (check_PayClientsCompany.Checked == false)
                    {
                        PayClientCompay = 0;
                        //Main.getmain.pay_patientCompany.Enabled = false;
                        //Main.getmain.accordion_PayCompany.Enabled = false;
                    }
                    if (check_DepitClients.Checked == true)
                    {
                        DepitClient = 1;
                        //Main.getmain.depit_client.Enabled = true;
                    }
                    else if (check_DepitClients.Checked == false)
                    {
                        DepitClient = 0;
                        //Main.getmain.depit_client.Enabled = false;
                    }

                    if (check_ReportClients.Checked == true)
                    {
                        ReportClient = 1;
                        //Main.getmain.report_patient.Enabled = true;
                    }
                    else if (check_ReportClients.Checked == false)
                    {
                        ReportClient = 0;
                        //Main.getmain.report_patient.Enabled = false;
                    }



                    p.UpdateUser_Tickets(txt_Baisc.Text, AddTickets, ManagmentTickets, SearchAllTickets, AddClient, PayClient,
                        PayClientCompay, DepitClient, ReportClient);



                    MessageBox.Show(" تم حفظ الصلاحيات للمستخدم");



                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {

            DataTable dt2 = new DataTable();
            DataTable dt10 = new DataTable();
            try
            {
                dt10.Clear();
                dt10 = U.Select_UserName(Convert.ToInt32(cmb_User6.SelectedValue));
                txt_Tickets.Text = dt10.Rows[0][0].ToString();
                dt2.Clear();
                dt2 = p.selecTUserTickets(txt_Tickets.Text);
                if (dt2.Rows.Count >= 1)
                {
                    if (Convert.ToInt32(dt2.Rows[0][0]) == 0)
                    {
                        check_AddTickets.Checked = false;
                        //Main.getmain.add_tickets.Enabled = false;
                        //Main.getmain.accordion_Tickets.Enabled = false;

                    }
                    else if (Convert.ToInt32(dt2.Rows[0][0]) == 1)
                    {
                        check_AddTickets.Checked = true;
                        //Main.getmain.add_tickets.Enabled = true;
                        //Main.getmain.accordion_Tickets.Enabled = true;

                    }
                    ///////
                    if (Convert.ToInt32(dt2.Rows[0][1]) == 0)
                    {
                        check_ManagmentTickets.Checked = false;
                        //Main.getmain.managment_tickets.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][1]) == 1)
                    {
                        check_ManagmentTickets.Checked = true;
                        //Main.getmain.managment_tickets.Enabled = true;
                    }
                    ////////
                    if (Convert.ToInt32(dt2.Rows[0][2]) == 0)
                    {
                        check_SearchTickets.Checked = false;
                        //Main.getmain.search_tickets.Enabled = false;
                        //Main.getmain.accordion_SerachTickrets.Enabled = false;

                    }
                    else if (Convert.ToInt32(dt2.Rows[0][2]) == 1)
                    {
                        check_SearchTickets.Checked = true;
                        //Main.getmain.search_tickets.Enabled = true;
                        //Main.getmain.accordion_SerachTickrets.Enabled = true;

                    }

                    ///////
                    if (Convert.ToInt32(dt2.Rows[0][3]) == 0)
                    {
                        check_AddClients.Checked = false;
                        //Main.getmain.add_patient.Enabled = false;
                        //Main.getmain.accordion_AddClient.Enabled = false;

                    }
                    else if (Convert.ToInt32(dt2.Rows[0][3]) == 1)
                    {
                        check_AddClients.Checked = true;
                        //Main.getmain.add_patient.Enabled = true;
                        //Main.getmain.accordion_AddClient.Enabled = true;

                    }
                    /////////
                    if (Convert.ToInt32(dt2.Rows[0][4]) == 0)
                    {
                        check_PayClients.Checked = false;
                        //Main.getmain.pay_patient.Enabled = false;
                        //Main.getmain.accordion_PayClient.Enabled = false;

                    }
                    else if (Convert.ToInt32(dt2.Rows[0][4]) == 1)
                    {
                        check_PayClients.Checked = true;
                        //Main.getmain.pay_patient.Enabled = true;
                        //Main.getmain.accordion_PayClient.Enabled = true;
                    }
                    ///////
                    if (Convert.ToInt32(dt2.Rows[0][5]) == 0)
                    {
                        check_PayClientsCompany.Checked = false;
                        //Main.getmain.pay_patientCompany.Enabled = false;
                        //Main.getmain.accordion_PayCompany.Enabled = false;

                    }
                    else if (Convert.ToInt32(dt2.Rows[0][5]) == 1)
                    {
                        check_PayClientsCompany.Checked = true;
                        //Main.getmain.pay_patientCompany.Enabled = true;
                        //Main.getmain.accordion_PayCompany.Enabled = true;
                    }
                    ///////
                    if (Convert.ToInt32(dt2.Rows[0][6]) == 0)
                    {
                        check_DepitClients.Checked = false;
                        //Main.getmain.depit_client.Enabled = false;

                    }
                    else if (Convert.ToInt32(dt2.Rows[0][6]) == 1)
                    {
                        check_DepitClients.Checked = true;
                        //Main.getmain.depit_client.Enabled = true;
                    }

                    if (Convert.ToInt32(dt2.Rows[0][7]) == 0)
                    {
                        check_ReportClients.Checked = false;
                        //Main.getmain.report_patient.Enabled = false;

                    }
                    else if (Convert.ToInt32(dt2.Rows[0][7]) == 1)
                    {
                       
                        check_ReportClients.Checked = true;
                        //Main.getmain.report_patient.Enabled = true;
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

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                if (cmb_User7.Text == "")
                {
                    MessageBox.Show("لا بد من تحديد إسم المستخدم");
                    return;
                }
                else
                {
                    int CreateAccount = 0, Permissson = 0;
                    

                    if (check_CreateAccount.Checked == true)
                    {
                        CreateAccount = 1;
                        //Main.getmain.Create_Account.Enabled = true;
                    

                    }
                    else if (check_CreateAccount.Checked == false)
                    {
                        CreateAccount = 0;
                        //Main.getmain.Create_Account.Enabled = false;

                    }

                    if (check_Permission.Checked == true)
                    {
                        Permissson = 1;
                        //Main.getmain.Permisson.Enabled = true;
                    }
                    else if (check_Permission.Checked == false)
                    {
                        Permissson = 0;
                        //Main.getmain.Permisson.Enabled = false;
                    }
                 


                    p.UpdateUser_Permission(txt_Baisc.Text,CreateAccount,Permissson);


            

                    MessageBox.Show(" تم حفظ الصلاحيات للمستخدم");



                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void cmb_User7_SelectionChangeCommitted(object sender, EventArgs e)
        {

            DataTable dt2 = new DataTable();
            DataTable dt10 = new DataTable();
            try
            {
                dt10.Clear();
                dt10 = U.Select_UserName(Convert.ToInt32(cmb_User7.SelectedValue));
                txt_User.Text = dt10.Rows[0][0].ToString();
                dt2.Clear();
                dt2 = p.selectUser_Permission(txt_User.Text);
                if (dt2.Rows.Count >= 1)
                {
                    if (Convert.ToInt32(dt2.Rows[0][0]) == 0)
                    {
                        check_CreateAccount.Checked = false;
                        //Main.getmain.Create_Account.Enabled = false;

                    }
                    else if (Convert.ToInt32(dt2.Rows[0][0]) == 1)
                    {
                        check_CreateAccount.Checked = true;
                        //Main.getmain.Create_Account.Enabled = true;

                    }
                    ///////
                    if (Convert.ToInt32(dt2.Rows[0][1]) == 0)
                    {
                        check_Permission.Checked = false;
                        //Main.getmain.Permisson.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][1]) == 1)
                    {
                        check_Permission.Checked = true;
                        //Main.getmain.Permisson.Enabled = true;
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
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
                    int Add_Branch = 0, Add_Employee = 0, Add_EmployeeBranch = 0, Add_CategoryXray = 0, Add_Xrays = 0, Downloaad_Finger = 0, Report_Finger = 0;
                    if (check_AddBranch.Checked == true)
                    {
                        Add_Branch = 1;
                        //Main.getmain.add_branch.Enabled = true;
                    }
                    else if (check_AddBranch.Checked == false)
                    {
                        Add_Branch = 0;
                        //Main.getmain.add_branch.Enabled = false;
                    }

                    if (check_AddEmployee.Checked == true)
                    {
                        Add_Employee = 1;
                        //Main.getmain.add_employee.Enabled = true;
                    }
                    else if (check_AddEmployee.Checked == false)
                    {
                        Add_Employee = 0;
                        //Main.getmain.add_employee.Enabled = false;
                    }
                    if (check_AddEmployeeBranch.Checked == true)
                    {
                        Add_EmployeeBranch = 1;
                        //Main.getmain.add_employeeBranche.Enabled = true;
                    }
                    else if (check_AddEmployeeBranch.Checked == false)
                    {
                        Add_EmployeeBranch = 0;
                        //Main.getmain.add_employee.Enabled = false;
                    }

                    if (Check_Add_CategoryXray.Checked == true)
                    {
                        Add_CategoryXray = 1;
                        //Main.getmain.Xray_Category.Enabled = true;
                    }
                    else if (Check_Add_CategoryXray.Checked == false)
                    {
                        Add_CategoryXray = 0;
                        //Main.getmain.Xray_Category.Enabled = false;
                    }
                    ////////
                    if (Check_Add_Xray.Checked == true)
                    {
                        Add_Xrays = 1;
                        //Main.getmain.XrayName.Enabled = true;
                    }
                    else if (Check_Add_Xray.Checked == false)
                    {
                        Add_Xrays = 0;
                        //Main.getmain.XrayName.Enabled = false;
                    }



                    if (check_DownloadFinger.Checked == true)
                    {
                        Downloaad_Finger = 1;
                        //Main.getmain.Download_finger.Enabled = true;
                    }
                    else if (check_DownloadFinger.Checked == false)
                    {
                        Downloaad_Finger = 0;
                        //Main.getmain.Download_finger.Enabled = false;
                    }


                    if (check_ReportFinger.Checked == true)
                    {
                        Report_Finger = 1;
                        //Main.getmain.report_finger.Enabled = true;
                    }
                    else if (check_ReportFinger.Checked == false)
                    {
                        Report_Finger = 0;
                        //Main.getmain.report_finger.Enabled = false;
                    }
                    p.Update_UserBAsicInformation(txt_Baisc.Text, Add_Employee, Add_EmployeeBranch, Add_Branch, Add_CategoryXray, Add_Xrays, Downloaad_Finger, Report_Finger);



                    MessageBox.Show(" تم حفظ الصلاحيات للمستخدم");

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cmb_user2.Text == "")
                {
                    MessageBox.Show("لا بد من تحديد إسم المستخدم");
                    return;
                }
                else
                {
                    int DiscountEmployee = 0, employeeSalary = 0, AddShiftEmployee = 0, AddSalfEmployee = 0, ReportEmployee = 0,
                        AddDOCOTOTCenter = 0, ReportDoctorCenter = 0, addTechincal = 0, AddShiftTecincal = 0, ReportTechincal = 0;
                    if (Check_Discount.Checked == true)
                    {
                        DiscountEmployee = 1;
                        //Main.getmain.discountEmployee.Enabled = true;
                    }
                    else if (Check_Discount.Checked == false)
                    {
                        DiscountEmployee = 0;
                        //Main.getmain.discountEmployee.Enabled = false;
                    }

                    if (Check_Sarf_Mortbat.Checked == true)
                    {
                        employeeSalary = 1;
                        //Main.getmain.sarf_SalaryEmployee.Enabled = true;
                    }
                    else if (Check_Sarf_Mortbat.Checked == false)
                    {
                        employeeSalary = 0;
                        //Main.getmain.sarf_SalaryEmployee.Enabled = false;
                    }
                    if (Check_Add_ShiftEmployee.Checked == true)
                    {
                        AddShiftEmployee = 1;
                        //Main.getmain.add_shiftEmployee.Enabled = true;
                    }
                    else if (Check_Add_ShiftEmployee.Checked == false)
                    {
                        AddShiftEmployee = 0;
                        //Main.getmain.add_shiftEmployee.Enabled = false;
                    }

                    if (Check_Salf.Checked == true)
                    {
                        AddSalfEmployee = 1;
                        //Main.getmain.add_salfEmployee.Enabled = true;
                    }
                    else if (Check_Salf.Checked == false)
                    {
                        AddSalfEmployee = 0;
                        //Main.getmain.add_salfEmployee.Enabled = false;
                    }
                    ////////
                    if (check_ReportEmployee.Checked == true)
                    {
                        ReportEmployee = 1;
                        //Main.getmain.Report_Employee.Enabled = true;
                    }
                    else if (check_ReportEmployee.Checked == false)
                    {
                        ReportEmployee = 0;
                        //Main.getmain.Report_Employee.Enabled = false;
                    }



                    if (Check_AddDoctor_Centers.Checked == true)
                    {
                        AddDOCOTOTCenter = 1;
                        //Main.getmain.add_DoctortCenter.Enabled = true;
                    }
                    else if (Check_AddDoctor_Centers.Checked == false)
                    {
                        AddDOCOTOTCenter = 0;
                        //Main.getmain.add_DoctortCenter.Enabled = false;
                    }


                    if (check_ReportDoctorOfCenter.Checked == true)
                    {
                        ReportDoctorCenter = 1;
                        //Main.getmain.Report_DoctorCenter.Enabled = true;
                    }
                    else if (check_ReportDoctorOfCenter.Checked == false)
                    {
                        ReportDoctorCenter = 0;
                        //Main.getmain.Report_DoctorCenter.Enabled = false;
                    }
                    ///////

                    if (check_ReportTechnical.Checked == true)
                    {
                        ReportTechincal = 1;
                        //Main.getmain.report_Techincal.Enabled = true;
                    }
                    else if (check_ReportTechnical.Checked == false)
                    {
                        ReportTechincal = 0;
                        //Main.getmain.report_Techincal.Enabled = false;
                    }
                    ///////

                    if (Check_AddShiftTechincal.Checked == true)
                    {
                        AddShiftTecincal = 1;
                        //Main.getmain.add_shiftTechincal.Enabled = true;
                    }
                    else if (Check_AddShiftTechincal.Checked == false)
                    {
                        AddShiftTecincal = 0;
                        //Main.getmain.add_shiftTechincal.Enabled = false;
                    }
                    //////

                    if (check_AddTechnical.Checked == true)
                    {
                        addTechincal = 1;
                        //Main.getmain.add_Techincal.Enabled = true;
                    }
                    else if (check_AddTechnical.Checked == false)
                    {
                        addTechincal = 0;
                        //Main.getmain.add_Techincal.Enabled = false;
                    }
                    p.Update_UserEmployee(txt_Baisc.Text, AddShiftEmployee, DiscountEmployee, AddSalfEmployee, employeeSalary, ReportEmployee,
                        AddDOCOTOTCenter, ReportDoctorCenter, addTechincal, AddShiftTecincal, ReportTechincal);
                    MessageBox.Show(" تم حفظ الصلاحيات للمستخدم");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_user3.Text == "")
                {
                    MessageBox.Show("لا بد من تحديد إسم المستخدم");
                    return;
                }
                else
                {
                    int AddCompany = 0, AddItemCompany = 0, payCompany = 0, DepitCompany = 0, ReportCompany = 0,
                        AddDOCOTOTOut = 0, ReportDoctorOut = 0;
                    if (check_AddCompany.Checked == true)
                    {
                        AddCompany = 1;
                        //Main.getmain.add_company.Enabled = true;
                    }
                    else if (check_AddCompany.Checked == false)
                    {
                        AddCompany = 0;
                        //Main.getmain.add_company.Enabled = false;
                    }

                    if (check_AddItemCompany.Checked == true)
                    {
                        AddItemCompany = 1;
                        //Main.getmain.add_XrayCompany.Enabled = true;
                    }
                    else if (check_AddItemCompany.Checked == false)
                    {
                        AddItemCompany = 0;
                        //Main.getmain.add_XrayCompany.Enabled = false;
                    }
                    if (check_PayCompany.Checked == true)
                    {
                        payCompany = 1;
                        //Main.getmain.pay_Company.Enabled = true;
                    }
                    else if (check_PayCompany.Checked == false)
                    {
                        payCompany = 0;
                        //Main.getmain.pay_Company.Enabled = false;
                    }

                    if (check_DebitCompany.Checked == true)
                    {
                        DepitCompany = 1;
                        //Main.getmain.Depit_Company.Enabled = true;
                    }
                    else if (check_DebitCompany.Checked == false)
                    {
                        DepitCompany = 0;
                        //Main.getmain.Depit_Company.Enabled = false;
                    }
                    ////////
                    if (check_REportCompany.Checked == true)
                    {
                        ReportCompany = 1;
                        //Main.getmain.Report_Company.Enabled = true;
                    }
                    else if (check_REportCompany.Checked == false)
                    {
                        ReportCompany = 0;
                        //Main.getmain.Report_Company.Enabled = false;
                    }



                    if (Check_AddDoctor.Checked == true)
                    {
                        AddDOCOTOTOut = 1;
                        //Main.getmain.add_doctorOut.Enabled = true;
                    }
                    else if (Check_AddDoctor_Centers.Checked == false)
                    {
                        AddDOCOTOTOut = 0;
                        //Main.getmain.add_doctorOut.Enabled = false;


                        if (check_RepoDoctorOut.Checked == true)
                        {
                            ReportDoctorOut = 1;
                            //Main.getmain.add_Techincal.Enabled = true;
                        }
                        else if (check_RepoDoctorOut.Checked == false)
                        {
                            ReportDoctorOut = 0;
                            //Main.getmain.report_DoctorOut.Enabled = false;
                        }



                    }

                    p.UpdateUserCompany(txt_Baisc.Text, AddCompany, AddItemCompany, payCompany, DepitCompany, ReportCompany,
                AddDOCOTOTOut, ReportDoctorOut);


                    MessageBox.Show(" تم حفظ الصلاحيات للمستخدم");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
