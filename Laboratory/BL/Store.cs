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
    class Store
    {
        internal void add_Store(string name , string address)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@Store_name", SqlDbType.NVarChar,150);
            param[0].Value = name;
            param[1] = new SqlParameter("@Address", SqlDbType.NVarChar, 150);
            param[1].Value = address;
            da.excutequery("add_Store", param);
            da.close();           
        }
        internal void Update_Store(int ID,string name, string address)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@id_store", SqlDbType.Int);
            param[0].Value = ID;
            param[1] = new SqlParameter("@Store_name", SqlDbType.NVarChar, 150);
            param[1].Value = name;
            param[2] = new SqlParameter("@Address", SqlDbType.NVarChar, 150);
            param[2].Value = address;
            da.excutequery("Update_Store", param);
            da.close();
        }
        internal DataTable Select_Store()
        {
            DataTable dt = new DataTable();
            try
            {
                DataAccessLayer DA = new DataAccessLayer();
                DA.open();
                dt.Clear();
                dt = DA.selected("Select_Store", null);
                return dt;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                dt.Dispose();
            }
        
        }
        internal DataTable Select_ComboStore()
        {
            DataTable dt = new DataTable();
            try
            {
                DataAccessLayer DA = new DataAccessLayer();
                DA.open();
                dt.Clear();
                dt = DA.selected("Select_ComboStore", null);
                return dt;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                dt.Dispose();
            }

        }
        internal DataTable Select_QuantityProduct( int Id_Product , int Id_Store)
        {
            DataTable dt = new DataTable();
            try
            {
                DataAccessLayer DA = new DataAccessLayer();
                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@ID_Product", SqlDbType.Int);
                param[0].Value = Id_Product;
                param[1] = new SqlParameter("@Id_Store", SqlDbType.Int);
                param[1].Value = Id_Store;
                DA.open();
                dt.Clear();
                dt = DA.selected("Select_QuantityProduct", param);
                return dt;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                dt.Dispose();
            }

        }
    }
}
