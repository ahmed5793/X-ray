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
namespace Laboratory.BL
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
            btn_print.Enabled = false;

        }
        void company()
        {
            cmb_Company.DataSource = cm.SelectCompany();
            cmb_Company.DisplayMember = "اسم الشركه";
            cmb_Company.ValueMember = "Comp_ID";
        }
        void CategoryXraya()
        {

            Cmb_category.DataSource = cx.selectCategoryXRaya();
            Cmb_category.DisplayMember = "الفئات";
            Cmb_category.ValueMember = "ID_CtegoryXrays";
        }

        private void Cmb_category_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (Cmb_category.Text != "")
            {

                cmb_items.DataSource = ix.SelectCtegoryItems(Convert.ToInt32(Cmb_category.SelectedValue));
                cmb_items.DisplayMember = "Name";
                cmb_items.ValueMember = "ID_ItemsXrays";

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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
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
                    cm.Add_Company_ItemsXray(Convert.ToInt32(cmb_Company.SelectedValue), Convert.ToInt32(cmb_items.SelectedValue)
                       , Convert.ToDecimal(Txt_Price.Text),Convert.ToDecimal(textBox1.Text));
                    Txt_Price.Clear();
                    textBox1.Clear();
                    MessageBox.Show("تم إضافة الفحص للشركة بنجاح");
                    dgv_visit.DataSource = cm.Select_Company_Xray();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && textBox1.Text.ToString().IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar((System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)))
            {
                e.Handled = true;
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
                    Txt_Price.Text= dgv_visit.CurrentRow.Cells[3].Value.ToString();
                    textBox1.Text= dgv_visit.CurrentRow.Cells[4].Value.ToString();
                    cmb_Company.Enabled = false;
                    Cmb_category.Enabled = false;
                    cmb_items.Enabled = false;
                    btn_save.Enabled = false;
                    btn_print.Enabled = true;

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
                if (Txt_Price.Text =="" && Txt_Price.Text=="0")
                {
                    MessageBox.Show("لا بد من تحديد سعر");
                    return;
                }
                else if(MessageBox.Show("هل تريد تعديل البيانات","عملية التعديل",MessageBoxButtons.YesNo , MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    cm.Update_Company_Xray(Convert.ToInt32(cmb_Company.SelectedValue), Convert.ToInt32(cmb_items.SelectedValue)
                       , Convert.ToDecimal(Txt_Price.Text), Convert.ToDecimal(textBox1.Text));
                    MessageBox.Show("تم التعديل بنجاح ");
                    btn_print.Enabled = false;
                    btn_save.Enabled = true;
                    cmb_Company.Enabled = true;
                    Cmb_category.Enabled = true;
                    cmb_items.Enabled = true;
                    Txt_Price.Clear();
                    textBox1.Clear();
                    dgv_visit.DataSource = cm.Select_Company_Xray();
                }
                else
                {
                    MessageBox.Show("لم يتم التعديل  ");
                    btn_print.Enabled = false;
                    btn_save.Enabled = true;
                    cmb_Company.Enabled = true;
                    Cmb_category.Enabled = true;
                    cmb_items.Enabled = true;
                    dgv_visit.DataSource = cm.Select_Company_Xray();
                }
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
            }
            finally
            {
                dt.Dispose();
            }
        }
    }
}
