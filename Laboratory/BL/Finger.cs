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
    class Finger
    {

        internal void AddHrInOut(int IDEmployee, DateTime CHECKTIME,  int idwInOutMode)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@IDEmployee", SqlDbType.Int);
            param[0].Value = IDEmployee;
            param[1] = new SqlParameter("@CHECKTIME", SqlDbType.DateTime2);
            param[1].Value = CHECKTIME;

            param[2] = new SqlParameter("@idwInOutMode", SqlDbType.Int);
            param[2].Value = idwInOutMode;

            da.excutequery("AddHrInOut", param);
            da.close();
        }
        internal DataTable vildateHRINOUT(int IDEMPLOYEE, DateTime datet)
        {

            DataAccessLayer da = new DataAccessLayer();
            DataTable dt = new DataTable();


            da.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@IDEMPLOYEE", SqlDbType.Int);
            param[0].Value = IDEMPLOYEE;
            param[1] = new SqlParameter("@datetime", SqlDbType.DateTime2);
            param[1].Value = datet;

            dt = da.selected("vildateHRINOUT", param);
            da.close();
            return dt;
        }
        internal DataTable selectcountidfinger()
        {

            DataAccessLayer da = new DataAccessLayer();
            DataTable dt = new DataTable();

            da.open();
         

            dt = da.selected("selectcountidfinger", null);
            da.close();
            return dt;
        }
        internal DataTable vildateLastDate(int IDEMPLOYEE, DateTime datet)
        {

            DataAccessLayer da = new DataAccessLayer();
            DataTable dt = new DataTable();


            da.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@IDEMPLOYEE", SqlDbType.Int);
            param[0].Value = IDEMPLOYEE;
            param[1] = new SqlParameter("@datetime", SqlDbType.Date);
            param[1].Value = datet;

            dt = da.selected("vildateLastDate", param);
            da.close();
           
            return dt;
        }
        internal DataTable selectidfingeremployee()
        {

            DataAccessLayer da = new DataAccessLayer();
            DataTable dt = new DataTable();


            da.open();
       
            dt = da.selected("selectidfingeremployee", null);
            da.close();
            return dt;
        }
        internal DataTable SELECTFingerIDemployee(int idemployee)
        {

            DataAccessLayer da = new DataAccessLayer();
            DataTable dt = new DataTable();


            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@idemployee", SqlDbType.Int);
            param[0].Value = idemployee;
            //param[1] = new SqlParameter("@From_date", SqlDbType.DateTime2);
            //param[1].Value = fromdate;
            //param[2] = new SqlParameter("@to_date", SqlDbType.DateTime2);
            //param[2].Value = todate;

            dt = da.selected("SELECTFingerIDemployee", param);
            da.close();

            return dt;
        }
        internal DataTable SELECTFingerIDemployeeOut(int idemployee)
        {

            DataAccessLayer da = new DataAccessLayer();
            DataTable dt = new DataTable();


            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@idemployee", SqlDbType.Int);
            param[0].Value = idemployee;
            //param[1] = new SqlParameter("@From_date", SqlDbType.DateTime2);
            //param[1].Value = fromdate;
            //param[2] = new SqlParameter("@to_date", SqlDbType.DateTime2);
            //param[2].Value = todate;

            dt = da.selected("SELECTFingerIDemployeeOut", param);
            da.close();

            return dt;
        }


        internal DataTable Attendance(int idemployee,DateTime Date)
        {

            DataAccessLayer da = new DataAccessLayer();
            DataTable dt = new DataTable();


            da.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = idemployee;
            param[1] = new SqlParameter("@Date", SqlDbType.DateTime);
            param[1].Value = Date;


            dt = da.selected("Attendance", param);
            da.close();

            return dt;
        }
    }
}
