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
    class Installment
    {
        internal void Addinstallment(DateTime dateinstallment, decimal money, string username, int idstock,  int IDinstallmentType)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@date", SqlDbType.DateTime);
            param[0].Value = dateinstallment;
            param[1] = new SqlParameter("@money", SqlDbType.Decimal);
            param[1].Value = money;
            param[2] = new SqlParameter("@userName", SqlDbType.NVarChar, 50);
            param[2].Value = username;

            param[3] = new SqlParameter("@idStock", SqlDbType.Int);
            param[3].Value = idstock;
            param[4] = new SqlParameter("@idinstallmentType", SqlDbType.Int);
            param[4].Value = IDinstallmentType;



            da.excutequery("Addinstallment", param);

            da.close();

        }
        internal void AddinstallmentType(string name)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Name", SqlDbType.NVarChar, 100);
            param[0].Value = name;




            da.excutequery("AddinstallmentType", param);

            da.close();

        }

        internal void Updateinstallment(DateTime dateinstallment, decimal money,  int IDinstallmentType,int IDinstallment)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@date", SqlDbType.DateTime);
            param[0].Value = dateinstallment;
            param[1] = new SqlParameter("@money", SqlDbType.Decimal);
            param[1].Value = money;
            param[2] = new SqlParameter("@idinstallmentType", SqlDbType.Int);
            param[2].Value = IDinstallmentType;
            param[3] = new SqlParameter("@idinstallment", SqlDbType.Int);
            param[3].Value = IDinstallment;


            da.excutequery("Updateinstallment", param);

            da.close();

        }
        internal DataTable Selectinstallment()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            dt = da.selected("Selectinstallment", null);
            da.close();
            return dt;
        }
        internal DataTable Searchinstallment(string name)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.NVarChar, 50);
            param[0].Value = name;

            dt = da.selected("Searchinstallment", param);
            da.close();
            return dt;
        }

        internal DataTable selectcompoinstallmentType()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            dt = da.selected("selectcompoinstallmentType", null);
            da.close();
            return dt;
        }

        internal DataTable SelectFromDateinstallment( DateTime Date_From, DateTime Date_To)
        {
            DataAccessLayer da = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];
     
            param[0] = new SqlParameter("@fromdate", SqlDbType.DateTime);
            param[0].Value = Date_From;
            param[1] = new SqlParameter("@todate", SqlDbType.DateTime);
            param[1].Value = Date_To;
            da.open();
            DataTable dt = new DataTable();
            dt.Clear();
            dt = da.selected("SelectFromDateinstallment", param);
            da.close();
            return dt;
        }
    }
}
