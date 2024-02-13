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
    public partial class Frm_AddBankMoney : Form
    {
        Bank b = new Bank();
        DataTable dt = new DataTable();
        public Frm_AddBankMoney()
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

        private void Cmb_Stock_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void Btn_save_Click(object sender, EventArgs e)
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
                    b.add_insertBank(Convert.ToInt32(cmb_Stock.SelectedValue), Convert.ToDecimal(txt_addbalance.Text), Date_insert.Value, txt_name.Text, textBox1.Text, txt_reason.Text);
                    MessageBox.Show("تم إضافة الرصيد للبنك المحدد");
                    clear();
            
                }
                else
                {
                    MessageBox.Show("تم إلغاء الايداع");
                    clear();
                   
                }

            }
        }

        private void Frm_AddBankMoney_Load(object sender, EventArgs e)
        {

        }
    }
}
