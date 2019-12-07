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
            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 300);
            param[0].Value = name;

            param[1] = new SqlParameter("@phone", SqlDbType.VarChar, 100);
            param[1].Value = phone;

            param[2] = new SqlParameter("@id", SqlDbType.Int);
            param[2].Value = id;
            param[3] = new SqlParameter("@address", SqlDbType.NVarChar, 250);
            param[3].Value = address;
           
            da.excutequery("UpdateDoctor_OFCENTER", param);
            da.close();


        }
    }
}
