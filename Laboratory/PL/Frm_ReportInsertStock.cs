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
    public partial class Frm_ReportInsertStock : Form
    {
        Stock S = new Stock();
        Users u = new Users();
        Branches b = new Branches();
        DataTable dt = new DataTable();
        public Frm_ReportInsertStock()
        {
            InitializeComponent();
            txt_UserName.Text = Program.salesman;
            Permision();
            Calc_Amount();
            Calc_AmountPull();
        }
        void Permision()
        {
            dt.Clear();
            dt = u.SelectUserBranch(txt_UserName.Text);

            if (dt.Rows.Count > 0)
            {
                cmb_UserBranch.DataSource = u.SelectUserBranch(txt_UserName.Text);
                cmb_UserBranch.DisplayMember = "Name";
                cmb_UserBranch.ValueMember = "Branch_ID";

                cmb_Stock.DataSource = S.SelectStockBranch(Convert.ToInt32(cmb_UserBranch.SelectedValue));
                cmb_Stock.DisplayMember = "Name_Stock";
                cmb_Stock.ValueMember = "ID_Stock";
            }
            else
            {
                cmb_UserBranch.DataSource = b.SelectCompBranches();
                cmb_UserBranch.DisplayMember = "Name";
                cmb_UserBranch.ValueMember = "Branch_ID";

                Stock();
            }
        }
        void Stock()
            {
            cmb_Stock.DataSource = S.Compo_Stock();
            cmb_Stock.DisplayMember = "Name_Stock";
            cmb_Stock.ValueMember = "ID_Stock";
        }

        void Calc_Amount()
        {
            decimal total = 0;
            for (int i = 0; i < gridViewInsert.DataRowCount; i++)
            {
                DataRow row = gridViewInsert.GetDataRow(i);
                total += Convert.ToDecimal(row[1].ToString());

            }
            textBox1.Text = total.ToString("₱ #,#0.0");

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
        private void btn_search_Click(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();         
            DataTable dt = new DataTable();
            try
            {
                dt.Clear();
                dt = S.Search_Report_InsertStock(Convert.ToInt32(cmb_Stock.SelectedValue), DateFrom.Value, DateTo.Value);
                gridControlInsert.DataSource = dt;
                Calc_Amount();

                dt2.Clear();
                dt2 = S.Search_ReprotStockPull(Convert.ToInt32(cmb_Stock.SelectedValue), DateFrom.Value, DateTo.Value);
                gridControlPull.DataSource = dt2;
                Calc_AmountPull();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                dt.Dispose();
                dt2.Dispose();
            }
        }

        private void cmb_Stock_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
            DataTable dt3 = new DataTable();
            try
            {
                dt2.Clear();
                dt2 = S.Report_InsertStock(Convert.ToInt32(cmb_Stock.SelectedValue));
                gridControlInsert.DataSource = dt2;
                Calc_Amount();
                dt3.Clear();
                dt3 = S.Reprot_StockPull(Convert.ToInt32(cmb_Stock.SelectedValue));
                gridControlPull.DataSource = dt3;
                Calc_AmountPull();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControlInsert.ShowRibbonPrintPreview();
            gridControlPull.ShowRibbonPrintPreview();
        }

        private void Frm_ReportInsertStock_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void gridControlPull_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cmb_UserBranch_SelectionChangeCommitted(object sender, EventArgs e)
        {

            cmb_Stock.DataSource = S.SelectStockBranch(Convert.ToInt32(cmb_UserBranch.SelectedValue));
            cmb_Stock.DisplayMember = "Name_Stock";
            cmb_Stock.ValueMember = "ID_Stock";
        }
    }
}
