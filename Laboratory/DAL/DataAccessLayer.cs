using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Laboratory.DAL
{
    class DataAccessLayer
    {
        SqlConnection con;

        public DataAccessLayer()
        {
            con = new SqlConnection(@"server =.; database=Laboratory;integrated security=true");

        }
        internal void open()

        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }

        }
        internal void close()
        {
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
        }
        SqlCommand cm = new SqlCommand();
        internal DataTable selected(string storedProcedure, SqlParameter[] param)
        {

            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = storedProcedure;
            cm.Connection = con;
            if (param != null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    cm.Parameters.Add(param[i]);
                }

            }
            SqlDataAdapter adabt = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            adabt.Fill(dt);
            return dt;
        }

        internal void excutequery(string storedProcedure, SqlParameter[] param)
        {
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = storedProcedure;
            cm.Connection = con;
            if (param != null)
            {
                cm.Parameters.AddRange(param);
            }
            cm.ExecuteNonQuery();

        }



    }
}
