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
    class Suppliers
    {
        internal void addSuppliers(string name, string address, string phone)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            param[0].Value = name;
            param[1] = new SqlParameter("@address", SqlDbType.NVarChar, 50);
            param[1].Value = address;
            param[2] = new SqlParameter("@phone", SqlDbType.VarChar, 50);
            param[2].Value = phone;


            da.excutequery("addSuppliers", param);
            da.close();
        }
        internal DataTable SelectSuppliers()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();

            dt = da.selected("SelectSuppliers", null);
            da.close();
            return dt;
        }
        internal DataTable SearchSuppliers(string id)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.NVarChar, 50);
            param[0].Value = id;

            dt = da.selected("SearchSuppliers", param);
            da.close();
            return dt;
        }
        internal void UpdateSuppliers(string name, string address, string phone, int id)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            param[0].Value = name;
            param[1] = new SqlParameter("@address", SqlDbType.NVarChar, 50);
            param[1].Value = address;
            param[2] = new SqlParameter("@phone", SqlDbType.VarChar, 50);
            param[2].Value = phone;
            param[3] = new SqlParameter("@id", SqlDbType.Int);
            param[3].Value = id;
            da.excutequery("UpdateSuppliers", param);
            da.close();
        }

        internal DataTable CompoBoxSuppliers()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();

            dt = da.selected("CompoBoxSuppliers", null);
            da.close();
            return dt;
        }

        internal void ADDSuppliersINFORMARION(int ID, int SupID, DateTime date, string note, string salesMan,
              decimal total_invoic, decimal pay, decimal rent, int Id_Stock)
        {

            DataAccessLayer da = new DataAccessLayer();


            da.open();
            SqlParameter[] param = new SqlParameter[9];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = ID;
            param[1] = new SqlParameter("@sup_id", SqlDbType.Int);
            param[1].Value = SupID;
            param[2] = new SqlParameter("@date", SqlDbType.DateTime);
            param[2].Value = date;
            param[3] = new SqlParameter("@note", SqlDbType.NVarChar, 350);
            param[3].Value = note;
            param[4] = new SqlParameter("@salesMan", SqlDbType.NVarChar, 50);
            param[4].Value = salesMan;
            param[5] = new SqlParameter("@Total_Invoic", SqlDbType.Decimal);
            param[5].Value = total_invoic;
            param[6] = new SqlParameter("@pay", SqlDbType.Decimal);
            param[6].Value = pay;
            param[7] = new SqlParameter("@rent", SqlDbType.Decimal);
            param[7].Value = rent;

            param[8] = new SqlParameter("@id_stock", SqlDbType.Int);
            param[8].Value = Id_Stock;

            da.excutequery("ADDSuppliersINFORMARION", param);
            da.close();

        }
        internal DataTable LastSuppliersDetalis()
        {
            DataAccessLayer da = new DataAccessLayer();
            DataTable dt = new DataTable();
            dt = da.selected("LastSuppliersDetalis", null);
            da.close();
            return dt;

        }
        internal void addSuppliersDetails(int id,int Id_Store , int IDProudect, int quantity,
         decimal prise, decimal amount, decimal discount, decimal totalAmount)
        {

            DataAccessLayer da = new DataAccessLayer();


            da.open();
            SqlParameter[] param = new SqlParameter[8];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@Id_Store", SqlDbType.Int);
            param[1].Value = Id_Store;
            param[2] = new SqlParameter("@idProd", SqlDbType.Int);
            param[2].Value = IDProudect;
            param[3] = new SqlParameter("@quantity", SqlDbType.Int);
            param[3].Value = quantity;
            param[4] = new SqlParameter("@Price", SqlDbType.Decimal);
            param[4].Value = prise;
            param[5] = new SqlParameter("@Amount", SqlDbType.Decimal);
            param[5].Value = amount;
            param[6] = new SqlParameter("@Discount", SqlDbType.Decimal);
            param[6].Value = discount;
            param[7] = new SqlParameter("@TotalAmount", SqlDbType.Decimal);
            param[7].Value = totalAmount;
            da.excutequery("addSuppliersDetails", param);
            da.close();

        }
    }
}
