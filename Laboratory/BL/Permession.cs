using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Laboratory.DAL;
namespace Laboratory.BL
{
    class Permession
    {
        internal void Add_UserBAsicInformation(string User_Name, int Add_Employee, int Add_Employee_Branch, int Add_Branch, 
            int add_CategoryXray, int Add_Xrays,int Download_Finger,int Report_Finger)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[8];
            param[0] = new SqlParameter("@User_Name", SqlDbType.NVarChar, 100);
            param[0].Value = User_Name;
            param[1] = new SqlParameter("@Add_Employee", SqlDbType.Int);
            param[1].Value = Add_Employee;
            param[2] = new SqlParameter("@Add_Employee_Branch", SqlDbType.Int);
            param[2].Value = Add_Employee_Branch;
            param[3] = new SqlParameter("@Add_Branch", SqlDbType.Int);
            param[3].Value = Add_Branch;
            param[4] = new SqlParameter("@Add_CategoryXray", SqlDbType.Int);
            param[4].Value = add_CategoryXray;
            param[5] = new SqlParameter("@Add_Xray", SqlDbType.Int);
            param[5].Value = Add_Xrays;
            param[6] = new SqlParameter("@Download_Finger", SqlDbType.Int);
            param[6].Value = Download_Finger;
            param[7] = new SqlParameter("@Report_Finger", SqlDbType.Int);
            param[7].Value = Report_Finger;
            da.excutequery("Add_UserBAsicInformation", param);
            da.close();

        }

