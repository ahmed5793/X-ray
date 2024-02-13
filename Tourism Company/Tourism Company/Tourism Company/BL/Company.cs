using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Tourism_Company.DAL;

namespace Tourism_Company.BL
{
  public  class Company
    {
        
            internal void AddCompany(string name, string phone)
            {
                DataAcssesLayer da = new DataAcssesLayer();
                da.open();
                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 300);
                param[0].Value = name;

                param[1] = new SqlParameter("@phone", SqlDbType.VarChar, 100);
                param[1].Value = phone;


                da.excutequery("AddCompany", param);
                da.close();
            }
            internal DataTable SelectCompany ()
            {
                DataTable dt = new DataTable();

                DataAcssesLayer da = new DataAcssesLayer();
                da.open();
                dt = da.selected("SelectCompany", null);
                da.close();
                return dt;
            }
        internal DataTable CompoCompany()
        {
            DataTable dt = new DataTable();

            DataAcssesLayer da = new DataAcssesLayer();
            da.open();
            dt = da.selected("CompoCompany", null);
            da.close();
            return dt;
        }
        internal void DeleteComapny (int id)
            {
                DataAcssesLayer da = new DataAcssesLayer();
                da.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@id", SqlDbType.Int);
                param[0].Value = id;



                da.excutequery("DeleteComapny", param);
                da.close();
            }
            internal DataTable SearchCompany (string name)
            {
                DataTable dt = new DataTable();

                DataAcssesLayer da = new DataAcssesLayer();
                da.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 300);
                param[0].Value = name;

                dt = da.selected("SearchCompany", param);
                da.close();
                return dt;
            }
            internal void UpdateCompany (string name, string phone, int id)
            {
                DataAcssesLayer da = new DataAcssesLayer();
                da.open();
                SqlParameter[] param = new SqlParameter[3];
                param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 300);
                param[0].Value = name;

                param[1] = new SqlParameter("@phone", SqlDbType.VarChar, 100);
                param[1].Value = phone;
                param[2] = new SqlParameter("@id", SqlDbType.Int);
                param[2].Value = id;
                da.excutequery("UpdateCompany", param);
                da.close();


            }

        }

    }

