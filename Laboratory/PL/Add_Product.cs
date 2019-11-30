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
    public partial class Add_Product : Form
    {
        Product Product = new Product();
        Store Store = new Store();
        public Add_Product()
        {
            InitializeComponent();
            btn_update.Enabled = false;
            btn_new.Hide();
            dataGridViewPR.DataSource = Product.Select_Product();
            Cmb_Store.DataSource = Store.Select_ComboStore();
            Cmb_Store.DisplayMember = "Store_name";
            Cmb_Store.ValueMember = "id_store";

        }
        internal void Clear()
        {
            txt_name.Text = "";
            txt_quantity.Text = "0";
            txt_seeling.Text = "0";
            txt_phr.Text = "0";
        }


        private void Add_Product_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_name.Text == "")
                {
                    MessageBox.Show("يرجي التاكد من اسم المنتج");
                    txt_name.Focus();
                    return;
                }
                if (Cmb_Store.Text=="")
                {
                    MessageBox.Show("لابد من وجود مخزن لإضافة الصنف");
                    Cmb_Store.Focus();
                    return;
                }
                else
                {
                    int x = Convert.ToInt32(Product.Select_LastIdProduct().Rows[0][0].ToString());
                    Product.Add_Product(x, txt_name.Text, Convert.ToDecimal(txt_quantity.Text),Convert.ToDecimal(txt_seeling.Text),
                        decimal.Parse(txt_phr.Text), Convert.ToInt32(Cmb_Store.SelectedValue));
                    MessageBox.Show("تم اضافه الصنف بنجاح", "عمليه الاضافه", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    dataGridViewPR.DataSource = Product.Select_Product();
                    Clear();

                }
            }
               catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (txt_name.Text == "")
                {
                    MessageBox.Show("يرجي التاكد من اسم المنتج");
                    txt_name.Focus();
                    return;
                }


                if (MessageBox.Show("هل تريد تعديل الصنف", "عمليه التعديل", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {

                    Product.Update_Product(int.Parse(dataGridViewPR.CurrentRow.Cells[0].Value.ToString()),  txt_name.Text, decimal.Parse(txt_quantity.Text),
                        Convert.ToDecimal(txt_seeling.Text), decimal.Parse(txt_phr.Text),Convert.ToInt32(Cmb_Store.SelectedValue));
                    MessageBox.Show("تم تعديل الصنف بنجاح", "عمليه التعديل", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          

                }

                else
                {
                    MessageBox.Show("تم الغاء عمليه التعديل", "عمليه التعديل", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                dataGridViewPR.DataSource = Product.Select_Product();
                Product.Update_TotalProd();
                Clear();
                btn_add.Show();
                btn_new.Hide();
                btn_update.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewPR_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewPR.Rows.Count > 0)
                {
                    txt_name.Text = dataGridViewPR.CurrentRow.Cells[1].Value.ToString();
                    txt_quantity.Text = dataGridViewPR.CurrentRow.Cells[2].Value.ToString();
                    txt_seeling.Text = dataGridViewPR.CurrentRow.Cells[3].Value.ToString();
                    txt_phr.Text = dataGridViewPR.CurrentRow.Cells[4].Value.ToString();
                    Cmb_Store.Text = dataGridViewPR.CurrentRow.Cells[5].Value.ToString();
                    btn_add.Hide();
                    btn_update.Enabled = true;
                    btn_new.Show();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {

                dt.Clear();
                dt = Product.Search_Product(txt_search.Text);
                dataGridViewPR.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dt.Dispose();
            }
        }

        private void txt_phr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && txt_phr.Text.ToString().IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {

                e.Handled = true;
            }
        }

        private void txt_seeling_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == '.' && txt_seeling.Text.ToString().IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {

                e.Handled = true;
            }
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

        private void btn_new_Click(object sender, EventArgs e)
        {
            Clear();

            btn_new.Hide();
            btn_add.Show();
            btn_update.Enabled = false;
        }

        private void txt_phr_TextChanged(object sender, EventArgs e)
        {
            if (txt_phr.Text == "")
            {
                txt_phr.Text = "0";
            }
        }

        private void txt_seeling_TextChanged(object sender, EventArgs e)
        {
            if (txt_seeling.Text == "")
            {
                txt_seeling.Text = "0";
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

        private void txt_phr_MouseClick(object sender, MouseEventArgs e)
        {
            txt_phr.SelectAll();

        }

        private void txt_seeling_MouseClick(object sender, MouseEventArgs e)
        {
            txt_seeling.SelectAll();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_AddStore frm_AddStore = new Frm_AddStore();
            try
            {
                frm_AddStore.ShowDialog();
                Cmb_Store.DataSource = Store.Select_ComboStore();
            }
            catch (Exception)
            {

                throw;
            }
            finally        
            {
                frm_AddStore.Dispose();
            }
        }
    }
}
