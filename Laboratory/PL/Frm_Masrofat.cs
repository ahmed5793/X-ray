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
            comboBox1.DataSource = m.SelectReserve();
            comboBox1.DisplayMember = "masrof_type";
            comboBox1.ValueMember = "ID_masrof";
            cmb_Stock.DataSource = Stock.Compo_Stock();
            cmb_Stock.DisplayMember = "Name_Stock";
            cmb_Stock.ValueMember = "ID_Stock";
        }


        private void btn_GenderJob_Click(object sender, EventArgs e)
        {
            Frm_MasrofGender g = new Frm_MasrofGender();
            g.ShowDialog();
            comboBox1.DataSource = m.SelectReserve();
            g.Dispose();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_amount.Text == "")
            {
                MessageBox.Show("من فضلك ادخال المبلغ ");
                return;

            }
            if (comboBox1.Text != string.Empty)
            {
                m.AddReserveDetails(Convert.ToInt32(comboBox1.SelectedValue), txt_notes.Text,
                Convert.ToDecimal(txt_amount.Text), dateTimePicker1.Value,Convert.ToInt32(cmb_Stock.SelectedValue),txt_username.Text);
                Stock.Add_StockPull(Convert.ToInt32(cmb_Stock.SelectedValue), Convert.ToDecimal(txt_amount.Text), dateTimePicker1.Value, txt_username.Text, "مصروفات ");
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
            label4.Hide();
            textBox1.Hide();
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

        }
    }
}
