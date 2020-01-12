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
    public partial class Frm_installment : Form
    {
        Stock s = new Stock();
        Installment i = new Installment();
        DataTable dt = new DataTable();
        public Frm_installment()
        {
            InitializeComponent();
            dataGridView1.DataSource = i.Selectinstallment();
            txt_username.Text = Program.salesman;
            cmb_stock.DataSource = s.Compo_Stock();
            cmb_stock.DisplayMember = "Name_Stock";
            cmb_stock.ValueMember = "ID_Stock";
            cmb_instalmenttype.DataSource = i.selectcompoinstallmentType();
            cmb_instalmenttype.DisplayMember = "ID_installmentType";
            cmb_instalmenttype.ValueMember = "Name";

        }

        private void Frm_installment_Load(object sender, EventArgs e)
        {

        }

        private void btn_GenderJob_Click(object sender, EventArgs e)
        {
            Frm_installmentType it = new Frm_installmentType();
            it.ShowDialog();
            cmb_instalmenttype.DataSource = i.selectcompoinstallmentType();
            cmb_instalmenttype.DisplayMember = "ID_installmentType";
            cmb_instalmenttype.ValueMember = "Name";
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            try
            {


                if (txt_money.Text == "")
                {
                    MessageBox.Show("برجاء التاكد من المبلغ");
                    return;

                }
                if (cmb_stock.Text == "")
                {
                    MessageBox.Show("عزيزي المستخدم لم يتم التسجيل لعدم وجود خزنة");
                    cmb_stock.Focus();
                    return;
                }
                if (cmb_instalmenttype.Text == "")
                {
                    MessageBox.Show("برجاء التاكد من نوع القسط");
                    cmb_instalmenttype.Focus();
                    return;
                }


                i.Addinstallment(dateTimePicker1.Value, Convert.ToDecimal(txt_money.Text), txt_username.Text, Convert.ToInt32(cmb_stock.SelectedValue), Convert.ToInt32(cmb_instalmenttype.SelectedValue));

                MessageBox.Show("تم اضافه بيانات الطبيب بنجاح", "عمليه الاضافه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                dataGridView1.DataSource =i.Selectinstallment(); ;
                txt_money.Clear();
             


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            dt.Clear();
            dt = i.Searchinstallment(txt_search.Text);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count>0)
            {
                txt_username.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                cmb_stock.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txt_money.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                cmb_instalmenttype.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
              
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            txt_money.Text = "0";
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            try
            {


                if (txt_money.Text == "")
                {
                    MessageBox.Show("برجاء التاكد من المبلغ");
                    return;

                }
            
          


                i.Updateinstallment(dateTimePicker1.Value, Convert.ToDecimal(txt_money.Text), Convert.ToInt32(cmb_instalmenttype.SelectedValue), Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));

                MessageBox.Show("تم التعديل بنجاحو", "عمليه التعديل", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                dataGridView1.DataSource = i.Selectinstallment(); 
                txt_money.Clear();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void txt_money_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && txt_money.Text.ToString().IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
    }
}
