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
    public partial class Frm_TransferToCompany : Form
    {
        Company c = new Company();
        ItemsXRaya ix = new ItemsXRaya();
        Branches b = new Branches();
        Stock s = new Stock();
        Users u = new Users();

        public Frm_TransferToCompany()
        {
            InitializeComponent();
            cmb_Company.DataSource = c.SelectCompany();
            cmb_Company.DisplayMember = "اسم الشركه";
            cmb_Company.ValueMember = "Comp_ID";
            txt_username.Text = Program.salesman;

            Permision();
        }
        void Permision()
        {
            dt.Clear();
            dt = u.SelectUserBranch(txt_username.Text);

            if (dt.Rows.Count > 0)
            {
                comboBox1.DataSource = u.SelectUserBranch(txt_username.Text);
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "Branch_ID";

                cmb_Stock.DataSource = s.SelectStockBranch(Convert.ToInt32(comboBox1.SelectedValue));
                cmb_Stock.DisplayMember = "Name_Stock";
                cmb_Stock.ValueMember = "ID_Stock";
            }
            else
            {
                comboBox1.DataSource = b.SelectCompBranches();
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "Branch_ID";

                Stock();
            }
        }
        void Stock()
        {

            cmb_Stock.DataSource = s.Compo_Stock();
            cmb_Stock.DisplayMember = "Name_Stock";
            cmb_Stock.ValueMember = "ID_Stock";

        }
        void Rent_Company()
        {
            if (txt_total.Text != "" && Txt_PricePayment.Text != "")
            {
                decimal Total = Convert.ToDecimal(txt_total.Text) - Convert.ToDecimal(Txt_PricePayment.Text);
                Txt_rentCompany.Text = Math.Round(Total, 1).ToString();
            }
        }
        void Patient_PaymentRate()
        {
            if (Txt_addtionPayment.Text != "" && Txt_PricePayment.Text != "")
            {
                if (Txt_addtionPayment.Text == "0")
                {
                    Txt_addtionPayment.Text = "0";
                    Txt_PricePayment.Text = "0";
                }
                else
                {
                    decimal Amount = Convert.ToDecimal(txt_total.Text);
                    decimal Discount = Convert.ToDecimal(Txt_addtionPayment.Text);
                    decimal Total = Amount * (Discount / 100);
                    Txt_PricePayment.Text = Math.Round(Total, 1).ToString();
                }
            }
            else
            {

                Txt_addtionPayment.Text = "0";
                Txt_PricePayment.Text = "0";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        void TotalRentCustomer()
        {
            decimal x;
            x = Convert.ToDecimal(txt_payLat.Text) - Convert.ToDecimal(Txt_PricePayment.Text);
            txt_rentCust.Text = x.ToString();
        }
        private void Frm_TransferToCompany_Load(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            TotalRentCustomer();
            Program.salesman = txt_username.Text;
            txt_patientname.Hide();
        }
        DataTable dt = new DataTable();
        DataTable dt12 = new DataTable();
        Tickets t = new Tickets();
        private void cmb_Company_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
            if (cmb_Company.Text != "")
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dt12 = c.selectXrayCompanyTransfer(Convert.ToInt32(cmb_Company.SelectedValue), Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value));
                    if (dt12.Rows.Count>0)
                    {
                        dataGridView2.DataSource = dt12;
                        dataGridView2.Columns[0].Visible = false;
                    }
                    else
                    {
                        dataGridView2.DataSource = null;
                        MessageBox.Show("يرجي العلم بان هذا الفحص غير مسجل في هذة الشركه");
                    }

                  
                    decimal total = 0;

                    for (int y = 0; y < dataGridView2.Rows.Count; y++)
                    {

                        total += Convert.ToDecimal(dataGridView2.Rows[y].Cells[2].Value);


                    }
                    txt_total.Text = Math.Round(total, 1).ToString();
                   




                }


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void Txt_addtionPayment_KeyUp(object sender, KeyEventArgs e)
        {
            Patient_PaymentRate();
            Rent_Company();
            TotalRentCustomer();
        }

        private void Txt_PricePayment_MouseUp(object sender, MouseEventArgs e)
        {
            Rent_Company();

        }
        Frm_Payouts p = new Frm_Payouts();
        Company cm = new Company();
        DataTable dt5 = new DataTable();

        private void btn_save_Click(object sender, EventArgs e)
        {

            //if (dataGridView2.Rows.Count>=0)
            //{
            dt5.Clear();
            dt5 = s.Select_moneyStock(Convert.ToInt32(cmb_Stock.SelectedValue));
            if (cmb_Stock.Text == "")
                {
                    MessageBox.Show("لا بد من تحديد خزنة");
                    return;

                }
      

                if (Convert.ToDecimal(txt_rentCust.Text) > Convert.ToDecimal(dt5.Rows[0][0]))
                {
                    MessageBox.Show("رصيد الخزنة الحالى غير كافى لسحب هذه المبلغ");
                    return;
                }
                  t.AddTransferForCompany(Convert.ToInt32(cmb_Company.SelectedValue), Convert.ToDecimal(Txt_addtionPayment.Text),
            Convert.ToDecimal(Txt_PricePayment.Text), Convert.ToDecimal(txt_total.Text), Convert.ToDecimal(txt_rentCust.Text),
            Convert.ToDecimal(Txt_rentCompany.Text), dateTimePicker1.Value, txt_reasonAddition.Text,
            Convert.ToInt32(dataGridView2.Rows[0].Cells[0].Value), Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value),
            txt_patientname.Text, Convert.ToInt32(cmb_Stock.SelectedValue), txt_username.Text,comboBox1.Text);
                
            
                cm.Update_CompanyTotalMoney(Convert.ToInt32(cmb_Company.SelectedValue), Convert.ToDecimal(Txt_rentCompany.Text));

                s.Add_StockPull(Convert.ToInt32(cmb_Stock.SelectedValue), Convert.ToDecimal(txt_rentCust.Text), dateTimePicker1.Value, txt_username.Text, "مردودات وتحولها الي جهه  "+cmb_Company.Text);
            MessageBox.Show("تم التسجيل بنجاح");
            this.Close();
                       

            //}
        }

        private void Txt_addtionPayment_KeyPress(object sender, KeyPressEventArgs e)
        {
          
            if (e.KeyChar == '.' && Txt_addtionPayment.Text.ToString().IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                e.Handled = true;
            }
          

        }

        private void Txt_addtionPayment_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void Txt_addtionPayment_MouseDown(object sender, MouseEventArgs e)
        {
            if (Txt_addtionPayment.Text == "0")
            {
                Txt_addtionPayment.Text = "";
            }
        }

        private void Txt_addtionPayment_TextChanged(object sender, EventArgs e)
        {
            if (Txt_addtionPayment.Text == ".")
            {
                Txt_addtionPayment.Text = "";
            }
        }

        private void btn_prod_Click(object sender, EventArgs e)
        {

            //if (dataGridView2.Rows.Count>=0)
            //{
            dt5.Clear();
            dt5 = s.Select_moneyStock(Convert.ToInt32(cmb_Stock.SelectedValue));
            if (cmb_Stock.Text == "")
            {
                MessageBox.Show("لا بد من تحديد خزنة");
                return;

            }


            if (Convert.ToDecimal(txt_rentCust.Text) > Convert.ToDecimal(dt5.Rows[0][0]))
            {
                MessageBox.Show("رصيد الخزنة الحالى غير كافى لسحب هذه المبلغ");
                return;
            }
            t.AddTransferForCompany(Convert.ToInt32(cmb_Company.SelectedValue), Convert.ToDecimal(Txt_addtionPayment.Text),
      Convert.ToDecimal(Txt_PricePayment.Text), Convert.ToDecimal(txt_total.Text), Convert.ToDecimal(txt_rentCust.Text),
      Convert.ToDecimal(Txt_rentCompany.Text), dateTimePicker1.Value, txt_reasonAddition.Text,
      Convert.ToInt32(dataGridView2.Rows[0].Cells[0].Value), Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value),
      txt_patientname.Text, Convert.ToInt32(cmb_Stock.SelectedValue), txt_username.Text, comboBox1.Text);


            cm.Update_CompanyTotalMoney(Convert.ToInt32(cmb_Company.SelectedValue), Convert.ToDecimal(Txt_rentCompany.Text));

            s.Add_StockPull(Convert.ToInt32(cmb_Stock.SelectedValue), Convert.ToDecimal(txt_rentCust.Text), dateTimePicker1.Value, txt_username.Text, "مردودات وتحولها الي جهه  " + cmb_Company.Text);
            MessageBox.Show("تم التسجيل بنجاح");
            this.Close();
        }
    }
}
