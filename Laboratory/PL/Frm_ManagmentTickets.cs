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
    public partial class Frm_ManagmentTickets : Form
    {
        Users u = new Users();
        Branches b = new Branches();
        Tickets t = new Tickets();
        public Frm_ManagmentTickets()
        {
            InitializeComponent();
         




        }

        private void dgv_visit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        DataTable dt = new DataTable();
        private void Frm_ManagmentTickets_Load(object sender, EventArgs e)
        {
            txt_username.Text = Program.salesman;
            dt = u.SelectUserBranch(txt_username.Text);

            if (dt.Rows.Count>0)
            {
                cmb_branches.DataSource = u.SelectUserBranch(txt_username.Text);
                cmb_branches.DisplayMember = "Name";
                cmb_branches.ValueMember = "Branch_ID";

                label1.Show();
                comboBox1.Show();

                label2.Hide();
                label3.Hide();
                FromDate.Hide();
                ToDate.Hide();
                button1.Hide();

             


            }
            else
            {
                cmb_branches.DataSource = b.SelectCompBranches();
                cmb_branches.DisplayMember = "Name";
                cmb_branches.ValueMember = "Branch_ID";
                label2.Show();
                label3.Show();
                FromDate.Show();
                ToDate.Show();
                button1.Show();
             
                label1.Show();
                comboBox1.Show();
              
           

            }
            label_day.Text = DateTime.Now.ToShortDateString();
     
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox1.Text=="AM")
            {
                dgv_visit.DataSource = t.SelectManagmentTicketsBranchMorning(Convert.ToInt32(cmb_branches.SelectedValue),Convert.ToDateTime(label_day.Text));
            }
           else if (comboBox1.Text=="PM")
            {
                dgv_visit.DataSource = t.SelectManagmentTicketsBranchEvening(Convert.ToInt32(cmb_branches.SelectedValue), Convert.ToDateTime (label_day.Text));

            }
            else   if (comboBox1.Text=="FULLDAY")
            {
                dgv_visit.DataSource = t.SelectManagmentTicketsBranchFullDay(Convert.ToInt32(cmb_branches.SelectedValue), Convert.ToDateTime(label_day.Text));

            }
            decimal total = 0;
            for (int i = 0; i <= dgv_visit.Rows.Count - 1; i++)
            {
                total += Convert.ToDecimal(dgv_visit.Rows[i].Cells[5].Value);

            }
            txt_rent.Text = Math.Round(total, 2).ToString();

            decimal totall = 0;
            for (int i = 0; i <= dgv_visit.Rows.Count - 1; i++)
            {
                totall += Convert.ToDecimal(dgv_visit.Rows[i].Cells[4].Value);

            }
            txt_pay.Text = Math.Round(totall, 2).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           dgv_visit.DataSource= t.SelectManagmentTicketsBranchDate(Convert.ToInt32(cmb_branches.SelectedValue), FromDate.Value, ToDate.Value);
            decimal total = 0;
            for (int i = 0; i <= dgv_visit.Rows.Count - 1; i++)
            {
                total += Convert.ToDecimal(dgv_visit.Rows[i].Cells[5].Value);


            }
            txt_rent.Text = Math.Round(total, 2).ToString();

            decimal totall = 0;
            for (int i = 0; i <= dgv_visit.Rows.Count - 1; i++)
            {
                totall += Convert.ToDecimal(dgv_visit.Rows[i].Cells[4].Value);

            }
            txt_pay.Text = Math.Round(totall, 2).ToString();
        }

        private void txt_phone_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            

            label2.Hide();
            label3.Hide();
            FromDate.Hide();
            ToDate.Hide();
            button1.Hide();



          
           
           
            label1.Hide();
            comboBox1.Hide();
        
         

         
           


        }

        private void rdb_NewPatient_CheckedChanged(object sender, EventArgs e)
        {
            
           
        
           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
          

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ToDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FromDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
