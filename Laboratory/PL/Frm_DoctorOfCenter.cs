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
    public partial class Frm_DoctorOfCenter : Form
    {
        DoctorOfCenter d = new DoctorOfCenter();
        DataTable dt = new DataTable();

        public Frm_DoctorOfCenter()
        {
            InitializeComponent();
            dataGridView1.DataSource = d.SelectDoctor_OFCENTER();
            Btn_Update.Enabled = false;     
            dataGridView1.Columns[3].Visible = false;
        }
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            dt.Clear();
            dt = d.SearchDoctor_OFCNETER(txt_search.Text);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                txt_name.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_phone.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txt_address.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                Btn_Update.Enabled = true;
            }
        }

        private void txt_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void Frm_DoctorOfCenter_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {        
            Btn_Update.Enabled = false;
            txt_name.Clear();
            txt_phone.Clear();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_name.Text == "")
                {
                    MessageBox.Show("يرجي التاكد من اسم الطبيب");
                    return;
                }
                d.AddDoctor_OFCENTER(txt_name.Text, txt_phone.Text, txt_address.Text);
                MessageBox.Show("تم اضافه بيانات الطبيب بنجاح", "عمليه الاضافه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dataGridView1.DataSource = d.SelectDoctor_OFCENTER();
                txt_name.Clear();
                txt_phone.Clear();
                txt_address.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }

        }

        private void simpleButton2_Click(object sender, EventArgs e)
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
                    d.UpdateDoctor_OFCENTER(txt_name.Text, txt_phone.Text, Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value), txt_address.Text);

                    MessageBox.Show("تم تعديل بيانات الطبيب بنجاح", "عمليه التعديل", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("تم الغاء عمليه التعديل");                
                }
                dataGridView1.DataSource = d.SelectDoctor_OFCENTER();
                txt_name.Clear();
                txt_phone.Clear();
                txt_address.Clear();
                Btn_Update.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }
    }
}
