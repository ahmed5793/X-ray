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
    public partial class Frm_addStocMoney : Form
    {
        Stock s = new Stock();
        DataTable dt = new DataTable();
        public Frm_addStocMoney()
        {
            InitializeComponent();
            cmb_Stock.DataSource = s.Compo_Stock();
            cmb_Stock.DisplayMember = "Treasury_name";
            cmb_Stock.ValueMember = "id_Treasury";

            dt = s.Select_moneyStock(Convert.ToInt32(cmb_Stock.SelectedValue));
            if (dt.Rows.Count > 0)
            {
                txt_CurrentBalance.Text = dt.Rows[0][0].ToString();
            }

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Cmb_Stock_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt = s.Select_moneyStock(Convert.ToInt32(cmb_Stock.SelectedValue));
            if (dt.Rows.Count > 0)
            {

                txt_CurrentBalance.Text = dt.Rows[0][0].ToString();

            }

        }

        private void Txt_CurrentBalance_TextChanged(object sender, EventArgs e)
        {
            //if (txt_CurrentBalance.Text == "")
            //{
            //    txt_CurrentBalance.Text = "0";
            //}

        }

        void add_money()
        {
          
            if (dt.Rows.Count <=0)
            {
                s.add_stockData(Convert.ToInt32(cmb_Stock.SelectedValue));
                dt = s.Select_moneyStock(Convert.ToInt32(cmb_Stock.SelectedValue));

                txt_CurrentBalance.Text = dt.Rows[0][0].ToString();
            }
            else
            {
                dt = s.Select_moneyStock(Convert.ToInt32(cmb_Stock.SelectedValue));

                txt_CurrentBalance.Text = dt.Rows[0][0].ToString();
            }
        }
        void clear()
        {
            txt_addbalance.Clear();
            txt_CurrentBalance.Text="0";
            txt_name.Clear();
            textBox1.Clear();
            txt_reason.Clear();
        }
        private void Btn_save_Click(object sender, EventArgs e)
        {
            if (cmb_Stock.Items.Count>=1)
            {
                try
                {
                    if (txt_addbalance.Text == "")
                    {
                        MessageBox.Show("لا بد من ان يكون الايداع اكبر من الصفر");
                        txt_addbalance.Focus();
                    }
                    else if (txt_name.Text == "")
                    {
                        MessageBox.Show("يرجى تحديد إسم المودع");
                        txt_name.Focus();
                    }
                    else if (MessageBox.Show("هل تريد حفظ الايداع", "عملية الايداع", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        s.add_insertStock(Convert.ToInt32(cmb_Stock.SelectedValue), Convert.ToDecimal(txt_addbalance.Text), Date_insert.Value, txt_name.Text, textBox1.Text, txt_reason.Text);
                        MessageBox.Show("تم إضافة الرصيد للخزنة المحددة");
                        clear();
                    
                    }
                    else
                    {
                        MessageBox.Show("تم إلغاء الايداع");
                        clear();
                    
                    }

                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void Txt_addbalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)&&e.KeyChar!=8 && e.KeyChar!= Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                e.Handled = true;
            }
            else if (e.KeyChar=='.'&& txt_addbalance.Text.ToString().IndexOf('.')>-1)
            {
                e.Handled = true;
            }
        }

        private void Frm_addStocMoney_Load(object sender, EventArgs e)
        {

        }
    }
}
