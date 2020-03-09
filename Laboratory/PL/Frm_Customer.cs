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
    public partial class Frm_Customer : Form
    {
        Customer c = new Customer();
        DataTable dt = new DataTable();
        public Frm_Customer()
        {
            InitializeComponent();
            dataGridView1.DataSource = c.SelectCustomer();          
            Btn_Update.Enabled = false;          
        }

        private void Frm_Customer_Load(object sender, EventArgs e)
        {
        }
        void clear()
        {
            txt_address.Clear();
            txt_age.Clear();
            txt_name.Clear();
            txt_phone.Clear();
            txt_idnational.Clear();
        }        
        private void Btn_save_Click(object sender, EventArgs e)
        {  
        }

        private void Btn_update_Click(object sender, EventArgs e)
        {           
        }

        private void Txt_search_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = c.SearchCustomer(txt_search.Text);

        }

        private void Rdb_male_CheckedChanged(object sender, EventArgs e)
        {

        
             
        }

        private void Rdb_female_CheckedChanged(object sender, EventArgs e)
        {

           
           
           
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                dateTimePicker1.Enabled = false;
                txt_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                comboBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txt_age.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txt_address.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txt_phone.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                txt_idnational.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                Btn_Update.Enabled = true;
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
        }

        private void txt_search_TextChanged_1(object sender, EventArgs e)
        {
            dt.Clear();
            dt = c.SearchCustomer(txt_search.Text);
            dataGridView1.DataSource = dt;
        }

        private void txt_age_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txt_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
        
           if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 )
            {
                e.Handled = true;
            }
        }

        private void txt_idnational_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            clear();    
            Btn_Update.Enabled = false;
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_name.Text == "")
                {
                    MessageBox.Show("يرجي التاكد من اسم العميل");
                    return;
                }
                if (comboBox1.Text == "")
                {
                    MessageBox.Show("يرجي التاكد من نوع ");
                    return;
                }
                if (txt_age.Text == "")
                {
                    MessageBox.Show("يرجي التاكد من ألسن");
                    return;
                }
                if (txt_phone.Text == "")
                {
                    MessageBox.Show("يرجي التاكد رقم العميل");
                    return;
                }
                c.addCustomer(txt_name.Text, txt_address.Text, txt_phone.Text,
                    Convert.ToInt32(txt_age.Text), dateTimePicker1.Value, comboBox1.Text, txt_idnational.Text);
                MessageBox.Show("تم اضافه العميل بنجاح", "عمليه الاضافه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dataGridView1.DataSource = c.SelectCustomer();
                clear();
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

                if (txt_name.Text == "")
                {
                    MessageBox.Show("يرجي التاكد من اسم العميل");
                    return;
                }
                if (comboBox1.Text == "")
                {
                    MessageBox.Show("يرجي التاكد من نوع ");
                    return;
                }
                if (txt_age.Text == "")
                {
                    MessageBox.Show("يرجي التاكد من ألسن");
                    return;
                }
                if (txt_phone.Text == "")
                {
                    MessageBox.Show("يرجي التاكد رقم موبايل العميل");
                    return;
                }
                if (MessageBox.Show("هل تريد تعديل بيانات العميل", "عمليه التعديل", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {

                    c.UpdateCustomer(txt_name.Text, txt_address.Text, txt_phone.Text,
                            Convert.ToInt32(txt_age.Text), int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()), comboBox1.Text, txt_idnational.Text);
                    MessageBox.Show("تم تعديل بيانات العميل بنجاح", "عمليه التعديل", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
                }
                else
                {
                    MessageBox.Show("لم يتم تعديل بيانات العميل بنجاح", "عمليه التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                dataGridView1.DataSource = c.SelectCustomer();
                clear();
                Btn_Update.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
