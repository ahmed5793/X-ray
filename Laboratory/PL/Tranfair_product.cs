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
    public partial class Tranfair_product : Form
    {
        Store Store = new Store();
        Product Product = new Product();
        DataTable dt = new DataTable();
        public Tranfair_product()
        {
            InitializeComponent();
            Cmb_FromStore.DataSource = Store.Select_ComboStore();
            Cmb_FromStore.DisplayMember = "Store_name";
            Cmb_FromStore.ValueMember = "id_store";

            Cmb_ToStore.DataSource = Store.Select_ComboStore();
            Cmb_ToStore.DisplayMember = "Store_name";
            Cmb_ToStore.ValueMember = "id_store";
            Txt_sales.Text = Program.salesman;
            txt_num.Text =Product.Select_LastIdTransfair().Rows[0][0].ToString();

            SelectdataTable();
            Rezizse();
        }
        void SelectdataTable()
        {
            dt.Columns.Add("رقم الصنف");
            dt.Columns.Add("اسم الصنف");
            dt.Columns.Add("الكميه المحولة");
            dt.Columns.Add("الحد الادنى");
            DataGridView1.DataSource = dt;
        }
        void Rezizse()
        {
            DataGridView1.RowHeadersWidth = 20;
            DataGridView1.Columns[0].Width = 60;
            DataGridView1.Columns[1].Width = 250;
            DataGridView1.Columns[2].Width = 158;    
        }

        private void Cmb_FromStore_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dt.Clear();
            DataGridView1.DataSource = null;
        }
        private void Cmb_ProdName_Enter(object sender, EventArgs e)
        {          
        }
        private void btn_new_Click(object sender, EventArgs e)
        {
          
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
        }

        private void Cmb_FromStore_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
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
                            dt2 = Product.Validate_Quantity(Convert.ToInt32(DataGridView1.CurrentRow.Cells[0].Value), Convert.ToInt32(Cmb_FromStore.SelectedValue), Convert.ToInt32(frm_EditQantity.textBox1.Text));
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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txt_num.Text = Product.Select_LastIdTransfair().Rows[0][0].ToString();
            Txt_note.Clear();
            dt.Clear();
            Btn_selectProduct.Enabled = true;
            Cmb_FromStore.Enabled = true;
            Cmb_ToStore.Enabled = true;
            DataGridView1.Enabled = true;
            Btn_Save.Enabled = true;
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            Frm_TransProductList frm_TransProductList = new Frm_TransProductList();
            try
            {
                frm_TransProductList.dataGridView1.DataSource = Product.Select_ComboTransfairProductT(Convert.ToInt32(Cmb_FromStore.SelectedValue));

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
                    dr[3] = frm_TransProductList.dataGridView1.CurrentRow.Cells[5].Value;
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

        private void simpleButton2_Click(object sender, EventArgs e)
        {

            DataTable dt5 = new DataTable();
            try
            {
                if (Cmb_FromStore.Text == string.Empty && Cmb_ToStore.Text == string.Empty)
                {
                    MessageBox.Show("لا بد من وجود مخزن للتحويل");
                    return;
                }
                if (DataGridView1.Rows.Count < 1)
                {
                    MessageBox.Show("لابد من وجود صنف واحد على الاقل ");
                    return;
                }
                else
                {
                    Product.add_TransFairProduct(Convert.ToInt32(txt_num.Text), Txt_sales.Text, DateTimePicker1.Value, Txt_note.Text);
                    for (int i = 0; i < DataGridView1.Rows.Count; i++)
                    {
                        Product.Add_TransfairDetails(Convert.ToInt32(txt_num.Text), Convert.ToInt32(Cmb_FromStore.SelectedValue), Cmb_FromStore.Text,
                            Convert.ToInt32(Cmb_ToStore.SelectedValue), Cmb_ToStore.Text, Convert.ToInt32(DataGridView1.Rows[i].Cells[0].Value),
                            Convert.ToInt32(DataGridView1.Rows[i].Cells[2].Value));
                        dt5 = Product.Validate_StoreProduct(Convert.ToInt32(DataGridView1.Rows[i].Cells[0].Value), Convert.ToInt32(Cmb_ToStore.SelectedValue));
                        if (dt5.Rows.Count > 0)
                        {
                            Product.Update_QuantityStoreProduct(Convert.ToInt32(DataGridView1.Rows[i].Cells[0].Value),
                                Convert.ToDecimal(DataGridView1.Rows[i].Cells[2].Value), Convert.ToInt32(Cmb_ToStore.SelectedValue));
                        }
                        else if (dt5.Rows.Count == 0)
                        {
                            Product.Add_StoreProduct(Convert.ToInt32(DataGridView1.Rows[i].Cells[0].Value), Convert.ToInt32(Cmb_ToStore.SelectedValue),
                                   Convert.ToDecimal(DataGridView1.Rows[i].Cells[2].Value), Convert.ToInt32(DataGridView1.Rows[i].Cells[3].Value));
                        }
                    }
                    MessageBox.Show("تم إضافة التحويل بنجاح");
                    Btn_selectProduct.Enabled = false;
                    Cmb_FromStore.Enabled = false;
                    Cmb_ToStore.Enabled = false;
                    DataGridView1.Enabled = false;
                    Btn_Save.Enabled = false;



                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_Print_Click(object sender, EventArgs e)
        {

        }
    }
}
