using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laboratory.DAL;
using System.Data;
using System.Data.SqlClient;

namespace Laboratory.BL
{
    class Company
    {
        internal void AddCompany(string name, string phone,string address,DateTime StartDate,string notes )
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 250);
            param[0].Value = name;

            param[1] = new SqlParameter("@phone", SqlDbType.VarChar, 50);
            param[1].Value = phone;

            param[2] = new SqlParameter("@address", SqlDbType.NVarChar, 250);
            param[2].Value = address;

            param[3] = new SqlParameter("@StartDate", SqlDbType.DateTime);
            param[3].Value = StartDate;

            param[4] = new SqlParameter("@notes", SqlDbType.NVarChar,750);
            param[4].Value = notes;
            da.excutequery("AddCompany", param);           
            da.close();
        }
        internal DataTable SelectCompany()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            dt = da.selected("SelectCompany", null);
            da.close();
            return dt;
        }
        internal DataTable CompoCompany()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            dt = da.selected("CompoCompany", null);
            da.close();
            return dt;
        }
      
        internal DataTable SearchCompany(string name)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 300);
            param[0].Value = name;

            dt = da.selected("SearchCompany", param);
            da.close();
            return dt;
        }
        internal void UpdateCompany(string name, string phone, int id, string address,string notes)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 300);
            param[0].Value = name;

            param[1] = new SqlParameter("@phone", SqlDbType.VarChar, 100);
            param[1].Value = phone;
  
            param[2] = new SqlParameter("@id", SqlDbType.Int);
            param[2].Value = id;
            param[3] = new SqlParameter("@address", SqlDbType.NVarChar, 250);
            param[3].Value = address;
            param[4] = new SqlParameter("@notes", SqlDbType.NVarChar, 750);
            param[4].Value = notes;
            da.excutequery("UpdateCompany", param);
            da.close();


        }
        internal DataTable selectCompanyRent()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            dt = da.selected("selectCompanyRent", null);
            da.close();
            return dt;
        }
        internal void addPayCustomerCompany(int ID_company, decimal pay, decimal rent, DateTime pay_date, int id_ticket,
                                            int IDStock,string Sales_man , int Id_Branch , string Cust_Name)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[9];
            param[0] = new SqlParameter("@ID_company", SqlDbType.Int);
            param[0].Value = ID_company;
            param[1] = new SqlParameter("@pay", SqlDbType.Decimal);
            param[1].Value = pay;
            param[2] = new SqlParameter("@rent", SqlDbType.Decimal);
            param[2].Value = rent;
            param[3] = new SqlParameter("@date_pay", SqlDbType.DateTime);
            param[3].Value = pay_date;
            param[4] = new SqlParameter("@id_ticket", SqlDbType.Int);
            param[4].Value = id_ticket;
            param[5] = new SqlParameter("@IDStock", SqlDbType.Int);
            param[5].Value = IDStock;
            param[6] = new SqlParameter("@sales_Man", SqlDbType.NVarChar, 100);
            param[6].Value = Sales_man;
            param[7] = new SqlParameter("@Id_Branch", SqlDbType.Int);
            param[7].Value = Id_Branch;
            param[8] = new SqlParameter("@Cust_Name", SqlDbType.NVarChar,100);
            param[8].Value = Cust_Name;
            da.excutequery("addPayCustomerCompany", param);
            da.close();
        }
        internal DataTable selectOneCompanytRent(int id_company)
        {
            DataAccessLayer da = new DataAccessLayer();
            DataTable dt = new DataTable();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id_company", SqlDbType.Int);
            param[0].Value = id_company;
            dt = da.selected("selectOneCompanytRent", param);
            da.close();
            return dt;


        }
        internal DataTable SelectRentCompoCompany()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            dt = da.selected("SelectRentCompoCompany", null);
            da.close();
            return dt;
        }
        internal DataTable searchOneCompanytRent(string id ,int id_company)
        {
            DataAccessLayer da = new DataAccessLayer();
            DataTable dt = new DataTable();
            da.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@id", SqlDbType.NVarChar,50);
            param[0].Value = id;
            param[1] = new SqlParameter("@id_company", SqlDbType.Int);
            param[1].Value = id_company;
            dt = da.selected("searchOneCompanytRent", param);
            da.close();
            return dt;


        }
        internal DataTable SelectDiscount(int id_company)
        {
            DataAccessLayer da = new DataAccessLayer();
            DataTable dt = new DataTable();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@idcompany", SqlDbType.Int);
            param[0].Value = id_company;
            dt = da.selected("SelectDiscount", param);
            da.close();
            return dt;
        }
        internal void Add_Company_ItemsXray(int ID_Company, int ID_Item,decimal discount , decimal Price)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@Id_Company", SqlDbType.Int);
            param[0].Value = ID_Company;
            param[1] = new SqlParameter("@Id_ItemXrays", SqlDbType.Int);
            param[1].Value = ID_Item;
            param[2] = new SqlParameter("@discount", SqlDbType.Decimal);
            param[2].Value = discount;
            param[3] = new SqlParameter("@Price", SqlDbType.Decimal);
            param[3].Value = Price;
            da.excutequery("Add_Company_ItemsXray", param);
            da.close();
        }
        internal void Update_Company_Xray(int ID_Company, int ID_Item, decimal discount,decimal Price)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@Id_Company", SqlDbType.Int);
            param[0].Value = ID_Company;
            param[1] = new SqlParameter("@Id_ItemXrays", SqlDbType.Int);
            param[1].Value = ID_Item;
            param[2] = new SqlParameter("@discount", SqlDbType.Decimal);
            param[2].Value = discount;
            param[3] = new SqlParameter("@Price", SqlDbType.Decimal);
            param[3].Value = Price;
            da.excutequery("Update_Company_Xray", param);
            da.close();
        }
        internal DataTable Select_Company_Xray()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            dt = da.selected("Select_Company_Xray", null);
            da.close();
            return dt;
        }
        internal DataTable Search_Company_Xray(string id_company)
        {
            DataAccessLayer da = new DataAccessLayer();
            DataTable dt = new DataTable();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.NVarChar,100);
            param[0].Value = id_company;
            dt = da.selected("Search_Company_Xray", param);
            da.close();
            return dt;
        }

        internal DataTable Select_PriceXrayCompany(int id_company , int Id_Xray )
        {
            DataAccessLayer da = new DataAccessLayer();
            DataTable dt = new DataTable();
            da.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@id_Compnay", SqlDbType.Int);
            param[0].Value = id_company;
            param[1] = new SqlParameter("@id_Xray", SqlDbType.Int);
            param[1].Value = Id_Xray;
            dt = da.selected("Select_PriceXrayCompany", param);
            da.close();
            return dt;
        }
        internal DataTable Select_DebitCompany(int id_company)
        {
            DataAccessLayer da = new DataAccessLayer();
            DataTable dt = new DataTable();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id_Company", SqlDbType.Int);
            param[0].Value = id_company;

            dt = da.selected("Select_DebitCompany", param);
            da.close();
            return dt;
        }
        internal DataTable Search_DebitCompany(int id_company ,DateTime Date_From , DateTime Date_To)
        {
            DataAccessLayer da = new DataAccessLayer();
            DataTable dt = new DataTable();
            da.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@id_Company", SqlDbType.Int);
            param[0].Value = id_company;
            param[1] = new SqlParameter("@Date_From", SqlDbType.DateTime);
            param[1].Value = Date_From;
            param[2] = new SqlParameter("@Date_To", SqlDbType.DateTime);
            param[2].Value = Date_To;
            dt = da.selected("Search_DebitCompany", param);
            da.close();
            return dt;
        }
        internal void Add_CompanyTotalMoney(int Id_company)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id_Company", SqlDbType.Int);
            param[0].Value = Id_company;
            da.excutequery("Add_CompanyTotalMoney", param);
            da.close();
        }
        internal void Update_CompanyTotalMoney(int Id_company,decimal Total_money)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@id_Company", SqlDbType.Int);
            param[0].Value = Id_company;
            param[1] = new SqlParameter("@Total_money", SqlDbType.Decimal);
            param[1].Value = Total_money;
            da.excutequery("Update_CompanyTotalMoney", param);
            da.close();
        }
        internal DataTable select_LastIdCompany()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            dt = da.selected("select_LastIdCompany", null);
            da.close();
            return dt;
        }
        internal DataTable SelectAllCompanyMoney()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            dt = da.selected("SelectAllCompanyMoney", null);
            da.close();
            return dt;
        }
        internal DataTable SelectOneCompanyMoney(int Id_Company)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Id_Company", SqlDbType.Int);
            param[0].Value = Id_Company;
            dt = da.selected("SelectOneCompanyMoney", param);
            da.close();
            return dt;
        }
        internal DataTable Select_CompanyTotalMoney(int Id_Company)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Id_Company", SqlDbType.Int);
            param[0].Value = Id_Company;
            dt = da.selected("Select_CompanyTotalMoney", param);
            da.close();
            return dt;
        }
        internal void ADD_Company_TotalRent(int ID_company, decimal Da2n, decimal Maden, DateTime pay_date, 
                                         decimal Balance, string Elbyan, int IDStock, int Id_Branch, string Sales_man)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[9];
            param[0] = new SqlParameter("@ID_Company", SqlDbType.Int);
            param[0].Value = ID_company;
            param[1] = new SqlParameter("@Da2n", SqlDbType.Decimal);
            param[1].Value = Da2n;
            param[2] = new SqlParameter("@Maden", SqlDbType.Decimal);
            param[2].Value = Maden;
            param[3] = new SqlParameter("@date_pay", SqlDbType.DateTime);
            param[3].Value = pay_date;
            param[4] = new SqlParameter("@Balance", SqlDbType.Decimal);
            param[4].Value = Balance;
            param[5] = new SqlParameter("@Elbyan", SqlDbType.NVarChar, 200);
            param[5].Value = Elbyan;
            param[6] = new SqlParameter("@Id_Stock", SqlDbType.Int);
            param[6].Value = IDStock;
            param[7] = new SqlParameter("@Id_Branch", SqlDbType.Int);
            param[7].Value = Id_Branch;
            param[8] = new SqlParameter("@Sales_Man", SqlDbType.NVarChar,100);
            param[8].Value = Sales_man;
            da.excutequery("ADD_Company_TotalRent", param);
            da.close();
        }
        internal DataTable Validate_CompanyNAme(int Id_Company)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Id_Company", SqlDbType.Int);
            param[0].Value = Id_Company;
            dt = da.selected("Validate_CompanyNAme", param);
            da.close();
            return dt;
        }
        internal DataTable Select_AllpAyOfCompany(int id_company)
        {
            DataAccessLayer da = new DataAccessLayer();
            DataTable dt = new DataTable();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Id_Company", SqlDbType.Int);
            param[0].Value = id_company;
            dt = da.selected("Select_AllpAyOfCompany", param);
            da.close();
            return dt;        
        }
        internal DataTable Search_AllpAyOfCompany(int id_company, DateTime Date_From, DateTime Date_To)
        {
            DataAccessLayer da = new DataAccessLayer();
            DataTable dt = new DataTable();
            da.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@Id_Company", SqlDbType.Int);
            param[0].Value = id_company;
            param[1] = new SqlParameter("@Date_From", SqlDbType.Date);
            param[1].Value = Date_From;
            param[2] = new SqlParameter("@Date_To", SqlDbType.Date);
            param[2].Value = Date_To;
            dt = da.selected("Search_AllpAyOfCompany", param);
            da.close();
            return dt;
        }
        internal DataTable Select_DetailsCompany(int id_company)
        {
            DataAccessLayer da = new DataAccessLayer();
            DataTable dt = new DataTable();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id_Company", SqlDbType.Int);
            param[0].Value = id_company;
            dt = da.selected("Select_DetailsCompany", param);
            da.close();
            return dt;
        }
        internal void Delect_CompanyItem(int ID_company, int Id_Item)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@ID_Company", SqlDbType.Int);
            param[0].Value = ID_company;
            param[1] = new SqlParameter("@Id_Item", SqlDbType.Int);
            param[1].Value = Id_Item;

            da.excutequery("Delect_CompanyItem", param);
            da.close();
        }

        internal DataTable selectXrayCompanyTransfer(int Id_company, int idItem)
        {
            DataAccessLayer da = new DataAccessLayer();
            DataTable dt = new DataTable();
            da.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@idcompany", SqlDbType.Int);
            param[0].Value = Id_company;
            param[1] = new SqlParameter("@idItem", SqlDbType.Int);
            param[1].Value = idItem;
            dt = da.selected("selectXrayCompanyTransfer", param);
            da.close();
            return dt;
        }

        internal DataTable selectItemCompany(int Id_Company,int iditem)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@idcompany", SqlDbType.Int);
            param[0].Value = Id_Company;
            param[1] = new SqlParameter("@iditem", SqlDbType.Int);
            param[1].Value = iditem;
            dt = da.selected("selectItemCompany", param);
            da.close();
            return dt;
        }
    }
}
