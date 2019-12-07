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
    class ItemsXRaya
    {
        internal void AddItemXRaya(string ItemName, decimal price, int IdCategory)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@item_name", SqlDbType.NVarChar, 250);
            param[0].Value = ItemName;
            param[1] = new SqlParameter("@price", SqlDbType.Decimal);
            param[1].Value = price;
            param[2] = new SqlParameter("@id_category", SqlDbType.Int);
            param[2].Value = IdCategory;


            da.excutequery("AddItemXRaya", param);
            da.close();
        }
        internal void UpdateItemXRaya(string ItemName, decimal price, int IdItem, int idcategory)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@item_name", SqlDbType.NVarChar, 600);
            param[0].Value = ItemName;
            param[1] = new SqlParameter("@price", SqlDbType.Decimal);
            param[1].Value = price;
            param[2] = new SqlParameter("@Item_ID", SqlDbType.Int);
            param[2].Value = IdItem;
            param[3] = new SqlParameter("@idcategory", SqlDbType.Int);
            param[3].Value = idcategory;


            da.excutequery("UpdateItemXRaya", param);
            da.close();
        }
        internal DataTable SelectItemXRaya()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            dt = da.selected("SelectItemXRaya", null);
            da.close();
            return dt;
        }



        internal DataTable PriceItemXRaya(int idItem)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@itemId", SqlDbType.Int);
            param[0].Value = idItem;

            dt = da.selected("PriceItemXRaya", param);
            da.close();
            return dt;
        }
        internal DataTable VildateItem(int idCtegory, int idItem)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@idCategory", SqlDbType.Int);
            param[0].Value = idCtegory;
            param[1] = new SqlParameter("@IDItem", SqlDbType.Int);
            param[1].Value = idItem;


            dt = da.selected("VildateItem", param);
            da.close();
            return dt;
        }
        internal DataTable SearchItemXRaya(string id)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.NVarChar, 50);
            param[0].Value = id;



            dt = da.selected("SearchItemXRaya", param);
            da.close();
            return dt;
        }



        internal DataTable SelectCtegoryItems(int idCategory)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id_Ctegory", SqlDbType.Int);
            param[0].Value = idCategory;

            dt = da.selected("SelectCtegoryItems", param);
            da.close();
            return dt;
        }

        internal DataTable SelectPriseItem( int idItem)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
          
            param[0] = new SqlParameter("@id_Item", SqlDbType.Int);
            param[0].Value = idItem;


            dt = da.selected("SelectPriseItem", param);
            da.close();
            return dt;
        }

    }
}
