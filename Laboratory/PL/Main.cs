using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using Laboratory.BL;


namespace Laboratory.PL
{
    public partial class Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
    	        
		
	

      


        private static Main farm;
        BL.Users u = new BL.Users();

        static void STATUESCllosed(object sender, FormClosedEventArgs e)
        {
            farm = null;
        }
        public static Main getmain
        {
            get
            {
                if (farm == null)
                {
                    farm = new Main();
                    farm.FormClosed += new FormClosedEventHandler(STATUESCllosed);
                }
                return farm;
            }
        }


        public Main()
        {

            InitializeComponent();
            if (farm == null)
            {
                farm = this;
            }


        }
       
	   	        
		

        private void barHeaderItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {

          
            Frm_ReportEmployeeData FRED = new Frm_ReportEmployeeData();
            FRED.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            try 
            { 
            Frm_Branches frm_Branches = new Frm_Branches();
            frm_Branches.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            try { 

            Frm_CategoryXRaya frm_CategoryX = new Frm_CategoryXRaya();
            frm_CategoryX.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            try 
            { 

            Frm_ItemsXRaya frm_ItemsXRaya = new Frm_ItemsXRaya();
            frm_ItemsXRaya.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            try { 
            Frm_Employee frm_Employee = new Frm_Employee();
            frm_Employee.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
         
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            try { 
            Frm_AddEmployeeShift AE = new Frm_AddEmployeeShift();
            AE.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            try { 

            Frm_Salf frm_Salf = new Frm_Salf();
            frm_Salf.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            try { 

            Frm_EmployeeDiscount fd = new Frm_EmployeeDiscount();
            fd.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            try { 
            Frm_EmpSarf frm_EmpSarf = new Frm_EmpSarf();
            frm_EmpSarf.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void barHeaderItem28_ItemClick(object sender, ItemClickEventArgs e)
        {
            try { 
            Frm_ReportEmployeeShift rm = new Frm_ReportEmployeeShift();
            rm.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void barHeaderItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            try { 
            Frm_ReportEmployeeSalary res = new Frm_ReportEmployeeSalary();
            res.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void barHeaderItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            try { 
            Frm_ReportEmployeeDiscount ed = new Frm_ReportEmployeeDiscount();
            ed.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void barHeaderItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            try { 
            Frm_ReportEmployeeSalf ES = new Frm_ReportEmployeeSalf();
            ES.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            try { 
            Frm_DoctorOfCenter frm_DoctorOfCenter = new Frm_DoctorOfCenter();
            frm_DoctorOfCenter.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void barHeaderItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            try { 
            Frm_ReportDoctorOfCenterData frdocd = new Frm_ReportDoctorOfCenterData();
            frdocd.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void barHeaderItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            try { 
            Frm_ReportOfDoctorOfCenter frm_ReportOfDoctorOfCenter = new Frm_ReportOfDoctorOfCenter();
            frm_ReportOfDoctorOfCenter.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void barHeaderItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            try { 
            Frm_AllCasesDoctorOfCenter facdoc = new Frm_AllCasesDoctorOfCenter();
            facdoc.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            try { 
            Frm_Techincal frm_Techincal = new Frm_Techincal();
            frm_Techincal.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void barHeaderItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            try { 
            Frm_ReportTechnicalData frtd = new Frm_ReportTechnicalData();
            frtd.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            try { 
            Frm_AddTechnicalShift fats = new Frm_AddTechnicalShift();
            fats.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void barHeaderItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            try { 
            Frm_ReportTechnicalShift frts = new Frm_ReportTechnicalShift();
            frts.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void barHeaderItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            try { 
            Frm_Report_DetailsTechnical frm_Report_Technical = new Frm_Report_DetailsTechnical();
            frm_Report_Technical.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void barHeaderItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            try { 
            Frm_AllXrayTechnical faxt = new Frm_AllXrayTechnical();
            faxt.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            try { 
            Frm_Company frm_Company = new Frm_Company();
            frm_Company.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem16_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Frm_PayCompanyMoney fpcm = new Frm_PayCompanyMoney();
                fpcm.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
        {
            try { 
            Frm_DebitCompany fdcas = new Frm_DebitCompany();
            fdcas.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem41_ItemClick(object sender, ItemClickEventArgs e)
        {
            try { 
            Frm_PayClient frm_PayClient = new Frm_PayClient();
            frm_PayClient.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void barHeaderItem29_ItemClick(object sender, ItemClickEventArgs e)
        {
            try { 
            Frm_ReportPAyCustomerCompany frpcc = new Frm_ReportPAyCustomerCompany();
            frpcc.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem38_ItemClick(object sender, ItemClickEventArgs e)
        {
            try { 
            Frm_Customer fc = new Frm_Customer();
            fc.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem39_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem40_ItemClick(object sender, ItemClickEventArgs e)
        {
            try { 
            Frm_DebitCustomer fdc = new Frm_DebitCustomer();
            fdc.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void barHeaderItem27_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem35_ItemClick(object sender, ItemClickEventArgs e)
        {
            try { 
            Frm_Tickets frm_Tickets = new Frm_Tickets();
            frm_Tickets.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem36_ItemClick(object sender, ItemClickEventArgs e)
        {
            try { 
            Frm_ManagmentTickets frm_Managment = new Frm_ManagmentTickets();
            frm_Managment.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem37_ItemClick(object sender, ItemClickEventArgs e)
        {
            try { 
            Frm_Search_Ticket frm_Search_Ticket = new Frm_Search_Ticket();
            frm_Search_Ticket.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void barHeaderItem26_ItemClick(object sender, ItemClickEventArgs e)
        {
            try { 
            Frm_ReportTransferForCompany tc = new Frm_ReportTransferForCompany();
            tc.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem16_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            try { 
            Frm_PayCompanyMoney fpcm = new Frm_PayCompanyMoney();
            fpcm.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void barHeaderItem13_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem14_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            try { 
            Frm_CompanyItemXray frm_CompanyItem = new Frm_CompanyItemXray();
            frm_CompanyItem.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem15_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            try { 
            Frm_DebitCompany fdcas = new Frm_DebitCompany();
            fdcas.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem18_ItemClick(object sender, ItemClickEventArgs e)
        {
            try { 
            Frm_Doctor frm_Doctor = new Frm_Doctor();
            frm_Doctor.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void barHeaderItem15_ItemClick(object sender, ItemClickEventArgs e)
        {
            try { 
            Frm_ReportOutDoctorData frodd = new Frm_ReportOutDoctorData();
            frodd.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void barHeaderItem16_ItemClick(object sender, ItemClickEventArgs e)
        {
            try { 
            Frm_ReportDoctor frm_ReportDoctor = new Frm_ReportDoctor();
            frm_ReportDoctor.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void barHeaderItem17_ItemClick(object sender, ItemClickEventArgs e)
        {
            try { 
            Frm_AllCasesOFOutDoctor facod = new Frm_AllCasesOFOutDoctor();
            facod.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem19_ItemClick(object sender, ItemClickEventArgs e)
        {
            try { 
            Frm_Masrofat frm_Masrofat = new Frm_Masrofat();
            frm_Masrofat.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void barHeaderItem18_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem20_ItemClick(object sender, ItemClickEventArgs e)
        {
            try { 
            frm_AddStock fas = new frm_AddStock();
            fas.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem21_ItemClick(object sender, ItemClickEventArgs e)
        {
            try { 
            Frm_StockPull fsp = new Frm_StockPull();
            fsp.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem22_ItemClick(object sender, ItemClickEventArgs e)
        {
            try { 
            frm_AddStockMoney fasm = new frm_AddStockMoney();
            fasm.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem23_ItemClick(object sender, ItemClickEventArgs e)
        {
            try { 
            Frm_StockTransfair fst = new Frm_StockTransfair();
            fst.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void barHeaderItem19_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barHeaderItem20_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void barButtonItem34_ItemClick(object sender, ItemClickEventArgs e)
        {
            try { 
            Frm_installment i = new Frm_installment();
            i.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void barHeaderItem25_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem24_ItemClick(object sender, ItemClickEventArgs e)
        {
            try { 
            Frm_AddStore frm_AddStore = new Frm_AddStore();
            frm_AddStore.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem25_ItemClick(object sender, ItemClickEventArgs e)
        {
            try { 
            Add_Product add_Product = new Add_Product();
            add_Product.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem26_ItemClick(object sender, ItemClickEventArgs e)
        {
            try { 
            Add_StoreProduct Asp = new Add_StoreProduct();
            Asp.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem27_ItemClick(object sender, ItemClickEventArgs e)
        {
            try { 
            Tranfair_product tranfair_Product = new Tranfair_product();
            tranfair_Product.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem28_ItemClick(object sender, ItemClickEventArgs e)
        {
            try { 
            Frm_Order frm_Order = new Frm_Order();
            frm_Order.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem29_ItemClick(object sender, ItemClickEventArgs e)
        {
            try { 
            Frm_Purshasing frm_Purshasing = new Frm_Purshasing();
            frm_Purshasing.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem30_ItemClick(object sender, ItemClickEventArgs e)
        {
            try { 

            Frm_ReturnSupplier frs = new Frm_ReturnSupplier();
            frs.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void barHeaderItem22_ItemClick(object sender, ItemClickEventArgs e)
        {
            try { 
            Frm_ReportTransfairProduct tp = new Frm_ReportTransfairProduct();
            tp.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void barHeaderItem21_ItemClick(object sender, ItemClickEventArgs e)
        {
            try { 
            Frm_ReportPurshasesInvoice pi = new Frm_ReportPurshasesInvoice();
            pi.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem31_ItemClick(object sender, ItemClickEventArgs e)
        {
            try { 
            Frm_Suppliers frm_Suppliers = new Frm_Suppliers();
            frm_Suppliers.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem32_ItemClick(object sender, ItemClickEventArgs e)

        {
            try { 
            Frm_PaySuppliers frm_PaySuppliers = new Frm_PaySuppliers();
            frm_PaySuppliers.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem33_ItemClick(object sender, ItemClickEventArgs e)
        {
            try { 
            Frm_DebitSuppliers frm_Debit = new Frm_DebitSuppliers();
            frm_Debit.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void barHeaderItem24_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void barButtonItem43_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem42_ItemClick(object sender, ItemClickEventArgs e)
        {


        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            barStaticItem7.Caption = Program.salesman;
            //accordionControlElement2.Text= Program.salesman;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            barStaticItem3.Caption = DateTime.Now.ToShortDateString();
            barStaticItem9.Caption = DateTime.Now.ToLongTimeString();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {


        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {

            //u.UpdateCheckUserName(Program.salesman, "Offline", Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy hh:mm tt")), Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy hh:mm tt")));

            Application.Exit();
        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {

        }

        private void fluentDesignFormContainer1_Click(object sender, EventArgs e)
        {

        }

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {

        }

        private void accordionContentContainer1_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement6_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem4_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            try { 
            Frm_ExportExell ex = new Frm_ExportExell();
            ex.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            //FingerPrint fs = new FingerPrint();
            //fs.Show();
        }

        private void barButtonItem5_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            try { 
            frm_ReportFingerExcell rf = new frm_ReportFingerExcell();
            rf.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            //Frm_reportFinger rp = new Frm_reportFinger();
            //rp.Show();
        }

        private void accordionControlElement6_Click_1(object sender, EventArgs e)
        {
          
        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {
           
        }

        private void accordionControlElement8_Click(object sender, EventArgs e)
        {
           
        }

        private void accordionControlElement9_Click(object sender, EventArgs e)
        {
         
        }

        private void Data_Redvelation_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Frm_DataRevaltionTicket dts = new Frm_DataRevaltionTicket();
                dts.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void Btn_ReciveaMoney_ItemClick(object sender, ItemClickEventArgs e)
        {
            try { 
            frm_RceiveMoney frm_Recive = new frm_RceiveMoney();
            frm_Recive.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void tileItem1_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {

        }

        private void tileItem2_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {

        }

        private void tileControl1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem4_ItemClick_2(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem4_ItemClick_3(object sender, ItemClickEventArgs e)
        {
            try { 
            Frm_AllPAyCompsny fapc = new Frm_AllPAyCompsny();
            fapc.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem5_ItemClick_2(object sender, ItemClickEventArgs e)
        {
            try { 
            Frm_ReportAllPayOfCustomer frapc = new Frm_ReportAllPayOfCustomer();
            frapc.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem6_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            try { 
            Frm_ReportMasrofat frm_ReportMasrofat = new Frm_ReportMasrofat();
            frm_ReportMasrofat.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem4_ItemClick_4(object sender, ItemClickEventArgs e)
        {
            try { 
            Frm_Mansgmentinstallment fmi = new Frm_Mansgmentinstallment();
            fmi.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem4_ItemClick_5(object sender, ItemClickEventArgs e)
        {
            try { 
            Frm_ReportInsertStock frm_Is = new Frm_ReportInsertStock();
            frm_Is.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_ReportPullStock_ItemClick(object sender, ItemClickEventArgs e)
        {
            try { 
            Frm_ReportStockPull frsp = new Frm_ReportStockPull();
            frsp.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem4_ItemClick_6(object sender, ItemClickEventArgs e)
        {
            try { 
            Frm_ReportPaySuppliers frm_ReportPaySuppliers = new Frm_ReportPaySuppliers();
            frm_ReportPaySuppliers.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_AddAccount_ItemClick(object sender, ItemClickEventArgs e)
        {
            try { 
            Frm_ManagmentUser frm_ManagmentUser = new Frm_ManagmentUser();
            frm_ManagmentUser.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_UserPermession_ItemClick(object sender, ItemClickEventArgs e)
        {
            try { 
            Validate_Users validate = new Validate_Users();
            validate.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem4_ItemClick_7(object sender, ItemClickEventArgs e)
        {
           
        }

        private void barHeaderItem23_ItemClick(object sender, ItemClickEventArgs e)
        {
            try { 
            Frm_ReportSelectOrder so = new Frm_ReportSelectOrder();
            so.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem5_ItemClick_3(object sender, ItemClickEventArgs e)
        {
            try { 
            Frm_ProductMinimum fpm = new Frm_ProductMinimum();
            fpm.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void barStaticItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            try { 
            Frm_ReportReturnSuppliers rsf = new Frm_ReportReturnSuppliers();
            rsf.Show();
        }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void barButtonItem6_ItemClick_2(object sender, ItemClickEventArgs e)
        {
            try
            {
                Frm_ReportTransferForCompany ftm = new Frm_ReportTransferForCompany();
                ftm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_ReportReturn_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Frm_ManagmentTicketsReturn fmtr = new Frm_ManagmentTicketsReturn();
                fmtr.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message) ;
            }
        }

        private void barButtonItem4_ItemClick_8(object sender, ItemClickEventArgs e)
        {
            try
            {
                PrintSetting p = new PrintSetting();
                p.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void accordionControlElement1_Click_1(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
          
         
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           
            
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
           
        }

        private void accordionControlElement1_Click_2(object sender, EventArgs e)
        {
            try
            {
                Frm_DetailsPhone dp = new Frm_DetailsPhone();
                dp.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void accordionControlElement4_Click_1(object sender, EventArgs e)
        {
            try
            {
                Application.Restart();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_Revenues_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Frm_Revenue fr = new Frm_Revenue();
                fr.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem6_ItemClick_3(object sender, ItemClickEventArgs e)
        {
            try
            {
                Frm_ReportOfDoctorOfCenter frdoc = new Frm_ReportOfDoctorOfCenter();
                frdoc.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem7_ItemClick_1(object sender, ItemClickEventArgs e)
        {
           
        }

        private void Btn_TechnicalShiftPrice_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_TechnicalShiftPrice ftsp = new Frm_TechnicalShiftPrice();
            ftsp.Show();
        }
    }
}
	
    
    
