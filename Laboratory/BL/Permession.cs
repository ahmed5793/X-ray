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
        internal void Add_UserBAsicInformation(string User_Name, int add_customer, int Validate_User, int add_CategoryXray, int Add_Xrays)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@User_Name", SqlDbType.NVarChar, 100);
            param[0].Value = User_Name;
            param[1] = new SqlParameter("@Add_customer", SqlDbType.Int);
            param[1].Value = add_customer;
            param[2] = new SqlParameter("@Validate_User", SqlDbType.Int);
            param[2].Value = Validate_User;
            param[3] = new SqlParameter("@Add_CategoryXray", SqlDbType.Int);
            param[3].Value = add_CategoryXray;
            param[4] = new SqlParameter("@Add_Xray", SqlDbType.Int);
            param[4].Value = Add_Xrays;
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
        internal void Update_UserBAsicInformation(string User_Name, int add_customer, int Validate_User, int add_CategoryXray, int Add_Xrays)
        {

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@User_Name", SqlDbType.NVarChar, 100);
            param[0].Value = User_Name;
            param[1] = new SqlParameter("@Add_customer", SqlDbType.Int);
            param[1].Value = add_customer;
            param[2] = new SqlParameter("@Validate_User", SqlDbType.Int);
            param[2].Value = Validate_User;
            param[3] = new SqlParameter("@Add_CategoryXray", SqlDbType.Int);
            param[3].Value = add_CategoryXray;
            param[4] = new SqlParameter("@Add_Xray", SqlDbType.Int);
            param[4].Value = Add_Xrays;
            da.excutequery("Update_UserBAsicInformation", param);
            da.close();
        }
        internal void Add_UserEmployee(string User_Name, int add_Employee, int Create_Account, int add_EmployeBranch, 
            int Add_Salf,int Mortbat,int Report_Salf,int Report_Mortbat,int DoctorOfCenter , int Report_DoctorOfCenter 
            , int Add_Technical , int Report_Technical)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[12];
            param[0] = new SqlParameter("@User_Name", SqlDbType.NVarChar, 100);
            param[0].Value = User_Name;
            param[1] = new SqlParameter("@Add_Employee", SqlDbType.Int);
            param[1].Value = add_Employee;
            param[2] = new SqlParameter("@Create_Account", SqlDbType.Int);
            param[2].Value = Create_Account;
            param[3] = new SqlParameter("@Add_EmployeBranch", SqlDbType.Int);
            param[3].Value = add_EmployeBranch;
            param[4] = new SqlParameter("@Add_Salf", SqlDbType.Int);
            param[4].Value = Add_Salf;
            param[5] = new SqlParameter("@Add_Mortbat", SqlDbType.Int);
            param[5].Value = Mortbat;
            param[6] = new SqlParameter("@Report_Salf", SqlDbType.Int);
            param[6].Value = Report_Salf;
            param[7] = new SqlParameter("@Report_Mortbat", SqlDbType.Int);
            param[7].Value = Report_Mortbat;
            param[8] = new SqlParameter("@Add_DoctorOfCenter", SqlDbType.Int);
            param[8].Value = DoctorOfCenter;
            param[9] = new SqlParameter("@Report_DoctorOfCenter", SqlDbType.Int);
            param[9].Value = Report_DoctorOfCenter;
            param[10] = new SqlParameter("@Add_Technical", SqlDbType.Int);
            param[10].Value = Add_Technical;
            param[11] = new SqlParameter("@Report_Technical", SqlDbType.Int);
            param[11].Value = Report_Technical;
            da.excutequery("Add_UserEmployee", param);
            da.close();
        }
        internal void Update_UserEmployee(string User_Name, int add_Employee, int Create_Account, int add_EmployeBranch,
           int Add_Salf, int Mortbat, int Report_Salf, int Report_Mortbat, int DoctorOfCenter, int Report_DoctorOfCenter
           , int Add_Technical, int Report_Technical)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[12];
            param[0] = new SqlParameter("@User_Name", SqlDbType.NVarChar, 100);
            param[0].Value = User_Name;
            param[1] = new SqlParameter("@Add_Employee", SqlDbType.Int);
            param[1].Value = add_Employee;
            param[2] = new SqlParameter("@Create_Account", SqlDbType.Int);
            param[2].Value = Create_Account;
            param[3] = new SqlParameter("@Add_EmployeBranch", SqlDbType.Int);
            param[3].Value = add_EmployeBranch;
            param[4] = new SqlParameter("@Add_Salf", SqlDbType.Int);
            param[4].Value = Add_Salf;
            param[5] = new SqlParameter("@Add_Mortbat", SqlDbType.Int);
            param[5].Value = Mortbat;
            param[6] = new SqlParameter("@Report_Salf", SqlDbType.Int);
            param[6].Value = Report_Salf;
            param[7] = new SqlParameter("@Report_Mortbat", SqlDbType.Int);
            param[7].Value = Report_Mortbat;
            param[8] = new SqlParameter("@Add_DoctorOfCenter", SqlDbType.Int);
            param[8].Value = DoctorOfCenter;
            param[9] = new SqlParameter("@Report_DoctorOfCenter", SqlDbType.Int);
            param[9].Value = Report_DoctorOfCenter;
            param[10] = new SqlParameter("@Add_Technical", SqlDbType.Int);
            param[10].Value = Add_Technical;
            param[11] = new SqlParameter("@Report_Technical", SqlDbType.Int);
            param[11].Value = Report_Technical;
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
    }
}
