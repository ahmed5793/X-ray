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
    public partial class Frm_TransfairStockToBank : Form
    {
        Stock s = new Stock();
        Bank b = new Bank();
        DataTable dt = new DataTable();
        public Frm_TransfairStockToBank()
        {
            InitializeComponent();
            cmb_StockFrom.DataSource = s.Compo_Stock();
            cmb_StockFrom.DisplayMember = "Treasury_name";
            cmb_StockFrom.ValueMember = "id_Treasury";
            Cmb_StrockTo.DataSource = b.Compo_Bank();
            Cmb_StrockTo.DisplayMember = "BANK_NAME";
            Cmb_StrockTo.ValueMember = "ID_BANK";

            dt = s.Select_moneyStock(Convert.ToInt32(cmb_StockFrom.SelectedValue));
            if (dt.Rows.Count > 0)
            {
                txt_CurrentBalance1.Text = dt.Rows[0][0].ToString();
            }
            dt = b.Select_moneyBank(Convert.ToInt32(Cmb_StrockTo.SelectedValue));
            if (dt.Rows.Count > 0)
            {
                textBox1.Text = dt.Rows[0][0].ToString();
            }   
        }
        


        private void Frm_TransfairStockToBank_Load(object sender, EventArgs e)
        {

        }

        private void Cmb_StockFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt = s.Select_moneyStock(Convert.ToInt32(cmb_StockFrom.SelectedValue));
            if (dt.Rows.Count > 0)
            {
                txt_CurrentBalance1.Text = dt.Rows[0][0].ToString();
            }   
        }

        private void Cmb_StrockTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt = b.Select_moneyBank(Convert.ToInt32(Cmb_StrockTo.SelectedValue));
            if (dt.Rows.Count > 0)
            {
                textBox1.Text = dt.Rows[0][0].ToString();
            }
        }
        void clear()
        {
            txt_addbalance.Clear();
            txt_CurrentBalance1.Text = "0";
            txt_name.Clear();
            txt_CurrentBalance1.Text = "0";
   
        }
        private void Btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_StockFrom.Text=="")
                {
                    return;
                }
             else   if (Cmb_StrockTo.Text=="")
                {
                    return;
                }  
           else     if (txt_addbalance.Text == "")
                {
                    MessageBox.Show("لا بد من ان يكون التحويل اكبر من الصفر");
                    txt_addbalance.Focus();
                    return;
                }
                else if (txt_name.Text == "")
                {
                    MessageBox.Show("يرجى تحديد إسم ");
                    txt_name.Focus();
                    return;
                }
                else if (Convert.ToDecimal(txt_addbalance.Text) > Convert.ToDecimal(txt_CurrentBalance1.Text))
                {
                    MessageBox.Show("   المبلغ المراد تحويلة اكبر من الرصيد الحالى");
                    txt_addbalance.Focus();
                    return;

                }
                 if (MessageBox.Show("هل تريد حفظ التحويل", "عملية التحويل", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    s.AddTransfairStockToBAnk(Convert.ToDecimal(txt_addbalance.Text), Date_insert.Value, cmb_StockFrom.SelectedValue.ToString(), Cmb_StrockTo.SelectedValue.ToString(), txt_name.Text) ;

                    MessageBox.Show("تم إضافة الرصيد للخزنة المحددة");

                    clear();



                }
                else
                {
                    MessageBox.Show("تم إلغاء التحويل");
                    clear();
                    //SelectBankmoney();
                    //SelectStockmoney();

                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Txt_addbalance_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_addbalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)&&e.KeyChar!=8&& e.KeyChar!= Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                e.Handled = true;
            }
            else if (e.KeyChar=='.'&&txt_addbalance.Text.ToString().IndexOf('.')>-1)
            {
                e.Handled = true;
            }
        }
    }
}
