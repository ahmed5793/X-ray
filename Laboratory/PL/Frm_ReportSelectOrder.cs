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
    public partial class Frm_ReportSelectOrder : Form
    {
        Orders o = new Orders();
        Users u = new Users();
        Store s = new Store();
        Branches b = new Branches();
        DataTable dt = new DataTable();
      
        public Frm_ReportSelectOrder()
        {
            InitializeComponent();
            txt_UserName.Text = Program.salesman;
            PermisionStore();
        }
        void PermisionStore()
        {

            dt.Clear();
            dt = u.SelectUserBranch(txt_UserName.Text);

            if (dt.Rows.Count > 0)
            {
                cmb_Branch.DataSource = u.SelectUserBranch(txt_UserName.Text);
                cmb_Branch.DisplayMember = "Name";
                cmb_Branch.ValueMember = "Branch_ID";

                cmb_Store.DataSource = s.SelectStoreBranch(Convert.ToInt32(cmb_Branch.SelectedValue));
                cmb_Store.DisplayMember = "Store_name";
                cmb_Store.ValueMember = "id_store";
            }
            else
            {
                cmb_Branch.DataSource = null;
                cmb_Branch.Enabled = false;
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

        private void btn_search_Click(object sender, EventArgs e)
        {

            try
            {

                dt.Clear();
                dt = o.ReportSelectOrder(Convert.ToInt32(cmb_Store.SelectedValue), DateFrom.Value, DateTo.Value);
                gridControl1.DataSource = dt;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            
            }
        }

        private void cmb_Branch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            PermisionStore();
        }

        private void Frm_ReportSelectOrder_Load(object sender, EventArgs e)
        {
           
        }
    }
}
