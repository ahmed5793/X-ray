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
            SqlParameter[] param = new SqlParameter[6];
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
        internal void addPayCompany(int ID_company, decimal pay, decimal rent, DateTime pay_date, int id_ticket, int IDStock)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[6];
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

            da.excutequery("addPayCompany", param);
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
        internal void Add_Company_ItemsXray(int ID_Company, int ID_Item, decimal Price, decimal patient_Payment)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@Id_Company", SqlDbType.Int);
            param[0].Value = ID_Company;
            param[1] = new SqlParameter("@Id_ItemXrays", SqlDbType.Int);
            param[1].Value = ID_Item;
            param[2] = new SqlParameter("@Price", SqlDbType.Decimal);
            param[2].Value = Price;
            param[3] = new SqlParameter("@Patient_payment", SqlDbType.Decimal);
            param[3].Value = patient_Payment;
            da.excutequery("Add_Company_ItemsXray", param);
            da.close();
        }
        internal void Update_Company_Xray(int ID_Company, int ID_Item, decimal Price, decimal patient_Payment)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@Id_Company", SqlDbType.Int);
            param[0].Value = ID_Company;
            param[1] = new SqlParameter("@Id_ItemXrays", SqlDbType.Int);
            param[1].Value = ID_Item;
            param[2] = new SqlParameter("@Price", SqlDbType.Decimal);
            param[2].Value = Price;
            param[3] = new SqlParameter("@Patient_payment", SqlDbType.Decimal);
            param[3].Value = patient_Payment;
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
    }
}
