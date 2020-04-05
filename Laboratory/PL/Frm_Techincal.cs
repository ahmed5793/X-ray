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
    public partial class Frm_Techincal : Form
    {
        Techincal t = new Techincal();
        public Frm_Techincal()
        {
            InitializeComponent();
            dataGridView1.DataSource = t.SelectTechincal();
            btn_new.Hide();
            btn_update.Enabled = false;
            dataGridView1.Columns[3].Visible = false;
        }

        private void Frm_Techincal_Load(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {


        }

        private void btn_update_Click(object sender, EventArgs e)
        {


        }

        private void btn_new_Click(object sender, EventArgs e)
        {
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = t.SearchTechincal(txt_search.Text);
            dataGridView1.DataSource = dt;

            dt.Dispose();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {



                txt_name.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_phone.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txt_address.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

                btn_save.Hide();
                btn_new.Show();
                btn_update.Enabled = true;
                txt_name.Enabled = false;
            }
        }

        private void txt_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

            btn_new.Hide();
            btn_save.Show();

            btn_update.Enabled = false;
            txt_name.Clear();
            txt_phone.Clear();
            txt_name.Enabled = true;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            try
            {


                if (txt_name.Text == "")
                {
                    MessageBox.Show("يرجي التاكد من اسم الطبيب");
                    return;

                }



                t.AddTechincal(txt_name.Text, txt_phone.Text, txt_address.Text);

                MessageBox.Show("تم اضافه بيانات الطبيب بنجاح", "عمليه الاضافه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                dataGridView1.DataSource = t.SelectTechincal();
                txt_name.Clear();
                txt_phone.Clear();
                txt_address.Clear();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

            try
            {


                if (txt_name.Text == "")
                {
                    MessageBox.Show("يرجي التاكد من اسم الطبيب");
                    txt_name.Focus();
                    return;
                }





                if (MessageBox.Show("هل تريد تعديل بيانات الطبيب", "عمليه التعديل", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    t.UpdateTechincal(txt_name.Text, txt_phone.Text, Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value), txt_address.Text);

                    MessageBox.Show("تم تعديل بيانات الطبيب بنجاح", "عمليه التعديل", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dataGridView1.DataSource = t.SelectTechincal();
                    txt_name.Clear();
                    txt_phone.Clear();
                    txt_address.Clear();
                    btn_update.Enabled = false;
                    btn_new.Hide();
                    btn_save.Show();
                    txt_name.Enabled = true;

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
    }
}
