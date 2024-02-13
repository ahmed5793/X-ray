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
using System.Globalization;

namespace Tourism_Company.PL
{
    public partial class Form_Booking : Form
    {
       
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
            txt_name.Clear();
            txt_num.Text = b.clienttLastID().Rows[0][0].ToString();

        }

        Customer c = new Customer();
        Company co = new Company();
        Booking b = new Booking();
        Bank ba = new Bank();
        Stock s = new Stock();
        private static Form_Booking book;
        static void formclosed(object sender, FormClosedEventArgs e)
        {

            book = null;

        }
        internal static Form_Booking geter
        {
            get
            {
                if (book == null)
                {
                    book = new Form_Booking();
                    book.FormClosed += new FormClosedEventHandler(formclosed);
                }
                return book;
            }
        }
        public Form_Booking()
        {
            InitializeComponent();
            txt_name.Hide();
            if (book == null)
                book = this;
            btn_addCoum.Enabled = false;
            cmb_customer.DataSource = c.CompoCustomer();
            cmb_customer.DisplayMember = "Name";
            cmb_customer.ValueMember = "ID";
            cmb_company.DataSource = co.CompoCompany();
            cmb_company.DisplayMember = "Name";
            cmb_company.ValueMember = "ID";
            comboBox1.DataSource = ba.Compo_Bank();
            comboBox1.DisplayMember = "BANK_NAME";
            comboBox1.ValueMember = "ID_BANK";
            cmb_Stock.DataSource = s.Compo_Stock();
            cmb_Stock.DisplayMember = "Treasury_name";
            cmb_Stock.ValueMember = "id_Treasury";
            cmb_company.Enabled = false;

            txt_num.Text = b.clienttLastID().Rows[0][0].ToString();
        

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
        Plane p = new Plane();
        private void Form_Booking_Load(object sender, EventArgs e)
        {
            cmb_plane.DataSource = p.SelectPlaneGender();
            cmb_plane.DisplayMember = "planGender";
            cmb_plane.ValueMember = "ID";
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rdb_company.Checked == true)
                {
                    txt_num.Text = b.CompanytLastID().Rows[0][0].ToString();
                    cmb_company.Enabled = true;
                    btn_addCoum.Enabled = true;
                    cmb_customer.Hide();
                    btn_addCustomer.Hide();
                    txt_name.Show();

                }
                else if (rdb_customer.Checked == true)
                {
                    txt_num.Text = b.clienttLastID().Rows[0][0].ToString();
                    cmb_company.Enabled = false;
                    btn_addCoum.Enabled = false;
                    cmb_customer.Show();
                    btn_addCustomer.Show();
                    txt_name.Hide();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Txt_Basic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && txt_Basic.Text.ToString().IndexOf('.') > -1)
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
            if (e.KeyChar == '.' && txt_Total.Text.ToString().IndexOf('.') > -1)
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
            if (e.KeyChar == '.' && txt_discountCommution.Text.ToString().IndexOf('.') > -1)
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
            if (e.KeyChar == '.' && txt_PriceClient.Text.ToString().IndexOf('.') > -1)
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
            if (e.KeyChar == '.' && txt_pay.Text.ToString().IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar((CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)))
            {
                e.Handled = true;
            }
        }

