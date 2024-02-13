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
    public partial class Frm_LogIn : Form
    {
        Users u = new Users();
        Permession P = new Permession();
        DataTable dt = new DataTable();
        
        public Frm_LogIn()
        {
            InitializeComponent();
            lableTime.Text = " الوقت:" + DateTime.Now.ToShortTimeString() + " / " + " التاريخ :" + DateTime.Now.ToShortDateString();

        }

        private void Btn_ok_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt2 = u.Logins(Txt_name.Text, Txt_Pass.Text);
                Form_Main fm = new Form_Main();

                if (dt2.Rows.Count>0)
                {
                    
                        dt.Clear();
                        dt = P.select_UserBAsicInformation(Txt_name.Text);
                    if (dt.Rows.Count >= 1)
                    {
                        if (Convert.ToInt32(dt.Rows[0][0]) == 1)
                        {
                            fm.btn_addCustomer.Enabled = true;

                        }
                        else if (Convert.ToInt32(dt.Rows[0][0]) == 0)
                        {
                            fm.btn_addCustomer.Enabled = false;

                        }
                        ////////////////
                        if (Convert.ToInt32(dt.Rows[0][1]) == 1)
                        {
                            fm.btn_addCompany.Enabled = true;

                        }
                        else if (Convert.ToInt32(dt.Rows[0][1]) == 0)
                        {
                            fm.btn_addCompany.Enabled = false;

                        }
                        ////////////////////
                        if (Convert.ToInt32(dt.Rows[0][2]) == 1)
                        {
                            fm.btn_AddPlan.Enabled = true;

                        }
                        else if (Convert.ToInt32(dt.Rows[0][2]) == 0)
                        {
                            fm.btn_AddPlan.Enabled = false;
                        }
                        ///////////////
                        if (Convert.ToInt32(dt.Rows[0][3]) == 1)
                        {
                            fm.Btn_Pay.Enabled = true;

                        }
                        else if (Convert.ToInt32(dt.Rows[0][3]) == 0)
                        {
                            fm.Btn_Pay.Enabled = false;
                        }
                    }
                        dt.Clear();
                        dt = P.Select_UserBookingTickets(Txt_name.Text);
                    if (dt.Rows.Count >= 1)
                    {
                        if (Convert.ToInt32(dt.Rows[0][0]) == 1)
                        {
                            fm.btn_booking.Enabled = true;

                        }
                        else if (Convert.ToInt32(dt.Rows[0][0]) == 0)
                        {
                            fm.btn_booking.Enabled = false;
                        }

                        //////////////
                        if (Convert.ToInt32(dt.Rows[0][1]) == 1)
                        {
                            fm.btn_Allticket.Enabled = true;

                        }
                        else if (Convert.ToInt32(dt.Rows[0][1]) == 0)
                        {
                            fm.btn_Allticket.Enabled = false;
                        }
                    }
                            dt.Clear();
                            dt = P.Select_UserArba7andMasrofat(Txt_name.Text);
                    if (dt.Rows.Count >= 1)
                    {
                        if (Convert.ToInt32(dt.Rows[0][0]) == 1)
                        {
                            fm.btn_addMasrof.Enabled = true;

                     
                        }
                        else if (Convert.ToInt32(dt.Rows[0][0]) == 0)
                        {
                            fm.btn_addMasrof.Enabled = false;
                        }
                        /////////
                        if (Convert.ToInt32(dt.Rows[0][1]) == 1)
                        {
                            fm.btn_AllMasrofat.Enabled = true;
                        }
                        else if (Convert.ToInt32(dt.Rows[0][1]) == 0)
                        {
                            fm.btn_AllMasrofat.Enabled = false;
                        }
                        //////////
                        if (Convert.ToInt32(dt.Rows[0][2]) == 1)
                        {
                            fm.btn_arba7.Enabled = true;
                          
                        }
                        else if (Convert.ToInt32(dt.Rows[0][2]) == 0)
                        {
                            fm.btn_arba7.Enabled = false;
                        }
                    }
                    dt.Clear();
                    dt = P.SelectUsers_BankStock(Txt_name.Text);
                    if (dt.Rows.Count >= 1)
                    {
                        if (Convert.ToInt32(dt.Rows[0][0]) == 1)
                        {
                            fm.btn_addCustomer.Enabled = true;
                        }
                        else if (Convert.ToInt32(dt.Rows[0][0]) == 0)
                        {
                            fm.btn_addCustomer.Enabled = false;
                        }
                        /////////
                        if (Convert.ToInt32(dt.Rows[0][1]) == 1)
                        {
                            fm.Btn_AddBank.Enabled = true;
                        }
                        else if (Convert.ToInt32(dt.Rows[0][1]) == 0)
                        {
                            fm.Btn_AddBank.Enabled = false;
                        }
                        //////////
                        if (Convert.ToInt32(dt.Rows[0][2]) == 1)
                        {
                            fm.InsertMoneyToStore.Enabled = true;
                        }
                        else if (Convert.ToInt32(dt.Rows[0][2]) == 0)
                        {
                            fm.InsertMoneyToStore.Enabled = false;
                        }
                        //////////
                        if (Convert.ToInt32(dt.Rows[0][3]) == 1)
                        {
                            fm.InsertMoneyToBank.Enabled = true;
                        }
                        else if (Convert.ToInt32(dt.Rows[0][3]) == 0)
                        {
                            fm.InsertMoneyToBank.Enabled = false;
                        }
                        /////////
                        if (Convert.ToInt32(dt.Rows[0][4]) == 1)
                        {
                            fm.PullMoneyFromStroe.Enabled = true;
                        }
                        else if (Convert.ToInt32(dt.Rows[0][4]) == 0)
                        {

                            fm.PullMoneyFromStroe.Enabled = false;
                        }
                        //////////
                        if (Convert.ToInt32(dt.Rows[0][5]) == 1)
                        {
                            fm.PullMoneyFromBank.Enabled = true;
                        }
                        else if (Convert.ToInt32(dt.Rows[0][5]) == 0)
                        {
                            fm.PullMoneyFromBank.Enabled = false;
                        }
                        //////////////////
                        if (Convert.ToInt32(dt.Rows[0][6]) == 1)
                        {
                            fm.TransfairStockToStock.Enabled = true;
                        }
                        else if (Convert.ToInt32(dt.Rows[0][6]) == 0)
                        {
                            fm.TransfairStockToStock.Enabled = false;
                        }
                        //////////
                        if (Convert.ToInt32(dt.Rows[0][7]) == 1)
                        {
                            fm.TransfairStockToBank.Enabled = true;
                        }
                        else if (Convert.ToInt32(dt.Rows[0][7]) == 0)
                        {
                            fm.TransfairStockToBank.Enabled = false;
                        }
                        ////////
                        if (Convert.ToInt32(dt.Rows[0][8]) == 1)
                        {
                            fm.transfairbankToStock.Enabled= true;
                        }
                        else if (Convert.ToInt32(dt.Rows[0][8]) == 0)
                        {
                            fm.transfairbankToStock.Enabled = false;
                        }
                        ////////
                        if (Convert.ToInt32(dt.Rows[0][9]) == 1)
                        {
                            fm.ReportInsertMoneyIntoStore.Enabled = true;
                        }
                        else if (Convert.ToInt32(dt.Rows[0][9]) == 0)
                        {
                            fm.ReportInsertMoneyIntoStore.Enabled = false;
                        }
                        ///////////
                        if (Convert.ToInt32(dt.Rows[0][10]) == 1)
                        {
                            fm.ReportInsertMoneyIntoBank.Enabled = true;
                           
                        }
                        else if (Convert.ToInt32(dt.Rows[0][10]) == 0)
                        {
                            fm.ReportInsertMoneyIntoBank.Enabled = false;
                        }
                        //////////
                        if (Convert.ToInt32(dt.Rows[0][11]) == 1)
                        {
                            fm.ReportPullMoneyFromStore.Enabled = true;
                        }
                        else if (Convert.ToInt32(dt.Rows[0][11]) == 0)
                        {
                            fm.ReportPullMoneyFromStore.Enabled = false;
                        }
                        //////////
                        if (Convert.ToInt32(dt.Rows[0][12]) == 1)
                        {
                            fm.ReportPullMoneyFromBank.Enabled = true;
                        }
                        else if (Convert.ToInt32(dt.Rows[0][12]) == 0)
                        {
                            fm.ReportPullMoneyFromBank.Enabled = true;
                        }

                    }

                    dt.Clear();
                    dt = P.SelectUser_Permssion(Txt_name.Text);
                    if (dt.Rows.Count >= 1)
                    {
                        if (Convert.ToInt32(dt.Rows[0][0]) == 1)
                        {
                            fm.btn_UserManagement.Enabled = true;
                        }
                        else if (Convert.ToInt32(dt.Rows[0][0]) == 0)
                        {
                            fm.btn_UserManagement.Enabled = false;
                        }

                        //////////////
                        if (Convert.ToInt32(dt.Rows[0][1]) == 1)
                        {
                            fm.Btn_UserPermssion.Enabled = true;
                        }
                        else if (Convert.ToInt32(dt.Rows[0][1]) == 0)
                        {
                            fm.Btn_UserPermssion.Enabled = false;
                        }
                       
                    }

                    Program.salesman = dt2.Rows[0]["FullName"].ToString();


                    u.ADDLogin(Txt_name.Text, lableTime.Text);
                    this.Hide();
                    fm.ShowDialog();

                }
                else
                {
                    MessageBox.Show("اسم المستخدم او كلمه المرور غير صحيحه");
                }


            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
