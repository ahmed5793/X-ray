using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tourism_Company.DAL;
using System.Data.SqlClient;
using System.Data;

namespace Tourism_Company.BL
{
    class Plane
    {
        DataAcssesLayer da = new DataAcssesLayer();

        internal void addPlane(string gender)
        {
            DataAcssesLayer da = new DataAcssesLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@planGender", SqlDbType.NVarChar, 300);
            param[0].Value = gender;

    


            da.excutequery("add_plan", param);
            da.close();
        }
        internal DataTable SelectPlaneGender()
            {
            DataTable dt = new DataTable();
            DataAcssesLayer da = new DataAcssesLayer();
            da.open();
            dt = da.selected("SelectPlaneGender", null);
            da.close();
            return dt;

        }
    }
}
