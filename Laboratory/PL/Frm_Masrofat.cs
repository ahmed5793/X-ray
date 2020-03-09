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
    public partial class Frm_Masrofat : Form
    {
        Masrofat m = new Masrofat();
        Stock Stock = new Stock();

        private static Frm_Masrofat farm;
        static void STATUESCllosed(object sender, FormClosedEventArgs e)
        {
            farm = null;
        }
        public static Frm_Masrofat getmain
        {
            get
            {
                if (farm == null)
                {
                    farm = new Frm_Masrofat();
                    farm.FormClosed += new FormClosedEventHandler(STATUESCllosed);
                }
                return farm;
            }
        }
        public Frm_Masrofat()
        {
            InitializeComponent();

            if (farm == null)
            {
                farm = this;
            }
            txt_username.Text = Program.salesman;
            dataGridView1.DataSource = m.SelectReserveDetails();

            comboBox1.DataSource = m.SelectReserve();
            comboBox1.DisplayMember = "masrof_type";
            comboBox1.ValueMember = "ID_masrof";

            cmb_Stock.DataSource = Stock.Compo_Stock();
            cmb_Stock.DisplayMember = "Name_Stock";
            cmb_Stock.ValueMember = "ID_Stock";
            textBox1.Hide();
            Btn_Delete.Enabled = false;
        }


        private void btn_GenderJob_Click(object sender, EventArgs e)
        {
            Frm_MasrofGender g = new Frm_MasrofGender();
            g.ShowDialog();
            comboBox1.DataSource = m.SelectReserve();
            g.Dispose();
        }
        DataTable dt = new DataTable();
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_amount.Text == "")
            {
                MessageBox.Show("من فضلك ادخال المبلغ ");
                return;
            }
            dt.Clear();

            dt = Stock.Select_moneyStock(Convert.ToInt32(cmb_Stock.SelectedValue));

            if (dt.Rows.Count > 0)
            {

                if (Convert.ToDecimal(txt_amount.Text) > Convert.ToDecimal(dt.Rows[0][0]))
                {
                    MessageBox.Show("رصيد الخزنة الحالى غير كافى ");
                    return;
                }
            }
            if (comboBox1.Text != string.Empty)
            {
                m.AddReserveDetails(Convert.ToInt32(comboBox1.SelectedValue), txt_notes.Text,
                Convert.ToDecimal(txt_amount.Text), dateTimePicker1.Value,Convert.ToInt32(cmb_Stock.SelectedValue),txt_username.Text);
                Stock.Add_StockPull(Convert.ToInt32(cmb_Stock.SelectedValue), Convert.ToDecimal(txt_amount.Text), dateTimePicker1.Value, txt_username.Text, "مصروفات " +"لل"+ comboBox1.Text);
                MessageBox.Show("تم التسجيل بنجاح", "عمليه التسجيل");
                dataGridView1.DataSource = m.SelectReserveDetails();
                txt_notes.Clear();
                txt_amount.Clear();
            }
            else
            {
                MessageBox.Show("من فضلك قم بااختيار نوع المصروف");
            }
        }

        private void Frm_Masrofat_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        
        }

        private void txt_amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && txt_amount.Text.ToString().IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                e.Handled = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count>0)
                {
                    Btn_Delete.Enabled = true;
                    btn_save.Enabled = false;
                    cmb_Stock.Enabled = false;
                    comboBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    txt_notes.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    txt_amount.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    //dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    textBox1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (MessageBox.Show("هل تريد تعديل المصروف","تعديل المصروف",MessageBoxButtons.YesNo , MessageBoxIcon.Question)==DialogResult.Yes)
            //    {
            //        m.UpdateResrveDetails(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),Convert.ToInt32(comboBox1.SelectedValue),
            //            txt_notes.Text, Convert.ToDecimal(txt_amount.Text),dateTimePicker1.Value,Convert.ToInt32(cmb_Stock.SelectedValue),txt_username.Text);
            //        MessageBox.Show("تم تعديل المصروف بنجاح");
            //    }
            //    else
            //    {
            //        MessageBox.Show("تم إلغاء تعديل المصروف ");
            //    }
            //    dataGridView1.DataSource = m.SelectReserveDetails();
            //    txt_notes.Clear();
            //    txt_amount.Clear();
            //    textBox1.Clear();
            //    Btn_Delete.Enabled = false;
            //    Btn_Update.Enabled = false;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void Btn_New_Click(object sender, EventArgs e)
        {
            txt_notes.Clear();
            txt_amount.Clear();
            textBox1.Clear();
            Btn_Delete.Enabled = false;
            btn_save.Enabled = true;
            cmb_Stock.Enabled = true;
            dateTimePicker1.Value = DateTime.Now;

        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("هل تريد مسح المصروف", "مسح المصروف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Stock.add_insertStock(Convert.ToInt32(textBox1.Text),Convert.ToDecimal(txt_amount.Text),DateTime.Now,txt_notes.Text,"مسح مصروف " +" "+   comboBox1.Text  +" "+"من شاشة المصروفات");
                    m.DeleteReserveDetails(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                    MessageBox.Show("تم مسح المصروف بنجاح");
                }
                else
                {
                    MessageBox.Show("تم إلغاء مسح المصروف ");
                }
                dataGridView1.DataSource = m.SelectReserveDetails();
                txt_notes.Clear();
                txt_amount.Clear();
                textBox1.Clear();
                Btn_Delete.Enabled = false;
                btn_save.Enabled = true;
                cmb_Stock.Enabled = true;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
