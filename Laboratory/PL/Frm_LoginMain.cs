using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Laboratory.BL;
using System.Threading;

namespace Laboratory.PL
{
    public partial class Frm_LoginMain : DevExpress.XtraEditors.XtraForm
    {
        Users U = new Users();
        Permession p = new Permession();
        //Frm_Main frm = new Frm_Main();
        DataTable dt2 = new DataTable();
        DataTable dt = new DataTable();
        DataTable dt3 = new DataTable();
        DataTable dt4 = new DataTable();
        DataTable dt5 = new DataTable();
        DataTable dt6 = new DataTable();
        DataTable dt7 = new DataTable();
       

        Main fm = new Main();
        public Frm_LoginMain()
        {
          


            //Thread th = new Thread(new ThreadStart(startForm));
            //th.Start();
            //Thread.Sleep(5000);
            InitializeComponent();

            //th.Abort();
            //this.BringToFront();
     
           

        }
    
        //public void startForm()
        //{
           
        //        Application.Run(new SplashScreen1());
            
         
           
        //}
        private void txt_User_Leave(object sender, EventArgs e)
        {

            if (txt_User.Text == "")
            {

                txt_User.Text = "USER NAME";
            }
        }

        private void txt_User_MouseClick(object sender, MouseEventArgs e)
        {
            if (txt_User.Text == "USER NAME")
            {
                txt_User.Text = "";


            }
            else if (txt_User.Text == "")
            {
                txt_User.Text = "USER NAME";
            }
        }

        private void txt_Pass_MouseMove(object sender, MouseEventArgs e)
        {
            if (txt_Pass.Text != "PASSWORD")
            {
                checkBox1.Checked = false;
                txt_Pass.UseSystemPasswordChar = true;
            }
        }

        private void txt_Pass_Leave(object sender, EventArgs e)
        {

            if (txt_Pass.Text == "")
            {


                checkBox1.Checked = true;
                txt_Pass.Text = "PASSWORD";





            }
        }

