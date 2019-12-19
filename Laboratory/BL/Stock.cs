using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Laboratory.DAL;

namespace Laboratory.BL
{
    class Stock
    {
        internal void add_stock(int id, string name)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@id_treasury", SqlDbType.Int);
            param[0].Value = id;
            param[01] = new SqlParameter("@Treasury_name", SqlDbType.NVarChar, 100);
            param[1].Value = name;
            da.excutequery("add_stock", param);
            da.close();
        }
        internal void Update_Stock(int id, string name)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@id_Treasury", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@Treasury_name", SqlDbType.NVarChar, 100);
            param[1].Value = name;
            da.excutequery("Update_Stock", param);
            da.close();


        }

        internal void Delete_Stock(int id)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id_Treasury", SqlDbType.Int);
            param[0].Value = id;
            da.excutequery("Delete_Stock", param);
            da.close();
        }
        internal DataTable select_Stock()
        {
            DataAccessLayer da = new DataAccessLayer();
            DataTable dt = new DataTable();
            da.open();
            dt = da.selected("select_Stock", null);

            return dt;
        }

        internal DataTable Select_LastIdStock()
        {
            DataAccessLayer da = new DataAccessLayer();
            DataTable dt = new DataTable();
            da.open();
            dt = da.selected("Select_LastIdStock", null);

            return dt;
        }
        internal DataTable Compo_Stock()
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            DataTable dt = new DataTable();
            dt = da.selected("Compo_Stock", null);
            return dt;
        }
        internal DataTable Select_moneyStock(int id)
        {
            DataAccessLayer da = new DataAccessLayer();
            DataTable dt = new DataTable();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id_Treasury", SqlDbType.Int);
            param[0].Value = id;

            dt = da.selected("Select_moneyStock", param);
            return dt;
        }
        internal void add_stockData(int id)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id_Treasury", SqlDbType.Int);
            param[0].Value = id;
            da.excutequery("add_stockData", param);
            da.close();
        }

        internal void add_insertStock(int id, decimal money, DateTime date, string name, string reason)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@id_Treasury", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@Money", SqlDbType.Real);
            param[1].Value = money;
            param[2] = new SqlParameter("@Date", SqlDbType.DateTime);
            param[2].Value = date;
            param[3] = new SqlParameter("@Name", SqlDbType.NVarChar, 250);
            param[3].Value = name;
      
            param[4] = new SqlParameter("@Reason", SqlDbType.NVarChar, 250);
            param[4].Value = reason;
            da.excutequery("add_insertStock", param);
            da.close();
        }

        internal void Add_StockPull(int id, decimal money, DateTime date, string name, string reason)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@id_Treasury", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@Money", SqlDbType.Decimal);
            param[1].Value = money;
            param[2] = new SqlParameter("@Date", SqlDbType.DateTime);
            param[2].Value = date;
            param[3] = new SqlParameter("@Name", SqlDbType.NVarChar, 250);
            param[3].Value = name;

            param[4] = new SqlParameter("@Reason", SqlDbType.NVarChar, 250);
            param[4].Value = reason;
            da.excutequery("Add_StockPull", param);
            da.close();
        }

        internal void Add_StockTransfair(decimal money, DateTime date,int Id_StockFrom ,string from,int Id_StockTo, string to, string name, string reason)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[8];
            param[0] = new SqlParameter("@Money", SqlDbType.Real);
            param[0].Value = money;
            param[1] = new SqlParameter("@Date", SqlDbType.DateTime);
            param[1].Value = date;
            param[2] = new SqlParameter("@Id_StockFroms", SqlDbType.Int);
            param[2].Value = Id_StockFrom;
            param[3] = new SqlParameter("@From_", SqlDbType.NVarChar, 50);
            param[3].Value = from;
            param[4] = new SqlParameter("@Id_StockTo", SqlDbType.Int);
            param[4].Value = Id_StockTo;
            param[5] = new SqlParameter("@To_", SqlDbType.NVarChar, 50);
            param[5].Value = to;
            param[6] = new SqlParameter("@Name", SqlDbType.NVarChar, 75);
            param[6].Value = name;
            param[7] = new SqlParameter("@Reason", SqlDbType.NVarChar, 150);
            param[7].Value = reason;
            da.excutequery("Add_StockTransfair", param);
            da.close();
        }

        internal DataTable Insert_Stock()
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            DataTable dt = new DataTable();
            dt = da.selected("Insert_Stock", null);
            return dt;
        }
        internal DataTable Search_Insert_Stock(DateTime dateFrom, DateTime DateTo)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@data_from", SqlDbType.DateTime);
            param[0].Value = dateFrom;
            param[1] = new SqlParameter("@data_to", SqlDbType.DateTime);
            param[1].Value = DateTo;
            dt = da.selected("Search_Insert_Stock", param);
            return dt;
        }

        internal DataTable Reprot_StockPull(int Id_Stock)
        {
            DataAccessLayer da = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id_Stock", SqlDbType.Int);
            param[0].Value = Id_Stock;
            da.open();
            DataTable dt = new DataTable();
            dt = da.selected("Reprot_StockPull", param);
            return dt;
        }

        internal DataTable Search_ReprotStockPull(int Id_Stock,DateTime dateFrom, DateTime DateTo)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@id_Stock", SqlDbType.Int);
            param[0].Value = Id_Stock;
            param[1] = new SqlParameter("@Date_From", SqlDbType.DateTime);
            param[1].Value = dateFrom;
            param[2] = new SqlParameter("@Date_to", SqlDbType.DateTime);
            param[2].Value = DateTo;
            dt = da.selected("Search_ReprotStockPull", param);
            return dt;
        }

        internal void DeletePullStock(int id_stock, DateTime date, decimal money)
        {

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@id_stock", SqlDbType.Int);
            param[0].Value = id_stock;
            param[1] = new SqlParameter("@Date", SqlDbType.DateTime);
            param[1].Value = date;
            param[2] = new SqlParameter("@Money", SqlDbType.Real);
            param[2].Value = money;
            da.selected("DeletePullStock", param);
            da.close();
        }


        internal DataTable SelectStockBranch(int Id_branch)
        {
            DataAccessLayer da = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@idbranch", SqlDbType.Int);
            param[0].Value = Id_branch;
            da.open();
            DataTable dt = new DataTable();
            dt = da.selected("SelectStockBranch", param);
            return dt;
        }
        internal DataTable Report_InsertStock(int Id_Stock)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id_Stock", SqlDbType.Int);
            param[0].Value = Id_Stock;
            
            dt = da.selected("Report_InsertStock", param);
            return dt;
        }
        internal DataTable Search_Report_InsertStock(int Id_Stock, DateTime dateFrom, DateTime DateTo)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@id_Stock", SqlDbType.Int);
            param[0].Value = Id_Stock;
            param[1] = new SqlParameter("@Date_From", SqlDbType.DateTime);
            param[1].Value = dateFrom;
            param[2] = new SqlParameter("@Date_to", SqlDbType.DateTime);
            param[2].Value = DateTo;
            dt = da.selected("Search_Report_InsertStock", param);
            return dt;
        }
        internal DataTable Report_TransfairStock()
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            DataTable dt = new DataTable();
     
            dt = da.selected("Report_TransfairStock",null);
            return dt;
        }
        internal DataTable Search_Report_TransfairStock(DateTime dateFrom, DateTime DateTo)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];
            param[1] = new SqlParameter("@Date_From", SqlDbType.DateTime);
            param[1].Value = dateFrom;
            param[2] = new SqlParameter("@Date_to", SqlDbType.DateTime);
            param[2].Value = DateTo;
            dt = da.selected("Search_Report_TransfairStock", param);
            return dt;
        }

    }
}
