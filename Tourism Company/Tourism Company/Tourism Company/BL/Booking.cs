using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tourism_Company.DAL;
using System.Data;
using System.Data.SqlClient;

namespace Tourism_Company.BL
{
    class Booking
    {
        internal DataTable selectCompanyRent()
        {
            DataAcssesLayer da = new DataAcssesLayer();
            DataTable dt = new DataTable();
            da.open();
            dt = da.selected("selectCompanyRent", null);
            da.close();
            return dt;


        }
        internal DataTable selectOneCompanyRent(int id)
        {
            DataAcssesLayer da = new DataAcssesLayer();
            DataTable dt = new DataTable();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            dt = da.selected("selectOneCompanyRent", param);
            da.close();
            return dt;


        }
        internal DataTable selectOneClientRent(int id)
        {
            DataAcssesLayer da = new DataAcssesLayer();
            DataTable dt = new DataTable();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            dt = da.selected("selectOneClientRent", param);
            da.close();
            return dt;


        }
        internal DataTable selectClientRent()
        {
            DataAcssesLayer da = new DataAcssesLayer();
            DataTable dt = new DataTable();
            da.open();
            dt = da.selected("selectClientRent", null);
            da.close();
            return dt;


        }
        internal DataTable clienttLastID()
        {
            DataAcssesLayer da = new DataAcssesLayer();
            DataTable dt = new DataTable();
            da.open();
            dt = da.selected("clienttLastID", null);
            da.close();
            return dt;


        }
        internal DataTable CompanytLastID()
        {
            DataTable dt = new DataTable();

            DataAcssesLayer da = new DataAcssesLayer();
            da.open();
            dt = da.selected("CompanytLastID", null);
            da.close();
            return dt;
        }
        internal void AddClientBooking(int bokiong_id,DateTime BOKKING_date,int id_client ,int id_plane, string city_mo8adra,
    long tripple_num, DateTime triple_date, string CityofArrival, decimal basic, decimal total, decimal commissin, decimal commissinMoney,
    decimal priceForClient, decimal pay, decimal rent,string note ,int id_bank)
        {

            DataAcssesLayer da = new DataAcssesLayer();


            da.open();
            SqlParameter[] param = new SqlParameter[17];
            param[0] = new SqlParameter("@booking_id", SqlDbType.Int);
            param[0].Value = bokiong_id;
            param[1] = new SqlParameter("@BOKKING_date", SqlDbType.DateTime);
            param[1].Value = BOKKING_date;
            param[2] = new SqlParameter("@id_client", SqlDbType.Int);
            param[2].Value = id_client;

            param[3] = new SqlParameter("@id_plane", SqlDbType.Int);
            param[3].Value = id_plane;
            param[4] = new SqlParameter("@city_mo8adra", SqlDbType.NVarChar, 500);
            param[4].Value = city_mo8adra;
            param[5] = new SqlParameter("@triple_num", SqlDbType.BigInt);
            param[5].Value = tripple_num;
            param[6] = new SqlParameter("@triple_date", SqlDbType.DateTime);
            param[6].Value = triple_date;
            param[7] = new SqlParameter("@CityofArrival", SqlDbType.NVarChar, 500);
            param[7].Value = CityofArrival;

            param[8] = new SqlParameter("@basic", SqlDbType.Decimal);
            param[8].Value = basic;
            param[9] = new SqlParameter("@total", SqlDbType.Decimal);
            param[9].Value = total;
            param[10] = new SqlParameter("@commissin", SqlDbType.Decimal);
            param[10].Value = commissin;
            param[11] = new SqlParameter("@commissinMoney", SqlDbType.Decimal);
            param[11].Value = commissinMoney;

            param[12] = new SqlParameter("@priceForClient", SqlDbType.Decimal);
            param[12].Value = priceForClient;
            param[13] = new SqlParameter("@pay", SqlDbType.Decimal);
            param[13].Value = pay;
            param[14] = new SqlParameter("@rent", SqlDbType.Decimal);
            param[14].Value = rent;
            param[15] = new SqlParameter("@note", SqlDbType.NVarChar, 100);
            param[15].Value = note;
            param[16] = new SqlParameter("@ID_bank", SqlDbType.Int);
            param[16].Value = id_bank;

            da.excutequery("AddClientBooking", param);
            da.close();

        }

