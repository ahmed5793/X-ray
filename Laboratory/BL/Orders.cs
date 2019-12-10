using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Laboratory.DAL;
namespace Laboratory.BL
{
    class Orders
    {
        internal void Add_Order(DateTime Date , string Discription ,string SaleMan )
        {
            DataAccessLayer DA = new DataAccessLayer();
            DA.open();
            SqlParameter[] Param = new SqlParameter[3];
            Param[0] = new SqlParameter("@Date_Order", SqlDbType.DateTime);
            Param[0].Value = Date;
            Param[1] = new SqlParameter("@Discraption", SqlDbType.NVarChar,250);
            Param[1].Value = Discription;
            Param[2] = new SqlParameter("@SalesMan", SqlDbType.NVarChar,50);
            Param[2].Value = SaleMan;
            DA.excutequery("Add_Order", Param);
            DA.close();  
        }
        internal void Add_OrderDetails(int Id_Order, int  Id_Store, int Id_Product ,int Quantity)
        {
            DataAccessLayer DA = new DataAccessLayer();
            DA.open();
            SqlParameter[] Param = new SqlParameter[4];
            Param[0] = new SqlParameter("@ID_order", SqlDbType.Int);
            Param[0].Value = Id_Order;
            Param[1] = new SqlParameter("@Id_Store", SqlDbType.Int);
            Param[1].Value = Id_Store;
            Param[2] = new SqlParameter("@ID_Prod", SqlDbType.Int );
            Param[2].Value = Id_Product;
            Param[3] = new SqlParameter("@Quntity", SqlDbType.Int);
            Param[3].Value = Quantity;
            DA.excutequery("Add_OrderDetails", Param);
            DA.close();
        }
        internal DataTable Last_IdOrder()
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            DataTable dt = new DataTable();
            dt.Clear();
            dt = da.selected("Last_IdOrder", null);
            da.close();
            return dt; 
        }
    }
}
