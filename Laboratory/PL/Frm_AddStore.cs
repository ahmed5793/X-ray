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
            Btn_Add.Show();
            btn_update.Enabled = false;
        }
        void Clear()
        {
            txt_name.Clear();
            txt_address.Clear();
            btn_update.Enabled = false;
            dataGridView1.DataSource = store.Select_Store();
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
           
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
                    btn_update.Enabled = true;
                    Btn_Add.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
       
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_name.Text == string.Empty)
                {
                    MessageBox.Show("يرجى التأكد من إسم المخزن");
                    return;
                }
                else
                {
                    store.add_Store(txt_name.Text, txt_address.Text);
                    MessageBox.Show("تم حفظ المخزن");
                    Clear();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void btn_new_Click_1(object sender, EventArgs e)
        {
            try
            {
                Btn_Add.Enabled=true;
                btn_update.Enabled = false;
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_update_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txt_name.Text == string.Empty)
                {
                    MessageBox.Show("يرجى التأكد من إسم المخزن");
                    return;
                }
                else if (MessageBox.Show("هل تريد تعديل بيانات المخزن", "عملية تعديل ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    store.Update_Store(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value), txt_name.Text, txt_address.Text);
                }
                else
                {
                    MessageBox.Show("لم تم تعديل البيانات بنجاح  ");
                }
                Clear();
                btn_update.Enabled = false;
                Btn_Add.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

    }
}
