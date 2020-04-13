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
    public partial class Frm_ReportStockPull : Form
    {
        Stock s = new Stock();
        Branches b = new Branches();
        Users u = new Users();
        DataTable dt = new DataTable();
        public Frm_ReportStockPull()
        {
            InitializeComponent();
            Function();
        }
        void Function()
        {
            try
            {
                txt_username.Text = Program.salesman;
                Permision();
                Calc_AmountPull();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        void Permision()
        {
            dt.Clear();
            dt = u.SelectUserBranch(txt_username.Text);

            if (dt.Rows.Count > 0)
            {
                cmb_UserBranch.DataSource = u.SelectUserBranch(txt_username.Text);
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
        void Calc_AmountPull()
        {
            decimal total = 0;
            for (int i = 0; i < gridViewPull.DataRowCount; i++)
            {
                DataRow row = gridViewPull.GetDataRow(i);
                total += Convert.ToDecimal(row[1].ToString());

            }
            textBox2.Text = total.ToString("₱ #,#0.0");

        }
        private void cmb_Stock_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                dt.Clear();
                dt = s.Reprot_StockPull(Convert.ToInt32(cmb_Stock.SelectedValue));
                gridControlPull.DataSource = dt;
                Calc_AmountPull();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }


        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                dt.Clear();
                dt = s.Search_ReprotStockPull(Convert.ToInt32(cmb_Stock.SelectedValue), DateFrom.Value, DateTo.Value);
                gridControlPull.DataSource = dt;
                Calc_AmountPull();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            gridControlPull.ShowRibbonPrintPreview();
        }
        private void cmb_UserBranch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Permision();
        }

        private void cmb_Stock_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
           
        }

        private void Frm_ReportStockPull_Load(object sender, EventArgs e)
        {

        }
    }
}
