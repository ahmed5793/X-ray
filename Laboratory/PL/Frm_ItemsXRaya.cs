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
    public partial class Frm_ItemsXRaya : Form
    {
        ItemsXRaya i = new ItemsXRaya();
        CategoryXRaya c = new CategoryXRaya();
        DataTable dt = new DataTable();
        public Frm_ItemsXRaya()
        {
            InitializeComponent();
            Function();
        }
        void Function()
        {
            try
            {
                comboBox1.DataSource = c.selectCategoryXRaya();
                comboBox1.DisplayMember = "الفئات";
                comboBox1.ValueMember = "ID_CtegoryXrays";
                gridControl1.DataSource = i.SelectItemXRaya();
                Btn_add.Enabled = true;
                Btn_Update.Enabled = false;
                gridView1.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
          
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txt_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && txt_price.Text.ToString().IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar((System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)))
            {
                e.Handled = true;
            }
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            try
            {

          
            dt.Clear();
            dt = c.Validate_CategoryXray(Convert.ToInt32(comboBox1.SelectedValue));
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("عزيزيى المستخدم يرجي العلم بان اسم الجهاز غير مسجل ");
                comboBox1.Focus();
                comboBox1.SelectAll();

                return;
            }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                dt.Clear();
                dt = c.Validate_CategoryXray(Convert.ToInt32(comboBox1.SelectedValue));
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("عزيزيى المستخدم يرجي العلم بان اسم الجهاز غير مسجل ");
                    txt_name.Focus();
                    txt_name.SelectAll();

                    return;
                }
                if (txt_name.Text == "")
                {
                    MessageBox.Show("من فضلك يرجي ادخال اسم الاشعة");
                    txt_name.Focus();
                    return;

                }
                if (comboBox1.Text == "")
                {

                    MessageBox.Show("من فضلك يرجي ادخال الفئه");
                    comboBox1.Focus();
                    return;
                }
                if (txt_price.Text == ""  && txt_price.Text=="0")
                {

                    MessageBox.Show("من فضلك يرجي ادخال سعر الاشعة");
                    txt_price.Focus();
                    return;
                }
                i.AddItemXRaya(txt_name.Text, Convert.ToDecimal(txt_price.Text), Convert.ToInt32(comboBox1.SelectedValue));
                MessageBox.Show("تم الاضافه  بنجاح", "عمليه الاضافه", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                txt_name.Clear();
                txt_price.Clear();
                gridControl1.DataSource = i.SelectItemXRaya();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_name.Text == "")
                {
                    MessageBox.Show("من فضلك يرجي ادخال اسم الصنف");
                    return;
                }
                if (comboBox1.Text == "")
                {
                    MessageBox.Show("من فضلك يرجي ادخال الفئه");
                    comboBox1.Focus();
                    return;
                }
                if (MessageBox.Show("هل تريد التعديل", "عملية التعديل", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    i.UpdateItemXRaya(txt_name.Text, Convert.ToDecimal(txt_price.Text), Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID_ItemsXrays")), Convert.ToInt32(comboBox1.SelectedValue));
                    MessageBox.Show("تم التعديل  بنجاح", "عمليه التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    MessageBox.Show("تم إلغاء التعديل", "عمليه التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                txt_name.Clear();
                txt_price.Clear();
                gridControl1.DataSource = i.SelectItemXRaya();
                Btn_Update.Enabled = false;
                Btn_add.Enabled = true;
                comboBox1.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }
        }

        private void Frm_ItemsXRaya_Load(object sender, EventArgs e)
        {

        }

        private void txt_price_MouseMove(object sender, MouseEventArgs e)
        {
            if (txt_price.Text=="")
            {
                txt_price.Text = "0";
            }
        }

        private void txt_price_Click(object sender, EventArgs e)
        {
            txt_price.SelectAll();
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            txt_name.Clear();
            txt_price.Clear();
            gridControl1.DataSource = i.SelectItemXRaya();
            Btn_Update.Enabled = false;
            Btn_add.Enabled = true;
            comboBox1.Enabled = true;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {


                if (gridView1.RowCount > 0)
                {
                    Btn_add.Enabled = false;
                    Btn_Update.Enabled = true;

                    comboBox1.Text = gridView1.GetFocusedRowCellValue("الفئه").ToString();
                    txt_name.Text = gridView1.GetFocusedRowCellValue("اسم الصنف").ToString();
                    txt_price.Text = gridView1.GetFocusedRowCellValue("السعر").ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
