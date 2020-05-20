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
    class DoctorOfCenter
    {
        internal void AddDoctor_OFCENTER(string name, string phone, string address)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 250);
            param[0].Value = name;

            param[1] = new SqlParameter("@phone", SqlDbType.VarChar, 50);
            param[1].Value = phone;

            param[2] = new SqlParameter("@address", SqlDbType.NVarChar, 250);
            param[2].Value = address;




            da.excutequery("AddDoctor_OFCENTER", param);

            da.close();

        }

    
        internal DataTable SelectDoctor_OFCENTER()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            dt = da.selected("SelectDoctor_OFCENTER", null);
            da.close();
            return dt;
        }
        internal DataTable CompoDoctor_OFCENTER()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            dt = da.selected("CompoDoctor_OFCENTER", null);
            da.close();
            return dt;
        }
   
        internal DataTable SearchDoctor_OFCNETER(string name)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 300);
            param[0].Value = name;

            dt = da.selected("SearchDoctor_OFCNETER", param);
            da.close();
            return dt;
        }
        internal void UpdateDoctor_OFCENTER(string name, string phone, int id, string address)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 250);
            param[0].Value = name;

            param[1] = new SqlParameter("@phone", SqlDbType.NVarChar, 50);
            param[1].Value = phone;

            param[2] = new SqlParameter("@id", SqlDbType.Int);
            param[2].Value = id;
            param[3] = new SqlParameter("@address", SqlDbType.NVarChar, 250);
            param[3].Value = address;
           
            da.excutequery("UpdateDoctor_OFCENTER", param);
            da.close();
        }
        internal DataTable Combo_DoctorOfCenter()
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            DataTable dt = new DataTable();
            dt.Clear();
            dt = da.selected("Combo_DoctorOfCenter", null);
            da.close();
            return dt;
        }
        internal DataTable Select_ReportDoctorOfCenter(int id)
        {
            DataAccessLayer da = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id_DoctorOfCenter", SqlDbType.Int);
            param[0].Value = id;
            da.open();
            DataTable dt = new DataTable();
            dt.Clear();
            dt = da.selected("Select_ReportDoctorOfCenter", param);
            da.close();
            return dt;
        }
        internal DataTable Search_ReportDoctorOfCenter(int id, DateTime Date_From , DateTime Date_To)
        {
            DataAccessLayer da = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@id_DoctorOfCenter", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@Date_From", SqlDbType.Date);
            param[1].Value = Date_From;
            param[2] = new SqlParameter("@Date_To", SqlDbType.Date);
            param[2].Value = Date_To;
            da.open();
            DataTable dt = new DataTable();
            dt.Clear();
            dt = da.selected("Search_ReportDoctorOfCenter", param);
            da.close();
            return dt;
        }
        internal DataTable vildateDoctorOfCenter(int id)
        {
            DataAccessLayer da = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            da.open();
            DataTable dt = new DataTable();
            dt.Clear();
            dt = da.selected("vildateDoctorOfCenter", param);
            da.close();
            return dt;
        }
        internal DataTable Select_NumberCases_DoctorOfCenter(int id)
        {
            DataAccessLayer da = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Id_DoctorOfCenter", SqlDbType.Int);
            param[0].Value = id;
            da.open();
            DataTable dt = new DataTable();
            dt.Clear();
            dt = da.selected("Select_NumberCases_DoctorOfCenter", param);
            da.close();
            return dt;
        }
        internal DataTable Search_NumberCases_DoctorOfCenter(int id, DateTime Date_From, DateTime Date_To)
        {
            DataAccessLayer da = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@Id_DoctorOfCenter", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@Date_From", SqlDbType.Date);
            param[1].Value = Date_From;
            param[2] = new SqlParameter("@Date_To", SqlDbType.Date);
            param[2].Value = Date_To;
            da.open();
            DataTable dt = new DataTable();
            dt.Clear();
            dt = da.selected("Search_NumberCases_DoctorOfCenter", param);
            da.close();
            return dt;
        }
        internal DataTable Search_ALLReportDoctorOfCenter(DateTime Date_From, DateTime Date_To)
        {
            DataAccessLayer da = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@Date_From", SqlDbType.Date);
            param[0].Value = Date_From;
            param[1] = new SqlParameter("@Date_To", SqlDbType.Date);
            param[1].Value = Date_To;
            da.open();
            DataTable dt = new DataTable();
            dt.Clear();
            dt = da.selected("Search_ALLReportDoctorOfCenter", param);
            da.close();
            return dt;
        }
        internal DataTable Search_ALLReportDoctorOfCenterPay(DateTime Date_From, DateTime Date_To)
        {
            DataAccessLayer da = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@Date_From", SqlDbType.Date);
            param[0].Value = Date_From;
            param[1] = new SqlParameter("@Date_To", SqlDbType.Date);
            param[1].Value = Date_To;
            da.open();
            DataTable dt = new DataTable();
            dt.Clear();
            dt = da.selected("Search_ALLReportDoctorOfCenterPay", param);
            da.close();
            return dt;
        }
        internal DataTable Search_ALLReportDoctorOfCenterCompany(DateTime Date_From, DateTime Date_To)
        {
            DataAccessLayer da = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@Date_From", SqlDbType.Date);
            param[0].Value = Date_From;
            param[1] = new SqlParameter("@Date_To", SqlDbType.Date);
            param[1].Value = Date_To;
            da.open();
            DataTable dt = new DataTable();
            dt.Clear();
            dt = da.selected("Search_ALLReportDoctorOfCenterCompany", param);
            da.close();
            return dt;
        }


        internal DataTable SelectDateCountDoctorOfCenter(int idDoctor, DateTime Date_From, DateTime Date_To)
        {
            DataAccessLayer da = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@idDoctor", SqlDbType.Int);
            param[0].Value = idDoctor;
            param[1] = new SqlParameter("@Date_From", SqlDbType.Date);
            param[1].Value = Date_From;
            param[2] = new SqlParameter("@Date_To", SqlDbType.Date);
            param[2].Value = Date_To;
            da.open();
            DataTable dt = new DataTable();
            dt.Clear();
            dt = da.selected("SelectDateCountDoctorOfCenter", param);
            da.close();
            return dt;
        }

        internal DataTable SelectDateCountDoctorOfCenterPay(int idDoctor, DateTime Date_From, DateTime Date_To)
        {
            DataAccessLayer da = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@idDoctor", SqlDbType.Int);
            param[0].Value = idDoctor;
            param[1] = new SqlParameter("@Date_From", SqlDbType.Date);
            param[1].Value = Date_From;
            param[2] = new SqlParameter("@Date_To", SqlDbType.Date);
            param[2].Value = Date_To;
            da.open();
            DataTable dt = new DataTable();
            dt.Clear();
            dt = da.selected("SelectDateCountDoctorOfCenterPay", param);
            da.close();
            return dt;
        }
        internal DataTable SelectDateCountDoctorOfCenterCompany(int idDoctor, DateTime Date_From, DateTime Date_To)
        {
            DataAccessLayer da = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@idDoctor", SqlDbType.Int);
            param[0].Value = idDoctor;
            param[1] = new SqlParameter("@Date_From", SqlDbType.Date);
            param[1].Value = Date_From;
            param[2] = new SqlParameter("@Date_To", SqlDbType.Date);
            param[2].Value = Date_To;
            da.open();
            DataTable dt = new DataTable();
            dt.Clear();
            dt = da.selected("SelectDateCountDoctorOfCenterCompany", param);
            da.close();
            return dt;
        }

    }
}
