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
    public partial class Frm_NoticeAmountCustomer : Form
    {
        Customer C = new Customer();
        Users u = new Users();
        Branches b = new Branches();
        Stock s = new Stock();
        DataTable dt5 = new DataTable();
        DataTable dt = new DataTable();
        public Frm_NoticeAmountCustomer()
        {
            InitializeComponent();
            function();
        }
        void function()
        {
            try
            {
                comboBox2.DataSource = C.SelectCompoCustomerN2dy();
                comboBox2.DisplayMember = "Cust_Name";
                comboBox2.ValueMember = "Cust_ID";
                comboBox2.SelectedIndex = -1;
                txt_username.Text = Program.salesman;
                /////////
                dt.Clear();
                dt = u.SelectUserBranch(txt_username.Text);

                if (dt.Rows.Count > 0)
                {
                    comboBox1.DataSource = u.SelectUserBranch(txt_username.Text);
                    comboBox1.DisplayMember = "Name";
                    comboBox1.ValueMember = "Branch_ID";

                }
                else
                {
                    comboBox1.DataSource = b.SelectCompBranches();
                    comboBox1.DisplayMember = "Name";
                    comboBox1.ValueMember = "Branch_ID";

                    //Stock();
                }

                cmb_Stock.DataSource = s.SelectStockBranch(Convert.ToInt32(comboBox1.SelectedValue));
                cmb_Stock.DisplayMember = "Name_Stock";
                cmb_Stock.ValueMember = "ID_Stock";
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void comboBox2_Leave(object sender, EventArgs e)
        {
            try
            {
                if (comboBox2.Text != "")
                {
                    dt.Clear();
                    dt = C.validate_CustomerName(Convert.ToInt32(comboBox2.SelectedValue));
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("إسم العميل غير موجود لا بد من إختيار إسم العميل من القائمة");
                        comboBox2.Focus();
                        textBox1.Clear();
                        comboBox2.Text = "";
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                dt5.Clear();
                dt5 = C.Select_CustomertotalBAlance(Convert.ToInt32(comboBox2.SelectedValue));
                textBox1.Text = dt5.Rows[0][0].ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmb_Stock.DataSource = s.SelectStockBranch(Convert.ToInt32(comboBox1.SelectedValue));
            cmb_Stock.DisplayMember = "Name_Stock";
            cmb_Stock.ValueMember = "ID_Stock";
        }

        private void Txt_PayLast_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_PayLast_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                e.Handled = true;
            }
            else if (e.KeyChar=='.' && Txt_PayLast.Text.ToString().IndexOf('.')>-1)
            {
                e.Handled = true;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Txt_PayLast.Text=="" || Txt_PayLast.Text=="0")
                {
                    MessageBox.Show("لا بد من تحديد المبلغ");
                    Txt_PayLast.Focus();
                    return;
                }
                dt5.Clear();
                dt5 = s.Select_moneyStock(Convert.ToInt32(cmb_Stock.SelectedValue));

                if (Convert.ToDecimal(Txt_PayLast.Text) > Convert.ToDecimal(dt5.Rows[0][0]))
                {
                    MessageBox.Show("رصيد الخزنة الحالى غير كافى لسحب هذه المبلغ");
                    return;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