        internal DataTable Select_UserBAsicInformation(string User_Name)
        {
            DataAccessLayer da = new DataAccessLayer();

            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@User_Name", SqlDbType.NVarChar, 100);
            param[0].Value = User_Name;
            DataTable dt = new DataTable();
            dt = da.selected("Select_UserBAsicInformation", param);

            return dt;

        }
        internal void Update_UserBAsicInformation(string User_Name, int Add_Employee, int Add_Employee_Branch, int Add_Branch,
              int add_CategoryXray, int Add_Xrays, int Download_Finger, int Report_Finger)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[8];
            param[0] = new SqlParameter("@User_Name", SqlDbType.NVarChar, 100);
            param[0].Value = User_Name;
            param[1] = new SqlParameter("@Add_Employee", SqlDbType.Int);
            param[1].Value = Add_Employee;
            param[2] = new SqlParameter("@Add_Employee_Branch", SqlDbType.Int);
            param[2].Value = Add_Employee_Branch;
            param[3] = new SqlParameter("@Add_Branch", SqlDbType.Int);
            param[3].Value = Add_Branch;
            param[4] = new SqlParameter("@Add_CategoryXray", SqlDbType.Int);
            param[4].Value = add_CategoryXray;
            param[5] = new SqlParameter("@Add_Xray", SqlDbType.Int);
            param[5].Value = Add_Xrays;
            param[6] = new SqlParameter("@Download_Finger", SqlDbType.Int);
            param[6].Value = Download_Finger;
            param[7] = new SqlParameter("@Report_Finger", SqlDbType.Int);
            param[7].Value = Report_Finger;
            da.excutequery("Update_UserBAsicInformation", param);
            da.close();

        }
        internal void Add_UserEmployee(string User_Name, int Add_Shift_Emolpyee, int Add_DiscountEmployee, int Add_Salf, 
            int Add_Mortbat, int Report_Employee,int DoctorOfCenter , int Report_DoctorOfCenter 
            , int Add_Technical , int Add_Shift_Technical, int Report_Technical)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[11];
            param[0] = new SqlParameter("@User_Name", SqlDbType.NVarChar, 100);
            param[0].Value = User_Name;
            param[1] = new SqlParameter("@Add_Shift_Emolpyee", SqlDbType.Int);
            param[1].Value = Add_Shift_Emolpyee;
            param[2] = new SqlParameter("@Add_DiscountEmployee", SqlDbType.Int);
            param[2].Value = Add_DiscountEmployee;
            param[3] = new SqlParameter("@Add_Salf", SqlDbType.Int);
            param[3].Value = Add_Salf;
    
            param[4] = new SqlParameter("@Add_Mortbat", SqlDbType.Int);
            param[4].Value = Add_Mortbat;
            param[5] = new SqlParameter("@Report_Employee", SqlDbType.Int);
            param[5].Value = Report_Employee;
            
            param[6] = new SqlParameter("@Add_DoctorOfCenter", SqlDbType.Int);
            param[6].Value = DoctorOfCenter;
            param[7] = new SqlParameter("@Report_DoctorOfCenter", SqlDbType.Int);
            param[7].Value = Report_DoctorOfCenter;
            param[8] = new SqlParameter("@Add_Technical", SqlDbType.Int);
            param[8].Value = Add_Technical;
            param[9] = new SqlParameter("@Add_Shift_Technical", SqlDbType.Int);
            param[9].Value = Add_Shift_Technical;
            param[10] = new SqlParameter("@Report_Technical", SqlDbType.Int);
            param[10].Value = Report_Technical;
            da.excutequery("Add_UserEmployee", param);
            da.close();
        }
        internal void Update_UserEmployee(string User_Name, int Add_Shift_Emolpyee, int Add_DiscountEmployee, int Add_Salf,
            int Add_Mortbat, int Report_Employee, int DoctorOfCenter, int Report_DoctorOfCenter
            , int Add_Technical, int Add_Shift_Technical, int Report_Technical)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[11];
            param[0] = new SqlParameter("@User_Name", SqlDbType.NVarChar, 100);
            param[0].Value = User_Name;
            param[1] = new SqlParameter("@Add_Shift_Emolpyee", SqlDbType.Int);
            param[1].Value = Add_Shift_Emolpyee;
            param[2] = new SqlParameter("@Add_DiscountEmployee", SqlDbType.Int);
            param[2].Value = Add_DiscountEmployee;
            param[3] = new SqlParameter("@Add_Salf", SqlDbType.Int);
            param[3].Value = Add_Salf;

            param[4] = new SqlParameter("@Add_Mortbat", SqlDbType.Int);
            param[4].Value = Add_Mortbat;
            param[5] = new SqlParameter("@Report_Employee", SqlDbType.Int);
            param[5].Value = Report_Employee;

            param[6] = new SqlParameter("@Add_DoctorOfCenter", SqlDbType.Int);
            param[6].Value = DoctorOfCenter;
            param[7] = new SqlParameter("@Report_DoctorOfCenter", SqlDbType.Int);
            param[7].Value = Report_DoctorOfCenter;
            param[8] = new SqlParameter("@Add_Technical", SqlDbType.Int);
            param[8].Value = Add_Technical;
            param[9] = new SqlParameter("@Add_Shift_Technical", SqlDbType.Int);
            param[9].Value = Add_Shift_Technical;
            param[10] = new SqlParameter("@Report_Technical", SqlDbType.Int);
            param[10].Value = Report_Technical;
            da.excutequery("Update_UserEmployee", param);
            da.close();
        }
        internal DataTable Select_UserEmployee(string User_Name)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@User_Name", SqlDbType.NVarChar, 100);
            param[0].Value = User_Name;
            DataTable dt = new DataTable();
            dt = da.selected("Select_UserEmployee", param);
            return dt;
        }

        internal void AddUserCompany(string User_Name, int Add_Company, int Add_itemCompany, int Depit_Company,
            int pay_Company, int Report_Company, int Add_DoctorOut, int Report_DoctorOut)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[8];
            param[0] = new SqlParameter("@User_Name", SqlDbType.NVarChar, 100);
            param[0].Value = User_Name;
            param[1] = new SqlParameter("@Add_Company", SqlDbType.Int);
            param[1].Value = Add_Company;
            param[2] = new SqlParameter("@Add_itemCompany", SqlDbType.Int);
            param[2].Value = Add_itemCompany;
            param[3] = new SqlParameter("@Depit_Company", SqlDbType.Int);
            param[3].Value = Depit_Company;

            param[4] = new SqlParameter("@pay_Company", SqlDbType.Int);
            param[4].Value = pay_Company;
            param[5] = new SqlParameter("@Report_Company", SqlDbType.Int);
            param[5].Value = Report_Company;

            param[6] = new SqlParameter("@Add_DoctorOut", SqlDbType.Int);
            param[6].Value = Add_DoctorOut;
            param[7] = new SqlParameter("@Report_DoctorOut", SqlDbType.Int);
            param[7].Value = Report_DoctorOut;
     
            da.excutequery("AddUserCompany", param);
            da.close();
        }
        internal DataTable SelectUserCompany(string User_Name)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@User_Name", SqlDbType.NVarChar, 100);
            param[0].Value = User_Name;
            DataTable dt = new DataTable();
            dt = da.selected("SelectUserCompany", param);
            return dt;
        }
        internal void UpdateUserCompany(string User_Name, int Add_Company, int Add_itemCompany, int Depit_Company,
         int pay_Company, int Report_Company, int Add_DoctorOut, int Report_DoctorOut)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[8];
            param[0] = new SqlParameter("@userName", SqlDbType.NVarChar, 100);
            param[0].Value = User_Name;
            param[1] = new SqlParameter("@Add_Company", SqlDbType.Int);
            param[1].Value = Add_Company;
            param[2] = new SqlParameter("@Add_itemCompany", SqlDbType.Int);
            param[2].Value = Add_itemCompany;
            param[3] = new SqlParameter("@Depit_Company", SqlDbType.Int);
            param[3].Value = Depit_Company;

            param[4] = new SqlParameter("@pay_Company", SqlDbType.Int);
            param[4].Value = pay_Company;
            param[5] = new SqlParameter("@Report_Company", SqlDbType.Int);
            param[5].Value = Report_Company;

            param[6] = new SqlParameter("@Add_DoctorOut", SqlDbType.Int);
            param[6].Value = Add_DoctorOut;
            param[7] = new SqlParameter("@Report_DoctorOut", SqlDbType.Int);
            param[7].Value = Report_DoctorOut;

            da.excutequery("UpdateUserCompany", param);
            da.close();
        }
        internal void AddUserAccount(string userName, int Add_Masrofat, int Report_Masrofat, int Add_Stock,
  int Pull_Stock, int Insert_Stock, int Transfer_Stock, int Report_Stock,int Add_Instalment,int Report_Instalment)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[10];
            param[0] = new SqlParameter("@userName", SqlDbType.NVarChar, 100);
            param[0].Value = userName;
            param[1] = new SqlParameter("Add_Masrofat", SqlDbType.Int);
            param[1].Value = Add_Masrofat;
            param[2] = new SqlParameter("@Report_Masrofat", SqlDbType.Int);
            param[2].Value = Report_Masrofat;
            param[3] = new SqlParameter("@Add_Stock", SqlDbType.Int);
            param[3].Value = Add_Stock;

            param[4] = new SqlParameter("@Pull_Stock", SqlDbType.Int);
            param[4].Value = Pull_Stock;
            param[5] = new SqlParameter("@Insert_Stock", SqlDbType.Int);
            param[5].Value = Insert_Stock;

            param[6] = new SqlParameter("@Transfer_Stock", SqlDbType.Int);
            param[6].Value = Transfer_Stock;
            param[7] = new SqlParameter("@Report_Stock", SqlDbType.Int);
            param[7].Value = Report_Stock;
            param[8] = new SqlParameter("@Add_Instalment", SqlDbType.Int);
            param[8].Value = Add_Instalment;
            param[9] = new SqlParameter("@Report_Instalment", SqlDbType.Int);
            param[9].Value = Report_Instalment;
            da.excutequery("AddUserAccount", param);
            da.close();
        }
        internal void UpdateUserAccount(string userName, int Add_Masrofat, int Report_Masrofat, int Add_Stock,
int Pull_Stock, int Insert_Stock, int Transfer_Stock, int Report_Stock, int Add_Instalment, int Report_Instalment)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[10];
            param[0] = new SqlParameter("@userName", SqlDbType.NVarChar, 100);
            param[0].Value = userName;
            param[1] = new SqlParameter("@Add_Masrofat", SqlDbType.Int);
            param[1].Value = Add_Masrofat;
            param[2] = new SqlParameter("@Report_Masrofat", SqlDbType.Int);
            param[2].Value = Report_Masrofat;
            param[3] = new SqlParameter("@Add_Stock", SqlDbType.Int);
            param[3].Value = Add_Stock;

            param[4] = new SqlParameter("@Pull_Stock", SqlDbType.Int);
            param[4].Value = Pull_Stock;
            param[5] = new SqlParameter("@Insert_Stock", SqlDbType.Int);
            param[5].Value = Insert_Stock;

            param[6] = new SqlParameter("@Transfer_Stock", SqlDbType.Int);
            param[6].Value = Transfer_Stock;
            param[7] = new SqlParameter("@Report_Stock", SqlDbType.Int);
            param[7].Value = Report_Stock;
            param[8] = new SqlParameter("@Add_Instalment", SqlDbType.Int);
            param[8].Value = Add_Instalment;
            param[9] = new SqlParameter("@Report_Instalment", SqlDbType.Int);
            param[9].Value = Report_Instalment;
            da.excutequery("UpdateUserAccount", param);
            da.close();
        }
        internal DataTable SelectUserAccount(string User_Name)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@User_Name", SqlDbType.NVarChar, 100);
            param[0].Value = User_Name;
            DataTable dt = new DataTable();
            dt = da.selected("SelectUserAccount", param);
            return dt;
        }
        internal void AddUser_Store(string User_Name, int Add_Store, int Add_Proudect, int Add_ProudectINStore,
int Transfer_Store, int @items_consumption, int Report_Store, int INvoice_purchise, int Return_Purchise, int Report_Purchise, int Add_Suppliers, int Pay_Suppliers,
int Depit_Suppliers, int Report_Suppliers)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[14];
            param[0] = new SqlParameter("@User_Name", SqlDbType.NVarChar, 100);
            param[0].Value = User_Name;
            param[1] = new SqlParameter("@Add_Store", SqlDbType.Int);
            param[1].Value = Add_Store;
            param[2] = new SqlParameter("@Add_Proudect", SqlDbType.Int);
            param[2].Value = Add_Proudect;
            param[3] = new SqlParameter("@Add_ProudectINStore", SqlDbType.Int);
            param[3].Value = Add_ProudectINStore;


            param[4] = new SqlParameter("@Transfer_Store", SqlDbType.Int);
            param[4].Value = Transfer_Store;
            param[5] = new SqlParameter("@items_consumption", SqlDbType.Int);
            param[5].Value = items_consumption;
            param[6] = new SqlParameter("@Report_Store", SqlDbType.Int);
            param[6].Value = Report_Store;

            param[7] = new SqlParameter("@INvoice_purchise", SqlDbType.Int);
            param[7].Value = INvoice_purchise;
            param[8] = new SqlParameter("@Return_Purchise", SqlDbType.Int);
            param[8].Value = Return_Purchise;
            param[9] = new SqlParameter("@Report_Purchise", SqlDbType.Int);
            param[9].Value = Report_Purchise;
            param[10] = new SqlParameter("@Add_Suppliers", SqlDbType.Int);
            param[10].Value = Add_Suppliers;
            param[11] = new SqlParameter("@Pay_Suppliers", SqlDbType.Int);
            param[11].Value = Pay_Suppliers;
            param[12] = new SqlParameter("@Depit_Suppliers", SqlDbType.Int);
            param[12].Value = Depit_Suppliers;
            param[13] = new SqlParameter("@Report_Suppliers", SqlDbType.Int);
            param[13].Value = Report_Suppliers;

            da.excutequery("AddUser_Store", param);
            da.close();
        }
        internal void UpdateUser_Store(string User_Name, int Add_Store, int Add_Proudect, int Add_ProudectINStore,
int Transfer_Store,int @items_consumption, int Report_Store, int INvoice_purchise, int Return_Purchise, int Report_Purchise, int Add_Suppliers, int Pay_Suppliers,
int Depit_Suppliers, int Report_Suppliers)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[14];
            param[0] = new SqlParameter("@User_Name", SqlDbType.NVarChar, 100);
            param[0].Value = User_Name;
            param[1] = new SqlParameter("@Add_Store", SqlDbType.Int);
            param[1].Value = Add_Store;
            param[2] = new SqlParameter("@Add_Proudect", SqlDbType.Int);
            param[2].Value = Add_Proudect;
            param[3] = new SqlParameter("@Add_ProudectINStore", SqlDbType.Int);
            param[3].Value = Add_ProudectINStore;

          
            param[4] = new SqlParameter("@Transfer_Store", SqlDbType.Int);
            param[4].Value = Transfer_Store;
            param[5] = new SqlParameter("@items_consumption", SqlDbType.Int);
            param[5].Value = items_consumption;
            param[6] = new SqlParameter("@Report_Store", SqlDbType.Int);
            param[6].Value = Report_Store;

            param[7] = new SqlParameter("@INvoice_purchise", SqlDbType.Int);
            param[7].Value = INvoice_purchise;
            param[8] = new SqlParameter("@Return_Purchise", SqlDbType.Int);
            param[8].Value = Return_Purchise;
            param[9] = new SqlParameter("@Report_Purchise", SqlDbType.Int);
            param[9].Value = Report_Purchise;
            param[10] = new SqlParameter("@Add_Suppliers", SqlDbType.Int);
            param[10].Value = Add_Suppliers;
            param[11] = new SqlParameter("@Pay_Suppliers", SqlDbType.Int);
            param[11].Value = Pay_Suppliers;
            param[12] = new SqlParameter("@Depit_Suppliers", SqlDbType.Int);
            param[12].Value = Depit_Suppliers;
            param[13] = new SqlParameter("@Report_Suppliers", SqlDbType.Int);
            param[13].Value = Report_Suppliers;

            da.excutequery("UpdateUser_Store", param);
            da.close();
        }
        internal DataTable selectUser_Store(string User_Name)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@User_Name", SqlDbType.NVarChar, 100);
            param[0].Value = User_Name;
            DataTable dt = new DataTable();
            dt = da.selected("selectUser_Store", param);
            return dt;
        }

        internal void AddUser_Tickets(string User_Name, int Add_Tickets, int Managment_Tickets, int Search_Tickets,
                                      int Add_Clients, int Pay_Clients,  int Depit_Client, int Report_Depit)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[8];
            param[0] = new SqlParameter("@User_Name", SqlDbType.NVarChar, 100);
            param[0].Value = User_Name;
            param[1] = new SqlParameter("@Add_Tickets", SqlDbType.Int);
            param[1].Value = Add_Tickets;
            param[2] = new SqlParameter("@Managment_Tickets", SqlDbType.Int);
            param[2].Value = Managment_Tickets;
            param[3] = new SqlParameter("@Search_Tickets", SqlDbType.Int);
            param[3].Value = Search_Tickets;

            param[4] = new SqlParameter("@Add_Clients", SqlDbType.Int);
            param[4].Value = Add_Clients;
            param[5] = new SqlParameter("@Pay_Clients", SqlDbType.Int);
            param[5].Value = Pay_Clients;

            param[6] = new SqlParameter("@Depit_Client", SqlDbType.Int);
            param[6].Value = Depit_Client;
            param[7] = new SqlParameter("@Report_Depit", SqlDbType.Int);
            param[7].Value = Report_Depit;
       
            da.excutequery("AddUser_Tickets", param);
            da.close();
        }
        internal DataTable selecTUserTickets(string User_Name)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@User_Name", SqlDbType.NVarChar, 100);
            param[0].Value = User_Name;
            DataTable dt = new DataTable();
            dt = da.selected("selecTUserTickets", param);
            return dt;
        }

        internal void UpdateUser_Tickets(string User_Name, int Add_Tickets, int Managment_Tickets, int Search_Tickets,
                                         int Add_Clients, int Pay_Clients, int Depit_Client, int Report_Depit)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[8];
            param[0] = new SqlParameter("@User_Name", SqlDbType.NVarChar, 100);
            param[0].Value = User_Name;
            param[1] = new SqlParameter("@Add_Tickets", SqlDbType.Int);
            param[1].Value = Add_Tickets;
            param[2] = new SqlParameter("@Managment_Tickets", SqlDbType.Int);
            param[2].Value = Managment_Tickets;
            param[3] = new SqlParameter("@Search_Tickets", SqlDbType.Int);
            param[3].Value = Search_Tickets;

            param[4] = new SqlParameter("@Add_Clients", SqlDbType.Int);
            param[4].Value = Add_Clients;
            param[5] = new SqlParameter("@Pay_Clients", SqlDbType.Int);
            param[5].Value = Pay_Clients;

            param[6] = new SqlParameter("@Depit_Client", SqlDbType.Int);
            param[6].Value = Depit_Client;
            param[7] = new SqlParameter("@Report_Depit", SqlDbType.Int);
            param[7].Value = Report_Depit;



            da.excutequery("UpdateUser_Tickets", param);
            da.close();
        }
        internal DataTable selectUser_Permission(string User_Name)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@User_Name", SqlDbType.NVarChar, 100);
            param[0].Value = User_Name;
            DataTable dt = new DataTable();
            dt = da.selected("selectUser_Permission", param);
            return dt;
        }

        internal void AddUser_Permission(string User_Name, int Create_account, int permission)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[9];
            param[0] = new SqlParameter("@User_Name", SqlDbType.NVarChar, 100);
            param[0].Value = User_Name;
            param[1] = new SqlParameter("@Create_account", SqlDbType.Int);
            param[1].Value = Create_account;
            param[2] = new SqlParameter("@permission", SqlDbType.Int);
            param[2].Value = permission;
       



            da.excutequery("AddUser_Permission", param);
            da.close();
        }

        internal void UpdateUser_Permission(string User_Name, int Create_account, int permission)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@User_Name", SqlDbType.NVarChar, 100);
            param[0].Value = User_Name;
            param[1] = new SqlParameter("@Create_account", SqlDbType.Int);
            param[1].Value = Create_account;
            param[2] = new SqlParameter("@permission", SqlDbType.Int);
            param[2].Value = permission;




            da.excutequery("UpdateUser_Permission", param);
            da.close();
        }
    }
}
