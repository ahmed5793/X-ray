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
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();

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
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();

            da.open();
         

            dt = da.selected("selectcountidfinger", null);
            da.close();
            return dt;
        }
    }
}
