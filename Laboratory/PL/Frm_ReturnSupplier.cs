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
    public partial class Frm_ReturnSupplier : Form
    {
        Suppliers Suppliers = new Suppliers();
        Store Store = new Store();
        Users u = new Users();
        Branches b = new Branches();
        Stock s = new Stock();
        DataTable dt = new DataTable();
        DataTable dt10 = new DataTable();
        DataTable dt5 = new DataTable();
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt20 = new DataTable();
        public Frm_ReturnSupplier()
        {

            InitializeComponent();
            Function();
        }
        void Function()
        {
            try
            {
                comboBox1.DataSource = Suppliers.select_IdPurshasing();
                comboBox1.DisplayMember = "ID";
                comboBox1.ValueMember = "ID";
                txt_sales.Text = Program.salesman;
                Permision();
                txt_iD.Hide();
                textBox1.Hide();
                SelectDataTable();
                Txt_IdStore.Hide();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            } 
        }
        void Permision()
        {
            dt.Clear();
            dt = u.SelectUserBranch(txt_sales.Text);

            if (dt.Rows.Count > 0)
            {
                Cmb_Bransh.DataSource = u.SelectUserBranch(txt_sales.Text);
                Cmb_Bransh.DisplayMember = "Name";
                Cmb_Bransh.ValueMember = "Branch_ID";

                Cmb_Stock.DataSource = s.SelectStockBranch(Convert.ToInt32(Cmb_Bransh.SelectedValue));
                Cmb_Stock.DisplayMember = "Name_Stock";
                Cmb_Stock.ValueMember = "ID_Stock";
            }
            else
            {
                Cmb_Bransh.DataSource = b.SelectCompBranches();
                Cmb_Bransh.DisplayMember = "Name";
                Cmb_Bransh.ValueMember = "Branch_ID";

                Stock();
            }
        }
        void Stock()
        {
            Cmb_Stock.DataSource = s.Compo_Stock();
            Cmb_Stock.DisplayMember = "Name_Stock";
            Cmb_Stock.ValueMember = "ID_Stock";
        }
        void Clear()
        {
            txt_Name.Clear();
            txt_names.Clear();
            txt_num.Clear();
            txt_prise.Clear();
            txt_quantity.Clear();
            txt_sales.Clear();
            txt_total.Clear();
            textBox4.Text = "0";
            textBox1.Clear();
            Txt_QuantityStore.Text = "0";
            dt10.Clear();
            dataGridView1.Rows.Clear();
        }

       void SelectDataTable()
        {
            dt10.Columns.Add("رقم الصنف");
            dt10.Columns.Add("إسم الصنف");
            dt10.Columns.Add("الكمية المرتجعه");
            dt10.Columns.Add("سعر الشراء");
            dt10.Columns.Add("إلاجمالى");
            dt10.Columns.Add("رقم المخزن");
            dataGridView2.DataSource = dt10;


        }
        //void Calcalutor()
        //{
        //    if (txt_prise.Text != string.Empty && txt_quantity.Text != string.Empty)
        //    {

        //        decimal mins = Convert.ToDecimal(txt_prise.Text) * Convert.ToInt32(txt_quantity.Text);
        //        txt_amount.Text = Math.Round(mins,1).ToString();
        //    }
        //}
        //void Total()
        //{
        //    if (txt_amount.Text != string.Empty && txt_discount.Text != string.Empty)
        //    {
        //        decimal amount = Convert.ToDecimal(txt_amount.Text);
        //        decimal discount = Convert.ToDecimal(txt_discount.Text);
        //        decimal total = amount - discount;
        //        txt_total.Text = Math.Round(total,1).ToString();
        //    }
        //}
        //internal void Sum()
        //{
        //    int x = int.Parse(textBox1.Text) - int.Parse(txt_return.Text);
        //    txt_quantity.Text = x.ToString();
        //}
        //public void CalctotalinvoOrder()
        //{
        //    decimal total = 0;
        //    for (int i = 0; i < dataGridView1.Rows.Count; i++)
        //    {
        //        total += Convert.ToDecimal(dataGridView1.Rows[i].Cells[6].Value);
        //    }
        //    txt_invo.Text = Math.Round(total,1).ToString();
        //}
        internal void Calc_ReturnValue()
        {
            decimal Total = 0;
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                Total += (Convert.ToDecimal(dataGridView2.Rows[i].Cells[4].Value));
            }
            textBox4.Text = Math.Round(Total, 0).ToString();
        }
        private void txt_sales_TextChanged(object sender, EventArgs e)
        {
        }
        private void label3_Click(object sender, EventArgs e)
        {
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
     
            try
            {
                dt20.Clear();
                dt20= Suppliers.Validate_IdSupplierInformation(Convert.ToInt32(comboBox1.SelectedValue));
                if (dt20.Rows.Count==0)
                {
                    Console.Beep();
                    MessageBox.Show("لا توجد فاتورة بهذا الرقم");
                    return;
                }
                Clear();
                dt1.Clear();
                dt2.Clear();
                dt1 = Suppliers.Select_SupplierInformation(Convert.ToInt32(comboBox1.SelectedValue));
                dt2 = Suppliers.Select_SupplierDetailsForReturn(Convert.ToInt32(comboBox1.SelectedValue));
                foreach (DataRow dr in dt1.Rows)
                {
                    txt_num.Text = dr["ID"].ToString();
                    txt_Name.Text = dr["Name"].ToString();
                    textBox1.Text = dr["sup_id"].ToString();
                    txt_sales.Text = Program.salesman;            
                }
                dataGridView1.DataSource = dt2;
                dataGridView1.Columns[7].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dt1.Dispose();
                dt2.Dispose();
            }
        }

        private void txt_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            try
            {
                txt_iD.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_names.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txt_prise.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txt_quantity.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txt_total.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                Txt_IdStore.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                data.Clear();
                data = (Store.Select_QuantityProduct(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value), Convert.ToInt32(dataGridView1.CurrentRow.Cells[7].Value)));
                Txt_QuantityStore.Text = data.Rows[0][0].ToString();       
            }
            catch
            {
                return;
            }
            finally
            {
                data.Dispose();
            }
        }

        private void btn_row_Click(object sender, EventArgs e)
        {
        }

        private void txt_return_KeyUp(object sender, KeyEventArgs e)
        {
          
        }

        private void txt_return_TextChanged(object sender, EventArgs e)
        {
            if (txt_return.Text == "")
            {
                txt_return.Text = "0";
            }     
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txt_return_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txt_pay_Leave(object sender, EventArgs e)
        {
           
        }

        private void txt_invo_KeyUp(object sender, KeyEventArgs e)
        {
         
        }

        private void txt_rent_KeyUp(object sender, KeyEventArgs e)
        {
          
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
        }

        private void txt_amount_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void Cmb_Stock_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Btn_SaveReturn_Click(object sender, EventArgs e)
        {
        }

        private void Txt_Pay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && Txt_Pay.Text.ToString().IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                e.Handled = true;
            }
        }

        private void Txt_Pay_TextChanged(object sender, EventArgs e)
        {
            if (Txt_Pay.Text=="")
            {
                Txt_Pay.Text = "0";
            }
        }

        private void Txt_Pay_Click(object sender, EventArgs e)
        {
            if (Txt_Pay.Text == "0")
            {
                Txt_Pay.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void View_OldReturn_Click(object sender, EventArgs e)
        {
        }

        private void btn_save_Click_1(object sender, EventArgs e)
        {

            Frm_SearchSupplierInformation frm = new Frm_SearchSupplierInformation();

            try
            {
                frm.ShowDialog();
                DataTable dt1 = new DataTable();
                DataTable dt2 = new DataTable();
                try
                {
                    if (frm.dataGridView1.SelectedRows.Count > 0 && frm.dataGridView1.Rows.Count > 0)
                    {
                        Clear();
                        dt1.Clear();
                        dt2.Clear();
                        dt1 = Suppliers.Select_SupplierInformation(Convert.ToInt32(frm.dataGridView1.CurrentRow.Cells[0].Value));
                        dt2 = Suppliers.Select_SupplierDetailsForReturn(Convert.ToInt32(frm.dataGridView1.CurrentRow.Cells[0].Value));
                        foreach (DataRow dr in dt1.Rows)
                        {
                            txt_num.Text = dr["ID"].ToString();
                            txt_Name.Text = dr["Name"].ToString();
                            textBox1.Text = dr["sup_id"].ToString();
                            txt_sales.Text = Program.salesman;

                        }
                        dataGridView1.DataSource = dt2;
                        dataGridView1.Columns[7].Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    dt1.Dispose();
                    dt2.Dispose();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            Frm_ShowOldReturn frm_show = new Frm_ShowOldReturn();
            DataTable data5 = new DataTable();
            try
            {
                if (txt_num.Text != "")
                {
                    data5.Clear();
                    data5 = Suppliers.Select_SupplierReturn(Convert.ToInt32(txt_num.Text));
                    frm_show.dataGridView1.DataSource = data5;
                    frm_show.ShowDialog();
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
                if (Convert.ToInt32(txt_return.Text) > Convert.ToInt32(txt_quantity.Text))
                {
                    MessageBox.Show("الكمية المرتجعة أكبر من الكمية المباعة");
                    txt_return.Focus();
                    return;
                }
                if (Convert.ToDecimal(txt_return.Text) > Convert.ToDecimal(Txt_QuantityStore.Text))
                {
                    MessageBox.Show("الكمية المرتجعة أكبر من الكمية بالمخزن", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_return.Focus();
                    return;
                }
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    if (txt_iD.Text == dataGridView2.Rows[i].Cells[0].Value.ToString())
                    {
                        MessageBox.Show("لا يسمح بأضافة هذا الصنف مرتين للمرتجع فى نفس الفاتورة ");
                        return;
                    }
                }
                if (txt_iD.Text != string.Empty && Convert.ToInt32(txt_return.Text) > 0)
                {

                    DataRow r = dt10.NewRow();
                    r[0] = txt_iD.Text;
                    r[1] = txt_names.Text;
                    r[2] = txt_return.Text;
                    r[3] = txt_prise.Text;
                    r[4] = (Convert.ToInt32(txt_return.Text) * Convert.ToDecimal(txt_prise.Text));
                    r[5] = Txt_IdStore.Text;
                    dt10.Rows.Add(r);
                    dataGridView2.DataSource = dt10;
                    Calc_ReturnValue();
                    txt_names.Clear();
                    txt_prise.Clear();
                    txt_quantity.Clear();
                    txt_iD.Clear();
                    Txt_IdStore.Clear();
                    txt_total.Clear();
                    txt_return.Text = "0";
                }
                else
                {
                    MessageBox.Show("من فضلك قم بتحديد الكميه المرتجعه");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }

        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {

            try
            {
                dt.Clear();
                dt = s.Select_moneyStock(Convert.ToInt32(Cmb_Stock.SelectedValue));
                if (dt.Rows.Count > 0)
                {
                    if (Convert.ToDecimal(Txt_Pay.Text) > Convert.ToDecimal(dt.Rows[0][0]))
                    {
                        MessageBox.Show("رصيد الخزنة الحالى غير كافى ");
                        return;
                    }
                }
                if (dataGridView2.Rows.Count > 0)
                {
                    if (Convert.ToInt32(Txt_Pay.Text) > 0)
                    {
                        s.add_insertStock(Convert.ToInt32(Cmb_Stock.SelectedValue), Convert.ToDecimal(Txt_Pay.Text), dateTimePicker1.Value, txt_sales.Text, "مرتجع فاتورة مستريات رقم " + txt_num.Text);
                    }

                    dt5.Clear();
                    dt5 = Suppliers.Select_SupplierTotalMoney(Convert.ToInt32(textBox1.Text));
                    decimal mno = Convert.ToDecimal(dt5.Rows[0][0]) - (Convert.ToDecimal(textBox4.Text) - Convert.ToDecimal(Txt_Pay.Text));
                    Suppliers.Update_SupplierTotalMoney(Convert.ToInt32(textBox1.Text), mno);
                    Suppliers.Add_SupplierStatmentACCount(Convert.ToInt32(textBox1.Text), Convert.ToDecimal(Txt_Pay.Text)
                        , Convert.ToDecimal(textBox4.Text), mno, "فاتورة مرتجع مشتريات رقم" + " " + txt_num.Text, dateTimePicker1.Value);
                    for (int i = 0; i < dataGridView2.Rows.Count; i++)
                    {
                        Suppliers.Add_SupplierReturn(Convert.ToInt32(txt_num.Text), Convert.ToInt32(dataGridView2.Rows[i].Cells[0].Value)
                            , Convert.ToDecimal(dataGridView2.Rows[i].Cells[3].Value)
                         , Convert.ToDecimal(dataGridView2.Rows[i].Cells[2].Value), dateTimePicker1.Value,
                         Convert.ToDecimal(dataGridView2.Rows[i].Cells[4].Value)
                        , txt_sales.Text, Convert.ToInt32(dataGridView1.CurrentRow.Cells[5].Value));

                    }
                    MessageBox.Show("تح حفظ المرتجع للفاتورة المحددة");
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
