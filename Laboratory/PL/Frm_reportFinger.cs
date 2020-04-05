using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Laboratory.BL;

namespace Laboratory.PL
{
    public partial class Frm_reportFinger : DevExpress.XtraEditors.XtraForm
    {
        Finger f = new Finger();
        public Frm_reportFinger()
        {
            InitializeComponent();
            Function();
            //dataGridView1.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";
            //dataGridView1.Columns[1].DefaultCellStyle.Format = "hh:mm tt";
            //dataGridView1.Columns[2].DefaultCellStyle.Format = "hh:mm tt";

        }
        void Function()
        {
            try
            {
                cmcb_clients.DataSource = f.selectidfingeremployee();
                cmcb_clients.DisplayMember = "IDEmployee";
                cmcb_clients.ValueMember = "IDEmployee";
                monthe();
                year();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        void year()
        {
            for (int i = 2010; i <= DateTime.Now.Year; i++)
            {
           
                cmb_year.Items.Add(i);
                cmb_year.SelectedIndex = 0;

            }
        }
        void monthe()
        {
            this.cmb_month.DisplayMember = "Text";
            this.cmb_month.ValueMember = "Value";

            var months = new[]
            {
            new { Text = "January", Value = 01 },
            new { Text = "February", Value = 02 },
            new { Text = "March", Value = 03 },
            new { Text = "April", Value = 04 },
            new { Text = "May", Value = 05 },
            new { Text = "June", Value = 06 },
            new { Text = "July", Value = 07 },
            new { Text = "Aughust", Value = 08 },
            new { Text = "September", Value = 09 },
            new { Text = "October", Value = 10 },
            new { Text = "November", Value = 11 },
            new { Text = "December", Value = 12 }
        };
            this.cmb_month.DataSource = months;

            DateTime now = DateTime.Now;
            int monthValue = now.Month;
            cmb_month.SelectedIndex = monthValue - 1;


        }
        public DataTable getatt(int EmpID, string year, string month)
        {
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            dt.Columns.Add("Day");
            dt.Columns.Add("CheckIN");
            dt.Columns.Add("Checkout");


            int day = DateTime.DaysInMonth(Convert.ToInt32(cmb_year.Text), Convert.ToInt32(cmb_month.SelectedValue));
            for (int i = 0; i < day; i++)
            {
                DateTime daydate = new DateTime(int.Parse(year) , int.Parse(month) , i+1);

               
                dt2 = f.Attendance(Convert.ToInt32(cmcb_clients.SelectedValue), daydate);

                dt.Rows.Add(daydate.ToString(), dt2.Rows[0][0].ToString(), dt2.Rows[0][1].ToString());

               

            }
            return dt;
        }
        private void Frm_reportFinger_Load(object sender, EventArgs e)
        {

        }

        private void Btn_AddShift_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            DataTable dt = new DataTable();
            dt = getatt(int.Parse(cmcb_clients.Text) ,cmb_year.Text, cmb_month.SelectedValue.ToString());
          

            if (dt.Rows.Count > 0)
            {
                int n = 0;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = dt.Rows[i][0].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = dt.Rows[i][1].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = dt.Rows[i][2].ToString();
                }

              

            }


            //try
            //{
            //    dataGridView1.DataSource = getatt(Convert.ToInt32(cmcb_clients.SelectedValue), cmb_year.Text, cmb_month.SelectedValue.ToString());

            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message);
            //    MessageBox.Show(ex.StackTrace);
            //}

        }

        private void DateTo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmcb_clients_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_month_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_year_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void DateFrom_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}