        internal void AddCompanyBooking(DateTime BOKKING_date, string client_name,int plane, string city_mo8adra,
long tripple_num, DateTime triple_date, string CityofArrival, decimal basic, decimal total, decimal commissin, decimal commissinMoney,
decimal priceForClient, decimal pay, decimal rent,int id_comany,int boking_id , string note , int id_bank)
        {

            DataAcssesLayer da = new DataAcssesLayer();


            da.open();
            SqlParameter[] param = new SqlParameter[18];
            param[0] = new SqlParameter("@BOKKING_date", SqlDbType.DateTime);
            param[0].Value = BOKKING_date;
            param[1] = new SqlParameter("@Client_Name", SqlDbType.NVarChar,250);
            param[1].Value = client_name;
        
            param[2] = new SqlParameter("@id_plane", SqlDbType.Int);
            param[2].Value = plane;
            param[3] = new SqlParameter("@city_mo8adra", SqlDbType.NVarChar, 500);
            param[3].Value = city_mo8adra;
            param[4] = new SqlParameter("@triple_num", SqlDbType.BigInt);
            param[4].Value = tripple_num;
            param[5] = new SqlParameter("@triple_date", SqlDbType.DateTime);
            param[5].Value = triple_date;
            param[6] = new SqlParameter("@CityofArrival", SqlDbType.NVarChar, 500);
            param[6].Value = CityofArrival;

            param[7] = new SqlParameter("@basic", SqlDbType.Decimal);
            param[7].Value = basic;
            param[8] = new SqlParameter("@total", SqlDbType.Decimal);
            param[8].Value = total;
            param[9] = new SqlParameter("@commissin", SqlDbType.Decimal);
            param[9].Value = commissin;
            param[10] = new SqlParameter("@commissinMoney", SqlDbType.Decimal);
            param[10].Value = commissinMoney;

            param[11] = new SqlParameter("@priceForClient", SqlDbType.Decimal);
            param[11].Value = priceForClient;
            param[12] = new SqlParameter("@pay", SqlDbType.Decimal);
            param[12].Value = pay;
            param[13] = new SqlParameter("@rent", SqlDbType.Decimal);
            param[13].Value = rent;
            param[14] = new SqlParameter("@ID_Company", SqlDbType.Int);
            param[14].Value = id_comany;
            param[15] = new SqlParameter("@boking_id", SqlDbType.Int);
            param[15].Value = boking_id;
            param[16] = new SqlParameter("@note", SqlDbType.NVarChar, 100);
            param[16].Value = note;
            param[17] = new SqlParameter("@ID_bank", SqlDbType.Int); ;
            param[17].Value = id_bank;



            da.excutequery("AddCompanyBooking", param);
            da.close();

        }

        internal DataTable selectClientTicket()
        {
            DataAcssesLayer da = new DataAcssesLayer();
            DataTable dt = new DataTable();
            da.open();
            dt = da.selected("selectClientTicket", null);
            da.close();
            return dt;


        }
        internal DataTable selectCompanyTicket()
        {
            DataAcssesLayer da = new DataAcssesLayer();
            DataTable dt = new DataTable();
            da.open();
            dt = da.selected("selectCompanyTicket", null);
            da.close();
            return dt;


        }
        internal DataTable SearchCompanyTicket(string id)
        {
            DataAcssesLayer da = new DataAcssesLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            da.open();
            param[0] = new SqlParameter("@id", SqlDbType.NVarChar, 100);
            param[0].Value = id;
            dt = da.selected("SearchCompanyTicket", param);
            da.close();
            return dt;


        }
        internal DataTable SearchClientTicket(string id)
        {
            DataAcssesLayer da = new DataAcssesLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            da.open();
            param[0] = new SqlParameter("@id", SqlDbType.NVarChar, 100);
            param[0].Value = id;
            dt = da.selected("SearchClientTicket", param);
            da.close();
            return dt;


        }

        internal DataTable ReturnClientBooking(int id)
        {
            DataAcssesLayer da = new DataAcssesLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            da.open();
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            dt = da.selected("ReturnClientBooking", param);
            da.close();
            return dt;


        }


