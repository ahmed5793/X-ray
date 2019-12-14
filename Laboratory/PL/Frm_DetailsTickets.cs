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
    public partial class Frm_DetailsTickets : Form
    {
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        DataTable dt10 = new DataTable();
        Tickets t = new Tickets();
        
        public Frm_DetailsTickets()
        {
            InitializeComponent();
            dt10=t.vildateTicketCompany(Convert.ToInt32(Frm_Search_Ticket.getmain.dgv_visit.CurrentRow.Cells[0].Value));
            if (dt10.Rows.Count > 0)
            {

                txt_company.Hide();
                label21.Hide();
                dt = t.TicketDetailsSelectTickets(Convert.ToInt32(Frm_Search_Ticket.getmain.dgv_visit.CurrentRow.Cells[0].Value));

                foreach (DataRow dr in dt.Rows)
                {
                    txt_name.Text = dr[1].ToString();
                    txt_phone.Text = dr[2].ToString();
                    txt_address.Text = dr[3].ToString();
                    txt_age.Text = dr[4].ToString();
                    txt_dateVisit.Text = dr[5].ToString();
                    txt_dateRecive.Text = dr[6].ToString();
                    txt_doctorOfCenter.Text = dr[7].ToString();
                    txt_doctor.Text = dr[8].ToString();
                    txt_branch.Text = dr[9].ToString();
                    txt_techincal.Text = dr[10].ToString();
                    txt_stock.Text = dr[11].ToString();
                    txt_total.Text = dr[12].ToString();
                    txt_pay.Text = dr[13].ToString();
                    txt_rent.Text = dr[14].ToString();
                    txt_statues.Text = dr[15].ToString();
                    txt_username.Text = dr[16].ToString();
                    txt_compint.Text = dr[17].ToString();
                    txt_timeKa4f.Text = dr[18].ToString();
                    txt_discount.Text = dr[19].ToString();

                }
            }
            else
            {
                txt_company.Show();
                label21.Show();
                dt = t.TicketDetailsSelectTicketsCompany(Convert.ToInt32(Frm_Search_Ticket.getmain.dgv_visit.CurrentRow.Cells[0].Value));

                foreach (DataRow dr in dt.Rows)
                {
                    txt_name.Text = dr[1].ToString();
                    txt_phone.Text = dr[2].ToString();
                    txt_address.Text = dr[3].ToString();
                    txt_age.Text = dr[4].ToString();
                    txt_dateVisit.Text = dr[5].ToString();
                    txt_dateRecive.Text = dr[6].ToString();
                    txt_doctorOfCenter.Text = dr[7].ToString();
                    txt_doctor.Text = dr[8].ToString();
                    txt_branch.Text = dr[9].ToString();
                    txt_techincal.Text = dr[10].ToString();
                    txt_stock.Text = dr[11].ToString();
                    txt_total.Text = dr[12].ToString();
                    txt_pay.Text = dr[13].ToString();
                    txt_rent.Text = dr[14].ToString();
                    txt_statues.Text = dr[15].ToString();
                    txt_username.Text = dr[16].ToString();
                    txt_company.Text = dr[17].ToString();
                    txt_compint.Text = dr[18].ToString();
                    txt_timeKa4f.Text = dr[19].ToString();
                    txt_discount.Text = dr[20].ToString();

                }

            }
            dt1 = t.TicketDetailsSelectTicketsDetAILS(Convert.ToInt32(Frm_Search_Ticket.getmain.dgv_visit.CurrentRow.Cells[0].Value));
            dgv_order.DataSource = dt1;
        }

        private void Frm_DetailsTickets_Load(object sender, EventArgs e)
        {

        }
    }
}
