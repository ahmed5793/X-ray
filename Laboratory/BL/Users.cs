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
        internal DataTable SelectUserBranch(string UserName)
        {
            DataAccessLayer da = new DataAccessLayer();

            da.open();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@userName",SqlDbType.NVarChar,100);
            param[0].Value = UserName;
            dt = da.selected("SelectUserBranch", param);
            return dt;
        }

        internal DataTable Select_UserName(int Id_Emp)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id_Emp", SqlDbType.Int);
            param[0].Value = Id_Emp;
            dt = da.selected("Select_UserName", param);
            return dt;
        }
        internal DataTable Select_MoneyForUser(int ID_Stock,string UserName, DateTime Date , TimeSpan Time_From , TimeSpan Time_To)
        {

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@ID_Stock", SqlDbType.Int);
            param[0].Value = ID_Stock;
            param[1] = new SqlParameter("@UserName", SqlDbType.NVarChar,50);
            param[1].Value = @UserName;
            param[2] = new SqlParameter("@Date", SqlDbType.Date);
            param[2].Value = Date;
            param[3] = new SqlParameter("@Time_From", SqlDbType.Time);
            param[3].Value = Time_From;
            param[4] = new SqlParameter("@Time_to", SqlDbType.Time);
            param[4].Value = Time_To;
            dt = da.selected("Select_MoneyForUser", param);
            return dt;
        }
        internal DataTable Select_PullMoneyForUser(int ID_Stock,string UserName, DateTime Date, TimeSpan Time_From, TimeSpan Time_To)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@ID_Stock", SqlDbType.Int);
            param[0].Value = ID_Stock;
            param[1] = new SqlParameter("@UserName", SqlDbType.NVarChar, 50);
            param[1].Value = @UserName;
            param[2] = new SqlParameter("@Date", SqlDbType.Date);
            param[2].Value = Date;
            param[3] = new SqlParameter("@Time_From", SqlDbType.Time);
            param[3].Value = Time_From;
            param[4] = new SqlParameter("@Time_to", SqlDbType.Time);
            param[4].Value = Time_To;
            dt = da.selected("Select_PullMoneyForUser", param);
            return dt;
        }
        internal DataTable Select_UserForBranch(int Id_Baranch)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id_Branch", SqlDbType.Int);
            param[0].Value = Id_Baranch;

            dt = da.selected("Select_UserForBranch", param);
            return dt;
        }
        internal void AddCheckUserName(string UserName, string Statues, DateTime OpenDate,DateTime CloseDate)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@UserName", SqlDbType.NVarChar,50);
            param[0].Value = UserName;
            param[1] = new SqlParameter("@Statues", SqlDbType.NVarChar, 50);
            param[1].Value = Statues;
            param[2] = new SqlParameter("@OpenDate", SqlDbType.DateTime);
            param[2].Value = OpenDate;
            param[3] = new SqlParameter("@CloseDate", SqlDbType.DateTime);
            param[3].Value = CloseDate;


            da.excutequery("AddCheckUserName", param);
            da.close();
        }
        internal void UpdateCheckUserName(string UserName, string Statues, DateTime CloseDate,DateTime OpenDate)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@UserName", SqlDbType.NVarChar, 50);
            param[0].Value = UserName;
            param[1] = new SqlParameter("@Statues", SqlDbType.NVarChar, 50);
            param[1].Value = Statues;
          
            param[2] = new SqlParameter("@CloseDate", SqlDbType.DateTime);
            param[2].Value = CloseDate;
            param[3] = new SqlParameter("@OpenDate", SqlDbType.DateTime);
            param[3].Value = OpenDate;

            da.excutequery("UpdateCheckUserName", param);
            da.close();
        }
        internal DataTable SelectCheckUserName(string UserName)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@UserName", SqlDbType.NVarChar,50);
            param[0].Value = UserName;

            dt = da.selected("SelectCheckUserName", param);
            return dt;
        }
        internal DataTable SelectAllCheckUserName()
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            DataTable dt = new DataTable();
      
            dt = da.selected("SelectAllCheckUserName", null);
            return dt;
        }
        internal DataTable SelectCheckUserNameOffline(string UserName)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@UserName", SqlDbType.NVarChar, 50);
            param[0].Value = UserName;

            dt = da.selected("SelectCheckUserNameOffline", param);
            return dt;
        }

    }
}
