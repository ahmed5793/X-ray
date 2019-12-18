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
    class CategoryXRaya
    {
        internal void AddCategoryXRaya(string name)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 150);
            param[0].Value = name;



            da.excutequery("AddCategoryXRaya", param);
            da.close();
        }
        internal DataTable selectCategoryXRaya()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            dt = da.selected("selectCategoryXRaya", null);
            da.close();
            return dt;
        }
      
        internal void UpdateCtegoryXRaya(int id, string name)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@name", SqlDbType.NVarChar, 150);
            param[1].Value = name;



            da.excutequery("UpdateCtegoryXRaya", param);
            da.close();
        }
        internal DataTable searchCategoryXRaya(string id)
        {
            DataTable dt = new DataTable();
         
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.NVarChar,100);
            param[0].Value = id;
            dt = da.selected("searchCategoryXRaya", param);
            da.close();
            return dt;
        }
        internal DataTable Validate_CategoryXray(int id)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            dt = da.selected("Validate_CategoryXray", param);
            da.close();
            return dt;
        }
    }
}

