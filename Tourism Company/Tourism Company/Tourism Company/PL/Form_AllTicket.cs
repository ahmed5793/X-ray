using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tourism_Company.BL;

namespace Tourism_Company.PL
{
    public partial class Form_AllTicket : Form
    {
        private static Form_AllTicket book;
        static void formclosed(object sender, FormClosedEventArgs e)
        {

            book = null;

        }
        internal static Form_AllTicket geter
        {
            get
            {
                if (book == null)
                {
                    book = new Form_AllTicket();
                    book.FormClosed += new FormClosedEventHandler(formclosed);
                }
                return book;
            }
        }
                DataTable dt = new DataTable();
        Booking b = new Booking();
        public Form_AllTicket()
        {
            InitializeComponent();
            if (book==null)
            
                book = this;
            
            dataGridView1.DataSource = b.selectClientTicket();
        }

        private void Rdb_customer_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_customer.Checked==true)
            {
                dataGridView1.DataSource = b.selectClientTicket();
            }
            else if (rdb_company.Checked==true)
            {
                dataGridView1.DataSource = b.selectCompanyTicket();
            
            }
           
        }

        private void Rdb_company_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Txt_search_TextChanged(object sender, EventArgs e)
        {
            if (rdb_customer.Checked==true)
            {
                dt.Clear();
                dt = b.SearchClientTicket(txt_search.Text);
                dataGridView1.DataSource = dt;
            }
            else if (rdb_company.Checked==true)
            {
                dt.Clear();
                dt = b.SearchCompanyTicket(txt_search.Text);
                dataGridView1.DataSource = dt;
             
            }
        }

        private void Btn_update_Click(object sender, EventArgs e)
        {
            try
            {
             
                if (rdb_customer.Checked == true)
                {
                    dt.Clear();
                    dt = b.ReturnClientBooking(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));

                    foreach (DataRow dr in dt.Rows)
                    {
                        Form_update fb = new Form_update();
                        fb.txt_num.Text = dr[0].ToString();
                        fb.date_booking.Text = dr[1].ToString();
                        fb.txt_client.Text = dr[2].ToString();
                        fb.cmb_plane.Text = dr[3].ToString();
                        fb.txt_out.Text = dr[4].ToString();
                        fb.txt_numTraiple.Text = dr[5].ToString();
                        fb.date_traiple.Text = dr[6].ToString();
                        fb.txt_arrival.Text = dr[7].ToString();
                        fb.txt_Basic.Text = dr[8].ToString();
                        fb.txt_Total.Text = dr[9].ToString();
                        fb.txt_discountCommution.Text = dr[10].ToString();
                        fb.txt_CommutionMoney.Text = dr[11].ToString();
                        fb.txt_PriceClient.Text = dr[12].ToString();
                        fb.txt_pay.Text = dr[13].ToString();
                        fb.txt_rent.Text = dr[14].ToString();
                        fb.txt_note.Text = dr[15].ToString();
                        fb.textBox1.Text = dr[16].ToString();
                        fb.rdb_customer.Checked = true;
                        fb.label3.Hide();
                        fb.txt_company.Hide();

                        fb.Show();

                    }


                }

                else if (rdb_company.Checked == true)
                {


                    dt = b.ReturnCompanyBooking(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));

                    foreach (DataRow dr in dt.Rows)
                    {
                        Form_update fb = new Form_update();
                        fb.txt_num.Text = dr[0].ToString();
                        fb.date_booking.Text = dr[1].ToString();
                        fb.txt_client.Text = dr[2].ToString();
                        fb.txt_company.Text = dr[3].ToString();
                        fb.cmb_plane.Text = dr[4].ToString();
                        fb.txt_out.Text = dr[5].ToString();
                        fb.txt_numTraiple.Text = dr[6].ToString();
                        fb.date_traiple.Text = dr[7].ToString();
                        fb.txt_arrival.Text = dr[8].ToString();
                        fb.txt_Basic.Text = dr[9].ToString();
                        fb.txt_Total.Text = dr[10].ToString();
                        fb.txt_discountCommution.Text = dr[11].ToString();
                        fb.txt_CommutionMoney.Text = dr[12].ToString();
                        fb.txt_PriceClient.Text = dr[13].ToString();
                        fb.txt_pay.Text = dr[14].ToString();
                        fb.txt_rent.Text = dr[15].ToString();
                        fb.txt_note.Text = dr[16].ToString();
                        fb.textBox1.Text = dr[17].ToString();
                 
                      

                        fb.rdb_company.Checked = true;




                        fb.Show();



                    }
                }

                }
            
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Form_AllTicket_Load(object sender, EventArgs e)
        {

        }

        private void Btn_print_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdb_customer.Checked == true)
                {


                    if (MessageBox.Show("هل تريد حذف العميل", "عمليه الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        b.Delete_Arba7(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value), Convert.ToDateTime(dataGridView1.CurrentRow.Cells[9].Value));
                        b.DeleteInsertBnak(Convert.ToInt32(dataGridView1.CurrentRow.Cells[8].Value), Convert.ToDateTime(dataGridView1.CurrentRow.Cells[9].Value), Convert.ToDecimal(dataGridView1.CurrentRow.Cells[9].Value) - Convert.ToDecimal(dataGridView1.CurrentRow.Cells[10].Value));
                        b.Delete_Client_bookinng(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));

                        MessageBox.Show("تم مسح العميل بنجاح", "عمليه الحذف", MessageBoxButtons.OK, MessageBoxIcon.None);


                        dataGridView1.DataSource = b.selectClientTicket();

                    }
                    else
                    {
                        MessageBox.Show("تم الغاء عمليه الحذف", "عمليه الحذف", MessageBoxButtons.OK, MessageBoxIcon.None);

                    }
                }
                else if (rdb_company.Checked==true)
                {
                    if (MessageBox.Show("هل تريد حذف العميل", "عمليه الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        b.Delete_Arba7(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value), Convert.ToDateTime(dataGridView1.CurrentRow.Cells[10].Value));
                        b.DeleteInsertBnak(Convert.ToInt32(dataGridView1.CurrentRow.Cells[9].Value), Convert.ToDateTime(dataGridView1.CurrentRow.Cells[10].Value), Convert.ToDecimal(dataGridView1.CurrentRow.Cells[11].Value) - Convert.ToDecimal(dataGridView1.CurrentRow.Cells[12].Value));
                        b.Delete_company_Booking(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));

                        MessageBox.Show("تم مسح العميل بنجاح", "عمليه الحذف", MessageBoxButtons.OK, MessageBoxIcon.None);


                        dataGridView1.DataSource = b.selectCompanyTicket();

                    }
                    else
                    {
                        MessageBox.Show("تم الغاء عمليه الحذف", "عمليه الحذف", MessageBoxButtons.OK, MessageBoxIcon.None);

                    }

                }

                }
            catch (Exception)
            {

                throw;
            }
        }
    }
    }

