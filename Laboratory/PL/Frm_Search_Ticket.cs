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
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting.Drawing;
using Laboratory.RPT_Order;
using DevExpress.XtraReports.Design;
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.Utils.OAuth;

namespace Laboratory.PL
{
    public partial class Frm_Search_Ticket : Form
    {

        Suppliers s = new Suppliers();
        Tickets t = new Tickets();
        CategoryXRaya c = new CategoryXRaya();
        Users u = new Users();
        Branches b = new Branches();
        DataTable dt = new DataTable();
        void brnches()
        {
            cmb_branches.DataSource = b.SelectCompBranches();
            cmb_branches.DisplayMember = "Name";
            cmb_branches.ValueMember = "Branch_ID";
        }
        public Frm_Search_Ticket()
        {
            InitializeComponent();
            txt_search.Hide();
            FromDate.Hide();
            ToDate.Hide();
            button2.Hide();
            //cmb_branches.DataSource = null;
            //cmb_branches.Enabled = false;
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            textBox1.Hide();
            Cmb_CategoryItem.Hide();
            cmb_branches.Hide();
            Cmb_CategoryItem.DataSource = c.selectCategoryXRaya();
            Cmb_CategoryItem.DisplayMember = "الفئات";
            Cmb_CategoryItem.ValueMember = "ID_CtegoryXrays";
            FromDate.Value = DateTime.Now;
            ToDate.Value = DateTime.Now;
        }
        private void Frm_Search_Ticket_Load(object sender, EventArgs e)
        {

        }
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            dt.Clear();
            dt = t.SearchManagmentTicketsBranch(txt_search.Text);
            gridControl1.DataSource = dt;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataTable dt10 = new DataTable();
            DataTable dt5 = new DataTable();
            Tickets t = new Tickets();
            Frm_DetailsTickets fd = new Frm_DetailsTickets();
            if (gridView1.RowCount > 0)
            {
                dt10 = t.vildateTicketCompany(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة")));
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
                    dt5 = t.TicketDetailsSelectTickets(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة")));
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
                    dt = t.TicketDetailsSelectTicketsCompany(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة")));

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
                dt1 = t.TicketDetailsSelectTicketsDetAILS(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة")));
                fd.dgv_order.DataSource = dt1;
                fd.ShowDialog();
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //dgv_visit.DataSource = t.SelectSearchticketsDate(FromDate.Value, ToDate.Value);


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
                label4.Hide();
                label5.Hide();
                textBox1.Hide();
                Cmb_CategoryItem.Hide();
                cmb_branches.Hide();
                gridControl1.DataSource = t.SelecthManagmentTicketsBranch();
                textBox1.Text = gridView1.RowCount.ToString();


            }
            else if (comboBox1.Text == "بحث بالتاريخ + مكان الفحص")
            {
                brnches();
                txt_search.Clear();
                //dgv_visit.DataSource = null;
                label2.Show();
                label3.Show();
                txt_search.Hide();
                FromDate.Show();
                ToDate.Show();
                button2.Show();
                label4.Hide();
                label5.Show();
                textBox1.Show();
                Cmb_CategoryItem.Hide();
                cmb_branches.Show();

            }
            else if (comboBox1.Text == "بحث بالتاريخ + مكان الفحص+نوع الفحص")
            {
                brnches();
                Cmb_CategoryItem.DataSource = c.selectCategoryXRaya();
                Cmb_CategoryItem.DisplayMember = "الفئات";
                Cmb_CategoryItem.ValueMember = "ID_CtegoryXrays";

                txt_search.Clear();
                //dgv_visit.DataSource = null;
                label2.Show();
                label3.Show();
                txt_search.Hide();
                FromDate.Show();
                ToDate.Show();
                button2.Show();
                label4.Show();
                label5.Show();
                textBox1.Show();
                Cmb_CategoryItem.Show();
                cmb_branches.Show();
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
            if (gridView1.RowCount> 0)
            {
                dt5.Clear();
                dt5 = t.vildateReturnTickets(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة")));
                dt10.Clear();
                dt10 = t.vildateTransferForCompany(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة")));

                if (dt5.Rows.Count > 0)
                {
                    if (Convert.ToDecimal(gridView1.GetFocusedRowCellValue("المدفوع")) == Convert.ToDecimal(dt5.Rows[0][1]))
                    {
                          MessageBox.Show("عزيزى المستخدم يرجي العلم باان تم استرداد مبلغ الفاتورة من قبل لايمكن استرداها مرة اخرى   ", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        return;
                    }
                }
                else if(dt10.Rows.Count>0)
                {
                    MessageBox.Show("عزيزى المستخدم يرجي العلم باان تم تحويل الفاتورة الي جةة اخري واسترداد المبلغ   ", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    return;
                }
                dt5.Clear();
                dt5 = t.TicketDetailsSelectTickets(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة")));

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
                    pa.Txt_IdCust.Text = dr[26].ToString();
                }
                DataTable dt1 = new DataTable();
                dt1.Clear();
                dt1 = t.TicketDetailsSelectTicketsDetAILS(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة")));
                pa.dataGridView1.DataSource = dt1;

                pa.dataGridView1.Columns[0].Visible = false;
                pa.dataGridView1.Columns[2].Visible = false;

                pa.ShowDialog();



            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                frm_SingelReport s = new frm_SingelReport();
                if (gridView1.GetFocusedRowCellValue("طريقه التعامل").ToString()== "نقدى")
                {
                   
                    Rpt_OrderPay report = new Rpt_OrderPay();

                    s.documentViewer1.Refresh();

                    DataTable dt5 = new DataTable();
                    dt5.Clear();
                    dt5 = t.ReportInvoiceTicketPay(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة")));
                    report.Parameters["idTicket"].Value = Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة"));
                    report.DataSource = dt5;

                    s.documentViewer1.DocumentSource = report;
                    report.Parameters["idTicket"].Visible = false;
                    s.ShowDialog();
                   


                }
              else  if (gridView1.GetFocusedRowCellValue("طريقه التعامل").ToString() == "شركات")
                {
                    Rpt_OrderCompany oc = new Rpt_OrderCompany();

                    s.documentViewer1.Refresh();

                    oc.DataSource = t.ReportInvoiceTicketCompany(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة")));

                    oc.Parameters["idTicket"].Value = Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة"));
                
                   

                    s.documentViewer1.DocumentSource = oc;
                    oc.Parameters["idTicket"].Visible = false;
                    s.ShowDialog();


                }


                // ReportPrintTool tool = new ReportPrintTool(report);
                //tool.ShowRibbonPreview();
                //  report.RequestParameters = false;
                //XtraReport1 x = new XtraReport1();
                //s.documentViewer1.Refresh();
                //    x.Parameters["@idTicket"].Value = Convert.ToInt32(dgv_visit.CurrentRow.Cells[0].Value);
                //x.DataSource = t.ReportInvoiceTicketPay(Convert.ToInt32(dgv_visit.CurrentRow.Cells[0].Value));
                //s.documentViewer1.DocumentSource = x;
                //x.Parameters["@idTicket"].Visible = false;
                //  x.RequestParameters = false;
                //s.ShowDialog();



            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Cmb_CategoryItem_Leave(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Clear();
            dt = c.Validate_CategoryXray(Convert.ToInt32(Cmb_CategoryItem.SelectedValue));
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("عزيزيى المستخدم يرجي العلم بان اسم الجهاز غير مسجل ");
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text == "بحث بالتاريخ + مكان الفحص")
            {
                gridControl1.DataSource = t.SelectSearchticketsBranchDate(Convert.ToInt32(cmb_branches.SelectedValue), FromDate.Value, ToDate.Value);
                textBox1.Text = gridView1.RowCount.ToString();
            }
            else if (comboBox1.Text == "بحث بالتاريخ + مكان الفحص+نوع الفحص")
            {
                gridControl1.DataSource = t.SelectSearchticketsBranchDateandCategory(Convert.ToInt32(cmb_branches.SelectedValue), Convert.ToInt32(Cmb_CategoryItem.SelectedValue), FromDate.Value, ToDate.Value);
                textBox1.Text = gridView1.RowCount.ToString();

            }
        }
    }
}
