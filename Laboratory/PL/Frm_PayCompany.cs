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
    public partial class Frm_PayCompany : Form
    {
        Users u = new Users();
        Company c = new Company();
        Stock s = new Stock();
        Branches b = new Branches();
        DataTable dt = new DataTable();
        public Frm_PayCompany()
        {
            InitializeComponent();
            //txt_prise.Hide();
            //rdbPartPay.Hide();
            //RdbAllPay.Hide();
            //cmb_company.Hide();
            //btn_client.Hide();
            groupBox2.Hide();
            dataGridView1.DataSource = c.selectCompanyRent();
            Txt_SalesMAn.Text = Program.salesman;
            Permision();
            Calc();
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
        void Calc()
        {
            decimal total = 0;
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                total += Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);

            }
            txt_rent.Text = Math.Round(total, 2).ToString();
        }
        void Stock()
        {
            cmb_Stock.DataSource = s.Compo_Stock();
            cmb_Stock.DisplayMember = "Name_Stock";
            cmb_Stock.ValueMember = "ID_Stock";
        }
        private void Frm_PayCompany_Load(object sender, EventArgs e)
        {
            txt_search.Hide();
        }

        private void RdbAllCustomer_CheckedChanged(object sender, EventArgs e)
        {
            //if (RdbAllCustomer.Checked == true)
            //{
            //    dataGridView1.DataSource = c.selectCompanyRent();
            //}
            if (RdbAllCustomer.Checked == true)
            {

                rdbPartPay.Hide();
                RdbAllPay.Hide();
                btn_client.Hide();
                groupBox2.Hide();
                dataGridView1.DataSource = c.selectCompanyRent();
                decimal total = 0;
                for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
                {
                    total += Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);

                }
                txt_rent.Text = Math.Round(total, 1).ToString();
                cmb_company.Hide();
                txt_search.Hide();
            }
        }

        private void RdbOneCustomer_CheckedChanged(object sender, EventArgs e)
        {
            txt_prise.Enabled = true;

          
            cmb_company.Show();
            cmb_company.DataSource = c.SelectCompany();
            cmb_company.DisplayMember = "اسم الشركه";
            cmb_company.ValueMember = "Comp_ID";
            dataGridView1.DataSource = null;
            txt_rent.Text = "0";
        }

        private void RdbAllPay_CheckedChanged(object sender, EventArgs e)
        {
            txt_prise.Enabled = false;
        }

        private void rdbPartPay_CheckedChanged(object sender, EventArgs e)
        {
            txt_prise.Enabled = true;

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (RdbAllCustomer.Checked == true)
            //    {

            //        rdbPartPay.Hide();
            //        RdbAllPay.Hide();
            //        btn_client.Hide();

            //        dataGridView1.DataSource = c.selectCompanyRent();
            //        decimal total = 0;
            //        for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            //        {
            //            total += Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);

            //        }
            //        txt_rent.Text = Math.Round(total, 2).ToString();
            //    }

            //    //    else if (RdbOneCustomer.Checked == true)
                //    {
                //        txt_search.Show();
                //        rdbPartPay.Show();
                //        RdbAllPay.Show();
                //        btn_client.Show();

                //        dataGridView1.DataSource = c.selectOneCompanytRent(Convert.ToInt32(cmb_company.SelectedValue));
                //        decimal total = 0;
                //        for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
                //        {
                //            total += Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);

                //        }
                //        txt_rent.Text = Math.Round(total, 2).ToString();
                //    }

                //}
                //catch (Exception ex)
                //{

                //    MessageBox.Show(ex.Message);
                //}
            //}
            }

        private void btn_client_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_prise.Text == "")
                {
                    txt_prise.Text = "0";
                }
                if (cmb_Stock.Text == "")
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
                            if (RdbAllCustomer.Checked == true)
                            {
                                MessageBox.Show("من فضلك حدد اسم العميل", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            c.addPayCustomerCompany(Convert.ToInt32(cmb_company.SelectedValue), Convert.ToDecimal(dataGridView1.CurrentRow.Cells[4].Value)
                                , x, dateTimePicker1.Value, Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value), Convert.ToInt32(cmb_Stock.SelectedValue)
                                , Txt_SalesMAn.Text, Convert.ToInt32(Cmb_Branch.SelectedValue),dataGridView1.CurrentRow.Cells[1].Value.ToString());

                            s.add_insertStock(Convert.ToInt32(cmb_Stock.SelectedValue), Convert.ToDecimal(dataGridView1.CurrentRow.Cells[4].Value), 
                                               dateTimePicker1.Value, cmb_company.Text, "مدفوعات مديونية");
                            MessageBox.Show("تم دفع المبلغ بنجاح");
                            dataGridView1.DataSource = c.selectOneCompanytRent(Convert.ToInt32(cmb_company.SelectedValue));
                        }
                        else
                        {
                            MessageBox.Show("تم   الغاء العمليه بنجاح");
                            return;
                        }


                    }
                    else if (rdbPartPay.Checked == true)
                    {
                        decimal z = Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value) - Convert.ToDecimal(txt_prise.Text);


                        if (MessageBox.Show("هل تريد جزء من المبلغ ", "عمليه الدفع", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)

                        {
                            if (RdbAllCustomer.Checked == true)
                            {
                                MessageBox.Show("من فضلك حدد اسم العميل", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            if (Convert.ToDecimal(txt_prise.Text) > Convert.ToDecimal(dataGridView1.CurrentRow.Cells[4].Value))
                            {
                                MessageBox.Show("المبلغ المدفوع اكبر من مبلغ الفاتورة ", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txt_prise.Focus();
                                return;
                            }


                            c.addPayCustomerCompany(Convert.ToInt32(cmb_company.SelectedValue), Convert.ToDecimal(txt_prise.Text),
                                                    z, dateTimePicker1.Value, Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                              Convert.ToInt32(cmb_Stock.SelectedValue), Txt_SalesMAn.Text, Convert.ToInt32(Cmb_Branch.SelectedValue), dataGridView1.CurrentRow.Cells[1].Value.ToString());
                            s.add_insertStock(Convert.ToInt32(cmb_Stock.SelectedValue), Convert.ToDecimal(txt_prise.Text), dateTimePicker1.Value, cmb_company.Text, "مدفوعات مديونية");

                            MessageBox.Show("تم دفع المبلغ بنجاح");
                            dataGridView1.DataSource = c.selectOneCompanytRent(Convert.ToInt32(cmb_company.SelectedValue));

                        }
                        else
                        {
                            MessageBox.Show("تم   الغاء العمليه بنجاح");
                            return;
                        }
                    }


                for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
                {
                    total += Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);

                }
                txt_rent.Text = Math.Round(total, 2).ToString();



                txt_prise.Text = "0";

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
    

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            decimal totall=0;
        

            dt.Clear();
            dt = c.searchOneCompanytRent(txt_search.Text,Convert.ToInt32(cmb_company.SelectedValue));
            dataGridView1.DataSource = dt;
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                totall += Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);

            }
            txt_rent.Text = Math.Round(totall, 2).ToString();



        }

        private void cmb_company_SelectionChangeCommitted(object sender, EventArgs e)
        {
              if (RdbOneCustomer.Checked == true)
            {
                txt_search.Show();
                rdbPartPay.Show();
                RdbAllPay.Show();
                btn_client.Show();
                groupBox2.Show();
                txt_prise.Enabled = false;
                RdbAllPay.Checked = true;
                dataGridView1.DataSource = c.selectOneCompanytRent(Convert.ToInt32(cmb_company.SelectedValue));
                decimal total = 0;
                for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
                {
                    total += Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);

                }
                txt_rent.Text = Math.Round(total, 2).ToString();
            }

        }
           


        private void cmb_company_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_prise_MouseMove(object sender, MouseEventArgs e)
        {
            if (txt_prise.Text == "")
            {
                txt_prise.Text = "0";
            }
        }
    }
}
