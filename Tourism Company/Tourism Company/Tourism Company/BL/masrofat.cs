using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using Tourism_Company.DAL;

namespace Tourism_Company.BL
{
    class masrofat
    {
        internal void Add_masrof(string name, decimal amount, DateTime date, string descrpsion,int id_stock , string Stock_name)
        {
            DataAcssesLayer da = new DataAcssesLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@Masrof_Name", SqlDbType.NVarChar, 100);
            param[0].Value = name;
            param[1] = new SqlParameter("@amount", SqlDbType.Decimal);
            param[1].Value = amount;
            param[2] = new SqlParameter("@date", SqlDbType.DateTime);
            param[2].Value = date;
            param[3] = new SqlParameter("@descrpsion", SqlDbType.NVarChar, 100);
            param[3].Value = descrpsion;
            param[4] = new SqlParameter("@stock_id", SqlDbType.Int);
            param[4].Value = id_stock;
            param[5] = new SqlParameter("@stock_name", SqlDbType.NVarChar, 100);
            param[5].Value = Stock_name;
            da.excutequery("Add_masrof", param);
            da.close();
        }

        internal void Update_masrof(int id, string name, decimal amount, DateTime date, string descrpsion, int id_stock, string Stock_name)
        {
            DataAcssesLayer da = new DataAcssesLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[7];

            param[0] = new SqlParameter("@id_masrof", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@Masrof_Name", SqlDbType.NVarChar, 100);
            param[1].Value = name;
            param[2] = new SqlParameter("@amount", SqlDbType.Decimal);
            param[2].Value = amount;
            param[3] = new SqlParameter("@date", SqlDbType.DateTime);
            param[3].Value = date;
            param[4] = new SqlParameter("@descrpsion", SqlDbType.NVarChar, 100);
            param[4].Value = descrpsion;
            param[5] = new SqlParameter("@stock_id", SqlDbType.Int);
            param[5].Value = id_stock;
            param[6] = new SqlParameter("@stock_name", SqlDbType.NVarChar, 100);
            param[6].Value = Stock_name;
            da.excutequery("Update_masrof", param);
            da.close();
        }

        internal void Delete_masrof(int id)
        {
            DataAcssesLayer da = new DataAcssesLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id_masrof", SqlDbType.Int);
            param[0].Value = id;
            da.excutequery("Delete_masrof", param);
            da.close();

        }

        internal DataTable Select_masrofat()
        {
            DataAcssesLayer da = new DataAcssesLayer();
            da.open();
            DataTable dt = new DataTable();
            dt = da.selected("Select_masrofat", null);
            return dt;
        }

        internal DataTable Searech_masrofat(string id)
        {
            DataAcssesLayer da = new DataAcssesLayer();
            da.open();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.NVarChar, 100);
            param[0].Value = id;
            dt = da.selected("Searech_masrofat", param);
            da.close();
            return dt;

        }
        internal DataTable Searech_masrofatDate(DateTime DAtefrom, DateTime DateTo)
        {
            DataAcssesLayer da = new DataAcssesLayer();
            da.open();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@Datefrom", SqlDbType.DateTime);
            param[0].Value = DAtefrom;
            param[1] = new SqlParameter("@DateTo", SqlDbType.DateTime);
            param[1].Value = DateTo;
            dt = da.selected("Searech_masrofatDate", param);
            da.close();
            return dt;

        }
    }
}