        internal DataTable ReturnCompanyBooking(int id)
        {
            DataAcssesLayer da = new DataAcssesLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            da.open();
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            dt = da.selected("ReturnCompanyBooking", param);
            da.close();
            return dt;


        }
        internal void UpdateCompanyBooking(int bokiong_id, DateTime BOKKING_date, int id_plane, string city_mo8adra,
 long tripple_num, DateTime triple_date, string CityofArrival, decimal basic, decimal total, decimal commissin, decimal commissinMoney,
 decimal priceForClient, decimal pay, decimal rent , string note , int id_bank)
        {

            DataAcssesLayer da = new DataAcssesLayer();


            da.open();
            SqlParameter[] param = new SqlParameter[16];
            param[0] = new SqlParameter("@booking_id", SqlDbType.Int);
            param[0].Value = bokiong_id;
            param[1] = new SqlParameter("@BOKKING_date", SqlDbType.DateTime);
            param[1].Value = BOKKING_date;
       
            param[2] = new SqlParameter("@id_plane", SqlDbType.Int);
            param[2].Value = id_plane;
            param[3] = new SqlParameter("@city_mo8adra", SqlDbType.NVarChar, 500);
            param[3].Value = city_mo8adra;
            param[4] = new SqlParameter("@triple_num", SqlDbType.BigInt);
            param[4].Value = tripple_num;
            param[5] = new SqlParameter("@triple_date", SqlDbType.DateTime);
            param[5].Value = triple_date;
            param[6] = new SqlParameter("@CityofArrival", SqlDbType.NVarChar, 500);
            param[6].Value = CityofArrival;

            param[7] = new SqlParameter("@basic", SqlDbType.Decimal);
            param[7].Value = basic;
            param[8] = new SqlParameter("@total", SqlDbType.Decimal);
            param[8].Value = total;
            param[9] = new SqlParameter("@commissin", SqlDbType.Decimal);
            param[9].Value = commissin;
            param[10] = new SqlParameter("@commissinMoney", SqlDbType.Decimal);
            param[10].Value = commissinMoney;

            param[11] = new SqlParameter("@priceForClient", SqlDbType.Decimal);
            param[11].Value = priceForClient;
            param[12] = new SqlParameter("@pay", SqlDbType.Decimal);
            param[12].Value = pay;
            param[13] = new SqlParameter("@rent", SqlDbType.Decimal);
            param[13].Value = rent;
            param[14] = new SqlParameter("@note", SqlDbType.NVarChar, 100);
            param[14].Value = note;
            param[15] = new SqlParameter("@ID_bank", SqlDbType.Int); ;
            param[15].Value = id_bank;



            da.excutequery("UpdateCompanyBooking", param);
            da.close();

        }


        internal void UpdateClientBooking(int bokiong_id, DateTime BOKKING_date, int id_plane, string city_mo8adra,
long tripple_num, DateTime triple_date, string CityofArrival, decimal basic, decimal total, decimal commissin, decimal commissinMoney,
decimal priceForClient, decimal pay, decimal rent,string note ,int id_bank)
        {

            DataAcssesLayer da = new DataAcssesLayer();


            da.open();
            SqlParameter[] param = new SqlParameter[16];
            param[0] = new SqlParameter("@booking_id", SqlDbType.Int);
            param[0].Value = bokiong_id;
            param[1] = new SqlParameter("@BOKKING_date", SqlDbType.DateTime);
            param[1].Value = BOKKING_date;

            param[2] = new SqlParameter("@id_plane", SqlDbType.Int);
            param[2].Value = id_plane;
            param[3] = new SqlParameter("@city_mo8adra", SqlDbType.NVarChar, 500);
            param[3].Value = city_mo8adra;
            param[4] = new SqlParameter("@triple_num", SqlDbType.BigInt);
            param[4].Value = tripple_num;
            param[5] = new SqlParameter("@triple_date", SqlDbType.DateTime);
            param[5].Value = triple_date;
            param[6] = new SqlParameter("@CityofArrival", SqlDbType.NVarChar, 500);
            param[6].Value = CityofArrival;

            param[7] = new SqlParameter("@basic", SqlDbType.Decimal);
            param[7].Value = basic;
            param[8] = new SqlParameter("@total", SqlDbType.Decimal);
            param[8].Value = total;
            param[9] = new SqlParameter("@commissin", SqlDbType.Decimal);
            param[9].Value = commissin;
            param[10] = new SqlParameter("@commissinMoney", SqlDbType.Decimal);
            param[10].Value = commissinMoney;

            param[11] = new SqlParameter("@priceForClient", SqlDbType.Decimal);
            param[11].Value = priceForClient;
            param[12] = new SqlParameter("@pay", SqlDbType.Decimal);
            param[12].Value = pay;
            param[13] = new SqlParameter("@rent", SqlDbType.Decimal);
            param[13].Value = rent;
            param[14] = new SqlParameter("@note", SqlDbType.NVarChar,100);
            param[14].Value = note;
            param[15] = new SqlParameter("@ID_bank", SqlDbType.Int); ;
            param[15].Value = id_bank;


            da.excutequery("UpdateClientBooking", param);
            da.close();

        }
        internal void addPayClient(int id_client, decimal pay,decimal rent,DateTime pay_date,int id_booking)
        {
            DataAcssesLayer da = new DataAcssesLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@ID_client", SqlDbType.Int);
            param[0].Value = id_client;

            param[1] = new SqlParameter("@pay", SqlDbType.Decimal);
            param[1].Value = pay;
            param[2] = new SqlParameter("@rent", SqlDbType.Decimal);
            param[2].Value = rent;
            param[3] = new SqlParameter("@date_pay", SqlDbType.DateTime);
            param[3].Value = pay_date;
            param[4] = new SqlParameter("@id_Booking", SqlDbType.Int);
            param[4].Value = id_booking;

            da.excutequery("addPayClient", param);
            da.close();
        }

