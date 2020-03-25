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
    class Employee
    {

        internal void AddEmployee(string Emp_name, decimal Salary, string Gender_Salary, string National_ID, string phone, string Address, DateTime date, int idEmprole)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[8];
            param[0] = new SqlParameter("@Emp_Name", SqlDbType.NVarChar, 150);
            param[0].Value = Emp_name;
            param[1] = new SqlParameter("@salary", SqlDbType.Decimal);
            param[1].Value = Salary;
            param[2] = new SqlParameter("@Gender_Salary", SqlDbType.NVarChar,50);
            param[2].Value = Gender_Salary;
            param[3] = new SqlParameter("@National_ID", SqlDbType.VarChar, 50);
            param[3].Value = National_ID;
            param[4] = new SqlParameter("@Emp_Phone", SqlDbType.VarChar, 100);
            param[4].Value = phone;
            param[5] = new SqlParameter("@Emp_Address", SqlDbType.NVarChar, 250);
            param[5].Value = Address;
            param[6] = new SqlParameter("@Date", SqlDbType.DateTime);
            param[6].Value = date;
            param[7] = new SqlParameter("@id_EmpRole", SqlDbType.Int);
            param[7].Value = idEmprole;
        


            da.excutequery("AddEmployee", param);
            da.close();
        }
        internal void UpdateEmployee(string Emp_name, decimal Salary, string Gender_Salary, string National_ID,
                                     string phone, string Address, DateTime date, int id_EmpRole, int idemployee)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[9];
            param[0] = new SqlParameter("@Emp_Name", SqlDbType.NVarChar, 150);
            param[0].Value = Emp_name;
            param[1] = new SqlParameter("@salary", SqlDbType.Decimal);
            param[1].Value = Salary;
            param[2] = new SqlParameter("@Gender_Salary", SqlDbType.NVarChar, 50);
            param[2].Value = Gender_Salary;
            param[3] = new SqlParameter("@National_ID", SqlDbType.VarChar, 50);
            param[3].Value = National_ID;
            param[4] = new SqlParameter("@Emp_Phone", SqlDbType.VarChar, 100);
            param[4].Value = phone;
            param[5] = new SqlParameter("@Emp_Address", SqlDbType.NVarChar, 250);
            param[5].Value = Address;
            param[6] = new SqlParameter("@Date", SqlDbType.DateTime);
            param[6].Value = date;
            param[7] = new SqlParameter("@id_EmpRole", SqlDbType.Int);
            param[7].Value = id_EmpRole;
            param[8] = new SqlParameter("@idemployee", SqlDbType.Int);
            param[8].Value = idemployee;
          


            da.excutequery("UpdateEmployee", param);
            da.close();
        }

        internal void AddEmployeeRole(string role)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@role", SqlDbType.NVarChar, 250);
            param[0].Value = role;

            da.excutequery("AddEmployeeRole", param);
            da.close();
        }
        internal DataTable SelectEmployee()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            dt = da.selected("SelectEmployee", null);
            da.close();
            return dt;
        }
        internal DataTable SelectEmpRole()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            dt = da.selected("SelectEmpRole", null);
            da.close();
            return dt;
        }
        internal DataTable Select_LastId_Employee()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            dt = da.selected("Select_LastId_Employee", null);
            da.close();
            return dt;
        }
        internal DataTable SearchEmployes(string id)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.NVarChar, 50);
            param[0].Value = id;
            dt = da.selected("SearchEmployes", param);
            da.close();
            return dt;
        }

        internal void AddEmployee_Salf(string Name_Daen, DateTime date_Salf, DateTime date, string @note, decimal money, int id_Empl,int ID_Branch)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@Name_Daen", SqlDbType.NVarChar, 100);
            param[0].Value = Name_Daen;
            param[1] = new SqlParameter("@date_Salf", SqlDbType.DateTime);
            param[1].Value = date_Salf;
            param[2] = new SqlParameter("@date", SqlDbType.DateTime);
            param[2].Value = date;
            param[3] = new SqlParameter("@note", SqlDbType.NVarChar, 150);
            param[3].Value = note;
            param[4] = new SqlParameter("@money", SqlDbType.Decimal);
            param[4].Value = money;
            param[5] = new SqlParameter("@id_Empl", SqlDbType.Int);
            param[5].Value = id_Empl;
            param[6] = new SqlParameter("@ID_Branch", SqlDbType.Int);
            param[6].Value = ID_Branch;



            da.excutequery("AddEmployee_Salf", param);
            da.close();
        }
        internal void UpdateEmployee_Salf(  decimal money, int id_salf)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[2];
   
            param[0] = new SqlParameter("@money", SqlDbType.Decimal);
            param[0].Value = money;
        
            param[1] = new SqlParameter("@id_salf", SqlDbType.Int);
            param[1].Value = id_salf;



            da.excutequery("UpdateEmployee_Salf", param);
            da.close();
        }
        internal DataTable SelectEmployeeSalf(int IDbranch)
        {
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            param[0] = new SqlParameter("@IDBranch", SqlDbType.Int);
            param[0].Value = IDbranch;
            dt = da.selected("SelectEmployeeSalf", param);
            da.close();
            return dt;
        }
        internal DataTable SearchEmployeeSalf(string id)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.NVarChar, 100);
            param[0].Value = id;
            dt = da.selected("SearchEmployeeSalf", param);
            da.close();
            return dt;
        }
        internal void AddEMPSalaryMins(int emp_id, DateTime date, decimal money, string pay)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@emp_id", SqlDbType.Int);
            param[0].Value = emp_id;
            param[1] = new SqlParameter("@date", SqlDbType.DateTime);
            param[1].Value = date;
            param[2] = new SqlParameter("@money", SqlDbType.Decimal);
            param[2].Value = money;
            param[3] = new SqlParameter("@Pay", SqlDbType.NVarChar, 50);
            param[3].Value = pay;






            da.excutequery("AddEMPSalaryMins", param);
            da.close();
        }

        internal DataTable SelectCompoEmployee()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            dt = da.selected("SelectCompoEmployee", null);
            da.close();
            return dt;
        }
        internal DataTable Select_EmployeeFromBranchToAddShift(int Id_branch)
        {
            DataTable dt = new DataTable();
            DataAccessLayer da = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Id_Baranch", SqlDbType.Int);
            param[0].Value = Id_branch;
            da.open();
            dt = da.selected("Select_EmployeeFromBranchToAddShift", param);
            da.close();
            return dt;
        }
        internal DataTable Select_EmployeFromBranch(int Id_branch  )
        {
            DataTable dt = new DataTable();
            DataAccessLayer da = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Id_Branch", SqlDbType.Int);
            param[0].Value = Id_branch;
            da.open();
            dt = da.selected("Select_EmployeFromBranch", param);
            da.close();
            return dt;
        }
        internal DataTable SelectCHECKSalaryEmployee(int id)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            dt = da.selected("SelectCHECKSalaryEmployee", param);
            da.close();
            return dt;
        }
        internal void AddEmp_Salary(int id_Emp, decimal TotalSalary, decimal TotalSalf, decimal total, DateTime date,
            string @note,string User_Name,string MonthSalary,decimal Total_DiscountEmployee)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[9];
            param[0] = new SqlParameter("@ID_Emp", SqlDbType.Int);
            param[0].Value = id_Emp;
            param[1] = new SqlParameter("@TotalSalary", SqlDbType.Decimal);
            param[1].Value = TotalSalary;
            param[2] = new SqlParameter("@TotalSalf", SqlDbType.Decimal);
            param[2].Value = TotalSalf;
            param[3] = new SqlParameter("@Total", SqlDbType.Decimal);
            param[3].Value = total;
            param[4] = new SqlParameter("@Date", SqlDbType.DateTime);
            param[4].Value = date;
            param[5] = new SqlParameter("@Note", SqlDbType.NVarChar, 150);
            param[5].Value = note;
            param[6] = new SqlParameter("@User_Name", SqlDbType.NVarChar, 50);
            param[6].Value = User_Name;
            param[7] = new SqlParameter("@MonthSalary", SqlDbType.NVarChar, 50);
            param[7].Value = MonthSalary;
            param[8] = new SqlParameter("@Total_DiscountEmployee", SqlDbType.Decimal);
            param[8].Value = Total_DiscountEmployee;

            da.excutequery("AddEmp_Salary", param);
            da.close();
        }

        internal void UpdateEMPSalaryMins(int id_Emp, string pay)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@emp_id", SqlDbType.Int);
            param[0].Value = id_Emp;
            param[1] = new SqlParameter("@Pay", SqlDbType.NVarChar, 50);
            param[1].Value = pay;


            da.excutequery("UpdateEMPSalaryMins", param);
            da.close();
        }
        internal DataTable SelectSalary(int id, decimal salary)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@salary", SqlDbType.Decimal);
            param[1].Value = salary;
            dt = da.selected("SelectSalary", param);
            da.close();
            return dt;
        }
        internal DataTable SelectSalaryMins(int id)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            dt = da.selected("SelectSalaryMins", param);
            da.close();
            return dt;
        }
        internal DataTable UpdateSSalaryMins(int id, decimal money)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@money", SqlDbType.Decimal);
            param[1].Value = money;
            dt = da.selected("UpdateSSalaryMins", param);
            da.close();
            return dt;
        }

        internal DataTable SelectCompoRoleEmployee(int id)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@idRole", SqlDbType.Int);
            param[0].Value = id;
            dt = da.selected("SelectCompoRoleEmployee", param);
            da.close();
            return dt;
        }

        internal DataTable VildateEmployee(int id)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            dt = da.selected("VildateEmployee", param);
            da.close();
            return dt;
        }
        internal DataTable SelectSalaryEmployee(int id)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            dt = da.selected("SelectSalaryEmployee", param);
            da.close();
            return dt;
        }
        internal void AddEmployeeBranch( int id_branch,int idemployee)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@id_branch", SqlDbType.Int);
            param[0].Value = id_branch;

            param[1] = new SqlParameter("@id_employee", SqlDbType.Int);
            param[1].Value = idemployee;



            da.excutequery("AddEmployeeBranch", param);
            da.close();
        }
        internal void Delete_EmployeeBranch( int idemployee)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
           
            param[0] = new SqlParameter("@Id_Employee", SqlDbType.Int);
            param[0].Value = idemployee;
            da.excutequery("Delete_EmployeeBranch", param);
            da.close();
        }
        internal void UpdateEmployeeBranch(int id_branch, int idemployee)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@id_branch", SqlDbType.Int);
            param[0].Value = id_branch;

            param[1] = new SqlParameter("@id_employee", SqlDbType.Int);
            param[1].Value = idemployee;



            da.excutequery("UpdateEmployeeBranch", param);
            da.close();
        }
        internal DataTable SelectEmployeeBranch()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            dt = da.selected("SelectEmployeeBranch", null);
            da.close();
            return dt;
        }
        internal DataTable SelectEmpRoleCompo()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            dt = da.selected("SelectEmpRoleCompo", null);
            da.close();
            return dt;
        }
        internal DataTable VildateEmployeeBranch( int idemployee)
        {
            DataAccessLayer da = new DataAccessLayer();
            DataTable dt = new DataTable();
            da.open();
     
            SqlParameter[] param = new SqlParameter[1];
     

            param[0] = new SqlParameter("@id_employee", SqlDbType.Int);
            param[0].Value = idemployee;


            dt = da.selected("VildateEmployeeBranch", param);
            da.close();
            return dt;
        }
        internal DataTable SearchEmployeeBranch(string id)
        {
            DataAccessLayer da = new DataAccessLayer();
            DataTable dt = new DataTable();
            da.open();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.NVarChar,50);
            param[0].Value = id;



            dt = da.selected("SearchEmployeeBranch", param);
            da.close();
            return dt;
        }

        internal DataTable selectEmployeeGenderSalary()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            dt = da.selected("selectEmployeeGenderSalary", null);
            da.close();
            return dt;
        }

        internal void Add_EmployeeShift(int Employee_ID,  string Date_shift, string StartTime_Shift, string EndTime_Shift,
                                        decimal Amount,int Id_Branch , string User_Name  )
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@Employee_ID", SqlDbType.Int);
            param[0].Value = Employee_ID;
            param[1] = new SqlParameter("@Date_Shift", SqlDbType.NVarChar, 100);
            param[1].Value = Date_shift;
            param[2] = new SqlParameter("@Start_Time_Shift", SqlDbType.NVarChar, 100);
            param[2].Value = StartTime_Shift;
            param[3] = new SqlParameter("@End_Time_Shift", SqlDbType.NVarChar, 100);
            param[3].Value = EndTime_Shift;
            param[4] = new SqlParameter("@Amount", SqlDbType.Decimal);
            param[4].Value = Amount;
            param[5] = new SqlParameter("@Id_Branch", SqlDbType.Int);
            param[5].Value = Id_Branch;
            param[6] = new SqlParameter("@Id_Users", SqlDbType.NVarChar,100);
            param[6].Value = User_Name;
            da.excutequery("Add_EmployeeShift", param);
            da.close();
        }

        internal void Update_EmployeeShift(int ID_Shift, int Employee_ID, string Date_shift, string StartTime_Shift, 
                             string EndTime_Shift, decimal Amount,int Id_Branch,string User_Name)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[8];
            param[0] = new SqlParameter("@ID_Shift", SqlDbType.Int);
            param[0].Value = ID_Shift;
            param[1] = new SqlParameter("@Employee_ID", SqlDbType.Int);
            param[1].Value = Employee_ID;
            param[2] = new SqlParameter("@Date_Shift", SqlDbType.NVarChar, 100);
            param[2].Value = Date_shift;
            param[3] = new SqlParameter("@Start_Time_Shift", SqlDbType.NVarChar, 100);
            param[3].Value = StartTime_Shift;
            param[4] = new SqlParameter("@End_Time_Shift", SqlDbType.NVarChar, 100);
            param[4].Value = EndTime_Shift;
            param[5] = new SqlParameter("@Amount", SqlDbType.Decimal);
            param[5].Value = Amount;
            param[6] = new SqlParameter("@Id_Branch", SqlDbType.Int);
            param[6].Value = Id_Branch;
            param[7] = new SqlParameter("@Id_Users", SqlDbType.NVarChar, 100);
            param[7].Value = User_Name;
            da.excutequery("Update_EmployeeShift", param);
            da.close();
        }
        internal void Delete_TechnicalShift(int Id_Shift)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID_Shift", SqlDbType.Int);
            param[0].Value = Id_Shift;
            da.excutequery("Delete_TechnicalShift", param);
            da.close();
        }
        internal void Delete_EmployeeShift(int Id_Shift)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID_Shift", SqlDbType.Int);
            param[0].Value = Id_Shift;
            da.excutequery("Delete_EmployeeShift", param);
            da.close();
        }
        internal DataTable Search_EmployeeShift(string id)
        {
            DataAccessLayer da = new DataAccessLayer();
            DataTable dt = new DataTable();
            da.open();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.NVarChar, 50);
            param[0].Value = id;



            dt = da.selected("Search_EmployeeShift", param);
            da.close();
            return dt;
        }

        internal DataTable Select_EmployeeShift(int Id_Branch )
        {
            DataTable dt = new DataTable();
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Id_Branch", SqlDbType.Int);
            param[0].Value = Id_Branch;
            dt = da.selected("Select_EmployeeShift", param);
            da.close();
            return dt;
        }

        internal DataTable selectEmployeeRoleshift(int id)
        {
            DataAccessLayer da = new DataAccessLayer();
            DataTable dt = new DataTable();
            da.open();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@idemployee", SqlDbType.Int);
            param[0].Value = id;



            dt = da.selected("selectEmployeeRoleshift", param);
            da.close();
            return dt;
        }


        internal DataTable VildateEmployeeShift(int id)
        {
            DataAccessLayer da = new DataAccessLayer();
            DataTable dt = new DataTable();
            da.open();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;



            dt = da.selected("VildateEmployeeShift", param);
            da.close();
            return dt;
        }

        internal DataTable Report_EmployeeShift(int Id_Technical, DateTime Date_From, DateTime Date_To)
        {
            DataAccessLayer da = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@id_Employee", SqlDbType.Int);
            param[0].Value = Id_Technical;
            param[1] = new SqlParameter("@Date_from", SqlDbType.Date);
            param[1].Value = Date_From;
            param[2] = new SqlParameter("@Date_to", SqlDbType.Date);
            param[2].Value = Date_To;
            da.open();
            DataTable dt = new DataTable();
            dt.Clear();
            dt = da.selected("Report_EmployeeShift", param);
            da.close();
            return dt;
        }

        internal DataTable selectEmployeeGenderSalaryMonthe()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            dt = da.selected("selectEmployeeGenderSalaryMonthe", null);
            da.close();
            return dt;
        }
        internal DataTable selectEmployeeGenderSalaryShift()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            dt = da.selected("selectEmployeeGenderSalaryShift", null);
            da.close();
            return dt;
        }

        internal DataTable vildateEmployeeSalary(int Id_employee ,string date)
        {
            DataAccessLayer da = new DataAccessLayer();
            DataTable dt = new DataTable();
            da.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@idemployee", SqlDbType.Int);
            param[0].Value = Id_employee;
            param[1] = new SqlParameter("@date", SqlDbType.NVarChar,50);
            param[1].Value = date;
            dt = da.selected("vildateEmployeeSalary", param);
            da.close();
            return dt;
        }

        internal DataTable RrportEmployeeSalary(int Id_employee,string fromdate,string todate)
        {
            DataAccessLayer da = new DataAccessLayer();
            DataTable dt = new DataTable();
            da.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@idemployee", SqlDbType.Int);
            param[0].Value = Id_employee;
            param[1] = new SqlParameter("@fromdate", SqlDbType.NVarChar,50);
            param[1].Value = fromdate;
            param[2] = new SqlParameter("@todate", SqlDbType.NVarChar,50);
            param[2].Value = todate;
            dt = da.selected("RrportEmployeeSalary", param);
            da.close();
            return dt;
        }
        internal DataTable RrportEmployeeSalaryDate( string fromdate, string todate)
        {
            DataAccessLayer da = new DataAccessLayer();
            DataTable dt = new DataTable();
            da.open();
            SqlParameter[] param = new SqlParameter[2];
          
            param[0] = new SqlParameter("@fromdate", SqlDbType.NVarChar,50);
            param[0].Value = fromdate;
            param[1] = new SqlParameter("@todate", SqlDbType.NVarChar,50);
            param[1].Value = todate;
            dt = da.selected("RrportEmployeeSalaryDate", param);
            da.close();
            return dt;
        }
        internal DataTable ReportEmployeeSalf()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            dt = da.selected("ReportEmployeeSalf", null);
            da.close();
            return dt;
        }
    

        internal void AddEmployeeDiscount(int Employee_ID, decimal money, string Reasson, DateTime Date_Discount, string User_Name)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@id_employee", SqlDbType.Int);
            param[0].Value = Employee_ID;
            param[1] = new SqlParameter("@money", SqlDbType.Decimal);
            param[1].Value = money;
            param[2] = new SqlParameter("@Reasson", SqlDbType.NVarChar, 100);
            param[2].Value = Reasson;
            param[3] = new SqlParameter("@Date_Discount", SqlDbType.DateTime);
            param[3].Value = Date_Discount;
          
            param[4] = new SqlParameter("@User_Name", SqlDbType.NVarChar, 50);
            param[4].Value = User_Name;
          
            da.excutequery("AddEmployeeDiscount", param);
            da.close();
        }


     


        internal DataTable ReportSearchEmployeeSalf(int Id_Employee, DateTime Date_From, DateTime Date_To)
        {
            DataAccessLayer da = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@id_Employee", SqlDbType.Int);
            param[0].Value = Id_Employee;
            param[1] = new SqlParameter("@Date_from", SqlDbType.Date);
            param[1].Value = Date_From;
            param[2] = new SqlParameter("@Date_to", SqlDbType.Date);
            param[2].Value = Date_To;
            da.open();
            DataTable dt = new DataTable();
            dt.Clear();
            dt = da.selected("ReportSearchEmployeeSalf", param);
            da.close();
            return dt;
        }

        internal DataTable ReportSearchDateEmployeeSalf( DateTime Date_From, DateTime Date_To)
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
            dt = da.selected("ReportSearchDateEmployeeSalf", param);
            da.close();
            return dt;
        }

        internal DataTable ReportselecEmployeetDiscount(int Id_Employee, DateTime Date_From, DateTime Date_To)
        {
            DataAccessLayer da = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@idEmployee", SqlDbType.Int);
            param[0].Value = Id_Employee;
            param[1] = new SqlParameter("@fromdate", SqlDbType.Date);
            param[1].Value = Date_From;
            param[2] = new SqlParameter("@todate", SqlDbType.Date);
            param[2].Value = Date_To;
            da.open();
            DataTable dt = new DataTable();
            dt.Clear();
            dt = da.selected("ReportselecEmployeetDiscount", param);
            da.close();
            return dt;
        }

        internal DataTable ReportselecDateEmployeetDiscount(DateTime Date_From, DateTime Date_To)
        {
            DataAccessLayer da = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@fromdate", SqlDbType.Date);
            param[0].Value = Date_From;
            param[1] = new SqlParameter("@todate", SqlDbType.Date);
            param[1].Value = Date_To;
            da.open();
            DataTable dt = new DataTable();
            dt.Clear();
            dt = da.selected("ReportselecDateEmployeetDiscount", param);
            da.close();
            return dt;
        }
    }
}
