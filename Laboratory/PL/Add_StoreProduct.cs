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
            dataGridViewPR.Columns[0].Visible = false;
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
        DataTable dt5 = new DataTable();

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
                if (txt_quantity.Text =="0")
                {
                    MessageBox.Show("لا بدان تكون الكمية أكبر من الصفر");
                    txt_quantity.Focus();
                    return;
                }
                dt5 = Product.Validate_StoreProduct(Convert.ToInt32(Cmb_ProdName.SelectedValue), Convert.ToInt32(Cmb_Store.SelectedValue));
                if (dt5.Rows.Count>0)
                {
                    Product.Update_QuantityStoreProduct(Convert.ToInt32(Cmb_ProdName.SelectedValue),
                        Convert.ToDecimal(txt_quantity.Text),Convert.ToInt32(Cmb_Store.SelectedValue));
                    MessageBox.Show("تم إضافة الصنف للمخزن بنجاح");
                    txt_quantity.Text = "0";
                    Txt_Minimum.Text = "0";

                }
                else if(dt5.Rows.Count ==0)
                {
                    Product.Add_StoreProduct(Convert.ToInt32(Cmb_ProdName.SelectedValue), Convert.ToInt32(Cmb_Store.SelectedValue),
                        Convert.ToDecimal(txt_quantity.Text),Convert.ToInt32(Txt_Minimum.Text));
                    MessageBox.Show("تم إضافة الصنف للمخزن بنجاح");
                    txt_quantity.Text = "0";
                    Txt_Minimum.Text = "0";


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
                        Product.Update_StoreProduct(Convert.ToInt32(dataGridViewPR.CurrentRow.Cells[0].Value), Convert.ToInt32(Cmb_ProdName.SelectedValue),
                            Convert.ToDecimal(txt_quantity.Text), Convert.ToInt32(Cmb_Store.SelectedValue), Convert.ToInt32(Txt_Minimum.Text));
                        MessageBox.Show("تم تعديل الصنف للمخزن بنجاح");
                        txt_quantity.Text = "0";
                        Txt_Minimum.Text = "0";
                        btn_new.Hide();
                        btn_add.Show();
                        btn_update.Enabled = false;
                        button1.Enabled = true;
                        Cmb_ProdName.Enabled = true;
                  
                }
                else
                {
                    MessageBox.Show("تم إلغاء التعديل");
                    btn_new.Hide();
                    btn_add.Show();
                    btn_update.Enabled = false;
                    txt_quantity.Text = "0";
                    Txt_Minimum.Text = "0";
                    button1.Enabled = true;
                    Cmb_ProdName.Enabled = true;

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
            button1.Enabled = true;
            Cmb_ProdName.Enabled = true;
        }

        private void dataGridViewPR_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewPR.Rows.Count>0)
                {
                    if (dataGridViewPR.CurrentRow.Cells[6].Value ==null)
                    {
                        Txt_Minimum.Text = "0";
                    }
                    Cmb_ProdName.Text = dataGridViewPR.CurrentRow.Cells[2].Value.ToString();
                    Cmb_Store.Text = dataGridViewPR.CurrentRow.Cells[4].Value.ToString();
                    txt_quantity.Text = dataGridViewPR.CurrentRow.Cells[5].Value.ToString();
                    Txt_Minimum.Text = dataGridViewPR.CurrentRow.Cells[6].Value.ToString();
                    btn_new.Show();
                    btn_add.Hide();
                    btn_update.Enabled = true;
                    button1.Enabled = false;
                    Cmb_ProdName.Enabled = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Add_StoreProduct_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Product add_Product = new Add_Product();
            try
            {
                add_Product.ShowDialog();
                Cmb_ProdName.DataSource = Product.Select_ComboProduct();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txt_quantity_Click(object sender, EventArgs e)
        {
            if (txt_quantity.Text=="0")
            {
                txt_quantity.Text = "";
            }
        }

        private void txt_quantity_Leave(object sender, EventArgs e)
        {
            if (txt_quantity.Text=="")
            {
                txt_quantity.Text = "0";
            }
        }

        private void Txt_Minimum_Click(object sender, EventArgs e)
        {
            if (Txt_Minimum.Text=="0")
            {
                Txt_Minimum.Text = "";
            }
        }

        private void Txt_Minimum_Leave(object sender, EventArgs e)
        {
            if (Txt_Minimum.Text == "")
            {
                Txt_Minimum.Text = "0";
            }
        }

        private void Txt_Minimum_KeyPress(object sender, KeyPressEventArgs e)
        {
         
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 )
            {

                e.Handled = true;
            }
        }

        private void Cmb_ProdName_Leave(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                if (Cmb_ProdName.Text!="")
                {
                    dt.Clear();
                    dt = Product.Validate_ProductNAme(Convert.ToInt32(Cmb_ProdName.SelectedValue));
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("يرجي العلم بان اسم الصنف غير مسجل من قبل يرجي تسجيل هذا الاسم في شاشه الاصناف", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                        Cmb_ProdName.Focus();
                        Cmb_ProdName.SelectAll();
                        return;
                    }
                    dt.Dispose();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
