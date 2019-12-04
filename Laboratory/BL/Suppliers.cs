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
    class Suppliers
    {
        internal void addSuppliers(string name, string address, string phone)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            param[0].Value = name;
            param[1] = new SqlParameter("@address", SqlDbType.NVarChar, 50);
            param[1].Value = address;
            param[2] = new SqlParameter("@phone", SqlDbType.VarChar, 50);
            param[2].Value = phone;


            da.excutequery("addSuppliers", param);
            da.close();
        }
        internal DataTable SelectSuppliers()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();

            dt = da.selected("SelectSuppliers", null);
            da.close();
            return dt;
        }
        internal DataTable SearchSuppliers(string id)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.NVarChar, 50);
            param[0].Value = id;

            dt = da.selected("SearchSuppliers", param);
            da.close();
            return dt;
        }
        internal void UpdateSuppliers(string name, string address, string phone, int id)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            param[0].Value = name;
            param[1] = new SqlParameter("@address", SqlDbType.NVarChar, 50);
            param[1].Value = address;
            param[2] = new SqlParameter("@phone", SqlDbType.VarChar, 50);
            param[2].Value = phone;
            param[3] = new SqlParameter("@id", SqlDbType.Int);
            param[3].Value = id;
            da.excutequery("UpdateSuppliers", param);
            da.close();


        }
    }
}
