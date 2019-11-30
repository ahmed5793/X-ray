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
    class Product
    {

        internal void Add_Product(int id ,string name , decimal Quantity , decimal Selling_price , Decimal Purshasing_price ,int id_Store)
        {
            DataAccessLayer da = new DataAccessLayer();

            SqlParameter[] param = new SqlParameter[6];
            da.open();
            param[0] = new SqlParameter("@Id_Product", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@Product_Name", SqlDbType.NVarChar,100);
            param[1].Value = name;
            param[2] = new SqlParameter("@Quantity", SqlDbType.Decimal);
            param[2].Value = Quantity;
            param[3] = new SqlParameter("@Selling_Price", SqlDbType.Decimal);
            param[3].Value = Selling_price;
            param[4] = new SqlParameter("@purxhase_price", SqlDbType.Decimal);
            param[4].Value = Purshasing_price;
            param[5] = new SqlParameter("@id_store", SqlDbType.Decimal);
            param[5].Value = id_Store;
            da.excutequery("Add_Product", param);
            da.close();
        }
        internal void Update_Product(int id, string name, decimal Quantity, decimal Selling_price, Decimal Purshasing_price, int id_Store)
        {
            DataAccessLayer da = new DataAccessLayer();

            SqlParameter[] param = new SqlParameter[6];
            da.open();
            param[0] = new SqlParameter("@Id_Product", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@Product_Name", SqlDbType.NVarChar, 100);
            param[1].Value = name;
            param[2] = new SqlParameter("@Quantity", SqlDbType.Decimal);
            param[2].Value = Quantity;
            param[3] = new SqlParameter("@Selling_Price", SqlDbType.Decimal);
            param[3].Value = Selling_price;
            param[4] = new SqlParameter("@purxhase_price", SqlDbType.Decimal);
            param[4].Value = Purshasing_price;
            param[5] = new SqlParameter("@id_store", SqlDbType.Decimal);
            param[5].Value = id_Store;
            da.excutequery("Update_Product", param);
            da.close();
        }
        internal DataTable Select_Product()
        {
            DataAccessLayer da = new DataAccessLayer();

            DataTable dt = new DataTable();
            try
            {
                da.open();
                dt.Clear();
                dt = da.selected("Select_Product", null);
               da.close();
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
        internal DataTable Search_Product(string id )
        {
            DataTable dt = new DataTable();
            try
            {
                DataAccessLayer da = new DataAccessLayer();

                da.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@id", SqlDbType.NVarChar,100);
                param[0].Value = id;
                dt.Clear();
                dt = da.selected("Search_Product", param);
                da.close();
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
        internal DataTable Select_LastIdProduct()
        {
            DataTable dt = new DataTable();
            try
            {
                DataAccessLayer da = new DataAccessLayer();
                da.open();
                dt.Clear();
                dt = da.selected("Select_LastIdProduct", null);
                da.close();
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
        internal void Update_TotalProd()
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            da.excutequery("Update_TotalProd", null);
            da.close();
        }
    }
}
