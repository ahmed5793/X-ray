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

   
        Tickets t = new Tickets();
        CategoryXRaya c = new CategoryXRaya();



     
        public Frm_Search_Ticket()
        {
            InitializeComponent();
          
            FromDate.Hide();
            ToDate.Hide();
            button2.Hide();
            //cmb_branches.DataSource = null;
            //cmb_branches.Enabled = false;
            label2.Hide();
            label3.Hide();
            label13.Hide();
            label4.Hide();
            label5.Hide();
            textBox1.Hide();
            Cmb_CategoryItem.Hide();
            cmb_branches.Hide();
    
        }
        void brnches()
        {
            Branches b = new Branches();
            cmb_branches.DataSource = b.SelectCompBranches();
            cmb_branches.DisplayMember = "Name";
            cmb_branches.ValueMember = "Branch_ID";
        }
        private void Frm_Search_Ticket_Load(object sender, EventArgs e)
        {
            Cmb_CategoryItem.DataSource = c.selectCategoryXRaya();
            Cmb_CategoryItem.DisplayMember = "الفئات";
            Cmb_CategoryItem.ValueMember = "ID_CtegoryXrays";
            FromDate.Value = DateTime.Now;
            ToDate.Value = DateTime.Now;
        }
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            //dt.Clear();
            //dt = t.SearchManagmentTicketsBranch(txt_search.Text);
            //gridControl1.DataSource = dt;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
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
            if (comboBox1.Text == "كل الحجوزات")
            {
                label2.Hide();
                label3.Hide();
                label13.Hide();
                FromDate.Hide();
                ToDate.Hide();
                button2.Hide();
                label4.Hide();
                label5.Hide();
                textBox1.Hide();
                Cmb_CategoryItem.Hide();
                cmb_branches.Hide();
                gridControl1.DataSource = t.SelecthManagmentTicketsBranch();
                sum();



            }
            else if (comboBox1.Text == "بحث بالتاريخ + مكان الفحص")
            {
                brnches();
               
                //dgv_visit.DataSource = null;
                label2.Show();
                label3.Show();
                FromDate.Show();
                ToDate.Show();
                button2.Show();
                label4.Hide();
                label5.Show();
                textBox1.Show();
                label13.Show();
                Cmb_CategoryItem.Hide();
                cmb_branches.Show();

            }
            else if (comboBox1.Text == "بحث بالتاريخ + مكان الفحص+نوع الفحص")
            {
                brnches();
                Cmb_CategoryItem.DataSource = c.selectCategoryXRaya();
                Cmb_CategoryItem.DisplayMember = "الفئات";
                Cmb_CategoryItem.ValueMember = "ID_CtegoryXrays";

                //dgv_visit.DataSource = null;
                label2.Show();
                label3.Show();
                label13.Show();
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
           
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
          
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
          
        }
        void sum()
        {
            decimal total = 0;
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                DataRow row = gridView1.GetDataRow(i);
                total += Convert.ToDecimal(row[10].ToString());

            }
            txt_totalinvoice.Text = total.ToString("₱ #,##0.0");
            textBox1.Text = gridView1.RowCount.ToString();
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text == "بحث بالتاريخ + مكان الفحص")
            {
                gridControl1.DataSource = t.SelectSearchAllticketsBranchDate(Convert.ToInt32(cmb_branches.SelectedValue), FromDate.Value, ToDate.Value);
            }
            else if (comboBox1.Text == "بحث بالتاريخ + مكان الفحص+نوع الفحص")
            {
                gridControl1.DataSource = t.SelectSearchticketsBranchDateandCategory(Convert.ToInt32(cmb_branches.SelectedValue), Convert.ToInt32(Cmb_CategoryItem.SelectedValue), FromDate.Value, ToDate.Value);
               

            }
            sum();
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            if (gridView1.RowCount>0)
            {
                gridControl1.ShowRibbonPrintPreview();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {



            Frm_Payouts pa = new Frm_Payouts();

            DataTable dt10 = new DataTable();
            DataTable dt5 = new DataTable();
            DataTable dt7 = new DataTable();
            DataTable dt1 = new DataTable();

            //Frm_DetailsTickets fd = new Frm_DetailsTickets();
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
                dt10.Clear();
                dt10 = t.vildateTransferForCompany(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة")));
                if (dt10.Rows.Count > 0)
                {
                    MessageBox.Show("عزيزى المستخدم يرجي العلم باان تم تحويل الفاتورة الي جهه اخري واسترداد المبلغ   ", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
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
                    pa.textBox1.Text = dr[20].ToString();
                    pa.txt_num.Text = dr[0].ToString();
                    pa.Txt_IdCust.Text = dr[26].ToString();
                }

                dt1.Clear();
                dt1 = t.TicketDetailsSelectTicketsDetAILS(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة")));
                pa.dataGridView1.DataSource = dt1;

                pa.dataGridView1.Columns[0].Visible = false;
                pa.dataGridView1.Columns[2].Visible = false;

                pa.ShowDialog();



            }

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

           
        }

        private void simpleButton3_Click_1(object sender, EventArgs e)
        {
           
        }

 
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
