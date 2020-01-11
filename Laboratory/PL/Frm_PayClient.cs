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
    public partial class Frm_PayClient : Form
    {
        Customer c = new Customer();
        Stock s = new Stock();
        Users u = new Users();
        Branches b = new Branches();
        DataTable dt = new DataTable();
        public Frm_PayClient()
        {
            InitializeComponent();
            dataGridView1.DataSource = c.selectClientRent();
            RdbAllCustomer.Checked = true;
            cmb_client.Hide();
            txt_prise.Hide();
            rdbPartPay.Hide();
            RdbAllPay.Hide();
            btn_client.Hide();
            Txt_SalesMAn.Text = Program.salesman;
         
      
            Permision();
            Calctotalrent();

        }
        void CalcOne()
        {
            decimal total = 0;
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                total += Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);

            }
            txt_rent.Text = Math.Round(total, 1).ToString();
        }
        void Calctotalrent()
        {
            decimal total = 0;
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                total += Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value);

            }
            txt_rent.Text = Math.Round(total, 1).ToString();
        }
        void Permision()
        {
            dt.Clear();
            dt = u.SelectUserBranch(Txt_SalesMAn.Text);

            if (dt.Rows.Count > 0)
            {
                Cmb_Branch.DataSource = u.SelectUserBranch(Txt_SalesMAn.Text);
                Cmb_Branch.DisplayMember = "Name";
                Cmb_Branch.ValueMember = "Branch_ID";

                cmb_Stock.DataSource = s.SelectStockBranch(Convert.ToInt32(Cmb_Branch.SelectedValue));
                cmb_Stock.DisplayMember = "Name_Stock";
                cmb_Stock.ValueMember = "ID_Stock";
            }
            else
            {
                Cmb_Branch.DataSource = b.SelectCompBranches();
                Cmb_Branch.DisplayMember = "Name";
                Cmb_Branch.ValueMember = "Branch_ID";

                Stock();
            }
        }
        void Stock()
        {
            cmb_Stock.DataSource = s.Compo_Stock();
            cmb_Stock.DisplayMember = "Name_Stock";
            cmb_Stock.ValueMember = "ID_Stock";
        }

        private void RdbAllCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbAllCustomer.Checked==true)
            {
                dataGridView1.DataSource = c.selectClientRent();
                cmb_client.Hide();
                txt_prise.Hide();
                rdbPartPay.Hide();
                RdbAllPay.Hide();
                btn_client.Hide();
            }
        }

        private void RdbOneCustomer_CheckedChanged(object sender, EventArgs e)
        {
            cmb_client.Show();
            txt_prise.Show();
            rdbPartPay.Show();
            RdbAllPay.Show();
            btn_client.Show();

            txt_prise.Enabled = true;
            dataGridView1.DataSource = null;
            cmb_client.DataSource = c.SelectRentCompoCustomer();
            cmb_client.DisplayMember = "Cust_Name";
            cmb_client.ValueMember = "Cust_ID";
        }

        private void RdbAllPay_CheckedChanged(object sender, EventArgs e)
        {
            txt_prise.Enabled = false;
        }

        private void rdbPartPay_CheckedChanged(object sender, EventArgs e)
        {
            txt_prise.Enabled = true;
        }

        private void btn_client_Click(object sender, EventArgs e)
        {
            if (txt_prise.Text == "")
            {
                txt_prise.Text = "0";
            }
            if (cmb_Stock.Text=="")
            {
                MessageBox.Show("من فضلك قم بااختيار الخزينة");
                return;
            }
            decimal x = 0;
            decimal total = 0;
            if (dataGridView1.Rows.Count >= 1)

                if (RdbAllPay.Checked == true)
                {

                    if (MessageBox.Show("هل تريد دفع المبلغ بالكامل", "عمليه الدفع", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)

                    {
                        if (RdbAllCustomer.Checked == true) { MessageBox.Show("من فضلك حدد اسم العميل", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }



                      c.addPayClient(Convert.ToInt32(cmb_client.SelectedValue), Convert.ToDecimal(dataGridView1.CurrentRow.Cells[3].Value),
                            x, dateTimePicker1.Value, Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                            Convert.ToInt32(cmb_Stock.SelectedValue),Txt_SalesMAn.Text, Convert.ToInt32(Cmb_Branch.SelectedValue));
                        s.add_insertStock(Convert.ToInt32(cmb_Stock.SelectedValue), Convert.ToDecimal(dataGridView1.CurrentRow.Cells[3].Value), dateTimePicker1.Value, cmb_client.Text, "مدفوعات مديونية");
                        MessageBox.Show("تم دفع المبلغ بنجاح");
                        dataGridView1.DataSource = c.selectOneClientRent(Convert.ToInt32(cmb_client.SelectedValue));
                    }
                    else
                    {
                        MessageBox.Show("تم   الغاء العمليه بنجاح");
                        return;
                    }
                }
                else if (rdbPartPay.Checked == true)
                {
                    decimal z = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value) - Convert.ToDecimal(txt_prise.Text);

                    if (Convert.ToDecimal(txt_prise.Text) > Convert.ToDecimal(dataGridView1.CurrentRow.Cells[3].Value))
                    {
                        MessageBox.Show("المبلغ المدفوع اكبر من المبلغ الموجود حاليا على الشركة  ", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txt_prise.Focus();
                        return;
                    }
                    if (MessageBox.Show("هل تريد جزء من المبلغ ", "عمليه الدفع", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)

                    {
                        if (RdbAllCustomer.Checked == true)
                        { 
                            MessageBox.Show("من فضلك حدد اسم العميل", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                            return;
                        }

                        c.addPayClient(Convert.ToInt32(cmb_client.SelectedValue), Convert.ToDecimal(txt_prise.Text), z,
                            dateTimePicker1.Value, Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value), 
                            Convert.ToInt32(cmb_Stock.SelectedValue),Txt_SalesMAn.Text, Convert.ToInt32(Cmb_Branch.SelectedValue));
                        s.add_insertStock(Convert.ToInt32(cmb_Stock.SelectedValue), Convert.ToDecimal(txt_prise.Text), dateTimePicker1.Value, Txt_SalesMAn.Text, cmb_client.Text + " "+"مدفوعات مديونية");
                        MessageBox.Show("تم دفع المبلغ بنجاح");
                        dataGridView1.DataSource = c.selectOneClientRent(Convert.ToInt32(cmb_client.SelectedValue));


                    }


                    else
                    {
                        MessageBox.Show("تم   الغاء العمليه بنجاح");
                        return;
                    }


                }


            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                total += Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);

            }
            txt_rent.Text = Math.Round(total, 1).ToString();



            txt_prise.Text = "0";
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (RdbAllCustomer.Checked == true)
                {
                    rdbPartPay.Hide();
                    RdbAllPay.Hide();
                    btn_client.Hide();

                    dataGridView1.DataSource = c.selectClientRent();
                    Calctotalrent();
                }

                else if (RdbOneCustomer.Checked == true)
                {
                    rdbPartPay.Show();
                    RdbAllPay.Show();
                    btn_client.Show();

                    dataGridView1.DataSource = c.selectOneClientRent(Convert.ToInt32(cmb_client.SelectedValue));
                    CalcOne();
                }

            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            }
        }

        private void txt_prise_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && txt_prise.Text.ToString().IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar((System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)))
            {
                e.Handled = true;
            }
        }

        private void Frm_PayClient_Load(object sender, EventArgs e)
        {

        }

        private void txt_prise_Click(object sender, EventArgs e)
        {
            txt_prise.Text = "";
        }

        private void txt_prise_MouseMove(object sender, MouseEventArgs e)
        {
            if (txt_prise.Text == "")
            {
                txt_prise.Text = "0";
            }
        }

        private void cmb_client_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void cmb_client_Leave(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                if (cmb_client.Text != "")
                {
                    dt.Clear();
                    dt = c.validate_CustomerName(Convert.ToInt32(cmb_client.SelectedValue));
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("إسم العميل غير موجود لا بد من إختيار إسم العميل من القائمة");
                        cmb_client.Focus();
                        return;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                dt.Dispose();
            }
        }
    }
}
