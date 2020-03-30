using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Laboratory.BL;
using Laboratory.RPT.Order;
using Laboratory.RPT_Order;

namespace Laboratory.PL
{
    public partial class frm_ReportFingerExcell : Form
    {
        Finger F = new Finger();
        Branches b = new Branches();
        DataTable dt = new DataTable();
        Users U = new Users();
        public frm_ReportFingerExcell()
        {
            InitializeComponent();
            //cmb_clients.DataSource = F.selectIDfingeremployeeExcell();
            //cmb_clients.DisplayMember = "IDEmployee";
            //cmb_clients.ValueMember = "IDEmployee";

            //cmb_user_branch.DataSource = b.SelectCompBranches();
            //cmb_user_branch.DisplayMember = "Name";
            //cmb_user_branch.ValueMember = "Branch_ID";
            Permision();
            monthe();
            year();

            lable_day.Hide();
            DateFrom.Hide();

            lable_mothe.Show();
            cmb_month.Show();
            cmb_year.Show();
            lable_year.Show();
            cmb_clients.Enabled = true;

            dataGridView1.Show();
            dataGridView2.Hide();
           
            cmb_clients.DataSource = F.selectIDfingeremployeeExcell(Convert.ToInt32(cmb_user_branch.SelectedValue));
            cmb_clients.DisplayMember = "Name_Employee";
            cmb_clients.ValueMember = "IDEmployee";
        }
        void Permision()
        {
         
            dt.Clear();
            dt = U.SelectUserBranch(Program.salesman);
            if (dt.Rows.Count > 0)
            {
                cmb_user_branch.DataSource = U.SelectUserBranch(Program.salesman);
                cmb_user_branch.DisplayMember = "Name";
                cmb_user_branch.ValueMember = "Branch_ID";
            }
            else
            {
                cmb_user_branch.DataSource = b.SelectCompBranches();
                cmb_user_branch.DisplayMember = "Name";
                cmb_user_branch.ValueMember = "Branch_ID";
            }
          

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
            dt.Columns.Add("التاريخ");
            dt.Columns.Add("اليوم");

            dt.Columns.Add("حضور");
            dt.Columns.Add("انصراف");


            int day = DateTime.DaysInMonth(Convert.ToInt32(cmb_year.Text), Convert.ToInt32(cmb_month.SelectedValue));
            for (int i = 0; i < day; i++)
            {
                DateTime daydate = new DateTime(int.Parse(year), int.Parse(month), i + 1);

                dt2.Clear();
                dt2 = F.AttendanceExcell(Convert.ToInt32(cmb_clients.SelectedValue), daydate, Convert.ToInt32(cmb_user_branch.SelectedValue));

                dt.Rows.Add(daydate.ToString("dd-MM-yyyy"), daydate.ToString("dddd"), dt2.Rows[0][0], dt2.Rows[0][1]);






            }
            return dt;
        }
        private void Btn_AddShift_Click(object sender, EventArgs e)
        {

        }

        private void frm_ReportFingerExcell_Load(object sender, EventArgs e)
        {
            //cmb_clients.SelectedIndex = -1;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            try
            {


                if (cmb_user_branch.Text == "")
                {
                    MessageBox.Show("من فضلك قم بااختيار الفرع");
                    return;


                }
             

                if (rdb_monthe.Checked == true)
                {

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
                            dataGridView1.Rows[n].Cells[3].Value = dt10.Rows[i][3].ToString();



                        }


                    }


                }
                else if (rdb_day.Checked==true)
                {
                    dataGridView2.DataSource = f.SelectAllAttendanceExcell(Convert.ToDateTime(DateFrom.Value.ToShortDateString()), Convert.ToInt32(cmb_user_branch.SelectedValue));
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }

        }

