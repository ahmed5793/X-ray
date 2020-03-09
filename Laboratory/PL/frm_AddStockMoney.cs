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
    public partial class frm_AddStockMoney : Form
    {
        Stock s = new Stock();
        DataTable dt = new DataTable();
        public frm_AddStockMoney()
        {
            InitializeComponent();
            cmb_Stock.DataSource = s.Compo_Stock();
            cmb_Stock.DisplayMember = "Name_Stock";
            cmb_Stock.ValueMember = "ID_Stock";
            txt_name.Text = Program.salesman;
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
            
        }

        private void cmb_Stock_SelectedIndexChanged(object sender, EventArgs e)
        {
           
         
        }

        private void frm_AddStockMoney_Load(object sender, EventArgs e)
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

        private void cmb_Stock_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dt.Clear();
            dt = s.Select_moneyStock(Convert.ToInt32(cmb_Stock.SelectedValue));
            if (dt.Rows.Count > 0)
            {

                txt_CurrentBalance.Text = dt.Rows[0][0].ToString();

            }
        }

        private void Btn_UpdateShift_Click(object sender, EventArgs e)
        {            
                try
                {
                if (cmb_Stock.Items.Count >= 1)
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
                        s.add_insertStock(Convert.ToInt32(cmb_Stock.SelectedValue), Convert.ToDecimal(txt_addbalance.Text), Date_insert.Value, txt_name.Text, txt_reason.Text);
                        MessageBox.Show("تم إضافة الرصيد للخزنة المحددة");
                        clear();

                    }
                    else
                    {
                        MessageBox.Show("تم إلغاء الايداع");
                        clear();

                    }
                }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            
        }
    }
   
}
