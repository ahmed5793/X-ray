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
        DataTable dt = new DataTable();

        public Frm_CompanyItemXray()
        {
            InitializeComponent();
            company();
            CategoryXraya();
            gridControl1.DataSource = cm.Select_Company_Xray();
            Btn_Update.Enabled = false;
            Btn_Delete.Hide();
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
                    cmb_items.Text = "";
                    cmb_items.DataSource = ix.SelectCtegoryItems(Convert.ToInt32(Cmb_category.SelectedValue));
                    cmb_items.DisplayMember = "Name";
                    cmb_items.ValueMember = "ID_ItemsXrays";
                    cmb_items.SelectedIndex = -1;
                    Txt_Price.Text = "0";
                    Txt_Discount.Text = "0";
                    Txt_PriceDiscount.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void cmb_items_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {                
                    dt.Clear();
                    dt = ix.SelectPriseItem(Convert.ToInt32(cmb_items.SelectedValue));
                    if (dt.Rows.Count>0)
                    {
                        Txt_Price.Text = dt.Rows[0][0].ToString();
                        Txt_PriceDiscount.Text = "0";
                        Txt_Discount.Text = "0";
                    }
                    Total();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }          
        }
        private void btn_save_Click(object sender, EventArgs e)
        {            
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
          
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //DataTable dt = new DataTable();
            //try
            //{
            //    dt.Clear();
            //    dt = cm.Search_Company_Xray(textBox2.Text);
            //    dgv_visit.DataSource = dt;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    MessageBox.Show(ex.StackTrace);
            //}
            //finally
            //{
            //    dt.Dispose();
            //}
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
                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                dt.Dispose();
            }
        }

        private void cmb_items_Leave(object sender, EventArgs e)
        {
            try
            {
                if (cmb_items.Text != "")
                {
                    dt.Clear();
                    dt = ix.VildateItem(Convert.ToInt32(Cmb_category.SelectedValue), Convert.ToInt32(cmb_items.SelectedValue));
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("إسم الفحص غير صحيح");
                        cmb_items.Focus();
                        cmb_items.SelectAll();
                        return;
                    }
                }
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

        private void cmb_Company_Leave(object sender, EventArgs e)
        {
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
                    Btn_Update.Enabled = false;
                    Btn_Delete.Enabled = false;                
                    cmb_Company.Enabled = true;
                    Cmb_category.Enabled = true;
                    cmb_items.Enabled = true;
                    Txt_Price.Text = "0";
                    Txt_Discount.Text = "0";
                    Txt_PriceDiscount.Text = "0";
                    Txt_PriceDiscount.Enabled = false;
                    Txt_Discount.Enabled = false;
                    gridControl1.DataSource = cm.Select_Company_Xray();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
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
            else
            {
                Txt_PriceDiscount.SelectAll();
            }
        }
      

        private void Txt_PriceDiscount_Leave(object sender, EventArgs e)
        {
            if (Txt_PriceDiscount.Text=="")
            {
                Txt_PriceDiscount.Text = "0";
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            cmb_Company.SelectedIndex = -1;
            cmb_items.SelectedIndex = -1;
            Cmb_category.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;
            Btn_Update.Enabled = false;
            Btn_Delete.Enabled = false;
            Btn_Add.Show();
            cmb_Company.Enabled = true;
            Cmb_category.Enabled = true;
            cmb_items.Enabled = true;
            Txt_Price.Text = "0";
            Txt_Discount.Text = "0";
            Txt_PriceDiscount.Text = "0";
            Txt_PriceDiscount.Enabled = false;
            Txt_Discount.Enabled = false;
            comboBox1.Text = "";
            cmb_items.Text = "";
            Cmb_category.Text = "";
            cmb_Company.Text = "";
            gridControl1.DataSource = cm.Select_Company_Xray();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_Company.Text == "") { MessageBox.Show("لا بد من إختيار إسم الشركة"); return; }
                if (Cmb_category.Text == "") { MessageBox.Show("لا بد من إختيار نوع الجهاز"); return; }
                if (cmb_items.Text == "") { MessageBox.Show("لا بد من إختيار نوع الفحص"); return; }
                if (comboBox1.Text == "") { MessageBox.Show("لا بد من إختيار نوع التعامل مع الشركة"); return; }
                if (comboBox1.Text== "أسعار متفق عليها")
                {
                    if (Txt_PriceDiscount.Text=="" || Txt_PriceDiscount.Text=="0")
                    {
                        MessageBox.Show("يرجي تحديد السعر المتفق عليه ");
                        Txt_PriceDiscount.Focus();
                        return;
                    }
                }
                //if (comboBox1.Text=="خصم")
                //{
                //    if (Txt_Discount.Text=="" || Txt_Discount)
                //    {

                //    }
                //}
                if (cmb_Company.Text != string.Empty && cmb_items.Text != string.Empty)
                {
                    for (int i = 0; i < gridView1.RowCount; i++)
                    {
                        DataRow row = gridView1.GetDataRow(i);
                        if (cmb_Company.Text == row[0].ToString() && cmb_items.Text == row[2].ToString())
                        {
                            MessageBox.Show(" تم إضافة نوع الفحص من قبل إلى نفس الشركة", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                    }
                    cm.Add_Company_ItemsXray(Convert.ToInt32(cmb_Company.SelectedValue), Convert.ToInt32(cmb_items.SelectedValue), Convert.ToDecimal(Txt_Discount.Text)
                       , Convert.ToDecimal(Txt_PriceDiscount.Text));
           

                    MessageBox.Show("تم إضافة الفحص للشركة بنجاح");
                    gridControl1.DataSource = cm.Select_Company_Xray();
                    Txt_Price.Text = "0";
                    Txt_Discount.Text = "0";
                    Txt_PriceDiscount.Text = "0";
                    Txt_PriceDiscount.Enabled = false;
                    Txt_Discount.Enabled = false;
                    comboBox1.SelectedIndex=-1;
                    cmb_items.Text = "";
                    Cmb_category.Text = "";
                    cmb_Company.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (Txt_PriceDiscount.Text == "0" && Txt_Discount.Text == "")
                {
                    MessageBox.Show("لا بد من تحديد سعر او  نسبة الخصم");
                    return;
                }
                if (comboBox1.Text == "أسعار متفق عليها")
                {
                    if (Txt_PriceDiscount.Text == "" || Txt_PriceDiscount.Text == "0")
                    {
                        MessageBox.Show("يرجي تحديد السعر المتفق عليه ");
                        Txt_PriceDiscount.Focus();
                        return;
                    }
                }
                else if (MessageBox.Show("هل تريد تعديل البيانات", "عملية التعديل", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm.Update_Company_Xray(Convert.ToInt32(cmb_Company.SelectedValue), Convert.ToInt32(cmb_items.SelectedValue), Convert.ToDecimal(Txt_Discount.Text)
                       , Convert.ToDecimal(Txt_PriceDiscount.Text));
                    MessageBox.Show("تم التعديل بنجاح ");
                }
                else
                {
                    MessageBox.Show("لم يتم التعديل  ");
                }
                cmb_Company.SelectedIndex = -1;
                cmb_items.SelectedIndex = -1;
                Cmb_category.SelectedIndex = -1;
                comboBox1.SelectedIndex = -1;              
                Btn_Update.Enabled = false;
                Btn_Delete.Enabled = false;
                Btn_Add.Show();
                cmb_Company.Enabled = true;
                Cmb_category.Enabled = true;
                cmb_items.Enabled = true;
                Txt_Price.Text = "0";
                Txt_Discount.Text = "0";
                Txt_PriceDiscount.Text = "0";
                Txt_PriceDiscount.Enabled = false;
                Txt_Discount.Enabled = false;
                comboBox1.Text = "";
                cmb_items.Text = "";
                Cmb_category.Text = "";
                cmb_Company.Text = "";
                gridControl1.DataSource = cm.Select_Company_Xray();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }
        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (gridView1.RowCount > 0)
                {
                    cmb_Company.Text = gridView1.GetFocusedRowCellValue("إسم الشركة").ToString();
                    Cmb_category.Text = gridView1.GetFocusedRowCellValue("الجهاز").ToString();
                    cmb_items.Text = gridView1.GetFocusedRowCellValue("إسم الفحص").ToString();
                    Txt_Discount.Text = gridView1.GetFocusedRowCellValue("نسبة الخصم").ToString();
                    Txt_PriceDiscount.Text = gridView1.GetFocusedRowCellValue("سعر المريض العادي").ToString();
                    Txt_Price.Text = gridView1.GetFocusedRowCellValue("السعر").ToString();
                    cmb_Company.Enabled = false;
                    Cmb_category.Enabled = false;
                    cmb_items.Enabled = false;
                    Btn_Delete.Enabled = true;
                    Btn_Update.Enabled = true;
                    Btn_Add.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void Txt_Discount_MouseMove(object sender, MouseEventArgs e)
        {
            if (Txt_Discount.Text == "")
            {
                Txt_Discount.Text = "0";
            }
            Total();
        }

        private void Cmb_category_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                cmb_items.DataSource = ix.SelectCtegoryItems(Convert.ToInt32(Cmb_category.SelectedValue));
                cmb_items.DisplayMember = "Name";
                cmb_items.ValueMember = "ID_ItemsXrays";
                cmb_items.SelectedIndex = -1;
                Txt_Price.Text = "0";
                Txt_Discount.Text = "0";
                Txt_PriceDiscount.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void cmb_items_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                dt.Clear();
                dt = ix.SelectPriseItem(Convert.ToInt32(cmb_items.SelectedValue));
                if (dt.Rows.Count > 0)
                {
                    Txt_Price.Text = dt.Rows[0][0].ToString();
                    Txt_PriceDiscount.Text = "0";
                    Txt_Discount.Text = "0";
                }
                Total();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void Txt_Discount_KeyDown(object sender, KeyEventArgs e)
        {
            if (Txt_Discount.Text == "0")
            {
                Txt_Discount.Text = "";
            }
        }

        private void Txt_Discount_Leave(object sender, EventArgs e)
        {
            if (Txt_Discount.Text == "")
            {
                Txt_Discount.Text = "0";
            }
        }
    }
}
