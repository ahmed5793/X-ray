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
    public partial class Frm_StockPull : Form
    {
        Stock s = new Stock();
        DataTable dt = new DataTable();
        public Frm_StockPull()
        {

            InitializeComponent();
       
            cmb_Stock.DataSource = s.Compo_Stock();
            cmb_Stock.DisplayMember = "Treasury_name";
            cmb_Stock.ValueMember = "id_Treasury";
      
            dt.Clear();
            dt = s.Select_moneyStock(Convert.ToInt32(cmb_Stock.SelectedValue));
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
            
            txt_reason.Clear();
        }
        private void btn_save_Click(object sender, EventArgs e)
        {

            try
            {
                if (cmb_Stock.Items.Count >= 1)
                {


                    if (txt_addbalance.Text == "0")
                    {
                        MessageBox.Show("لا بد من ان يكون السحب اكبر من الصفر");
                        txt_addbalance.Focus();
                    }
                    if (txt_name.Text == "")
                    {
                        MessageBox.Show("يرجى تحديد إسم الساحب");
                        txt_name.Focus();
                        return;
                    }
                    if (Convert.ToDecimal(txt_addbalance.Text) > Convert.ToDecimal(txt_CurrentBalance.Text))
                    {
                        MessageBox.Show("هذا المبلغ اكبر من الرصيد الحالى");
                        txt_addbalance.Focus();
                        return;

                    }
                    if (MessageBox.Show("هل تريد حفظ السحب", "عملية السحب", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        s.Add_StockPull(Convert.ToInt32(cmb_Stock.SelectedValue), Convert.ToDecimal(txt_addbalance.Text), Date_insert.Value, txt_name.Text, txt_reason.Text);
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
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
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
    }
}
