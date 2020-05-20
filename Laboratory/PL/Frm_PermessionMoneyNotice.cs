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
    public partial class Frm_PermessionMoneyNotice : Form
    {
        Customer c = new Customer();
        Stock s = new Stock();
        Users u = new Users();
        Branches b = new Branches();
        DataTable dt = new DataTable();
        public Frm_PermessionMoneyNotice()
        {
            InitializeComponent();
            Function();
        }
        void Function()
        {
            try
            {

                Txt_SalesMAn.Text = Program.salesman;

                Permision();

                cmb_client.DataSource = c.SelectCreditCompoCustomer();
                cmb_client.DisplayMember = "Cust_Name";
                cmb_client.ValueMember = "Cust_ID";
                cmb_client.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
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

                cmb_Stock.DataSource = s.SelectStockBranch(Convert.ToInt32(Cmb_Branch.SelectedValue));
                cmb_Stock.DisplayMember = "Name_Stock";
                cmb_Stock.ValueMember = "ID_Stock";
            }
        }

        private void Frm_PermessionMoneyNotice_Load(object sender, EventArgs e)
        {

        }

        private void Txt_Money_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == '.' && Txt_Money.Text.ToString().IndexOf('.') > -1)
            //{
            //    e.Handled = true;
            //}
            //else if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar((System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)))
            //{
            //    e.Handled = true;
            //}
        }

        private void Txt_Money_MouseMove(object sender, MouseEventArgs e)
        {
            //if (Txt_Money.Text == "")
            //{
            //    Txt_Money.Text = "0";
            //}
        }

        private void Txt_Money_Click(object sender, EventArgs e)
        {
            //Txt_Money.SelectAll();
            
        }

        private void cmb_client_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                
                   dt = c.selectOneClientRent(Convert.ToInt32(cmb_client.SelectedValue));
                    if (dt.Rows.Count>0)
                    {
                        Txt_Balance.Text = (Convert.ToDecimal(dt.Rows[0][2]) * -1).ToString();
                    }
                  
                
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
                MessageBox.Show(EX.StackTrace);
            }
        }

        private void cmb_client_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
               
                    dt = c.selectOneClientRent(Convert.ToInt32(cmb_client.SelectedValue));
                    if (dt.Rows.Count > 0)
                    {
                        Txt_Balance.Text = (Convert.ToDecimal(dt.Rows[0][2]) * -1).ToString();
                    }

               
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
                MessageBox.Show(EX.StackTrace);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                //if (Txt_Money.Text=="" || Txt_Money.Text=="0")
                //{
                //    MessageBox.Show("لا بد من تحديد المبلغ المراد صرفه للعميل");
                //    return;
                //}
                //if (Convert.ToDecimal(Txt_Money.Text) > Convert.ToDecimal(Txt_Balance.Text))
                //{
                //    MessageBox.Show("لا يسمح بصرف مبلغ أكبر من المبلغ المستحق لعميل");
                //    return;
                //}
            
               
                    if (MessageBox.Show("هريد تأكيد صرف المبلغ المراد تحديد ","تأكيد صرف مبلغ ",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                    {

                    dt.Clear();
                    dt = s.Select_moneyStock(Convert.ToInt32(cmb_Stock.SelectedValue));
                    if (Convert.ToDecimal(Txt_Balance.Text) > Convert.ToDecimal(dt.Rows[0][0]))
                    {
                        MessageBox.Show("رصيد الخزنة الحالى غير كافى لسحب هذه المبلغ");
                        return;
                    }
                    s.Add_StockPull(Convert.ToInt32(cmb_Stock.SelectedValue), Convert.ToDecimal(Txt_Balance.Text), dateTimePicker1.Value
                     , Txt_SalesMAn.Text, " إذن صرف  مبلغ " + "( " + (Txt_Balance.Text) +")" + " تسوية رصيد للعميل " + " " + cmb_client.Text);

                    dt.Clear();
                    dt = c.Select_CustomertotalBAlance(Convert.ToInt32(cmb_client.SelectedValue));
                    decimal hrl = Convert.ToDecimal(dt.Rows[0][0]) * -1;

                    //decimal mno5 = Convert.ToDecimal(Txt_PayLast.Text) - Convert.ToDecimal(Txt_LastPayOut.Text);
                    decimal mno4 = Convert.ToDecimal(dt.Rows[0][0]) + Convert.ToDecimal(Txt_Balance.Text);
                    c.Update_CustomerTotalBalance(Convert.ToInt32(cmb_client.SelectedValue), mno4);
                    c.Add_CustomerAccountStatment(Convert.ToInt32(cmb_client.SelectedValue), 0,
                    Convert.ToDecimal(Txt_Balance.Text), dateTimePicker1.Value, mno4, Convert.ToInt32(cmb_Stock.SelectedValue)
                    , Txt_SalesMAn.Text, Convert.ToInt32(Cmb_Branch.SelectedValue),
                    " إذن صرف مبلغ   " + " (" + (Txt_Balance.Text) + " )" + " تسوية رصيد للعميل " +" "+ cmb_client.Text);
                        MessageBox.Show("تم تأكيد صرف المبلغ المحدد للعميل");
                        cmb_client.SelectedIndex = -1;
                        Txt_Balance.Text = "0";
                        

                    }
                    else
                    {
                        MessageBox.Show("تم إلغاء صرف المبلغ المراد صرفه يرجى التأكد من العملية و إعادة المحاولة");
                        return;
                    }


                

            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
                MessageBox.Show(EX.StackTrace);
            }
        }

        private void txt_reasonAddition_TextChanged(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void cmb_client_Leave(object sender, EventArgs e)
        {

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
        }

        private void cmb_client_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
               
            //    if (cmb_client.SelectedIndex != -1)
            //    {
            //        dt = c.selectOneClientRent(Convert.ToInt32((DataRowView)cmb_client.SelectedValue));
            //        if (dt.Rows.Count > 0)
            //        {
            //            Txt_Balance.Text = (Convert.ToDecimal(dt.Rows[0][2]) * -1).ToString();
            //        }

            //    }

            //}
            //catch (Exception EX)
            //{

            //    MessageBox.Show(EX.Message);
            //    MessageBox.Show(EX.StackTrace);
            //}
        }

        private void cmb_client_SelectedValueChanged(object sender, EventArgs e)
        {
 
        }

        private void cmb_client_Click(object sender, EventArgs e)
        {
       
        }

        private void cmb_client_MouseMove(object sender, MouseEventArgs e)
        {
    
        }

        private void Cmb_Branch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                cmb_Stock.DataSource = s.SelectStockBranch(Convert.ToInt32(Cmb_Branch.SelectedValue));
                cmb_Stock.DisplayMember = "Name_Stock";
                cmb_Stock.ValueMember = "ID_Stock";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
