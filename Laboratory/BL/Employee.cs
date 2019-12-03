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

        internal void AddEmployee(string Emp_name, decimal Salary, DateTime salary_date, string National_ID, string phone, string Address, DateTime date, int idEmprole, int IDbeanches)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[9];
            param[0] = new SqlParameter("@Emp_Name", SqlDbType.NVarChar, 150);
            param[0].Value = Emp_name;
            param[1] = new SqlParameter("@salary", SqlDbType.Decimal);
            param[1].Value = Salary;
            param[2] = new SqlParameter("@salary_Date", SqlDbType.DateTime);
            param[2].Value = salary_date;
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
            param[8] = new SqlParameter("@idBranches", SqlDbType.Int);
            param[8].Value = IDbeanches;


            da.excutequery("AddEmployee", param);
            da.close();
        }
        internal void UpdateEmployee(string Emp_name, decimal Salary, DateTime salary_date, string National_ID, string phone, string Address, DateTime date, int id_EmpRole, int idemployee, int IDbeanches)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[10];
            param[0] = new SqlParameter("@Emp_Name", SqlDbType.NVarChar, 150);
            param[0].Value = Emp_name;
            param[1] = new SqlParameter("@salary", SqlDbType.Decimal);
            param[1].Value = Salary;
            param[2] = new SqlParameter("@salary_Date", SqlDbType.DateTime);
            param[2].Value = salary_date;
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
            param[9] = new SqlParameter("@idBranches", SqlDbType.Int);
            param[9].Value = IDbeanches;


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

        internal void AddEmployee_Salf(string Name_Daen, DateTime date_Salf, DateTime date, string @note, decimal money, int id_Empl)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[6];
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



            da.excutequery("AddEmployee_Salf", param);
            da.close();
        }
        internal void UpdateEmployee_Salf(string Name_Daen, DateTime date_Salf, DateTime date, string @note, decimal money, int id_Empl, int id_salf)
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
            param[6] = new SqlParameter("@id_salf", SqlDbType.Int);
            param[6].Value = id_salf;



            da.excutequery("UpdateEmployee_Salf", param);
            da.close();
        }
        internal DataTable SelectEmployeeSalf()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            dt = da.selected("SelectEmployeeSalf", null);
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
        internal void AddEmp_Salary(int id_Emp, decimal TotalSalary, decimal TotalSalf, decimal total, DateTime date, string @note, int idstock)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[7];
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

            param[6] = new SqlParameter("@idStock", SqlDbType.Int);
            param[6].Value = idstock;

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
    }
}
