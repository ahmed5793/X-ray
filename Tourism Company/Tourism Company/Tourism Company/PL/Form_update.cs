using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Tourism_Company.BL;

namespace Tourism_Company.PL
{
    public partial class Form_update : Form
    {

        private static Form_update book;
        static void formclosed(object sender, FormClosedEventArgs e)
        {

            book = null;

        }
        internal static Form_update geter
        {
            get
            {
                if (book == null)
                {
                    book = new Form_update();
                    book.FormClosed += new FormClosedEventHandler(formclosed);
                }
                return book;
            }
        }
        internal void DiscountBasics()
        {
            if (txt_Basic.Text != "")
            {
                decimal basics = Convert.ToDecimal(txt_Basic.Text);
                decimal coummetion = Convert.ToDecimal(txt_discountCommution.Text);
                decimal money = (basics * (coummetion / 100));
                txt_CommutionMoney.Text = money.ToString();
            }
        }
        internal void moneyBasics()
        {
            if (txt_Basic.Text != "")
            {
                decimal basics = Convert.ToDecimal(txt_Basic.Text);
                decimal coummetion = Convert.ToDecimal(txt_discountCommution.Text);
                decimal money = coummetion;
                txt_CommutionMoney.Text = money.ToString();
            }
        }
        internal void rent()
        {
            if (txt_PriceClient.Text != "")
            {
                decimal priceClient = Convert.ToDecimal(txt_PriceClient.Text);
                decimal pay = Convert.ToDecimal(txt_pay.Text);
                decimal rent = priceClient - pay;
                txt_rent.Text = rent.ToString();
            }
        }
        Plane p = new Plane();
        Bank ba = new Bank();
        public Form_update()
        {
            InitializeComponent();
            if (book == null)
                book = this;
            cmb_plane.DataSource = p.SelectPlaneGender();
            cmb_plane.DisplayMember = "planGender";
            cmb_plane.ValueMember = "ID";
            textBox1.Hide();

        }

        private void Form_update_Load(object sender, EventArgs e)
        {
            rdb_company.Enabled = false;
            rdb_customer.Enabled = false;
       
        }

