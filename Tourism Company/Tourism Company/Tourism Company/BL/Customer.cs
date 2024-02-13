using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tourism_Company.DAL;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;


namespace Tourism_Company.BL
{
    public class Customer
    {
        internal void addCustomer(string name,  string phone)
        {
            DataAcssesLayer da = new DataAcssesLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 600);
            param[0].Value = name;
 
            param[1] = new SqlParameter("@phone", SqlDbType.VarChar, 500);
            param[1].Value = phone;


            da.excutequery("AddCustomer", param);
            da.close();
        }
        internal DataTable SelectCustomer()
        {
            DataTable dt = new DataTable();

            DataAcssesLayer da = new DataAcssesLayer();
            da.open();
            dt = da.selected("SelectCustomer", null);
            da.close();
            return dt;
        }
        internal DataTable CompoCustomer()
        {
            DataTable dt = new DataTable();

            DataAcssesLayer da = new DataAcssesLayer();
            da.open();
            dt = da.selected("CompoCustomer", null);
            da.close();
            return dt;
        }
        internal void DeleteCustomer(int id)
        {
            DataAcssesLayer da = new DataAcssesLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;



            da.excutequery("DeleteCustomer", param);
            da.close();
        }
        internal DataTable SearchCustomer(string name)
        {
            DataTable dt = new DataTable();

            DataAcssesLayer da = new DataAcssesLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 100);
            param[0].Value = name;

            dt = da.selected("SearchCustomer", param);
            da.close();
            return dt;
        }
        internal void UpdateCustomer(string name, string phone, int id)
        {
            DataAcssesLayer da = new DataAcssesLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 150);
            param[0].Value = name;
   
            param[1] = new SqlParameter("@phone", SqlDbType.VarChar, 20);
            param[1].Value = phone;
            param[2] = new SqlParameter("@id", SqlDbType.Int);
            param[2].Value = id;
            da.excutequery("UpdateCustomer", param);
            da.close();


        }

        internal DataTable ValidetCustomer(int id)
        {
            SqlParameter[] param = new SqlParameter[1];
            DataTable dt = new DataTable();

            DataAcssesLayer da = new DataAcssesLayer();
            da.open();
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            dt = da.selected("ValidetCustomer", param);
            da.close();
            return dt;
        }
    }
}
