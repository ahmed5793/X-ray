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

        Suppliers s = new Suppliers();
        Tickets t = new Tickets();

        Users u = new Users();
        Branches b = new Branches();
        DataTable dt = new DataTable();
        public Frm_Search_Ticket()
        {
            InitializeComponent();

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
            DataTable dt = new DataTable();

            DataTable dt10 = new DataTable();
            DataTable dt5 = new DataTable();
            Tickets t = new Tickets();
            Frm_DetailsTickets fd = new Frm_DetailsTickets();
            if (dgv_visit.Rows.Count > 0)
            {

                dt10 = t.vildateTicketCompany(Convert.ToInt32(dgv_visit.CurrentRow.Cells[0].Value));
                if (dt10.Rows.Count > 0)
                {
                    fd.Txt_PricePayment.Hide();
                    fd.Txt_addtionPayment.Hide();

                    fd.txt_idcompany.Hide();


                    fd.label26.Hide();
                    fd.label27.Hide();
                    fd.txt_company.Hide();
                    fd.label21.Hide();
                    dt5.Clear();
                    dt5 = t.TicketDetailsSelectTickets(Convert.ToInt32(dgv_visit.CurrentRow.Cells[0].Value));

                    foreach (DataRow dr in dt5.Rows)
                    {
                        fd.txt_name.Text = dr[1].ToString();
                        fd.txt_phone.Text = dr[2].ToString();
                        fd.txt_address.Text = dr[3].ToString();
                        fd.txt_age.Text = dr[4].ToString();
                        fd.txt_dateVisit.Text = dr[5].ToString();
                        fd.txt_dateRecive.Text = dr[6].ToString();
                        fd.txt_doctorOfCenter.Text = dr[7].ToString();
                        fd.txt_doctor.Text = dr[8].ToString();
                        fd.txt_branch.Text = dr[9].ToString();
                        fd.txt_techincal.Text = dr[10].ToString();
                        fd.txt_stock.Text = dr[11].ToString();
                        fd.txt_total.Text = dr[12].ToString();
                        fd.txt_pay.Text = dr[13].ToString();
                        fd.txt_rent.Text = dr[14].ToString();
                        fd.txt_statues.Text = dr[15].ToString();
                        fd.txt_username.Text = dr[16].ToString();
                        fd.txt_compint.Text = dr[17].ToString();
                        fd.txt_timeKa4f.Text = dr[18].ToString();
                        fd.txt_discount.Text = dr[19].ToString();
                        fd.txt_place.Text = dr[20].ToString();
                        fd.txt_afterDiscount.Text = dr[21].ToString();
                        fd.txt_reasonAddition.Text = dr[22].ToString();
                        fd.txt_idnationa.Text = dr[23].ToString();
                        fd.txt_idtickets.Text = dr[0].ToString();
                        fd.txt_idstock.Text = dr[24].ToString();
                        fd.txt_idbranche.Text = dr[25].ToString();
                    }
                }
                else
                {
                    fd.txt_company.Show();
                    fd.label21.Show();
                    fd.Txt_PricePayment.Show();
                    fd.Txt_addtionPayment.Show();
                    fd.txt_afterDiscount.Hide();
                    fd.txt_discount.Hide();
                    fd.label9.Hide();
                    fd.label24.Hide();
                    fd.label26.Show();
                    fd.label27.Show();
                    fd.txt_idcompany.Show();
                    dt.Clear();
                    dt = t.TicketDetailsSelectTicketsCompany(Convert.ToInt32(dgv_visit.CurrentRow.Cells[0].Value));

                    foreach (DataRow dr in dt.Rows)
                    {
                        fd.txt_name.Text = dr[1].ToString();
                        fd.txt_phone.Text = dr[2].ToString();
                        fd.txt_address.Text = dr[3].ToString();
                        fd.txt_age.Text = dr[4].ToString();
                        fd.txt_dateVisit.Text = dr[5].ToString();
                        fd.txt_dateRecive.Text = dr[6].ToString();
                        fd.txt_doctorOfCenter.Text = dr[7].ToString();
                        fd.txt_doctor.Text = dr[8].ToString();
                        fd.txt_branch.Text = dr[9].ToString();
                        fd.txt_techincal.Text = dr[10].ToString();
                        fd.txt_stock.Text = dr[11].ToString();
                        fd.txt_total.Text = dr[12].ToString();
                        fd.txt_pay.Text = dr[13].ToString();
                        fd.txt_rent.Text = dr[14].ToString();
                        fd.txt_statues.Text = dr[15].ToString();
                        fd.txt_username.Text = dr[16].ToString();
                        fd.txt_company.Text = dr[17].ToString();
                        fd.txt_compint.Text = dr[18].ToString();
                        fd.txt_timeKa4f.Text = dr[19].ToString();

                        fd.txt_place.Text = dr[20].ToString();
                        fd.txt_afterDiscount.Text = dr[21].ToString();
                        fd.txt_reasonAddition.Text = dr[22].ToString();
                        fd.Txt_PricePayment.Text = dr[23].ToString();
                        fd.Txt_addtionPayment.Text = dr[24].ToString();
                        fd.txt_idnationa.Text = dr[25].ToString();
                        fd.txt_idtickets.Text = dr[0].ToString();
                        fd.txt_idstock.Text = dr[26].ToString();
                        fd.txt_idbranche.Text = dr[27].ToString();
                        fd.txt_idcompany.Text = dr[28].ToString();

                    }

                }
                DataTable dt1 = new DataTable();
                dt1 = t.TicketDetailsSelectTicketsDetAILS(Convert.ToInt32(dgv_visit.CurrentRow.Cells[0].Value));
                fd.dgv_order.DataSource = dt1;



                fd.ShowDialog();

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
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
                dgv_visit.DataSource = t.SelectSearchticketsDate(FromDate.Value, ToDate.Value);

            }

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox1.Text == "ألاسم او رقم الحجز")
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
            else if (comboBox1.Text == "بالتاريخ")
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

        private void button3_Click(object sender, EventArgs e)
        {
            Frm_Payouts pa = new Frm_Payouts();
            DataTable dt = new DataTable();

            DataTable dt10 = new DataTable();
            DataTable dt5 = new DataTable();
            Tickets t = new Tickets();
            Frm_DetailsTickets fd = new Frm_DetailsTickets();
            if (dgv_visit.Rows.Count > 0)
            {


                dt5.Clear();
                dt5 = t.TicketDetailsSelectTickets(Convert.ToInt32(dgv_visit.CurrentRow.Cells[0].Value));

                foreach (DataRow dr in dt5.Rows)
                {
                    pa.txt_name.Text = dr[1].ToString();

                    pa.txt_date.Text = dr[5].ToString();


                    pa.txt_total.Text = dr[12].ToString();
                    pa.txt_pay.Text = dr[13].ToString();
                    pa.txt_rent.Text = dr[14].ToString();
                    pa.txt_statues.Text = dr[15].ToString();

                    pa.textBox1.Text = dr[20].ToString();

                    pa.txt_num.Text = dr[0].ToString();


                }
                DataTable dt1 = new DataTable();
                dt1.Clear();
                dt1 = t.TicketDetailsSelectTicketsDetAILS(Convert.ToInt32(dgv_visit.CurrentRow.Cells[0].Value));
                pa.dataGridView1.DataSource = dt1;



                pa.ShowDialog();



            }
        }
    }
}
