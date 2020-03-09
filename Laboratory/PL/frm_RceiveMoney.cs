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
        Stock S = new Stock();
        Users U = new Users();
        Branches b = new Branches();
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt3 = new DataTable();
        void Permision()
        {
            dt.Clear();
            dt = U.SelectUserBranch(txt_UserName.Text);
            if (dt.Rows.Count > 0)
            {
                cmb_UserBranch.DataSource = U.SelectUserBranch(txt_UserName.Text);
                cmb_UserBranch.DisplayMember = "Name";
                cmb_UserBranch.ValueMember = "Branch_ID";
                cmb_UserBranch.SelectedIndex = -1;
            }
            else
            {
                cmb_UserBranch.DataSource = b.SelectCompBranches();
                cmb_UserBranch.DisplayMember = "Name";
                cmb_UserBranch.ValueMember = "Branch_ID";
                cmb_UserBranch.SelectedIndex = -1;

            }
        }

        public frm_RceiveMoney()
        {
            InitializeComponent();
            Select_Users();
            txt_UserName.Text = Program.salesman;
            Permision();
        }
   
        void Select_Users()
        {
            Cmb_Users.DataSource = U.SelectUsers();
            Cmb_Users.DisplayMember = "User Name";
            Cmb_Users.ValueMember = "ID";
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
        private void Btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                
                dt.Clear();
                dt = U.Select_MoneyForUser(Cmb_Users.Text,DateFrom.Value,Time_From.Value.TimeOfDay,
                   Time_To.Value.TimeOfDay);
                dt2.Clear();
                dt2 = U.Select_PullMoneyForUser(Cmb_Users.Text, DateFrom.Value, Time_From.Value.TimeOfDay, Time_To.Value.TimeOfDay);
                gridControl1.DataSource = dt2;
                gridControlInsert.DataSource = dt;
                calcInsertMoney();
                CalcPullMoney();
                Clac_total();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }
        private void cmb_UserBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_UserBranch.Text!="")
            {
                Cmb_Users.DataSource = U.Select_UserForBranch(Convert.ToInt32(cmb_UserBranch.SelectedValue));
                Cmb_Users.DisplayMember = "UserName";
                Cmb_Users.ValueMember ="id_Emp";
                Cmb_Users.SelectedIndex = -1;
            }
        }

        private void cmb_UserBranch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmb_UserBranch.Text != "")
            {
                Cmb_Users.DataSource = U.Select_UserForBranch(Convert.ToInt32(cmb_UserBranch.SelectedValue));
                Cmb_Users.DisplayMember = "UserName";
                Cmb_Users.ValueMember = "id_Emp";
                Cmb_Users.SelectedIndex = -1;
            }
        }
    }
}