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
        Users u = new Users();
        Branches b = new Branches();
        Stock s = new Stock();
        DataTable dt = new DataTable();

        public Frm_ReturnSupplier()
        {

            InitializeComponent();
            comboBox1.DataSource = Suppliers.select_IdPurshasing();
            comboBox1.DisplayMember = "ID";
            comboBox1.ValueMember = "ID";
            txt_sales.Text = Program.salesman;
            Permision();
            txt_pay.Enabled = false;
            txt_return.Enabled = false;
            btn_row.Enabled = false;
            btn_save.Hide();
            txt_iD.Hide();
            textBox1.Hide();
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
            txt_amount.Clear();
            txt_invo.Clear();
            txt_Name.Clear();
            txt_names.Clear();
            txt_note.Clear();
            txt_num.Clear();
            txt_pay.Clear();
            txt_prise.Clear();
            txt_quantity.Clear();
            txt_rent.Clear();
            txt_sales.Clear();
            txt_total.Clear();
            textBox4.Text = "0";
        }
        void Pay()
        {
            if (txt_invo.Text != string.Empty && txt_pay.Text != string.Empty)
            {
                decimal totainv = Convert.ToDecimal(txt_invo.Text) - Convert.ToDecimal(txt_pay.Text);
                txt_rent.Text = Math.Round(totainv, 1).ToString();
            }
        }
        void Calcalutor()
        {
            if (txt_prise.Text != string.Empty && txt_quantity.Text != string.Empty)
            {

                decimal mins = Convert.ToDecimal(txt_prise.Text) * Convert.ToInt32(txt_quantity.Text);
                txt_amount.Text = Math.Round(mins,1).ToString();
            }
        }
        void Total()
        {
            if (txt_amount.Text != string.Empty && txt_discount.Text != string.Empty)
            {
                decimal amount = Convert.ToDecimal(txt_amount.Text);
                decimal discount = Convert.ToDecimal(txt_discount.Text);
                decimal total = amount - discount;
                txt_total.Text = Math.Round(total,1).ToString();
            }
        }
        internal void Sum()
        {
            int x = int.Parse(textBox1.Text) - int.Parse(txt_return.Text);
            txt_quantity.Text = x.ToString();
        }
        public void CalctotalinvoOrder()
        {
            decimal total = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                total += Convert.ToDecimal(dataGridView1.Rows[i].Cells[6].Value);
            }
            textBox3.Text = Math.Round(total,1).ToString();
        }
     

        private void txt_sales_TextChanged(object sender, EventArgs e)
        {
        }
        private void label3_Click(object sender, EventArgs e)
        {
        }
        private void button2_Click(object sender, EventArgs e)
        {           
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            try
            {
                Clear();
                dt1 = Suppliers.Select_SupplierInformation(Convert.ToInt32(comboBox1.SelectedValue));
                dt2 = Suppliers.Select_SupplierDetailsForReturn(Convert.ToInt32(comboBox1.SelectedValue));
                foreach (DataRow dr in dt1.Rows)
                {
                    txt_num.Text = dr["ID"].ToString();
                    txt_Name.Text = dr["Name"].ToString();
                    txt_sales.Text = Program.salesman;
                    txt_note.Text = dr["note"].ToString();
                    txt_invo.Text = dr["Total_Invoic"].ToString();
                    txt_pay.Text = dr["pay"].ToString();
                    txt_rent.Text = dr["rent"].ToString();
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
            try
            {
                btn_row.Enabled = true;
                txt_iD.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_names.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txt_prise.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txt_amount.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txt_discount.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txt_total.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                Sum();
                txt_return.Enabled = true;               
            }
            catch
            {
                return;
            }
        }

        private void btn_row_Click(object sender, EventArgs e)
        {
            try

            {
                //btn_close.Enabled=false;
                btn_save.Show();
                if (Convert.ToInt32(txt_return.Text) > Convert.ToInt32(textBox1.Text))
                {
                    MessageBox.Show("الكمية المرتجعة أكبر من الكمية المباعة");
                    txt_return.Text = "0";
                    Sum();
                    Calcalutor();
                    Total();
                    return;
                }
                if (txt_iD.Text != string.Empty)
                {

                    dataGridView1.CurrentRow.Cells[2].Value = txt_prise.Text;
                    dataGridView1.CurrentRow.Cells[3].Value = txt_quantity.Text;
                    dataGridView1.CurrentRow.Cells[4].Value = txt_amount.Text;
                    dataGridView1.CurrentRow.Cells[5].Value = txt_discount.Text;
                    dataGridView1.CurrentRow.Cells[6].Value = txt_total.Text;

                    Suppliers.Add_SupplierReturn(Convert.ToInt32(txt_num.Text), Convert.ToInt32(txt_iD.Text),Convert.ToDecimal(txt_prise.Text)
                        ,Convert.ToDecimal(txt_return.Text),dateTimePicker1.Value,Convert.ToDecimal(txt_prise.Text)* Convert.ToDecimal(txt_return.Text)
                        ,txt_sales.Text,Convert.ToInt32(dataGridView1.CurrentRow.Cells[7].Value));

                    MessageBox.Show("تم تعديل الصنف بنجاح");


                    CalctotalinvoOrder();
                    Pay();
                    //textBox3.Text= dataGridView2.CurrentRow.Cells[0].Value.ToString();

                    txt_pay.Enabled = true;
                    txt_amount.Clear();
                    txt_names.Clear();
                    txt_prise.Clear();
                    txt_quantity.Clear();
                    txt_iD.Clear();
                    txt_discount.Text = "0";
                    txt_return.Text = "0";
                    txt_total.Clear();
                    textBox4.Text = "0";
                    textBox1.Text = "0";
                    txt_pay.Focus();
                    txt_pay.SelectAll();
                }
                else
                {
                    MessageBox.Show("من فضلك قم بتحديد الكميه المرتجعه");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txt_return_KeyUp(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(txt_return.Text) > 0)
            {
                txt_discount.Text = "0";
            }
            Sum();
            Calcalutor();
            Total();
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
            Sum();
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
            if (txt_pay.Text == "")
            {
                txt_pay.Text = "0";
                Pay();
            }
        }

        private void txt_invo_KeyUp(object sender, KeyEventArgs e)
        {
            Pay();
        }

        private void txt_rent_KeyUp(object sender, KeyEventArgs e)
        {
            Pay();
        }
    }
}
