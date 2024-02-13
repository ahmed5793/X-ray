using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Tourism_Company.DAL;
namespace Tourism_Company.BL
{
    class Permession
    {
        internal void Add_UserBAsicInformation(string id, int add_customer, int add_company, int add_plan, int pay_cust)
        {
            DataAcssesLayer da = new DataAcssesLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            param[0].Value = id;
            param[1] = new SqlParameter("@Add_customer", SqlDbType.Int);
            param[1].Value = add_customer;
            param[2] = new SqlParameter("@Add_company", SqlDbType.Int);
            param[2].Value = add_company;
            param[3] = new SqlParameter("@Add_Paln", SqlDbType.Int);
            param[3].Value = add_plan;
            param[4] = new SqlParameter("@Pay_Comstomer", SqlDbType.Int);
            param[4].Value = pay_cust;
            da.excutequery("Add_UserBAsicInformation", param);
            da.close();

        }

        internal DataTable select_UserBAsicInformation(string id)
        {
            DataAcssesLayer da = new DataAcssesLayer();

            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            param[0].Value = id;
            DataTable dt = new DataTable();
            dt = da.selected("select_UserBAsicInformation", param);

            return dt;

        }
        internal void Update_UserBAsicInformation(string id, int add_customer, int add_company, int add_plan, int pay_cust)
        {

            DataAcssesLayer da = new DataAcssesLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            param[0].Value = id;
            param[1] = new SqlParameter("@Add_customer", SqlDbType.Int);
            param[1].Value = add_customer;
            param[2] = new SqlParameter("@Add_company", SqlDbType.Int);
            param[2].Value = add_company;
            param[3] = new SqlParameter("@Add_Paln", SqlDbType.Int);
            param[3].Value = add_plan;
            param[4] = new SqlParameter("@Pay_Comstomer", SqlDbType.Int);
            param[4].Value = pay_cust;
            da.excutequery("Update_UserBAsicInformation", param);
            da.close();
        }
        internal void Add_UserBookingTickets(string id, int booking , int AllTicket)
        {
            DataAcssesLayer da = new DataAcssesLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            param[0].Value = id;
            param[1] = new SqlParameter("@booking", SqlDbType.Int);
            param[1].Value = booking;
            param[2] = new SqlParameter("@All_ticket", SqlDbType.Int);
            param[2].Value = AllTicket;
       
            da.excutequery("Add_UserBookingTickets", param);
            da.close();

        }
        internal DataTable Select_UserBookingTickets(string id)
        {
            DataAcssesLayer da = new DataAcssesLayer();

            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            param[0].Value = id;
            DataTable dt = new DataTable();
            dt = da.selected("Select_UserBookingTickets", param);

            return dt;

        }
        internal void Update_UserBookingTickets(string id, int booking, int AllTicket)
        {

            DataAcssesLayer da = new DataAcssesLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            param[0].Value = id;
            param[1] = new SqlParameter("@booking", SqlDbType.Int);
            param[1].Value = booking;
            param[2] = new SqlParameter("@All_ticket", SqlDbType.Int);
            param[2].Value = AllTicket;
            da.excutequery("Update_UserBookingTickets", param);
            da.close();
        }

