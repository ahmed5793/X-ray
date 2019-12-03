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
    public partial class Frm_Tickets : Form
    {

        public Frm_Tickets()
        {
            InitializeComponent();
            brnches();
            Stock();
            Customer();
        }
        void brnches()
        {
            Branches b = new Branches();
            cmb_branches.DataSource = b.SelectCompBranches();
            cmb_branches.DisplayMember = "Name";
            cmb_branches.ValueMember = "Branch_ID";
            
        }
    
        void Stock()
        {
            Stock s=new Stock();
            cmb_Stock.DataSource = s.Compo_Stock();
            cmb_Stock.DisplayMember = "Name_Stock";
            cmb_Stock.ValueMember = "ID_Stock";

        }
        void Customer()
        {
            Customer c = new Customer();
            Cmb_customer.DataSource = c.SelectCompoCustomer();
            Cmb_customer.DisplayMember = "Cust_Name";
            Cmb_customer.ValueMember = "Cust_ID";
        }
            
        private void Frm_Tickets_Load(object sender, EventArgs e)
        {

        }
    }
}
