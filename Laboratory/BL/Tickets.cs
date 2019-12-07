﻿using System;
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
            int ID_Doctorofcenter,int ID_Techincal, string userName)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[15];
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
    }
}
