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


namespace Laboratory.PL
{
    public partial class Main : DevExpress.XtraEditors.XtraForm
    {
        private static Main farm;

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
            Frm_ReportEmployeeData FRED = new Frm_ReportEmployeeData();
            FRED.MdiParent = this;
            FRED.Show();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_Branches frm_Branches = new Frm_Branches();
            frm_Branches.MdiParent = this;
            frm_Branches.Show();
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_CategoryXRaya frm_CategoryX = new Frm_CategoryXRaya();
           frm_CategoryX.MdiParent = this;
            frm_CategoryX.Show();
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_ItemsXRaya frm_ItemsXRaya = new Frm_ItemsXRaya();
            frm_ItemsXRaya.MdiParent = this;
            frm_ItemsXRaya.Show();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_Employee frm_Employee = new Frm_Employee();
            frm_Employee.MdiParent = this;
            frm_Employee.Show();
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_AddEmployeeBranch employeeBranch = new Frm_AddEmployeeBranch();
            employeeBranch.MdiParent = this;
            employeeBranch.Show();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_AddEmployeeShift AE = new Frm_AddEmployeeShift();
            AE.MdiParent = this;
            AE.Show();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_Salf frm_Salf = new Frm_Salf();
            frm_Salf.MdiParent = this;
            frm_Salf.Show();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_EmployeeDiscount fd = new Frm_EmployeeDiscount();
            fd.MdiParent = this;
            fd.Show();
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_EmpSarf frm_EmpSarf = new Frm_EmpSarf();
           frm_EmpSarf .MdiParent = this;
            frm_EmpSarf.Show();
        }

