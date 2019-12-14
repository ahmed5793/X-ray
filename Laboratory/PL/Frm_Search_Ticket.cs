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

        private static Frm_Search_Ticket farm;
        static void STATUESCllosed(object sender, FormClosedEventArgs e)
        {
            farm = null;
        }
        public static Frm_Search_Ticket getmain
        {
            get
            {
                if (farm == null)
                {
                    farm = new Frm_Search_Ticket();
                    farm.FormClosed += new FormClosedEventHandler(STATUESCllosed);
                }
                return farm;
            }
        }
        Suppliers s = new Suppliers();
        Tickets t = new Tickets();

        Users u = new Users();
        Branches b = new Branches();
        DataTable dt = new DataTable();
        public Frm_Search_Ticket()
        {
            InitializeComponent();
            if (farm == null)
            {
                farm = this;
            }
            txt_username.Text = Program.salesman;
            dt = u.SelectUserBranch(txt_username.Text);

           

            if (dt.Rows.Count > 0)
            {
                cmb_branches.DataSource = u.SelectUserBranch(txt_username.Text);
                cmb_branches.DisplayMember = "Name";
                cmb_branches.ValueMember = "Branch_ID";

                 

            }
            else
            {
                cmb_branches.DataSource = b.SelectCompBranches();
                cmb_branches.DisplayMember = "Name";
                cmb_branches.ValueMember = "Branch_ID";
              



            }
        }

        private void Frm_Search_Ticket_Load(object sender, EventArgs e)
        {
            dgv_visit.DataSource =t.SelecthManagmentTicketsBranch(Convert.ToInt32(cmb_branches.SelectedValue));
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            dt.Clear();
            dt = t.SearchManagmentTicketsBranch(txt_search.Text, Convert.ToInt32(cmb_branches.SelectedValue));
            dgv_visit.DataSource = dt;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (dgv_visit.Rows.Count>0)
            {
                Frm_DetailsTickets dt = new Frm_DetailsTickets();
                dt.ShowDialog();

            }
        }
    }
}