        private void Txt_numTraiple_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && txt_numTraiple.Text.ToString().IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar((CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)))
            {
                e.Handled = true;
            }
        }

        private void Txt_Basic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && txt_numTraiple.Text.ToString().IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar((CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)))
            {
                e.Handled = true;
            }
        }

        private void Txt_Total_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && txt_numTraiple.Text.ToString().IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar((CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)))
            {
                e.Handled = true;
            }
        }

        private void Txt_discountCommution_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && txt_numTraiple.Text.ToString().IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar((CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)))
            {
                e.Handled = true;
            }
        }

        private void Txt_PriceClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && txt_numTraiple.Text.ToString().IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar((CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)))
            {
                e.Handled = true;
            }
        }

        private void Txt_pay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && txt_numTraiple.Text.ToString().IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar((CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)))
            {
                e.Handled = true;
            }
        }
        Booking b = new Booking();
        internal void clear()
        {
            txt_arrival.Clear();
            txt_Basic.Clear();
            txt_CommutionMoney.Clear();
            txt_discountCommution.Clear();
            txt_numTraiple.Clear();
            txt_out.Clear();
            txt_pay.Clear();
            txt_PriceClient.Clear();
            txt_rent.Clear();
            txt_Total.Clear();
            txt_company.Clear();
            txt_client.Clear();
            txt_num.Clear();
           

        }

        Form_AllTicket at = new Form_AllTicket();
        private void Btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdb_customer.Checked==true)
                    
                {

                    b.UpdateClientBooking(Convert.ToInt32(txt_num.Text), date_booking.Value, Convert.ToInt32(cmb_plane.SelectedValue)
                    , txt_out.Text, Convert.ToInt64(txt_numTraiple.Text), date_traiple.Value, txt_arrival.Text, Convert.ToDecimal(txt_Basic.Text)
                    , Convert.ToDecimal(txt_Total.Text), Convert.ToDecimal(txt_discountCommution.Text), Convert.ToDecimal(txt_CommutionMoney.Text)
                    , Convert.ToDecimal(txt_PriceClient.Text), Convert.ToDecimal(txt_pay.Text), Convert.ToDecimal(txt_rent.Text),txt_note.Text,Convert.ToInt32(textBox1.Text));


                    b.DeleteInsertBnak(Convert.ToInt32(textBox1.Text), date_booking.Value, Convert.ToDecimal(txt_Total.Text) - Convert.ToDecimal(txt_CommutionMoney.Text)) ;


                    ba.add_insertBank(Convert.ToInt32(textBox1.Text), Convert.ToDecimal(txt_Total.Text) - Convert.ToDecimal(txt_CommutionMoney.Text), date_booking.Value, txt_client.Text, "حجز تذكرة إلى " + "" + txt_client, "");


                    b.Update_Arba7(Convert.ToInt32(txt_num.Text), date_booking.Value, txt_client.Text, Convert.ToDecimal(txt_CommutionMoney.Text), Convert.ToDecimal(txt_PriceClient.Text), Convert.ToDecimal(txt_Total.Text));
                    MessageBox.Show("تم تعديل البيانات بنجاح ", "عمليه التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                    clear();
                          Form_AllTicket.geter.dataGridView1.DataSource= b.selectClientTicket();
                }
                else if(rdb_company.Checked==true)
                {

                    b.UpdateCompanyBooking(Convert.ToInt32(txt_num.Text), date_booking.Value, Convert.ToInt32(cmb_plane.SelectedValue)
                    , txt_out.Text, Convert.ToInt64(txt_numTraiple.Text), date_traiple.Value, txt_arrival.Text, Convert.ToDecimal(txt_Basic.Text)
                    , Convert.ToDecimal(txt_Total.Text), Convert.ToDecimal(txt_discountCommution.Text), Convert.ToDecimal(txt_CommutionMoney.Text)
                    , Convert.ToDecimal(txt_PriceClient.Text), Convert.ToDecimal(txt_pay.Text), Convert.ToDecimal(txt_rent.Text), txt_note.Text, Convert.ToInt32(textBox1.Text));

                    b.DeleteInsertBnak(Convert.ToInt32(textBox1.Text), date_booking.Value, Convert.ToDecimal(txt_Total.Text) - Convert.ToDecimal(txt_CommutionMoney.Text));

                    ba.add_insertBank(Convert.ToInt32(textBox1.Text), Convert.ToDecimal(txt_Total.Text) - Convert.ToDecimal(txt_CommutionMoney.Text), date_booking.Value, txt_client.Text, "حجز تذكرة إلى " + "" + txt_company.Text , "");


                    b.Update_Arba7(Convert.ToInt32(txt_num.Text), date_booking.Value, txt_client.Text + "التابع لشركة " + txt_company.Text, Convert.ToDecimal(txt_CommutionMoney.Text), Convert.ToDecimal(txt_PriceClient.Text), Convert.ToDecimal(txt_Total.Text));

                    MessageBox.Show("تم تعديل البيانات بنجاح ", "عمليه التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    clear();
                    Form_AllTicket.geter.dataGridView1.DataSource = b.selectClientTicket();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        private void Txt_Basic_TextChanged(object sender, EventArgs e)
        {
            if (txt_Basic.Text == "")
            {
                txt_Basic.Text = "0";
            }
        }

        private void Txt_pay_TextChanged(object sender, EventArgs e)
        {
            if (txt_pay.Text == "")
            {
                txt_pay.Text = "0";
            }
        }

        private void Txt_discountCommution_TextChanged(object sender, EventArgs e)
        {
            if (txt_discountCommution.Text == "")
            {
                txt_discountCommution.Text = "0";
            }
        }

        private void Txt_Total_TextChanged(object sender, EventArgs e)
        {
            if (txt_Total.Text == "")
            {
                txt_Total.Text = "0";
            }
        }

        private void Txt_PriceClient_TextChanged(object sender, EventArgs e)
        {
            if (txt_PriceClient.Text == "")
            {
                txt_PriceClient.Text = "0";
            }
        }

        private void Txt_CommutionMoney_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {


                if (rdb_discount.Checked == true)
                {

                    DiscountBasics();
                }

                else if (rdb_money.Checked == true)
                {

                    moneyBasics();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Txt_discountCommution_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {


                if (rdb_discount.Checked == true)
                {

                    DiscountBasics();
                }

                else if (rdb_money.Checked == true)
                {

                    moneyBasics();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Txt_Basic_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {


                if (rdb_discount.Checked == true)
                {

                    DiscountBasics();
                }

                else if (rdb_money.Checked == true)
                {

                    moneyBasics();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Txt_PriceClient_KeyUp(object sender, KeyEventArgs e)
        {
            rent();
        }

        private void Txt_pay_KeyUp(object sender, KeyEventArgs e)
        {
            rent();
        }

        private void Txt_rent_KeyUp(object sender, KeyEventArgs e)
        {
            rent();
        }

        private void Txt_rent_TextChanged(object sender, EventArgs e)
        {
            if (txt_rent.Text == "")
            {
                txt_rent.Text = "0";
            }
        }

        private void Txt_CommutionMoney_TextChanged(object sender, EventArgs e)
        {
            if (txt_CommutionMoney.Text == "")
            {
                txt_CommutionMoney.Text = "0";
            }
        }

        private void Rdb_discount_CheckedChanged(object sender, EventArgs e)
        {
            txt_CommutionMoney.Text = "0";
            txt_discountCommution.Text = "0";

        }

        private void Rdb_money_CheckedChanged(object sender, EventArgs e)
        {
            txt_CommutionMoney.Text = "0";
            txt_discountCommution.Text = "0";

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
    }

