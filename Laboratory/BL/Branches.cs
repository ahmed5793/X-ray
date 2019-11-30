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
    class Branches
    {
        internal DataTable SelectCompBranches()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            dt = da.selected("SelectCompBranches", null);
            da.close();
            return dt;
        }
        internal DataTable SelectBranches()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            dt = da.selected("SelectBranches", null);
            da.close();
            return dt;
        }
        internal DataTable SearchBranches(string id)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.NVarChar, 100);
            param[0].Value = id;
          
            dt = da.selected("SearchBranches", param);
            da.close();
            return dt;
        }
        internal void AddBranches(string name, string address,int id_stock,int id_store)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@Name", SqlDbType.NVarChar, 100);
            param[0].Value = name;
            param[1] = new SqlParameter("@Address", SqlDbType.NVarChar, 150);
            param[1].Value = address;
            param[2] = new SqlParameter("@id_Stock", SqlDbType.Int);
            param[2].Value = id_stock;
            param[3] = new SqlParameter("@id_Store", SqlDbType.Int);
            param[3].Value = id_store;


            da.excutequery("AddBranches", param);
            da.close();
        }
        internal void UpdateBranches(string name, string address, int id_stock, int id_store,int @ID_Branches)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@Name", SqlDbType.NVarChar, 100);
            param[0].Value = name;
            param[1] = new SqlParameter("@Address", SqlDbType.NVarChar, 150);
            param[1].Value = address;
            param[2] = new SqlParameter("@id_Stock", SqlDbType.Int);
            param[2].Value = id_stock;
            param[3] = new SqlParameter("@id_Store", SqlDbType.Int);
            param[3].Value = id_store;

            param[4] = new SqlParameter("@ID_Branches", SqlDbType.Int);
            param[4].Value = ID_Branches;
            da.excutequery("UpdateBranches", param);
            da.close();
        }
    }
}
