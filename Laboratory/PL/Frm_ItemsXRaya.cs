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
                dataGridView1.DataSource = i.SelectItemXRaya();
                Btn_add.Enabled = true;
                Btn_Update.Enabled = false;
                dataGridView1.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                Btn_add.Enabled = false;
                Btn_Update.Enabled = true;
                comboBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txt_name.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txt_price.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            dt.Clear();
            dt = i.SearchItemXRaya(txt_search.Text);
            dataGridView1.DataSource = dt;
            dt.Dispose();
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
            dt.Clear();
            dt = c.Validate_CategoryXray(Convert.ToInt32(comboBox1.SelectedValue));
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("عزيزيى المستخدم يرجي العلم بان اسم الجهاز غير مسجل ");
                return;
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
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
                if (txt_price.Text == "")
                {

                    MessageBox.Show("من فضلك يرجي ادخال سعر الاشعة");
                    txt_price.Focus();
                    return;
                }
                i.AddItemXRaya(txt_name.Text, Convert.ToDecimal(txt_price.Text), Convert.ToInt32(comboBox1.SelectedValue));
                MessageBox.Show("تم الاضافه  بنجاح", "عمليه الاضافه", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                txt_name.Clear();
                txt_price.Clear();
                dataGridView1.DataSource = i.SelectItemXRaya();
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

                i.UpdateItemXRaya(txt_name.Text, Convert.ToDecimal(txt_price.Text), Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value), Convert.ToInt32(comboBox1.SelectedValue));
                MessageBox.Show("تم التعديل  بنجاح", "عمليه التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                txt_name.Clear();
                txt_price.Clear();
                dataGridView1.DataSource = i.SelectItemXRaya();
                Btn_Update.Enabled = false;
                Btn_add.Enabled = true;
                comboBox1.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void Frm_ItemsXRaya_Load(object sender, EventArgs e)
        {

        }
    }
}
