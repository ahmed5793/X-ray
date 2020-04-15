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
        Branches b = new Branches();
        Employee E = new Employee();
        Users U = new Users();
        Permession p = new Permession();
        DataTable dt = new DataTable();
        DataTable dt10 = new DataTable();
        DataTable dt2 = new DataTable();

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
            cmb_Users1.DataSource = E.Select_EmployeFromBranch(Convert.ToInt32(Cmb_Branch.SelectedValue));
            cmb_Users1.DisplayMember = "Emp_Name";
            cmb_Users1.ValueMember = "id_Emp";
            cmb_Users1.SelectedIndex = -1;

            dt2.Clear();
            dt2 = p.Select_UserBAsicInformation(txt_Baisc.Text);
        }

        public Validate_Users()
        {
            InitializeComponent();
            Txt_SalesMAn.Text = Program.salesman;
            Permision();
            check_AddEmployeeBranch.Hide();
           
        }       
        private void cmb_Users1_SelectionChangeCommitted(object sender, EventArgs e)
        {          
            try
            {
                dt10.Clear();
                dt10 = U.Select_UserName(Convert.ToInt32(cmb_Users1.SelectedValue));
                txt_Baisc.Text = dt10.Rows[0][0].ToString();

                dt2.Clear();
                dt2 = p.Select_UserBAsicInformation(txt_Baisc.Text);
                if (dt2.Rows.Count >= 1)
                {
                    if (Convert.ToInt32(dt2.Rows[0][0]) == 0){check_AddEmployee.Checked = false;}
                    else if (Convert.ToInt32(dt2.Rows[0][0]) == 1){check_AddEmployee.Checked = true;}
                    ///////
                    if (Convert.ToInt32(dt2.Rows[0][1]) == 0){check_AddEmployeeBranch.Checked = false;}
                    else if (Convert.ToInt32(dt2.Rows[0][1]) == 1){check_AddEmployeeBranch.Checked = true;}
                    ////////
                    if (Convert.ToInt32(dt2.Rows[0][2]) == 0){check_AddBranch.Checked = false;}
                    else if (Convert.ToInt32(dt2.Rows[0][2]) == 1){check_AddBranch.Checked = true;}
                    ///////
                    if (Convert.ToInt32(dt2.Rows[0][3]) == 0){Check_Add_CategoryXray.Checked = false;}
                    else if (Convert.ToInt32(dt2.Rows[0][3]) == 1){Check_Add_CategoryXray.Checked = true;}
                    /////////
                    if (Convert.ToInt32(dt2.Rows[0][4]) == 0){Check_Add_Xray.Checked = false;}
                    else if (Convert.ToInt32(dt2.Rows[0][4]) == 1){Check_Add_Xray.Checked = true;}
                    ///////
                    if (Convert.ToInt32(dt2.Rows[0][5]) == 0){check_DownloadFinger.Checked = false;}
                    else if (Convert.ToInt32(dt2.Rows[0][5]) == 1){check_DownloadFinger.Checked = true;}
                    ///////
                    if (Convert.ToInt32(dt2.Rows[0][6]) == 0){check_ReportFinger.Checked = false;}
                    else if (Convert.ToInt32(dt2.Rows[0][6]) == 1){check_ReportFinger.Checked = true;}
                    //////
                    ///////
                    if (Convert.ToInt32(dt2.Rows[0][7]) == 0) { Check_AddUserAccount.Checked = false; }
                    else if (Convert.ToInt32(dt2.Rows[0][7]) == 1) { Check_AddUserAccount.Checked = true; }
                    //////
                    ///////
                    if (Convert.ToInt32(dt2.Rows[0][8]) == 0) { Check_UserPermession.Checked = false; }
                    else if (Convert.ToInt32(dt2.Rows[0][8]) == 1) { Check_UserPermession.Checked = true; }
                   
                }

                dt2.Clear();
                dt2 = p.Select_UserEmployee(txt_Baisc.Text);
                if (dt2.Rows.Count >= 1)
                {
                    if (Convert.ToInt32(dt2.Rows[0][0]) == 0) { Check_Add_ShiftEmployee.Checked = false; }

                    else if (Convert.ToInt32(dt2.Rows[0][0]) == 1) { Check_Add_ShiftEmployee.Checked = true; }
                    ///////
                    if (Convert.ToInt32(dt2.Rows[0][1]) == 0) { Check_Discount.Checked = false; }

                    else if (Convert.ToInt32(dt2.Rows[0][1]) == 1) { Check_Discount.Checked = true; }
                    ////////
                    if (Convert.ToInt32(dt2.Rows[0][2]) == 0) { Check_Salf.Checked = false; }

                    else if (Convert.ToInt32(dt2.Rows[0][2]) == 1) { Check_Salf.Checked = true; }

                    /////////
                    if (Convert.ToInt32(dt2.Rows[0][3]) == 0) { Check_Sarf_Mortbat.Checked = false; }

                    else if (Convert.ToInt32(dt2.Rows[0][3]) == 1) { Check_Sarf_Mortbat.Checked = true; }
                    ///////
                    if (Convert.ToInt32(dt2.Rows[0][4]) == 0) { check_ReportEmployee.Checked = false; }

                    else if (Convert.ToInt32(dt2.Rows[0][4]) == 1) { check_ReportEmployee.Checked = true; }
                    ///////
                    if (Convert.ToInt32(dt2.Rows[0][5]) == 0) { Check_AddDoctor_Centers.Checked = false; }

                    else if (Convert.ToInt32(dt2.Rows[0][5]) == 1) { Check_AddDoctor_Centers.Checked = true; }
                    //////
                    if (Convert.ToInt32(dt2.Rows[0][6]) == 0) { check_ReportDoctorOfCenter.Checked = false; }

                    else if (Convert.ToInt32(dt2.Rows[0][6]) == 1) { check_ReportDoctorOfCenter.Checked = true; }
                    //////
                    if (Convert.ToInt32(dt2.Rows[0][7]) == 0) { check_AddTechnical.Checked = false; }

                    else if (Convert.ToInt32(dt2.Rows[0][7]) == 1) { check_AddTechnical.Checked = true; }
                    /////
                    if (Convert.ToInt32(dt2.Rows[0][8]) == 0) { Check_AddShiftTechincal.Checked = false; }

                    else if (Convert.ToInt32(dt2.Rows[0][8]) == 1) { Check_AddShiftTechincal.Checked = true; }
                    ///////
                    if (Convert.ToInt32(dt2.Rows[0][9]) == 0) { check_ReportTechnical.Checked = false; }

                    else if (Convert.ToInt32(dt2.Rows[0][9]) == 1) { check_ReportTechnical.Checked = true; }
                }
                dt2.Clear();
                dt2 = p.SelectUserCompany(txt_Baisc.Text);
                if (dt2.Rows.Count >= 1)
                {
                    if (Convert.ToInt32(dt2.Rows[0][0]) == 0){check_AddCompany.Checked = false;}
                    else if (Convert.ToInt32(dt2.Rows[0][0]) == 1){check_AddCompany.Checked = true;}
                    ///////
                    if (Convert.ToInt32(dt2.Rows[0][1]) == 0){check_AddItemCompany.Checked = false;}
                    else if (Convert.ToInt32(dt2.Rows[0][1]) == 1){check_AddItemCompany.Checked = true;}
                    ////////
                    if (Convert.ToInt32(dt2.Rows[0][2]) == 0){check_DebitCompany.Checked = false;}
                    else if (Convert.ToInt32(dt2.Rows[0][2]) == 1){check_DebitCompany.Checked = true;}

                    ///////
                    if (Convert.ToInt32(dt2.Rows[0][3]) == 0){check_PayCompany.Checked = false;}
                    else if (Convert.ToInt32(dt2.Rows[0][3]) == 1){check_PayCompany.Checked = true;}
                    /////////
                    if (Convert.ToInt32(dt2.Rows[0][4]) == 0){check_REportCompany.Checked = false;}
                    else if (Convert.ToInt32(dt2.Rows[0][4]) == 1){check_REportCompany.Checked = true;}
                    ///////
                    if (Convert.ToInt32(dt2.Rows[0][5]) == 0){Check_AddDoctor.Checked = false;}
                    else if (Convert.ToInt32(dt2.Rows[0][5]) == 1){Check_AddDoctor.Checked = true;}
                    ///////
                    if (Convert.ToInt32(dt2.Rows[0][6]) == 0){check_RepoDoctorOut.Checked = false;}
                    else if (Convert.ToInt32(dt2.Rows[0][6]) == 1){check_RepoDoctorOut.Checked = true;}

                    if (Convert.ToInt32(dt2.Rows[0][7]) == 0) { check_TransferCompany.Checked = false; }
                    else if (Convert.ToInt32(dt2.Rows[0][7]) == 1) { check_TransferCompany.Checked = true; }
                }
                dt2.Clear();
                dt2 = p.SelectUserAccount(txt_Baisc.Text);
                if (dt2.Rows.Count >= 1)
                {
                    if (Convert.ToInt32(dt2.Rows[0][0]) == 0){check_AddMasrof.Checked = false;}
                    else if (Convert.ToInt32(dt2.Rows[0][0]) == 1){check_AddMasrof.Checked = true;}
                    ///////
                    if (Convert.ToInt32(dt2.Rows[0][1]) == 0){check_ReportMarofat.Checked = false;}
                    else if (Convert.ToInt32(dt2.Rows[0][1]) == 1){check_ReportMarofat.Checked = true;}
                    ////////
                    if (Convert.ToInt32(dt2.Rows[0][2]) == 0){check_AddStock.Checked = false;}
                    else if (Convert.ToInt32(dt2.Rows[0][2]) == 1){check_AddStock.Checked = true;}
                    ///////
                    if (Convert.ToInt32(dt2.Rows[0][3]) == 0){check_PullStock.Checked = false;}
                    else if (Convert.ToInt32(dt2.Rows[0][3]) == 1){check_PullStock.Checked = true;}
                    /////////
                    if (Convert.ToInt32(dt2.Rows[0][4]) == 0){check_InsertIntoStock.Checked = false;}
                    else if (Convert.ToInt32(dt2.Rows[0][4]) == 1){check_InsertIntoStock.Checked = true;}
                    ///////
                    if (Convert.ToInt32(dt2.Rows[0][5]) == 0){check_TranfairStockToStock.Checked = false;}
                    else if (Convert.ToInt32(dt2.Rows[0][5]) == 1){check_TranfairStockToStock.Checked = true;}
                    ///////
                    if (Convert.ToInt32(dt2.Rows[0][6]) == 0){Ckeck_ReciveMoney.Checked = false;}
                    else if (Convert.ToInt32(dt2.Rows[0][6]) == 1){Ckeck_ReciveMoney.Checked = true;}
                    //////
                    if (Convert.ToInt32(dt2.Rows[0][7]) == 0) { check_ReportPullStock.Checked = false; }
                    else if (Convert.ToInt32(dt2.Rows[0][7]) == 1) { check_ReportPullStock.Checked = true; }
                    //////
                    if (Convert.ToInt32(dt2.Rows[0][8]) == 0) { check_ReportInsertStock.Checked = false; }
                    else if (Convert.ToInt32(dt2.Rows[0][8]) == 1) { check_ReportInsertStock.Checked = true; }
                    ///////
                    if (Convert.ToInt32(dt2.Rows[0][9]) == 0){check_AddInstalment.Checked = false;}
                    else if (Convert.ToInt32(dt2.Rows[0][9]) == 1){check_AddInstalment.Checked = true;}
                    //////
                    if (Convert.ToInt32(dt2.Rows[0][10]) == 0){check_ReportInstalment.Checked = false;}
                    else if (Convert.ToInt32(dt2.Rows[0][10]) == 1){check_ReportInstalment.Checked = true;}
                }
                dt2.Clear();
                dt2 = p.selectUser_Store(txt_Baisc.Text);
                if (dt2.Rows.Count >= 1)
                {
                    if (Convert.ToInt32(dt2.Rows[0][0]) == 0) { check_AddStore.Checked = false; }

                    else if (Convert.ToInt32(dt2.Rows[0][0]) == 1) { check_AddStore.Checked = true; }
                    ///////
                    if (Convert.ToInt32(dt2.Rows[0][1]) == 0) { check_AddProudect.Checked = false; }

                    else if (Convert.ToInt32(dt2.Rows[0][1]) == 1) { check_AddProudect.Checked = true; }
                    ////////
                    if (Convert.ToInt32(dt2.Rows[0][2]) == 0) { check_AddStoreProduct.Checked = false; }

                    else if (Convert.ToInt32(dt2.Rows[0][2]) == 1) { check_AddStoreProduct.Checked = true; }
                    ///////
                    if (Convert.ToInt32(dt2.Rows[0][3]) == 0) { check_TransfairProduct.Checked = false; }

                    else if (Convert.ToInt32(dt2.Rows[0][3]) == 1) { check_TransfairProduct.Checked = true; }
                    /////////
                    if (Convert.ToInt32(dt2.Rows[0][4]) == 0) { check_Order.Checked = false; }

                    else if (Convert.ToInt32(dt2.Rows[0][4]) == 1) { check_Order.Checked = true; }
                    ///////
                    if (Convert.ToInt32(dt2.Rows[0][5]) == 0) { check_ReportProudect.Checked = false; }

                    else if (Convert.ToInt32(dt2.Rows[0][5]) == 1) { check_ReportProudect.Checked = true; }
                    ///////
                    if (Convert.ToInt32(dt2.Rows[0][6]) == 0) { check_AddPurshase.Checked = false; }
                    else if (Convert.ToInt32(dt2.Rows[0][6]) == 1) { check_AddPurshase.Checked = true; }
                    //////
                    if (Convert.ToInt32(dt2.Rows[0][7]) == 0) { check_ReurnPurchise.Checked = false; }
                    else if (Convert.ToInt32(dt2.Rows[0][7]) == 1) { check_ReurnPurchise.Checked = true; }
                    /////
                    if (Convert.ToInt32(dt2.Rows[0][8]) == 0) { check_ReportPurshases.Checked = false; }
                    else if (Convert.ToInt32(dt2.Rows[0][8]) == 1) { check_ReportPurshases.Checked = true; }
                    /////
                    if (Convert.ToInt32(dt2.Rows[0][9]) == 0) { check_AddSuppliers.Checked = false; }
                    else if (Convert.ToInt32(dt2.Rows[0][9]) == 1) { check_AddSuppliers.Checked = true; }
                    /////

                    if (Convert.ToInt32(dt2.Rows[0][10]) == 0) { check_PaySupplies.Checked = false; }
                    else if (Convert.ToInt32(dt2.Rows[0][10]) == 1) { check_PaySupplies.Checked = true; }
                    /////
                    if (Convert.ToInt32(dt2.Rows[0][11]) == 0) { check_DepitSuppliuers.Checked = false; }
                    else if (Convert.ToInt32(dt2.Rows[0][11]) == 1)
                    { check_DepitSuppliuers.Checked = true; }

                    /////
                    if (Convert.ToInt32(dt2.Rows[0][12]) == 0) { check_ReportSuppliers.Checked = false; }
                    else if (Convert.ToInt32(dt2.Rows[0][12]) == 1) { check_ReportSuppliers.Checked = true; }
                }
                dt2.Clear();
                dt2 = p.selecTUserTickets(txt_Baisc.Text);
                if (dt2.Rows.Count >= 1)
                {
                    if (Convert.ToInt32(dt2.Rows[0][0]) == 0) { check_AddTickets.Checked = false; }
                    else if (Convert.ToInt32(dt2.Rows[0][0]) == 1) { check_AddTickets.Checked = true; }
                    ///////
                    if (Convert.ToInt32(dt2.Rows[0][1]) == 0) { check_ManagmentTickets.Checked = false; }
                    else if (Convert.ToInt32(dt2.Rows[0][1]) == 1) { check_ManagmentTickets.Checked = true; }
                    ////////
                    if (Convert.ToInt32(dt2.Rows[0][2]) == 0) { check_SearchTickets.Checked = false; }
                    else if (Convert.ToInt32(dt2.Rows[0][2]) == 1) { check_SearchTickets.Checked = true; }
                    ///////
                   
                    if (Convert.ToInt32(dt2.Rows[0][3]) == 0) { check_BookingTimes.Checked = false; }
                    else if (Convert.ToInt32(dt2.Rows[0][3]) == 1) { check_BookingTimes.Checked = true; }
                    /////
                    if (Convert.ToInt32(dt2.Rows[0][4]) == 0) { check_AddClients.Checked = false; }
                    else if (Convert.ToInt32(dt2.Rows[0][4]) == 1) { check_AddClients.Checked = true; }
                    /////////
                    if (Convert.ToInt32(dt2.Rows[0][5]) == 0) { check_PayClients.Checked = false; }

                    else if (Convert.ToInt32(dt2.Rows[0][5]) == 1) { check_PayClients.Checked = true; }
                    ///////
                    if (Convert.ToInt32(dt2.Rows[0][6]) == 0) { check_DepitClients.Checked = false; }

                    else if (Convert.ToInt32(dt2.Rows[0][6]) == 1) { check_DepitClients.Checked = true; }
                    //////
                    if (Convert.ToInt32(dt2.Rows[0][7]) == 0) { check_CustomerAccountStatment.Checked = false; }

                    else if (Convert.ToInt32(dt2.Rows[0][7]) == 1) { check_CustomerAccountStatment.Checked = true; }
                }
                //dt2.Clear();
                //dt2 = p.selectUser_Permission(txt_Baisc.Text);
                //if (dt2.Rows.Count >= 1)
                //{
                //    if (Convert.ToInt32(dt2.Rows[0][0]) == 0) { check_CreateAccount.Checked = false; }
                //    else if (Convert.ToInt32(dt2.Rows[0][0]) == 1) { check_CreateAccount.Checked = true; }
                //    ///////
                //    if (Convert.ToInt32(dt2.Rows[0][1]) == 0) { check_Permission.Checked = false; }
                //    else if (Convert.ToInt32(dt2.Rows[0][1]) == 1) { check_Permission.Checked = true; }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         
        }


        private void Validate_Users_Load(object sender, EventArgs e)
        {
              //txt_Baisc.Hide();
        }



        private void button4_Click(object sender, EventArgs e)
        {

            
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            try
            {
                if (cmb_Users1.Text == "")
                {
                    MessageBox.Show("لا بد من تحديد إسم الموظف");
                    return;
                }
                else
                {
                    int Add_Branch = 0, Add_Employee = 0, Add_EmployeeBranch = 0, Add_CategoryXray = 0, Add_Xrays = 0,
                        Downloaad_Finger = 0, Report_Finger = 0, Add_UserAccount = 0, User_Permession = 0 ;
                    if (check_AddBranch.Checked == true){Add_Branch = 1;}
                    else if (check_AddBranch.Checked == false){Add_Branch = 0;}
                    /////
                    if (check_AddEmployee.Checked == true){Add_Employee = 1;}
                    else if (check_AddEmployee.Checked == false){Add_Employee = 0;}
                    /////
                    if (check_AddEmployeeBranch.Checked == true){Add_EmployeeBranch = 1;}
                    else if (check_AddEmployeeBranch.Checked == false){Add_EmployeeBranch = 0;}
                    ////
                    if (Check_Add_CategoryXray.Checked == true){Add_CategoryXray = 1;}
                    else if (Check_Add_CategoryXray.Checked == false){Add_CategoryXray = 0;}
                    ////////
                    if (Check_Add_Xray.Checked == true){Add_Xrays = 1;}
                    else if (Check_Add_Xray.Checked == false){Add_Xrays = 0;}
                    ////////
                    if (check_DownloadFinger.Checked == true){Downloaad_Finger = 1;}
                    else if (check_DownloadFinger.Checked == false){Downloaad_Finger = 0;}
                    //////
                    if (check_ReportFinger.Checked == true){Report_Finger = 1;}
                    else if (check_ReportFinger.Checked == false){Report_Finger = 0;}
                    //////
                    if (Check_AddUserAccount.Checked == true) { Add_UserAccount = 1; }
                    else if (Check_AddUserAccount.Checked == false) { Add_UserAccount = 0; }
                    //////
                    if (Check_UserPermession.Checked == true) { User_Permession = 1; }
                    else if (Check_UserPermession.Checked == false) { User_Permession = 0; }

                    p.Update_UserBAsicInformation(txt_Baisc.Text, Add_Employee, Add_EmployeeBranch, Add_Branch, Add_CategoryXray, 
                        Add_Xrays, Downloaad_Finger, Report_Finger, Add_UserAccount, User_Permession);



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
                if (cmb_Users1.Text == "")
                {
                    MessageBox.Show("لا بد من تحديد إسم المستخدم");
                    return;
                }
                else
                {
                    int DiscountEmployee = 0, employeeSalary = 0, AddShiftEmployee = 0, AddSalfEmployee = 0, ReportEmployee = 0,
                        AddDOCOTOTCenter = 0, ReportDoctorCenter = 0, addTechincal = 0, AddShiftTecincal = 0, ReportTechincal = 0;

                    if (Check_Discount.Checked == true){DiscountEmployee = 1;}
                    else if (Check_Discount.Checked == false){DiscountEmployee = 0;}
                    //////
                    if (Check_Sarf_Mortbat.Checked == true){employeeSalary = 1;}
                    else if (Check_Sarf_Mortbat.Checked == false){employeeSalary = 0;}
                    //////
                    if (Check_Add_ShiftEmployee.Checked == true){AddShiftEmployee = 1;}
                    else if (Check_Add_ShiftEmployee.Checked == false){AddShiftEmployee = 0;}
                    //////
                    if (Check_Salf.Checked == true){AddSalfEmployee = 1;}
                    else if (Check_Salf.Checked == false){AddSalfEmployee = 0;}
                    ////////
                    if (check_ReportEmployee.Checked == true){ReportEmployee = 1;}
                    else if (check_ReportEmployee.Checked == false){ReportEmployee = 0;}
                    ///////
                    if (Check_AddDoctor_Centers.Checked == true){AddDOCOTOTCenter = 1;}
                    else if (Check_AddDoctor_Centers.Checked == false){AddDOCOTOTCenter = 0;}
                    //////
                    if (check_ReportDoctorOfCenter.Checked == true){ReportDoctorCenter = 1;}
                    else if (check_ReportDoctorOfCenter.Checked == false){ReportDoctorCenter = 0;}
                    ///////
                    if (check_ReportTechnical.Checked == true){ReportTechincal = 1;}
                    else if (check_ReportTechnical.Checked == false){ReportTechincal = 0;}
                    ///////
                    if (Check_AddShiftTechincal.Checked == true){AddShiftTecincal = 1;}
                    else if (Check_AddShiftTechincal.Checked == false){AddShiftTecincal = 0;}
                    //////
                    if (check_AddTechnical.Checked == true){addTechincal = 1;}
                    else if (check_AddTechnical.Checked == false){addTechincal = 0;}

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
                if (cmb_Users1.Text == "")
                {
                    MessageBox.Show("لا بد من تحديد إسم الموظف");
                    return;
                }
                else
                {
                    int AddCompany = 0, AddItemCompany = 0, payCompany = 0, DepitCompany = 0, ReportCompany = 0,
                        AddDOCOTOTOut = 0, ReportDoctorOut = 0, TransferCompany = 0;

                    if (check_AddCompany.Checked == true){AddCompany = 1;}

                    else if (check_AddCompany.Checked == false){AddCompany = 0;}
                    ///////
                    if (check_AddItemCompany.Checked == true){AddItemCompany = 1;}

                    else if (check_AddItemCompany.Checked == false){AddItemCompany = 0;}
                    ///////
                    if (check_PayCompany.Checked == true){payCompany = 1;}

                    else if (check_PayCompany.Checked == false){payCompany = 0;}
                    ////////
                    if (check_DebitCompany.Checked == true){DepitCompany = 1;}

                    else if (check_DebitCompany.Checked == false){DepitCompany = 0;}
                    ////////
                    if (check_REportCompany.Checked == true){ReportCompany = 1;}

                    else if (check_REportCompany.Checked == false){ReportCompany = 0;}
                    //////
                    if (Check_AddDoctor.Checked == true){AddDOCOTOTOut = 1;}

                    else if (Check_AddDoctor.Checked == false){AddDOCOTOTOut = 0;}
                    //////
                    if (check_RepoDoctorOut.Checked == true) { ReportDoctorOut = 1; }
                    
                    else if (check_RepoDoctorOut.Checked == false) { ReportDoctorOut = 0; }
                    ////
                    if (check_TransferCompany.Checked == true) { TransferCompany = 1; }

                    else if (check_TransferCompany.Checked == false) { TransferCompany = 0; }

                    p.UpdateUserCompany(txt_Baisc.Text, AddCompany, AddItemCompany, DepitCompany, payCompany, ReportCompany,
                                         AddDOCOTOTOut, ReportDoctorOut,TransferCompany);


                    MessageBox.Show(" تم حفظ الصلاحيات للمستخدم");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
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
                    int AddMasrof = 0, ReportMasrof = 0, AddStock = 0, InsertStock = 0, PullStock = 0,
                        TransfierStock = 0,ReciveMoney = 0 , ReportPullStock = 0, ReportInsertStock = 0 ,AddInstalment = 0,
                        reportInstalment = 0;

                    if (check_AddMasrof.Checked == true){AddMasrof = 1;}

                    else if (check_AddMasrof.Checked == false){AddMasrof = 0;}
                    ////////
                    if (check_ReportMarofat.Checked == true){ReportMasrof = 1;}

                    else if (check_ReportMarofat.Checked == false){ReportMasrof = 0;}
                    ///////
                    if (check_AddStock.Checked == true){AddStock = 1;}

                    else if (check_AddStock.Checked == false){AddStock = 0;}
                    ///////
                    if (check_InsertIntoStock.Checked == true){InsertStock = 1;}

                    else if (check_InsertIntoStock.Checked == false){InsertStock = 0;}
                    ////////
                    if (check_PullStock.Checked == true){PullStock = 1;}

                    else if (check_PullStock.Checked == false){PullStock = 0;}
                    /////////
                    if (check_TranfairStockToStock.Checked == true){TransfierStock = 1;}

                    else if (check_TranfairStockToStock.Checked == false){TransfierStock = 0;}
                    //////
                    if (Ckeck_ReciveMoney.Checked == true){ReciveMoney = 1;}

                    else if (Ckeck_ReciveMoney.Checked == false){ReciveMoney = 0;}
                    ///////
                    if (check_ReportPullStock.Checked == true){ReportPullStock = 1;}

                    else if (check_ReportPullStock.Checked == false){ReportPullStock = 0;}
                    //////

                    if (check_ReportInsertStock.Checked == true) { ReportInsertStock = 1; }

                    else if (check_ReportInsertStock.Checked == false) { ReportInsertStock = 0; }
                    //////
                    if (check_AddInstalment.Checked == true){AddInstalment = 1;}

                    else if (check_AddInstalment.Checked == false){AddInstalment = 0;}
                    //////
                    if (check_ReportInstalment.Checked == true){reportInstalment = 1;}

                    else if (check_ReportInstalment.Checked == false){reportInstalment = 0;}



                    p.UpdateUserAccount(txt_Baisc.Text, AddMasrof, ReportMasrof, AddStock, InsertStock, PullStock,
                        TransfierStock, ReciveMoney,ReportPullStock,ReportInsertStock, AddInstalment, reportInstalment);

                    MessageBox.Show(" تم حفظ الصلاحيات للمستخدم");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        private void simpleButton4_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_Users1.Text == "")
                {
                    MessageBox.Show("لا بد من تحديد إسم الموظف");
                    return;
                }
                else
                {
                    int AddStore = 0, AddProudect = 0, AddProudectStore = 0, items_consumption = 0, TransferStore = 0, reportProudect = 0,
                        AddSuppliers = 0, PaySuppliers = 0, DepitSuppliers = 0, ReportSupplier = 0,
                        AddInvoicePurchise = 0, returnInvlicePurchise = 0, ReportPurchise = 0;

                    if (check_AddStore.Checked == true){AddStore = 1;}

                    else if (check_AddStore.Checked == false){AddStore = 0;}
                    //////
                    if (check_AddProudect.Checked == true){AddProudect = 1;}

                    else if (check_AddProudect.Checked == false){AddProudect = 0;}
                    /////
                    if (check_AddStoreProduct.Checked == true){AddProudectStore = 1;}

                    else if (check_AddStoreProduct.Checked == false){AddProudectStore = 0;}
                    /////
                    if (check_Order.Checked == true){items_consumption = 1;}

                    else if (check_Order.Checked == false){items_consumption = 0;}
                    ////////
                    if (check_TransfairProduct.Checked == true){TransferStore = 1;}

                    else if (check_TransfairProduct.Checked == false){TransferStore = 0;}

                    ///////

                    if (check_ReportProudect.Checked == true){reportProudect = 1;}
                    else if (check_ReportProudect.Checked == false){reportProudect = 0;}
                    //////

                    if (check_AddSuppliers.Checked == true){AddSuppliers = 1;}
                    else if (check_AddSuppliers.Checked == false){AddSuppliers = 0;}
                    ///////
                    if (check_PaySupplies.Checked == true){PaySuppliers = 1;}

                    else if (check_PaySupplies.Checked == false){PaySuppliers = 0;}
                    ///////

                    if (check_DepitSuppliuers.Checked == true){DepitSuppliers = 1;}

                    else if (check_DepitSuppliuers.Checked == false){DepitSuppliers = 0;}
                    //////
                    if (check_ReportSuppliers.Checked == true){ReportSupplier = 1;}

                    else if (check_ReportSuppliers.Checked == false){ReportSupplier = 0;}
                    ////
                    if (check_AddPurshase.Checked == true){AddInvoicePurchise = 1;}

                    else if (check_AddPurshase.Checked == false){AddInvoicePurchise = 0;}
                    /////
                    if (check_ReurnPurchise.Checked == true){returnInvlicePurchise = 1;}
                    else if (check_ReurnPurchise.Checked == false){returnInvlicePurchise = 0;}
                    ////
                    if (check_ReportPurshases.Checked == true){ReportPurchise = 1;}
                    else if (check_ReportPurshases.Checked == false){ReportPurchise = 0;}
                    ///
                    p.UpdateUser_Store(txt_Baisc.Text, AddStore, AddProudect, AddProudectStore, TransferStore, items_consumption, reportProudect,
                        AddInvoicePurchise, returnInvlicePurchise, ReportPurchise, AddSuppliers, PaySuppliers, DepitSuppliers, ReportSupplier);

                    MessageBox.Show(" تم حفظ الصلاحيات للمستخدم");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_Users1.Text == "")
                {
                    MessageBox.Show("لا بد من تحديد إسم الموظف");
                    
                    return;
                }
                else
                {
                    int AddTickets = 0, ManagmentTickets = 0, SearchAllTickets = 0,BookingTimes = 0 , AddClient = 0, PayClient = 0,
                        DepitClient = 0, ReportClient = 0, ReportReturnTickets = 0; ;

                    if (check_AddTickets.Checked == true){AddTickets = 1;}
                    else if (check_AddTickets.Checked == false){AddTickets = 0;}
                    //////
                    if (check_ManagmentTickets.Checked == true){ManagmentTickets = 1;}
                    else if (check_ManagmentTickets.Checked == false){ManagmentTickets = 0;}
                    //////
                    if (check_SearchTickets.Checked == true){SearchAllTickets = 1;}
                    else if (check_SearchTickets.Checked == false){SearchAllTickets = 0;}
                    //////
                    if (check_BookingTimes.Checked == true) { BookingTimes = 1; }
                    else if (check_BookingTimes.Checked == false) { BookingTimes = 0; }
                    /////
                    if (check_AddClients.Checked == true){AddClient = 1;}
                    else if (check_AddClients.Checked == false){AddClient = 0;}
                    ////////
                    if (check_PayClients.Checked == true){PayClient = 1;}
                    else if (check_PayClients.Checked == false){PayClient = 0;}
                   /////
                    if (check_DepitClients.Checked == true){DepitClient = 1;}
                    else if (check_DepitClients.Checked == false){DepitClient = 0;}
                    /////
                    if (check_CustomerAccountStatment.Checked == true){ReportClient = 1;}
                    else if (check_CustomerAccountStatment.Checked == false){ReportClient = 0;}
                    if (check_ReportTicketsReturn.Checked == true) { ReportReturnTickets = 1; }
                    else if (check_ReportTicketsReturn.Checked == false) { ReportReturnTickets = 0; }


                    p.UpdateUser_Tickets(txt_Baisc.Text, AddTickets, ManagmentTickets, SearchAllTickets,BookingTimes, AddClient, PayClient,
                                          DepitClient, ReportClient, ReportReturnTickets);



                    MessageBox.Show(" تم حفظ الصلاحيات للمستخدم");



                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Cmb_Branch_SelectionChangeCommitted(object sender, EventArgs e)
        {

            cmb_Users1.DataSource = E.Select_EmployeFromBranch(Convert.ToInt32(Cmb_Branch.SelectedValue));
            cmb_Users1.DisplayMember = "Emp_Name";
            cmb_Users1.ValueMember = "id_Emp";
            cmb_Users1.SelectedIndex = -1;
            dt2.Clear();
            dt2 = p.Select_UserBAsicInformation(txt_Baisc.Text);
            if (cmb_Users1.Text=="")
            {
                Check();
            }
        }
        void Check()
        {
            
            
            check_AddBranch.Checked = false;
            check_AddClients.Checked = false;
            check_AddCompany.Checked = false;
            check_AddEmployee.Checked = false;
            check_AddEmployeeBranch.Checked = false;
            check_AddInstalment.Checked = false;
            check_AddItemCompany.Checked = false;
            check_AddMasrof.Checked = false;
            check_AddProudect.Checked = false;
            check_AddPurshase.Checked = false;
            check_AddStock.Checked = false;
            check_AddStore.Checked = false;
            check_AddStoreProduct.Checked = false;
            check_AddSuppliers.Checked = false;
            check_AddTechnical.Checked = false;
            check_AddTickets.Checked = false;
            check_BookingTimes.Checked = false;
            check_CustomerAccountStatment.Checked = false;
            check_DebitCompany.Checked = false;
            check_DepitClients.Checked = false;
            check_DepitSuppliuers.Checked = false;
            check_DownloadFinger.Checked = false;
            check_InsertIntoStock.Checked = false;
            check_ManagmentTickets.Checked = false;
            check_Order.Checked = false;
            check_PayClients.Checked = false;
            check_PayCompany.Checked = false;
            check_PaySupplies.Checked = false;
            check_PullStock.Checked = false;
            check_RepoDoctorOut.Checked = false;
            check_REportCompany.Checked = false;
            check_ReportDoctorOfCenter.Checked = false;
            check_ReportEmployee.Checked = false;
            check_ReportFinger.Checked = false;
            check_ReportInsertStock.Checked = false;
            check_ReportInstalment.Checked = false;
            check_ReportMarofat.Checked = false;
            check_ReportProudect.Checked = false;
            check_ReportPullStock.Checked = false;
            check_ReportPurshases.Checked = false;
            check_ReportSuppliers.Checked = false;
            check_ReportTechnical.Checked = false;
            check_ReurnPurchise.Checked = false;
            check_SearchTickets.Checked = false;
            check_TranfairStockToStock.Checked = false;
            check_TransfairProduct.Checked = false;
            Ckeck_ReciveMoney.Checked = false;
            Check_AddDoctor.Checked = false;
            Check_AddDoctor_Centers.Checked = false;
            Check_AddShiftTechincal.Checked = false;
            Check_AddUserAccount.Checked = false;
            Check_Add_CategoryXray.Checked = false;
            Check_Add_ShiftEmployee.Checked = false;
            Check_Add_Xray.Checked = false;
            Check_Discount.Checked = false;
            Check_Salf.Checked = false;
            Check_Sarf_Mortbat.Checked = false;
            Check_UserPermession.Checked = false;

        }

        private void cmb_Users1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
