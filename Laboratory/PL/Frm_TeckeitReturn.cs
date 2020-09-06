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
    public partial class Frm_TeckeitReturn : Form
    {
        Branches b = new Branches();
        Tickets t = new Tickets();
        Frm_Payouts pa = new Frm_Payouts();
        DataTable dt10 = new DataTable();
        DataTable dt5 = new DataTable();
        DataTable dt7 = new DataTable();
        DataTable dt1 = new DataTable();
        public Frm_TeckeitReturn()
        {
            InitializeComponent();
            Permision();
        }

        void Permision()
        {
            try
            {

                cmb_branches.DataSource = b.SelectCompBranches();
                cmb_branches.DisplayMember = "Name";
                cmb_branches.ValueMember = "Branch_ID";
               

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdb_all.Checked == true)
                {




                    if (radio_placeTicket.Checked == true)
                    {
                        gridControl1.DataSource = t.SelectSearchticketsBranchDate(Convert.ToInt32(cmb_branches.SelectedValue), FromDate.Value, ToDate.Value);

                    }
                    else if (radio_Branch.Checked == true)
                    {
                        gridControl1.DataSource = t.SelectSearchticketsBranch(cmb_branches.Text, FromDate.Value, ToDate.Value);

                    }
                }
                else if (rdb_company.Checked == true)
                {


                    if (radio_placeTicket.Checked == true)
                    {
                        gridControl1.DataSource = t.SelectSearchticketsBranchDateCompany(Convert.ToInt32(cmb_branches.SelectedValue), FromDate.Value, ToDate.Value);

                    }
                    else if (radio_Branch.Checked == true)
                    {
                        gridControl1.DataSource = t.SelectSearchticketsBranchCompany(cmb_branches.Text, FromDate.Value, ToDate.Value);

                    }

                }

                else if (rdb_pay.Checked == true)
                {

                    if (radio_placeTicket.Checked == true)
                    {
                        gridControl1.DataSource = t.SelectSearchticketsBranchDatePay(Convert.ToInt32(cmb_branches.SelectedValue), FromDate.Value, ToDate.Value);

                    }
                    else if (radio_Branch.Checked == true)
                    {
                        gridControl1.DataSource = t.SelectSearchticketsBranchPay(cmb_branches.Text, FromDate.Value, ToDate.Value);

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                //Frm_DetailsTickets fd = new Frm_DetailsTickets();
                if (gridView1.RowCount > 0)
                {
                    //if (gridView1.GetFocusedRowCellValue("طريقه التعامل").ToString() == "نقدى" )
                    //{
                    if (Convert.ToDecimal(gridView1.GetFocusedRowCellValue("المدفوع")) == 0)
                    {
                        MessageBox.Show("لا يوجد مردود لهذاالفحص لا يوجد مبلغ مدفوع مسبقا");
                        return;
                    }

                    //}
                    dt5.Clear();
                    dt5 = t.vildateReturnTickets(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة")));
                    if (dt5.Rows.Count > 0)
                    {
                        if (Convert.ToDecimal(gridView1.GetFocusedRowCellValue("المدفوع")) == Convert.ToDecimal(dt5.Rows[0][1]))
                        {
                            MessageBox.Show("عزيزى المستخدم يرجي العلم باان تم استرداد مبلغ الفاتورة من قبل لايمكن استرداها مرة اخرى   ", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    dt10.Clear();
                    dt10 = t.vildateTransferForCompany(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة")));
                    if (dt10.Rows.Count > 0)
                    {
                        MessageBox.Show("عزيزى المستخدم يرجي العلم باان تم تحويل الفاتورة الي جهه اخري  ", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        return;
                    }
                    dt7.Clear();
                    dt7 = t.TicketDetailsSelectTickets(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة")));
                    foreach (DataRow dr in dt7.Rows)
                    {
                        pa.txt_name.Text = dr[1].ToString();
                        pa.txt_date.Text = dr[5].ToString();
                        pa.txt_total.Text = dr[12].ToString();
                        pa.txt_pay.Text = dr[13].ToString();
                        pa.txt_rent.Text = dr[14].ToString();
                        pa.txt_statues.Text = dr[15].ToString();
                        pa.textBox1.Text = dr[9].ToString();
                        pa.txt_num.Text = dr[0].ToString();
                        pa.Txt_IdCust.Text = dr[26].ToString();
                        pa.Txt_OldBranch.Text = gridView1.GetFocusedRowCellValue("فرع").ToString();

                    }
                    dt10.Clear();
                    dt10 = t.Select_IdCompanyAndRentFromTicket(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة")));
                    if (gridView1.GetFocusedRowCellValue("طريقه التعامل").ToString() == "شركات")
                    {
                        foreach (DataRow dr in dt10.Rows)
                        {
                            pa.Txt_IdCompany.Text = dr[0].ToString();
                            pa.Txt_RentCompany.Text = dr[2].ToString();
                            pa.Txt_PriceCustomerPayment.Text = dr[3].ToString();
                        }
                    }
                    dt5.Clear();
                    dt5 = t.vildateReturnTickets(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة")));
                    foreach (DataRow item in dt5.Rows)
                    {
                        pa.Txt_ReturnMoney.Text = item[1].ToString();
                    }
                    dt1.Clear();
                    dt1 = t.TicketDetailsSelectTicketsDetAILS(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة")));
                    pa.dataGridView1.DataSource = dt1;
                    pa.dataGridView1.Columns[0].Visible = false;
                    pa.dataGridView1.Columns[3].Visible = false;

                    pa.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
