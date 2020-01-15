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
    public partial class Frm_Payouts : Form
    {
        DataTable dt = new DataTable();
        Users u = new Users();
        Branches b = new Branches();
        Stock s = new Stock();
        public Frm_Payouts()
        {
            InitializeComponent();
            Permision();
        }
        void Permision()
        {
            dt.Clear();
            dt = u.SelectUserBranch(txt_username.Text);

            if (dt.Rows.Count > 0)
            {
                comboBox1.DataSource = u.SelectUserBranch(txt_username.Text);
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "Branch_ID";

                cmb_Stock.DataSource = s.SelectStockBranch(Convert.ToInt32(comboBox1.SelectedValue));
                cmb_Stock.DisplayMember = "Name_Stock";
                cmb_Stock.ValueMember = "ID_Stock";
            }
            else
            {
                comboBox1.DataSource = b.SelectCompBranches();
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "Branch_ID";

                Stock();
            }
        }
        void Stock()
        {

            cmb_Stock.DataSource = s.Compo_Stock();
            cmb_Stock.DisplayMember = "Name_Stock";
            cmb_Stock.ValueMember = "ID_Stock";

        }
        private void Frm_Payouts_Load(object sender, EventArgs e)
        {
            txt_prise.Enabled = false;
            txt_username.Text = Program.salesman;
        }

        private void rdbPartPay_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPartPay.Checked==true)
            {
                txt_prise.Enabled = true;
            }
        }

        private void RdbAllPay_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbAllPay.Checked == true)
            {
                txt_prise.Enabled = false;
            }
        }
    }
}
