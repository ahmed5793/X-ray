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
    public partial class Frm_Main : Form
    {
        private static Frm_Main farm;

        static void STATUESCllosed(object sender, FormClosedEventArgs e)
        {
            farm = null;
        }
        public static Frm_Main getmain
        {
            get
            {
                if (farm == null)
                {
                    farm = new Frm_Main();
                    farm.FormClosed += new FormClosedEventHandler(STATUESCllosed);
                }
                return farm;
            }
        }
        Users u = new Users();
        public Frm_Main()
        {
            if (farm == null)
            {
                farm = this;
            }
            InitializeComponent();


        }

        private void hghjvmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void إضافةاصنافلمخزنToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void تحويلأصنافمنمخزنلمخزنToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Add_Store_Click(object sender, EventArgs e)
        {
            Frm_AddStore frm_AddStore = new Frm_AddStore();
            frm_AddStore.ShowDialog();
        }

        private void Add_Product_Click(object sender, EventArgs e)
        {
            Add_Product ap = new Add_Product();
            ap.ShowDialog();
        }

        private void Add_customer_Click(object sender, EventArgs e)
        {

        }

        private void Add_masrof_Click(object sender, EventArgs e)
        {
          
        }

        private void Add_Stock_Click(object sender, EventArgs e)
        {
            frm_AddStock fas = new frm_AddStock();
            fas.ShowDialog();
        }

        private void Stock_Pull_Click(object sender, EventArgs e)
        {
            Frm_StockPull fsp = new Frm_StockPull();
            fsp.ShowDialog();
        }

        private void Insert_Stock_Click(object sender, EventArgs e)
        {
            frm_AddStockMoney fasm = new frm_AddStockMoney();
            fasm.ShowDialog();
        }

        private void Stock_Transfair_Click(object sender, EventArgs e)
        {
            Frm_StockTransfair fst = new Frm_StockTransfair();
            fst.ShowDialog();
        }

        private void Add_Customer_Click_1(object sender, EventArgs e)
        {
            Frm_Customer fc = new Frm_Customer();
            fc.ShowDialog();
        }

        private void إضافةشركةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Company frm_Company = new Frm_Company();
            frm_Company.ShowDialog();

        }

        private void Add_Doctor_Click(object sender, EventArgs e)
        {
            Frm_Doctor frm_Doctor = new Frm_Doctor();

            frm_Doctor.Show();
        }

        private void Store_Management_ButtonClick(object sender, EventArgs e)
        {

        }

        private void Add_Employee_Click(object sender, EventArgs e)
        {
            Frm_Employee frm_Employee = new Frm_Employee();
            frm_Employee.Show();

        }

        private void السلفياتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Salf frm_Salf = new Frm_Salf();

            frm_Salf.Show();

        }

        private void صرفالمرتباتToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void Add_XRays_Click(object sender, EventArgs e)
        {
            Frm_ItemsXRaya frm_ItemsXRaya = new Frm_ItemsXRaya();

            frm_ItemsXRaya.Show();

        }

        private void Category_XRay_Click(object sender, EventArgs e)
        {
            Frm_CategoryXRaya frm_CategoryX = new Frm_CategoryXRaya();

            frm_CategoryX.Show();

        }

        private void Main_data_Click(object sender, EventArgs e)
        {

        }

        private void Add_Branche_Click(object sender, EventArgs e)
        {
            Frm_Branches frm_Branches = new Frm_Branches();
            frm_Branches.Show();

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void Add_Masrof_Click_1(object sender, EventArgs e)
        {
            Frm_Masrofat frm_Masrofat = new Frm_Masrofat();
            frm_Masrofat.Show();
        }

        private void Report_Masrofat_Click(object sender, EventArgs e)
        {
            Frm_ReportMasrofat frm_ReportMasrofat = new Frm_ReportMasrofat();
            frm_ReportMasrofat.ShowDialog();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
        }

        private void AddStore_Click(object sender, EventArgs e)
        {
            Frm_AddStore frm_AddStore = new Frm_AddStore();
            frm_AddStore.Show();
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            Add_Product add_Product = new Add_Product();
            add_Product.Show();
        }

        private void toolStripMenuItem3_Click_1(object sender, EventArgs e)
        {

        }

        private void Teicket_Click(object sender, EventArgs e)
        {
            Frm_Tickets frm_Tickets = new Frm_Tickets();
            frm_Tickets.ShowDialog();
        }

        private void Add_StoreProduct_Click(object sender, EventArgs e)
        {
            Add_StoreProduct Asp = new Add_StoreProduct();
            Asp.ShowDialog();
        }

        private void TransFairProduct_Click(object sender, EventArgs e)
        {
            Tranfair_product tranfair_Product = new Tranfair_product();
            tranfair_Product.ShowDialog();
        }

        private void Doctoer_Management_Click(object sender, EventArgs e)
        {

        }

        private void إنشاءحسابللموظفينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ManagmentUser frm_ManagmentUser = new Frm_ManagmentUser();
            frm_ManagmentUser.ShowDialog();
        }

        private void AddSupplier_Click(object sender, EventArgs e)
        {
            Frm_Suppliers frm_Suppliers = new Frm_Suppliers();
            frm_Suppliers.ShowDialog();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Sarf_Mortbat_Click(object sender, EventArgs e)
        {
            Frm_EmpSarf frm_EmpSarf = new Frm_EmpSarf();
            frm_EmpSarf.Show();
        }

        private void Doctors_Center_Click(object sender, EventArgs e)
        {
 
        }

        private void Techniqual_Click(object sender, EventArgs e)
        {
         
        }

        private void Pay_Customer_Click(object sender, EventArgs e)
        {
            Frm_PayClient frm_PayClient = new Frm_PayClient();
            frm_PayClient.ShowDialog();

        }

        private void Pay_Suppliers_Click(object sender, EventArgs e)
        {
            Frm_PaySuppliers frm_PaySuppliers = new Frm_PaySuppliers();
            frm_PaySuppliers.ShowDialog();
        }

        private void مديونيةالموردينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_DebitSuppliers frm_Debit = new Frm_DebitSuppliers();
            frm_Debit.ShowDialog();
        }

        private void Report_PaySupplier_Click(object sender, EventArgs e)
        {
            Frm_ReportPaySuppliers frm_ReportPaySuppliers = new Frm_ReportPaySuppliers();
            frm_ReportPaySuppliers.ShowDialog();
        }

        private void pay_company_Click(object sender, EventArgs e)
        {
            Frm_PayCompany pc = new Frm_PayCompany();
            pc.ShowDialog();
        }

        private void ConsumingProduct_Click(object sender, EventArgs e)
        {
            Frm_Order frm_Order = new Frm_Order();
            frm_Order.ShowDialog();


        }

        private void اضافةالموظفينللفروعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_AddEmployeeBranch employeeBranch = new Frm_AddEmployeeBranch();
            employeeBranch.ShowDialog();
        }

        private void PurshaseProduct_Click(object sender, EventArgs e)
        {
            Frm_Purshasing frm_Purshasing = new Frm_Purshasing();
            frm_Purshasing.ShowDialog();
        }

        private void Management_Ticket_Click(object sender, EventArgs e)
        {
            Frm_ManagmentTickets frm_Managment = new Frm_ManagmentTickets();
            frm_Managment.ShowDialog();
        }

        private void إضافةدكتورToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_DoctorOfCenter frm_DoctorOfCenter = new Frm_DoctorOfCenter();
            frm_DoctorOfCenter.ShowDialog();
        }

        private void Add_Technical_Click(object sender, EventArgs e)
        {
            Frm_Techincal frm_Techincal = new Frm_Techincal();
            frm_Techincal.ShowDialog();
        }

        private void Validate_Users_Click(object sender, EventArgs e)
        {
            Validate_Users validate = new Validate_Users();
            validate.ShowDialog();
        }

        private void Report_DoctorOfCenter_Click(object sender, EventArgs e)
        {
            Frm_ReportOfDoctorOfCenter frm_ReportOfDoctorOfCenter = new Frm_ReportOfDoctorOfCenter();
            frm_ReportOfDoctorOfCenter.ShowDialog();
        }

        private void بحثفىكلالحجوزاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Search_Ticket frm_Search_Ticket = new Frm_Search_Ticket();
            frm_Search_Ticket.ShowDialog();
        }

        private void Report_Technical_Click(object sender, EventArgs e)
        {
            Frm_Report_DetailsTechnical frm_Report_Technical = new Frm_Report_DetailsTechnical();
            frm_Report_Technical.ShowDialog();
        }

        private void Report_Doctor_Click(object sender, EventArgs e)
        {
            Frm_ReportDoctor frm_ReportDoctor = new Frm_ReportDoctor();
            frm_ReportDoctor.ShowDialog();
        }

        private void Report_PullMoneyStock_Click(object sender, EventArgs e)
        {
            Frm_ReportStockPull frm_ReportStock = new Frm_ReportStockPull();
            frm_ReportStock.ShowDialog();
        }

        private void Add_CompanyXrays_Click(object sender, EventArgs e)
        {
            Frm_CompanyItemXray frm_CompanyItem = new Frm_CompanyItemXray();
            frm_CompanyItem.ShowDialog();
        }

        private void Report_InsertStock_Click(object sender, EventArgs e)
        {
            Frm_ReportInsertStock frm_Is = new Frm_ReportInsertStock();
            frm_Is.ShowDialog();
        }

        private void Report_TransfairMoney_Click(object sender, EventArgs e)
        {
            Frm_ReportTransfairStock frts = new Frm_ReportTransfairStock();
            frts.ShowDialog();
        }

        private void Mardodat_Click(object sender, EventArgs e)
        {
            Frm_ReportTransferForCompany tc = new Frm_ReportTransferForCompany();
            tc.ShowDialog();

        }

        private void Debit_Company_Click(object sender, EventArgs e)
        {
            Frm_DebitCompany fdcas = new Frm_DebitCompany();
            fdcas.ShowDialog();
        }

        private void Pay_Company_Click_1(object sender, EventArgs e)
        {
            Frm_PayCompanyMoney fpcm = new Frm_PayCompanyMoney();
            fpcm.ShowDialog();
        }

        private void Report_PayCompany_Click(object sender, EventArgs e)
        {
            Frm_AllPAyCompsny fapc = new Frm_AllPAyCompsny();
            fapc.ShowDialog();
        }

        private void Report_PayCutomerCompany_Click(object sender, EventArgs e)
        {
            Frm_ReportPAyCustomerCompany frpcc = new Frm_ReportPAyCustomerCompany();
            frpcc.ShowDialog();
        }

        private void Report_PAyCustomer_Click(object sender, EventArgs e)
        {
            Frm_ReportAllPayOfCustomer frapc = new Frm_ReportAllPayOfCustomer();
            frapc.ShowDialog();
        }

        private void Debit_Customer_Click(object sender, EventArgs e)
        {
            Frm_DebitCustomer fdc = new Frm_DebitCustomer();
            fdc.ShowDialog();
        }

        private void Report_TotalXrayTechnical_Click(object sender, EventArgs e)
        {
            Frm_AllXrayTechnical faxt = new Frm_AllXrayTechnical();
            faxt.ShowDialog();
        }

        private void Report_AllCasesDoctorOFCenter_Click(object sender, EventArgs e)
        {
            Frm_AllCasesDoctorOfCenter facdoc = new Frm_AllCasesDoctorOfCenter();
            facdoc.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_AllCasesOFOutDoctor facod = new Frm_AllCasesOFOutDoctor();
            facod.ShowDialog();
        }

        private void Add_TechnicalShift_Click(object sender, EventArgs e)
        {
            Frm_AddTechnicalShift fats = new Frm_AddTechnicalShift();
            fats.ShowDialog();
        }

        private void Tool_ReprotTechnicalShift_Click(object sender, EventArgs e)
        {
            Frm_ReportTechnicalShift frts = new Frm_ReportTechnicalShift();
            frts.ShowDialog();
        }

        private void تسجيلالاقساطToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_installment i = new Frm_installment();
            i.ShowDialog();
        }

        private void ToolReportEmployeeData_Click(object sender, EventArgs e)
        {
            Frm_ReportEmployeeData FRED = new Frm_ReportEmployeeData();
            FRED.ShowDialog();
        }

        private void Tool_ReportDoctorOfCenterData_Click(object sender, EventArgs e)
        {
            Frm_ReportDoctorOfCenterData frdocd = new Frm_ReportDoctorOfCenterData();
            frdocd.ShowDialog();
        }

        private void Tool_ReportTechnecalData_Click(object sender, EventArgs e)
        {
            Frm_ReportTechnicalData frtd = new Frm_ReportTechnicalData();
            frtd.ShowDialog();
        }

        private void Tool_ReportDoctorData_Click(object sender, EventArgs e)
        {
            Frm_ReportOutDoctorData frodd = new Frm_ReportOutDoctorData();
            frodd.ShowDialog();
        }

        private void Tool_ReportInstallment_Click(object sender, EventArgs e)
        {
            Frm_Mansgmentinstallment fmi = new Frm_Mansgmentinstallment();
            fmi.ShowDialog();
        }

        private void ProductManage_Click(object sender, EventArgs e)
        {

        }

        private void Tool_ReturnPurshasing_Click(object sender, EventArgs e)
        {
            Frm_ReturnSupplier frs = new Frm_ReturnSupplier();
            frs.ShowDialog();
        }

        private void اضافةالشيفتاتللموظفينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_AddEmployeeShift AE = new Frm_AddEmployeeShift();
            AE.Show();
        }

        private void تقريرحسابشيفتاتالفنيينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ReportEmployeeShift rm = new Frm_ReportEmployeeShift();
            rm.Show();
        }

        private void تقريرعنصرفمرتباتالموظفينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ReportEmployeeSalary res = new Frm_ReportEmployeeSalary();
            res.Show();
        }

        private void Employee_Click(object sender, EventArgs e)
        {

        }

        private void Report_Salf_Click(object sender, EventArgs e)
        {
            Frm_ReportEmployeeSalf ES = new Frm_ReportEmployeeSalf();
            ES.Show();
        }

        private void خصوماتالموظفينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_EmployeeDiscount fd = new Frm_EmployeeDiscount();
            fd.Show();
        }

        private void ارسالالرسايلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void تقريرعنخصوماتالموظفينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ReportEmployeeDiscount ed = new Frm_ReportEmployeeDiscount();
            ed.Show();
        }

        private void التحكمفيجهازالبصمةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FingerPrint fp = new FingerPrint();
            fp.ShowDialog();
        }
    }
}
