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

        internal void Add_Product(int id ,string name, decimal Selling_price, Decimal Purshasing_price)
 
        {
            DataAccessLayer da = new DataAccessLayer();

            SqlParameter[] param = new SqlParameter[4];
            da.open();
            param[0] = new SqlParameter("@Id_Product", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@Product_Name", SqlDbType.NVarChar,100);
            param[1].Value = name;
            param[2] = new SqlParameter("@Selling_Price", SqlDbType.Decimal);
            param[2].Value = Selling_price;
            param[3] = new SqlParameter("@purxhase_price", SqlDbType.Decimal);
            param[3].Value = Purshasing_price;
         
            da.excutequery("Add_Product", param);
            da.close();
        }
        internal void Update_Product(int id, string name, decimal Selling_price, Decimal Purshasing_price)
        {
            DataAccessLayer da = new DataAccessLayer();

            SqlParameter[] param = new SqlParameter[4];
            da.open();
            param[0] = new SqlParameter("@Id_Product", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@Product_Name", SqlDbType.NVarChar, 100);
            param[1].Value = name;
            param[2] = new SqlParameter("@Selling_Price", SqlDbType.Decimal);
            param[2].Value = Selling_price;
            param[3] = new SqlParameter("@purxhase_price", SqlDbType.Decimal);
            param[3].Value = Purshasing_price;
       
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
       
        internal void Add_StoreProduct(int id_product,int id_Store,decimal Quantity, int minimum)
        {
            DataAccessLayer da = new DataAccessLayer();

            SqlParameter[] param = new SqlParameter[4];
            da.open();
            param[0] = new SqlParameter("@Id_Product", SqlDbType.Int);
            param[0].Value = id_product;
            param[1] = new SqlParameter("@id_store", SqlDbType.Int);
            param[1].Value = id_Store;
            param[2] = new SqlParameter("@Quantity", SqlDbType.Decimal);
            param[2].Value = Quantity;
            param[3] = new SqlParameter("@minimum", SqlDbType.Int);
            param[3].Value = minimum;
            da.excutequery("Add_StoreProduct", param);
            da.close();
        }
        internal void Update_StoreProduct(int Id_StoreProduct,int id_Product, decimal Quantity, int Id_Store, int minimum)
        {
            DataAccessLayer da = new DataAccessLayer();

            SqlParameter[] param = new SqlParameter[5];
            da.open();
            param[0] = new SqlParameter("@ID_StoreProduct", SqlDbType.Int);
            param[0].Value = Id_StoreProduct;
            param[1] = new SqlParameter("@Id_Product", SqlDbType.Int);
            param[1].Value = id_Product;
            param[2] = new SqlParameter("@Quantity", SqlDbType.Decimal);
            param[2].Value = Quantity;
            param[3] = new SqlParameter("@id_store", SqlDbType.Int);
            param[3].Value = Id_Store;
            param[4] = new SqlParameter("@minimum", SqlDbType.Int);
            param[4].Value = minimum;
            da.excutequery("Update_StoreProduct", param);
            da.close();
        }
        internal void Delete_StoreProduct(int Id_StoreProduct)
        {
            DataAccessLayer da = new DataAccessLayer();

            SqlParameter[] param = new SqlParameter[1];
            da.open();
            param[0] = new SqlParameter("@ID_StoreProduct", SqlDbType.Int);
            param[0].Value = Id_StoreProduct;
 
            da.excutequery("Delete_StoreProduct", param);
            da.close();
        }
        internal DataTable Select_ComboProduct()
        {
            DataAccessLayer da = new DataAccessLayer();

            DataTable dt = new DataTable();
            try
            {
                da.open();
                dt.Clear();
                dt = da.selected("Select_ComboProduct", null);
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
        internal DataTable Select_StoreProduct()
        {
            DataAccessLayer da = new DataAccessLayer();

            DataTable dt = new DataTable();
            try
            {
                da.open();
                dt.Clear();
                dt = da.selected("Select_StoreProduct", null);
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
        internal DataTable Search_StoreProduct(string id)
        {
               DataTable dt = new DataTable();
               DataAccessLayer da = new DataAccessLayer();
               da.open();
               SqlParameter[] param = new SqlParameter[1];
               param[0] = new SqlParameter("@id", SqlDbType.NVarChar, 100);
               param[0].Value = id;
               dt.Clear();
               dt = da.selected("Search_StoreProduct", param);
               da.close();
               return dt;
        }
        internal void add_TransFairProduct(string  Emp_name, DateTime Date,string Note)
        {
            DataAccessLayer da = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[3];
            da.open();
            param[0] = new SqlParameter("@Employee_name", SqlDbType.NVarChar, 100);
            param[0].Value = Emp_name;
            param[1] = new SqlParameter("@Date", SqlDbType.DateTime);
            param[1].Value = Date;
            param[2] = new SqlParameter("@note", SqlDbType.NVarChar,350);
            param[2].Value = Note;
            da.excutequery("add_TransFairProduct", param);
            da.close();
        }
        internal void Add_TransfairDetails(int id_transfair, int from_store,string From_NameStore, int To_store,string To_NameStore, int id_product,int quantity)
        {
            DataAccessLayer da = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[7];
            da.open();
            param[0] = new SqlParameter("@id_transfair", SqlDbType.Int);
            param[0].Value = id_transfair;
            param[1] = new SqlParameter("@From_Store", SqlDbType.Int);
            param[1].Value = from_store;
            param[2] = new SqlParameter("@From_NameStore", SqlDbType.NVarChar,50);
            param[2].Value = From_NameStore;
            param[3] = new SqlParameter("@To_Store", SqlDbType.Int);
            param[3].Value = To_store;
            param[4] = new SqlParameter("@To_NameStore", SqlDbType.NVarChar,50);
            param[4].Value = To_NameStore;
            param[5] = new SqlParameter("@Id_product", SqlDbType.Int);
            param[5].Value = id_product;
            param[6] = new SqlParameter("@Quantity", SqlDbType.Int);
            param[6].Value = quantity;
            da.excutequery("Add_TransfairDetails", param);
            da.close();
        }
        internal DataTable Select_ComboTransfairProductT(int id)
        {
            DataTable dt = new DataTable();
            try
            {
                DataAccessLayer da = new DataAccessLayer();
                da.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@id", SqlDbType.Int);
                param[0].Value = id;
                dt.Clear();
                dt = da.selected("Select_ComboTransfairProductT", param);
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
        internal DataTable Select_LastIdTransfair()
        {
            DataAccessLayer da = new DataAccessLayer();

            DataTable dt = new DataTable();
            try
            {
                da.open();
                dt.Clear();
                dt = da.selected("Select_LastIdTransfair", null);
                da.close();
                return dt;

            }
            catch (Exception )
            {

                throw;
            }
            finally
            {
                dt.Dispose();
            }
        }
        internal DataTable Validate_Quantity(int id_product , int id_Store ,int Quantity)
        {
            DataTable dt = new DataTable();
            try
            {
                DataAccessLayer da = new DataAccessLayer();
                da.open();
                SqlParameter[] param = new SqlParameter[3];
                param[0] = new SqlParameter("@id_product", SqlDbType.Int);
                param[0].Value = id_product;
                param[1] = new SqlParameter("@id_store", SqlDbType.Int);
                param[1].Value = id_Store;
                param[2] = new SqlParameter("@Quantity", SqlDbType.Int);
                param[2].Value = Quantity;
                dt.Clear();
                dt = da.selected("Validate_Quantity", param);
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
        internal void Update_QuantityStoreProduct(int id_Product, decimal Quantity, int Id_Store)
        {
            DataAccessLayer da = new DataAccessLayer();

            SqlParameter[] param = new SqlParameter[3];
            da.open();
            param[0] = new SqlParameter("@Id_Product", SqlDbType.Int);
            param[0].Value = id_Product;
            param[1] = new SqlParameter("@Quantity", SqlDbType.Decimal);
            param[1].Value = Quantity;
            param[2] = new SqlParameter("@id_store", SqlDbType.Int);
            param[2].Value = Id_Store;
            da.excutequery("Update_QuantityStoreProduct", param);
            da.close();
        }

        internal DataTable Validate_StoreProduct(int id_product, int id_Store)
        {
            DataTable dt = new DataTable();
            try
            {
                DataAccessLayer da = new DataAccessLayer();
                da.open();
                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@id_product", SqlDbType.Int);
                param[0].Value = id_product;
                param[1] = new SqlParameter("@id_Store", SqlDbType.Int);
                param[1].Value = id_Store;
                dt.Clear();
                dt = da.selected("Validate_StoreProduct", param);
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

        internal DataTable Validate_ProductNAme(int id_product)
        {
            DataTable dt = new DataTable();
            try
            {
                DataAccessLayer da = new DataAccessLayer();
                da.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@Id", SqlDbType.Int);
                param[0].Value = id_product;
                dt.Clear();
                dt = da.selected("Validate_ProductNAme", param);
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
        internal DataTable Report_TransfairProduct()
        {
            DataAccessLayer da = new DataAccessLayer();

            DataTable dt = new DataTable();
            try
            {
                da.open();
                dt.Clear();
                dt = da.selected("Report_TransfairProduct", null);
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
        internal DataTable SearchReport_TransfairProduct(DateTime Date_From , DateTime Date_To)
        {
            DataTable dt = new DataTable();
            try
            {
                DataAccessLayer da = new DataAccessLayer();
                da.open();
                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@Date_From", SqlDbType.Date);
                param[0].Value = Date_From;
                param[1] = new SqlParameter("@Date_To", SqlDbType.Date);
                param[1].Value = Date_To;
                dt.Clear();
                dt = da.selected("SearchReport_TransfairProduct", param);
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
    }
}
