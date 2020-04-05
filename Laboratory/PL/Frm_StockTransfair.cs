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
  
    public partial class Frm_StockTransfair : Form
    {
        Stock s = new Stock();
        DataTable dt = new DataTable();
        public Frm_StockTransfair()
        {
            InitializeComponent();
            Function();
        }
        void Function()
        {
            try
            {
                cmb_StockFrom.DataSource = s.Compo_Stock();
                cmb_StockFrom.DisplayMember = "Name_Stock";
                cmb_StockFrom.ValueMember = "ID_Stock";
                Cmb_StrockTo.DataSource = s.Compo_Stock();
                Cmb_StrockTo.DisplayMember = "Name_Stock";
                Cmb_StrockTo.ValueMember = "ID_Stock";
                txt_name.Text = Program.salesman;
                dt.Clear();
                dt = s.Select_moneyStock(Convert.ToInt32(cmb_StockFrom.SelectedValue));
                if (dt.Rows.Count > 0)
                {
                    txt_CurrentBalance1.Text = dt.Rows[0][0].ToString();
                }
                dt.Clear();
                dt = s.Select_moneyStock(Convert.ToInt32(Cmb_StrockTo.SelectedValue));
                if (dt.Rows.Count > 0)
                {
                    textBox1.Text = dt.Rows[0][0].ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void btn_save_Click(object sender, EventArgs e)
        {

        }

        private void txt_addbalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == '.' && txt_addbalance.Text.ToString().IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cmb_StrockTo_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
        void clear()
        {
            txt_addbalance.Clear();
            txt_CurrentBalance1.Text = "0";
            textBox1.Text = "0";
            txt_reason.Clear();
        }
        private void cmb_StockFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void Frm_StockTransfair_Load(object sender, EventArgs e)
        {

        }

        private void cmb_StockFrom_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dt.Clear();
            dt = s.Select_moneyStock(Convert.ToInt32(cmb_StockFrom.SelectedValue));
            if (dt.Rows.Count > 0)
            {

                txt_CurrentBalance1.Text = dt.Rows[0][0].ToString();
            }
        }

        private void Cmb_StrockTo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dt.Clear();
            dt = s.Select_moneyStock(Convert.ToInt32(Cmb_StrockTo.SelectedValue));
            if (dt.Rows.Count > 0)
            {
                textBox1.Text = dt.Rows[0][0].ToString();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_StockFrom.Text == "")
                {
                    MessageBox.Show("لا بد من تحديد خزنة المحول منها");
                    return;
                }
                if (Cmb_StrockTo.Text == "")
                {
                    MessageBox.Show("لا بد من تحديد خزنة المحول إليها");
                    return;
                }
                if (txt_addbalance.Text == ""|| txt_addbalance.Text=="0")
                {
                    MessageBox.Show("لا بد من ان يكون التحويل اكبر من الصفر");
                    txt_addbalance.Focus();
                    return;
                }
                if (txt_name.Text == "")
                {
                    MessageBox.Show("يرجى تحديد إسم ");
                    txt_name.Focus();
                    return;
                }
                if (Convert.ToDecimal(txt_addbalance.Text) > Convert.ToDecimal(txt_CurrentBalance1.Text))
                {
                    MessageBox.Show("   المبلغ المراد تحويلة اكبر من الرصيد الحالى");
                    txt_addbalance.Focus();
                    return;
                }
                if (MessageBox.Show("هل تريد حفظ التحويل", "عملية التحويل", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                 s.Add_StockTransfair(Convert.ToDecimal(txt_addbalance.Text), Date_insert.Value, Convert.ToInt32(cmb_StockFrom.SelectedValue),
                 cmb_StockFrom.Text, Convert.ToInt32(Cmb_StrockTo.SelectedValue), Cmb_StrockTo.Text, txt_name.Text, txt_reason.Text);
                    s.Add_StockPull(Convert.ToInt32(cmb_StockFrom.SelectedValue), Convert.ToDecimal(txt_addbalance.Text), Date_insert.Value, 
                                     txt_name.Text,"تحويل رصيد الي الخزنة"+" "+ Cmb_StrockTo.Text +" "+ txt_reason.Text);
                    s.add_insertStock(Convert.ToInt32(Cmb_StrockTo.SelectedValue), Convert.ToDecimal(txt_addbalance.Text), Date_insert.Value,
                                      txt_name.Text,"رصيد محول من خزنة "+" "+cmb_StockFrom.Text + " " + txt_reason.Text);

                    MessageBox.Show("تم إضافة الرصيد للخزنة المحددة");
                }
                else
                {
                    MessageBox.Show("تم إلغاء التحويل");
                    //updateMoneyFrom();
                    //UpdateMoneyTo();
                }
                clear();

            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
                MessageBox.Show(EX.StackTrace);
            }
        }

        private void txt_CurrentBalance1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_addbalance_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
