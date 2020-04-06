using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratory.PL
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
            PL.Frm_Order frm = new Frm_Order();
            frm.MdiParent = this;
            frm.Show();
        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
            
                PL.Frm_Tickets frm = new Frm_Tickets();
                frm.MdiParent = this;
                frm.Show();
            }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PL.Frm_Branches frm = new Frm_Branches();
            frm.MdiParent = this;
            frm.Show();
        }

        private void bunifuThinButton1_Click(object sender, EventArgs e)
        {

            //try
            //{

            //    if (txt_User.Text == "")
            //    {
            //        MessageBox.Show("PLEASE INSERT USER NAME");
            //        return;
            //    }
            //    if (txt_Pass.Text == "")
            //    {
            //        MessageBox.Show("PLEASE INSERT PASSWORD");
            //        return;
            //    }

            //    else
            //    {
            //        dt.Clear();
            //        dt = U.Logins(txt_User.Text, txt_Pass.Text);

            //        if (dt.Rows.Count > 0)
            //        {
            //            //DataTable dt50 = new DataTable();
            //            //DataTable dt5 = new DataTable();


            //            //    dt50.Clear();
            //            //    dt50 = U.SelectCheckUserName(txt_User.Text);
            //            //    if (dt50.Rows.Count>0)
            //            //    {
            //            //        MessageBox.Show("عفوا هذا الاكونت مفتوح من جهاز اخر يرجي غلق الاكونت ثم اعد فتحه مرة اخرى");
            //            //        return;
            //            //    }



            //            dt2.Clear();
            //            dt2 = p.Select_UserBAsicInformation(txt_User.Text);
            //            if (dt2.Rows.Count >= 1)
            //            {
            //                if (Convert.ToInt32(dt2.Rows[0][0]) == 0)
            //                {
            //                    Main.getmain.add_employee.Enabled = false;
            //                }
            //                else if (Convert.ToInt32(dt2.Rows[0][0]) == 1)
            //                {
            //                    Main.getmain.add_employee.Enabled = true;
            //                }
            //                ///////
            //                if (Convert.ToInt32(dt2.Rows[0][1]) == 0)
            //                {

            //                }
            //                else if (Convert.ToInt32(dt2.Rows[0][1]) == 1)
            //                {

            //                }
            //                ////////
            //                if (Convert.ToInt32(dt2.Rows[0][2]) == 0)
            //                {
            //                    Main.getmain.add_branch.Enabled = false;
            //                }
            //                else if (Convert.ToInt32(dt2.Rows[0][2]) == 1)
            //                {
            //                    Main.getmain.add_branch.Enabled = true;
            //                }

            //                ///////
            //                if (Convert.ToInt32(dt2.Rows[0][3]) == 0)
            //                {
            //                    Main.getmain.Xray_Category.Enabled = false;
            //                }
            //                else if (Convert.ToInt32(dt2.Rows[0][3]) == 1)
            //                {
            //                    Main.getmain.Xray_Category.Enabled = true;
            //                }
            //                /////////
            //                if (Convert.ToInt32(dt2.Rows[0][4]) == 0)
            //                {
            //                    Main.getmain.XrayName.Enabled = false;
            //                }
            //                else if (Convert.ToInt32(dt2.Rows[0][4]) == 1)
            //                {
            //                    Main.getmain.XrayName.Enabled = true;
            //                }
            //                ///////
            //                if (Convert.ToInt32(dt2.Rows[0][5]) == 0)
            //                {
            //                    Main.getmain.Download_finger.Enabled = false;
            //                }
            //                else if (Convert.ToInt32(dt2.Rows[0][5]) == 1)
            //                {
            //                    Main.getmain.Download_finger.Enabled = true;
            //                }
            //                ///////
            //                if (Convert.ToInt32(dt2.Rows[0][6]) == 0)
            //                {
            //                    Main.getmain.report_finger.Enabled = false;
            //                }
            //                else if (Convert.ToInt32(dt2.Rows[0][6]) == 1)
            //                {
            //                    Main.getmain.report_finger.Enabled = true;
            //                }
            //                ///////
            //                if (Convert.ToInt32(dt2.Rows[0][7]) == 0)
            //                {
            //                    Main.getmain.Btn_AddAccount.Enabled = false;
            //                }
            //                else if (Convert.ToInt32(dt2.Rows[0][7]) == 1)
            //                {
            //                    Main.getmain.Btn_AddAccount.Enabled = true;
            //                }
            //                ///////
            //                if (Convert.ToInt32(dt2.Rows[0][8]) == 0)
            //                {
            //                    Main.getmain.Btn_UserPermession.Enabled = false;
            //                }
            //                else if (Convert.ToInt32(dt2.Rows[0][8]) == 1)
            //                {
            //                    Main.getmain.Btn_UserPermession.Enabled = true;
            //                }
            //                ////
            //            }
            //            dt3.Clear();
            //            dt3 = p.Select_UserEmployee(txt_User.Text);
            //            if (dt3.Rows.Count >= 1)
            //            {
            //                if (Convert.ToInt32(dt3.Rows[0][0]) == 0)
            //                {
            //                    Main.getmain.add_shiftEmployee.Enabled = false;
            //                }
            //                else if (Convert.ToInt32(dt3.Rows[0][0]) == 1)
            //                {
            //                    Main.getmain.add_shiftEmployee.Enabled = true;
            //                }
            //                ///////
            //                if (Convert.ToInt32(dt3.Rows[0][1]) == 0)
            //                {
            //                    Main.getmain.discountEmployee.Enabled = false;
            //                }
            //                else if (Convert.ToInt32(dt3.Rows[0][1]) == 1)
            //                {
            //                    Main.getmain.discountEmployee.Enabled = true;
            //                }
            //                ////////
            //                if (Convert.ToInt32(dt3.Rows[0][2]) == 0)
            //                {
            //                    Main.getmain.add_salfEmployee.Enabled = false;
            //                }
            //                else if (Convert.ToInt32(dt3.Rows[0][2]) == 1)
            //                {
            //                    Main.getmain.add_salfEmployee.Enabled = true;
            //                }

            //                ///////

            //                /////////
            //                if (Convert.ToInt32(dt3.Rows[0][3]) == 0)
            //                {
            //                    Main.getmain.sarf_SalaryEmployee.Enabled = false;
            //                }
            //                else if (Convert.ToInt32(dt3.Rows[0][3]) == 1)
            //                {
            //                    Main.getmain.sarf_SalaryEmployee.Enabled = true;
            //                }
            //                ///////
            //                if (Convert.ToInt32(dt3.Rows[0][4]) == 0)
            //                {
            //                    Main.getmain.Report_Employee.Enabled = false;
            //                }
            //                else if (Convert.ToInt32(dt3.Rows[0][4]) == 1)
            //                {
            //                    Main.getmain.Report_Employee.Enabled = true;
            //                }
            //                ///////
            //                if (Convert.ToInt32(dt3.Rows[0][5]) == 0)
            //                {
            //                    Main.getmain.add_DoctortCenter.Enabled = false;
            //                }
            //                else if (Convert.ToInt32(dt3.Rows[0][5]) == 1)
            //                {
            //                    Main.getmain.add_DoctortCenter.Enabled = true;
            //                }
            //                //////
            //                if (Convert.ToInt32(dt3.Rows[0][6]) == 0)
            //                {
            //                    Main.getmain.Report_DoctorCenter.Enabled = false;
            //                }
            //                else if (Convert.ToInt32(dt3.Rows[0][6]) == 1)
            //                {
            //                    Main.getmain.Report_DoctorCenter.Enabled = true;
            //                }
            //                ///
            //                if (Convert.ToInt32(dt3.Rows[0][7]) == 0)
            //                {
            //                    Main.getmain.add_Techincal.Enabled = false;
            //                }
            //                else if (Convert.ToInt32(dt3.Rows[0][7]) == 1)
            //                {
            //                    Main.getmain.add_Techincal.Enabled = true;
            //                }
            //                ///
            //                if (Convert.ToInt32(dt3.Rows[0][8]) == 0)
            //                {
            //                    Main.getmain.add_shiftTechincal.Enabled = false;
            //                }
            //                else if (Convert.ToInt32(dt3.Rows[0][8]) == 1)
            //                {
            //                    Main.getmain.add_shiftTechincal.Enabled = true;
            //                }
            //                if (Convert.ToInt32(dt3.Rows[0][9]) == 0)
            //                {
            //                    Main.getmain.report_Techincal.Enabled = false;
            //                }
            //                else if (Convert.ToInt32(dt3.Rows[0][9]) == 1)
            //                {
            //                    Main.getmain.report_Techincal.Enabled = true;
            //                }
            //            }
            //            dt4.Clear();
            //            dt4 = p.SelectUserCompany(txt_User.Text);
            //            if (dt4.Rows.Count >= 1)
            //            {
            //                if (Convert.ToInt32(dt4.Rows[0][0]) == 0)
            //                {
            //                    Main.getmain.add_company.Enabled = false;
            //                }
            //                else if (Convert.ToInt32(dt4.Rows[0][0]) == 1)
            //                {
            //                    Main.getmain.add_company.Enabled = true;
            //                }
            //                ///////
            //                if (Convert.ToInt32(dt4.Rows[0][1]) == 0)
            //                {
            //                    Main.getmain.add_XrayCompany.Enabled = false;
            //                }
            //                else if (Convert.ToInt32(dt4.Rows[0][1]) == 1)
            //                {
            //                    Main.getmain.add_XrayCompany.Enabled = true;
            //                }
            //                ////////
            //                if (Convert.ToInt32(dt4.Rows[0][2]) == 0)
            //                {
            //                    Main.getmain.Depit_Company.Enabled = false;

            //                }
            //                else if (Convert.ToInt32(dt4.Rows[0][2]) == 1)
            //                {
            //                    Main.getmain.Depit_Company.Enabled = true;
            //                }

            //                ///////
            //                if (Convert.ToInt32(dt4.Rows[0][3]) == 0)
            //                {
            //                    Main.getmain.pay_Company.Enabled = false;
            //                }
            //                else if (Convert.ToInt32(dt4.Rows[0][3]) == 1)
            //                {
            //                    Main.getmain.pay_Company.Enabled = true;
            //                }
            //                ///////
            //                if (Convert.ToInt32(dt4.Rows[0][4]) == 0)
            //                {
            //                    Main.getmain.Btn_AccountStatment.Enabled = false;
            //                }
            //                else if (Convert.ToInt32(dt4.Rows[0][4]) == 1)
            //                {
            //                    Main.getmain.Btn_AccountStatment.Enabled = true;
            //                }
            //                /////
            //                if (Convert.ToInt32(dt4.Rows[0][5]) == 0)
            //                {
            //                    Main.getmain.add_doctorOut.Enabled = false;
            //                }
            //                else if (Convert.ToInt32(dt4.Rows[0][5]) == 1)
            //                {
            //                    Main.getmain.add_doctorOut.Enabled = true;
            //                }
            //                ///////
            //                if (Convert.ToInt32(dt4.Rows[0][6]) == 0)
            //                {
            //                    Main.getmain.report_DoctorOut.Enabled = false;
            //                }
            //                else if (Convert.ToInt32(dt4.Rows[0][6]) == 1)
            //                {
            //                    Main.getmain.report_DoctorOut.Enabled = true;
            //                }

            //                if (Convert.ToInt32(dt4.Rows[0][7]) == 0)
            //                {
            //                    Main.getmain.btn_ReportTransferCompany.Enabled = false;
            //                }
            //                else if (Convert.ToInt32(dt4.Rows[0][7]) == 1)
            //                {
            //                    Main.getmain.btn_ReportTransferCompany.Enabled = true;
            //                }
            //            }
            //            dt5.Clear();
            //            dt5 = p.SelectUserAccount(txt_User.Text);
            //            if (dt5.Rows.Count >= 1)
            //            {
            //                if (Convert.ToInt32(dt5.Rows[0][0]) == 0)
            //                {
            //                    Main.getmain.add_masrof.Enabled = false;
            //                }
            //                else if (Convert.ToInt32(dt5.Rows[0][0]) == 1)
            //                {
            //                    Main.getmain.add_masrof.Enabled = true;
            //                }
            //                ///////
            //                if (Convert.ToInt32(dt5.Rows[0][1]) == 0)
            //                {
            //                    Main.getmain.Btn_ReportMasrofat.Enabled = false;
            //                }
            //                else if (Convert.ToInt32(dt5.Rows[0][1]) == 1)
            //                {
            //                    Main.getmain.Btn_ReportMasrofat.Enabled = true;
            //                }
            //                ////////
            //                if (Convert.ToInt32(dt5.Rows[0][2]) == 0)
            //                {
            //                    Main.getmain.add_stock.Enabled = false;
            //                }
            //                else if (Convert.ToInt32(dt5.Rows[0][2]) == 1)
            //                {
            //                    Main.getmain.add_stock.Enabled = true;
            //                }

            //                ///////
            //                if (Convert.ToInt32(dt5.Rows[0][3]) == 0)
            //                {
            //                    Main.getmain.pull_stock.Enabled = false;
            //                }
            //                else if (Convert.ToInt32(dt5.Rows[0][3]) == 1)
            //                {

            //                    Main.getmain.pull_stock.Enabled = true;
            //                }
            //                /////////
            //                if (Convert.ToInt32(dt5.Rows[0][4]) == 0)
            //                {
            //                    Main.getmain.insert_stock.Enabled = false;
            //                }
            //                else if (Convert.ToInt32(dt5.Rows[0][4]) == 1)
            //                {
            //                    Main.getmain.insert_stock.Enabled = true;
            //                }
            //                ///////
            //                if (Convert.ToInt32(dt5.Rows[0][5]) == 0)
            //                {
            //                    Main.getmain.transfer_stock.Enabled = false;
            //                }
            //                else if (Convert.ToInt32(dt5.Rows[0][5]) == 1)
            //                {
            //                    Main.getmain.transfer_stock.Enabled = true;
            //                }
            //                ///////
            //                if (Convert.ToInt32(dt5.Rows[0][6]) == 0)
            //                {
            //                    Main.getmain.Btn_ReciveaMoney.Enabled = false;
            //                }
            //                else if (Convert.ToInt32(dt5.Rows[0][6]) == 1)
            //                {
            //                    Main.getmain.Btn_ReciveaMoney.Enabled = true;
            //                }
            //                ////////
            //                if (Convert.ToInt32(dt5.Rows[0][7]) == 0)
            //                {
            //                    Main.getmain.Btn_ReportPullStock.Enabled = false;
            //                }
            //                else if (Convert.ToInt32(dt5.Rows[0][7]) == 1)
            //                {
            //                    Main.getmain.Btn_ReportPullStock.Enabled = true;
            //                }
            //                /////
            //                if (Convert.ToInt32(dt5.Rows[0][8]) == 0)
            //                {
            //                    Main.getmain.Btn_ReportInsertStock.Enabled = false;
            //                }
            //                else if (Convert.ToInt32(dt5.Rows[0][8]) == 1)
            //                {
            //                    Main.getmain.Btn_ReportInsertStock.Enabled = true;
            //                }
            //                if (Convert.ToInt32(dt5.Rows[0][9]) == 0)
            //                {
            //                    Main.getmain.add_installment.Enabled = false;
            //                }
            //                else if (Convert.ToInt32(dt5.Rows[0][9]) == 1)
            //                {
            //                    Main.getmain.add_installment.Enabled = true;
            //                }
            //                if (Convert.ToInt32(dt5.Rows[0][10]) == 0)
            //                {
            //                    Main.getmain.btn_ReportInstallment.Enabled = false;
            //                }
            //                else if (Convert.ToInt32(dt5.Rows[0][10]) == 1)
            //                {
            //                    Main.getmain.btn_ReportInstallment.Enabled = true;
            //                }
            //            }

            //            dt6.Clear();
            //            dt6 = p.selectUser_Store(txt_User.Text);
            //            if (dt6.Rows.Count >= 1)
            //            {
            //                if (Convert.ToInt32(dt6.Rows[0][0]) == 0)
            //                {
            //                    Main.getmain.add_store.Enabled = false;
            //                }
            //                else if (Convert.ToInt32(dt6.Rows[0][0]) == 1)
            //                {
            //                    Main.getmain.add_store.Enabled = true;
            //                }
            //                ///////
            //                if (Convert.ToInt32(dt6.Rows[0][1]) == 0)
            //                {
            //                    Main.getmain.add_items.Enabled = false;
            //                }
            //                else if (Convert.ToInt32(dt6.Rows[0][1]) == 1)
            //                {
            //                    Main.getmain.add_items.Enabled = true;
            //                }
            //                ////////
            //                if (Convert.ToInt32(dt6.Rows[0][2]) == 0)
            //                {
            //                    Main.getmain.add_ItemStore.Enabled = false;
            //                }
            //                else if (Convert.ToInt32(dt6.Rows[0][2]) == 1)
            //                {
            //                    Main.getmain.add_ItemStore.Enabled = true;
            //                }

            //                ///////
            //                if (Convert.ToInt32(dt6.Rows[0][3]) == 0)
            //                {
            //                    Main.getmain.trnasferStore.Enabled = false;
            //                }
            //                else if (Convert.ToInt32(dt6.Rows[0][3]) == 1)
            //                {
            //                    Main.getmain.trnasferStore.Enabled = true;
            //                }
            //                /////////
            //                if (Convert.ToInt32(dt6.Rows[0][4]) == 0)
            //                {
            //                    Main.getmain.items_consumption.Enabled = false;
            //                }
            //                else if (Convert.ToInt32(dt6.Rows[0][4]) == 1)
            //                {
            //                    Main.getmain.items_consumption.Enabled = true;
            //                }
            //                ///////
            //                if (Convert.ToInt32(dt6.Rows[0][5]) == 0)
            //                {
            //                    Main.getmain.report_items.Enabled = false;
            //                }
            //                else if (Convert.ToInt32(dt6.Rows[0][5]) == 1)
            //                {
            //                    Main.getmain.report_items.Enabled = true;
            //                }
            //                ///////
            //                if (Convert.ToInt32(dt6.Rows[0][6]) == 0)
            //                {
            //                    Main.getmain.add_invoiceSuppliers.Enabled = false;
            //                }
            //                else if (Convert.ToInt32(dt6.Rows[0][6]) == 1)
            //                {
            //                    Main.getmain.add_invoiceSuppliers.Enabled = true;
            //                }

            //                if (Convert.ToInt32(dt6.Rows[0][7]) == 0)
            //                {
            //                    Main.getmain.return_suppliers.Enabled = false;
            //                }
            //                else if (Convert.ToInt32(dt6.Rows[0][7]) == 1)
            //                {
            //                    Main.getmain.return_suppliers.Enabled = true;
            //                }
            //                if (Convert.ToInt32(dt6.Rows[0][8]) == 0)
            //                {
            //                    Main.getmain.report_invoicePurchise.Enabled = false;
            //                }
            //                else if (Convert.ToInt32(dt6.Rows[0][8]) == 1)
            //                {
            //                    Main.getmain.report_invoicePurchise.Enabled = true;
            //                }

            //                if (Convert.ToInt32(dt6.Rows[0][9]) == 0)
            //                {
            //                    Main.getmain.add_suppliers.Enabled = false;
            //                }
            //                else if (Convert.ToInt32(dt6.Rows[0][9]) == 1)
            //                {
            //                    Main.getmain.add_suppliers.Enabled = true;
            //                }
            //                if (Convert.ToInt32(dt6.Rows[0][10]) == 0)
            //                {
            //                    Main.getmain.pay_suppliers.Enabled = false;
            //                }
            //                else if (Convert.ToInt32(dt6.Rows[0][10]) == 1)
            //                {
            //                    Main.getmain.pay_suppliers.Enabled = true;
            //                }
            //                if (Convert.ToInt32(dt6.Rows[0][11]) == 0)
            //                {
            //                    Main.getmain.Depit_suppliers.Enabled = false;
            //                }
            //                else if (Convert.ToInt32(dt6.Rows[0][11]) == 1)
            //                {
            //                    Main.getmain.Depit_suppliers.Enabled = true;
            //                }


            //                if (Convert.ToInt32(dt6.Rows[0][12]) == 0)
            //                {
            //                    Main.getmain.Btn_SuppliersAccountStatment.Enabled = false;
            //                }
            //                else if (Convert.ToInt32(dt6.Rows[0][12]) == 1)
            //                {
            //                    Main.getmain.Btn_SuppliersAccountStatment.Enabled = true;
            //                }
            //            }
            //            dt7.Clear();
            //            dt7 = p.selecTUserTickets(txt_User.Text);
            //            if (dt7.Rows.Count >= 1)
            //            {
            //                if (Convert.ToInt32(dt7.Rows[0][0]) == 0)
            //                {
            //                    Main.getmain.add_tickets.Enabled = false;
            //                    //Main.getmain.accordion_Tickets.Enabled = false;
            //                }
            //                else if (Convert.ToInt32(dt7.Rows[0][0]) == 1)
            //                {
            //                    Main.getmain.add_tickets.Enabled = true;
            //                    //Main.getmain.accordion_Tickets.Enabled = true;
            //                }
            //                ///////
            //                if (Convert.ToInt32(dt7.Rows[0][1]) == 0)
            //                {
            //                    Main.getmain.managment_tickets.Enabled = false;
            //                }
            //                else if (Convert.ToInt32(dt7.Rows[0][1]) == 1)
            //                {
            //                    Main.getmain.managment_tickets.Enabled = true;
            //                }
            //                ////////
            //                if (Convert.ToInt32(dt7.Rows[0][2]) == 0)
            //                {
            //                    Main.getmain.search_tickets.Enabled = false;
            //                }
            //                else if (Convert.ToInt32(dt7.Rows[0][2]) == 1)
            //                {
            //                    Main.getmain.search_tickets.Enabled = true;
            //                }
            //                ///////
            //                if (Convert.ToInt32(dt7.Rows[0][3]) == 0)
            //                {
            //                    Main.getmain.data_Revelation.Enabled = false;
            //                }
            //                else if (Convert.ToInt32(dt7.Rows[0][3]) == 1)
            //                {
            //                    Main.getmain.data_Revelation.Enabled = true;
            //                }
            //                ///////
            //                if (Convert.ToInt32(dt7.Rows[0][4]) == 0)
            //                {
            //                    Main.getmain.add_patient.Enabled = false;
            //                }
            //                else if (Convert.ToInt32(dt7.Rows[0][4]) == 1)
            //                {
            //                    Main.getmain.add_patient.Enabled = true;
            //                }
            //                /////////
            //                //if (Convert.ToInt32(dt7.Rows[0][4]) == 0)
            //                //{
            //                //    Main.getmain.pay_patient.Enabled = false;

            //                //}
            //                //else if (Convert.ToInt32(dt7.Rows[0][4]) == 1)
            //                //{
            //                //    Main.getmain.pay_patient.Enabled = true;
            //                //}
            //                ///////
            //                if (Convert.ToInt32(dt7.Rows[0][5]) == 0)
            //                {
            //                    Main.getmain.pay_patientCompany.Enabled = false;

            //                }
            //                else if (Convert.ToInt32(dt7.Rows[0][5]) == 1)
            //                {
            //                    Main.getmain.pay_patientCompany.Enabled = true;
            //                }
            //                ///////
            //                if (Convert.ToInt32(dt2.Rows[0][6]) == 0)
            //                {
            //                    Main.getmain.depit_client.Enabled = false;
            //                }
            //                else if (Convert.ToInt32(dt7.Rows[0][6]) == 1)
            //                {
            //                    Main.getmain.depit_client.Enabled = true;
            //                }

            //                if (Convert.ToInt32(dt7.Rows[0][7]) == 0)
            //                {
            //                    Main.getmain.Btn_CustomerAccouantStatment.Enabled = false;
            //                }
            //                else if (Convert.ToInt32(dt7.Rows[0][7]) == 1)
            //                {
            //                    Main.getmain.Btn_CustomerAccouantStatment.Enabled = true;
            //                }
            //                if (Convert.ToInt32(dt7.Rows[0][8]) == 0)
            //                {
            //                    Main.getmain.Btn_ReportReturn.Enabled = false;
            //                    //Main.getmain.accordion_Tickets.Enabled = false;
            //                }
            //                else if (Convert.ToInt32(dt7.Rows[0][8]) == 1)
            //                {
            //                    Main.getmain.Btn_ReportReturn.Enabled = true;
            //                    //Main.getmain.accordion_Tickets.Enabled = true;
            //                }
            //            }



            //            Program.salesman = dt.Rows[0][1].ToString();
            //            Console.Beep();
            //            this.Hide();
            //            //dt5 = U.SelectCheckUserNameOffline(txt_User.Text);
            //            //if (dt5.Rows.Count > 0)
            //            //{
            //            //    dt50.Clear();
            //            //    dt50 = U.SelectCheckUserName(txt_User.Text);
            //            //    if (dt50.Rows.Count == 0)
            //            //    {
            //            //        U.UpdateCheckUserName(txt_User.Text, "Online", Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy hh:mm tt")), Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy hh:mm tt")));

            //            //}

            //            //}


            //            //else
            //            //{

            //            //    U.AddCheckUserName(txt_User.Text, "Online", Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy hh:mm tt")),
            //            //     Convert.ToDateTime(DateTime.Now.ToString()));
            //            //}
            //            fm.ShowDialog();
            //            Users u = new Users();
            //            DataTable dt10 = new DataTable();
            //            dt10.Clear();

            //            dt10 = u.SelectAllCheckUserName();












            //        }
            //        else
            //        {
            //            MessageBox.Show("Incorrect password or username");
            //        }




            //    }


            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message);
            //    MessageBox.Show(ex.StackTrace);
            //}

        }
    }
}
