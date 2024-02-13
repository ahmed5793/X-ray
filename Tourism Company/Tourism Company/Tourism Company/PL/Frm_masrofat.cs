using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Tourism_Company.BL;
namespace Tourism_Company.PL
{
    public partial class Frm_masrofat : Form
    {
        masrofat m = new masrofat();
        Stock s = new Stock();
        public Frm_masrofat()
        {
            InitializeComponent();
            dataGridView1.DataSource = m.Select_masrofat();
            btn_new.Hide();
            btn_update.Enabled = false;
            btn_delete.Enabled = false;
            cmb_Stock.DataSource = s.Compo_Stock();
            cmb_Stock.DisplayMember = "Treasury_name";
            cmb_Stock.ValueMember = "id_Treasury";
            textBox1.Hide();
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {

                if (cmb_Stock.Text == "")
                {
                    MessageBox.Show("من فضلك قم بااختيار نوع الخزنة");
                    return;
                }
                if (txt_name.Text == "")
                {
                    MessageBox.Show("تاكد من كتابة نوع المصروف");
                    return;
                }
                if (txt_amount.Text == "")
                {
                    MessageBox.Show("تاكد من كتابة مبلغ المصروف");
                    return;

                }
                
                    dt = s.Select_moneyStock(Convert.ToInt32(cmb_Stock.SelectedValue));
                if (Convert.ToDecimal(txt_amount.Text) <= Convert.ToDecimal(dt.Rows[0][0])) 
                    {


                        m.Add_masrof(txt_name.Text, Convert.ToDecimal(txt_amount.Text), dateTimePicker1.Value, txt_notes.Text, Convert.ToInt32(cmb_Stock.SelectedValue), cmb_Stock.Text);
                        s.Add_StockPull(Convert.ToInt32(cmb_Stock.SelectedValue), Convert.ToDecimal(txt_amount.Text), dateTimePicker1.Value, Program.salesman, "مصروفات", txt_notes.Text);

                        MessageBox.Show("تم تسجيل المصروف بنجاح");
                        dataGridView1.DataSource = m.Select_masrofat();
                        txt_amount.Clear();
                        txt_name.Clear();
                        txt_notes.Clear();

                    }
                    else
                    {
                        MessageBox.Show("عزيزى المستخدم المبلغ المراد صرفه اكبر من الاموجود في الخزنه الرجاء التأكد  من نقديه الخزنه");
                        return;
                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_name.Text == "")
                {
                    MessageBox.Show("تاكد من كتابة نوع المصروف");
                }
                else if (txt_amount.Text == "")
                {
                    MessageBox.Show("تاكد من كتابة مبلغ المصروف");

                }
                else if (MessageBox.Show("هل تريد التعديل", " عميل التعديل", MessageBoxButtons.YesNo, MessageBoxIcon.Information)==DialogResult.Yes)

                {
                    m.Update_masrof(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value), txt_name.Text, Convert.ToDecimal(txt_amount.Text), dateTimePicker1.Value, txt_notes.Text,Convert.ToInt32(cmb_Stock.SelectedValue),cmb_Stock.Text);
                    s.DeletePullStock(Convert.ToInt32(cmb_Stock.SelectedValue), dateTimePicker1.Value, Convert.ToDecimal(txt_amount.Text));
                    s.Add_StockPull(Convert.ToInt32(cmb_Stock.SelectedValue), Convert.ToDecimal(txt_amount.Text), dateTimePicker1.Value, Program.salesman, "مصروفات", txt_notes.Text);

                    MessageBox.Show("تم تعديل المصروف بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dataGridView1.DataSource = m.Select_masrofat();
                    txt_amount.Clear();
                    txt_name.Clear();
                    txt_notes.Clear();
                    btn_new.Hide();
                    btn_save.Show();
                    btn_delete.Enabled = false;
                    btn_update.Enabled = false;
                    textBox1.Hide();
                    cmb_Stock.Show();
                }
                else
                {
                    MessageBox.Show("تم إلغاء التعديل");
                    txt_amount.Clear();
                    txt_name.Clear();
                    txt_notes.Clear();
                    textBox1.Hide();
                    cmb_Stock.Show();

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("هل تريد حذف هذا المصروف ", "حذف المصروف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    m.Delete_masrof(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                    s.DeletePullStock(Convert.ToInt32(cmb_Stock.SelectedValue), dateTimePicker1.Value, Convert.ToDecimal(txt_amount.Text));

                    MessageBox.Show("تم مسح المصروف بنجاح");
                    dataGridView1.DataSource = m.Select_masrofat();
                    txt_amount.Clear();
                    txt_name.Clear();
                    txt_notes.Clear();
                    btn_new.Hide();
                    btn_save.Show();
                    btn_delete.Enabled = false;
                    btn_update.Enabled = false;
                    textBox1.Hide();
                    cmb_Stock.Show();
                }
                else
                {
                    MessageBox.Show("تم إلغاء المسح");
                    txt_amount.Clear();
                    txt_name.Clear();
                    txt_notes.Clear();
                    textBox1.Hide();
                    cmb_Stock.Show();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            textBox1.Show();
            cmb_Stock.Hide();
            txt_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_amount.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_notes.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            btn_new.Show();
            btn_save.Hide();
            btn_update.Enabled = true;
            btn_delete.Enabled = true;
        }

        private void Btn_new_Click(object sender, EventArgs e)
        {
            txt_amount.Clear();
            txt_name.Clear();
            txt_notes.Clear();
            btn_new.Hide();
            btn_save.Show();
            btn_delete.Enabled = false;
            btn_update.Enabled = false;
            textBox1.Hide();
            cmb_Stock.Show();
        }

        private void Txt_amount_TextChanged(object sender, EventArgs e)
        {
            if (txt_amount.Text == "")
            {
                txt_amount.Text = "0";
            }
        }

        private void Txt_amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && txt_amount.Text.ToString().IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                e.Handled = true;
            }
        }

        private void Txt_search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = m.Searech_masrofat(txt_search.Text);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
