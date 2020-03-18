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
            label1.Hide();
            comboBox1.Hide();

        }

        private void dgv_visit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
      //public  void rent()
      //  {
      //      if (txt_totalinvoice.Text != "" && txt_totalpay.Text != "")
      //      {
      //          decimal x = Convert.ToDecimal(txt_totalinvoice.Text) - Convert.ToDecimal(txt_totalpay.Text);
      //          textBox1.Text = x.ToString();
      //      }
      //  }
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
               
             
                label1.Show();
                comboBox1.Show();
              
           

            }
            label_day.Text = DateTime.Now.ToShortDateString();
     
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox1.Text=="AM")
            {
                gridControl1.DataSource = t.SelectManagmentTicketsBranchMorning(Convert.ToInt32(cmb_branches.SelectedValue),Convert.ToDateTime(label_day.Text));
                //rent();
            }
           else if (comboBox1.Text=="PM")
            {
                gridControl1.DataSource = t.SelectManagmentTicketsBranchEvening(Convert.ToInt32(cmb_branches.SelectedValue), Convert.ToDateTime (label_day.Text));
                //rent();
            }
            else   if (comboBox1.Text=="FULLDAY")
            {
                gridControl1.DataSource = t.SelectManagmentTicketsBranchFullDay(Convert.ToInt32(cmb_branches.SelectedValue), Convert.ToDateTime(label_day.Text));
                //rent();
            }
            decimal total = 0;
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                DataRow row = gridView1.GetDataRow(i);
                total += Convert.ToDecimal(row[5].ToString());

            }
            txt_totalinvoice.Text = total.ToString("₱ #,##0.0");

            decimal totall = 0;
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                DataRow row = gridView1.GetDataRow(i);
                totall += Convert.ToDecimal(row[4].ToString());

            }
            //txt_totalpay.Text = totall.ToString("₱ #,##0.0");
            //rent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           //gridControl1.DataSource= t.SelectManagmentTicketsBranchDate(Convert.ToInt32(cmb_branches.SelectedValue), FromDate.Value, ToDate.Value);
           // decimal total = 0;
           // for (int i = 0; i < gridView1.RowCount; i++)
           // {
           //     DataRow row = gridView1.GetDataRow(i);
           //     total += Convert.ToDecimal(row[5].ToString());

           // }
           // txt_totalpay.Text = total.ToString("₱ #,##0.0");

           // decimal totall = 0;
           // for (int i = 0; i < gridView1.RowCount; i++)
           // {
           //     DataRow row = gridView1.GetDataRow(i);
           //     totall += Convert.ToDecimal(row[4].ToString());

           // }
           // txt_totalpay.Text = totall.ToString("₱ #,##0.0");
           // rent();
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

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            gridControl1.DataSource = t.SelectManagmentTicketsBranchDate(Convert.ToInt32(cmb_branches.SelectedValue), FromDate.Value, ToDate.Value);
            decimal total = 0;
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                DataRow row = gridView1.GetDataRow(i);
                total += Convert.ToDecimal(row[5].ToString());

            }
            txt_totalinvoice.Text = total.ToString("₱ #,##0.0");

            decimal totall = 0;
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                DataRow row = gridView1.GetDataRow(i);
                totall += Convert.ToDecimal(row[4].ToString());

            }
            //txt_totalpay.Text = totall.ToString("₱ #,##0.0");
            //rent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }
    }
}
