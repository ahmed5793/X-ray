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
    public partial class frm_AddStock : Form
    {
        Stock s = new Stock();
        public frm_AddStock()
        {
            InitializeComponent();

            textBox1.Text = s.Select_LastIdStock().Rows[0][0].ToString();
            dataGridView1.DataSource = s.select_Stock();
            btn_delete.Enabled = false;
            btn_new.Hide();
            btn_update.Enabled = false;
            textBox1.Text = s.Select_LastIdStock().Rows[0][0].ToString();
            if (textBox1.Text == "")
            {
                textBox1.Text = "1";
            }
        }

        private void frm_AddStock_Load(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            if (txt_name.Text == "")
            {
                MessageBox.Show("يرحى كتابة إسم الخزنة");

            }
            else
            {
                s.add_stock(Convert.ToInt32(textBox1.Text), txt_name.Text);
                s.add_stockData(Convert.ToInt32(textBox1.Text));
                MessageBox.Show("تم إضافة الخزنة بنجاح");
                txt_name.Clear();
                dataGridView1.DataSource = s.select_Stock();
                textBox1.Text = s.Select_LastIdStock().Rows[0][0].ToString();

            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "")
            {
                MessageBox.Show("يرجى التاكد من إسم الخزنة");
                txt_name.Clear();
                btn_new.Hide();
                btn_save.Show();
                btn_update.Enabled = false;
                btn_delete.Enabled = false;
                dataGridView1.DataSource = s.select_Stock();
            }
             if (MessageBox.Show("هل تريد تعديل بيانات الخزنة", "عمليه التعديل", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {

                s.Update_Stock(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value), txt_name.Text);
                MessageBox.Show("تم تعديل الاسم");
                txt_name.Clear();
                btn_new.Hide();
                btn_save.Show();
                btn_update.Enabled = false;
                btn_delete.Enabled = false;
                dataGridView1.DataSource = s.select_Stock();


            }
            else
            {
                MessageBox.Show("لم يتم التعديل", "عملية التعديل", MessageBoxButtons.OK);
                txt_name.Clear();
                btn_new.Hide();
                btn_save.Show();
                btn_update.Enabled = false;
                btn_delete.Enabled = false;
                dataGridView1.DataSource = s.select_Stock();
            }
            textBox1.Text = s.Select_LastIdStock().Rows[0][0].ToString();


        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "")
            {
                MessageBox.Show("يرجى التاكد من إسم الخزنة");

                btn_new.Hide();
                btn_save.Show();
                btn_update.Enabled = false;
                btn_delete.Enabled = false;
            }
            else if (MessageBox.Show("هل تريد مسح الخزنة المحدده", "عملية المسح", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                s.Delete_Stock(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                MessageBox.Show("تم مسح الخزنة");
                btn_new.Hide();
                btn_save.Show();
                btn_update.Enabled = false;
                btn_delete.Enabled = false;
                txt_name.Clear();
                dataGridView1.DataSource = s.select_Stock();
            }
            else
            {
                MessageBox.Show("لم يتم مسح الخزنة");
                btn_new.Hide();
                btn_save.Show();
                btn_update.Enabled = false;
                btn_delete.Enabled = false;
                txt_name.Clear();
                dataGridView1.DataSource = s.select_Stock();

            }
            textBox1.Text = s.Select_LastIdStock().Rows[0][0].ToString();

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            btn_new.Hide();
            btn_save.Show();
            btn_update.Enabled = false;
            btn_delete.Enabled = false;
            txt_name.Clear();
            textBox1.Text = s.Select_LastIdStock().Rows[0][0].ToString();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count>0)
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                btn_save.Hide();
                btn_new.Show();
                btn_update.Enabled = true;
                btn_delete.Enabled = true;
            }
        }
    }
}