        private void barHeaderItem28_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_ReportEmployeeShift rm = new Frm_ReportEmployeeShift();
            rm.MdiParent = this;
            rm.Show();
        }

        private void barHeaderItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_ReportEmployeeSalary res = new Frm_ReportEmployeeSalary();
            res.MdiParent = this;
            res.Show();
        }

        private void barHeaderItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_ReportEmployeeDiscount ed = new Frm_ReportEmployeeDiscount();
            ed.MdiParent = this;
            ed.Show();
        }

        private void barHeaderItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_ReportEmployeeSalf ES = new Frm_ReportEmployeeSalf();
            ES.MdiParent = this;
            ES.Show();
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_DoctorOfCenter frm_DoctorOfCenter = new Frm_DoctorOfCenter();
            frm_DoctorOfCenter.MdiParent = this;
            frm_DoctorOfCenter.Show();
        }

        private void barHeaderItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_ReportDoctorOfCenterData frdocd = new Frm_ReportDoctorOfCenterData();
            frdocd.MdiParent = this;
            frdocd.Show();
        }

        private void barHeaderItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_ReportOfDoctorOfCenter frm_ReportOfDoctorOfCenter = new Frm_ReportOfDoctorOfCenter();
            frm_ReportOfDoctorOfCenter.MdiParent = this;
            frm_ReportOfDoctorOfCenter.Show();
        }

        private void barHeaderItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_AllCasesDoctorOfCenter facdoc = new Frm_AllCasesDoctorOfCenter();
            facdoc.MdiParent = this;
            facdoc.Show();
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_Techincal frm_Techincal = new Frm_Techincal();
            frm_Techincal.MdiParent = this;
            frm_Techincal.Show();
        }

        private void barHeaderItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_ReportTechnicalData frtd = new Frm_ReportTechnicalData();
            frtd.MdiParent = this;
            frtd.ShowDialog();
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_AddTechnicalShift fats = new Frm_AddTechnicalShift();
            fats.MdiParent = this;
            fats.ShowDialog();
        }

        private void barHeaderItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_ReportTechnicalShift frts = new Frm_ReportTechnicalShift();
            frts.MdiParent = this;
            frts.ShowDialog();
        }

        private void barHeaderItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_Report_DetailsTechnical frm_Report_Technical = new Frm_Report_DetailsTechnical();
            frm_Report_Technical.MdiParent = this;
            frm_Report_Technical.Show();
        }

        private void barHeaderItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_AllXrayTechnical faxt = new Frm_AllXrayTechnical();
            faxt.MdiParent = this;
            faxt.Show();
        }

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_Company frm_Company = new Frm_Company();
            frm_Company.MdiParent = this;
            frm_Company.Show();
        }

        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem16_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_PayCompanyMoney fpcm = new Frm_PayCompanyMoney();
            fpcm.MdiParent = this;
            fpcm.Show();
        }

        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_DebitCompany fdcas = new Frm_DebitCompany();
            fdcas.MdiParent = this;
            fdcas.Show();
        }

        private void barButtonItem41_ItemClick(object sender, ItemClickEventArgs e)
        {

            Frm_PayCompany pc = new Frm_PayCompany();
            pc.MdiParent = this;
            pc.Show();
        }

        private void barHeaderItem29_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_ReportPAyCustomerCompany frpcc = new Frm_ReportPAyCustomerCompany();
            frpcc.MdiParent = this;
            frpcc.Show();
        }

        private void barButtonItem38_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_Customer fc = new Frm_Customer();
            fc.MdiParent = this;
            fc.Show();
        }

        private void barButtonItem39_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_PayClient frm_PayClient = new Frm_PayClient();
            frm_PayClient.MdiParent = this;
            frm_PayClient.Show();
        }

        private void barButtonItem40_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_DebitCustomer fdc = new Frm_DebitCustomer();
            fdc.MdiParent = this;
            fdc.Show();
        }

        private void barHeaderItem27_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_ReportAllPayOfCustomer frapc = new Frm_ReportAllPayOfCustomer();
            frapc.MdiParent = this;
            frapc.Show();
        }

        private void barButtonItem35_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_Tickets frm_Tickets = new Frm_Tickets();
            frm_Tickets.MdiParent = this;
            frm_Tickets.Show();
        }

        private void barButtonItem36_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_ManagmentTickets frm_Managment = new Frm_ManagmentTickets();
            frm_Managment.MdiParent = this;
            frm_Managment.Show();
        }

        private void barButtonItem37_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_Search_Ticket frm_Search_Ticket = new Frm_Search_Ticket();
            frm_Search_Ticket.MdiParent = this;
            frm_Search_Ticket.Show();
        }

        private void barHeaderItem26_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_ReportTransferForCompany tc = new Frm_ReportTransferForCompany();
            tc.MdiParent = this;
            tc.Show();
        }

        private void barButtonItem16_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            Frm_PayCompanyMoney fpcm = new Frm_PayCompanyMoney();
            fpcm.MdiParent = this;
            fpcm.Show();
        }

        private void barHeaderItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_AllPAyCompsny fapc = new Frm_AllPAyCompsny();
            fapc.MdiParent = this;
            fapc.Show();
        }

        private void barButtonItem14_ItemClick_1(object sender, ItemClickEventArgs e)
        {
        //Frm_CompanyItemXray frm_CompanyItem = new Frm_CompanyItemXray();
        //   frm_CompanyItem.ShowDialog();
        }

        private void barButtonItem15_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            Frm_DebitCompany fdcas = new Frm_DebitCompany();
            fdcas.MdiParent = this;
            fdcas.Show();
        }

        private void barButtonItem18_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_Doctor frm_Doctor = new Frm_Doctor();
            frm_Doctor.MdiParent = this;
            frm_Doctor.Show();
        }

        private void barHeaderItem15_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_ReportOutDoctorData frodd = new Frm_ReportOutDoctorData();
            frodd.MdiParent = this;
            frodd.Show();
        }

        private void barHeaderItem16_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_ReportDoctor frm_ReportDoctor = new Frm_ReportDoctor();
            frm_ReportDoctor.MdiParent = this;
            frm_ReportDoctor.Show();
        }

        private void barHeaderItem17_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_AllCasesOFOutDoctor facod = new Frm_AllCasesOFOutDoctor();
            facod.MdiParent = this;
            facod.Show();
        }

        private void barButtonItem19_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_Masrofat frm_Masrofat = new Frm_Masrofat();
           frm_Masrofat .MdiParent = this;
            frm_Masrofat.Show();
        }

        private void barHeaderItem18_ItemClick(object sender, ItemClickEventArgs e)
        {

            Frm_ReportMasrofat frm_ReportMasrofat = new Frm_ReportMasrofat();
            frm_ReportMasrofat.MdiParent = this;
            frm_ReportMasrofat.Show();
        }

        private void barButtonItem20_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_AddStock fas = new frm_AddStock();
            fas.MdiParent = this;
            fas.Show();
        }

        private void barButtonItem21_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_StockPull fsp = new Frm_StockPull();
            fsp.MdiParent = this;
            fsp.Show();
        }

        private void barButtonItem22_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_AddStockMoney fasm = new frm_AddStockMoney();
            fasm.MdiParent = this;
            fasm.Show();
        }

        private void barButtonItem23_ItemClick(object sender, ItemClickEventArgs e)
        {

            Frm_StockTransfair fst = new Frm_StockTransfair();
            fst.MdiParent = this;
            fst.Show();
        }

        private void barHeaderItem19_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_ReportInsertStock frm_Is = new Frm_ReportInsertStock();
            frm_Is.MdiParent = this;
            frm_Is.Show();
        }

        private void barHeaderItem20_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_ReportTransfairStock frts = new Frm_ReportTransfairStock();
            frts.MdiParent = this;
            frts.Show();
        }

        private void barButtonItem34_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_installment i = new Frm_installment();
            i.MdiParent = this;
            i.Show();
        }

        private void barHeaderItem25_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_Mansgmentinstallment fmi = new Frm_Mansgmentinstallment();
            fmi.MdiParent = this;
            fmi.Show();
        }

        private void barButtonItem24_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_AddStore frm_AddStore = new Frm_AddStore();
            frm_AddStore.MdiParent = this;
            frm_AddStore.Show();
        }

        private void barButtonItem25_ItemClick(object sender, ItemClickEventArgs e)
        {
            Add_Product add_Product = new Add_Product();
            add_Product.MdiParent = this;
            add_Product.Show();
        }

        private void barButtonItem26_ItemClick(object sender, ItemClickEventArgs e)
        {
            Add_StoreProduct Asp = new Add_StoreProduct();
            Asp.MdiParent = this;
            Asp.Show();
        }

        private void barButtonItem27_ItemClick(object sender, ItemClickEventArgs e)
        {
            Tranfair_product tranfair_Product = new Tranfair_product();
            tranfair_Product.MdiParent = this;
            tranfair_Product.Show();
        }

        private void barButtonItem28_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_Order frm_Order = new Frm_Order();
            frm_Order.MdiParent = this;
            frm_Order.Show();
        }

        private void barButtonItem29_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_Purshasing frm_Purshasing = new Frm_Purshasing();
            frm_Purshasing.MdiParent = this;
            frm_Purshasing.Show();
        }

        private void barButtonItem30_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_ReturnSupplier frs = new Frm_ReturnSupplier();
            frs.MdiParent = this;
            frs.Show();
        }

        private void barHeaderItem22_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_ReportTransfairProduct tp = new Frm_ReportTransfairProduct();
            tp.MdiParent = this;
            tp.Show();
        }

        private void barHeaderItem21_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_ReportPurshasesInvoice pi = new Frm_ReportPurshasesInvoice();
            pi.MdiParent = this;
            pi.Show();
        }

        private void barButtonItem31_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_Suppliers frm_Suppliers = new Frm_Suppliers();
            frm_Suppliers.MdiParent = this;
            frm_Suppliers.Show();
        }

        private void barButtonItem32_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_PaySuppliers frm_PaySuppliers = new Frm_PaySuppliers();
            frm_PaySuppliers.MdiParent = this;
            frm_PaySuppliers.Show();
        }

        private void barButtonItem33_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_DebitSuppliers frm_Debit = new Frm_DebitSuppliers();
            frm_Debit.MdiParent = this;
            frm_Debit.Show();
        }

        private void barHeaderItem24_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_ReportPaySuppliers frm_ReportPaySuppliers = new Frm_ReportPaySuppliers();
            frm_ReportPaySuppliers.MdiParent = this;
            frm_ReportPaySuppliers.Show();
        }

        private void barButtonItem43_ItemClick(object sender, ItemClickEventArgs e)
        {
            Validate_Users validate = new Validate_Users();
            validate.MdiParent = this;
            validate.Show();
        }

        private void barButtonItem42_ItemClick(object sender, ItemClickEventArgs e)
        {

            Frm_ManagmentUser frm_ManagmentUser = new Frm_ManagmentUser();
            frm_ManagmentUser.MdiParent = this;
            frm_ManagmentUser.Show();
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            barStaticItem7.Caption = Program.salesman;
            accordionControlElement2.Text= Program.salesman;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            barStaticItem5.Caption = DateTime.Now.ToString();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
           
           
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
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
            FingerPrint fs = new FingerPrint();
            fs.ShowDialog();
        }

        private void barButtonItem5_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            Frm_reportFinger rp = new Frm_reportFinger();
            rp.ShowDialog();
        }

        private void accordionControlElement6_Click_1(object sender, EventArgs e)
        {
            Frm_PayCompany pc = new Frm_PayCompany();
            pc.MdiParent = this;
            pc.Show();
        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {
            Frm_Customer fc = new Frm_Customer();
            fc.MdiParent = this;
            fc.Show();
        }

        private void accordionControlElement8_Click(object sender, EventArgs e)
        {
            Frm_Tickets frm_Tickets = new Frm_Tickets();
            frm_Tickets.MdiParent = this;
            frm_Tickets.Show();
        }

        private void accordionControlElement9_Click(object sender, EventArgs e)
        {
            Frm_ManagmentTickets frm_Managment = new Frm_ManagmentTickets();
            frm_Managment.MdiParent = this;
            frm_Managment.Show();
        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement1_Click_1(object sender, EventArgs e)
        {

        }
    }
    }
    
