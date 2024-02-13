using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Tourism_Company.DAL;

namespace Tourism_Company.BL
{
    class Bank
    {
        internal void add_bank(int id ,string name , string number)
        {
            DataAcssesLayer da = new DataAcssesLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@id_bank", SqlDbType.NVarChar, 150);
            param[0].Value = id;
            param[1] = new SqlParameter("@BANK_NAME", SqlDbType.NVarChar, 150);
            param[1].Value = name;
            param[2] = new SqlParameter("@Account_Num", SqlDbType.VarChar, 50);
            param[2].Value = number;
            da.excutequery("add_bank", param);
            da.close();
        }
        internal void Update_bank(int id, string name ,string number )
        {
            DataAcssesLayer da = new DataAcssesLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@ID_BANK", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@BANK_NAME", SqlDbType.NVarChar, 150);
            param[1].Value = name;
            param[2] = new SqlParameter("@Account_Num", SqlDbType.VarChar, 50);
            param[2].Value = number;
            da.excutequery("Update_bank", param);
            da.close();


        }

        internal void Delete_bank(int id)
        {
            DataAcssesLayer da = new DataAcssesLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID_BANK", SqlDbType.Int);
            param[0].Value = id;
            da.excutequery("Delete_bank", param);
            da.close();
        }
        internal DataTable select_bank()
        {
            DataAcssesLayer da = new DataAcssesLayer();
            DataTable dt = new DataTable();
            da.open();
            dt = da.selected("select_bank", null);

            return dt;
        }
        internal DataTable Select_LastIdBank()
        {
            DataAcssesLayer da = new DataAcssesLayer();
            DataTable dt = new DataTable();
            da.open();
            dt = da.selected("Select_LastIdBank", null);

            return dt;
        }
        internal DataTable Compo_Bank()
        {
            DataAcssesLayer da = new DataAcssesLayer();
            da.open();
            DataTable dt = new DataTable();
            dt = da.selected("Compo_Bank", null);
            return dt;
        }
        internal DataTable Select_moneyBank(int id)
        {
            DataAcssesLayer da = new DataAcssesLayer();
            DataTable dt = new DataTable();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID_BANK", SqlDbType.Int);
            param[0].Value = id;

            dt = da.selected("Select_moneyBank", param);
            return dt;
        }
        internal void Add_BankData(int id)
        {
            DataAcssesLayer da = new DataAcssesLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID_BANK", SqlDbType.Int);
            param[0].Value = id;
            da.excutequery("Add_BankData", param);
            da.close();
        }

        internal void add_insertBank(int id, decimal money, DateTime date, string name, string type, string reason)
        {
            DataAcssesLayer da = new DataAcssesLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@ID_BANK", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@Money", SqlDbType.Real);
            param[1].Value = money;
            param[2] = new SqlParameter("@Date", SqlDbType.DateTime);
            param[2].Value = date;
            param[3] = new SqlParameter("@Name", SqlDbType.NVarChar, 250);
            param[3].Value = name;
            param[4] = new SqlParameter("@Type", SqlDbType.NVarChar, 250);
            param[4].Value = type;
            param[5] = new SqlParameter("@Reason", SqlDbType.NVarChar, 250);
            param[5].Value = reason;
            da.excutequery("add_insertBank", param);
            da.close();
        }

        internal void Add_BankPull(int id, decimal money, DateTime date, string name, string type, string reason)
        {
            DataAcssesLayer da = new DataAcssesLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@id_bank", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@Money", SqlDbType.Real);
            param[1].Value = money;
            param[2] = new SqlParameter("@Date", SqlDbType.DateTime);
            param[2].Value = date;
            param[3] = new SqlParameter("@Name", SqlDbType.NVarChar, 250);
            param[3].Value = name;
            param[4] = new SqlParameter("@Type", SqlDbType.NVarChar, 250);
            param[4].Value = type;
            param[5] = new SqlParameter("@Reason", SqlDbType.NVarChar, 250);
            param[5].Value = reason;
            da.excutequery("Add_BankPull", param);
            da.close();
        }
        internal DataTable Insert_bank()
        {
            DataAcssesLayer da = new DataAcssesLayer();
            da.open();
            DataTable dt = new DataTable();
            dt = da.selected("Insert_bank", null);
            return dt;


        }
        internal DataTable Search_InserBank(DateTime dateFrom, DateTime DateTo)
        {
            DataAcssesLayer da = new DataAcssesLayer();
            da.open();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@data_from", SqlDbType.DateTime);
            param[0].Value = dateFrom;
            param[1] = new SqlParameter("@data_to", SqlDbType.DateTime);
            param[1].Value = DateTo;
            dt = da.selected("Search_InserBank", param);
            return dt;


        }
        internal DataTable Report_PullBank()
        {
            DataAcssesLayer da = new DataAcssesLayer();
            da.open();
            DataTable dt = new DataTable();
            dt = da.selected("Report_PullBank", null);
            return dt;


        }
        internal DataTable Search_PullBank(DateTime dateFrom, DateTime DateTo)
        {
            DataAcssesLayer da = new DataAcssesLayer();
            da.open();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@data_from", SqlDbType.DateTime);
            param[0].Value = dateFrom;
            param[1] = new SqlParameter("@data_to", SqlDbType.DateTime);
            param[1].Value = DateTo;
            dt = da.selected("Search_PullBank", param);
            return dt;


        }
    }
}
