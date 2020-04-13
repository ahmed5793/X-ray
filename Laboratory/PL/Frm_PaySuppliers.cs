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
        DataTable dt5= new DataTable();
        Branches b = new Branches();
        Users u = new Users();
        public Frm_PaySuppliers()
        {
            InitializeComponent();
            Function();
        }
        void Permision()
        {
            dt.Clear();
            dt = u.SelectUserBranch(Txt_sales.Text);

            if (dt.Rows.Count > 0)
            {
                Cmb_Branch.DataSource = u.SelectUserBranch(Txt_sales.Text);
                Cmb_Branch.DisplayMember = "Name";
                Cmb_Branch.ValueMember = "Branch_ID";

                cmb_Stock.DataSource = Stock.SelectStockBranch(Convert.ToInt32(Cmb_Branch.SelectedValue));
                cmb_Stock.DisplayMember = "Name_Stock";
                cmb_Stock.ValueMember = "ID_Stock";
            }
            else
            {
                Cmb_Branch.DataSource = b.SelectCompBranches();
                Cmb_Branch.DisplayMember = "Name";
                Cmb_Branch.ValueMember = "Branch_ID";

                cmb_Stock.DataSource = Stock.SelectStockBranch(Convert.ToInt32(Cmb_Branch.SelectedValue));
                cmb_Stock.DisplayMember = "Name_Stock";
                cmb_Stock.ValueMember = "ID_Stock";
            }
        }

        void Function()
        {
            try
            {
                Txt_sales.Text = Program.salesman;
                Permision();
                if (dt4.Rows.Count > 0)
                {
                    dt4 = Stock.Select_moneyStock(Convert.ToInt32(cmb_Stock.SelectedValue));
                }
                comboBox1.DataSource = Suppliers.Combo_SupplierRent();
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "Sup_id";

                txt_prise.Enabled = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
        }

        private void RdbAllSuppliers_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void RdbAllPay_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbAllPay.Checked == true)
            {
                txt_prise.Enabled = false;
                txt_prise.Text = "0";
            }

            else
            {
                txt_prise.Enabled = true;
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
           
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

        private void RdbOneSuppliers_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txt_prise_MouseMove(object sender, MouseEventArgs e)
        {
            if (txt_prise.Text=="")
            {
                txt_prise.Text = "0";
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
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
                    dt4 = Stock.Select_moneyStock(Convert.ToInt32(cmb_Stock.SelectedValue));

                    if (RdbAllPay.Checked == true)
                    {

                        if (MessageBox.Show("هل تريد دفع المبلغ بالكامل", "عمليه الدفع", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)

                        {

                            if (Convert.ToDecimal(dataGridView1.CurrentRow.Cells[2].Value) > Convert.ToDecimal(dt4.Rows[0][0]))
                            {
                                MessageBox.Show("رصيد الخزنة الحالى غير كافى لشراء هذه الفاتورة");
                                return;
                            }
                            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                            {

                                Suppliers.AddPaySuppliers(Convert.ToInt32(comboBox1.SelectedValue), Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value)
                                   , dateTimePicker1.Value, Convert.ToInt32(cmb_Stock.SelectedValue), Txt_sales.Text);
                                Stock.Add_StockPull(Convert.ToInt32(cmb_Stock.SelectedValue), Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value),
                                    dateTimePicker1.Value, Txt_sales.Text, " مدفوعات مورد" + " " + comboBox1.Text);

                                dt5.Clear();
                                dt5 = Suppliers.Select_SupplierTotalMoney(Convert.ToInt32(comboBox1.SelectedValue));
                                decimal mno = Convert.ToDecimal(dt5.Rows[0][0]) - Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value);

                                Suppliers.Update_SupplierTotalMoney(Convert.ToInt32(comboBox1.SelectedValue), mno);
                                Suppliers.Add_SupplierStatmentACCount(Convert.ToInt32(comboBox1.SelectedValue), 0
                                    , Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value), mno, "مدفوعات مورد", dateTimePicker1.Value);
                            }


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
                        if (Convert.ToDecimal(txt_prise.Text) > Convert.ToDecimal(dt4.Rows[0][0]))
                        {
                            MessageBox.Show("رصيد الخزنة الحالى غير كافى لشراء هذه الفاتورة");
                            return;
                        }
                        else if (Convert.ToDecimal(txt_prise.Text) > Convert.ToDecimal(dataGridView1.CurrentRow.Cells[2].Value))
                        {
                            MessageBox.Show("المبلغ المراد تسديده اكبر من المبلغ المتبقى للمورد");
                            txt_prise.Focus();
                            return;
                        }
                        if (MessageBox.Show("هل تريد دفع المبلغ المحدد", "عمليه الدفع", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)

                        {
                            decimal x = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[2].Value) - Convert.ToDecimal(txt_prise.Text);
                           
                            if (Convert.ToDecimal(txt_prise.Text) > 0)
                            {
                                Suppliers.AddPaySuppliers(
                                    Convert.ToInt32(comboBox1.SelectedValue), Convert.ToDecimal(txt_prise.Text)
                                   , dateTimePicker1.Value, Convert.ToInt32(cmb_Stock.SelectedValue), Txt_sales.Text);

                                Stock.Add_StockPull(Convert.ToInt32(cmb_Stock.SelectedValue), Convert.ToDecimal(txt_prise.Text),
                                                   dateTimePicker1.Value, Txt_sales.Text, "مدفوعات من حساب  المورد" +" "+ comboBox1.Text );

                                dt5.Clear();
                                dt5 = Suppliers.Select_SupplierTotalMoney(Convert.ToInt32(comboBox1.SelectedValue));
                                decimal mno = Convert.ToDecimal(dt5.Rows[0][0]) - Convert.ToDecimal(txt_prise.Text);

                                Suppliers.Update_SupplierTotalMoney(Convert.ToInt32(comboBox1.SelectedValue), mno);
                                Suppliers.Add_SupplierStatmentACCount(Convert.ToInt32(comboBox1.SelectedValue), 0
                                    , Convert.ToDecimal(txt_prise.Text), mno, "مدفوعات مورد", dateTimePicker1.Value);

                        
                                MessageBox.Show("تم دفع المبلغ بنجاح");
                            }
                        }
                        else
                        {
                            MessageBox.Show("تم إلغاء العملية بنجاح");
                            return;
                        }
                        dataGridView1.DataSource = Suppliers.SelectOneSuppliersMony(Convert.ToInt32(comboBox1.SelectedValue));
                        txt_prise.Text = "0";
                    }
                }
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
                if (comboBox1.Text != "")
                {
                    dataGridView1.DataSource = Suppliers.SelectOneSuppliersMony(Convert.ToInt32(comboBox1.SelectedValue));
                }
                else
                {
                    MessageBox.Show("لا بد من إختيار إسم المورد");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void txt_prise_Click(object sender, EventArgs e)
        {
            if (txt_prise.Text=="0")
            {
                txt_prise.Text = "";
            }
            else
            {
                txt_prise.SelectAll();
                    
            }
        }
        DataTable dt = new DataTable();

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text != "")
                {
                    dt.Clear();
                    dt = Suppliers.Validate_SuppliersName(Convert.ToInt32(comboBox1.SelectedValue));
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("هذا الاسم غير موجود فى قائمة الموردين");
                        comboBox1.Focus();
                        comboBox1.SelectAll();
                        return;
                    }
                }
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
            }
    }
}
