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
        }

        private void btn_GenderJob_Click(object sender, EventArgs e)
        {
            Frm_MasrofGender g = new Frm_MasrofGender();
            g.ShowDialog();
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
                    Convert.ToDecimal(txt_amount.Text), dateTimePicker1.Value);
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
    }
}
