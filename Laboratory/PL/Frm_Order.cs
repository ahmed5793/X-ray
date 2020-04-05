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
    public partial class Frm_Order : Form
    {
        Orders Orders = new Orders();
        Store Store = new Store();
        Product Product = new Product();
        DataTable dt = new DataTable();
        public Frm_Order()
        {
            InitializeComponent();
            Function();
        }
        void Function()
        {
            try
            {

            txt_sales.Text = Program.salesman;
            cmb_Store.DataSource = Store.Select_ComboStore();
            cmb_Store.DisplayMember = "Store_name";
            cmb_Store.ValueMember = "id_store";
            txt_num.Hide();
            DataTablee();
            Rezizse();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void DataTablee()
        {
            dt.Columns.Add("رقم الصنف");
            dt.Columns.Add("اسم الصنف");
            dt.Columns.Add("الكميه ");
            DataGridView1.DataSource = dt;
        }
        void Rezizse()
        {
            DataGridView1.RowHeadersWidth = 20;
            DataGridView1.Columns[0].Width = 60;
            DataGridView1.Columns[1].Width = 250;
            DataGridView1.Columns[2].Width = 158;
        }
        void Data()
        {
            dt.Clear();
            txt_note.Clear();
            txt_num.Clear();
        }

        private void Btn_selectProduct_Click(object sender, EventArgs e)
        {
           
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Frm_EditQantity frm_EditQantity = new Frm_EditQantity();
            DataTable dt2 = new DataTable();
            try
            {
                if (DataGridView1.Rows.Count > 0)
                {
                    if (e.ColumnIndex == 2)
                    {
                        frm_EditQantity.ShowDialog();
                        if (frm_EditQantity.textBox1.Text != "" && frm_EditQantity.textBox1.Text != "0")
                        {
                            dt2.Clear();
                            dt2 = Product.Validate_Quantity(Convert.ToInt32(DataGridView1.CurrentRow.Cells[0].Value), Convert.ToInt32(cmb_Store.SelectedValue), Convert.ToInt32(frm_EditQantity.textBox1.Text));
                            if (dt2.Rows.Count > 0)
                            {
                                MessageBox.Show("الكمية المحددة أكبر من الكمية الموجود حاليا بالمخزن");
                                return;
                            }
                            DataGridView1.CurrentRow.Cells[2].Value = frm_EditQantity.textBox1.Text;
                            frm_EditQantity.textBox1.Clear();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                dt2.Dispose();
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Frm_TransProductList frm_TransProductList = new Frm_TransProductList();
            try
            {
                frm_TransProductList.dataGridView1.DataSource = Product.Select_ComboTransfairProductT(Convert.ToInt32(cmb_Store.SelectedValue));

                frm_TransProductList.ShowDialog();

                if (frm_TransProductList.dataGridView1.Rows.Count > 0 && frm_TransProductList.dataGridView1.SelectedRows.Count > 0)
                {
                    for (int i = 0; i < DataGridView1.Rows.Count; i++)
                    {
                        if (DataGridView1.Rows[i].Cells[0].Value.ToString() == frm_TransProductList.dataGridView1.CurrentRow.Cells[0].Value.ToString())
                        {
                            if (Convert.ToInt32(DataGridView1.CurrentRow.Cells[2].Value) >= Convert.ToInt32(frm_TransProductList.dataGridView1.CurrentRow.Cells[4].Value))
                            {
                                MessageBox.Show(" الكميه المدخله لهذا الصنف غير متاحه", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            else
                            {
                                int x = 1;
                                DataGridView1.CurrentRow.Cells[2].Value = Convert.ToInt32(DataGridView1.CurrentRow.Cells[2].Value) + x;
                                Console.Beep();
                                return;
                            }
                        }
                    }
                    DataRow dr = dt.NewRow();
                    dr[0] = frm_TransProductList.dataGridView1.CurrentRow.Cells[0].Value;
                    dr[1] = frm_TransProductList.dataGridView1.CurrentRow.Cells[1].Value;
                    dr[2] = 1;
                    dt.Rows.Add(dr);
                    DataGridView1.DataSource = dt;
                    Console.Beep();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            Data();

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_Store.Text == "" && DataGridView1.Rows.Count < 0)
                {
                    MessageBox.Show("");
                    return;
                }
                else if (DataGridView1.Rows.Count > 0)
                {
                    Orders.Add_Order(dateTimePicker1.Value, txt_note.Text, txt_sales.Text);
                    txt_num.Text = (Orders.Last_IdOrder().Rows[0][0]).ToString();
                    for (int i = 0; i < DataGridView1.Rows.Count; i++)
                    {
                        Orders.Add_OrderDetails(Convert.ToInt32(txt_num.Text), Convert.ToInt32(cmb_Store.SelectedValue),
                            Convert.ToInt32(DataGridView1.Rows[i].Cells[0].Value), Convert.ToInt32(DataGridView1.Rows[i].Cells[2].Value));
                    }
                    MessageBox.Show("تم حفظ الفاتورة بنجاح");
                    Data();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void cmb_Store_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dt.Clear();
        }
    }
}
