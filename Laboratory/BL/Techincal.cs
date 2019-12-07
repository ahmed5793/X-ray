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
    class Techincal
    {
        internal void AddTechincal(string name, string phone, string address)
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




            da.excutequery("AddTechincal", param);

            da.close();

        }


        internal DataTable SelectTechincal()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            dt = da.selected("SelectTechincal", null);
            da.close();
            return dt;
        }
        internal DataTable CompoTechibncal()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            dt = da.selected("CompoTechibncal", null);
            da.close();
            return dt;
        }

        internal DataTable SearchTechincal(string name)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 300);
            param[0].Value = name;

            dt = da.selected("SearchTechincal", param);
            da.close();
            return dt;
        }
        internal void UpdateTechincal(string name, string phone, int id, string address)
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

            da.excutequery("UpdateTechincal", param);
            da.close();


        }
    }
}
