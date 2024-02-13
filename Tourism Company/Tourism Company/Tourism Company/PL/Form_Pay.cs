using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tourism_Company.BL;

namespace Tourism_Company.PL
{
    public partial class Form_Pay : Form
    {

        Booking b = new Booking();
        Stock s = new Stock();
        DataTable dt = new DataTable();
        public Form_Pay()
        {
            InitializeComponent();

            cmb_company.Hide();
            txt_prise.Enabled = false;

            btn_company.Hide();
            btn_client.Hide();
            rdbPartPay.Hide();
            RdbAllPay.Hide();


        }

        private void Form_Pay_Load(object sender, EventArgs e)
        {
            cmb_Stock.DataSource = s.Compo_Stock();
            cmb_Stock.DisplayMember = "Treasury_name";
            cmb_Stock.ValueMember = "id_Treasury";
        }
        Customer c = new Customer();
        private void Btn_search_Click(object sender, EventArgs e)
        {
            try
            {




                if (RdbAllCustomer.Checked == true)
                {
                    rdbPartPay.Hide();
                    RdbAllPay.Hide();
                    btn_client.Hide();
                    btn_company.Hide();

                    dataGridView1.DataSource = b.selectClientRent();
                    decimal total = 0;
                    for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
                    {
                        total += Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value);

                    }
                    txt_rent.Text = Math.Round(total, 2).ToString();
                }

                else if (RdbOneCustomer.Checked == true)
                {
                    rdbPartPay.Show();
                    RdbAllPay.Show();

                    dataGridView1.DataSource = b.selectOneClientRent(Convert.ToInt32(cmb_company.SelectedValue));
                    decimal total = 0;
                    for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
                    {
                        total += Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);

                    }
                    txt_rent.Text = Math.Round(total, 2).ToString();
                }

