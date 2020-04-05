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
    public partial class Frm_Doctor : Form
    {
        Doctors d = new Doctors();

        private static Frm_Doctor farm;

        static void STATUESCllosed(object sender, FormClosedEventArgs e)
        {
            farm = null;
        }
        public static Frm_Doctor getmain
        {
            get
            {
                if (farm == null)
                {
                    farm = new Frm_Doctor();
                    farm.FormClosed += new FormClosedEventHandler(STATUESCllosed);
                }
                return farm;
            }
        }






        public Frm_Doctor()
        {
            InitializeComponent();
            if (farm == null)
            {
                farm = this;
            }
            Function();
        }
        void Function()
        {
            try
            {

                Btn_Update.Enabled = false;
                dataGridView1.DataSource = d.SelectDoctor();
                dataGridView1.Columns[4].Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        Frm_DoctorJob j = new Frm_DoctorJob();

        private void btn_GenderJob_Click(object sender, EventArgs e)
        {
            j.ShowDialog();
            comboBox1.DataSource = d.CompoDoctorDepatrtment();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {        
        }

        private void Frm_Doctor_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = d.CompoDoctorDepatrtment();
            comboBox1.DisplayMember = "Deplartmen";
            comboBox1.ValueMember = "ID_Departmen";
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
            dt = d.SearchDoctor(txt_search.Text);
            dataGridView1.DataSource = dt;

            dt.Dispose();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                Btn_Update.Enabled = true;
                Btn_Add.Enabled = false;
                dateTimePicker1.Enabled = false;
                txt_name.Enabled = false;

                txt_name.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                comboBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txt_phone.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txt_address.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

                dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
               
              
            }

        }

        private void txt_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
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
                if (comboBox1.Text == "")
                {
                    MessageBox.Show("يرجي التاكد من تخصص الطبيب");
                    comboBox1.Focus();
                    return;
                }
                d.AddDoctor(txt_name.Text, txt_phone.Text, txt_address.Text, dateTimePicker1.Value, Convert.ToInt32(comboBox1.SelectedValue));
                MessageBox.Show("تم اضافه بيانات الطبيب بنجاح", "عمليه الاضافه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dataGridView1.DataSource = d.SelectDoctor();
                txt_name.Clear();
                txt_phone.Clear();
                txt_address.Clear();
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
                    MessageBox.Show("يرجي التاكد من اسم الطبيب");
                    txt_name.Focus();
                    return;
                }
                if (comboBox1.Text == "")
                {
                    MessageBox.Show("يرجي التاكد من تخصص الطبيب");
                    comboBox1.Focus();
                    return;
                }
                if (MessageBox.Show("هل تريد تعديل بيانات الطبيب", "عمليه التعديل", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    d.UpdateDoctor(txt_name.Text, txt_phone.Text, Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value), txt_address.Text, Convert.ToInt32(comboBox1.SelectedValue));
                    MessageBox.Show("تم تعديل بيانات الطبيب بنجاح", "عمليه التعديل", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("تم الغاء عمليه التعديل");                 
                }
                dataGridView1.DataSource = d.SelectDoctor();
                txt_name.Clear();
                txt_phone.Clear();
                txt_address.Clear();
                Btn_Update.Enabled = false;
                Btn_Add.Enabled = true;
                txt_name.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
