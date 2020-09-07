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
            Function();
        }

        void Function()
        {
            try
            {

                Txt_SalesMAn.Text = Program.salesman;

                Permision();

                lookUpEdit1.Properties.DataSource = c.SelectRentCompoCustomer();
                lookUpEdit1.Properties.DisplayMember = "Cust_Name";
                lookUpEdit1.Properties.ValueMember = "Cust_ID";
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
        void Stock()
        {
            cmb_Stock.DataSource = s.Compo_Stock();
            cmb_Stock.DisplayMember = "Name_Stock";
            cmb_Stock.ValueMember = "ID_Stock";
        }

        private void RdbAllCustomer_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void RdbOneCustomer_CheckedChanged(object sender, EventArgs e)
        {
            lookUpEdit1.Properties.DataSource = c.SelectRentCompoCustomer();
            lookUpEdit1.Properties.DisplayMember = "Cust_Name";
            lookUpEdit1.Properties.ValueMember = "Cust_ID";
        }

        private void RdbAllPay_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbAllPay.Checked==true)
            {
                txt_prise.Enabled = false;
                txt_prise.Text = "0";
            }
            else
            {
                txt_prise.Enabled = true;

            }
        }

        private void rdbPartPay_CheckedChanged(object sender, EventArgs e)
        {
            txt_prise.Enabled = true;
        }

        private void btn_client_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
           
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
            txt_prise.Enabled = false;
        }
        private void txt_prise_Click(object sender, EventArgs e)
        {
            txt_prise.SelectAll();
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
            try
            {
                if (lookUpEdit1.Text != "")
                {
                    dt.Clear();
                    dt = c.validate_CustomerName(Convert.ToInt32(lookUpEdit1.EditValue));
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("إسم العميل غير موجود لا بد من إختيار إسم العميل من القائمة");
                        lookUpEdit1.Focus();
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
        private void label19_Click(object sender, EventArgs e)
        {
        }
        private void cmb_Stock_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
        private void Cmb_Branch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmb_Stock.DataSource = s.SelectStockBranch(Convert.ToInt32(Cmb_Branch.SelectedValue));
            cmb_Stock.DisplayMember = "Name_Stock";
            cmb_Stock.ValueMember = "ID_Stock";
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (lookUpEdit1.Text != "")
                {
                    //dataGridView1.DataSource = c.selectOneClientRent(Convert.ToInt32(cmb_client.SelectedValue));
                    Txt_CustAccount.Text = c.selectOneClientRent(Convert.ToInt32(lookUpEdit1.EditValue)).Rows[0][2].ToString();
                    Txt_CustAcountAfterDisCount.Text = c.selectOneClientRent(Convert.ToInt32(lookUpEdit1.EditValue)).Rows[0][2].ToString();
                    if (Txt_CustAccount.Text=="0")
                    {
                        TxtDisCount.Enabled = false;
                    }
                    else
                    {
                        TxtDisCount.Enabled = true;
                    }

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
               
                if (cmb_Stock.Text == "")
                {
                    MessageBox.Show("من فضلك قم بااختيار الخزينة");
                    return;
                }

                if (Convert.ToDecimal(Txt_CustAccount.Text) >0)
                {
                    if (RdbAllPay.Checked == true)
                    {

                        if (MessageBox.Show("هل تريد تسديد المبلغ على العميل بالكامل", "عمليه الدفع", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)

                        {
                            //    c.addPayClient(Convert.ToInt32(cmb_client.SelectedValue), Convert.ToDecimal(dataGridView1.CurrentRow.Cells[3].Value),
                            //          x, dateTimePicker1.Value, Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                            //          Convert.ToInt32(cmb_Stock.SelectedValue), Txt_SalesMAn.Text, Convert.ToInt32(Cmb_Branch.SelectedValue));

                            if (Convert.ToDecimal(TxtDisCount.Text)>0)
                            {


                                dt.Clear();
                                dt = c.Select_CustomertotalBAlance(Convert.ToInt32(lookUpEdit1.EditValue));
                                decimal mno1 = Convert.ToDecimal(dt.Rows[0][0]) - Convert.ToDecimal(TxtDisCount.Text)
                                    ;
                                c.Update_CustomerTotalBalance(Convert.ToInt32(lookUpEdit1.EditValue), mno1);
                                c.Add_CustomerAccountStatment(Convert.ToInt32(lookUpEdit1.EditValue), 
                                    Convert.ToDecimal(TxtDisCount.Text),0
                                     , dateTimePicker1.Value, mno1, Convert.ToInt32(cmb_Stock.SelectedValue)
                                     , Txt_SalesMAn.Text, Convert.ToInt32(Cmb_Branch.SelectedValue), "خصم مبلغ"  +"("+TxtDisCount.Text+")"+ "من الحساب المتبقي على العميل");
                            }
                            dt.Clear();
                            dt = c.Select_CustomertotalBAlance(Convert.ToInt32(lookUpEdit1.EditValue));
                            decimal mno = Convert.ToDecimal(dt.Rows[0][0]) - Convert.ToDecimal(Txt_CustAcountAfterDisCount.Text)
                                ;
                            c.Update_CustomerTotalBalance(Convert.ToInt32(lookUpEdit1.EditValue), mno);
                            c.Add_CustomerAccountStatment(Convert.ToInt32(lookUpEdit1.EditValue), Convert.ToDecimal(Txt_CustAcountAfterDisCount.Text),
                               0
                                 , dateTimePicker1.Value, mno, Convert.ToInt32(cmb_Stock.SelectedValue)
                                 , Txt_SalesMAn.Text, Convert.ToInt32(Cmb_Branch.SelectedValue), "تسديد كل الحساب القديم" );

                            s.add_insertStock(Convert.ToInt32(cmb_Stock.SelectedValue), 
                                Convert.ToDecimal(Txt_CustAcountAfterDisCount.Text), dateTimePicker1.Value,Txt_SalesMAn.Text,
                                "  مدفوعات من العميل  "+" "+lookUpEdit1.Text );
                            MessageBox.Show("تم دفع المبلغ بنجاح");

                            Txt_CustAccount.Text = c.selectOneClientRent(Convert.ToInt32(lookUpEdit1.EditValue)).Rows[0][0].ToString();
                            Txt_CustAcountAfterDisCount.Text = c.selectOneClientRent(Convert.ToInt32(lookUpEdit1.EditValue)).Rows[0][0].ToString();
                            TxtDisCount.Text = "0";
                        }
                        else
                        {
                            MessageBox.Show("تم   الغاء العمليه بنجاح");
                            return;
                        }
                    }
                    else if (rdbPartPay.Checked == true)
                    {
                        decimal z = Convert.ToDecimal(Txt_CustAcountAfterDisCount.Text) - Convert.ToDecimal(txt_prise.Text);
                        if (Convert.ToDecimal(txt_prise.Text) > Convert.ToDecimal(Txt_CustAcountAfterDisCount.Text))
                        {
                            MessageBox.Show("المبلغ المدفوع اكبر من المبلغ الموجود حاليا على الشركة  ", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txt_prise.Focus();
                            return;
                        }
                        if (txt_prise.Text == "0" && txt_prise.Text == "")
                        {
                            MessageBox.Show("لا بد ان يكون المبلغ المدفوع اكبر من الصفر", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txt_prise.Focus();
                            return;
                        }
                        if (MessageBox.Show("هل تريد تسديد جزء من المبلغ على العميل ", "عمليه الدفع", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)

                        {
                            //c.addPayClient(Convert.ToInt32(cmb_client.SelectedValue), Convert.ToDecimal(txt_prise.Text), z,
                            //    dateTimePicker1.Value, Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                            //    Convert.ToInt32(cmb_Stock.SelectedValue), Txt_SalesMAn.Text, Convert.ToInt32(Cmb_Branch.SelectedValue));
                            if (txt_prise.Text=="")
                            {
                                MessageBox.Show("لا بد من تحديد السعر");
                                return;
                            }
                            if (Convert.ToDecimal(TxtDisCount.Text) > 0)
                            {


                                dt.Clear();
                                dt = c.Select_CustomertotalBAlance(Convert.ToInt32(lookUpEdit1.EditValue));
                                decimal mno1 = Convert.ToDecimal(dt.Rows[0][0]) - Convert.ToDecimal(TxtDisCount.Text)
                                    ;
                                c.Update_CustomerTotalBalance(Convert.ToInt32(lookUpEdit1.EditValue), mno1);
                                c.Add_CustomerAccountStatment(Convert.ToInt32(lookUpEdit1.EditValue),
                                    Convert.ToDecimal(TxtDisCount.Text), 0
                                     , dateTimePicker1.Value, mno1, Convert.ToInt32(cmb_Stock.SelectedValue)
                                     , Txt_SalesMAn.Text, Convert.ToInt32(Cmb_Branch.SelectedValue), "خصم مبلغ" + "(" + TxtDisCount.Text + ")" + "من الحساب المتبقي على العميل");
                            }
                            dt.Clear();
                            dt = c.Select_CustomertotalBAlance(Convert.ToInt32(lookUpEdit1.EditValue));
                            decimal mno = Convert.ToDecimal(dt.Rows[0][0]) - Convert.ToDecimal(txt_prise.Text);
                            c.Update_CustomerTotalBalance(Convert.ToInt32(lookUpEdit1.EditValue), mno);
                            c.Add_CustomerAccountStatment(Convert.ToInt32(lookUpEdit1.EditValue), Convert.ToDecimal(txt_prise.Text),
                               0
                                 , dateTimePicker1.Value, mno, Convert.ToInt32(cmb_Stock.SelectedValue)
                                 , Txt_SalesMAn.Text, Convert.ToInt32(Cmb_Branch.SelectedValue), "تسديد جزء من الحساب ");
                            s.add_insertStock(Convert.ToInt32(cmb_Stock.SelectedValue), Convert.ToDecimal(txt_prise.Text), dateTimePicker1.Value, Txt_SalesMAn.Text, lookUpEdit1.Text + " " + "مدفوعات مديونية");
                            MessageBox.Show("تم دفع المبلغ بنجاح");

                            Txt_CustAccount.Text = c.selectOneClientRent(Convert.ToInt32(lookUpEdit1.EditValue)).Rows[0][0].ToString();
                            Txt_CustAcountAfterDisCount.Text = c.selectOneClientRent(Convert.ToInt32(lookUpEdit1.EditValue)).Rows[0][0].ToString();
                            TxtDisCount.Text = "0";
                        }
                        else
                        {
                            MessageBox.Show("تم   الغاء العمليه بنجاح");
                            return;
                        }

                    }
                  

                }
                txt_prise.Text = "0";
                Txt_CustAccount.Text = "0";
                Txt_CustAcountAfterDisCount.Text = "0";
                TxtDisCount.Text = "0";


                lookUpEdit1.Properties.DataSource = c.SelectRentCompoCustomer();
                lookUpEdit1.Properties.DisplayMember = "Cust_Name";
                lookUpEdit1.Properties.ValueMember = "Cust_ID";
                lookUpEdit1.Text = "";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void txt_prise_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtDisCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && TxtDisCount.Text.ToString().IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar((System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)))
            {
                e.Handled = true;
            }
        }

        private void TxtDisCount_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TxtDisCount_Click(object sender, EventArgs e)
        {
            TxtDisCount.Text = "";

        }

        private void TxtDisCount_KeyUp(object sender, KeyEventArgs e)
        {
           
            if (Txt_CustAccount.Text != "" && Txt_CustAccount.Text != "0")
            {
                if (TxtDisCount.Text!="")
                {
                    (Txt_CustAcountAfterDisCount.Text) = (Convert.ToDecimal(Txt_CustAccount.Text) - Convert.ToDecimal(TxtDisCount.Text)).ToString();

                }
                else if (TxtDisCount.Text == "")
                {
                    (Txt_CustAcountAfterDisCount.Text) = (Convert.ToDecimal(Txt_CustAccount.Text) - 0).ToString();

                }
            }
        }

        private void TxtDisCount_MouseLeave(object sender, EventArgs e)
        {
            if (TxtDisCount.Text=="")
            {
                TxtDisCount.Text = "0";
            }
            if (Txt_CustAccount.Text != "" && Txt_CustAccount.Text != "0")
            {
                (Txt_CustAcountAfterDisCount.Text) = (Convert.ToDecimal(Txt_CustAccount.Text) - Convert.ToDecimal(TxtDisCount.Text)).ToString();
            }
        }

        private void TxtDisCount_TextChanged(object sender, EventArgs e)
        {
            if (TxtDisCount.Text==".")
            {
                TxtDisCount.Text = "0";
            }
        }
    }
}
