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
            decimal TotalAfterDiscount,decimal Patient_paymentAmount,string Activate)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[21];
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

            param[20] = new SqlParameter("@Activate", SqlDbType.NVarChar,50);
            param[20].Value = Activate;
            da.excutequery("AddTickets", param);
            da.close();
        }

        internal void Update_TeckietInformation(int Id_Teckiet, int Id_Technical, int Id_DoctorOfCenter, DateTime Date_Revelation, 
                                                DateTime Date_Recieve,int  palce_ToCheck, string User_Name , string Notes)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[8];
            param[0] = new SqlParameter("@Id_Teckiet", SqlDbType.Int);
            param[0].Value = Id_Teckiet;
            param[1] = new SqlParameter("@Id_Technical", SqlDbType.Int);
            param[1].Value = Id_Technical;
            param[2] = new SqlParameter("@Id_DoctortOfCenter", SqlDbType.Int);
            param[2].Value = Id_DoctorOfCenter;
            param[3] = new SqlParameter("@Date_Revelation", SqlDbType.DateTime);
            param[3].Value = Date_Revelation;
            param[4] = new SqlParameter("@Recieve_Date", SqlDbType.DateTime);
            param[4].Value = Date_Recieve;
            param[5] = new SqlParameter("@ID_Branches", SqlDbType.Int);
            param[5].Value = palce_ToCheck;
            param[6] = new SqlParameter("@User_Name", SqlDbType.NVarChar, 150);
            param[6].Value = User_Name;
            param[7] = new SqlParameter("@ReasonForAdding", SqlDbType.NVarChar, 150);
            param[7].Value = Notes;
            da.excutequery("Update_TeckietInformation", param);
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
        internal void AddTicketCompany(int ID_Tickets, int idcompany , decimal Total_Company)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@idticket", SqlDbType.Int);
            param[0].Value = ID_Tickets;
            param[1] = new SqlParameter("@idCompany", SqlDbType.Int);
            param[1].Value = idcompany;
            param[2] = new SqlParameter("@TOTal_Company", SqlDbType.Decimal);
            param[2].Value = Total_Company;
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
        internal DataTable SelectManagmentTicketsBranchMorning(int IDBranch, DateTime date_day)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@id_Branche", SqlDbType.Int);
            param[0].Value = IDBranch;
            param[1] = new SqlParameter("@date_day", SqlDbType.Date);
            param[1].Value = date_day;
            dt = da.selected("SelectManagmentTicketsBranchMorning", param);
            da.close();
            return dt;
        }
        internal DataTable Report_StockMoneyCategoryXray(int  Id_Branch , DateTime From_Date , DateTime To_Date   )
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@Id_Branch", SqlDbType.Int);
            param[0].Value = Id_Branch;
            param[1] = new SqlParameter("@Date_From", SqlDbType.Date);
            param[1].Value = From_Date;
            param[2] = new SqlParameter("@Date_to", SqlDbType.Date);
            param[2].Value = To_Date;
            dt = da.selected("Report_StockMoneyCategoryXray", param);
            da.close();
            return dt;
        }
        internal DataTable SelectManagmentTicketsBranchEvening(int IDBranch, DateTime date_day)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@id_Branche", SqlDbType.Int);
            param[0].Value = IDBranch;
            param[1] = new SqlParameter("@date_day", SqlDbType.Date);
            param[1].Value = date_day;
            dt = da.selected("SelectManagmentTicketsBranchEvening", param);
            da.close();
            return dt;
        }
        internal DataTable SelectManagmentTicketsBranchFullDay(int IDBranch,DateTime date_day)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@id_Branche", SqlDbType.Int);
            param[0].Value = IDBranch;
            param[1] = new SqlParameter("@date_day", SqlDbType.Date);
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
        internal DataTable SearchManagmentTicketsBranch(string ID)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.NVarChar,50);
            param[0].Value = ID;
      

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
        internal DataTable Select_IDBranch(string Branch_Name)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Branchname", SqlDbType.NVarChar,50);
            param[0].Value = Branch_Name;
            dt = da.selected("Select_IDBranch", param);
            da.close();
            return dt;
        }
        internal DataTable Select_IdCompanyAndRentFromTicket(int IDTickets)
        {
            DataTable dt = new DataTable();
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Id_Tiecket", SqlDbType.Int);
            param[0].Value = IDTickets;
            dt = da.selected("Select_IdCompanyAndRentFromTicket", param);
            da.close();
            return dt;
        }
        internal DataTable SelecthManagmentTicketsBranch()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
     
            dt = da.selected("SelecthManagmentTicketsBranch", null);
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
        internal DataTable selectSearchTicketsReturnDate(string Branch_Name,DateTime from, DateTime to)
        {
            DataTable dt = new DataTable();
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@Branch", SqlDbType.NVarChar,100);
            param[0].Value = Branch_Name;
            param[1] = new SqlParameter("@from", SqlDbType.DateTime);
            param[1].Value = from;
            param[2] = new SqlParameter("@to", SqlDbType.DateTime);
            param[2].Value = to;
            dt = da.selected("selectSearchTicketsReturnDate", param);
            da.close();
            return dt;
        }
        internal DataTable SelectSearchticketsDate( DateTime from, DateTime to)
        {
            DataTable dt = new DataTable();
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[2];        
            param[0] = new SqlParameter("@from", SqlDbType.DateTime);
            param[0].Value = from;
            param[1] = new SqlParameter("@to", SqlDbType.DateTime);
            param[1].Value = to;
            dt = da.selected("SelectSearchticketsDate", param);
            da.close();
            return dt;
        }
        internal DataTable SelectSearchticketsBranchDate(int branch,DateTime from, DateTime to)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@id_Branche", SqlDbType.Int);
            param[0].Value = branch;
            param[1] = new SqlParameter("@from", SqlDbType.DateTime);
            param[1].Value = from;
            param[2] = new SqlParameter("@to", SqlDbType.DateTime);
            param[2].Value = to;

            dt = da.selected("SelectSearchticketsBranchDate", param);
            da.close();
            return dt;
        }
        internal DataTable SelectSearchAllticketsBranchDate(int branch, DateTime from, DateTime to)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@id_Branche", SqlDbType.Int);
            param[0].Value = branch;
            param[1] = new SqlParameter("@from", SqlDbType.Date);
            param[1].Value = from;
            param[2] = new SqlParameter("@to", SqlDbType.Date);
            param[2].Value = to;

            dt = da.selected("SelectSearchAllticketsBranchDate", param);
            da.close();
            return dt;
        }
        internal DataTable SelectSearchticketsBranchDateandCategory(int branch,int Id_CategoryItem, DateTime from, DateTime to)
        {
            DataTable dt = new DataTable();
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@id_Branche", SqlDbType.Int);
            param[0].Value = branch;
            param[1] = new SqlParameter("@Id_CategoryItem", SqlDbType.Int);
            param[1].Value = Id_CategoryItem;
            param[2] = new SqlParameter("@from", SqlDbType.Date);
            param[2].Value = from;
            param[3] = new SqlParameter("@to", SqlDbType.Date);
            param[3].Value = to;
            dt = da.selected("SelectSearchticketsBranchDateandCategory", param);
            da.close();
            return dt;
        }

        internal DataTable VildateXrayCompany(int IDitem,int idcompany)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@iditem", SqlDbType.Int);
            param[0].Value = IDitem;
            param[1] = new SqlParameter("@idcompany", SqlDbType.Int);
            param[1].Value = idcompany;
            dt = da.selected("VildateXrayCompany", param);
            da.close();
            return dt;
        }

        internal void addticketsReturn(int id_tickets,int id_stock,string branch,string patient_name,
                                      string statues,string item_name,DateTime date_return,decimal moneyreturn, string note, 
                                      decimal prise_items,decimal Pay, string UserName, int Id_Item,int Id_UserBranch)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[14];
            param[0] = new SqlParameter("@id_tickets", SqlDbType.Int);
            param[0].Value = id_tickets;
            param[1] = new SqlParameter("@id_stock", SqlDbType.Int);
            param[1].Value = id_stock;
            param[2] = new SqlParameter("@branch", SqlDbType.NVarChar,50);
            param[2].Value = branch;
            param[3] = new SqlParameter("@patient_name", SqlDbType.NVarChar,150);
            param[3].Value = patient_name;
            param[4] = new SqlParameter("@statues", SqlDbType.NVarChar,50);
            param[4].Value = statues;
            param[5] = new SqlParameter("@item_name", SqlDbType.NVarChar,150);
            param[5].Value = item_name;
            param[6] = new SqlParameter("@date_return", SqlDbType.DateTime);
            param[6].Value = date_return;
            param[7] = new SqlParameter("@moneyreturn", SqlDbType.Decimal);
            param[7].Value = moneyreturn;
            param[8] = new SqlParameter("@note", SqlDbType.NVarChar,150);
            param[8].Value = note;
            param[9] = new SqlParameter("@prise_items", SqlDbType.Decimal);
            param[9].Value = prise_items;
            param[10] = new SqlParameter("@Pay", SqlDbType.Decimal);
            param[10].Value = Pay;
            param[11] = new SqlParameter("@UserName", SqlDbType.NVarChar,50);
            param[11].Value = UserName;
            param[12] = new SqlParameter("@Id_Item", SqlDbType.Int);
            param[12].Value = Id_Item;
            param[13] = new SqlParameter("@Id_Branch", SqlDbType.Int);
            param[13].Value = Id_UserBranch;
            da.excutequery("addticketsReturn", param);
            da.close();
        }

        internal void UpdateticketsReturn(int id_tickets, int id_stock, string branch, DateTime date_return, decimal moneyreturn,
                                      string UserName,  int Id_UserBranch,string Notes)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[8];
            param[0] = new SqlParameter("@id_tickets", SqlDbType.Int);
            param[0].Value = id_tickets;
            param[1] = new SqlParameter("@id_stock", SqlDbType.Int);
            param[1].Value = id_stock;
            param[2] = new SqlParameter("@branch", SqlDbType.NVarChar, 50);
            param[2].Value = branch;
            param[3] = new SqlParameter("@date_return", SqlDbType.DateTime);
            param[3].Value = date_return;
            param[4] = new SqlParameter("@moneyreturn", SqlDbType.Decimal);
            param[4].Value = moneyreturn;

            param[5] = new SqlParameter("@UserName", SqlDbType.NVarChar, 50);
            param[5].Value = UserName;
            param[6] = new SqlParameter("@Id_Branch", SqlDbType.Int);
            param[6].Value = Id_UserBranch;
            param[7] = new SqlParameter("@note", SqlDbType.NVarChar,150);
            param[7].Value = Notes;
            da.excutequery("UpdateticketsReturn", param);
            da.close();
        }
        internal DataTable vildateReturnTickets( int idtickets)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@idtickets", SqlDbType.Int);
            param[0].Value = idtickets;
         
            dt = da.selected("vildateReturnTickets", param);
            da.close();
            return dt;
        }

        internal DataTable vildateIDReturnTickets(int idtickets)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@idtickets", SqlDbType.Int);
            param[0].Value = idtickets;

            dt = da.selected("vildateIDReturnTickets", param);
            da.close();
            return dt;
        }
        internal DataTable searchdateTicketsReturn( DateTime from, DateTime to)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[2];

        
            param[1] = new SqlParameter("@FromDate", SqlDbType.DateTime);
            param[1].Value = from;
            param[2] = new SqlParameter("@ToDate", SqlDbType.DateTime);
            param[2].Value = to;


            dt = da.selected("searchdateTicketsReturn", param);
            da.close();
            return dt;
        }

        internal DataTable selectTicketsReturn(string Branch_Name )
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Branch", SqlDbType.NVarChar,100);
            param[0].Value = Branch_Name;
            dt = da.selected("selectTicketsReturn", param);
            da.close();
            return dt;
        }


        internal DataTable VildateselectItemXrayCompany( int idcompany,int ID_CATEGORY)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@idcompany", SqlDbType.Int);
            param[0].Value = idcompany;
            param[1] = new SqlParameter("@ID_CATEGORY", SqlDbType.Int);
            param[1].Value = ID_CATEGORY;
            dt = da.selected("VildateselectItemXrayCompany", param);
            da.close();
            return dt;
        }



        internal void AddTransferForCompany(int ID_Company, decimal Patient_Rate, decimal Patient_Amont, decimal Total, decimal Customer_Rent,
            decimal Rent_OfCompany, DateTime Date_Transfer, string Note, int ID_Item, int ID_Tickets, string name_Customer,
            int ID_Stock,string User_Name, string Branche_Name)

        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[14];
            param[0] = new SqlParameter("@ID_Company", SqlDbType.Int);
            param[0].Value = ID_Company;
            param[1] = new SqlParameter("@Patient_Rate", SqlDbType.Decimal);
            param[1].Value = Patient_Rate;
            param[2] = new SqlParameter("@Patient_Amont", SqlDbType.Decimal);
            param[2].Value = Patient_Amont;
            param[3] = new SqlParameter("@Total", SqlDbType.Decimal);
            param[3].Value = Total;
            param[4] = new SqlParameter("@Customer_Rent", SqlDbType.Decimal);
            param[4].Value = Customer_Rent;
            param[5] = new SqlParameter("@Rent_OfCompany", SqlDbType.Decimal);
            param[5].Value = Rent_OfCompany;
            param[6] = new SqlParameter("@Date_Transfer", SqlDbType.DateTime);
            param[6].Value = Date_Transfer;
            param[7] = new SqlParameter("@Note", SqlDbType.NVarChar, 150);
            param[7].Value = Note;
            param[8] = new SqlParameter("@ID_Item", SqlDbType.Int);
            param[8].Value = ID_Item;
            param[9] = new SqlParameter("@ID_Tickets", SqlDbType.Int);
            param[9].Value = ID_Tickets;
            param[10]= new SqlParameter("@name_Customer", SqlDbType.NVarChar,100);
            param[10].Value = name_Customer;
            param[11] = new SqlParameter("@ID_Stock", SqlDbType.Int);
            param[11].Value = ID_Stock;
            param[12] = new SqlParameter("@User_Name", SqlDbType.NVarChar,50);
            param[12].Value = User_Name;
            param[13] = new SqlParameter("@Branche_Name", SqlDbType.NVarChar, 50);
            param[13].Value = Branche_Name;
            da.excutequery("AddTransferForCompany", param);
            da.close();
        }


        internal DataTable vildateTransferForCompany(int idtickets)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@idtickets", SqlDbType.Int);
            param[0].Value = idtickets;

            dt = da.selected("vildateTransferForCompany", param);
            da.close();
            return dt;
        }

        internal DataTable ReportSelectTransferCompany(DateTime Date_From, DateTime Date_To)
        {
            DataAccessLayer da = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@Date_from", SqlDbType.Date);
            param[0].Value = Date_From;
            param[1] = new SqlParameter("@Date_to", SqlDbType.Date);
            param[1].Value = Date_To;
            da.open();
            DataTable dt = new DataTable();
            dt.Clear();
            dt = da.selected("ReportSelectTransferCompany", param);
            da.close();
            return dt;
        }


        internal DataTable ReportInvoiceTicketPay(int idtickets)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@idTicket", SqlDbType.Int);
            param[0].Value = idtickets;

            dt = da.selected("ReportInvoiceTicketPay", param);
            da.close();
            return dt;
        }

        internal DataTable ReportInvoiceTicketCompany(int idtickets)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@idTicket", SqlDbType.Int);
            param[0].Value = idtickets;

            dt = da.selected("ReportInvoiceTicketCompany", param);
            da.close();
            return dt;
        }

        internal DataTable selectDataRevlation(int idBranch, DateTime date)
        {
            DataAccessLayer da = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@idBranch", SqlDbType.Int);
            param[0].Value = idBranch;
            param[1] = new SqlParameter("@date", SqlDbType.Date);
            param[1].Value = date;
            da.open();
            DataTable dt = new DataTable();
            dt.Clear();
            dt = da.selected("selectDataRevlation", param);
            da.close();
            return dt;
        }
        internal DataTable PrintBarcode(int idtickets)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@idTickets", SqlDbType.Int);
            param[0].Value = idtickets;

            dt = da.selected("PrintBarcode", param);
            da.close();
            return dt;
        }
        internal void UpdateTicketsActive(int Id_Teckiet, string Activate)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@Id_Teckiet", SqlDbType.Int);
            param[0].Value = Id_Teckiet;
            param[1] = new SqlParameter("@Activate", SqlDbType.NVarChar,50);
            param[1].Value = Activate;
         
            da.excutequery("UpdateTicketsActive", param);
            da.close();
        }
        internal void Add_Revenue(int id_Branch , int Id_Teckiet, int Id_ItemXtay, decimal price_ItemXray,
                                                Decimal Discount, decimal Pay, decimal Rent, DateTime Date_Pay)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[8];
            param[0] = new SqlParameter("@ID_Branch", SqlDbType.Int);
            param[0].Value = id_Branch;
            param[1] = new SqlParameter("@Id_Teckiet", SqlDbType.Int);
            param[1].Value = Id_Teckiet;
            param[2] = new SqlParameter("@Id_ItemXray", SqlDbType.Int);
            param[2].Value = Id_ItemXtay;
            param[3] = new SqlParameter("@Price_ItemXray", SqlDbType.Decimal);
            param[3].Value = price_ItemXray;
            param[4] = new SqlParameter("@Discount", SqlDbType.Decimal);
            param[4].Value = Discount;
            param[5] = new SqlParameter("@Pay", SqlDbType.Decimal);
            param[5].Value = Pay;
            param[6] = new SqlParameter("@Rent", SqlDbType.Decimal);
            param[6].Value = Rent;
            param[7] = new SqlParameter("@date_Pay", SqlDbType.DateTime);
            param[7].Value = Date_Pay;
            da.excutequery("Add_Revenue", param);
            da.close();
        }
        internal void Update_Revenue(int id_Branch, int Id_Teckiet, int Id_ItemXtay, decimal price_ItemXray,
                                         Decimal Discount, decimal Pay, decimal Rent, DateTime Date_Pay)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[8];
            param[0] = new SqlParameter("@ID_Branch", SqlDbType.Int);
            param[0].Value = id_Branch;
            param[1] = new SqlParameter("@Id_Teckiet", SqlDbType.Int);
            param[1].Value = Id_Teckiet;
            param[2] = new SqlParameter("@Id_ItemXray", SqlDbType.Int);
            param[2].Value = Id_ItemXtay;
            param[3] = new SqlParameter("@Price_ItemXray", SqlDbType.Decimal);
            param[3].Value = price_ItemXray;
            param[4] = new SqlParameter("@Discount", SqlDbType.Decimal);
            param[4].Value = Discount;
            param[5] = new SqlParameter("@Pay", SqlDbType.Decimal);
            param[5].Value = Pay;
            param[6] = new SqlParameter("@Rent", SqlDbType.Decimal);
            param[6].Value = Rent;
            param[7] = new SqlParameter("@date_Pay", SqlDbType.DateTime);
            param[7].Value = Date_Pay;
            da.excutequery("Update_Revenue", param);
            da.close();
        }

    }
}