        private void cmb_UserBranch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmb_user_branch.Text != "")
            {
                dataGridView1.Rows.Clear();
                cmb_clients.DataSource = F.selectIDfingeremployeeExcell(Convert.ToInt32(cmb_user_branch.SelectedValue));
                cmb_clients.DisplayMember = "Name_Employee";
                cmb_clients.ValueMember = "IDEmployee";


            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {


            if (rdb_monthe.Checked == true)
            {

                dataGridView2.DataSource = null;

                lable_day.Hide();
                DateFrom.Hide();

                lable_mothe.Show();
                cmb_month.Show();
                cmb_year.Show();
                lable_year.Show();
                cmb_clients.Enabled = true;

                dataGridView1.Show();
                dataGridView2.Hide();
            }

        }

        private void rdb_day_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_day.Checked == true)
            {

                dataGridView1.Rows.Clear();


                lable_day.Show();
                DateFrom.Show();
                lable_mothe.Hide();
                cmb_month.Hide();
                cmb_year.Hide();
                lable_year.Hide();
                cmb_clients.Enabled = false;


                dataGridView1.Hide();
                dataGridView2.Show();

            }
        }

        private void rdb_noIn_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
        }
        Finger f = new Finger();
        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            try
            {

                if (rdb_monthe.Checked == true)
                {

                    if (dataGridView1.Rows.Count > 0)
                    {




                        DataSetFingerExcell ds1 = new DataSetFingerExcell();
                        RPT.Order.RPT_FingeerExcell rf = new RPT.Order.RPT_FingeerExcell();
                        frm_SingelReport sr = new frm_SingelReport();

                        sr.documentViewer1.Refresh();
                        ds1.Tables["DataTable1"].Clear();

                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {


                            ds1.Tables["DataTable1"].Rows.Add(dataGridView1.Rows[i].Cells[0].Value.ToString(), dataGridView1.Rows[i].Cells[1].Value.ToString(),
                            dataGridView1.Rows[i].Cells[2].Value.ToString(), dataGridView1.Rows[i].Cells[3].Value.ToString());






                        }


                        rf.DataSource = ds1;
                        rf.Parameters["Date"].Value = cmb_year.Text + "/" + cmb_month.Text;
                        rf.Parameters["ID"].Value = Convert.ToInt32(cmb_clients.SelectedValue);
                        rf.Parameters["idbranch"].Value = Convert.ToInt32(cmb_user_branch.SelectedValue);
                        rf.Parameters["NameEmployee"].Value = cmb_clients.Text;
                        rf.Parameters["UserName"].Value = Program.salesman;



                        sr.documentViewer1.DocumentSource = rf;
                        rf.Parameters["Date"].Visible = false;
                        rf.Parameters["ID"].Visible = false;
                        rf.Parameters["idbranch"].Visible = false;
                        rf.Parameters["NameEmployee"].Visible = false;
                        rf.Parameters["UserName"].Visible = false;
                        sr.ShowDialog();
                    }
                }


                else if (rdb_day.Checked == true)
                {
                    if (dataGridView2.Rows.Count > 0)
                    {


                        DataSetFingerExcelDay ds = new DataSetFingerExcelDay();
                        RPT_FingerExcellDay rd = new RPT_FingerExcellDay();
                        frm_SingelReport sr = new frm_SingelReport();

                        sr.documentViewer1.Refresh();
                        ds.Tables["DataTableDay"].Clear();

                        for (int i = 0; i < dataGridView2.Rows.Count; i++)
                        {


                            ds.Tables["DataTableDay"].Rows.Add(dataGridView2.Rows[i].Cells[0].Value.ToString(), dataGridView2.Rows[i].Cells[1].Value.ToString(),
                               Convert.ToDateTime(dataGridView2.Rows[i].Cells[2].Value).ToString("hh:mm tt"),
                            Convert.ToDateTime(dataGridView2.Rows[i].Cells[3].Value).ToString("hh:mm tt"));






                        }


                        rd.DataSource = ds;
                        rd.Parameters["Date"].Value = Convert.ToDateTime(DateFrom.Value);
                        rd.Parameters["NameBranch"].Value = cmb_user_branch.Text;
                        rd.Parameters["UserName"].Value = Program.salesman;





                        sr.documentViewer1.DocumentSource = rd;
                        rd.Parameters["Date"].Visible = false;
                        rd.Parameters["NameBranch"].Visible = false;
                        rd.Parameters["UserName"].Visible = false;


                        sr.ShowDialog();

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }
        } 
    }
}