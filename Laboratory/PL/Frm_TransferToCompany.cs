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
        DataTable dt = new DataTable();
        DataTable dt12 = new DataTable();
        Tickets t = new Tickets();
        Customer cu = new Customer();
        public Frm_TransferToCompany()
        {
            InitializeComponent();
            Function();
        }
        void Function()
        {
            try
            {
                cmb_Company.DataSource = c.SelectCompany();
                cmb_Company.DisplayMember = "اسم الشركه";
                cmb_Company.ValueMember = "Comp_ID";
                txt_username.Text = Program.salesman;
                Txt_IdCust.Hide();
                Permision();                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
        void Stock()
        {

            cmb_Stock.DataSource = s.Compo_Stock();
            cmb_Stock.DisplayMember = "Name_Stock";
            cmb_Stock.ValueMember = "ID_Stock";

        }
        void Rent_Company()
        {
            if (Txt_Total.Text != "" && Txt_PricePayment.Text != "")
            {
                decimal Total = Convert.ToDecimal(Txt_Total.Text) - Convert.ToDecimal(Txt_PricePayment.Text);
                Txt_RentCompany.Text = Math.Round(Total, 1).ToString();
            }
        }
        void Patient_PaymentRate()
        {
            if (Txt_addtionPaymentrate.Text != "" && Txt_PricePayment.Text != "")
            {
                if (Txt_addtionPaymentrate.Text == "0")
                {
                    Txt_addtionPaymentrate.Text = "0";
                    Txt_PricePayment.Text = "0";
                }
                else
                {
                    decimal Amount = Convert.ToDecimal(Txt_Total.Text);
                    decimal Discount = Convert.ToDecimal(Txt_addtionPaymentrate.Text);
                    decimal Total = Amount * (Discount / 100);
                    Txt_PricePayment.Text = Math.Round(Total, 1).ToString();
                }
            }
            else
            {
                Txt_addtionPaymentrate.Text = "0";
                Txt_PricePayment.Text = "0";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        void TotalRentCustomer()
        {
            decimal x ,y ;
            if (Convert.ToDecimal(Txt_PayLast.Text) - Convert.ToDecimal(Txt_LastPayOut.Text) > Convert.ToDecimal(Txt_PricePayment.Text))
            {
                x = Convert.ToDecimal(Txt_PayLast.Text) - Convert.ToDecimal(Txt_LastPayOut.Text);
                y = x - Convert.ToDecimal(Txt_PricePayment.Text);
                textBox2.Text = y.ToString();
                Txt_RentCustomer.Text = "0";
            }
            else if (Convert.ToDecimal(Txt_PricePayment.Text) > Convert.ToDecimal(Txt_PayLast.Text) - Convert.ToDecimal(Txt_LastPayOut.Text))
            {
                textBox2.Text = "0";
                x = Convert.ToDecimal(Txt_PayLast.Text) - Convert.ToDecimal(Txt_LastPayOut.Text);
                y =  Convert.ToDecimal(Txt_PricePayment.Text)-x;
                Txt_RentCustomer.Text = y.ToString();
            }
        }
        private void Frm_TransferToCompany_Load(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            txt_IdTeckit.Hide();
            Txt_IdCust.Hide();
            Txt_TotalBeforeTransfair.Hide();
            Txt_OldRentBeforeTransfair.Hide();
            //TotalRentCustomer();
            Program.salesman = txt_username.Text;
            txt_patientname.Hide();
        }

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
                    Txt_Total.Text = Math.Round(total, 1).ToString();

                    Patient_PaymentRate();
                    Rent_Company();
                    TotalRentCustomer();
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

            //if (Convert.ToDecimal(Txt_PayLast.Text) - Convert.ToDecimal(Txt_LastPayOut.Text) > Convert.ToDecimal(Txt_PricePayment.Text))
            //{
            //    TotalRentCustomer();
            //}
            //else if (Convert.ToDecimal(Txt_PricePayment.Text) > Convert.ToDecimal(Txt_PayLast.Text) - Convert.ToDecimal(Txt_LastPayOut.Text))
            //{
            //    textBox2.Text = "0";
            //}
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
        }

        private void Txt_addtionPayment_KeyPress(object sender, KeyPressEventArgs e)
        {
          
            if (e.KeyChar == '.' && Txt_addtionPaymentrate.Text.ToString().IndexOf('.') > -1)
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
         
        }

        private void Txt_addtionPayment_TextChanged(object sender, EventArgs e)
        {
            if (Txt_addtionPaymentrate.Text == ".")
            {
                Txt_addtionPaymentrate.Text = "";
            }
            
        }

        private void cmb_Company_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_total_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
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
                if (cmb_Company.Text == "")
                {
                    MessageBox.Show("لا بد من تحديد الشركة");
                    cmb_Company.Focus();
                    return;
                }
           
                if (Convert.ToDecimal(Txt_PayLast.Text) - Convert.ToDecimal(Txt_LastPayOut.Text) > Convert.ToDecimal(Txt_PricePayment.Text))
                {

                    if (Convert.ToDecimal(textBox2.Text) > 0)
                    {
                        dt5.Clear();
                        dt5 = s.Select_moneyStock(Convert.ToInt32(cmb_Stock.SelectedValue));

                        if (Convert.ToDecimal(textBox2.Text) > Convert.ToDecimal(dt5.Rows[0][0]))
                        {
                            MessageBox.Show("رصيد الخزنة الحالى غير كافى لسحب هذه المبلغ");
                            return;
                        }
                       s.Add_StockPull(Convert.ToInt32(cmb_Stock.SelectedValue), Convert.ToDecimal(textBox2.Text), dateTimePicker1.Value
                        , txt_username.Text, " سحب مبلغ " + " " + ( textBox2.Text )+ "مدفوع مسبقا للحجز " + (txt_IdTeckit.Text));
                        for (int i = 0; i < dataGridView2.Rows.Count; i++)
                        {
                         t.addticketsReturn(Convert.ToInt32(txt_IdTeckit.Text), Convert.ToInt32(cmb_Stock.SelectedValue), comboBox1.Text,
                         txt_patientname.Text, "تحويل إلى شركة " + " " + cmb_Company.Text,
                         dataGridView2.Rows[i].Cells[1].Value.ToString(), dateTimePicker1.Value, Convert.ToDecimal(textBox2.Text), 
                         textBox2.Text, Convert.ToDecimal(dataGridView2.Rows[i].Cells[2].Value), Convert.ToDecimal(Txt_PayLast.Text), 
                         txt_username.Text, Convert.ToInt32(dataGridView2.Rows[0].Cells[0].Value));
                        }

                        t.UpdateTicketsActive(Convert.ToInt32(txt_IdTeckit.Text), "Transfer");
                        
                        dt.Clear();
                        dt = cu.Select_CustomertotalBAlance(Convert.ToInt32(Txt_IdCust.Text));
                        decimal mno5 = Convert.ToDecimal(Txt_PayLast.Text) - Convert.ToDecimal(Txt_LastPayOut.Text);
                        decimal mno4 = Convert.ToDecimal(dt.Rows[0][0]) + mno5;
                        cu.Update_CustomerTotalBalance(Convert.ToInt32(Txt_IdCust.Text), mno4);
                        cu.Add_CustomerAccountStatment(Convert.ToInt32(Txt_IdCust.Text), 0,
                        mno5, dateTimePicker1.Value, mno4, Convert.ToInt32(cmb_Stock.SelectedValue)
                        , txt_username.Text, Convert.ToInt32(comboBox1.SelectedValue),
                        " إذن صرف مبلغ   " + " " + (textBox2.Text )+" "+ " فرق المبلغ المدفوع مسبقا للحجز   " +" "+ (txt_IdTeckit.Text));



                        dt.Clear();
                        dt = cu.Select_CustomertotalBAlance(Convert.ToInt32(Txt_IdCust.Text));
                        decimal hr = Convert.ToDecimal(textBox2.Text) + Convert.ToDecimal(Txt_OldRentBeforeTransfair.Text);
                        decimal mno2 = Convert.ToDecimal(dt.Rows[0][0]) - Convert.ToDecimal(Txt_TotalBeforeTransfair.Text);
                        cu.Update_CustomerTotalBalance(Convert.ToInt32(Txt_IdCust.Text), mno2);
                        cu.Add_CustomerAccountStatment(Convert.ToInt32(Txt_IdCust.Text), Convert.ToDecimal(Txt_TotalBeforeTransfair.Text),
                        0, dateTimePicker1.Value, mno2, Convert.ToInt32(cmb_Stock.SelectedValue)
                        , txt_username.Text, Convert.ToInt32(comboBox1.SelectedValue), " إلغاء الفحص النقدى رقم" + " " +( txt_IdTeckit.Text )+ " " + "وإسترداد المبلغ  المدفوع مسبقا بالكامل للعميل");
                    }
                    dt.Clear();
                    dt = cu.Select_CustomertotalBAlance(Convert.ToInt32(Txt_IdCust.Text));
                    decimal mno3 = Convert.ToDecimal(dt.Rows[0][0]);
                    //cu.Update_CustomerTotalBalance(Convert.ToInt32(Txt_IdCust.Text), mno2);
                    cu.Add_CustomerAccountStatment(Convert.ToInt32(Txt_IdCust.Text), Convert.ToDecimal(Txt_PricePayment.Text),
                   Convert.ToDecimal(Txt_PricePayment.Text), dateTimePicker1.Value, mno3, Convert.ToInt32(cmb_Stock.SelectedValue)
                    , txt_username.Text, Convert.ToInt32(comboBox1.SelectedValue), " تحويل الفحص  رقم" + " " + (txt_IdTeckit.Text )+ " " + "إلى الشركة " + " " + cmb_Company.Text);


                }

                else if (Convert.ToDecimal(Txt_PricePayment.Text) > Convert.ToDecimal(Txt_PayLast.Text) - Convert.ToDecimal(Txt_LastPayOut.Text))
                {
                    if (Convert.ToDecimal(Txt_RentCustomer.Text) > 0)
                    {


                        dt.Clear();
                        dt = cu.Select_CustomertotalBAlance(Convert.ToInt32(Txt_IdCust.Text));
                        decimal mno4 = Convert.ToDecimal(dt.Rows[0][0]) + Convert.ToDecimal(Txt_PayLast.Text);
                        cu.Update_CustomerTotalBalance(Convert.ToInt32(Txt_IdCust.Text), mno4);
                        cu.Add_CustomerAccountStatment(Convert.ToInt32(Txt_IdCust.Text), 0,
                        Convert.ToDecimal(Txt_PayLast.Text), dateTimePicker1.Value, mno4, Convert.ToInt32(cmb_Stock.SelectedValue)
                     , txt_username.Text, Convert.ToInt32(comboBox1.SelectedValue), " تم دفع للعميل مبلغ " + " " + ( Txt_PayLast.Text ) + "مدفوع مسبقا للحجز  " +( txt_IdTeckit.Text ));

                        dt.Clear();
                        dt = cu.Select_CustomertotalBAlance(Convert.ToInt32(Txt_IdCust.Text));
                        decimal mno2 = Convert.ToDecimal(dt.Rows[0][0]) - Convert.ToDecimal(Txt_TotalBeforeTransfair.Text);
                        cu.Update_CustomerTotalBalance(Convert.ToInt32(Txt_IdCust.Text), mno2);
                        cu.Add_CustomerAccountStatment(Convert.ToInt32(Txt_IdCust.Text), Convert.ToDecimal(Txt_TotalBeforeTransfair.Text),
                        0, dateTimePicker1.Value, mno2, Convert.ToInt32(cmb_Stock.SelectedValue)
                        , txt_username.Text, Convert.ToInt32(comboBox1.SelectedValue), " إلغاء الفحص النقدى رقم" + " " + (txt_IdTeckit.Text) + " " + "وإسترداد المبلغ  المدفوع مسبقا بالكامل للعميل");

                        dt.Clear();
                        dt = cu.Select_CustomertotalBAlance(Convert.ToInt32(Txt_IdCust.Text));
                        //decimal mn = Convert.ToDecimal(Txt_PricePayment) - Convert.ToDecimal(Txt_PayLast.Text);
                        decimal mno3 = Convert.ToDecimal(dt.Rows[0][0]) + Convert.ToDecimal(Txt_RentCustomer.Text);
                        decimal mno5 = Convert.ToDecimal(Txt_PayLast.Text) - Convert.ToDecimal(Txt_LastPayOut.Text);
                        cu.Update_CustomerTotalBalance(Convert.ToInt32(Txt_IdCust.Text), mno3);
                        cu.Add_CustomerAccountStatment(Convert.ToInt32(Txt_IdCust.Text), mno5,
                       Convert.ToDecimal(Txt_PricePayment.Text), dateTimePicker1.Value, mno3, Convert.ToInt32(cmb_Stock.SelectedValue)
                        , txt_username.Text, Convert.ToInt32(comboBox1.SelectedValue), " تحويل الفحص  رقم" + " " + (txt_IdTeckit.Text )+ " " + "إلى الشركة " + " " + cmb_Company.Text);
                    }
                }
                t.AddTransferForCompany(Convert.ToInt32(cmb_Company.SelectedValue), Convert.ToDecimal(Txt_addtionPaymentrate.Text),
                Convert.ToDecimal(Txt_PricePayment.Text), Convert.ToDecimal(Txt_Total.Text), Convert.ToDecimal(Txt_RentCustomer.Text),
                Convert.ToDecimal(Txt_RentCompany.Text), dateTimePicker1.Value, txt_reasonAddition.Text,
                Convert.ToInt32(dataGridView2.Rows[0].Cells[0].Value), Convert.ToInt32(txt_IdTeckit.Text),
                txt_patientname.Text, Convert.ToInt32(cmb_Stock.SelectedValue), txt_username.Text, comboBox1.Text);
                
                dt.Clear();
                dt = c.Select_CompanyTotalMoney(Convert.ToInt32(cmb_Company.SelectedValue));
                decimal mno = Convert.ToDecimal(dt.Rows[0][0]) + Convert.ToDecimal(Txt_RentCompany.Text);
                c.Update_CompanyTotalMoney(Convert.ToInt32(cmb_Company.SelectedValue), mno);
                c.ADD_Company_TotalRent(Convert.ToInt32(cmb_Company.SelectedValue), 0
                    , Convert.ToDecimal(Txt_RentCompany.Text), dateTimePicker1.Value, mno, "  تحويل حجز اشعة رقم  " + " " + (txt_IdTeckit.Text) +" "+ "للعميل " + txt_patientname.Text, Convert.ToInt32(cmb_Stock.SelectedValue)
                 , Convert.ToInt32(comboBox1.SelectedValue), txt_username.Text);
                MessageBox.Show("تم حفظ التحويل بنجاح");
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Txt_addtionPaymentrate_Leave(object sender, EventArgs e)
        {
            if (Txt_addtionPaymentrate.Text=="")
            {
                Txt_addtionPaymentrate.Text = "0";
            }
            Patient_PaymentRate();
            Rent_Company();
            TotalRentCustomer();
            //if (Convert.ToDecimal(Txt_PayLast.Text) > Convert.ToDecimal(Txt_PricePayment.Text))
            //{
            //    TotalRentCustomer();
            //}
            //else if (Convert.ToDecimal(Txt_PricePayment.Text) > Convert.ToDecimal(Txt_PayLast.Text))
            //{
            //    textBox2.Text = "0";
            //}
        }

        private void Txt_addtionPaymentrate_MouseMove(object sender, MouseEventArgs e)
        {
            if (Txt_addtionPaymentrate.Text == "")
            {
                Txt_addtionPaymentrate.Text = "0";
            }
            Patient_PaymentRate();
            Rent_Company();
            TotalRentCustomer();
            //if (Convert.ToDecimal(Txt_PayLast.Text) > Convert.ToDecimal(Txt_PricePayment.Text))
            //{
            //    TotalRentCustomer();
            //}
            //else if (Convert.ToDecimal(Txt_PricePayment.Text) > Convert.ToDecimal(Txt_PayLast.Text))
            //{
            //    textBox2.Text = "0";
            //}
        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void txt_reasonAddition_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_addtionPaymentrate_Click(object sender, EventArgs e)
        {
            Txt_addtionPaymentrate.SelectAll();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
                cmb_Stock.DataSource = s.SelectStockBranch(Convert.ToInt32(comboBox1.SelectedValue));
                cmb_Stock.DisplayMember = "Name_Stock";
                cmb_Stock.ValueMember = "ID_Stock";
        }

        private void Txt_IdCust_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
