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
        internal void Add_SupplierTotalMoney(int Id_Supplier)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Id_Suppliers", SqlDbType.Int);
            param[0].Value = Id_Supplier;
       
            da.excutequery("Add_SupplierTotalMoney", param);
            da.close();

        }
        internal void Update_SupplierTotalMoney(int Id_Supplier , decimal Total_Money)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@Id_Suppliers", SqlDbType.Int);
            param[0].Value = Id_Supplier;
            param[1] = new SqlParameter("@Total_Money", SqlDbType.Decimal);
            param[1].Value = Total_Money;
            da.excutequery("Update_SupplierTotalMoney", param);
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
        internal DataTable select_LastIdSupplier()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();

            dt = da.selected("select_LastIdSupplier", null);
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

        internal void ADDSuppliersINFORMARION( int SupID, DateTime date, string note, string salesMan,
              decimal total_invoic, decimal pay, decimal rent, int Id_Stock)
        {

            DataAccessLayer da = new DataAccessLayer();


            da.open();
            SqlParameter[] param = new SqlParameter[8];

            param[0] = new SqlParameter("@sup_id", SqlDbType.Int);
            param[0].Value = SupID;
            param[1] = new SqlParameter("@date", SqlDbType.DateTime);
            param[1].Value = date;
            param[2] = new SqlParameter("@note", SqlDbType.NVarChar, 350);
            param[2].Value = note;
            param[3] = new SqlParameter("@salesMan", SqlDbType.NVarChar, 50);
            param[3].Value = salesMan;
            param[4] = new SqlParameter("@Total_Invoic", SqlDbType.Decimal);
            param[4].Value = total_invoic;
            param[5] = new SqlParameter("@pay", SqlDbType.Decimal);
            param[5].Value = pay;
            param[6] = new SqlParameter("@rent", SqlDbType.Decimal);
            param[6].Value = rent;
            param[7] = new SqlParameter("@id_stock", SqlDbType.Int);
            param[7].Value = Id_Stock;

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
        internal DataTable Combo_SupplierRent()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            dt.Clear();
            dt = da.selected("Combo_SupplierRent", null);
            da.close();
            return dt;
        }
        internal DataTable SelectSuppliersMony()
        {
            DataAccessLayer da = new DataAccessLayer();
            DataTable dt = new DataTable();
            dt.Clear();
            dt = da.selected("SelectSuppliersMony", null);
            da.close();
            return dt;

        }
        internal DataTable SelectOneSuppliersMony(int Sup_id)
        {
            DataTable dt = new DataTable();
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Sup_id", SqlDbType.Int);
            param[0].Value = Sup_id;
            dt.Clear();
            dt = da.selected("SelectOneSuppliersMony", param);
            da.close();
            return dt;
        }
        internal void AddPaySuppliers( int id_sup, decimal pay, DateTime date, int Id_stock , string salesMan)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@id_Supp", SqlDbType.Int);
            param[0].Value = id_sup;
            param[1] = new SqlParameter("@pay", SqlDbType.Decimal);
            param[1].Value = pay;
            param[2] = new SqlParameter("@date", SqlDbType.DateTime);
            param[2].Value = date;
            param[3] = new SqlParameter("@Id_stock", SqlDbType.Int);
            param[3].Value = Id_stock;
            param[4] = new SqlParameter("@sales_man", SqlDbType.NVarChar,50);
            param[4].Value = salesMan;
            da.excutequery("AddPaySuppliers", param);
            da.close();
        }
        internal DataTable Select_DepitSupplier()
        {
            DataTable dt = new DataTable();
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            dt = da.selected("Select_DepitSupplier", null);
            return dt;
        }
        internal DataTable Report_PaySupplier(int Id_Suppliers)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Id_Suppliers", SqlDbType.Int);
            param[0].Value = Id_Suppliers;
            dt = da.selected("Report_PaySupplier", null);
            da.close();
            return dt;
        }
        internal DataTable Search_PaySupplier(string id)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.NVarChar, 100);
            param[0].Value = id;

            dt = da.selected("Search_PaySupplier", param);
            da.close();
            return dt;
        }
        internal DataTable Search_PaySupplierDateAndName(int Id_Suppliers ,DateTime Date_From ,DateTime Date_To)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@Id_Suppliers", SqlDbType.Int);
            param[0].Value = Id_Suppliers;
            param[1] = new SqlParameter("@date_from", SqlDbType.Date);
            param[1].Value = Date_From;
            param[2] = new SqlParameter("@date_to", SqlDbType.Date);
            param[2].Value = Date_To;
            dt = da.selected("Search_PaySupplierDateAndName", param);
            da.close();
            return dt;
        }
        internal DataTable Search_PaySupplierDate( DateTime Date_From, DateTime Date_To)
        {
            DataTable dt = new DataTable();
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[2];        
            param[0] = new SqlParameter("@date_from", SqlDbType.Date);
            param[0].Value = Date_From;
            param[1] = new SqlParameter("@date_to", SqlDbType.Date);
            param[1].Value = Date_To;
            dt = da.selected("Search_PaySupplierDate", param);
            da.close();
            return dt;
        }
        internal DataTable select_IdPurshasing()
        {
            DataAccessLayer da = new DataAccessLayer();
            DataTable dt = new DataTable();
            dt = da.selected("select_IdPurshasing", null);
            da.close();
            return dt;

        }
        internal DataTable Select_SupplierInformation(int Id_Information)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID_Information", SqlDbType.Int);
            param[0].Value = Id_Information;

            dt = da.selected("Select_SupplierInformation", param);
            da.close();
            return dt;
        }
        internal DataTable Select_SupplierDetailsForReturn(int Id_Information)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID_Information", SqlDbType.Int);
            param[0].Value = Id_Information;

            dt = da.selected("Select_SupplierDetailsForReturn", param);
            da.close();
            return dt;
        }
        internal void Add_SupplierReturn(int Id_Information, int Id_Product, decimal Price,Decimal Quantity, DateTime Date,
                                         Decimal  Total_Return, string salesMan , int Id_Store)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[8];
            param[0] = new SqlParameter("@Id_Information", SqlDbType.Int);
            param[0].Value = Id_Information;
            param[1] = new SqlParameter("@Id_product", SqlDbType.Int);
            param[1].Value = Id_Product;
            param[2] = new SqlParameter("@price", SqlDbType.Decimal);
            param[2].Value = Price;
            param[3] = new SqlParameter("@return_quantity", SqlDbType.Decimal);
            param[3].Value = Quantity;
            param[4] = new SqlParameter("@date_return", SqlDbType.DateTime);
            param[4].Value = Date;
            param[5] = new SqlParameter("@Total_Return", SqlDbType.Decimal);
            param[5].Value = Total_Return;
            param[6] = new SqlParameter("@Sales_Man", SqlDbType.NVarChar, 100);
            param[6].Value = salesMan;
            param[7] = new SqlParameter("@Id_Store", SqlDbType.Int);
            param[7].Value = Id_Store;
            da.excutequery("Add_SupplierReturn", param);
            da.close();
        }
        internal DataTable Validate_SuppliersName(int Id_Supplier)
        {
            DataTable dt = new DataTable();
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID_Sup", SqlDbType.Int);
            param[0].Value = Id_Supplier;
            dt = da.selected("Validate_SuppliersName", param);
            da.close();
            return dt;
        }
        internal DataTable SelectSupplierInovice(int Id_Supplier)
        {
            DataTable dt = new DataTable();
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Id_Sup", SqlDbType.Int);
            param[0].Value = Id_Supplier;
            dt = da.selected("SelectSupplierInovice", param);
            da.close();
            return dt;
        }
        internal DataTable Select_SupplierReturn(int Id_information)
        {
            DataTable dt = new DataTable();
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID_Information", SqlDbType.Int);
            param[0].Value = Id_information;
            dt = da.selected("Select_SupplierReturn", param);
            da.close();
            return dt;
        }
        internal DataTable Validate_IdSupplierInformation(int Id_information)
        {
            DataTable dt = new DataTable();
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Id_Infromation", SqlDbType.Int);
            param[0].Value = Id_information;
            dt = da.selected("Validate_IdSupplierInformation", param);
            da.close();
            return dt;
        }
        internal DataTable Report_PurshasesInvoice()
        {
            DataTable dt = new DataTable();
            DataAccessLayer da = new DataAccessLayer();
            dt = da.selected("Report_PurshasesInvoice", null);
            da.close();
            return dt;
        }
        internal DataTable SearchReport_PurshasesInvoice(DateTime Date_From , DateTime Date_To)
        {
            DataTable dt = new DataTable();
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@Date_From", SqlDbType.Date);
            param[0].Value = Date_From;
            param[1] = new SqlParameter("@Date_To", SqlDbType.Date);
            param[1].Value = Date_To;
            dt = da.selected("SearchReport_PurshasesInvoice", param);
            da.close();
            return dt;
        }
        internal void Add_SupplierStatmentACCount(int Id_Suppliers,decimal Da2n, decimal Maden, decimal Balance, string Elbyan,DateTime Date)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@ID_Suppliers", SqlDbType.Int);
            param[0].Value = Id_Suppliers;
            param[1] = new SqlParameter("@D2An", SqlDbType.Decimal);
            param[1].Value = Da2n;
            param[2] = new SqlParameter("@Maden", SqlDbType.Decimal);
            param[2].Value = Maden;
            param[3] = new SqlParameter("@Balance", SqlDbType.Decimal);
            param[3].Value = Balance;
            param[4] = new SqlParameter("@Elbyan", SqlDbType.NVarChar,200);
            param[4].Value = Elbyan;
            param[5] = new SqlParameter("@Date", SqlDbType.DateTime);
            param[5].Value = Date;
            da.excutequery("Add_SupplierStatmentACCount", param);
            da.close();
        }

        internal DataTable Select_SupplierTotalMoney(int Id_Suppliers)
        {
            DataTable dt = new DataTable();
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id_Suppliers", SqlDbType.Int);
            param[0].Value = Id_Suppliers;
            dt = da.selected("Select_SupplierTotalMoney", param);
            da.close();
            return dt;
        }

        internal DataTable ReportReurnSuppliers(DateTime Date_From, DateTime Date_To)
        {
            DataTable dt = new DataTable();
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@FromDate", SqlDbType.Date);
            param[0].Value = Date_From;
            param[1] = new SqlParameter("@ToDate", SqlDbType.Date);
            param[1].Value = Date_To;
            dt = da.selected("ReportReurnSuppliers", param);
            da.close();
            return dt;
        }
    }
}
