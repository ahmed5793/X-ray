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
        Stock s = new Stock();
        Branches b = new Branches();
        Users u = new Users();
        DataTable dt = new DataTable();

        public Frm_ReportInsertStock()
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
               // Calc_Amount();
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
        //void Calc_Amount()
        //{
        //    decimal total = 0;
        //    for (int i = 0; i < gridViewInsert.DataRowCount; i++)
        //    {
        //        DataRow row = gridViewInsert.GetDataRow(i);
        //        total += Convert.ToDecimal(row[1].ToString());

        //    }
        //    textBox1.Text = total.ToString("₱ #,#0.0");

        //}
     
        private void btn_search_Click(object sender, EventArgs e)
        {
        }

        private void cmb_Stock_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //try
            //{
            //    dt.Clear();
            //    dt = s.Report_InsertStock(Convert.ToInt32(cmb_Stock.SelectedValue));
            //    gridControlInsert.DataSource = dt;
            //    Calc_Amount();

            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message);

            //}
        }


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                dt.Clear();
                dt = s.Search_Report_InsertStock(Convert.ToInt32(cmb_Stock.SelectedValue), DateFrom.Value, DateTo.Value);
                gridControlInsert.DataSource = dt;
               // Calc_Amount();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
               
            }
          
        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControlInsert.ShowRibbonPrintPreview();
        }

        private void cmb_UserBranch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dt.Clear();
            dt = u.SelectUserBranch(txt_username.Text);

            if (dt.Rows.Count > 0)
            {
            

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

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            gridControlInsert.ShowRibbonPrintPreview();
        }

        private void Frm_ReportInsertStock_Load(object sender, EventArgs e)
        {

        }
    }
}
