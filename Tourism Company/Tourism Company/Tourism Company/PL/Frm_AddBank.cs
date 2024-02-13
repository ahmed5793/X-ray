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
    
    public partial class Frm_AddBank : Form
    {
        Bank B = new Bank();
        public Frm_AddBank()
        {
            InitializeComponent();
            dataGridView1.DataSource = B.select_bank();
            btn_new.Hide();
            btn_update.Enabled = false;
            btn_delete.Enabled = false;
            textBox1.Text = B.Select_LastIdBank().Rows[0][0].ToString();
            if (textBox1.Text=="")
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = B.Select_LastIdBank().Rows[0][0].ToString();
            }
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Btn_new_Click(object sender, EventArgs e)
        {
            textBox1.Text = B.Select_LastIdBank().Rows[0][0].ToString();
            txt_name.Clear();
            txt_num.Clear();
            btn_new.Hide();
            btn_save.Show();
            btn_delete.Enabled = false;
            btn_update.Enabled = false;
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {

            if (txt_name.Text=="")
            {
                MessageBox.Show("من فضلك اكتب إسم البنك");
                txt_name.Focus();
            }
            else
            {
                B.add_bank(Convert.ToInt32(textBox1.Text),txt_name.Text, txt_num.Text);
                B.Add_BankData(Convert.ToInt32(textBox1.Text));
                MessageBox.Show("تم إضافة البنك بنجاح");
                txt_num.Clear();
                txt_name.Clear();
                dataGridView1.DataSource = B.select_bank();
                textBox1.Text = B.Select_LastIdBank().Rows[0][0].ToString();
            }
        }

        private void Btn_update_Click(object sender, EventArgs e)
        {
            if (txt_name.Text=="")
            {
                MessageBox.Show("من فضلك اكتب إسم البنك");
                txt_name.Focus();

            }
            else if (MessageBox.Show("هل تريد تعديل البيانات","عملية التعديل",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                B.Update_bank(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value), txt_name.Text, txt_num.Text);
                MessageBox.Show("تم تعديل البيانات بنجاح");
                dataGridView1.DataSource = B.select_bank();
                
                txt_name.Clear();
                txt_num.Clear();
                btn_new.Hide();
                btn_save.Show();
                btn_delete.Enabled = false;
                btn_update.Enabled = false;

            }
            else
            {

                MessageBox.Show("تم إلغاء التعديل");
                dataGridView1.DataSource = B.select_bank();
                txt_name.Clear();
                txt_num.Clear();
                btn_new.Hide();
                btn_save.Show();
                btn_delete.Enabled = false;
                btn_update.Enabled = false;
            }
            textBox1.Text = B.Select_LastIdBank().Rows[0][0].ToString();
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
              if (MessageBox.Show("هل تريد مسح البيانات", "عملية المسح", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                B.Delete_bank(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                MessageBox.Show("تم مسح البيانات بنجاح");
                dataGridView1.DataSource = B.select_bank();
                txt_name.Clear();
                txt_num.Clear();
                btn_new.Hide();
                btn_save.Show();
                btn_delete.Enabled = false;
                btn_update.Enabled = false;

            }
            else
            {

                MessageBox.Show("تم إلغاء المسح");
                dataGridView1.DataSource = B.select_bank();
                txt_name.Clear();
                txt_num.Clear();
                btn_new.Hide();
                btn_save.Show();
                btn_delete.Enabled = false;
                btn_update.Enabled = false;
            }
            textBox1.Text = B.Select_LastIdBank().Rows[0][0].ToString();
        }

        private void DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_num.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
          
            btn_new.Show();
            btn_save.Hide();
            btn_delete.Enabled = true;
            btn_update.Enabled = true;
        }

        private void Txt_num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)&&e.KeyChar!=8)
            {
                e.Handled = true;
            }
        }

        private void Frm_AddBank_Load(object sender, EventArgs e)
        {
            btn_delete.Hide();
        }
    }
}
