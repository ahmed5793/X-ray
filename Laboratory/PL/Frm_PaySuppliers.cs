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
    public partial class Frm_PaySuppliers : Form
    {
        Suppliers Suppliers = new Suppliers();
        Stock Stock = new Stock();
        DataTable dt4 = new DataTable();
        public Frm_PaySuppliers()
        {
            InitializeComponent();
            cmb_Stock.DataSource = Stock.Compo_Stock();
            cmb_Stock.DisplayMember = "Name_Stock";
            cmb_Stock.ValueMember = "ID_Stock";
            if (dt4.Rows.Count > 0)
            {
                dt4 = Stock.Select_moneyStock(Convert.ToInt32(cmb_Stock.SelectedValue));

            }

            comboBox1.DataSource = Suppliers.Combo_SupplierRent();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Sup_id";
            Txt_sales.Text = Program.salesman;

            txt_prise.Enabled = false;
            comboBox1.Enabled = false;
            rdbPartPay.Hide();
            RdbAllPay.Hide();
            btnPay.Hide();
            txt_prise.Hide();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (RdbAllSuppliers.Checked == true)
                {
                    rdbPartPay.Hide();
                    RdbAllPay.Hide();
                    btnPay.Hide();
                    txt_prise.Hide();
                    dataGridView1.DataSource = Suppliers.SelectSuppliersMony();
               

                }
                else if (RdbOneSuppliers.Checked == true)
                {
                    rdbPartPay.Show();
                    RdbAllPay.Show();
                    btnPay.Show();
                    txt_prise.Show();
                    dataGridView1.DataSource = Suppliers.SelectOneSuppliersMony(Convert.ToInt32(comboBox1.SelectedValue));
       
                }

                decimal total = 0;
                for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
                {
                    total += Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value);

                }
                txt_rent.Text = Math.Round(total, 1).ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void RdbAllSuppliers_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbAllSuppliers.Checked == true)
            {
                comboBox1.Enabled = false;
            }
            else
            {
                comboBox1.Enabled = true;
            }
        }

        private void RdbAllPay_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbAllPay.Checked == true)
            {
                txt_prise.Enabled = false;
            }

            else
            {
                txt_prise.Enabled = true;
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count >= 1)
                {
                    if (cmb_Stock.Text == "")
                    {
                        MessageBox.Show("لا بد من تحديد خزنة");
                        return;

                    }
                    if (RdbAllPay.Checked == true)
                    {

                        if (MessageBox.Show("هل تريد دفع المبلغ بالكامل", "عمليه الدفع", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)

                        {
                            if (RdbAllSuppliers.Checked == true)
                            {
                                MessageBox.Show("من فضلك حدد اسم العميل", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            else if (Convert.ToDecimal(dataGridView1.CurrentRow.Cells[2].Value) > Convert.ToDecimal(dt4.Rows[0][0]))
                            {
                                MessageBox.Show("رصيد الخزنة الحالى غير كافى لشراء هذه الفاتورة");
                                return;
                            }
                            Suppliers.AddPaySuppliers(
                                Convert.ToInt32(comboBox1.SelectedValue), Convert.ToDecimal(dataGridView1.CurrentRow.Cells[2].Value)
                               , dateTimePicker1.Value,Convert.ToInt32(cmb_Stock.SelectedValue),Txt_sales.Text);
                            Stock.Add_StockPull(Convert.ToInt32(cmb_Stock.SelectedValue), Convert.ToDecimal(dataGridView1.CurrentRow.Cells[2].Value), dateTimePicker1.Value, comboBox1.Text, comboBox1.Text + " مدفوعات مورد");

                            MessageBox.Show("تم دفع المبلغ بنجاح");
                            dataGridView1.DataSource = Suppliers.SelectOneSuppliersMony(Convert.ToInt32(comboBox1.SelectedValue));
                            comboBox1.DataSource = Suppliers.Combo_SupplierRent();


                        }
                        else
                        {
                            MessageBox.Show("تم إلغاء العملية بنجاح");
                            return;

                        }
                    }
                    else if (rdbPartPay.Checked == true)
                    {
                        if (MessageBox.Show("هل تريد دفع المبلغ المحدد", "عمليه الدفع", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)

                        {
                            dt4 = Stock.Select_moneyStock(Convert.ToInt32(cmb_Stock.SelectedValue));

                            decimal x = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[2].Value) - Convert.ToDecimal(txt_prise.Text);

                            if (RdbAllSuppliers.Checked == true)
                            {
                                MessageBox.Show("من فضلك حدد اسم العميل", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            else if (Convert.ToDecimal(txt_prise.Text) > Convert.ToDecimal(dt4.Rows[0][0]))
                            {
                                MessageBox.Show("رصيد الخزنة الحالى غير كافى لشراء هذه الفاتورة");
                                return;
                            }

                            Suppliers.AddPaySuppliers(
                                Convert.ToInt32(comboBox1.SelectedValue), Convert.ToDecimal(dataGridView1.CurrentRow.Cells[2].Value)
                               , dateTimePicker1.Value, Convert.ToInt32(cmb_Stock.SelectedValue), Txt_sales.Text);
                            MessageBox.Show("تم دفع المبلغ بنجاح");

                            Stock.Add_StockPull(Convert.ToInt32(cmb_Stock.SelectedValue), Convert.ToDecimal(txt_prise.Text), 
                                dateTimePicker1.Value, Txt_sales.Text,  comboBox1.Text + " مدفوعات مورد");
                            
                            dataGridView1.DataSource = Suppliers.SelectOneSuppliersMony(Convert.ToInt32(comboBox1.SelectedValue));


                        }
                        else
                        {
                            MessageBox.Show("تم إلغاء العملية بنجاح");
                            return;

                        }
                    }
                    decimal total = 0;
                    for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
                    {
                        total += Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value);

                    }
                    txt_rent.Text = Math.Round(total, 1).ToString();
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txt_prise_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && txt_prise.Text.ToString().IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))

            {
                e.Handled = true;

            }
        }

        private void Frm_PaySuppliers_Load(object sender, EventArgs e)
        {
        }
    }
}
