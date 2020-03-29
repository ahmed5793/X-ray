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
    public partial class Frm_Purshasing : Form
    {
        Product Product = new Product();
        Store Store = new Store();
        Stock Stock = new Stock();
        Suppliers Suppliers = new Suppliers();
        DataTable dt = new DataTable();
        DataTable dt4 = new DataTable();
        DataTable dt5 = new DataTable();

        public Frm_Purshasing()
        {
            InitializeComponent();
            Cmb_Store.DataSource = Store.Select_ComboStore();
            Cmb_Store.DisplayMember = "Store_name";
            Cmb_Store.ValueMember = "id_store";
            cmb_Stock.DataSource = Stock.Compo_Stock();
            cmb_Stock.DisplayMember = "Name_Stock";
            cmb_Stock.ValueMember = "ID_Stock";
            if (dt4.Rows.Count > 0)
            {
                dt4 = Stock.Select_moneyStock(Convert.ToInt32(cmb_Stock.SelectedValue));

            }

            Cmb_Suppliers.DataSource = Suppliers.CompoBoxSuppliers();
            Cmb_Suppliers.DisplayMember = "Name";
            Cmb_Suppliers.ValueMember = "Sup_id";
            //txt_num.Text = Suppliers.LastSuppliersDetalis().Rows[0][0].ToString();

            txt_sales.Text = Program.salesman;
            DataTablee();
        }
        public void DataTablee()
        {


            dt.Columns.Add("رقم الصنف");
            dt.Columns.Add("اسم الصنف");
            dt.Columns.Add("سعر الشراء");
            dt.Columns.Add("الكميه ");
            dt.Columns.Add(" الاجمالي ");
            dt.Columns.Add(" نسبه الخصم");
            dt.Columns.Add(" الاجمالي بعد الخصم");
            dataGridView1.DataSource = dt;
        }

        void Data()
        {
            dt.Clear();
            txt_note.Clear();
            txt_invo.Text = "0.00";
            txt_pay.Text = "0.00";
            txt_mark.Text = "0";
        }
        public void Pay()

        {
            if (txt_invo.Text != string.Empty && txt_pay.Text != string.Empty)
            {
                decimal totainv = Convert.ToDecimal(txt_invo.Text) - Convert.ToDecimal(txt_pay.Text);
                txt_mark.Text = totainv.ToString();
            }

        }
        public void Calc_Amount()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                decimal mins = Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value) * Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                dataGridView1.Rows[i].Cells[4].Value = mins.ToString();
            }
        }
        public void Total_Amount()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                decimal amount = Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);
                decimal discount = Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value);
                decimal total = amount - discount;
                dataGridView1.Rows[i].Cells[6].Value = total.ToString();
            }
        }
        public void Totalinvoicesup()
        {

            decimal total = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                total += Convert.ToDecimal(dataGridView1.Rows[i].Cells[6].Value);
            }
            txt_invo.Text = Math.Round(total, 2).ToString();

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Frm_Purshasing_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_Suppliers frm_Suppliers = new Frm_Suppliers();
                frm_Suppliers.ShowDialog();
                Cmb_Suppliers.DataSource = Suppliers.CompoBoxSuppliers();

            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Frm_EditDiscount fed = new Frm_EditDiscount();

            Frm_EditPrice fp = new Frm_EditPrice();
            Frm_EditQantity qs = new Frm_EditQantity();

            try
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;

                    }


                    if (e.ColumnIndex == 3)
                    {
                        qs.ShowDialog();
                        if (qs.textBox1.Text != "" && qs.textBox1.Text != "0")
                        {
                            dataGridView1.CurrentRow.Cells[3].Value = qs.textBox1.Text;
                            Calc_Amount();
                            Total_Amount();
                            Totalinvoicesup();
                            Pay();
                            qs.textBox1.Clear();
                        }

                    }
                    if (e.ColumnIndex == 2)
                    {

                        fp.ShowDialog();

                        if (fp.txt_prise.Text != "" && fp.txt_prise.Text != "0")
                        {
                            dataGridView1.CurrentRow.Cells[2].Value = fp.txt_prise.Text;

                            Calc_Amount();
                            Total_Amount();
                            Totalinvoicesup();
                            Pay();
                            fp.txt_prise.Clear();
                        }

                    }
                    if (e.ColumnIndex == 5)
                    {
                        fed.ShowDialog();
                        if (fed.textBox1.Text != "" && fed.textBox1.Text != "0")
                        {
                            dataGridView1.CurrentRow.Cells[5].Value = fed.textBox1.Text;
                           Calc_Amount();
                           Total_Amount();
                           Totalinvoicesup();
                           Pay();
 
                            fed.textBox1.Clear();

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
                fed.Dispose();
                qs.Dispose();
                fp.Dispose();
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
           
        }

        private void txt_pay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && txt_pay.Text.ToString().IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar((System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)))
            {
                e.Handled = true;
            }
        }

        private void txt_pay_KeyUp(object sender, KeyEventArgs e)
        {
            Pay();
        }

        private void txt_invo_KeyUp(object sender, KeyEventArgs e)
        {
            Pay();

        }

        private void txt_mark_KeyUp(object sender, KeyEventArgs e)
        {
           
            Pay();
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            try
            {
                Totalinvoicesup();
                Pay();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_Print_Click(object sender, EventArgs e)
        {
            //Rpt.rptsupplier rs = new Rpt.rptsupplier();
            //Rpt.FrmSingleReport fr = new Rpt.FrmSingleReport();

            //rs.SetParameterValue("@id", Convert.ToInt32(txt_num.Text));
            //fr.crystalReportViewer1.ReportSource = rs;
            //fr.Show();
        }

        private void txt_pay_Click(object sender, EventArgs e)
        {
            if (txt_pay.Text=="0")
            {
                txt_pay.Text ="";
            }
        }

        private void txt_pay_Leave(object sender, EventArgs e)
        {
            if (txt_pay.Text=="")
            {
                txt_pay.Text = "0";
                Pay();
            }
        }

        private void txt_pay_TextChanged(object sender, EventArgs e)
        {
            if (txt_pay.Text==".")
            {
                txt_pay.Text = "";
            }
        }

        private void txt_num_TextChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Frm_ProductList frm_ProductList = new Frm_ProductList();
            try
            {
                frm_ProductList.ShowDialog();
                if (frm_ProductList.dataGridView1.Rows.Count > 0 && frm_ProductList.dataGridView1.SelectedRows.Count > 0)
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        if (dataGridView1.Rows[i].Cells[0].Value.ToString() == frm_ProductList.dataGridView1.CurrentRow.Cells[0].Value.ToString())
                        {
                            Console.Beep();
                            MessageBox.Show("هذا الصنف مسجل من قبل ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    DataRow r = dt.NewRow();
                    r[0] = frm_ProductList.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    r[1] = frm_ProductList.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    r[2] = frm_ProductList.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    r[3] = 1;
                    r[5] = 0;
                    //r[6] = txt_amount.Text;
                    dt.Rows.Add(r);
                    Console.Beep();
                    dataGridView1.DataSource = dt;
                    Calc_Amount();
                    Total_Amount();
                    Totalinvoicesup();
                    Pay();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    if (cmb_Stock.Text == "")
                    {
                        MessageBox.Show("لا بد من تحديد خزنة");
                        return;
                    }
                    if (Cmb_Store.Text == "")
                    {
                        MessageBox.Show("لا بد من تحديد مخزن");
                        return;
                    }
                    dt4.Clear();
                    dt4 = Stock.Select_moneyStock(Convert.ToInt32(cmb_Stock.SelectedValue));
                    if (dt4.Rows.Count > 0)
                    {
                        if (Convert.ToDecimal(txt_pay.Text) > Convert.ToDecimal(dt4.Rows[0][0]))
                        {
                            MessageBox.Show("رصيد الخزنة الحالى غير كافى لشراء هذه الفاتورة");
                            return;
                        }
                    }
                    Btn_Save.Enabled = false;
                    cmb_Stock.Enabled = false;
                    Cmb_Store.Enabled = false;
                    Cmb_Suppliers.Enabled = false;
                    dataGridView1.Enabled = false;
                    Btn_SelectProduct.Enabled = false;
                    Suppliers.ADDSuppliersINFORMARION(Convert.ToInt32(Cmb_Suppliers.SelectedValue),
                     dateTimePicker1.Value, txt_note.Text, txt_sales.Text, Convert.ToDecimal(txt_invo.Text),
                     Convert.ToDecimal(txt_pay.Text), Convert.ToDecimal(txt_mark.Text), Convert.ToInt32(cmb_Stock.SelectedValue));
                    txt_num.Text = Suppliers.LastSuppliersDetalis().Rows[0][0].ToString();

                    if (Convert.ToDecimal(txt_pay.Text) > 0)
                    {
                        Stock.Add_StockPull(Convert.ToInt32(cmb_Stock.SelectedValue), Convert.ToDecimal(txt_pay.Text), dateTimePicker1.Value, txt_sales.Text, "فاتورة مشتريات رقم" + " " + txt_num.Text + " " + "إلى المورد " + " " + Cmb_Suppliers.Text);
                    }
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        dt5.Clear();
                        dt5 = Product.Validate_StoreProduct(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value), Convert.ToInt32(Cmb_Store.SelectedValue));
                        if (dt5.Rows.Count > 0)
                        {
                            Product.Update_QuantityStoreProduct(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value),
                                 Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value), Convert.ToInt32(Cmb_Store.SelectedValue));
                        }
                        else if (dt5.Rows.Count == 0)
                        {
                            Product.Add_StoreProduct(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value), Convert.ToInt32(Cmb_Store.SelectedValue),
                                Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value), 0);
                        }
                        Suppliers.addSuppliersDetails(Convert.ToInt32(txt_num.Text),
                            Convert.ToInt32(Cmb_Store.SelectedValue),
                            Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value),
                            Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value)
                            , Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value),
                            Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value),
                            Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value)
                            , Convert.ToDecimal(dataGridView1.Rows[i].Cells[6].Value));
                    }
                    dt5.Clear();
                    dt5 = Suppliers.Select_SupplierTotalMoney(Convert.ToInt32(Cmb_Suppliers.SelectedValue));
                    decimal mno = Convert.ToDecimal(dt5.Rows[0][0]) + Convert.ToDecimal(txt_mark.Text);
                    Suppliers.Update_SupplierTotalMoney(Convert.ToInt32(Cmb_Suppliers.SelectedValue), mno);
                    Suppliers.Add_SupplierStatmentACCount(Convert.ToInt32(Cmb_Suppliers.SelectedValue), Convert.ToDecimal(txt_invo.Text)
                        , Convert.ToDecimal(txt_pay.Text), mno, "فاتورة مشتريات رقم" + " " + txt_num.Text, dateTimePicker1.Value);

                    MessageBox.Show("تم اضافه الفاتوره بنجاح", "عمليه الاضافه", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                    Data();
                    Btn_Save.Enabled = true;
                    cmb_Stock.Enabled = true;
                    Cmb_Store.Enabled = true;
                    Cmb_Suppliers.Enabled = true;
                    dataGridView1.Enabled = true;
                    Btn_SelectProduct.Enabled = true;
                    txt_num.Clear();
                }
                else
                {
                    MessageBox.Show("من فضلك قم بااختيار صنف واحد علي الاقل ");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void txt_pay_MouseMove(object sender, MouseEventArgs e)
        {
            if (txt_pay.Text=="")
            {
                txt_pay.Text = "0";
                Pay();
            }
        }
    }
}
