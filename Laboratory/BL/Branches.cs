using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laboratory.DAL;
using System.Data.SqlClient;
using System.Data;

namespace Laboratory.BL
{
    class Branches
    {
        internal DataTable SelectBranches()
        {
            DataTable dt = new DataTable();
            try
            {
               

                DataAccessLayer da = new DataAccessLayer();
                da.open();
                dt = da.selected("SelectBranches", null);
                da.close();

                return dt;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                dt.Dispose();
               
               
            }
          
         
        }
    }
}
