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
    public partial class Add_StoreProduct : Form
    {
        Product Product = new Product();
        Store Store = new Store();
        public Add_StoreProduct()
        {
            InitializeComponent();
            Cmb_ProdName.DataSource = Product.Select_ComboProduct();
            Cmb_ProdName.DisplayMember = "Product_Name";
            Cmb_ProdName.ValueMember = "Id_Product";
            Cmb_Store.DataSource = Store.Select_ComboStore();
            Cmb_Store.DisplayMember = "Store_name";
            Cmb_Store.ValueMember = "id_store";
            dataGridViewPR.DataSource = Product.Select_StoreProduct();
            btn_update.Enabled = false;
            btn_new.Hide();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void txt_quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && txt_quantity.Text.ToString().IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {

                e.Handled = true;
            }
        }

        private void txt_quantity_TextChanged(object sender, EventArgs e)
        {
            if (txt_quantity.Text == "")
            {
                txt_quantity.Text = "0";
            }
        }

        private void txt_quantity_MouseClick(object sender, MouseEventArgs e)
        {
            txt_quantity.SelectAll();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cmb_ProdName.Text == string.Empty )
                {
                    MessageBox.Show("لابد من وجود صنف");
                    Cmb_ProdName.Focus();
                    return;
                }
                if (Cmb_Store.Text == string.Empty)
                {
                    MessageBox.Show("لا بد من وجود مخزن");
                    Cmb_Store.Focus();
                    return;
                }
                if (txt_quantity.Text == string.Empty)
                {
                    MessageBox.Show("لا بدان تكون الكمية أكبر من الصفر");
                    txt_quantity.Focus();
                    return;
                }
                else
                {
                    Product.Add_StoreProduct(Convert.ToInt32(Cmb_ProdName.SelectedValue), Convert.ToInt32(Cmb_Store.SelectedValue),
                        Convert.ToDecimal(txt_quantity.Text));
                    Product.Update_TotalProd(Convert.ToInt32(Cmb_ProdName.SelectedValue), Convert.ToDecimal(txt_quantity.Text));
                    MessageBox.Show("تم إضافة الصنف للمخزن بنجاح");
                    txt_quantity.Text = "0";

                }
                dataGridViewPR.DataSource = Product.Select_StoreProduct();

            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.Message) ;
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cmb_ProdName.Text == string.Empty)
                {
                    MessageBox.Show("لابد من وجود صنف");
                    Cmb_ProdName.Focus();
                    return;
                }
                if (Cmb_Store.Text == string.Empty)
                {
                    MessageBox.Show("لا بد من وجود مخزن");
                    Cmb_Store.Focus();
                    return;
                }
                if (txt_quantity.Text == string.Empty)
                {
                    MessageBox.Show("لا بدان تكون الكمية أكبر من الصفر");
                    txt_quantity.Focus();
                    return;
                }
                else if (MessageBox.Show("هل تريد التعديل","عملية التعديل",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    Product.Update_StoreProduct(Convert.ToInt32(dataGridViewPR.CurrentRow.Cells[0].Value),
                        Convert.ToDecimal(txt_quantity.Text) ,Convert.ToInt32(Cmb_Store.SelectedValue) );
                    Product.Update_TotalProd(Convert.ToInt32(Cmb_ProdName.SelectedValue), Convert.ToDecimal(txt_quantity.Text));
                    MessageBox.Show("تم تعديل الصنف للمخزن بنجاح");
                    txt_quantity.Text = "0";
                    btn_new.Hide();
                    btn_add.Show();
                    btn_update.Enabled = false;
                }
                else
                {
                    MessageBox.Show("تم إلغاء التعديل");
                    btn_new.Hide();
                    btn_add.Show();
                    btn_update.Enabled = false;
                    txt_quantity.Text = "0";

                }
                dataGridViewPR.DataSource = Product.Select_StoreProduct();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {

            btn_new.Hide();
            btn_add.Show();
            btn_update.Enabled = false;
            txt_quantity.Text = "0";
        }

        private void dataGridViewPR_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewPR.Rows.Count>0)
                {
                    Cmb_ProdName.Enabled = false;
                    Cmb_ProdName.Text = dataGridViewPR.CurrentRow.Cells[1].Value.ToString();
                    Cmb_Store.Text = dataGridViewPR.CurrentRow.Cells[3].Value.ToString();
                    txt_quantity.Text = dataGridViewPR.CurrentRow.Cells[4].Value.ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