        internal void Delete_UserBookingTickets(string id)
        {
            DataAcssesLayer da = new DataAcssesLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            param[0].Value = id;
            da.excutequery("Delete_UserBookingTickets", param);
            da.close();
        }
        internal void Delete_Users_basicInformation(string id)
        {
            DataAcssesLayer da = new DataAcssesLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            param[0].Value = id;
            da.excutequery("Delete_Users_basicInformation", param);
            da.close();
        }
        internal void Add_UserArba7andMasrofat(string id, int add_Masrof, int All_Masrofat, int arba7)
        {
            DataAcssesLayer da = new DataAcssesLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            param[0].Value = id;
            param[1] = new SqlParameter("@Add_Masrof", SqlDbType.Int);
            param[1].Value = add_Masrof;
            param[2] = new SqlParameter("@All_masrofat", SqlDbType.Int);
            param[2].Value = All_Masrofat;
            param[3] = new SqlParameter("@arba7", SqlDbType.Int);
            param[3].Value = arba7;
         
            da.excutequery("Add_UserArba7andMasrofat", param);
            da.close();

        }
        internal void Update_UserArba7andMasrofat(string id, int add_Masrof, int All_Masrofat, int arba7)
        {
            DataAcssesLayer da = new DataAcssesLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            param[0].Value = id;
            param[1] = new SqlParameter("@Add_Masrof", SqlDbType.Int);
            param[1].Value = add_Masrof;
            param[2] = new SqlParameter("@All_masrofat", SqlDbType.Int);
            param[2].Value = All_Masrofat;
            param[3] = new SqlParameter("@arba7", SqlDbType.Int);
            param[3].Value = arba7;

            da.excutequery("Update_UserArba7andMasrofat", param);
            da.close();

        }
        internal void Delete_UserArba7andMasrofat(string id)
        {
            DataAcssesLayer da = new DataAcssesLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            param[0].Value = id;
            da.excutequery("Delete_UserArba7andMasrofat", param);
            da.close();
        }
        internal DataTable Select_UserArba7andMasrofat(string id)
        {
            DataAcssesLayer da = new DataAcssesLayer();

            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            param[0].Value = id;
            DataTable dt = new DataTable();
            dt = da.selected("Select_UserArba7andMasrofat", param);

            return dt;

        }
        internal void AddUsers_BankStock(string id, int add_Stock, int add_Bank, int Insert_Stock, int insert_bank,int Pull_Stock , int Pull_Bank,int transfair_stock,int Transfair_StockToBank,int transfairBankToStock,int Report_insertStock,int Report_insertBank,int Report_pullStock, int Report_pullBank)
        {
            DataAcssesLayer da = new DataAcssesLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[14];
            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            param[0].Value = id;
            param[1] = new SqlParameter("@add_stock", SqlDbType.Int);
            param[1].Value = add_Stock;
            param[2] = new SqlParameter("@add_bank", SqlDbType.Int);
            param[2].Value = add_Bank;
            param[3] = new SqlParameter("@insert_Stock", SqlDbType.Int);
            param[3].Value = Insert_Stock;
            param[4] = new SqlParameter("@insert_bank", SqlDbType.Int);
            param[4].Value = insert_bank;
            param[5] = new SqlParameter("@pull_Stock", SqlDbType.Int);
            param[5].Value = Pull_Stock;
            param[6] = new SqlParameter("@pull_bank", SqlDbType.Int);
            param[6].Value = Pull_Bank;
            param[7] = new SqlParameter("@transfair_Stock", SqlDbType.Int);
            param[7].Value = transfair_stock;
            param[8] = new SqlParameter("@transfair_StockToBank", SqlDbType.Int);
            param[8].Value = Transfair_StockToBank;
            param[9] = new SqlParameter("@Transfair_BankToStock", SqlDbType.Int);
            param[9].Value = transfairBankToStock;
            param[10] = new SqlParameter("@Report_insertStock", SqlDbType.Int);
            param[10].Value = Report_insertStock;
            param[11] = new SqlParameter("@Report_InsertBAnk", SqlDbType.Int);
            param[11].Value = Report_insertBank;
            param[12] = new SqlParameter("@Report_PullStock", SqlDbType.Int);
            param[12].Value = Report_pullStock;
            param[13] = new SqlParameter("@Report_PullBAnk", SqlDbType.Int);
            param[13].Value = Report_pullBank;

            da.excutequery("AddUsers_BankStock", param);
            da.close();

        }
        internal void UpdateUsers_BankStock(string id, int add_Stock, int add_Bank, int Insert_Stock, int insert_bank, int Pull_Stock, int Pull_Bank, int transfair_stock, int Transfair_StockToBank, int transfairBankToStock, int Report_insertStock, int Report_insertBank, int Report_pullStock, int Report_pullBank)
        {
            DataAcssesLayer da = new DataAcssesLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[14];
            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            param[0].Value = id;
            param[1] = new SqlParameter("@add_stock", SqlDbType.Int);
            param[1].Value = add_Stock;
            param[2] = new SqlParameter("@add_bank", SqlDbType.Int);
            param[2].Value = add_Bank;
            param[3] = new SqlParameter("@insert_Stock", SqlDbType.Int);
            param[3].Value = Insert_Stock;
            param[4] = new SqlParameter("@insert_bank", SqlDbType.Int);
            param[4].Value = insert_bank;
            param[5] = new SqlParameter("@pull_Stock", SqlDbType.Int);
            param[5].Value = Pull_Stock;
            param[6] = new SqlParameter("@pull_bank", SqlDbType.Int);
            param[6].Value = Pull_Bank;
            param[7] = new SqlParameter("@transfair_Stock", SqlDbType.Int);
            param[7].Value = transfair_stock;
            param[8] = new SqlParameter("@transfair_StockToBank", SqlDbType.Int);
            param[8].Value = Transfair_StockToBank;
            param[9] = new SqlParameter("@Transfair_BankToStock", SqlDbType.Int);
            param[9].Value = transfairBankToStock;
            param[10] = new SqlParameter("@Report_insertStock", SqlDbType.Int);
            param[10].Value = Report_insertStock;
            param[11] = new SqlParameter("@Report_InsertBAnk", SqlDbType.Int);
            param[11].Value = Report_insertBank;
            param[12] = new SqlParameter("@Report_PullStock", SqlDbType.Int);
            param[12].Value = Report_pullStock;
            param[13] = new SqlParameter("@Report_PullBAnk", SqlDbType.Int);
            param[13].Value = Report_pullBank;

            da.excutequery("UpdateUsers_BankStock", param);
            da.close();

        }
        internal void DeleteUsers_BankStock(string id)
        {
            DataAcssesLayer da = new DataAcssesLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            param[0].Value = id;
            da.excutequery("DeleteUsers_BankStock", param);
            da.close();
        }
        internal DataTable SelectUsers_BankStock(string id)
        {
            DataAcssesLayer da = new DataAcssesLayer();

            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            param[0].Value = id;
            DataTable dt = new DataTable();
            dt = da.selected("SelectUsers_BankStock", param);

            return dt;

        }
        internal void AddUser_Permssion(string id, int Manage_user, int User_permssion)
        {
            DataAcssesLayer da = new DataAcssesLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            param[0].Value = id;
            param[1] = new SqlParameter("@Manage_Users", SqlDbType.Int);
            param[1].Value = Manage_user;
            param[2] = new SqlParameter("@User_Permssion", SqlDbType.Int);
            param[2].Value = User_permssion;

            da.excutequery("AddUser_Permssion", param);
            da.close();

        }
        internal DataTable SelectUser_Permssion(string id)
        {
            DataAcssesLayer da = new DataAcssesLayer();

            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            param[0].Value = id;
            DataTable dt = new DataTable();
            dt = da.selected("SelectUser_Permssion", param);

            return dt;

        }
        internal void UpdateUser_Permssion(string id, int Manage_user, int User_permssion)
        {

            DataAcssesLayer da = new DataAcssesLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            param[0].Value = id;
            param[1] = new SqlParameter("@Manage_Users", SqlDbType.Int);
            param[1].Value = Manage_user;
            param[2] = new SqlParameter("@User_Permssion", SqlDbType.Int);
            param[2].Value = User_permssion;
            da.excutequery("UpdateUser_Permssion", param);
            da.close();
        }

        internal void DeleteUser_Permssion(string id)
        {
            DataAcssesLayer da = new DataAcssesLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            param[0].Value = id;
            da.excutequery("DeleteUser_Permssion", param);
            da.close();
        }
    }
}
