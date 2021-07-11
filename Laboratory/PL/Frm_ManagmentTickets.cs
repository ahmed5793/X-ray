using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.XtraGrid.Views.Grid;
using Laboratory.BL;
using Laboratory.RPT;
using Laboratory.RPT_Order;
using DevExpress.XtraReports.UI;

namespace Laboratory.PL
{
    public partial class Frm_ManagmentTickets : Form
    {
        Users u = new Users();
        Branches b = new Branches();
        Tickets t = new Tickets();
        Frm_Payouts pa = new Frm_Payouts();
        DataTable dt10 = new DataTable();
        DataTable dt5 = new DataTable();
        DataTable dt7 = new DataTable();
        DataTable dt1 = new DataTable();

        public Frm_ManagmentTickets()
        {
            InitializeComponent();
            txt_username.Text = Program.salesman;
            Permision();
            

        }

        private void dgv_visit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void Permision()
        {
            try
            {
                //dt10.Clear();
                //dt10 = u.SelectUserBranch(txt_username.Text);

                //if (dt10.Rows.Count > 0)
                //{
                //    cmb_branches.DataSource = u.SelectUserBranch(txt_username.Text);
                //    cmb_branches.DisplayMember = "Name";
                //    cmb_branches.ValueMember = "Branch_ID";
                //}
                //else
                //{
                    cmb_branches.DataSource = b.SelectCompBranches();
                    cmb_branches.DisplayMember = "Name";
                    cmb_branches.ValueMember = "Branch_ID";
              //  }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label2.Hide();
            label3.Hide();
            FromDate.Hide();
            ToDate.Hide();
        }


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdb_all.Checked==true)
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
                else if(rdb_company.Checked==true)
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
                        if (Convert.ToDecimal(gridView1.GetFocusedRowCellValue("المدفوع"))==0)
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

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_DetailsTickets fd = new Frm_DetailsTickets();
                if (gridView1.RowCount > 0)
                {
                    dt10.Clear();
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
                        dt10.Clear();
                        dt10 = t.TicketDetailsSelectTicketsCompany(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة")));

                        foreach (DataRow dr in dt10.Rows)
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
                    dt1.Clear();
                    dt1 = t.TicketDetailsSelectTicketsDetAILS(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة")));
                    fd.dgv_order.DataSource = dt1;
                    fd.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        frm_SingelReport sr = new frm_SingelReport();
        private void btn_print_Click(object sender, EventArgs e)
        {
            try
            {
             
                if (gridView1.RowCount > 0)
                {
                    if (gridView1.GetFocusedRowCellValue("طريقه التعامل").ToString() == "نقدى")
                    {
                        DataTable dt2 = new DataTable();
                        Rpt_OrderPay report = new Rpt_OrderPay();
                        RPT.Order.DataSetOrderPay dso = new RPT.Order.DataSetOrderPay();
                      
                        sr.documentViewer1.Refresh();
                        dt2.Clear();
                        dt2 = t.ReportInvoiceTicketPay(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة").ToString()));
                        dso.Tables["DataTable1"].Clear();
                        for (int i = 0; i < dt2.Rows.Count; i++)
                        {
                            dso.Tables["DataTable1"].Rows.Add(dt2.Rows[0][0], dt2.Rows[0][1], dt2.Rows[0][2],
                              dt2.Rows[0][3], dt2.Rows[0][4], dt2.Rows[0][5], dt2.Rows[0][6], dt2.Rows[0][7],
                                dt2.Rows[0][8], dt2.Rows[0][9], dt2.Rows[0][10], dt2.Rows[0][11], dt2.Rows[0][12], dt2.Rows[0][13],
                                dt2.Rows[0][14], dt2.Rows[0][15], dt2.Rows[0][16],
                                dt2.Rows[0][17], dt2.Rows[0][18], dt2.Rows[0][19], dt2.Rows[0][20],dt2.Rows[0][21],
                                dt2.Rows[0][22], dt2.Rows[0][23], dt2.Rows[0][24], dt2.Rows[0][25], dt2.Rows[0][26],
                                dt2.Rows[0][27], dt2.Rows[0][28]);
                        }
                        sr.documentViewer1.Refresh();
                        report.DataSource = dso;
                        report.Parameters["idTicket"].Value = Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة").ToString());
                        sr.documentViewer1.DocumentSource = report;
                        report.Parameters["idTicket"].Visible = false;
                        sr.documentViewer1.Enabled = true;
                        sr.ShowDialog();
                    }
                    else if (gridView1.GetFocusedRowCellValue("طريقه التعامل").ToString() == "شركات")
                    {
                        DataTable dt1 = new DataTable();
                 
                     
                        sr.documentViewer1.Refresh();

                        dt1.Clear();
                        dt1 = t.ReportInvoiceTicketCompany(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة").ToString()));
                        RPT.Order.Rpt_TeckietCompanyOrder oc = new RPT.Order.Rpt_TeckietCompanyOrder();
                        RPT.Order.DataSetOrderCompany dso = new RPT.Order.DataSetOrderCompany();
                        dso.Tables["dataCompany"].Clear();
                        for (int i = 0; i < dt1.Rows.Count; i++)
                        {

                            dso.Tables["dataCompany"].Rows.Add(dt1.Rows[i][0], dt1.Rows[i][1], dt1.Rows[i][2],
                           dt1.Rows[i][3], dt1.Rows[i][4], dt1.Rows[i][5], dt1.Rows[i][6], dt1.Rows[i][7],
                           dt1.Rows[i][8], dt1.Rows[i][9], dt1.Rows[i][10], dt1.Rows[i][11], dt1.Rows[i][12], dt1.Rows[i][13],
                           dt1.Rows[i][14], dt1.Rows[i][15], dt1.Rows[i][16],
                           dt1.Rows[i][17], dt1.Rows[i][18], dt1.Rows[i][19], dt1.Rows[i][20], dt1.Rows[i][21], dt1.Rows[i][22],
                           dt1.Rows[i][23], dt1.Rows[i][24], dt1.Rows[i][25], dt1.Rows[i][26],
                           dt1.Rows[i][27], dt1.Rows[i][28], dt1.Rows[i][29],
                           dt1.Rows[i][30], dt1.Rows[i][31], dt1.Rows[i][32]);
                        }
                        sr.documentViewer1.Refresh();
                        oc.DataSource = dso;
                        oc.Parameters["idTicket"].Value = Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة").ToString());
                        sr.documentViewer1.DocumentSource = oc;
                        oc.Parameters["idTicket"].Visible = false;
                        sr.documentViewer1.Enabled = true;

                        
                     
                      
                      
                        sr.ShowDialog();

                    }


                   

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridView1.RowCount > 0)
                {
                    DataSet1 ds1 = new DataSet1();
                    //            DataTable dt = new DataTable();
                    //            dt.Clear();
                    //            dt = t.PrintBarcode(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة").ToString()));
                    //            RPT.RPT_Barcode rb = new RPT.RPT_Barcode();
                    //            sr.documentViewer1.Refresh();

                    //            ds1.Tables["DataTable1"].Clear();
                    //            for (int i = 0; i < dt.Rows.Count; i++)
                    //            {
                    //                ds1.Tables["DataTable1"].Rows.Add(Convert.ToInt32(dt.Rows[i][0]), dt.Rows[i][1], dt.Rows[i][2],
                    //                    dt.Rows[i][3], Convert.ToDateTime(dt.Rows[i][4]));
                    //            }
                    //            rb.DataSource = ds1;
                    //            rb.Parameters["idTicket"].Value = Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة").ToString());

                    //            sr.documentViewer1.DocumentSource = rb;
                    //            rb.Parameters["idTicket"].Visible = false;



                    //string printerName = Properties.Settings.Default.PrintNameBarcode;




                    //    //Specify the printer name.
                    //    rb.PrinterName = printerName;

                    //    //Create the document.
                    //    rb.CreateDocument();

                    //    ReportPrintTool pt = new ReportPrintTool(rb);
                    //    pt.Print();


                 
                 RPT.Order.CrystalReport2 cr = new RPT.Order.CrystalReport2();
                  
                    DataTable dt = new DataTable();
                               dt.Clear();
                               dt = t.PrintBarcode(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة").ToString()));
                          
                                sr.documentViewer1.Refresh();

                              ds1.Tables["DataTable1"].Clear();
                    ds1.Tables["DataTable1"].Clear();
                              for (int i = 0; i < dt.Rows.Count; i++)
                                {
                                   ds1.Tables["DataTable1"].Rows.Add(Convert.ToInt32(dt.Rows[i][0]), dt.Rows[i][1], dt.Rows[i][2],
                                        dt.Rows[i][3], Convert.ToDateTime(dt.Rows[i][4]));
                            }
                    cr.SetDataSource(ds1);
                 
                    sr.documentViewer1.DocumentSource = cr;
                    sr.documentViewer1.Refresh();
                    System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                    cr.PrintOptions.PrinterName = Properties.Settings.Default.PrintNameBarcode;
                    cr.PrintToPrinter(1, true, 0, 0);

                    sr.Close();
                    cr.Dispose();



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridView1.RowCount > 0)
                {
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

                    if (gridView1.GetFocusedRowCellValue("طريقه التعامل").ToString() == "شركات")
                    {
                        MessageBox.Show("لا يصلح تحويل الفحص من شركة إلى شركة اخرى يرجى إرتجاع المبلغ بالكامل لهذا الفحص ثم عمل حجز جديد للشركة الجديدة");
                        return;
                    }
                    dt10.Clear();
                    dt10 = t.vildateTransferForCompany(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة").ToString()));
                    if (dt10.Rows.Count > 0)
                    {
                        MessageBox.Show("تم تحويل هذا الفحص من قبل ");
                        return;
                    }

                    Frm_TransferToCompany tc = new Frm_TransferToCompany();
                    dt1.Clear();
                    dt1 = t.TicketDetailsSelectTicketsDetAILS(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة")));

                    tc.dataGridView1.DataSource = dt1;

                    tc.dataGridView1.Columns[0].Visible = false;
                    tc.dataGridView1.Columns[3].Visible = false;

                    dt10.Clear();
                    dt10 = t.TicketDetailsSelectTickets(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة")));
                    dt5.Clear();
                    dt5 = t.SelectMoneyPayCustomer(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة")));
                    foreach (DataRow dr in dt10.Rows)
                    {
                        tc.txt_IdTeckit.Text = dr[0].ToString();
                        if (dt5.Rows.Count>0)
                        {
                            int x = Convert.ToInt32(dr[13]) + Convert.ToInt32(dt5.Rows[0][1]);
                            pa.txt_pay.Text = x.ToString();
                        }
                        else
                        {
                            tc.Txt_PayLast.Text = dr[13].ToString();

                        }
                        tc.txt_patientname.Text = dr[1].ToString();
                        tc.Txt_IdCust.Text = dr[26].ToString();
                        tc.Txt_TotalBeforeTransfair.Text = dr[21].ToString();
                        tc.Txt_OldRentBeforeTransfair.Text = dr[14].ToString();
                        tc.Txt_OldBranch.Text = gridView1.GetFocusedRowCellValue("فرع").ToString();

                    }
                    dt5.Clear();
                    dt5 = t.vildateReturnTickets(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة")));
                    foreach (DataRow item in dt5.Rows)
                    {
                        tc.Txt_LastPayOut.Text = item[1].ToString();
                    }
                    tc.ShowDialog();
                    //this.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void Frm_ManagmentTickets_Load(object sender, EventArgs e)
        {
            txt_username.Hide();
            simpleButton2.Hide();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_EditTeckit fd = new Frm_EditTeckit();
                if (gridView1.RowCount > 0)
                {
                    dt10.Clear();
                    dt10 = t.vildateTicketCompany(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة")));
                    if (dt10.Rows.Count > 0)
                    {
                        
                        dt5.Clear();
                        dt5 = t.TicketDetailsSelectTickets(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة")));
                        foreach (DataRow dr in dt5.Rows)
                        {
                            fd.txt_name.Text = dr[1].ToString();
                           
                            fd.txt_dateRecive.Text = dr[6].ToString();
                            fd.txt_doctorOfCenter.Text = dr[7].ToString();
                            fd.txt_branch.Text = dr[9].ToString();
                            fd.txt_techincal.Text = dr[10].ToString();
                            fd.txt_timeKa4f.Text = dr[18].ToString();
                            fd.txt_idtickets.Text = dr[0].ToString();
                            fd.Txt_OldNotes.Text = dr[22].ToString();
                            fd.txt_idCust.Text = dr[26].ToString();
                            fd.txt_visiteDate.Text = dr[5].ToString();
                            fd.txt_IdStock.Text = dr[24].ToString();

                            //--------------------------------------------البيانات الجديدة------------------------------------------

                            fd.dtp_recive.Text = dr[6].ToString();
                            fd.cmb_DoctorOfCenter.Text = dr[7].ToString();
                            fd.cmb_branches.Text = dr[9].ToString();
                            fd.cmb_Techincal.Text = dr[10].ToString();
                            fd.dtb_kashf.Text = dr[18].ToString();
                        
                            fd.Txt_NewNotes.Text = dr[22].ToString();
                         
                            fd.dtb_Visite.Text = dr[5].ToString();
                           
                        }
                    }
                    else
                    {
                        
                        dt10.Clear();
                        dt10 = t.TicketDetailsSelectTicketsCompany(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة")));

                        foreach (DataRow dr in dt10.Rows)
                        {
                            fd.txt_name.Text = dr[1].ToString();
                         
                            fd.txt_dateRecive.Text = dr[6].ToString();
                            fd.txt_doctorOfCenter.Text = dr[7].ToString();
                            fd.txt_branch.Text = dr[9].ToString();
                            fd.txt_techincal.Text = dr[10].ToString();                            
                            fd.txt_timeKa4f.Text = dr[19].ToString();
                            fd.Txt_OldNotes.Text = dr[22].ToString();
                            fd.txt_idCust.Text = dr[29].ToString();
                            fd.txt_visiteDate.Text = dr[5].ToString();
                            fd.txt_IdStock.Text = dr[26].ToString();

                            //--------------------------------------------البيانات الجديدة------------------------------------------
                            

                            fd.dtp_recive.Text = dr[6].ToString();
                            fd.cmb_DoctorOfCenter.Text = dr[7].ToString();
                            fd.cmb_branches.Text = dr[9].ToString();
                            fd.cmb_Techincal.Text = dr[10].ToString();
                            fd.dtb_kashf.Text = dr[19].ToString();
                            fd.Txt_NewNotes.Text = dr[22].ToString();
                        
                            fd.dtb_Visite.Text = dr[5].ToString();
                          


                        }
                    }
                    fd.ShowDialog();
                 //   gridControl1.DataSource = t.SelectSearchticketsBranchDate(Convert.ToInt32(cmb_branches.SelectedValue), FromDate.Value, ToDate.Value);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rdb_company_CheckedChanged(object sender, EventArgs e)
        {

            if (rdb_company.Checked == true)
            {
                gridControl1.DataSource = null;
                gridView1.Columns.Clear();
                radio_Branch.Checked = true;
                gridControl1.DataSource = t.SelectSearchticketsBranchCompany(cmb_branches.Text, FromDate.Value, ToDate.Value);
            }



        }

        private void rdb_pay_CheckedChanged(object sender, EventArgs e)
        {
              if (rdb_pay.Checked == true)
            {
                gridControl1.DataSource = null;
                gridView1.Columns.Clear();
                radio_Branch.Checked = true;
                gridControl1.DataSource = t.SelectSearchticketsBranchPay(cmb_branches.Text, FromDate.Value, ToDate.Value);

            }


            }

            private void rdb_all_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_all.Checked == true)
            {
                gridControl1.DataSource = null;
                gridView1.Columns.Clear();
                radio_Branch.Checked = true;
                gridControl1.DataSource = t.SelectSearchticketsBranch(cmb_branches.Text, FromDate.Value, ToDate.Value);




            }
        }

        private void radio_placeTicket_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton5_Click_1(object sender, EventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }
    }
}