        private void txt_Pass_MouseClick(object sender, MouseEventArgs e)
        {
            if (txt_Pass.Text == "PASSWORD")
            {

                txt_Pass.Text = "";
                checkBox1.Checked = false;
                txt_Pass.UseSystemPasswordChar = true;


            }
            else if (txt_Pass.Text == "")
            {
                txt_Pass.Text = "PASSWORD";

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (txt_Pass.Text != "PASSWORD")
            {


                if (checkBox1.Checked == true)
                {
                    txt_Pass.UseSystemPasswordChar = false;
                }
                else
                {
                    txt_Pass.UseSystemPasswordChar = true;
                }
            }
            else
            {
                checkBox1.Checked = true;
            }
        }
   
        private void Frm_LoginMain_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            //Properties.Settings.Default.Reset();
            //Thread.Sleep(8000);
            //Properties.Settings.Default.Reset();
        }

     

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bunifuThinButton2_Click(object sender, EventArgs e)
        {

            try
            {


                if (Properties.Settings.Default.ProudectKey=="NO")
                {
                    frm_SerielNumber FS = new frm_SerielNumber();
                    FS.ShowDialog();
                }
                else
                {

              
                    
                

                if (txt_User.Text == "")
                {
                    MessageBox.Show("PLEASE INSERT USER NAME");
                    return;
                }
                    if (txt_Pass.Text == "")
                    {
                        MessageBox.Show("PLEASE INSERT PASSWORD");
                        return;
                    }

                    else
                    {
                        dt.Clear();
                        dt = U.Logins(txt_User.Text, txt_Pass.Text);

                        if (dt.Rows.Count > 0)
                        {
                            /*---------------نسخه تجريبية------------------*/
                           // bool check;
                           //check = trail();
                           // if (check==false)
                           // {
                           //     return;
                           // }


                            backgroundWorker1.RunWorkerAsync();

                            Program.salesman = dt.Rows[0][1].ToString();
                            Console.Beep();
                            this.Hide();
                        
                            
                            fm.ShowDialog();
                        
                        }
                        else
                        {
                            MessageBox.Show("Incorrect password or username");
                        }

                    }




                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
              
            }
        }
        bool trail()
        {
            int x = Properties.Settings.Default.Trial;
            int y = x + 1;
            Properties.Settings.Default.Trial = y;
            Properties.Settings.Default.Save();

             
            if ( y  >  5)
            {
                  
                MessageBox.Show("يرجي العلم بأان تم انتهاء فترة النسخه التجريبية","تعطيل",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            

            }

            else
            {

                int min = y -5;
                MessageBox.Show(" هذة نسخة تجريبة ومتبقي لك عدد مرات" +  (min)   +" مرة","تعطيل", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            return true;

        }

        private void checkBox1_MouseMove(object sender, MouseEventArgs e)
        {
          
        }

        private void checkBox1_Leave(object sender, EventArgs e)
        {
           
        }

        private void checkBox1_MouseLeave(object sender, EventArgs e)
        {
            if (txt_Pass.Text != "PASSWORD")
            {
                if (checkBox1.Checked == true)
                {
                    checkBox1.Checked = false;
                    txt_Pass.UseSystemPasswordChar = true;
                }


            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
               
                dt2.Clear();
                dt2 = p.Select_UserBAsicInformation(txt_User.Text);
                if (dt2.Rows.Count >= 1)
                {
                    if (Convert.ToInt32(dt2.Rows[0][0]) == 0)
                    {
                        Main.getmain.add_employee.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][0]) == 1)
                    {
                        Main.getmain.add_employee.Enabled = true;
                    }
                    ///////
                    if (Convert.ToInt32(dt2.Rows[0][1]) == 0)
                    {

                    }
                    else if (Convert.ToInt32(dt2.Rows[0][1]) == 1)
                    {

                    }
                    ////////
                    if (Convert.ToInt32(dt2.Rows[0][2]) == 0)
                    {
                        Main.getmain.add_branch.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][2]) == 1)
                    {
                        Main.getmain.add_branch.Enabled = true;
                    }

                    ///////
                    if (Convert.ToInt32(dt2.Rows[0][3]) == 0)
                    {
                        Main.getmain.Xray_Category.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][3]) == 1)
                    {
                        Main.getmain.Xray_Category.Enabled = true;
                    }
                    /////////
                    if (Convert.ToInt32(dt2.Rows[0][4]) == 0)
                    {
                        Main.getmain.XrayName.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][4]) == 1)
                    {
                        Main.getmain.XrayName.Enabled = true;
                    }
                    ///////
                    if (Convert.ToInt32(dt2.Rows[0][5]) == 0)
                    {
                        Main.getmain.Download_finger.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][5]) == 1)
                    {
                        Main.getmain.Download_finger.Enabled = true;
                    }
                    ///////
                    if (Convert.ToInt32(dt2.Rows[0][6]) == 0)
                    {
                        Main.getmain.report_finger.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][6]) == 1)
                    {
                        Main.getmain.report_finger.Enabled = true;
                    }
                    ///////
                    if (Convert.ToInt32(dt2.Rows[0][7]) == 0)
                    {
                        Main.getmain.Btn_AddAccount.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][7]) == 1)
                    {
                        Main.getmain.Btn_AddAccount.Enabled = true;
                    }
                    ///////
                    if (Convert.ToInt32(dt2.Rows[0][8]) == 0)
                    {
                        Main.getmain.Btn_UserPermession.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][8]) == 1)
                    {
                        Main.getmain.Btn_UserPermession.Enabled = true;
                    }
                    ////
                    if (Convert.ToInt32(dt2.Rows[0][9]) == 0)
                    {
                        Main.getmain.Setting_Items.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][9]) == 1)
                    {
                        Main.getmain.Setting_Items.Enabled = true;
                    }
                }
                dt3.Clear();
                dt3 = p.Select_UserEmployee(txt_User.Text);
                if (dt3.Rows.Count >= 1)
                {
                    if (Convert.ToInt32(dt3.Rows[0][0]) == 0)
                    {
                        Main.getmain.add_shiftEmployee.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt3.Rows[0][0]) == 1)
                    {
                        Main.getmain.add_shiftEmployee.Enabled = true;
                    }
                    ///////
                    if (Convert.ToInt32(dt3.Rows[0][1]) == 0)
                    {
                        Main.getmain.discountEmployee.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt3.Rows[0][1]) == 1)
                    {
                        Main.getmain.discountEmployee.Enabled = true;
                    }
                    ////////
                    if (Convert.ToInt32(dt3.Rows[0][2]) == 0)
                    {
                        Main.getmain.add_salfEmployee.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt3.Rows[0][2]) == 1)
                    {
                        Main.getmain.add_salfEmployee.Enabled = true;
                    }

                    ///////

                    /////////
                    if (Convert.ToInt32(dt3.Rows[0][3]) == 0)
                    {
                        Main.getmain.sarf_SalaryEmployee.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt3.Rows[0][3]) == 1)
                    {
                        Main.getmain.sarf_SalaryEmployee.Enabled = true;
                    }
                    ///////
                    if (Convert.ToInt32(dt3.Rows[0][4]) == 0)
                    {
                        Main.getmain.Report_Employee.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt3.Rows[0][4]) == 1)
                    {
                        Main.getmain.Report_Employee.Enabled = true;
                    }
                    ///////
                    if (Convert.ToInt32(dt3.Rows[0][5]) == 0)
                    {
                        Main.getmain.add_DoctortCenter.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt3.Rows[0][5]) == 1)
                    {
                        Main.getmain.add_DoctortCenter.Enabled = true;
                    }
                    //////
                    if (Convert.ToInt32(dt3.Rows[0][6]) == 0)
                    {
                        Main.getmain.Report_DoctorCenter.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt3.Rows[0][6]) == 1)
                    {
                        Main.getmain.Report_DoctorCenter.Enabled = true;
                    }
                    ///
                    if (Convert.ToInt32(dt3.Rows[0][7]) == 0)
                    {
                        Main.getmain.add_Techincal.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt3.Rows[0][7]) == 1)
                    {
                        Main.getmain.add_Techincal.Enabled = true;
                    }
                    ///
                    if (Convert.ToInt32(dt3.Rows[0][8]) == 0)
                    {
                        Main.getmain.add_shiftTechincal.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt3.Rows[0][8]) == 1)
                    {
                        Main.getmain.add_shiftTechincal.Enabled = true;
                    }
                    //////////
                    if (Convert.ToInt32(dt3.Rows[0][9]) == 0)
                    {
                        Main.getmain.report_Techincal.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt3.Rows[0][9]) == 1)
                    {
                        Main.getmain.report_Techincal.Enabled = true;
                    }
                    //////////
                    if (Convert.ToInt32(dt3.Rows[0][10]) == 0)
                    {
                        Main.getmain.Btn_TechnicalShiftPrice.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt3.Rows[0][10]) == 1)
                    {
                        Main.getmain.Btn_TechnicalShiftPrice.Enabled = true;
                    }
                }
                dt4.Clear();
                dt4 = p.SelectUserCompany(txt_User.Text);
                if (dt4.Rows.Count >= 1)
                {
                    if (Convert.ToInt32(dt4.Rows[0][0]) == 0)
                    {
                        Main.getmain.add_company.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt4.Rows[0][0]) == 1)
                    {
                        Main.getmain.add_company.Enabled = true;
                    }
                    ///////
                    if (Convert.ToInt32(dt4.Rows[0][1]) == 0)
                    {
                        Main.getmain.add_XrayCompany.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt4.Rows[0][1]) == 1)
                    {
                        Main.getmain.add_XrayCompany.Enabled = true;
                    }
                    ////////
                    if (Convert.ToInt32(dt4.Rows[0][2]) == 0)
                    {
                        Main.getmain.Depit_Company.Enabled = false;

                    }
                    else if (Convert.ToInt32(dt4.Rows[0][2]) == 1)
                    {
                        Main.getmain.Depit_Company.Enabled = true;
                    }

                    ///////
                    if (Convert.ToInt32(dt4.Rows[0][3]) == 0)
                    {
                        Main.getmain.pay_Company.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt4.Rows[0][3]) == 1)
                    {
                        Main.getmain.pay_Company.Enabled = true;
                    }
                    ///////
                    if (Convert.ToInt32(dt4.Rows[0][4]) == 0)
                    {
                        Main.getmain.Btn_AccountStatment.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt4.Rows[0][4]) == 1)
                    {
                        Main.getmain.Btn_AccountStatment.Enabled = true;
                    }
                    /////
                    if (Convert.ToInt32(dt4.Rows[0][5]) == 0)
                    {
                        Main.getmain.add_doctorOut.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt4.Rows[0][5]) == 1)
                    {
                        Main.getmain.add_doctorOut.Enabled = true;
                    }
                    ///////
                    if (Convert.ToInt32(dt4.Rows[0][6]) == 0)
                    {
                        Main.getmain.report_DoctorOut.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt4.Rows[0][6]) == 1)
                    {
                        Main.getmain.report_DoctorOut.Enabled = true;
                    }

                    if (Convert.ToInt32(dt4.Rows[0][7]) == 0)
                    {
                        Main.getmain.btn_ReportTransferCompany.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt4.Rows[0][7]) == 1)
                    {
                        Main.getmain.btn_ReportTransferCompany.Enabled = true;
                    }
                }
                dt5.Clear();
                dt5 = p.SelectUserAccount(txt_User.Text);
                if (dt5.Rows.Count >= 1)
                {
                    if (Convert.ToInt32(dt5.Rows[0][0]) == 0)
                    {
                        Main.getmain.add_masrof.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt5.Rows[0][0]) == 1)
                    {
                        Main.getmain.add_masrof.Enabled = true;
                    }
                    ///////
                    if (Convert.ToInt32(dt5.Rows[0][1]) == 0)
                    {
                        Main.getmain.Btn_ReportMasrofat.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt5.Rows[0][1]) == 1)
                    {
                        Main.getmain.Btn_ReportMasrofat.Enabled = true;
                    }
                    ////////
                    if (Convert.ToInt32(dt5.Rows[0][2]) == 0)
                    {
                        Main.getmain.add_stock.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt5.Rows[0][2]) == 1)
                    {
                        Main.getmain.add_stock.Enabled = true;
                    }

                    ///////
                    if (Convert.ToInt32(dt5.Rows[0][3]) == 0)
                    {
                        Main.getmain.pull_stock.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt5.Rows[0][3]) == 1)
                    {

                        Main.getmain.pull_stock.Enabled = true;
                    }
                    /////////
                    if (Convert.ToInt32(dt5.Rows[0][4]) == 0)
                    {
                        Main.getmain.insert_stock.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt5.Rows[0][4]) == 1)
                    {
                        Main.getmain.insert_stock.Enabled = true;
                    }
                    ///////
                    if (Convert.ToInt32(dt5.Rows[0][5]) == 0)
                    {
                        Main.getmain.transfer_stock.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt5.Rows[0][5]) == 1)
                    {
                        Main.getmain.transfer_stock.Enabled = true;
                    }
                    ///////
                    if (Convert.ToInt32(dt5.Rows[0][6]) == 0)
                    {
                        Main.getmain.Btn_ReciveaMoney.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt5.Rows[0][6]) == 1)
                    {
                        Main.getmain.Btn_ReciveaMoney.Enabled = true;
                    }
                    ////////
                    if (Convert.ToInt32(dt5.Rows[0][7]) == 0)
                    {
                        Main.getmain.Btn_ReportPullStock.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt5.Rows[0][7]) == 1)
                    {
                        Main.getmain.Btn_ReportPullStock.Enabled = true;
                    }
                    /////
                    if (Convert.ToInt32(dt5.Rows[0][8]) == 0)
                    {
                        Main.getmain.Btn_ReportInsertStock.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt5.Rows[0][8]) == 1)
                    {
                        Main.getmain.Btn_ReportInsertStock.Enabled = true;
                    }
                    if (Convert.ToInt32(dt5.Rows[0][9]) == 0)
                    {
                        Main.getmain.add_installment.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt5.Rows[0][9]) == 1)
                    {
                        Main.getmain.add_installment.Enabled = true;
                    }
                    if (Convert.ToInt32(dt5.Rows[0][10]) == 0)
                    {
                        Main.getmain.btn_ReportInstallment.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt5.Rows[0][10]) == 1)
                    {
                        Main.getmain.btn_ReportInstallment.Enabled = true;
                    }
                    ///////
                    if (Convert.ToInt32(dt5.Rows[0][11]) == 0)
                    {
                        Main.getmain.Btn_Revenues.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt5.Rows[0][11]) == 1)
                    {
                        Main.getmain.Btn_Revenues.Enabled = true;
                    }
                }

                dt6.Clear();
                dt6 = p.selectUser_Store(txt_User.Text);
                if (dt6.Rows.Count >= 1)
                {
                    if (Convert.ToInt32(dt6.Rows[0][0]) == 0)
                    {
                        Main.getmain.add_store.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt6.Rows[0][0]) == 1)
                    {
                        Main.getmain.add_store.Enabled = true;
                    }
                    ///////
                    if (Convert.ToInt32(dt6.Rows[0][1]) == 0)
                    {
                        Main.getmain.add_items.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt6.Rows[0][1]) == 1)
                    {
                        Main.getmain.add_items.Enabled = true;
                    }
                    ////////
                    if (Convert.ToInt32(dt6.Rows[0][2]) == 0)
                    {
                        Main.getmain.add_ItemStore.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt6.Rows[0][2]) == 1)
                    {
                        Main.getmain.add_ItemStore.Enabled = true;
                    }

                    ///////
                    if (Convert.ToInt32(dt6.Rows[0][3]) == 0)
                    {
                        Main.getmain.trnasferStore.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt6.Rows[0][3]) == 1)
                    {
                        Main.getmain.trnasferStore.Enabled = true;
                    }
                    /////////
                    if (Convert.ToInt32(dt6.Rows[0][4]) == 0)
                    {
                        Main.getmain.items_consumption.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt6.Rows[0][4]) == 1)
                    {
                        Main.getmain.items_consumption.Enabled = true;
                    }
                    ///////
                    if (Convert.ToInt32(dt6.Rows[0][5]) == 0)
                    {
                        Main.getmain.report_items.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt6.Rows[0][5]) == 1)
                    {
                        Main.getmain.report_items.Enabled = true;
                    }
                    ///////
                    if (Convert.ToInt32(dt6.Rows[0][6]) == 0)
                    {
                        Main.getmain.add_invoiceSuppliers.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt6.Rows[0][6]) == 1)
                    {
                        Main.getmain.add_invoiceSuppliers.Enabled = true;
                    }

                    if (Convert.ToInt32(dt6.Rows[0][7]) == 0)
                    {
                        Main.getmain.return_suppliers.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt6.Rows[0][7]) == 1)
                    {
                        Main.getmain.return_suppliers.Enabled = true;
                    }
                    if (Convert.ToInt32(dt6.Rows[0][8]) == 0)
                    {
                        Main.getmain.report_invoicePurchise.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt6.Rows[0][8]) == 1)
                    {
                        Main.getmain.report_invoicePurchise.Enabled = true;
                    }

                    if (Convert.ToInt32(dt6.Rows[0][9]) == 0)
                    {
                        Main.getmain.add_suppliers.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt6.Rows[0][9]) == 1)
                    {
                        Main.getmain.add_suppliers.Enabled = true;
                    }
                    if (Convert.ToInt32(dt6.Rows[0][10]) == 0)
                    {
                        Main.getmain.pay_suppliers.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt6.Rows[0][10]) == 1)
                    {
                        Main.getmain.pay_suppliers.Enabled = true;
                    }
                    if (Convert.ToInt32(dt6.Rows[0][11]) == 0)
                    {
                        Main.getmain.Depit_suppliers.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt6.Rows[0][11]) == 1)
                    {
                        Main.getmain.Depit_suppliers.Enabled = true;
                    }


                    if (Convert.ToInt32(dt6.Rows[0][12]) == 0)
                    {
                        Main.getmain.Btn_SuppliersAccountStatment.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt6.Rows[0][12]) == 1)
                    {
                        Main.getmain.Btn_SuppliersAccountStatment.Enabled = true;
                    }
                }
                dt7.Clear();
                dt7 = p.selecTUserTickets(txt_User.Text);
                if (dt7.Rows.Count >= 1)
                {
                    if (Convert.ToInt32(dt7.Rows[0][0]) == 0)
                    {
                        Main.getmain.add_tickets.Enabled = false;
                        //Main.getmain.accordion_Tickets.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt7.Rows[0][0]) == 1)
                    {
                        Main.getmain.add_tickets.Enabled = true;
                        //Main.getmain.accordion_Tickets.Enabled = true;
                    }
                    ///////
                    if (Convert.ToInt32(dt7.Rows[0][1]) == 0)
                    {
                        Main.getmain.managment_tickets.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt7.Rows[0][1]) == 1)
                    {
                        Main.getmain.managment_tickets.Enabled = true;
                    }
                    ////////
                    if (Convert.ToInt32(dt7.Rows[0][2]) == 0)
                    {
                        Main.getmain.search_tickets.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt7.Rows[0][2]) == 1)
                    {
                        Main.getmain.search_tickets.Enabled = true;
                    }
                    ///////
                    if (Convert.ToInt32(dt7.Rows[0][3]) == 0)
                    {
                        Main.getmain.data_Revelation.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt7.Rows[0][3]) == 1)
                    {
                        Main.getmain.data_Revelation.Enabled = true;
                    }
                    ///////
                    if (Convert.ToInt32(dt7.Rows[0][4]) == 0)
                    {
                        Main.getmain.add_patient.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt7.Rows[0][4]) == 1)
                    {
                        Main.getmain.add_patient.Enabled = true;
                    }
                    /////////
                    //if (Convert.ToInt32(dt7.Rows[0][4]) == 0)
                    //{
                    //    Main.getmain.pay_patient.Enabled = false;

                    //}
                    //else if (Convert.ToInt32(dt7.Rows[0][4]) == 1)
                    //{
                    //    Main.getmain.pay_patient.Enabled = true;
                    //}
                    ///////
                    if (Convert.ToInt32(dt7.Rows[0][5]) == 0)
                    {
                        Main.getmain.pay_patientCompany.Enabled = false;

                    }
                    else if (Convert.ToInt32(dt7.Rows[0][5]) == 1)
                    {
                        Main.getmain.pay_patientCompany.Enabled = true;
                    }
                    ///////
                    if (Convert.ToInt32(dt2.Rows[0][6]) == 0)
                    {
                        Main.getmain.depit_client.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt7.Rows[0][6]) == 1)
                    {
                        Main.getmain.depit_client.Enabled = true;
                    }

                    if (Convert.ToInt32(dt7.Rows[0][7]) == 0)
                    {
                        Main.getmain.Btn_CustomerAccouantStatment.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt7.Rows[0][7]) == 1)
                    {
                        Main.getmain.Btn_CustomerAccouantStatment.Enabled = true;
                    }
                    if (Convert.ToInt32(dt7.Rows[0][8]) == 0)
                    {
                        Main.getmain.Btn_ReportReturn.Enabled = false;
                        //Main.getmain.accordion_Tickets.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt7.Rows[0][8]) == 1)
                    {
                        Main.getmain.Btn_ReportReturn.Enabled = true;
                        //Main.getmain.accordion_Tickets.Enabled = true;
                    }

                    if (Convert.ToInt32(dt7.Rows[0][9]) == 0)
                    {
                        Main.getmain.Btn_PermissionNoticeMoney.Enabled = false;
                        //Main.getmain.accordion_Tickets.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt7.Rows[0][9]) == 1)
                    {
                        Main.getmain.Btn_PermissionNoticeMoney.Enabled = true;
                        //Main.getmain.accordion_Tickets.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txt_Pass_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {



                    if (Properties.Settings.Default.ProudectKey == "NO")
                    {
                        frm_SerielNumber FS = new frm_SerielNumber();
                        FS.ShowDialog();
                    }
                    else
                    {





                        if (txt_User.Text == "")
                        {
                            MessageBox.Show("PLEASE INSERT USER NAME");
                            return;
                        }
                        if (txt_Pass.Text == "")
                        {
                            MessageBox.Show("PLEASE INSERT PASSWORD");
                            return;
                        }

                        else
                        {
                            dt.Clear();
                            dt = U.Logins(txt_User.Text, txt_Pass.Text);

                            if (dt.Rows.Count > 0)
                            {
                                //DataTable dt50 = new DataTable();
                                //DataTable dt5 = new DataTable();


                                //    dt50.Clear();
                                //    dt50 = U.SelectCheckUserName(txt_User.Text);
                                //    if (dt50.Rows.Count>0)
                                //    {
                                //        MessageBox.Show("عفوا هذا الاكونت مفتوح من جهاز اخر يرجي غلق الاكونت ثم اعد فتحه مرة اخرى");
                                //        return;
                                //    }


                                backgroundWorker1.RunWorkerAsync();



                                Program.salesman = dt.Rows[0][1].ToString();
                                Console.Beep();
                                this.Hide();
                                //dt5 = U.SelectCheckUserNameOffline(txt_User.Text);
                                //if (dt5.Rows.Count > 0)
                                //{
                                //    dt50.Clear();
                                //    dt50 = U.SelectCheckUserName(txt_User.Text);
                                //    if (dt50.Rows.Count == 0)
                                //    {
                                //        U.UpdateCheckUserName(txt_User.Text, "Online", Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy hh:mm tt")), Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy hh:mm tt")));

                                //}

                                //}


                                //else
                                //{

                                //    U.AddCheckUserName(txt_User.Text, "Online", Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy hh:mm tt")),
                                //     Convert.ToDateTime(DateTime.Now.ToString()));
                                //}
                                fm.ShowDialog();
                                Users u = new Users();
                                DataTable dt10 = new DataTable();
                                dt10.Clear();

                                dt10 = u.SelectAllCheckUserName();












                            }
                            else
                            {
                                MessageBox.Show("Incorrect password or username");
                            }

                        }




                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void txt_User_TextChanged(object sender, EventArgs e)
        {

        }
    }
}