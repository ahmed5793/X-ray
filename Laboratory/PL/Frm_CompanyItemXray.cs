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
    public partial class Frm_CompanyItemXray : Form
    {
        ItemsXRaya ix = new ItemsXRaya();
        CategoryXRaya cx = new CategoryXRaya();
        Company cm = new Company();
        public Frm_CompanyItemXray()
        {
            InitializeComponent();
            company();
            CategoryXraya();
            dgv_visit.DataSource = cm.Select_Company_Xray();
            btn_Update.Enabled = false;
            Btn_Delete.Enabled = false;
            Txt_Discount.Enabled = false;
            Txt_PriceDiscount.Enabled = false;

        }
        void Total()
        {
            if (Txt_Price.Text != string.Empty && Txt_Discount.Text != string.Empty)
            {
                decimal price = Convert.ToDecimal(Txt_Price.Text);
                decimal discount = Convert.ToDecimal(Txt_Discount.Text);
                decimal total = price - (price * (discount / 100));
                Txt_PriceDiscount.Text = total.ToString();
            }
        }
        void company()
        {
            cmb_Company.DataSource = cm.SelectCompany();
            cmb_Company.DisplayMember = "اسم الشركه";
            cmb_Company.ValueMember = "Comp_ID";
            cmb_Company.SelectedIndex = -1;

        }
        void CategoryXraya()
        {

            Cmb_category.DataSource = cx.selectCategoryXRaya();
            Cmb_category.DisplayMember = "الفئات";
            Cmb_category.ValueMember = "ID_CtegoryXrays";
            Cmb_category.SelectedIndex = -1;
        }

        private void Cmb_category_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
              
                    cmb_items.DataSource = ix.SelectCtegoryItems(Convert.ToInt32(Cmb_category.SelectedValue));
                    cmb_items.DisplayMember = "Name";
                    cmb_items.ValueMember = "ID_ItemsXrays";
              
                if (cmb_items.Text != string.Empty)
                {
                    dt.Clear();
                    dt = ix.SelectPriseItem(Convert.ToInt32(cmb_items.SelectedValue));
                    Txt_Price.Text = dt.Rows[0][0].ToString();
                    Txt_Discount.Text = "0";
                    Txt_PriceDiscount.Text = "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void cmb_items_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                if (cmb_items.Text != string.Empty)
                {
                    dt.Clear();
                    dt = ix.SelectPriseItem(Convert.ToInt32(cmb_items.SelectedValue));
                    Txt_Price.Text = dt.Rows[0][0].ToString();
                    Txt_PriceDiscount.Text = "0";
                    Txt_Discount.Text = "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }          
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_Company.Text==""){MessageBox.Show("لا بد من إختيار إسم الشركة");return; }
                if (Cmb_category.Text==""){MessageBox.Show("لا بد من إختيار نوع الجهاز");return; }
                if (cmb_items.Text==""){MessageBox.Show("لا بد من إختيار نوع الفحص");return; }
                if (comboBox1.Text==""){MessageBox.Show("لا بد من إختيار نوع التعامل مع الشركة");return; }
                
                if (cmb_Company.Text!=string.Empty && cmb_items.Text!=string.Empty)
                {
                    for (int i = 0; i < dgv_visit.Rows.Count; i++)
                    {
                        if (cmb_Company.Text==dgv_visit.Rows[i].Cells[0].Value.ToString() && cmb_items.Text==dgv_visit.Rows[i].Cells[2].Value.ToString())
                        {
                            MessageBox.Show(" تم إضافة نوع الفحص من قبل إلى نفس الشركة","", MessageBoxButtons.OK , MessageBoxIcon.Exclamation) ;
                            return;
                        }
                    }
                    cm.Add_Company_ItemsXray(Convert.ToInt32(cmb_Company.SelectedValue), Convert.ToInt32(cmb_items.SelectedValue),Convert.ToDecimal(Txt_Discount.Text)
                       , Convert.ToDecimal(Txt_PriceDiscount.Text));
                    Txt_Price.Text="0";
                    Txt_Discount.Text = "0";
                    Txt_PriceDiscount.Text = "0";
                    Txt_PriceDiscount.Enabled = false;
                    Txt_Discount.Enabled = false;
                    MessageBox.Show("تم إضافة الفحص للشركة بنجاح");
                    dgv_visit.DataSource = cm.Select_Company_Xray();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void Txt_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && Txt_Price.Text.ToString().IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar((System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)))
            {
                e.Handled = true;
            }
        }

        private void Txt_Price_MouseMove(object sender, MouseEventArgs e)
        {
            if (Txt_Price.Text=="")
            {
                Txt_Price.Text = "0";
            }
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            if (Txt_Price.Text == "")
            {
                Txt_Price.Text = "0";
            }
        }

        private void dgv_visit_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgv_visit.Rows.Count>0)
                {
                    cmb_Company.Text = dgv_visit.CurrentRow.Cells[0].Value.ToString();
                    Cmb_category.Text= dgv_visit.CurrentRow.Cells[1].Value.ToString();
                    cmb_items.Text= dgv_visit.CurrentRow.Cells[2].Value.ToString();
                    Txt_Discount.Text= dgv_visit.CurrentRow.Cells[3].Value.ToString();
                    Txt_PriceDiscount.Text= dgv_visit.CurrentRow.Cells[4].Value.ToString();
                    Txt_Price.Text= dgv_visit.CurrentRow.Cells[5].Value.ToString();
                    cmb_Company.Enabled = false;
                    Cmb_category.Enabled = false;
                    cmb_items.Enabled = false;
                    Btn_Delete.Enabled = true;
                    btn_Update.Enabled = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            try
            {
                if (Txt_PriceDiscount.Text =="0" && Txt_Discount.Text=="")
                {
                    MessageBox.Show("لا بد من تحديد سعر او  نسبة الخصم");
                    return;
                }
                else if(MessageBox.Show("هل تريد تعديل البيانات","عملية التعديل",MessageBoxButtons.YesNo , MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    cm.Update_Company_Xray(Convert.ToInt32(cmb_Company.SelectedValue), Convert.ToInt32(cmb_items.SelectedValue),Convert.ToDecimal(Txt_Discount.Text)
                       , Convert.ToDecimal(Txt_PriceDiscount.Text));
                    MessageBox.Show("تم التعديل بنجاح ");                
                }
                else
                {
                    MessageBox.Show("لم يتم التعديل  ");
                }
                btn_Update.Enabled = false;
                Btn_Delete.Enabled = false;
                btn_save.Show();
                cmb_Company.Enabled = true;
                Cmb_category.Enabled = true;
                cmb_items.Enabled = true;
                Txt_Price.Text = "0";
                Txt_Discount.Text = "0";
                Txt_PriceDiscount.Text = "0";
                Txt_PriceDiscount.Enabled = false;
                Txt_Discount.Enabled = false;
                dgv_visit.DataSource = cm.Select_Company_Xray();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                dt.Clear();
                dt = cm.Search_Company_Xray(textBox2.Text);
                dgv_visit.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                dt.Dispose();
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }
        private void Txt_Discount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && Txt_Price.Text.ToString().IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar((System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)))
            {
                e.Handled = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text!="")
                {
                    if (comboBox1.Text== "خصم ")
                    {
                        Txt_Discount.Enabled = true;
                        Txt_PriceDiscount.Enabled = false;
                        Txt_Discount.Text = "0";
                        Txt_PriceDiscount.Text = "0";
                    }
                    else if(comboBox1.Text== "أسعار متفق عليها")
                    {
                        Txt_Discount.Enabled = false;
                        Txt_PriceDiscount.Enabled = true;
                        Txt_Discount.Text = "0";
                        Txt_PriceDiscount.Text = "0";
                    }
                }
                Total();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Txt_PriceDiscount_MouseMove(object sender, MouseEventArgs e)
        {

            if (Txt_PriceDiscount.Text == "")
            {
                Txt_PriceDiscount.Text = "0";
            }
        }
        private void Txt_Discount_MouseLeave(object sender, EventArgs e)
        {
            if (Txt_Discount.Text == "")
            {
                Txt_Discount.Text = "0";
            }
            Total();
        }

        private void Txt_Discount_KeyUp(object sender, KeyEventArgs e)
        {          
        }
        private void Txt_PriceDiscount_KeyUp(object sender, KeyEventArgs e)
        {           
        }
        private void Txt_PriceDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && Txt_PriceDiscount.Text.ToString().IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar((System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)))
            {
                e.Handled = true;
            }
        }

        private void Txt_Discount_TextChanged(object sender, EventArgs e)
        {
            Total();
        }

        private void Txt_PriceDiscount_TextChanged(object sender, EventArgs e)
        {
           // Total();
        }

        private void cmb_Company_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Cmb_category_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void Cmb_category_Leave(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                if (Cmb_category.Text != "")
                {
                    dt.Clear();
                    dt = cx.Validate_CategoryXray(Convert.ToInt32(Cmb_category.SelectedValue));
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("إسم الجهاز غير موجود لا بد من إختيار إسم الجهاز من القائمة");
                        Cmb_category.Focus();
                        cmb_items.DataSource = null;
                        return;
                    }
                }
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

        private void cmb_items_Leave(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
            try
            {
                if (cmb_Company.Text != "")
                {
                    dt2.Clear();
                    dt2 = ix.VildateItem(Convert.ToInt32(Cmb_category.SelectedValue), Convert.ToInt32(cmb_items.SelectedValue));
                    if (dt2.Rows.Count == 0)
                    {
                        MessageBox.Show("إسم الفحص غير صحيح");
                        cmb_Company.Focus();
                        cmb_Company.SelectAll();
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dt2.Dispose();
            }
        }

        private void cmb_Company_Leave(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                if (cmb_Company.Text != "")
                {
                    dt.Clear();
                    dt = cm.Validate_CompanyNAme(Convert.ToInt32(cmb_Company.SelectedValue));
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("إسم الشركة غير موجود لا بد من إختيار إسم لشركة من القائمة");
                        cmb_Company.Focus();
                        return;
                    }

                }
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

        private void Btn_New_Click(object sender, EventArgs e)
        {
            Txt_Price.Text = "0";
            Txt_Discount.Text = "0";
            Txt_PriceDiscount.Text = "0";
            Btn_Delete.Enabled = false;
            btn_Update.Enabled = false;        
            cmb_Company.Enabled = true;
            Cmb_category.Enabled = true;
            cmb_items.Enabled = true;
            Txt_PriceDiscount.Enabled = false;
            Txt_Discount.Enabled = false;
            dgv_visit.DataSource = cm.Select_Company_Xray();
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_Company.Text!="" && cmb_items.Text!="")
                {
                    if (MessageBox.Show("هل تريد مسح هذا الفحص للشركة المحددة","مسح الفحص للشركة",MessageBoxButtons.YesNo , MessageBoxIcon.Question)==DialogResult.Yes)
                    {
                        cm.Delect_CompanyItem(Convert.ToInt32(cmb_Company.SelectedValue), Convert.ToInt32(cmb_items.SelectedValue));
                        MessageBox.Show("تم مسح الفحص المحدد للشركة");

                    }
                    else
                    {
                        MessageBox.Show("تم إلغاء المسح");
                    }
                    btn_Update.Enabled = false;
                    Btn_Delete.Enabled = false;
                
                    cmb_Company.Enabled = true;
                    Cmb_category.Enabled = true;
                    cmb_items.Enabled = true;
                    Txt_Price.Text = "0";
                    Txt_Discount.Text = "0";
                    Txt_PriceDiscount.Text = "0";
                    Txt_PriceDiscount.Enabled = false;
                    Txt_Discount.Enabled = false;
                    dgv_visit.DataSource = cm.Select_Company_Xray();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Frm_CompanyItemXray_Load(object sender, EventArgs e)
        {

        }

        private void Txt_Discount_Click(object sender, EventArgs e)
        {
            if (Txt_Discount.Text=="0")
            {
                Txt_Discount.Text = "";
            }
            Total();
        }

        private void Txt_PriceDiscount_Click(object sender, EventArgs e)
        {
            if (Txt_PriceDiscount.Text == "0")
            {
                Txt_PriceDiscount.Text = "";
            }
            Txt_PriceDiscount.SelectAll();
        }

        private void Txt_PriceDiscount_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void Txt_PriceDiscount_Leave(object sender, EventArgs e)
        {
            if (Txt_PriceDiscount.Text=="")
            {
                Txt_PriceDiscount.Text = "0";
            }
        }
    }
}
