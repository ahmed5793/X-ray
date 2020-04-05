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
    public partial class Frm_ProductMinimum : Form
    {
        Branches b = new Branches();
        Product p = new Product();
        Store s = new Store();
        DataTable dt = new DataTable();
        Users U = new Users();
        public Frm_ProductMinimum()
        {
            InitializeComponent();
            Function();
        }

        void Function()
        {
            try
            {
                Txt_SalesMAn.Text = Program.salesman;
                PermisionStore();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        void PermisionStore()
        {

            dt.Clear();
            dt = U.SelectUserBranch(Txt_SalesMAn.Text);

            if (dt.Rows.Count > 0)
            {
                Cmb_Branch.DataSource = U.SelectUserBranch(Txt_SalesMAn.Text);
                Cmb_Branch.DisplayMember = "Name";
                Cmb_Branch.ValueMember = "Branch_ID";

                cmb_Store.DataSource = s.SelectStoreBranch(Convert.ToInt32(Cmb_Branch.SelectedValue));
                cmb_Store.DisplayMember = "Store_name";
                cmb_Store.ValueMember = "id_store";
            }
            else
            {
                Cmb_Branch.DataSource = null;
                Cmb_Branch.Enabled = false;
                //cmb_UserBranch.DataSource = b.SelectCompBranches();
                //cmb_UserBranch.DisplayMember = "Name";
                //cmb_UserBranch.ValueMember = "Branch_ID";

                //cmb_Stock.DataSource = s.SelectStockBranch(Convert.ToInt32(cmb_UserBranch.SelectedValue));
                //cmb_Stock.DisplayMember = "Name_Stock";
                //cmb_Stock.ValueMember = "ID_Stock";
                store();
            }
        }
        void store()
        {
            cmb_Store.DataSource = s.Select_ComboStore();
            cmb_Store.DisplayMember = "Store_name";
            cmb_Store.ValueMember = "id_store";
        }
        private void Frm_ProductMinimum_Load(object sender, EventArgs e)
        {
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_Store.Text!= "")
                {
                    gridControl1.DataSource = p.Select_MinimumProductFromStore(Convert.ToInt32(cmb_Store.SelectedValue));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void Btn_Print_Click(object sender, EventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }
    }
}
