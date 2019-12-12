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
    public partial class Frm_Search_Ticket : Form
    {
        Tickets t = new Tickets();

        Users u = new Users();
        Branches b = new Branches();
        DataTable dt = new DataTable();
        public Frm_Search_Ticket()
        {
            InitializeComponent();
            txt_username.Text = Program.salesman;
            dt = u.SelectUserBranch(txt_username.Text);

             cmb_branches.DataSource = u.SelectUserBranch(txt_username.Text);
                cmb_branches.DisplayMember = "Name";
                cmb_branches.ValueMember = "Branch_ID";
            }

        private void Frm_Search_Ticket_Load(object sender, EventArgs e)
        {

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            dt.Clear();
            dt = t.SearchManagmentTicketsBranch(txt_search.Text, Convert.ToInt32(cmb_branches.SelectedValue));
            dgv_visit.DataSource = dt;
        }
    }
}
