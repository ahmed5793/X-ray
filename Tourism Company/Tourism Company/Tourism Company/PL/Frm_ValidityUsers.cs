using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tourism_Company.BL;

namespace Tourism_Company.PL
{
    public partial class Frm_ValidityUsers : Form
    {
        Users u = new Users();
        Permession p = new Permession();
        DataTable dt = new DataTable();
        Form_Main fm = new Form_Main();
        public Frm_ValidityUsers()
        {
            InitializeComponent();
            select_ComboUsers();
       
        }
        internal void select_ComboUsers()
        {
            cmb_Users1.DataSource = u.selectIDUser();
            cmb_Users1.DisplayMember = "ID";
            cmb_Users1.ValueMember = "ID";
            Cmb_user2.DataSource = u.selectIDUser();
            Cmb_user2.DisplayMember = "ID";
            Cmb_user2.ValueMember = "ID";
            cmb_user3.DataSource = u.selectIDUser();
            cmb_user3.DisplayMember = "ID";
            cmb_user3.ValueMember = "ID";
            Cmb_User4.DataSource = u.selectIDUser();
            Cmb_User4.DisplayMember = "ID";
            Cmb_User4.ValueMember = "ID";
            cmb_user5.DataSource = u.selectIDUser();
            cmb_user5.DisplayMember = "ID";
            cmb_user5.ValueMember = "ID";
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Cmb_plane_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dt.Clear();
                dt = p.select_UserBAsicInformation(cmb_Users1.SelectedValue.ToString());
                if (dt.Rows.Count >= 1)
                {
                    if (Convert.ToInt32(dt.Rows[0][0]) == 1)
                    {
                        check_AddUser.Checked = true;
                    }
                    else if (Convert.ToInt32(dt.Rows[0][0]) == 0)
                    {
                        check_AddUser.Checked = false;
                    }
                    ////////////////
                    if (Convert.ToInt32(dt.Rows[0][1]) == 1)
                    {
                        check_AddCompany.Checked = true;
                    }
                    else if (Convert.ToInt32(dt.Rows[0][1]) == 0)
                    {
                        check_AddCompany.Checked = false;
                    }
                    ////////////////////
                    if (Convert.ToInt32(dt.Rows[0][2]) == 1)
                    {
                        check_AddPaln.Checked = true;
                    }
                    else if (Convert.ToInt32(dt.Rows[0][2]) == 0)
                    {
                        check_AddPaln.Checked = false;
                    }
                    ///////////////
                    if (Convert.ToInt32(dt.Rows[0][3]) == 1)
                    {
                        check_pay.Checked = true;
                    }
                    else if (Convert.ToInt32(dt.Rows[0][3]) == 0)
                    {
                        check_pay.Checked = false;
                    }

                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void GroupBox5_Enter(object sender, EventArgs e)
        {

        }
  
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_Users1.Text == "")
                {
                    MessageBox.Show("لا بد من تحديد إسم المستخدم");
                }
                else
                {


                    int add_costomer = 0, add_company = 0, add_plan = 0, pay = 0;
                    if (check_AddUser.Checked == true)
                    {
                        add_costomer = 1;
                        fm.btn_addCustomer.Enabled = true;
                    }
                    else if (check_AddUser.Checked == false)
                    {
                        add_costomer = 0;
                        fm.btn_addCustomer.Enabled = false;
                    }
                    ////////////////////////////
                    if (check_AddCompany.Checked == true)
                    {
                        add_company = 1;
                        fm.btn_addCompany.Enabled = true;
                    }
                    else if (check_AddCompany.Checked == false)
                    {
                        add_company = 0;
                        fm.btn_addCompany.Enabled = true;
                    }
                    ////////////////////////////
                    if (check_AddPaln.Checked == true)
                    {
                        add_plan = 1;
                        fm.btn_AddPlan.Enabled = true;
                    }
                    else if (check_AddPaln.Checked == false)
                    {
                        add_plan = 0;
                        fm.btn_AddPlan.Enabled = true;
                    }
                    ////////////////////////////
                    if (check_pay.Checked == true)
                    {
                        pay = 1;
                        fm.Btn_Pay.Enabled = true;
                    }
                    else if (check_pay.Checked == false)
                    {
                        pay = 0;
                        fm.Btn_Pay.Enabled = true;
                    }

                    p.Update_UserBAsicInformation(cmb_Users1.SelectedValue.ToString(), add_costomer, add_company, add_plan, pay);
                    MessageBox.Show(" تم حفظ الصلاحيات للمستخدم");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Cmb_user2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt2 = new DataTable();
                dt2.Clear();
                dt2 = p.Select_UserBookingTickets(Cmb_user2.SelectedValue.ToString());
                if (dt2.Rows.Count >= 1)
                {
                    if (Convert.ToInt32(dt2.Rows[0][0]) == 1)
                    {
                        check_booking.Checked = true;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][0]) == 0)
                    {
                        check_booking.Checked = false;
                    }

                    //////////////
                    if (Convert.ToInt32(dt2.Rows[0][1]) == 1)
                    {
                        check_manageBooking.Checked = true;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][1]) == 0)
                    {
                        check_manageBooking.Checked = false;
                    }

                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Btn_save2_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cmb_user2.Text == "")
                {
                    MessageBox.Show("لا بد من تحديد إسم المستخدم");
                }
                else
                {
                    int booking = 0, All_ticket = 0;
                    if (check_booking.Checked == true)
                    {
                        booking = 1;
                        fm.btn_booking.Enabled = true;
                    }
                    else if (check_booking.Checked == false)
                    {
                        booking = 0;
                        fm.btn_booking.Enabled = false;
                    }

                    if (check_manageBooking.Checked == true)
                    {
                        All_ticket = 1;
                        fm.btn_Allticket.Enabled = true;
                    }
                    else if (check_manageBooking.Checked == false)
                    {
                        All_ticket = 0;
                        fm.btn_Allticket.Enabled = false;
                    }

                    p.Update_UserBookingTickets(Cmb_user2.SelectedValue.ToString(), booking, All_ticket);
                    MessageBox.Show("تم حفظ الصلاحيات للمستخدم");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Cmb_user3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dt.Clear();
                dt = p.Select_UserArba7andMasrofat(cmb_user3.SelectedValue.ToString());
                if (dt.Rows.Count >= 1)
                {
                    if (Convert.ToInt32(dt.Rows[0][0]) == 1)
                    {
                        check_AddMasrof.Checked = true;
                    }
                    else if (Convert.ToInt32(dt.Rows[0][0]) == 0)
                    {
                        check_AddMasrof.Checked = false;
                    }
                    /////////
                    if (Convert.ToInt32(dt.Rows[0][1]) == 1)
                    {
                        check_allMasrofat.Checked = true;
                    }
                    else if (Convert.ToInt32(dt.Rows[0][1]) == 0)
                    {
                        check_allMasrofat.Checked = false;
                    }
                    //////////
                    if (Convert.ToInt32(dt.Rows[0][2]) == 1)
                    {
                        check_arba7.Checked = true;
                    }
                    else if (Convert.ToInt32(dt.Rows[0][2]) == 0)
                    {
                        check_arba7.Checked = false;
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Btn_save3_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_user3.Text == "")
                {
                    MessageBox.Show("لا بد من تحديد إسم المستخدم");
                }
                else
                {
                    int Add_masrof = 0, All_masrofat = 0, arba7 = 0;
                    if (check_AddMasrof.Checked == true)
                    {
                        Add_masrof = 1;
                        fm.btn_addMasrof.Enabled = true;
                    }
                    else if (check_AddMasrof.Checked == false)
                    {
                        Add_masrof = 0;
                        fm.btn_addMasrof.Enabled = false;
                    }
                    ///////////////

                    if (check_allMasrofat.Checked == true)
                    {
                        All_masrofat = 1;
                        fm.btn_AllMasrofat.Enabled = true;
                    }
                    else if (check_allMasrofat.Checked == false)
                    {
                        All_masrofat = 0;
                        fm.btn_AllMasrofat.Enabled = false;
                    }
                    ////////////////
                    if (check_arba7.Checked == true)
                    {
                        arba7 = 1;
                        fm.btn_arba7.Enabled = true;
                    }
                    else if (check_arba7.Checked == false)
                    {
                        arba7 = 0;
                        fm.btn_arba7.Enabled = false;
                    }

                    p.Update_UserArba7andMasrofat(cmb_user3.SelectedValue.ToString(), Add_masrof, All_masrofat, arba7);
                    MessageBox.Show("تم حفظ الصلاحيات للمستخدم");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Cmb_User4_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dt.Clear();
                dt = p.SelectUsers_BankStock(Cmb_User4.SelectedValue.ToString());
                if (dt.Rows.Count >= 1)
                {
                    if (Convert.ToInt32(dt.Rows[0][0]) == 1)
                    {
                        check_AddStock.Checked = true;
                    }
                    else if (Convert.ToInt32(dt.Rows[0][0]) == 0)
                    {
                        check_AddStock.Checked = false;
                    }
                    /////////
                    if (Convert.ToInt32(dt.Rows[0][1]) == 1)
                    {
                        check_AddBank.Checked = true;
                    }
                    else if (Convert.ToInt32(dt.Rows[0][1]) == 0)
                    {
                        check_AddBank.Checked = false;
                    }
                    //////////
                    if (Convert.ToInt32(dt.Rows[0][2]) == 1)
                    {
                        check_InsertIntoStock.Checked = true;
                    }
                    else if (Convert.ToInt32(dt.Rows[0][2]) == 0)
                    {
                        check_InsertIntoStock.Checked = false;
                    }
                    //////////
                    if (Convert.ToInt32(dt.Rows[0][3]) == 1)
                    {
                        check_InsertBank.Checked = true;
                    }
                    else if (Convert.ToInt32(dt.Rows[0][3]) == 0)
                    {
                        check_InsertBank.Checked = false;
                    }
                    /////////
                    if (Convert.ToInt32(dt.Rows[0][4]) == 1)
                    {
                        check_PullStock.Checked = true;
                    }
                    else if (Convert.ToInt32(dt.Rows[0][4]) == 0)
                    {
                        check_PullStock.Checked = false;
                    }
                    //////////
                    if (Convert.ToInt32(dt.Rows[0][5]) == 1)
                    {
                        check_PullBAnk.Checked = true;
                    }
                    else if (Convert.ToInt32(dt.Rows[0][5]) == 0)
                    {
                        check_PullBAnk.Checked = false;
                    }
                    //////////////////
                    if (Convert.ToInt32(dt.Rows[0][6]) == 1)
                    {
                        check_TranfairStockToStock.Checked = true;
                    }
                    else if (Convert.ToInt32(dt.Rows[0][6]) == 0)
                    {
                        check_TranfairStockToStock.Checked = false;
                    }
                    //////////
                    if (Convert.ToInt32(dt.Rows[0][7]) == 1)
                    {
                        check_tranfairStocktobank.Checked = true;
                    }
                    else if (Convert.ToInt32(dt.Rows[0][7]) == 0)
                    {
                        check_tranfairStocktobank.Checked = false;
                    }
                    ////////
                    if (Convert.ToInt32(dt.Rows[0][8]) == 1)
                    {
                        check_transBanktoStock.Checked = true;
                    }
                    else if (Convert.ToInt32(dt.Rows[0][8]) == 0)
                    {
                        check_transBanktoStock.Checked = false;
                    }
                    ////////
                    if (Convert.ToInt32(dt.Rows[0][9]) == 1)
                    {
                        check_ReportInsertStock.Checked = true;
                    }
                    else if (Convert.ToInt32(dt.Rows[0][9]) == 0)
                    {
                        check_ReportInsertStock.Checked = false;
                    }
                    ///////////
                    if (Convert.ToInt32(dt.Rows[0][10]) == 1)
                    {
                        check_reportInsertBank.Checked = true;
                    }
                    else if (Convert.ToInt32(dt.Rows[0][10]) == 0)
                    {
                        check_reportInsertBank.Checked = false;
                    }
                    //////////
                    if (Convert.ToInt32(dt.Rows[0][11]) == 1)
                    {
                        check_ReportPullStock.Checked = true;
                    }
                    else if (Convert.ToInt32(dt.Rows[0][11]) == 0)
                    {
                        check_ReportPullStock.Checked = false;
                    }
                    //////////
                    if (Convert.ToInt32(dt.Rows[0][12]) == 1)
                    {
                        check_ReportPullBank.Checked = true;
                    }
                    else if (Convert.ToInt32(dt.Rows[0][12]) == 0)
                    {
                        check_ReportPullBank.Checked = false;
                    }


                }

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void Btn_save4_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cmb_User4.Text == "")
                {
                    MessageBox.Show("لا بد من تحديد إسم المستخدم");
                }
                else
                {
                    int Add_Stock = 0, Add_BAnk = 0, insert_Stock = 0, Insert_Bank = 0, Pull_stock = 0, Pull_Bank = 0
               , TransStock = 0, TransStockToBank = 0, TransBAnkToStock = 0, ReportInsertStock = 0, ReportInsertbank = 0, ReportPullStock = 0, ReportPullBank = 0;
                    if (check_AddStock.Checked == true)
                    {
                        Add_Stock = 1;
                        fm.Btn_addStore.Enabled = true;
                    }
                    else if (check_AddMasrof.Checked == false)
                    {
                        Add_Stock = 0;
                        fm.Btn_addStore.Enabled = false;
                    }
                    ///////////////

                    if (check_AddBank.Checked == true)
                    {
                        Add_BAnk = 1;
                        fm.Btn_AddBank.Enabled = true;
                    }
                    else if (check_AddBank.Checked == false)
                    {
                        Add_BAnk = 0;
                        fm.Btn_AddBank.Enabled = false;
                    }
                    ////////////////
                    if (check_InsertIntoStock.Checked == true)
                    {
                        insert_Stock = 1;
                        fm.InsertMoneyToStore.Enabled = true;
                    }
                    else if (check_arba7.Checked == false)
                    {
                        insert_Stock = 0;
                        fm.InsertMoneyToStore.Enabled = false;
                    }
                    //////////////
                    if (check_InsertBank.Checked == true)
                    {
                        Insert_Bank = 1;
                        fm.InsertMoneyToBank.Enabled = true;
                    }
                    else if (check_InsertBank.Checked == false)
                    {
                        Insert_Bank = 0;
                        fm.InsertMoneyToBank.Enabled = false;
                    }
                    //////////////////////
                    if (check_PullStock.Checked == true)
                    {
                        Pull_stock = 1;
                        fm.PullMoneyFromStroe.Enabled = true;
                    }
                    else if (check_PullStock.Checked == false)
                    {
                        Pull_stock = 0;
                        fm.PullMoneyFromStroe.Enabled = false;
                    }
                    //////////
                    if (check_PullBAnk.Checked == true)
                    {
                        Pull_Bank = 1;
                        fm.PullMoneyFromBank.Enabled = true;
                    }
                    else if (check_PullBAnk.Checked == false)
                    {
                        Pull_Bank = 0;
                        fm.PullMoneyFromBank.Enabled = false;
                    }
                    ///////////
                    if (check_TranfairStockToStock.Checked == true)
                    {
                        TransStock = 1;
                        fm.TransfairStockToStock.Enabled = true;
                    }
                    else if (check_TranfairStockToStock.Checked == false)
                    {
                        TransStock = 0;
                        fm.TransfairStockToStock.Enabled = false;
                    }
                    //////////////
                    if (check_tranfairStocktobank.Checked == true)
                    {
                        TransStockToBank = 1;
                        fm.TransfairStockToBank.Enabled = true;
                    }
                    else if (check_tranfairStocktobank.Checked == false)
                    {
                        TransStockToBank = 0;
                        fm.TransfairStockToBank.Enabled = false;
                    }
                    //////////////

                    if (check_transBanktoStock.Checked == true)
                    {
                        TransBAnkToStock = 1;
                        fm.transfairbankToStock.Enabled = true;
                    }
                    else if (check_transBanktoStock.Checked == false)
                    {
                        TransBAnkToStock = 0;
                        fm.transfairbankToStock.Enabled = false;
                    }
                    //////////////
                    if (check_ReportInsertStock.Checked == true)
                    {
                        ReportInsertStock = 1;
                        fm.ReportInsertMoneyIntoStore.Enabled = true;
                    }
                    else if (check_ReportInsertStock.Checked == false)
                    {
                        ReportInsertStock = 0;
                        fm.ReportInsertMoneyIntoStore.Enabled = false;
                    }
                    //////////////
                    if (check_reportInsertBank.Checked == true)
                    {
                        ReportInsertbank = 1;
                        fm.ReportInsertMoneyIntoBank.Enabled = true;
                    }
                    else if (check_reportInsertBank.Checked == false)
                    {
                        ReportInsertbank = 0;
                        fm.ReportInsertMoneyIntoBank.Enabled = false;
                    }
                    //////////////
                    if (check_ReportPullStock.Checked == true)
                    {
                        ReportPullStock = 1;
                        fm.ReportPullMoneyFromStore.Enabled = true;
                    }
                    else if (check_ReportPullStock.Checked == false)
                    {
                        ReportPullStock = 0;
                        fm.ReportPullMoneyFromStore.Enabled = false;
                    }
                    //////////////
                    if (check_ReportPullBank.Checked == true)
                    {
                        ReportPullBank = 1;
                        fm.ReportPullMoneyFromBank.Enabled = true;
                    }
                    else if (check_ReportPullBank.Checked == false)
                    {
                        ReportPullBank = 0;
                        fm.ReportPullMoneyFromBank.Enabled = false;
                    }

                    p.UpdateUsers_BankStock(Cmb_User4.SelectedValue.ToString(), Add_Stock, Add_BAnk, insert_Stock, Insert_Bank, Pull_stock, Pull_Bank, TransStock, TransStockToBank, TransBAnkToStock, ReportInsertStock, ReportInsertbank, ReportPullStock, ReportPullBank);
                    MessageBox.Show("تم حفظ الصلاحيات للمستخدم");
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void Cmb_user5_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
                dt.Clear();
                dt = p.SelectUser_Permssion(cmb_user5.SelectedValue.ToString());
                if (dt.Rows.Count >= 1)
                {
                    if (Convert.ToInt32(dt.Rows[0][0]) == 1)
                    {
                        check_UserManagment.Checked = true;
                    }
                    else if (Convert.ToInt32(dt.Rows[0][0]) == 0)
                    {
                        check_UserManagment.Checked = false;
                    }

                    //////////////
                    if (Convert.ToInt32(dt.Rows[0][1]) == 1)
                    {
                        check_validtyUser.Checked = true;
                    }
                    else if (Convert.ToInt32(dt.Rows[0][1]) == 0)
                    {
                        check_validtyUser.Checked = false;
                    }

                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            try
            {
                if (cmb_user5.Text == "")
                {
                    MessageBox.Show("لابد من تحديد إسم مستخدم");
                }
                else
                {


                    int manage_user = 0, user_permession = 0;
                    if (check_UserManagment.Checked == true)
                    {
                        manage_user = 1;
                        fm.btn_UserManagement.Enabled = true;
                    }
                    else if (check_UserManagment.Checked == false)
                    {
                        manage_user = 0;
                        fm.btn_UserManagement.Enabled = false;
                    }

                    if (check_validtyUser.Checked == true)
                    {
                        user_permession = 1;
                        fm.Btn_UserPermssion.Enabled = true;
                    }
                    else if (check_validtyUser.Checked == false)
                    {
                        user_permession = 0;
                        fm.Btn_UserPermssion.Enabled = false;
                    }

                    p.UpdateUser_Permssion(cmb_user5.SelectedValue.ToString(), manage_user, user_permession);
                    MessageBox.Show("تم حفظ الصلاحيات للمستخدم");
                }
            }

            catch (Exception)
            {

                throw;
            }
        }
    }
}
