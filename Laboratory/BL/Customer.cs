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
    class Customer
    {
        internal void addCustomer(string name, string address, string phone,int age,DateTime Start_Date)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 150);
            param[0].Value = name;
            param[1] = new SqlParameter("@address", SqlDbType.NVarChar, 100);
            param[1].Value = address;
            param[2] = new SqlParameter("@phone", SqlDbType.VarChar, 20);
            param[2].Value = phone;
          
            param[3] = new SqlParameter("@age", SqlDbType.TinyInt);
            param[3].Value = age;
            param[4] = new SqlParameter("@Start_Date", SqlDbType.DateTime);
            param[4].Value = Start_Date;


            da.excutequery("AddCustomer", param);
            da.close();
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
        internal void UpdateCustomer(string name, string address, string phone, int age, int id)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 150);
            param[0].Value = name;
            param[1] = new SqlParameter("@address", SqlDbType.NVarChar, 100);
            param[1].Value = address;
            param[2] = new SqlParameter("@phone", SqlDbType.VarChar, 20);
            param[2].Value = phone;
       
            param[3] = new SqlParameter("@age", SqlDbType.TinyInt);
            param[3].Value = age;
            param[4] = new SqlParameter("@id", SqlDbType.Int);
            param[4].Value = id;
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
    }
}
