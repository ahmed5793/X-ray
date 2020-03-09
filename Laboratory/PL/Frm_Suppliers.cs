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
    public partial class Frm_Suppliers : Form
    {
        Suppliers S = new Suppliers();

        public Frm_Suppliers()
        {
            InitializeComponent();
            dataGridView1.DataSource = S.SelectSuppliers();
            dataGridView1.Columns[0].Visible = false;
            btn_new.Hide();
            Btn_save.Show();
        }
        void Clear()
        {
            txt_phone.Text = "";
            Txt_name.Text = "";
            txt_address.Text = "";
        }
        private void Btn_save_Click(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
            try
            {

                if (Txt_name.Text == "")
                {
                    MessageBox.Show("يرجي التاكد من اسم المورد");

                }
                else
                {
                    S.addSuppliers(Txt_name.Text, txt_address.Text, txt_phone.Text);
                    dt2.Clear();
                    dt2= S.select_LastIdSupplier();
                    S.Add_SupplierTotalMoney(Convert.ToInt32(dt2.Rows[0][0]));
                    MessageBox.Show("تم اضافه المورد بنجاح", "عمليه الاضافه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Clear();
                    dataGridView1.DataSource = S.SelectSuppliers();
                    btn_new.Hide();
                    Btn_save.Show();
                    btn_update.Enabled = false;
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


                if (Txt_name.Text == "")
                {
                    MessageBox.Show("يرجي التاكد من اسم المورد");
                }



                else if (MessageBox.Show("هل تريد تعديل بيانات المورد", "عمليه التعديل", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {

                    S.UpdateSuppliers(Txt_name.Text, txt_address.Text, txt_phone.Text, int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                    MessageBox.Show("تم تعديل بيانات العميل بنجاح", "عمليه التعديل", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    dataGridView1.DataSource = S.SelectSuppliers();
                    Clear();
                    Btn_save.Show();
                    btn_new.Hide();
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
            btn_new.Hide();
            Btn_save.Show();
            btn_update.Enabled = false;
            Clear();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    Txt_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    txt_address.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    txt_phone.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    Btn_save.Hide();
                    btn_new.Show();
                    btn_update.Enabled = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txt_phone_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {

                e.Handled = true;
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = S.SearchSuppliers(txt_search.Text);

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            btn_new.Hide();
            Btn_save.Show();
            btn_update.Enabled = false;
            Clear();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
            try
            {

                if (Txt_name.Text == "")
                {
                    MessageBox.Show("يرجي التاكد من اسم المورد");

                }
                else
                {
                    S.addSuppliers(Txt_name.Text, txt_address.Text, txt_phone.Text);
                    dt2.Clear();
                    dt2 = S.select_LastIdSupplier();
                    S.Add_SupplierTotalMoney(Convert.ToInt32(dt2.Rows[0][0]));
                    MessageBox.Show("تم اضافه المورد بنجاح", "عمليه الاضافه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Clear();
                    dataGridView1.DataSource = S.SelectSuppliers();
                    btn_new.Hide();
                    Btn_save.Show();
                    btn_update.Enabled = false;
                }
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


                if (Txt_name.Text == "")
                {
                    MessageBox.Show("يرجي التاكد من اسم المورد");
                }



                else if (MessageBox.Show("هل تريد تعديل بيانات المورد", "عمليه التعديل", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {

                    S.UpdateSuppliers(Txt_name.Text, txt_address.Text, txt_phone.Text, int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                    MessageBox.Show("تم تعديل بيانات العميل بنجاح", "عمليه التعديل", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    dataGridView1.DataSource = S.SelectSuppliers();
                    Clear();
                    Btn_save.Show();
                    btn_new.Hide();
                    btn_update.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Frm_Suppliers_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
