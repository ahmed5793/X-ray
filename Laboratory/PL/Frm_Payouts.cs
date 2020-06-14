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
    public partial class Frm_Payouts : Form
    {
      
        Users u = new Users();
      
        Stock s = new Stock();
        Tickets t = new Tickets();
        Customer c = new Customer();
        Company cm = new Company();
        //DataTable dt6 = new DataTable();

        public Frm_Payouts()
           
        {
            InitializeComponent();
            Function();
        }
        void Function()
        {
            try
            {
                txt_username.Text = Program.salesman;
                Permision();
                Txt_IdCust.Hide();
                Txt_IdCompany.Hide();
                Txt_RentCompany.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void Permision()
        {
            Branches b = new Branches();
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

                cmb_Stock.DataSource = s.SelectStockBranch(Convert.ToInt32(comboBox1.SelectedValue));
                cmb_Stock.DisplayMember = "Name_Stock";
                cmb_Stock.ValueMember = "ID_Stock";
            }
        }

        DataTable dt = new DataTable();
        DataTable dt4 = new DataTable();
        DataTable dt5 = new DataTable();
        DataTable dt10 = new DataTable();

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
               
                    //if (Convert.ToInt32(txt_pay.Text )== 0)
                    //{
                    //    MessageBox.Show("لا يوجد مردود لهذاالفحص لا يوجد مبلغ مدفوع مسبقا");
                    //    return;
                    //}

                
                dt5.Clear();
                dt5 = t.vildateReturnTickets(Convert.ToInt32(txt_num.Text));
                //if (dt5.Rows.Count > 0)
                //{
                //    //if (Convert.ToDecimal(txt_pay.Text) == Convert.ToDecimal(dt5.Rows[0][1]))
                //    //{
                //    MessageBox.Show("عزيزى المستخدم يرجي العلم باان تم استرداد مبلغ الفاتورة من قبل لايمكن استرداها مرة اخرى   ", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                //    //MessageBox.Show(dt5.Rows[0][3].ToString() , "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                //    return;
                //   //}
                //}
                dt10.Clear();
                dt10 = t.vildateTransferForCompany(Convert.ToInt32(txt_num.Text));
                if (dt10.Rows.Count > 0)
                {
                    MessageBox.Show("عزيزى المستخدم يرجي العلم باان تم تحويل الفاتورة الي جهه اخري  ", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    return;
                }
                //if (Convert.ToDecimal(txt_prise.Text) > Convert.ToDecimal(txt_pay.Text))
                //{
                //    MessageBox.Show("عزيزى المستخدم يرجي العلم باان المبلغ المراد سحبة اكبر من المدفوع  ", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                //    return;
                //}

                //dt5.Clear();
                //dt5 = t.vildateReturnTickets(Convert.ToInt32(txt_num.Text));
                //if (dt5.Rows.Count > 0)
                //{
                //    if (Convert.ToDecimal(txt_prise.Text) > (Convert.ToDecimal(txt_pay.Text) - Convert.ToDecimal(dt5.Rows[0][1])))
                //    {
                //        MessageBox.Show("عزيزى المستخدم يرجي العلم باان المبلغ المردود اكبر من المدفوع  ", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                //        return;
                //    }
                //}
                dt4 = s.Select_moneyStock(Convert.ToInt32(cmb_Stock.SelectedValue));
                if (cmb_Stock.Text == "")
                {
                    MessageBox.Show("لا بد من تحديد خزنة");
                    return;
                }
                if (dataGridView1.Rows.Count >= 1)
                {
                        //if (dt5.Rows.Count > 0)
                        //{
                        //    if (Convert.ToDecimal(dt5.Rows[0][1]) == Convert.ToDecimal(txt_pay.Text))
                        //    {
                        //        MessageBox.Show("عزيزى المستخدم يرجي العلم باان تم استرداد مبلغ الفاتورة من قبل لايمكن استرداها مرة اخرى   ", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        //        return;
                        //    }
                        //    if (Convert.ToDecimal(dt5.Rows[0][1]) > 0)
                        //    {
                        //        MessageBox.Show("عزيزى المستخدم يرجي العلم بانه تم استرداد مبلغ" + "(" + Convert.ToDecimal(dt5.Rows[0][1]) + ")" + "لهذه الفاتورة من قبل", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        //        return;
                        //    }
                        //}
                        if (Convert.ToDecimal(txt_pay.Text) > Convert.ToDecimal(dt4.Rows[0][0]))
                        {
                            MessageBox.Show("رصيد الخزنة الحالى غير كافى لسحب هذا المبلغ");
                            return;
                        }

                        if (MessageBox.Show("هل تريد سحب المبلغ المدفوع مسبقا من العميل بالكامل", "عمليه السحب", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)

                        {
                
                        t.UpdateTicketsActive(Convert.ToInt32(txt_num.Text), "return");

                        if (txt_statues.Text == "نقدى")
                        {
                            dt.Clear();
                            dt = c.Select_CustomertotalBAlance(Convert.ToInt32(Txt_IdCust.Text));
                            decimal mno1 = Convert.ToDecimal(dt.Rows[0][0]) + Convert.ToDecimal(txt_pay.Text);
                            c.Update_CustomerTotalBalance(Convert.ToInt32(Txt_IdCust.Text), mno1);
                            c.Add_CustomerAccountStatment(Convert.ToInt32(Txt_IdCust.Text), 0,
                            Convert.ToDecimal(txt_pay.Text), dateTimePicker2.Value, mno1, Convert.ToInt32(cmb_Stock.SelectedValue)
                         , txt_username.Text, Convert.ToInt32(comboBox1.SelectedValue), "إذن صرف مبلغ " + " " + (txt_pay.Text )+ "مدفوع مسبقا للحجز  " + (txt_num.Text));
                         
                           
                            /////////////
                          
                         
                            ///////////
                            
                            dt.Clear();
                            dt = c.Select_CustomertotalBAlance(Convert.ToInt32(Txt_IdCust.Text));
                            decimal mno2 = Convert.ToDecimal(dt.Rows[0][0]) - Convert.ToDecimal(txt_total.Text);
                            c.Update_CustomerTotalBalance(Convert.ToInt32(Txt_IdCust.Text), mno2);
                            c.Add_CustomerAccountStatment(Convert.ToInt32(Txt_IdCust.Text), Convert.ToDecimal(txt_total.Text),
                            0, dateTimePicker2.Value, mno2, Convert.ToInt32(cmb_Stock.SelectedValue)
                            , txt_username.Text, Convert.ToInt32(comboBox1.SelectedValue), " إلغاء الفحص رقم" + " " + (txt_num.Text) + " " + "وإسترداد المبلغ  المدفوع مسبقا بالكامل للعميل");
                        }    
                        if (txt_statues.Text == "شركات")
                        {

                            dt.Clear();
                            dt = c.Select_CustomertotalBAlance(Convert.ToInt32(Txt_IdCust.Text));
                            decimal mno1 = Convert.ToDecimal(dt.Rows[0][0]) + Convert.ToDecimal(txt_pay.Text);
                            c.Update_CustomerTotalBalance(Convert.ToInt32(Txt_IdCust.Text), mno1);
                            c.Add_CustomerAccountStatment(Convert.ToInt32(Txt_IdCust.Text), 0,
                            Convert.ToDecimal(txt_pay.Text), dateTimePicker2.Value, mno1, Convert.ToInt32(cmb_Stock.SelectedValue)
                         , txt_username.Text, Convert.ToInt32(comboBox1.SelectedValue), " إذن صرف مبلغ " + " " +( txt_pay.Text) + "مدفوع مسبقا للحجز  " + (txt_num.Text));
                            //s.Add_StockPull(Convert.ToInt32(cmb_Stock.SelectedValue), Convert.ToDecimal(txt_pay.Text), dateTimePicker2.Value, txt_username.Text, " سحب مبلغ " + " " + (txt_pay.Text) + "مدفوع مسبقا للحجز  " +( txt_num.Text));

                            dt.Clear();
                            dt = c.Select_CustomertotalBAlance(Convert.ToInt32(Txt_IdCust.Text));
                            decimal mno2 = Convert.ToDecimal(dt.Rows[0][0]) - Convert.ToDecimal(Txt_PriceCustomerPayment.Text);
                            c.Update_CustomerTotalBalance(Convert.ToInt32(Txt_IdCust.Text), mno2);
                            c.Add_CustomerAccountStatment(Convert.ToInt32(Txt_IdCust.Text), Convert.ToDecimal(Txt_PriceCustomerPayment.Text),
                            0, dateTimePicker2.Value, mno2, Convert.ToInt32(cmb_Stock.SelectedValue)
                            , txt_username.Text, Convert.ToInt32(comboBox1.SelectedValue), " إلغاء الفحص رقم" + " " +( txt_num.Text) + " " + "وإسترداد المبلغ  المدفوع مسبقا بالكامل للعميل");
                            //////////////////
                            dt.Clear();
                            dt = cm.Select_CompanyTotalMoney(Convert.ToInt32(Txt_IdCompany.Text));
                            decimal mno = Convert.ToDecimal(dt.Rows[0][0]) - Convert.ToDecimal(Txt_RentCompany.Text);

                            cm.Update_CompanyTotalMoney(Convert.ToInt32(Txt_IdCompany.Text), mno);

                            cm.ADD_Company_TotalRent(Convert.ToInt32(Txt_IdCompany.Text), Convert.ToDecimal(Txt_RentCompany.Text), 0
                            , dateTimePicker2.Value, mno, "مردود أشعة ورقم الحجز   " + " " + (txt_num.Text) + " " + "للعميل " + " " + txt_name.Text,
                            Convert.ToInt32(cmb_Stock.SelectedValue), Convert.ToInt32(comboBox1.SelectedValue), txt_username.Text);
                        }

                        if (comboBox1.Text == Txt_OldBranch.Text)
                        {
                            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                            {
                                dt5.Clear();
                                dt5 = t.vildateReturnTickets(Convert.ToInt32(txt_num.Text));
                                if (dt5.Rows.Count > 0)
                                {
                                    //if (Convert.ToDecimal(txt_pay.Text) == Convert.ToDecimal(dt5.Rows[0][1]))
                                    //{
                                    MessageBox.Show("عزيزى المستخدم يرجي العلم باان تم استرداد مبلغ الفاتورة من قبل لايمكن استرداها مرة اخرى   ", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                                    //MessageBox.Show(dt5.Rows[0][3].ToString(), "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                                    return;
                                    //}
                                }
                                t.UpdateticketsReturn(Convert.ToInt32(txt_num.Text), Convert.ToInt32(cmb_Stock.SelectedValue),
                                    comboBox1.Text
                                    , dateTimePicker2.Value, Convert.ToDecimal(txt_pay.Text), txt_username.Text,
                                    Convert.ToInt32(comboBox1.SelectedValue), textBox2.Text);


                                t.Update_Revenue(Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(txt_num.Text),
                             Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value), Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value)
                                   , 0, Convert.ToDecimal(txt_pay.Text), Convert.ToDecimal(txt_rent.Text), dateTimePicker2.Value);
                                s.Add_StockPull(Convert.ToInt32(cmb_Stock.SelectedValue), Convert.ToDecimal(txt_pay.Text), dateTimePicker2.Value, txt_username.Text, " سحب مبلغ " + " " + (txt_pay.Text) + "مدفوع مسبقا للحجز  " + (txt_num.Text));
                                MessageBox.Show("تم سحب المبلغ بنجاح");

                            }
                        }
                        else if (comboBox1.Text != Txt_OldBranch.Text)
                        {
                            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                            {
                                dt5.Clear();
                                dt5 = t.vildateReturnTickets(Convert.ToInt32(txt_num.Text));
                                if (dt5.Rows.Count > 0)
                                {
                                    //if (Convert.ToDecimal(txt_pay.Text) == Convert.ToDecimal(dt5.Rows[0][1]))
                                    //{
                                    MessageBox.Show("عزيزى المستخدم يرجي العلم باان تم استرداد مبلغ الفاتورة من قبل لايمكن استرداها مرة اخرى   ", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                                    //MessageBox.Show(dt5.Rows[0][3].ToString(), "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                                    return;
                                    //}
                                }
                                t.addticketsReturn(Convert.ToInt32(txt_num.Text), Convert.ToInt32(cmb_Stock.SelectedValue),
                                    comboBox1.Text,
                                      txt_name.Text, txt_statues.Text, dataGridView1.Rows[i].Cells[1].Value.ToString(),

                                      dateTimePicker2.Value, Convert.ToDecimal(txt_pay.Text), textBox2.Text,
                                      Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value),
                                        Convert.ToDecimal(txt_pay.Text), txt_username.Text, Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value),
                                        Convert.ToInt32(comboBox1.SelectedValue));


                                t.Add_Revenue(Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(txt_num.Text),
                                Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value), 0
                                , 0, 0, 0, dateTimePicker2.Value);


                                Txt_IdOldBranch.Clear();
                                Txt_IdOldBranch.Text = (t.Select_IDBranch(Txt_OldBranch.Text)).Rows[0][0].ToString();

                                t.UpdateticketsReturn(Convert.ToInt32(txt_num.Text), Convert.ToInt32(cmb_Stock.SelectedValue), 
                                    Txt_OldBranch.Text
                                    , dateTimePicker2.Value, Convert.ToDecimal(txt_pay.Text), txt_username.Text,
                                    Convert.ToInt32(Txt_IdOldBranch.Text), textBox2.Text);
                                s.Add_StockPull(Convert.ToInt32(cmb_Stock.SelectedValue), Convert.ToDecimal(txt_pay.Text), dateTimePicker2.Value, txt_username.Text, " سحب مبلغ " + " " + (txt_pay.Text) + "مدفوع مسبقا للحجز  " + (txt_num.Text));
                                MessageBox.Show("تم سحب المبلغ بنجاح");

                            }
                        }
                     }  
                        else
                        {
                            MessageBox.Show("تم إلغاء العملية بنجاح");
                        }
   

                    Txt_IdCust.Clear();
                    this.Close();

                    //else if (rdbPartPay.Checked == true)
                    //{
                    //    if (Convert.ToDecimal(txt_prise.Text) > Convert.ToDecimal(dt4.Rows[0][0]))
                    //    {
                    //        MessageBox.Show("رصيد الخزنة الحالى غير كافى لسحب هذا المبلغ");
                    //        return;
                    //    }

                    //    if (Convert.ToDecimal(txt_prise.Text) > Convert.ToDecimal(txt_pay.Text))
                    //    {
                    //        MessageBox.Show("الرصيد المحدد أكبر من المبلغ المدفوع لحجز الاشعة");
                    //        return;
                    //    }
                    //    if (MessageBox.Show("هل تريد سحب المبلغ المحدد", "عمليه السحب", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)

                    //    {
                    //        decimal x = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[2].Value) - Convert.ToDecimal(txt_prise.Text);

                    //        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    //        {

                    //            t.addticketsReturn(Convert.ToInt32(txt_num.Text), Convert.ToInt32(cmb_Stock.SelectedValue), comboBox1.Text,
                    //            txt_name.Text, txt_statues.Text, dataGridView1.Rows[i].Cells[1].Value.ToString(), dateTimePicker2.Value
                    //          , Convert.ToDecimal(txt_prise.Text), textBox2.Text, Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value), Convert.ToDecimal(txt_pay.Text), txt_username.Text);
                    //        }

                    //        dt.Clear();
                    //        dt = c.Select_CustomertotalBAlance(Convert.ToInt32(Txt_IdCust.Text));
                    //        decimal mno2 = Convert.ToDecimal(dt.Rows[0][0]) - Convert.ToDecimal(txt_rent.Text);

                    //        c.Update_CustomerTotalBalance(Convert.ToInt32(Txt_IdCust.Text), mno2);

                    //        dt.Clear();
                    //        dt = c.Select_CustomertotalBAlance(Convert.ToInt32(Txt_IdCust.Text));
                    //        decimal mno3 = Convert.ToDecimal(txt_prise.Text) - Convert.ToDecimal(txt_pay.Text);

                    //        decimal mno1 = Convert.ToDecimal(dt.Rows[0][0]) - mno3;
                    //        c.Update_CustomerTotalBalance(Convert.ToInt32(Txt_IdCust.Text), mno1);
                    //        c.Add_CustomerAccountStatment(Convert.ToInt32(Txt_IdCust.Text), Convert.ToDecimal(txt_prise.Text),
                    //            Convert.ToDecimal(txt_prise.Text)
                    //             , dateTimePicker2.Value, mno1, Convert.ToInt32(cmb_Stock.SelectedValue)
                    //             , txt_username.Text, Convert.ToInt32(comboBox1.SelectedValue), " مردود  أشعة ورقم الحجز" + " " + txt_num.Text);
                    //        s.Add_StockPull(Convert.ToInt32(cmb_Stock.SelectedValue), Convert.ToDecimal(txt_prise.Text), dateTimePicker2.Value, txt_username.Text, txt_name.Text + " مردودات");

                    //        MessageBox.Show("تم سحب المبلغ بنجاح");
                    //    }
                    //    else
                    //    {
                    //        MessageBox.Show("تم إلغاء العملية بنجاح");
                    //    }
                }                     
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmb_Stock.DataSource = s.SelectStockBranch(Convert.ToInt32(comboBox1.SelectedValue));
            cmb_Stock.DisplayMember = "Name_Stock";
            cmb_Stock.ValueMember = "ID_Stock";
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void Txt_OldBranch_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_IdOldBranch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