                else if (RdbAllCompaany.Checked == true)
                {
                    rdbPartPay.Hide();
                    RdbAllPay.Hide();
                    btn_client.Hide();
                    btn_company.Hide();
                    dataGridView1.DataSource = b.selectCompanyRent();
                    decimal total = 0;
                    for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
                    {
                        total += Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value);

                    }
                    txt_rent.Text = Math.Round(total, 2).ToString();
                }
                else if (RdbOneCompany.Checked == true)
                {
                    rdbPartPay.Show();
                    RdbAllPay.Show();
                    btn_client.Hide();
                    btn_company.Show();
                    dataGridView1.DataSource = b.selectOneCompanyRent(Convert.ToInt32(cmb_company.SelectedValue));
                    decimal total = 0;
                    for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
                    {
                        total += Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);

                    }
                    txt_rent.Text = Math.Round(total, 2).ToString();
                }










            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RdbOneCustomer_CheckedChanged(object sender, EventArgs e)
        {
            txt_prise.Enabled = true;
            btn_client.Show();
            btn_company.Hide();
            cmb_company.Show();

            cmb_company.DataSource = c.CompoCustomer();
            cmb_company.DisplayMember = "Name";
            cmb_company.ValueMember = "ID";



        }

        private void RdbAllCustomer_CheckedChanged(object sender, EventArgs e)
        {

            cmb_company.Hide();



        }

        private void RdbOneCompany_CheckedChanged(object sender, EventArgs e)
        {
            txt_prise.Enabled = true;
            btn_client.Hide();
            btn_company.Show();
            Company cm = new Company();

            cmb_company.Show();

            cmb_company.DataSource = cm.CompoCompany();
            cmb_company.DisplayMember = "Name";
            cmb_company.ValueMember = "ID";




        }

        private void RdbAllCompaany_CheckedChanged(object sender, EventArgs e)
        {
            cmb_company.Hide();
        }

        private void RdbAllPay_CheckedChanged(object sender, EventArgs e)
        {
            txt_prise.Enabled = false;
        }




        



        private void Button2_Click(object sender, EventArgs e)
        {
            decimal x = 0;
            decimal total = 0;
            if (dataGridView1.Rows.Count >= 1)

                if (RdbAllPay.Checked == true)
                {

                    if (MessageBox.Show("هل تريد دفع المبلغ بالكامل", "عمليه الدفع", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)

                    {
                        if (RdbAllCustomer.Checked == true) { MessageBox.Show("من فضلك حدد اسم العميل", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }



                        b.addPayClient(Convert.ToInt32(cmb_company.SelectedValue), Convert.ToDecimal(dataGridView1.CurrentRow.Cells[3].Value), x, dateTimePicker1.Value, Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                        s.add_insertStock(Convert.ToInt32(cmb_Stock.SelectedValue), Convert.ToDecimal(dataGridView1.CurrentRow.Cells[3].Value), dateTimePicker1.Value, cmb_company.Text, "مدفوعات مديونية", "فلوس قديمة");
                        MessageBox.Show("تم دفع المبلغ بنجاح");
                        dataGridView1.DataSource = b.selectOneClientRent(Convert.ToInt32(cmb_company.SelectedValue));


                     

                    }
                    

                    else
                    {
                        MessageBox.Show("تم   الغاء العمليه بنجاح");
                        return;
                    }

                 
                }
                else if (rdbPartPay.Checked==true)
                {
                    decimal z = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value) - Convert.ToDecimal(txt_prise.Text);


                    if (MessageBox.Show("هل تريد جزء من المبلغ ", "عمليه الدفع", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)

                    {
                        if (RdbAllCustomer.Checked == true) { MessageBox.Show("من فضلك حدد اسم العميل", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }



                        b.addPayClient(Convert.ToInt32(cmb_company.SelectedValue), Convert.ToDecimal(txt_prise.Text), z, dateTimePicker1.Value, Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                        s.add_insertStock(Convert.ToInt32(cmb_Stock.SelectedValue), Convert.ToDecimal(txt_prise.Text), dateTimePicker1.Value, cmb_company.Text, "مدفوعات مديونية", "فلوس قديمة");

                        MessageBox.Show("تم دفع المبلغ بنجاح");
                        dataGridView1.DataSource = b.selectOneClientRent(Convert.ToInt32(cmb_company.SelectedValue));




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
            txt_rent.Text = Math.Round(total, 2).ToString();



            txt_prise.Text = "0";


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            decimal x = 0;
            decimal total = 0;
            if (dataGridView1.Rows.Count >= 1)

                if (RdbAllPay.Checked == true)
                {

                    if (MessageBox.Show("هل تريد دفع المبلغ بالكامل", "عمليه الدفع", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)

                    {
                        if (RdbAllCompaany.Checked == true) { MessageBox.Show("من فضلك حدد اسم العميل", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }



                        b.addPayCompany(Convert.ToInt32(cmb_company.SelectedValue), Convert.ToDecimal(dataGridView1.CurrentRow.Cells[3].Value), x, dateTimePicker1.Value, Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                        MessageBox.Show("تم دفع المبلغ بنجاح");
                        dataGridView1.DataSource = b.selectOneCompanyRent(Convert.ToInt32(cmb_company.SelectedValue));


                    

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


                    if (MessageBox.Show("هل تريد جزء من المبلغ ", "عمليه الدفع", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)

                    {
                        if (RdbAllCompaany.Checked == true) { MessageBox.Show("من فضلك حدد اسم العميل", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }



                        b.addPayCompany(Convert.ToInt32(cmb_company.SelectedValue), Convert.ToDecimal(txt_prise.Text), z, dateTimePicker1.Value, Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                        MessageBox.Show("تم دفع المبلغ بنجاح");
                        dataGridView1.DataSource = b.selectOneCompanyRent(Convert.ToInt32(cmb_company.SelectedValue));


                        txt_prise.Text = "0";

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
            txt_rent.Text = Math.Round(total, 2).ToString();






        }

        private void Txt_prise_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && txt_prise.Text.ToString().IndexOf('.') > -1)
            {
                e.Handled = true;
            }

            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {

                e.Handled = true;


            }
        }

        private void RdbPartPay_CheckedChanged(object sender, EventArgs e)
        {
            txt_prise.Enabled = true;
        }

        private void Txt_prise_TextChanged(object sender, EventArgs e)
        {
            if (txt_prise.Text=="")
            {
                txt_prise.Text = "0";
           
            }
        }

        private void Txt_prise_MouseClick(object sender, MouseEventArgs e)
        {
            txt_prise.SelectAll();
        }
    }
}
    
    
    
    