        private void Txt_rent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && txt_rent.Text.ToString().IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar((CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)))
            {
                e.Handled = true;
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

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txt_CommutionMoney.Text = "0";
            txt_discountCommution.Text = "0";

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

        private void Rdb_money_CheckedChanged(object sender, EventArgs e)
        {
            txt_CommutionMoney.Text = "0";
            txt_discountCommution.Text = "0";
        }

        private void Txt_discountCommution_TextChanged(object sender, EventArgs e)
        {
            if (txt_discountCommution.Text == "")
            {
                txt_discountCommution.Text = "0";
            }
        }

        private void Txt_Basic_TextChanged(object sender, EventArgs e)
        {
            if (txt_Basic.Text == "")
            {
                txt_Basic.Text = "0";
            }

        }

        private void Date_traiple_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Txt_pay_TextChanged(object sender, EventArgs e)
        {
            if (txt_pay.Text == "")
            {
                txt_pay.Text = "0";
            }
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

        private void Txt_PriceClient_TextChanged(object sender, EventArgs e)
        {
            if (txt_PriceClient.Text == "")
            {
                txt_PriceClient.Text = "0";
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

        private void Btn_addCoum_Click(object sender, EventArgs e)
        {


            Form_Company p = new Form_Company();
            p.ShowDialog();
        }

        private void Btn_addCustomer_Click(object sender, EventArgs e)
        {
            Form_Customer c = new Form_Customer();
            c.ShowDialog();
        }

        private void Rdb_customer_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Total_TextChanged(object sender, EventArgs e)
        {
            if (txt_Total.Text == "")
            {
                txt_Total.Text = "0";
            }
        }
        DataTable dt = new DataTable();
        private void Btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_Stock.Text=="")
                {
                    MessageBox.Show("الرجاء قم بتسجيل الخزنة ");
                    return;
                }
                if (cmb_plane.Text == "")
                {
                    MessageBox.Show("الرجاء قم بتسجيل نوع الطيران ");
                    return;
                }
                if (comboBox1.Text == "")
                {

                    MessageBox.Show("الرجاء قم بتسجيل البنك ");
                    return;
                }

                if (rdb_customer.Checked == true)
                {




                    if (txt_arrival.Text == "" && txt_out.Text == "")
                    {
                        MessageBox.Show("من فضلك قم باادخال مدينه المغادرة او مدينة الوصول ");
                        return;
                    }
                    else if (txt_numTraiple.Text == "")
                    {
                        MessageBox.Show("من فضلك قم باادخال رقم الرحله  ");
                        return;
                    }
                    dt = c.ValidetCustomer(Convert.ToInt32(cmb_customer.SelectedValue));
                    if (dt.Rows.Count == 0)
                    {

                        MessageBox.Show("عزيزي المستخدم يرجي العلم بان اسم العميل غير موجود مسبقا الرجاء التسجيل اولا  ");
                        return;
                    }


                    b.AddClientBooking(Convert.ToInt32(txt_num.Text), date_booking.Value, Convert.ToInt32(cmb_customer.SelectedValue), Convert.ToInt32(cmb_plane.SelectedValue)
                    , txt_out.Text, Convert.ToInt64(txt_numTraiple.Text), date_traiple.Value, txt_arrival.Text, Convert.ToDecimal(txt_Basic.Text)
                    , Convert.ToDecimal(txt_Total.Text), Convert.ToDecimal(txt_discountCommution.Text), Convert.ToDecimal(txt_CommutionMoney.Text)
                    , Convert.ToDecimal(txt_PriceClient.Text), Convert.ToDecimal(txt_pay.Text), Convert.ToDecimal(txt_rent.Text),txt_note.Text, Convert.ToInt32(comboBox1.SelectedValue));
                    s.add_insertStock(Convert.ToInt32(cmb_Stock.SelectedValue), Convert.ToDecimal(txt_pay.Text), date_booking.Value, cmb_customer.Text, "تذكرة طيران", "حجز تذكرة إلى " + "" + cmb_customer.Text);
                    ba.add_insertBank(Convert.ToInt32(comboBox1.SelectedValue), Convert.ToDecimal(txt_Total.Text) - Convert.ToDecimal(txt_CommutionMoney.Text), date_booking.Value, cmb_customer.Text, "حجز تذكرة إلى " +"" + cmb_customer.Text , "");
                    b.Add_Arba7(Convert.ToInt32(txt_num.Text), date_booking.Value, cmb_customer.Text, Convert.ToDecimal(txt_CommutionMoney.Text), Convert.ToDecimal(txt_PriceClient.Text), Convert.ToDecimal(txt_Total.Text));
                    MessageBox.Show("تم حفظ الحجز بنجاح ", "عمليه الاضافه", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    clear();

                }
                //----------------------------------------------------------
                else if (rdb_company.Checked == true)
                {



                    if (txt_arrival.Text == "" && txt_out.Text == "")
                    {
                        MessageBox.Show("من فضلك قم باادخال مدينه المغادرة او مدينة الوصول ");
                        return;
                    }
                    else if (txt_numTraiple.Text == "")
                    {
                        MessageBox.Show("من فضلك قم باادخال رقم الرحله  ");
                        return;
                    }




                    dt = c.ValidetCustomer(Convert.ToInt32(cmb_customer.SelectedValue));
                    if (dt.Rows.Count == 0)
                    {


                        MessageBox.Show("عزيزي المستخدم يرجي العلم بان اسم الشركة غير موجود مسبقا الرجاء التسجيل اولا  ");
                        return;
                    }



                    b.AddCompanyBooking(date_booking.Value,txt_name.Text, Convert.ToInt32(cmb_plane.SelectedValue)
                     , txt_out.Text, Convert.ToInt64(txt_numTraiple.Text), date_traiple.Value, txt_arrival.Text, Convert.ToDecimal(txt_Basic.Text)
                     , Convert.ToDecimal(txt_Total.Text), Convert.ToDecimal(txt_discountCommution.Text), Convert.ToDecimal(txt_CommutionMoney.Text)
                     , Convert.ToDecimal(txt_PriceClient.Text), Convert.ToDecimal(txt_pay.Text), Convert.ToDecimal(txt_rent.Text), Convert.ToInt32(cmb_company.SelectedValue), Convert.ToInt32(txt_num.Text), txt_note.Text, Convert.ToInt32(comboBox1.SelectedValue));

                    s.add_insertStock(Convert.ToInt32(cmb_Stock.SelectedValue), Convert.ToDecimal(txt_pay.Text), date_booking.Value, txt_name.Text, "تذكرة طيران", txt_name.Text + "التابع لشركة " + cmb_company.Text);

                    ba.add_insertBank(Convert.ToInt32(comboBox1.SelectedValue),Convert.ToDecimal(txt_Total.Text)-Convert.ToDecimal( txt_CommutionMoney.Text),date_booking.Value,cmb_company.Text,"حجز تذكرة لشركة"+""+cmb_company.Text,".");
                    b.Add_Arba7(Convert.ToInt32(txt_num.Text), date_booking.Value, txt_name.Text + "التابع لشركة "+cmb_company.Text, Convert.ToDecimal(txt_CommutionMoney.Text), Convert.ToDecimal(txt_PriceClient.Text), Convert.ToDecimal(txt_Total.Text));

                    MessageBox.Show("تم حفظ الحجز بنجاح ", "عمليه الاضافه", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    clear();
                    rdb_customer.Focus();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Button3_Click(object sender, EventArgs e)
        {
           
        }

        private void Txt_rent_TextChanged(object sender, EventArgs e)
        {
            if (txt_rent.Text=="")
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
    }
}