        internal void addPayCompany(int id_company, decimal pay, decimal rent, DateTime pay_date, int id_booking)
        {
            DataAcssesLayer da = new DataAcssesLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@ID_company", SqlDbType.Int);
            param[0].Value = id_booking;

            param[1] = new SqlParameter("@pay", SqlDbType.Decimal);
            param[1].Value = pay;
            param[2] = new SqlParameter("@rent", SqlDbType.Decimal);
            param[2].Value = rent;
            param[3] = new SqlParameter("@date_pay", SqlDbType.DateTime);
            param[3].Value = pay_date;
            param[4] = new SqlParameter("@id_Booking", SqlDbType.Int);
            param[4].Value = id_booking;

            da.excutequery("addPayCompany", param);
            da.close();
        }
        internal void Add_Arba7(int boking_id,DateTime BOKKING_date, string client_name, decimal commissinMoney,decimal priceForClient ,decimal Total )
        {

            DataAcssesLayer da = new DataAcssesLayer();


            da.open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@Booking_ID", SqlDbType.Int);
            param[0].Value = boking_id;
            param[1] = new SqlParameter("@Booking_date", SqlDbType.DateTime);
            param[1].Value = BOKKING_date;
            param[2] = new SqlParameter("@Name", SqlDbType.NVarChar, 150);
            param[2].Value = client_name;

            param[3] = new SqlParameter("@commission_Money", SqlDbType.Decimal);
            param[3].Value = commissinMoney;

            param[4] = new SqlParameter("@price_for_client", SqlDbType.Decimal);
            param[4].Value = priceForClient;

            param[5] = new SqlParameter("@Total", SqlDbType.Decimal);
            param[5].Value = Total;



            da.excutequery("Add_Arba7", param);
            da.close();

        }
        internal void Update_Arba7(int boking_id, DateTime BOKKING_date, string client_name, decimal commissinMoney, decimal priceForClient, decimal Total)
        {

            DataAcssesLayer da = new DataAcssesLayer();


            da.open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@Booking_ID", SqlDbType.Int);
            param[0].Value = boking_id;
            param[1] = new SqlParameter("@Booking_date", SqlDbType.DateTime);
            param[1].Value = BOKKING_date;
            param[2] = new SqlParameter("@Name", SqlDbType.NVarChar, 150);
            param[2].Value = client_name;

            param[3] = new SqlParameter("@commission_Money", SqlDbType.Decimal);
            param[3].Value = commissinMoney;

            param[4] = new SqlParameter("@price_for_client", SqlDbType.Decimal);
            param[4].Value = priceForClient;

            param[5] = new SqlParameter("@Total", SqlDbType.Decimal);
            param[5].Value = Total;



            da.excutequery("Update_Arba7", param);
            da.close();

        }

        internal DataTable Select_rba7()
        {
            DataAcssesLayer da = new DataAcssesLayer();
            da.open();
            DataTable dt = new DataTable();
            dt = da.selected("Select_rba7", null);
            return dt;
        }
        internal DataTable Search_arba7(DateTime DateFrom , DateTime DateTo)
        {
            DataAcssesLayer da = new DataAcssesLayer();
            da.open();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@date_From", SqlDbType.DateTime);
            param[0].Value = DateFrom;
            param[1] = new SqlParameter("@date_To", SqlDbType.DateTime);
            param[1].Value = DateTo;
            dt = da.selected("Search_arba7", param);
            return dt;
        }
      
        internal void DeleteInsertBnak(int id_bank, DateTime date, decimal amount)
        {

            DataAcssesLayer da = new DataAcssesLayer();


            da.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@id_bank", SqlDbType.Int);
            param[0].Value = id_bank;
            param[1] = new SqlParameter("@Date", SqlDbType.DateTime);
            param[1].Value = date;
            param[2] = new SqlParameter("@Money", SqlDbType.Real);
            param[2].Value = amount;

            da.excutequery("DeleteInsertBnak", param);
            da.close();

        }
        internal void Delete_Client_bookinng(int id_booking)
        {

            DataAcssesLayer da = new DataAcssesLayer();


            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Booking_ID", SqlDbType.Int);
            param[0].Value = id_booking;


            da.excutequery("Delete_Client_bookinng", param);
            da.close();

        }
        internal void Delete_company_Booking(int id_booking)
        {

            DataAcssesLayer da = new DataAcssesLayer();


            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id_booking", SqlDbType.Int);
            param[0].Value = id_booking;


            da.excutequery("Delete_company_Booking", param);
            da.close();

        }
        internal void Delete_Arba7(int id_booking, DateTime date)
        {

            DataAcssesLayer da = new DataAcssesLayer();


            da.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@Booking_ID", SqlDbType.Int);
            param[0].Value = id_booking;
            param[1] = new SqlParameter("@Booking_date", SqlDbType.DateTime);
            param[1].Value = date;
          

            da.excutequery("Delete_Arba7", param);
            da.close();

        }







    }


}