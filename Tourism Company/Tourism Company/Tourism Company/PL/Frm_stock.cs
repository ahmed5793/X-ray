using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Tourism_Company.BL;


namespace Tourism_Company.PL
{
    public partial class Frm_stock : Form
    {
        Stock s = new Stock();
        
        public Frm_stock()
        {
            InitializeComponent();
        
            dataGridView1.DataSource = s.select_Stock();
            btn_delete.Enabled = false;
            btn_new.Hide();
            btn_update.Enabled = false;
            textBox1.Text = s.Select_LastIdStock().Rows[0][0].ToString() ;
            if (textBox1.Text=="")
            {
                textBox1.Text = "1";
            }
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "")
            {
                MessageBox.Show("يرحى كتابة إسم الخزنة");

            }
            else
            {
                s.add_stock(Convert.ToInt32(textBox1.Text),txt_name.Text);
                s.add_stockData(Convert.ToInt32(textBox1.Text));
                MessageBox.Show("تم إضافة الخزنة بنجاح");
                txt_name.Clear();
                dataGridView1.DataSource = s.select_Stock();
                textBox1.Text = s.Select_LastIdStock().Rows[0][0].ToString();

            }
        }

        private void DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            btn_save.Hide();
            btn_new.Show();
            btn_update.Enabled = true;
            btn_delete.Enabled = true;
        }

        private void Btn_update_Click(object sender, EventArgs e)
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
            else if (MessageBox.Show("هل تريد تعديل بيانات الخزنة", "عمليه التعديل", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
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

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            if (txt_name.Text=="")
            {
                MessageBox.Show("يرجى التاكد من إسم الخزنة");
            
                btn_new.Hide();
                btn_save.Show();
                btn_update.Enabled = false;
                btn_delete.Enabled = false;
            }
            else if (MessageBox.Show("هل تريد مسح الخزنة المحدده","عملية المسح",MessageBoxButtons.YesNo , MessageBoxIcon.Information)== DialogResult.Yes)
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

        private void Btn_new_Click(object sender, EventArgs e)
        {
            btn_new.Hide();
            btn_save.Show();
            btn_update.Enabled = false;
            btn_delete.Enabled = false;
            txt_name.Clear();
            textBox1.Text = s.Select_LastIdStock().Rows[0][0].ToString();

        }

        private void Frm_stock_Load(object sender, EventArgs e)
        {
            btn_delete.Hide();
        }
    }
}
