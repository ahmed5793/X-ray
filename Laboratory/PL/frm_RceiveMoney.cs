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
    public partial class frm_RceiveMoney : DevExpress.XtraEditors.XtraForm
    {
        Employee E = new Employee();
        Stock S = new Stock();
        Users U = new Users();
        Branches b = new Branches();
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt3 = new DataTable();
        Stock s = new Stock();
        //void Permision()
        //{
        //    //dt.Clear();
        //    //dt = U.SelectUserBranch(Program.salesman);
        //    //if (dt.Rows.Count > 0)
        //    //{
        //    //     cmb_UserBranch.Enabled = true;
        //    //    cmb_UserBranch.DataSource = U.SelectUserBranch(Program.salesman);
        //    //    cmb_UserBranch.DisplayMember = "Name";
        //    //    cmb_UserBranch.ValueMember = "Branch_ID";


        //    //    cmb_Stock.DataSource = s.SelectStockBranch(Convert.ToInt32(cmb_UserBranch.SelectedValue));
        //    //    cmb_Stock.DisplayMember = "Name_Stock";
        //    //    cmb_Stock.ValueMember = "ID_Stock";
        //    //    Cmb_Users.DataSource = E.Select_EmployeFromBranch(Convert.ToInt32(cmb_UserBranch.SelectedValue));
        //    //    Cmb_Users.DisplayMember = "Emp_Name";
        //    //    Cmb_Users.ValueMember = "id_Emp";
        //    //    Cmb_Users.SelectedIndex = -1;
        //    //}
        //    //else
        //    //{

        //    cmb_UserBranch.Enabled = true;
        //    cmb_UserBranch.DataSource = b.SelectCompBranches();
        //    cmb_UserBranch.DisplayMember = "Name";
        //    cmb_UserBranch.ValueMember = "Branch_ID";


        //    cmb_Stock.DataSource = s.SelectStockBranch(Convert.ToInt32(cmb_UserBranch.SelectedValue));
        //    cmb_Stock.DisplayMember = "Name_Stock";
        //    cmb_Stock.ValueMember = "ID_Stock";


        //    //Cmb_Users.DataSource = E.Select_EmployeFromBranch(Convert.ToInt32(cmb_UserBranch.SelectedValue));
        //    //Cmb_Users.DisplayMember = "Emp_Name";
        //    //Cmb_Users.ValueMember = "id_Emp";
        //    //Cmb_Users.SelectedIndex = -1;



        //    // }


        //}


        public frm_RceiveMoney()
        {
            InitializeComponent();
            Function();
            Function2();
        }
    
        /// <summary>
        /// إستلام نقدية يومي
        /// </summary>
        void Function()
        {
            try
            {
                // Select_Users();

                Permision();
                DateFrom.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());

                textBox4.Hide();
                label7.Hide();
                Cmb_Users.Hide();
                checkBox1.Hide();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        void Permision()
        {
            dt.Clear();
            dt = U.SelectUserBranch(Program.salesman);

            if (dt.Rows.Count > 0)
            {
                cmb_UserBranch.DataSource = U.SelectUserBranch(Program.salesman);
                cmb_UserBranch.DisplayMember = "Name";
                cmb_UserBranch.ValueMember = "Branch_ID";

                cmb_Stock.DataSource = s.SelectStockBranch(Convert.ToInt32(cmb_UserBranch.SelectedValue));
                cmb_Stock.DisplayMember = "Name_Stock";
                cmb_Stock.ValueMember = "ID_Stock";
            }
            else
            {
                cmb_UserBranch.DataSource = null;
                cmb_UserBranch.Enabled = false;
                //cmb_UserBranch.DataSource = b.SelectCompBranches();
                //cmb_UserBranch.DisplayMember = "Name";
                //cmb_UserBranch.ValueMember = "Branch_ID";

                //cmb_Stock.DataSource = s.SelectStockBranch(Convert.ToInt32(cmb_UserBranch.SelectedValue));
                //cmb_Stock.DisplayMember = "Name_Stock";
                //cmb_Stock.ValueMember = "ID_Stock";
                Stock();
            }
        }
        void Stock()
        {
            cmb_Stock.DataSource = s.Compo_Stock();
            cmb_Stock.DisplayMember = "Name_Stock";
            cmb_Stock.ValueMember = "ID_Stock";
        }



        void calcInsertMoney()
        {
            decimal total = 0;
            for (int i = 0; i < gridViewInsert.RowCount; i++)
            {
                DataRow r = gridViewInsert.GetDataRow(i);
                total += Convert.ToDecimal(r[1].ToString());
            }
            textBox1.Text = total.ToString();
        }
        void CalcPullMoney()
        {
            decimal total = 0;
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                DataRow r = gridView1.GetDataRow(i);
                total += Convert.ToDecimal(r[1].ToString());
            }
            textBox2.Text = total.ToString();
        }
        void Clac_total()
        {
            decimal totalmoney = Convert.ToDecimal(textBox1.Text) - Convert.ToDecimal(textBox2.Text);
            textBox3.Text = totalmoney.ToString();
        }


        //////////////////////////////////////////////////
        ///

        /// <summary>
        /// إستلام نقدية من فترة لفتره
        /// </summary>
        void Function2()
        {
            try
            {
                // Select_Users();

                Permision2();
                DateFrom.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());

                textBox4.Hide();
                label7.Hide();
                Cmb_Users.Hide();
                checkBox1.Hide();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        void Permision2()
        {
            dt.Clear();
            dt = U.SelectUserBranch(Program.salesman);

            if (dt.Rows.Count > 0)
            {
                comboBox3.DataSource = U.SelectUserBranch(Program.salesman);
                comboBox3.DisplayMember = "Name";
                comboBox3.ValueMember = "Branch_ID";

                comboBox2.DataSource = s.SelectStockBranch(Convert.ToInt32(cmb_UserBranch.SelectedValue));
                comboBox2.DisplayMember = "Name_Stock";
                comboBox2.ValueMember = "ID_Stock";
            }
            else
            {
                comboBox3.DataSource = null;
                comboBox3.Enabled = false;
                //cmb_UserBranch.DataSource = b.SelectCompBranches();
                //cmb_UserBranch.DisplayMember = "Name";
                //cmb_UserBranch.ValueMember = "Branch_ID";

                //cmb_Stock.DataSource = s.SelectStockBranch(Convert.ToInt32(cmb_UserBranch.SelectedValue));
                //cmb_Stock.DisplayMember = "Name_Stock";
                //cmb_Stock.ValueMember = "ID_Stock";
                Stock();
            }
        }
        void Stock2()
        {
            comboBox2.DataSource = s.Compo_Stock();
            comboBox2.DisplayMember = "Name_Stock";
            comboBox2.ValueMember = "ID_Stock";
        }



        void calcInsertMoney2()
        {
            decimal total = 0;
            for (int i = 0; i < gridView3.RowCount; i++)
            {
                DataRow r = gridViewInsert.GetDataRow(i);
                total += Convert.ToDecimal(r[1].ToString());
            }
            textBox1.Text = total.ToString();
        }
        void CalcPullMoney2()
        {
            decimal total = 0;
            for (int i = 0; i < gridView2.RowCount; i++)
            {
                DataRow r = gridView1.GetDataRow(i);
                total += Convert.ToDecimal(r[1].ToString());
            }
            textBox2.Text = total.ToString();
        }
        void Clac_total2()
        {
            decimal totalmoney = Convert.ToDecimal(textBox8.Text) - Convert.ToDecimal(textBox5.Text);
            textBox7.Text = totalmoney.ToString();
        }










        DataTable dt1 = new DataTable();
        DataTable dt4 = new DataTable();
        private void Btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                //if (checkBox1.Checked==true)
                //{

                dt1.Clear();
                dt1 = U.Select_MoneyForUserAllBranch(Convert.ToInt32(cmb_Stock.SelectedValue), DateFrom.Value, Time_From.Value.TimeOfDay,
                   Time_To.Value.TimeOfDay);
                dt4.Clear();
                dt4 = U.Select_PullMoneyForUserAllBranch(Convert.ToInt32(cmb_Stock.SelectedValue), DateFrom.Value, Time_From.Value.TimeOfDay, Time_To.Value.TimeOfDay);
                gridControl1.DataSource = dt4;
                gridControlInsert.DataSource = dt1;
                //}
                //else if((checkBox1.Checked == false))
                //{
                //    dt.Clear();
                //    dt = U.Select_MoneyForUser(Convert.ToInt32(cmb_Stock.SelectedValue), textBox4.Text, DateFrom.Value, Time_From.Value.TimeOfDay,
                //       Time_To.Value.TimeOfDay);
                //    dt2.Clear();
                //    dt2 = U.Select_PullMoneyForUser(Convert.ToInt32(cmb_Stock.SelectedValue), textBox4.Text, DateFrom.Value, Time_From.Value.TimeOfDay, Time_To.Value.TimeOfDay);
                //    gridControl1.DataSource = dt2;
                //    gridControlInsert.DataSource = dt;
                //}

                calcInsertMoney();
                CalcPullMoney();
                Clac_total();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }
        private void cmb_UserBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            //dt.Clear();
            //dt = U.SelectUserBranch(Program.salesman);
            //if (dt.Rows.Count > 0)
            //{



            //    Cmb_Users.DataSource = E.Select_EmployeFromBranch(Convert.ToInt32(cmb_UserBranch.SelectedValue));
            //    Cmb_Users.DisplayMember = "Emp_Name";
            //    Cmb_Users.ValueMember = "id_Emp";
            //    Cmb_Users.SelectedIndex = -1;
            //}
            //else
            //{
            try
            {

          
            cmb_Stock.DataSource = s.SelectStockBranch(Convert.ToInt32(cmb_UserBranch.SelectedValue));
            cmb_Stock.DisplayMember = "Name_Stock";
            cmb_Stock.ValueMember = "ID_Stock";


                //Cmb_Users.DataSource = E.Select_EmployeFromBranch(Convert.ToInt32(cmb_UserBranch.SelectedValue));
                //Cmb_Users.DisplayMember = "Emp_Name";
                //Cmb_Users.ValueMember = "id_Emp";
                //Cmb_Users.SelectedIndex = -1;


                // }
            }
            catch (Exception)
            {

                return;
            }
        }
          

    private void cmb_UserBranch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {

         
            dt.Clear();
            dt = U.SelectUserBranch(Program.salesman);
            if (dt.Rows.Count > 0)
            {



                Cmb_Users.DataSource = E.Select_EmployeFromBranch(Convert.ToInt32(cmb_UserBranch.SelectedValue));
                Cmb_Users.DisplayMember = "Emp_Name";
                Cmb_Users.ValueMember = "id_Emp";
                Cmb_Users.SelectedIndex = -1;
            }
            else
            {

                cmb_Stock.DataSource = s.SelectStockBranch(Convert.ToInt32(cmb_UserBranch.SelectedValue));
                cmb_Stock.DisplayMember = "Name_Stock";
                cmb_Stock.ValueMember = "ID_Stock";


                Cmb_Users.DataSource = E.Select_EmployeFromBranch(Convert.ToInt32(cmb_UserBranch.SelectedValue));
                Cmb_Users.DisplayMember = "Emp_Name";
                Cmb_Users.ValueMember = "id_Emp";
                Cmb_Users.SelectedIndex = -1;


            }
            }
            catch (Exception)
            {

                return;
            }
        }
            

    private void frm_RceiveMoney_Load(object sender, EventArgs e)
        {

        }

        private void Cmb_Users_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dt3.Clear();
            dt3 = U.Select_UserName(Convert.ToInt32(Cmb_Users.SelectedValue));
            textBox4.Text = dt3.Rows[0][0].ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {


                if (checkBox1.Checked == true)
                {
                    Cmb_Users.Enabled = false;
                }
                else
                {
                    Cmb_Users.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void gridControlInsert_Click(object sender, EventArgs e)
        {

        }

        private void gridControlInsert_DataSourceChanged(object sender, EventArgs e)
        {

        }

        private void searchControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
            gridControlInsert.ShowRibbonPrintPreview();
        }
    }
}