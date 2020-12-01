using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laboratory.DAL;
using System.Data;
using System.Data.SqlClient;
using DevExpress.ClipboardSource.SpreadsheetML;

namespace Laboratory.BL
{
    class Customer
    {
        internal DataTable addCustomer(string name, string address, string phone,int age,DateTime Start_Date,string gender,string ID_Ntional)
        {
            DataAccessLayer da = new DataAccessLayer();
            DataTable dt = new DataTable();
            da.open();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 150);
            param[0].Value = name;
            param[1] = new SqlParameter("@address", SqlDbType.NVarChar, 100);
            param[1].Value = address;
            param[2] = new SqlParameter("@phone", SqlDbType.VarChar, 20);
            param[2].Value = phone;
          
            param[3] = new SqlParameter("@age", SqlDbType.Int);
            param[3].Value = age;
            param[4] = new SqlParameter("@Start_Date", SqlDbType.DateTime);
            param[4].Value = Start_Date;
            param[5] = new SqlParameter("@gender", SqlDbType.NVarChar,50);
            param[5].Value = gender;
            param[6] = new SqlParameter("@ID_Ntional", SqlDbType.VarChar, 100);
            param[6].Value = ID_Ntional;

         dt  = da.selected("AddCustomer", param);
            da.close();
            return dt;
        }
        internal DataTable SelectCustomer()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            dt = da.selected("SelectCustomer", null);
            da.close();
            return dt;
        }
        internal DataTable Report_PayCustomer()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            dt = da.selected("Report_PayCustomer", null);
            da.close();
            return dt;
        }
        internal DataTable search_PayCustomer(string id)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.NVarChar, 50);
            param[0].Value = id;

            dt = da.selected("search_PayCustomer", param);
            da.close();
            return dt;
        }
    
        internal DataTable SearchCustomer(string name)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 100);
            param[0].Value = name;

            dt = da.selected("SearchCustomer", param);
            da.close();
            return dt;
        }
        internal void UpdateCustomer(string name, string address, string phone, int age, int id,string gender,string ID_Ntional)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 150);
            param[0].Value = name;
            param[1] = new SqlParameter("@address", SqlDbType.NVarChar, 100);
            param[1].Value = address;
            param[2] = new SqlParameter("@phone", SqlDbType.VarChar, 20);
            param[2].Value = phone;
       
            param[3] = new SqlParameter("@age", SqlDbType.Int);
            param[3].Value = age;
            param[4] = new SqlParameter("@id", SqlDbType.Int);
            param[4].Value = id;
            param[5] = new SqlParameter("@gender", SqlDbType.NVarChar, 50);
            param[5].Value = gender;
            param[6] = new SqlParameter("@ID_Ntional", SqlDbType.VarChar, 100);
            param[6].Value = ID_Ntional;
            da.excutequery("UpdateCustomer", param);
            da.close();
        }

        internal DataTable SelectCompoCustomer()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            dt = da.selected("SelectCompoCustomer", null);
            da.close();
            return dt;
        }
        internal DataTable SelectCompoCustomerN2dy()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            dt = da.selected("SelectCompoCustomerN2dy", null);
            da.close();
            return dt;
        }
        internal DataTable SelectCompoCustomerCompany()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            dt = da.selected("SelectCompoCustomerN2dy", null);
            da.close();
            return dt;
        }
        internal DataTable SelectDataCompoCustomer(int id)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id_Cust", SqlDbType.Int);
            param[0].Value = id;

            dt = da.selected("SelectDataCompoCustomer", param);
            da.close();
            return dt;
        }
        internal DataTable LastIdCustomer()
        {
            DataTable dt = new DataTable();
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            dt = da.selected("LastIdCustomer", null);
            da.close();
            return dt;
        }
        internal DataTable selectClientRent()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            dt = da.selected("selectClientRent", null);
            da.close();
            return dt;
        }
        internal void addPayClient(int id_client, decimal pay, string branch, string Sales_Man,
                                   DateTime pay_date, int Id_Item,int ID_Tickets,decimal discount)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[8];
            param[0] = new SqlParameter("@IdCustomer", SqlDbType.Int);
            param[0].Value = id_client;
            param[1] = new SqlParameter("@PayMoney", SqlDbType.Decimal);
            param[1].Value = pay;
            param[2] = new SqlParameter("@Branch", SqlDbType.NVarChar,50);
            param[2].Value = branch;
            param[3] = new SqlParameter("@SalesMan", SqlDbType.NVarChar,50);
            param[3].Value = Sales_Man;
            param[4] = new SqlParameter("@DatePay", SqlDbType.Date);
            param[4].Value = pay_date;
            param[5] = new SqlParameter("@ID_Item", SqlDbType.Int);
            param[5].Value = Id_Item;
            param[6] = new SqlParameter("@ID_Tickets", SqlDbType.Int);
            param[6].Value = ID_Tickets;
            param[7] = new SqlParameter("@Discount", SqlDbType.Decimal);
            param[7].Value = discount;
            da.excutequery("addPayClient", param);
            da.close();
        }
        internal void Add_CustomerTotalBalance(int Id_Customer)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Id_Customer", SqlDbType.Int);
            param[0].Value = Id_Customer;          
            da.excutequery("Add_CustomerTotalBalance", param);
            da.close();
        }
        internal void Update_CustomerTotalBalance(int  Id_Customer, decimal Total_Rent)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@Id_Customer", SqlDbType.Int);
            param[0].Value = Id_Customer;
            param[1] = new SqlParameter("@Total_Balance", SqlDbType.Decimal);
            param[1].Value = Total_Rent;
            da.excutequery("Update_CustomerTotalBalance", param);
            da.close();
        }
        internal void Add_CustomerAccountStatment(int id_client, decimal Da2n, decimal Maden, DateTime pay_date, decimal Balance,
                                                    int IDStock, string Sales_Man, int Id_Branch,string ElByan)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[9];
            param[0] = new SqlParameter("@Id_Customer", SqlDbType.Int);
            param[0].Value = id_client;
            param[1] = new SqlParameter("@Da2n", SqlDbType.Decimal);
            param[1].Value = Da2n;
            param[2] = new SqlParameter("@Maden", SqlDbType.Decimal);
            param[2].Value = Maden;
            param[3] = new SqlParameter("@date_pay", SqlDbType.DateTime);
            param[3].Value = pay_date;
            param[4] = new SqlParameter("@Balance", SqlDbType.Decimal);
            param[4].Value = Balance;
            param[5] = new SqlParameter("@id_Stock", SqlDbType.Int);
            param[5].Value = IDStock;
            param[6] = new SqlParameter("@sales_Man", SqlDbType.NVarChar, 100);
            param[6].Value = Sales_Man;
            param[7] = new SqlParameter("@Id_Branch", SqlDbType.Int);
            param[7].Value = Id_Branch;
            param[8] = new SqlParameter("@El_Byan", SqlDbType.NVarChar,250);
            param[8].Value = ElByan;
            da.excutequery("Add_CustomerAccountStatment", param);
            da.close();
        }
        internal DataTable Select_CustomertotalBAlance(int Id_Customer)
        {
            DataAccessLayer da = new DataAccessLayer();
            DataTable dt = new DataTable();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id_Customer", SqlDbType.Int);
            param[0].Value = Id_Customer;
            dt = da.selected("Select_CustomertotalBAlance", param);
            da.close();
            return dt;
        }
        internal DataTable selectOneClientRent(int id)
        {
            DataAccessLayer da = new DataAccessLayer();
            DataTable dt = new DataTable();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id_customer", SqlDbType.Int);
            param[0].Value = id;
            dt = da.selected("selectOneClientRent", param);
            da.close();
            return dt;
        }
        internal DataTable SelectTicketsForCustomer(int id)
        {
            DataAccessLayer da = new DataAccessLayer();
            DataTable dt = new DataTable();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Id_Customer", SqlDbType.Int);
            param[0].Value = id;
            dt = da.selected("SelectTicketsForCustomer", param);
            da.close();
            return dt;
        }
        internal DataTable SelectRentCompoCustomer()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            dt = da.selected("SelectRentCompoCustomer", null);
            da.close();
            return dt;
        }
        internal DataTable SelectCreditCompoCustomer()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            dt = da.selected("SelectCreditCompoCustomer", null);
            da.close();
            return dt;
        }
        internal DataTable Select_AllPayCustomerCompany()
        {
            DataTable dt = new DataTable();
            DataAccessLayer da = new DataAccessLayer();
            dt.Clear();
            da.open();
            dt = da.selected("Select_AllPayCustomerCompany", null);
            da.close();
            return dt;
        }

        internal DataTable Search_AllPayCustomerCompany(string id)
        {
            DataTable dt = new DataTable();
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Id", SqlDbType.NVarChar,100);
            param[0].Value = id;
            dt = da.selected("Search_AllPayCustomerCompany", param);
            da.close();
            return dt;
        }
        internal DataTable Search_AllPayCustomerCompanyDate(DateTime Date_From, DateTime Date_To)
        {
            DataTable dt = new DataTable();
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@From_Date", SqlDbType.Date);
            param[0].Value = Date_From;
            param[1] = new SqlParameter("@To_Date", SqlDbType.Date);
            param[1].Value = Date_To;
            dt = da.selected("Search_AllPayCustomerCompanyDate", param);
            da.close();
            return dt;
        }
        internal DataTable Search_AllPayCustomerCompanyDateAndName(string id, DateTime Date_From, DateTime Date_To)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@Id", SqlDbType.NVarChar, 100);
            param[0].Value = id;
            param[1] = new SqlParameter("@From_Date", SqlDbType.Date);
            param[1].Value = Date_From;
            param[2] = new SqlParameter("@To_Date", SqlDbType.Date);
            param[2].Value = Date_To;
            dt = da.selected("Search_AllPayCustomerCompanyDateAndName", param);
            da.close();
            return dt;
        }
        internal DataTable Select_AllPayCustomer(int Id_Customer)
        {
            DataTable dt = new DataTable();
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Id_Cust", SqlDbType.Int);
            param[0].Value = Id_Customer;
            dt = da.selected("Select_AllPayCustomer", param);
            da.close();
            return dt;
        }
        internal DataTable Search_AllPayCustomer(string id)
        {
            DataTable dt = new DataTable();
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Id", SqlDbType.NVarChar, 100);
            param[0].Value = id;
            dt = da.selected("Search_AllPayCustomer", param);
            da.close();
            return dt;
        }
        internal DataTable Search_AllPayCustomerDate(DateTime Date_From, DateTime Date_To)
        {
            DataTable dt = new DataTable();
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@From_Date", SqlDbType.Date);
            param[0].Value = Date_From;
            param[1] = new SqlParameter("@To_Date", SqlDbType.Date);
            param[1].Value = Date_To;
            dt = da.selected("Search_AllPayCustomerDate", param);
            da.close();
            return dt;
        }

        internal DataTable Search_AllPayCustomerNameanddate(int Id_Customer, DateTime Date_From, DateTime Date_To)
        {
            DataTable dt = new DataTable();
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@Id_Customer", SqlDbType.Int);
            param[0].Value = Id_Customer;
            param[1] = new SqlParameter("@From_Date", SqlDbType.Date);
            param[1].Value = Date_From;
            param[2] = new SqlParameter("@To_Date", SqlDbType.Date);
            param[2].Value = Date_To;
            dt = da.selected("Search_AllPayCustomerNameanddate", param);
            da.close();
            return dt;
        }
        internal DataTable validate_CustomerName(int id)
        {
            DataTable dt = new DataTable();
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Id_Cust", SqlDbType.Int);
            param[0].Value = id;
            dt = da.selected("validate_CustomerName", param);
            da.close();
            return dt;
        }

        internal DataTable SelectCustomerPay(int idStock, DateTime Date_From, DateTime Date_To)
        {
            DataTable dt = new DataTable();
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@idStock", SqlDbType.Int);
            param[0].Value = idStock;
            param[1] = new SqlParameter("@from", SqlDbType.Date);
            param[1].Value = Date_From;
            param[2] = new SqlParameter("@To", SqlDbType.Date);
            param[2].Value = Date_To;
            dt = da.selected("SelectCustomerPay", param);
            da.close();
            return dt;
        }
    }
}
