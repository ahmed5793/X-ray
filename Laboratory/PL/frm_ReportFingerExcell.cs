using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Laboratory.BL;

namespace Laboratory.PL
{
    public partial class frm_ReportFingerExcell : Form
    {
        Finger F = new Finger();
        Branches b = new Branches();
        
        public frm_ReportFingerExcell()
        {
            InitializeComponent();
            //cmb_clients.DataSource = F.selectIDfingeremployeeExcell();
            //cmb_clients.DisplayMember = "IDEmployee";
            //cmb_clients.ValueMember = "IDEmployee";
        
            cmb_user_branch.DataSource = b.SelectCompBranches();
            cmb_user_branch.DisplayMember = "Name";
            cmb_user_branch.ValueMember = "Branch_ID";
            monthe();
            year();
        }
    
        void year()
        {
            for (int i = 2020; i <= DateTime.Now.Year; i++)
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
                DateTime daydate = new DateTime(int.Parse(year), int.Parse(month), i + 1);

                dt2.Clear();
                dt2 = F.AttendanceExcell(Convert.ToInt32(cmb_clients.SelectedValue), daydate,Convert.ToInt32(cmb_user_branch.SelectedValue));
                dt.Rows.Add(daydate.ToString(), dt2.Rows[0][0].ToString(), dt2.Rows[0][1].ToString());

              




            }
            return dt;
        }
        private void Btn_AddShift_Click(object sender, EventArgs e)
        {

        }

        private void frm_ReportFingerExcell_Load(object sender, EventArgs e)
        {
            cmb_clients.SelectedIndex = -1;
        }


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {


                dataGridView1.Rows.Clear();
                if (cmb_user_branch.Text == "")
                {
                    MessageBox.Show("من فضلك قم بااختيار الفرع");
                    return;


                }
                if (cmb_clients.Text == "")
                {
                    MessageBox.Show("من فضلك قم بااختيار اسم الموظف");
                    return;

                }



                DataTable dt10 = new DataTable();
                dt10.Clear();
                dt10 = getatt(Convert.ToInt32(cmb_clients.SelectedValue), cmb_year.Text, cmb_month.SelectedValue.ToString());
         

                if (dt10.Rows.Count > 0)
                {
                    int n = 0;
                    for (int i = 0; i < dt10.Rows.Count; i++)
                    {
                        n = dataGridView1.Rows.Add();
                        dataGridView1.Rows[n].Cells[0].Value = dt10.Rows[i][0].ToString();
                        dataGridView1.Rows[n].Cells[1].Value = dt10.Rows[i][1].ToString();


                        dataGridView1.Rows[n].Cells[2].Value = dt10.Rows[i][2].ToString();
                      

                    }



                }
            

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
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

        private void cmb_UserBranch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmb_user_branch.Text!="")
            {
                dataGridView1.Rows.Clear();
               cmb_clients.DataSource= F.selectIDfingeremployeeExcell(Convert.ToInt32(cmb_user_branch.SelectedValue));
                cmb_clients.DisplayMember = "Name_Employee";
                cmb_clients.ValueMember = "IDEmployee";
           

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
