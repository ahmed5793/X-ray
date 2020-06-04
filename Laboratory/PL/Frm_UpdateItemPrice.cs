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
    public partial class Frm_UpdateItemPrice : Form
    {
        ItemsXRaya it = new ItemsXRaya();

        public Frm_UpdateItemPrice()
        {
            InitializeComponent();
        }

        private void bunifuTextbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (Txt_price.Text=="0" ||Txt_price.Text=="")
                {
                    MessageBox.Show("لأبد ان يكون المبلغ اكبر من الصفر");
                    return;
                }
            if (radio_pay.Checked==true)
            {
                if (radio_plas.Checked == true)
                {
                    it.UpdatePrice(Convert.ToDecimal(Txt_price.Text));
                }
                else if (radio_mins.Checked == true)
                {
                    it.UpdatePriceMins(Convert.ToDecimal(Txt_price.Text));
                }
            }
            else if (radio_company.Checked==true)
            {

                if (radio_plas.Checked == true)
                {
                    it.UpdatePriceCompany(Convert.ToDecimal(Txt_price.Text));
                }
                else if (radio_mins.Checked == true)
                {
                    it.UpdatePriceMinsCompany(Convert.ToDecimal(Txt_price.Text));
                }
            }
                MessageBox.Show("تم الحفظ بنجاح");
                Txt_price.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Txt_price_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void Frm_UpdateItemPrice_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && Txt_price.Text.ToString().IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                e.Handled = true;
            }
        }
    }
}
