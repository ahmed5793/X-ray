using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tourism_Company.BL;

namespace Tourism_Company.PL
{
    public partial class Form_Company : Form
    {
        Company co = new Company();
        DataTable dt = new DataTable();
        public Form_Company()
        {
            InitializeComponent();
            btn_delete.Enabled = false;
            
            btn_new.Hide();
            btn_update.Enabled = false;
            dataGridView1.DataSource = co.SelectCompany();
            dataGridView1.Columns[2].Visible = false;
        }

        private void Form_Company_Load(object sender, EventArgs e)
        {

        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            try
            {

             if (txt_name.Text == "")
            {
                MessageBox.Show("يرجي التاكد من اسم الشركة");
                    
            }
            else
            {

                co.AddCompany(txt_name.Text, txt_phone.Text);

                MessageBox.Show("تم اضافه بيانات الشركة بنجاح", "عمليه الاضافه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                dataGridView1.DataSource = co.SelectCompany();
                txt_name.Clear();
                txt_phone.Clear();
            }
               Form_Booking.geter.cmb_company.DataSource = co.CompoCompany();
                Form_Booking.geter.cmb_company.DisplayMember = "Name";
                Form_Booking.geter.cmb_company.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void Txt_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void Txt_search_TextChanged(object sender, EventArgs e)
        {
            dt =co.SearchCompany(txt_search.Text);
            dataGridView1.DataSource = dt;
        }

        private void DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {

                txt_name.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_phone.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                btn_save.Hide();
                btn_new.Show();
                btn_delete.Enabled = true;
            }  btn_update.Enabled = true;
        }

        private void Btn_new_Click(object sender, EventArgs e)
        {
            btn_new.Hide();
            btn_save.Show();
            btn_delete.Enabled = false;
            btn_update.Enabled = false;
            txt_name.Clear();
            txt_phone.Clear();
        }

        private void Btn_update_Click(object sender, EventArgs e)
        {
            try
            {

              
                 if (txt_name.Text == "")
                {
                    MessageBox.Show("يرجي التاكد من اسم الشركة");
                    txt_name.Focus();
                }



                else if (MessageBox.Show("هل تريد تعديل بيانات الشركة", "عمليه التعديل", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    co.UpdateCompany(txt_name.Text, txt_phone.Text, Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value));

                    MessageBox.Show("تم تعديل بيانات الشركة بنجاح", "عمليه التعديل", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dataGridView1.DataSource = co.SelectCompany();
                    txt_name.Clear();
                    txt_phone.Clear();
                

                }
                Form_Booking.geter.cmb_company.DataSource = co.CompoCompany();
                Form_Booking.geter.cmb_company.DisplayMember = "Name";
                Form_Booking.geter.cmb_company.ValueMember = "ID";

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
                if (MessageBox.Show("هل تريد حذف بيانات الشركة", "عمليه الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {

                    co.DeleteComapny(Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value));
                    MessageBox.Show("تم مسح بيانات الشركة بنجاح", "عمليه الحذف", MessageBoxButtons.OK, MessageBoxIcon.None);


                    dataGridView1.DataSource = co.SelectCompany();
                    txt_name.Clear();
                    txt_phone.Clear();
                  
                }
                else
                {
                    MessageBox.Show("تم الغاء عمليه الحذف", "عمليه الحذف", MessageBoxButtons.OK, MessageBoxIcon.None);

                }
                Form_Booking.geter.cmb_company.DataSource = co.CompoCompany();
                Form_Booking.geter.cmb_company.DisplayMember = "Name";
                Form_Booking.geter.cmb_company.ValueMember = "ID";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
