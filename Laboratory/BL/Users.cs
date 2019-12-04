using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laboratory.DAL;
using System.Data.SqlClient;
using System.Data;

namespace Laboratory.BL
{
    class Users
    {
        internal DataTable Logins(string userName, string pass)
        {
            DataAccessLayer da = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];
          
            param[0] = new SqlParameter("@UserName", SqlDbType.NVarChar, 100);
            param[0].Value = userName;

            param[1] = new SqlParameter("@PASS", SqlDbType.VarChar, 50);
            param[1].Value = pass;
            da.open();
            DataTable dt = new DataTable();
            dt = da.selected("st_login", param);

            return dt;

        }
        internal void AddUser(int id_emp,string userName, string pass)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id_emp;
            param[1] = new SqlParameter("@UserName", SqlDbType.NVarChar, 100);
            param[1].Value = userName;
            param[2] = new SqlParameter("@pass", SqlDbType.VarChar, 50);
            param[2].Value = pass;
          
        
            da.excutequery("AddUser", param);
            da.close();
        }




        internal DataTable SelectUsers()
        {
            DataAccessLayer da = new DataAccessLayer();

            da.open();
            DataTable dt = new DataTable();
            dt = da.selected("SelectUsers", null);

            return dt;

        }

        internal void UpdateUsers(int id_emp, string userName, string pass)
        {

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id_emp;
          
            param[1] = new SqlParameter("@UserName", SqlDbType.NVarChar, 100);
            param[1].Value = userName;
            param[2] = new SqlParameter("@pass", SqlDbType.VarChar, 50);
            param[2].Value = pass;
            da.excutequery("UpdateUsers", param);
            da.close();
        }

        internal void deleteusers(int id)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            da.excutequery("deleteusers", param);
            da.close();
        }

        internal void ADDLogin(string id, string login)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@id", SqlDbType.NVarChar, 50);
            param[0].Value = id;
            param[1] = new SqlParameter("LogIn", SqlDbType.NVarChar, 50);
            param[1].Value = login;
            da.excutequery("ADDLogin", param);
            da.close();
        }

        internal DataTable LastIDLogin()
        {
            DataAccessLayer da = new DataAccessLayer();

            da.open();
            DataTable dt = new DataTable();
            dt = da.selected("LastIDLogin", null);

            return dt;

        }
        internal DataTable VildateUsers(string UserName)
        {
            DataAccessLayer da = new DataAccessLayer();

            da.open();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@UserName", SqlDbType.NVarChar, 100);
            param[0].Value = UserName;
            dt = da.selected("VildateUsers", param);

            return dt;

        }

   



    }
}
