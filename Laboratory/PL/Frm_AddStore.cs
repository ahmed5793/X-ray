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
    public partial class Frm_AddStore : Form
    {
        Store store = new Store();
        public Frm_AddStore()
        {
            InitializeComponent();
            dataGridView1.DataSource = store.Select_Store();

            btn_new.Hide();
            btn_save.Show();
            btn_update.Enabled = false;
        }
        void Clear()
        {
            txt_name.Clear();
            txt_address.Clear();
            dataGridView1.DataSource = store.Select_Store();
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_name.Text== string.Empty)
                {
                    MessageBox.Show("يرجى التأكد من إسم المخزن");
                    return; 
                }
                else
                {
                    store.add_Store(txt_name.Text , txt_address.Text);
                    MessageBox.Show("تم حفظ المخزن");
                    Clear();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Frm_AddStore_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count>0)
                {
                    txt_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    txt_address.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

                    btn_new.Show();
                    btn_save.Hide();
                    btn_update.Enabled = true;
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
                if (txt_name.Text == string.Empty)
                {
                    MessageBox.Show("يرجى التأكد من إسم المخزن");
                    return;
                }
                else if (MessageBox.Show("","",MessageBoxButtons.YesNo ,MessageBoxIcon.Exclamation)==DialogResult.Yes)
                {
                    store.Update_Store(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),txt_name.Text,txt_address.Text);
                    MessageBox.Show("تم تعديل البيانات بنجاح");
                    Clear();

                    btn_new.Hide();
                    btn_save.Show();
                    btn_update.Enabled = false;
                }
                else
                {
                    MessageBox.Show("لم تم تعديل البيانات بنجاح  ");
                    Clear();

                    btn_new.Hide();
                    btn_save.Show();
                    btn_update.Enabled = false;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            try
            {
                btn_new.Hide();
                btn_save.Show();
                btn_update.Enabled = false;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
