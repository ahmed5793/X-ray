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



            txt_search.Hide();
            FromDate.Hide();
            ToDate.Hide();
            button2.Hide();
            cmb_branches.DataSource = null;
            cmb_branches.Enabled = false;
            checkBox1.Hide();
            label2.Hide();
            label3.Hide();
          
              



          
        }

        private void Frm_Search_Ticket_Load(object sender, EventArgs e)
        {
        
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            dt.Clear();
            dt = t.SearchManagmentTicketsBranch(txt_search.Text);
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                cmb_branches.Enabled = true;
                cmb_branches.DataSource = b.SelectCompBranches();
                cmb_branches.DisplayMember = "Name";
                cmb_branches.ValueMember = "Branch_ID";

            }
            else
            {
                cmb_branches.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                cmb_branches.Enabled = true;
                dgv_visit.DataSource = t.SelectSearchticketsBranchDate(Convert.ToInt32(cmb_branches.SelectedValue), FromDate.Value, ToDate.Value);


            }
            else
            {
                cmb_branches.DataSource = null;
                cmb_branches.Enabled = false;
                dgv_visit.DataSource = t.SelectSearchticketsDate( FromDate.Value, ToDate.Value);

            }

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox1.Text== "ألاسم او رقم الحجز")
            {
            
                txt_search.Clear();
                label2.Hide();
                label3.Hide();
                txt_search.Show();
                FromDate.Hide();
                ToDate.Hide();
                button2.Hide();
                cmb_branches.DataSource = null;
                cmb_branches.Enabled = false;
                checkBox1.Hide();
                dgv_visit.DataSource = t.SelecthManagmentTicketsBranch();

            }
            else if(comboBox1.Text== "بالتاريخ")
            {
                txt_search.Clear();
                dgv_visit.DataSource = null;
              
                label2.Show();
                label3.Show();
                txt_search.Hide();
                FromDate.Show();
                ToDate.Show();
                button2.Show();
               
                cmb_branches.Enabled = false;
                checkBox1.Show();
            }
        }
    }
}
