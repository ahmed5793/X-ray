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
    public partial class Frm_Company : Form
    {
        Company co = new Company();
        DataTable dt = new DataTable();
        public Frm_Company()
        {
            InitializeComponent();
          
            btn_new.Hide();
            btn_update.Enabled = false;
            dataGridView1.DataSource = co.SelectCompany();
            dataGridView1.Columns[3].Visible = false;

      
           
        }

        private void Frm_Company_Load(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            try
            {

                if (txt_name.Text == "")
                {
                    MessageBox.Show("يرجي التاكد من اسم الشركة");
                   
                }
                else
                {

                    co.AddCompany(txt_name.Text, txt_phone.Text,txt_address.Text,dateTimePicker1.Value);

                    MessageBox.Show("تم اضافه بيانات الشركة بنجاح", "عمليه الاضافه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    dataGridView1.DataSource = co.SelectCompany();
                    txt_name.Clear();
                    txt_phone.Clear();
                    txt_address.Clear();
              
                }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
               

                if (txt_name.Text == "")
                {
                    MessageBox.Show("يرجي التاكد من اسم الشركة");
                    txt_name.Focus();
                    return;
                }



                if (MessageBox.Show("هل تريد تعديل بيانات الشركة", "عمليه التعديل", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    co.UpdateCompany(txt_name.Text, txt_phone.Text, Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value),txt_address.Text);

                    MessageBox.Show("تم تعديل بيانات الشركة بنجاح", "عمليه التعديل", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dataGridView1.DataSource = co.SelectCompany();
                    txt_name.Clear();
                    txt_phone.Clear();
                    txt_address.Clear();
                    btn_update.Enabled = false;
                    btn_new.Hide();
                    btn_save.Show();


                }
                else
                {
                    MessageBox.Show("تم الغاء عمليه التعديل");
                    txt_name.Clear();
                    txt_phone.Clear();
                    txt_address.Clear();
                    btn_update.Enabled = false;
                    btn_new.Hide();
                    btn_save.Show();
                }
            

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

                dateTimePicker1.Enabled = false;

                txt_name.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_phone.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txt_address.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

                dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                btn_save.Hide();
                btn_new.Show();
                btn_update.Enabled = true;
            }
        
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            btn_new.Hide();
            btn_save.Show();
        
            btn_update.Enabled = false;
            txt_name.Clear();
            txt_phone.Clear();
        }
      
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
         
            dt = co.SearchCompany(txt_search.Text);
            dataGridView1.DataSource = dt;

            dt.Dispose();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txt_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
    
}
