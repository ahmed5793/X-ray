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
    public partial class Frm_BankPull : Form
    {
        Bank b = new Bank();
        DataTable dt = new DataTable();
        public Frm_BankPull()
        {
            InitializeComponent();
            cmb_Stock.DataSource = b.Compo_Bank();
            cmb_Stock.DisplayMember = "BANK_NAME";
            cmb_Stock.ValueMember = "ID_BANK";
            dt = b.Select_moneyBank(Convert.ToInt32(cmb_Stock.SelectedValue));
            if (dt.Rows.Count > 0)
            {
                txt_CurrentBalance.Text = dt.Rows[0][0].ToString();
            }
        }
     
              void clear()
        {
            txt_addbalance.Clear();
            txt_CurrentBalance.Text = "0";
            txt_name.Clear();
            textBox1.Clear();
            txt_reason.Clear();
        }
        private void Frm_BankPull_Load(object sender, EventArgs e)
        {

        }

        private void Cmb_Stock_SelectedIndexChanged(object sender, EventArgs e)
        {

            //b.Add_BankData(Convert.ToInt32(cmb_Stock.SelectedValue));
            dt = b.Select_moneyBank(Convert.ToInt32(cmb_Stock.SelectedValue));
            if (dt.Rows.Count>0)
            {


           
                txt_CurrentBalance.Text = dt.Rows[0][0].ToString();
            }
        }

        private void Txt_CurrentBalance_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_addbalance_TextChanged(object sender, EventArgs e)
        {

        }

        private void Date_insert_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Txt_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_reason_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            try
            {
             
                if (txt_addbalance.Text == "")
                {
                    MessageBox.Show("من فضلك قم باادخال المبلغ المراد سحبه");
                    return;
                }

                if (cmb_Stock.Text!="")
                {


                    if (txt_addbalance.Text == "0")
                    {
                        MessageBox.Show("لا بد من ان يكون السحب اكبر من الصفر");
                        txt_addbalance.Focus();
                    }
                    else if (txt_name.Text == "")
                    {
                        MessageBox.Show("يرجى تحديد إسم الساحب");
                        txt_name.Focus();
                    }
                    else if (Convert.ToDecimal(txt_addbalance.Text) > Convert.ToDecimal(txt_CurrentBalance.Text))
                    {
                        MessageBox.Show("هذا المبلغ اكبر من الرصيد الحالى");
                        txt_addbalance.Focus();

                    }
                    else if (MessageBox.Show("هل تريد حفظ السحب", "عملية السحب", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        b.Add_BankPull(Convert.ToInt32(cmb_Stock.SelectedValue), Convert.ToDecimal(txt_addbalance.Text), Date_insert.Value, txt_name.Text, textBox1.Text, txt_reason.Text);
                        MessageBox.Show("تم سحب الرصيد من البنك المحدد");
                        clear();
                     
                    }
                    else
                    {
                        MessageBox.Show("تم إلغاء السحب");
                        clear();
                    
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Txt_addbalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)&&e.KeyChar!=8&& e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                e.Handled = true;
            }
            else if (e.KeyChar== '.'&&txt_addbalance.Text.ToString().IndexOf('.')>-1)
            {
                e.Handled = true;
            }
        }
    }
}
