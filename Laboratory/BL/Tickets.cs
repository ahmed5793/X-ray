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
    class Tickets
    {
        internal void AddTickets(DateTime Visite_Date, DateTime Receive_Date, decimal Total, decimal Pay, decimal Rent, 
            int Cust_ID, string Statues, int Doctor_ID, int ID_Branches,int ID_Stock,DateTime Date_revelation,string Complain,
            int ID_Doctorofcenter,int ID_Techincal, string userName,String PlaceToCheck,decimal Additions, string ReasonForAdding,
            decimal TotalAfterDiscount,decimal Patient_paymentAmount)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[20];
            param[0] = new SqlParameter("@Visite_Date", SqlDbType.DateTime);
            param[0].Value = Visite_Date;
            param[1] = new SqlParameter("@Receive_Date", SqlDbType.DateTime);
            param[1].Value = Receive_Date;
            param[2] = new SqlParameter("@Total", SqlDbType.Decimal);
            param[2].Value = Total;
            param[3] = new SqlParameter("@Pay", SqlDbType.Decimal);
            param[3].Value = Pay;
            param[4] = new SqlParameter("@Rent", SqlDbType.Decimal);
            param[4].Value = Rent;
            param[5] = new SqlParameter("@Cust_ID", SqlDbType.Int);
            param[5].Value = Cust_ID;
            param[6] = new SqlParameter("@Statues", SqlDbType.NVarChar,50);
            param[6].Value = Statues;
            param[7] = new SqlParameter("@Doctor_ID", SqlDbType.Int);
            param[7].Value = Doctor_ID;
            param[8] = new SqlParameter("@ID_Branches", SqlDbType.Int);
            param[8].Value = ID_Branches;
            param[9] = new SqlParameter("@ID_Stock", SqlDbType.Int);
            param[9].Value = ID_Stock;
            param[10] = new SqlParameter("@Date_revelation", SqlDbType.DateTime);
            param[10].Value = Date_revelation;
            param[11] = new SqlParameter("@Complain", SqlDbType.NVarChar, 150);
            param[11].Value = Complain;
            param[12] = new SqlParameter("@ID_Doctorofcenter", SqlDbType.Int);
            param[12].Value = ID_Doctorofcenter;
            param[13] = new SqlParameter("@ID_Techincal", SqlDbType.Int);
            param[13].Value = ID_Techincal;
            param[14] = new SqlParameter("@userName", SqlDbType.NVarChar,150);
            param[14].Value = userName;

            param[15] = new SqlParameter("@PlaceToCheck", SqlDbType.NVarChar, 50);
            param[15].Value = PlaceToCheck;
            param[16] = new SqlParameter("@Additions", SqlDbType.Decimal);
            param[16].Value = Additions;
            param[17] = new SqlParameter("@ReasonForAdding", SqlDbType.NVarChar, 150);
            param[17].Value = ReasonForAdding;
            param[18] = new SqlParameter("@TotalAfterDiscount", SqlDbType.Decimal);
            param[18].Value = TotalAfterDiscount;
            param[19] = new SqlParameter("@Patient_paymentAmount", SqlDbType.Decimal);
            param[19].Value = Patient_paymentAmount;


            da.excutequery("AddTickets", param);
            da.close();
        }
        internal void AddTicketDetails(int ID_Tickets, int ID_ItemsXrays, decimal prise)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@ID_Tickets", SqlDbType.Int);
            param[0].Value = ID_Tickets;
            param[1] = new SqlParameter("@ID_ItemsXrays", SqlDbType.Int);
            param[1].Value = ID_ItemsXrays;
            param[2] = new SqlParameter("@Prise", SqlDbType.Decimal);
            param[2].Value = prise;
            
      


            da.excutequery("AddTicketDetails", param);
            da.close();
        }
        internal void AddTickestDiscount(int ID_Tickets, decimal Value)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@ID_Tickets", SqlDbType.Int);
            param[0].Value = ID_Tickets;
      
            param[1] = new SqlParameter("@Value", SqlDbType.Decimal);
            param[1].Value = Value;




            da.excutequery("AddTickestDiscount", param);
            da.close();
        }
        internal DataTable LastIdTicket()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            dt = da.selected("LastIdTicket", null);
            da.close();
            return dt;
        }
        internal void AddTicketCompany(int ID_Tickets, int idcompany)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@idticket", SqlDbType.Int);
            param[0].Value = ID_Tickets;
            param[1] = new SqlParameter("@idCompany", SqlDbType.Int);
            param[1].Value = idcompany;
           




            da.excutequery("AddTicketCompany", param);
            da.close();
        }
        internal DataTable SelectTicketEmployee(int IDCustomer)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@IDCustomer", SqlDbType.Int);
            param[0].Value = IDCustomer;
            dt = da.selected("SelectTicketEmployee", param);
            da.close();
            return dt;
        }
        internal DataTable SelectManagmentTicketsBranchMorning(int IDBranch, string date_day)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@id_Branche", SqlDbType.Int);
            param[0].Value = IDBranch;
            param[1] = new SqlParameter("@date_day", SqlDbType.NVarChar,50);
            param[1].Value = date_day;
            dt = da.selected("SelectManagmentTicketsBranchMorning", param);
            da.close();
            return dt;
        }
        internal DataTable SelectManagmentTicketsBranchEvening(int IDBranch, string date_day)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@id_Branche", SqlDbType.Int);
            param[0].Value = IDBranch;
            param[1] = new SqlParameter("@date_day", SqlDbType.NVarChar);
            param[1].Value = date_day;
            dt = da.selected("SelectManagmentTicketsBranchEvening", param);
            da.close();
            return dt;
        }
        internal DataTable SelectManagmentTicketsBranchFullDay(int IDBranch,string date_day)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@id_Branche", SqlDbType.Int);
            param[0].Value = IDBranch;
            param[1] = new SqlParameter("@date_day", SqlDbType.NVarChar,50);
            param[1].Value = date_day;
            dt = da.selected("SelectManagmentTicketsBranchFullDay", param);
            da.close();
            return dt;
        }
        internal DataTable SelectManagmentTicketsBranchDate(int IDBranch,DateTime from ,DateTime to)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@id_Branche", SqlDbType.Int);
            param[0].Value = IDBranch;
            param[1] = new SqlParameter("@from", SqlDbType.DateTime);
            param[1].Value = from;
            param[2] = new SqlParameter("@to", SqlDbType.DateTime);
            param[2].Value = to;


            dt = da.selected("SelectManagmentTicketsBranchDate", param);
            da.close();
            return dt;
        }
        internal DataTable SearchManagmentTicketsBranch(string ID,int IDBranch)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@id", SqlDbType.NVarChar,50);
            param[0].Value = ID;
            param[1] = new SqlParameter("@id_Branche", SqlDbType.Int);
            param[1].Value = IDBranch;

            dt = da.selected("SearchManagmentTicketsBranch", param);
            da.close();
            return dt;
        }
        internal DataTable TicketDetailsSelectTickets(int IDTickets)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@idTicket", SqlDbType.Int);
            param[0].Value = IDTickets;
            dt = da.selected("TicketDetailsSelectTickets", param);
            da.close();
            return dt;
        }
        internal DataTable SelecthManagmentTicketsBranch(int IDTickets)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id_Branch", SqlDbType.Int);
            param[0].Value = IDTickets;
            dt = da.selected("SelecthManagmentTicketsBranch", param);
            da.close();
            return dt;
        }
        internal DataTable TicketDetailsSelectTicketsDetAILS(int IDTickets)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@idTicket", SqlDbType.Int);
            param[0].Value = IDTickets;
            dt = da.selected("TicketDetailsSelectTicketsDetAILS", param);
            da.close();
            return dt;
        }
        internal DataTable vildateTicketCompany(int IDTickets)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id_ticket", SqlDbType.Int);
            param[0].Value = IDTickets;
            dt = da.selected("vildateTicketCompany", param);
            da.close();
            return dt;
        }
        internal DataTable TicketDetailsSelectTicketsCompany(int IDTickets)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@idTicket", SqlDbType.Int);
            param[0].Value = IDTickets;
            dt = da.selected("TicketDetailsSelectTicketsCompany", param);
            da.close();
            return dt;
        }
    }
}
