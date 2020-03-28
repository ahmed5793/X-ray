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
            cmb_instalmenttype.DisplayMember = "Name";
            cmb_instalmenttype.ValueMember = "ID_installmentType";
            Btn_Update.Enabled = false;
            textBox1.Hide();
        }

        private void Frm_installment_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].Visible = false;
        }

        private void btn_GenderJob_Click(object sender, EventArgs e)
        {
            Frm_installmentType it = new Frm_installmentType();
            it.ShowDialog();
            cmb_instalmenttype.DataSource = i.selectcompoinstallmentType();
            cmb_instalmenttype.DisplayMember = "Name";
            cmb_instalmenttype.ValueMember = "ID_installmentType"; 
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

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
                Btn_Update.Enabled = true;
                cmb_stock.Enabled = false;
                Btn_Add.Enabled = false;
                //txt_username.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                cmb_stock.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txt_money.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                cmb_instalmenttype.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();              
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {            
        }
        private void btn_update_Click(object sender, EventArgs e)
        {                                   
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
        void clear()
        {
            cmb_stock.Enabled = true;
            txt_money.Text = "0";
            Btn_Update.Enabled = false;
            cmb_stock.Enabled = true;
            Btn_Add.Enabled = true;
            textBox1.Clear();
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_money.Text == "" || txt_money.Text == "0")
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

                dt.Clear();
                dt = s.Select_moneyStock(Convert.ToInt32(cmb_stock.SelectedValue));
                if (dt.Rows.Count > 0)
                {
                    if (Convert.ToDecimal(txt_money.Text) > Convert.ToDecimal(dt.Rows[0][0]))
                    {
                        MessageBox.Show("رصيد الخزنة الحالى غير كافى ");
                        return;
                    }
                }

                i.Addinstallment(dateTimePicker1.Value, Convert.ToDecimal(txt_money.Text), txt_username.Text, Convert.ToInt32(cmb_stock.SelectedValue), Convert.ToInt32(cmb_instalmenttype.SelectedValue));

                MessageBox.Show("تم اضافةالقسط بنجاح ", "عمليه الاضافه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                s.Add_StockPull(Convert.ToInt32(cmb_stock.SelectedValue), Convert.ToDecimal(txt_money.Text),
                             dateTimePicker1.Value, txt_username.Text,  " دفع قسط" +" "+ cmb_instalmenttype.Text );

                dataGridView1.DataSource = i.Selectinstallment();
                clear();
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
                if (txt_money.Text == "" ||txt_money.Text=="0" )
                {
                    MessageBox.Show("برجاء التاكد من المبلغ");
                    txt_money.Focus();
                    return;
                }
                dt.Clear();
                dt = s.Select_moneyStock(Convert.ToInt32(cmb_stock.SelectedValue));
                if (dt.Rows.Count > 0)
                {
                    if (Convert.ToDecimal(txt_money.Text) > Convert.ToDecimal(dt.Rows[0][0]))
                    {
                        MessageBox.Show("رصيد الخزنة الحالى غير كافى ");
                        return;
                    }
                }
                if (MessageBox.Show("هل تريد مسح القسط المحدد", "عمليه مسح قسط", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    //s.Add_StockPull(Convert.ToInt32(cmb_stock.SelectedValue), Convert.ToDecimal(dataGridView1.CurrentRow.Cells[3].Value), dateTimePicker1.Value, txt_username.Text, cmb_instalmenttype.Text + " " + " دفع قسط");
                    i.Delete_Installment(Convert.ToInt32(textBox1.Text));
                    s.add_insertStock(Convert.ToInt32(cmb_stock.SelectedValue), Convert.ToDecimal(txt_money.Text), 
                        dateTimePicker1.Value, txt_username.Text, " مسح قسط" + " " + cmb_instalmenttype.Text );

                    MessageBox.Show("تم مسح القسط بنجاح", "عمليه التعديل", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("تم الغاء عمليه المسح");
                }
                dataGridView1.DataSource = i.Selectinstallment();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }
        private void txt_money_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_money_MouseLeave(object sender, EventArgs e)
        {
            if (txt_money.Text=="")
            {
                txt_money.Text = "0";
            }
        }

        private void txt_money_Click(object sender, EventArgs e)
        {
            if (txt_money.Text=="0")
            {
                txt_money.Text ="";
            }
        }
    }
}
