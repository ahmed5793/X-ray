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
    public partial class Frm_Tickets : Form
    {
        ItemsXRaya ix = new ItemsXRaya();
        Customer c = new Customer();
        Company cm = new Company();
        Doctors d = new Doctors();

        Branches b = new Branches();
        Stock s = new Stock();
        CategoryXRaya cx = new CategoryXRaya();
        Employee E = new Employee();
        DataTable dt2 = new DataTable();
        Tickets t = new Tickets();
        Techincal tc = new Techincal();
        DoctorOfCenter dc = new DoctorOfCenter();
        string names;

        public Frm_Tickets()
        {
            InitializeComponent();
            Cmb_customer.Show();
            txt_name.Hide();
            cmb_Company.Enabled = false;
            txt_username.Text = Program.salesman;
            brnches();
            Stock();
            Customer();
            doctor();
          

            txt_phone.Enabled = false;
            txt_age.Enabled = false;
            txt_address.Enabled = false;
       

        }
        public void rezizse()
        {

            dgv_order.RowHeadersWidth = 20;


            dgv_order.Columns[1].Width = 180;
            dgv_order.Columns[2].Width = 90;
        }

        public void SelectdataTable()
        {
          
            
            dt2.Columns.Add("رقم الفحص");
            dt2.Columns.Add("اسم الفحص");


            dt2.Columns.Add("قيمة الفحص");                  
            dgv_order.DataSource = dt2;
            dgv_order.Columns[0].Visible = false;

        }
        void company()
        {
            cmb_Company.DataSource = cm.SelectCompany();
            cmb_Company.DisplayMember = "اسم الشركه";
            cmb_Company.ValueMember = "Comp_ID";
        }
        void doctor()
        {
            cmb_Doctor.DataSource = d.SelectDoctor();
            cmb_Doctor.DisplayMember = "اسم الطبيب المعالج";
            cmb_Doctor.ValueMember = "Doc_ID";
        }
        void brnches()
        {
          
            cmb_branches.DataSource = b.SelectCompBranches();
            cmb_branches.DisplayMember = "Name";
            cmb_branches.ValueMember = "Branch_ID";

        }

        void Stock()
        {
           
            cmb_Stock.DataSource = s.Compo_Stock();
            cmb_Stock.DisplayMember = "Name_Stock";
            cmb_Stock.ValueMember = "ID_Stock";

        }
        void Customer()
        {

            Cmb_customer.DataSource = c.SelectCompoCustomer();
            Cmb_customer.DisplayMember = "Cust_Name";
            Cmb_customer.ValueMember = "Cust_ID";
        }

        void CategoryXraya()
        {
            
            Cmb_category.DataSource = cx.selectCategoryXRaya();
            Cmb_category.DisplayMember = "الفئات";
            Cmb_category.ValueMember = "ID_CtegoryXrays";
        }
        void DoctorOfCenter()
        {
            cmb_DoctorOfCenter.DataSource = dc.CompoDoctor_OFCENTER();
            cmb_DoctorOfCenter.DisplayMember = "Doc_Name";
            cmb_DoctorOfCenter.ValueMember = "Doc_ID";
        }
        void Techincal()
        {
            cmb_Techincal.DataSource = tc.CompoTechibncal();
            cmb_Techincal.DisplayMember = "Tech_Name";
            cmb_Techincal.ValueMember = "Techincal_ID";
        }
      
      

        private void Frm_Tickets_Load(object sender, EventArgs e)
        {
            CategoryXraya();
            SelectdataTable();

            rezizse();
            txt_idcust.Hide();
            txt_IdTicket.Hide();
            totalOrder();
            DoctorOfCenter();
            Techincal();
     



        }
        void SelectTicketEmployee()
        {
            if (rdb_CurrentPatient.Checked==true)
            {
                dt.Clear();
                dt = t.SelectTicketEmployee(Convert.ToInt32(Cmb_customer.SelectedValue));
                dgv_visit.DataSource = dt;
                dgv_visit.Columns[0].Visible = false;

            }
          
        
        }

        public void totalOrder()
        {

            decimal total = 0;
            for (int i = 0; i < dgv_order.Rows.Count; i++)
            {
                total += Convert.ToDecimal(dgv_order.Rows[i].Cells[2].Value);
            }
            txt_total.Text = Math.Round(total, 2).ToString();

        }
        public void pay()

        {
            decimal x = 0;
            if (txt_afterDiscount.Text != string.Empty && txt_pay.Text != string.Empty)
            {
                decimal totainv = Convert.ToDecimal(txt_afterDiscount.Text) - Convert.ToDecimal(txt_pay.Text);
                txt_rent.Text = totainv.ToString();
            }
            else
            {
                //txt_pay.Text = "0";
                decimal totainv = Convert.ToDecimal(txt_afterDiscount.Text) - x;
                txt_rent.Text = totainv.ToString();

            }

        }
        public void Discount()
        {
            decimal x = 0;
            if (txt_total.Text != string.Empty &&txt_discount.Text!=string.Empty)
            {
                

                decimal discount = Convert.ToDecimal(txt_total.Text) - (Convert.ToDecimal(txt_total.Text) * (Convert.ToDecimal(txt_discount.Text)/100));
                txt_afterDiscount.Text = discount.ToString();
            }
            else
            {
                //txt_discount.Text = "0";
                decimal discount = Convert.ToDecimal(txt_total.Text) - x;
                txt_afterDiscount.Text = discount.ToString();
                totalOrder();
            }

        }
        public void DiscountMoney()
        {
            decimal x = 0;
            if (txt_total.Text != string.Empty&&txt_discount.Text!=string.Empty)
            {


                decimal discount = Convert.ToDecimal(txt_total.Text) - Convert.ToDecimal(txt_discount.Text) ;
                txt_afterDiscount.Text = discount.ToString();
                
            }
            else
            {
                //txt_discount.Text = "0";
                decimal discount = Convert.ToDecimal(txt_total.Text) - x;
                txt_afterDiscount.Text = discount.ToString();
                totalOrder();

            }

        }
        private void rdb_Compamy_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_Compamy.Checked == true)
            {
              
                cmb_Company.Enabled = true;
                company();
            }
            names = "شركات";
        }
      
        private void rdb_client_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_client.Checked == true)
            {
             
                cmb_Company.Enabled = false;
                cmb_Company.DataSource = null;
            }
            names = "اهالي";
        }
        DataTable dt = new DataTable();
        private void Cmb_category_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (Cmb_category.Text != "")
            {

                cmb_items.DataSource = ix.SelectCtegoryItems(Convert.ToInt32(Cmb_category.SelectedValue));
                cmb_items.DisplayMember = "Name";
                cmb_items.ValueMember = "ID_ItemsXrays";

            }
        }

        private void Cmb_category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cmb_customer_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (Cmb_customer.Text != "")
            {
                dt.Clear();
                dt = c.SelectDataCompoCustomer(Convert.ToInt32(Cmb_customer.SelectedValue));
                if (dt.Rows.Count > 0)
                {
                    txt_phone.Text = dt.Rows[0][0].ToString();
                    txt_address.Text = dt.Rows[0][1].ToString();
                    txt_age.Text = dt.Rows[0][2].ToString();
                    SelectTicketEmployee();
                }
                else
                {
                    MessageBox.Show("!اسم المريض غير متسجل ");
                    txt_phone.Clear();
                    txt_address.Clear();

                    txt_age.Clear();
                }
           
            }
        }

        private void rdb_NewPatient_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_NewPatient.Checked == true)
            {
                Cmb_customer.Hide();
                txt_name.Show();

                txt_phone.Enabled = true;
                txt_age.Enabled = true;
                txt_address.Enabled = true;

                txt_phone.Clear();
                txt_age.Clear();
                txt_address.Clear();
                dgv_visit.DataSource = null;
               
            }
        }

        private void rdb_CurrentPatient_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_CurrentPatient.Checked == true)
            {
                Cmb_customer.Show();
                txt_name.Hide();

                txt_phone.Enabled = false;
                txt_age.Enabled = false;
                txt_address.Enabled = false;

                txt_phone.Clear();
                txt_age.Clear();
                txt_address.Clear();
            }
        }

        private void Cmb_customer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cmb_customer_Leave(object sender, EventArgs e)
        {
            if (Cmb_customer.Text != "")
            {
                dt.Clear();
                dt = c.SelectDataCompoCustomer(Convert.ToInt32(Cmb_customer.SelectedValue));
                if (dt.Rows.Count > 0)
                {
                    txt_phone.Text = dt.Rows[0][0].ToString();
                    txt_address.Text = dt.Rows[0][1].ToString();
                    txt_age.Text = dt.Rows[0][2].ToString();
                    SelectTicketEmployee();

                }
                else
                {
                    MessageBox.Show("!اسم المريض غير متسجل ");
                    txt_phone.Clear();
                    txt_address.Clear();

                    txt_age.Clear();
                    Cmb_customer.Focus();
                    return;
                }
            }
        }

        private void Cmb_customer_KeyDown(object sender, KeyEventArgs e)
        {
            dt.Clear();
            dt = c.SelectDataCompoCustomer(Convert.ToInt32(Cmb_customer.SelectedValue));
            if (dt.Rows.Count > 0)
            {
                txt_phone.Text = dt.Rows[0][0].ToString();
                txt_address.Text = dt.Rows[0][1].ToString();
                txt_age.Text = dt.Rows[0][2].ToString();

            }
           
         
        }

        private void txt_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && txt_total.Text.ToString().IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar((System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)))
            {
                e.Handled = true;
            }
        }

        private void text_discount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && txt_discount.Text.ToString().IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar((System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)))
            {
                e.Handled = true;
            }
        }

        private void txt_pay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && txt_pay.Text.ToString().IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar((System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)))
            {
                e.Handled = true;
            }
        }

        private void txt_rent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && txt_rent.Text.ToString().IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar((System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)))
            {
                e.Handled = true;
            }
        }

        private void txt_age_KeyPress(object sender, KeyPressEventArgs e)
        {


             if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txt_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void Cmp_EMPRAOLE_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //cmb_Techincal.DataSource = E.SelectCompoRoleEmployee(Convert.ToInt32(cmb_DoctorOfCenter.SelectedValue));
            //label23.Text = cmb_DoctorOfCenter.Text;
            //cmb_Techincal.DisplayMember = "Emp_Name";
            //cmb_Techincal.ValueMember = "Emp_ID";
        

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cmb_Emprole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_addgrid_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dgv_order.Rows.Count; i++)
                {


                    if (Convert.ToInt32(cmb_items.SelectedValue) == Convert.ToInt32(dgv_order.Rows[i].Cells[0].Value))
                    {
                        Console.Beep();
                        MessageBox.Show("هذا الاشعة مسجلة من قبل ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return;
                    }
                }
                if (Cmb_category.Text=="")
                {
                    MessageBox.Show("من فضلك قم بااختيار فئة الفحص");
                    return;
                }
                if (cmb_items.Text == "")
                {
                    MessageBox.Show("من فضلك قم بااختيارنوع الفحص");
                    return;
                }
                else
                {

                    decimal x;
                    dt = ix.SelectPriseItem(Convert.ToInt32(cmb_items.SelectedValue));
                    x = Convert.ToDecimal(dt.Rows[0][0].ToString());

                    DataRow r = dt2.NewRow();
                    r[0] = cmb_items.SelectedValue;
                    r[1] = cmb_items.Text;
                    r[2] = x;


                    dt2.Rows.Add(r);
                    Console.Beep();
                    dgv_order.DataSource = dt2;
                    totalOrder();
                    if (rdb_Discount.Checked == true)
                    {
                        Discount();
                    }
                    else
                    {
                        DiscountMoney();
                    }
                    pay();


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            DiscountMoney();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Discount();
        }

        private void txt_discount_Leave(object sender, EventArgs e)
        {
            if (txt_discount.Text=="")
            {
                txt_discount.Text = "0";
            }
        }

        private void txt_pay_KeyUp(object sender, KeyEventArgs e)
        {
            pay();
        }

        private void txt_rent_KeyUp(object sender, KeyEventArgs e)
        {
            //pay();
        }

        private void txt_discount_KeyUp(object sender, KeyEventArgs e)
        {
            if (rdb_Discount.Checked==true)
            {
                Discount();
                pay();
            }
            else
            {
                DiscountMoney();
                pay();
            }
        }

        private void txt_discount_Validated(object sender, EventArgs e)
        {
        }

        private void txt_discount_MouseDown(object sender, MouseEventArgs e)
        {
            txt_discount.SelectAll();
        }

        private void txt_pay_MouseDown(object sender, MouseEventArgs e)
        {
            txt_pay.SelectAll();
        }

        private void txt_pay_Leave(object sender, EventArgs e)
        {
            if (txt_pay.Text=="")
            {
                txt_pay.Text = "0";
            }
        }

       
        private void groupBox4_Enter(object sender, EventArgs e)
        {
          
        }
        void clear()
        {
            rdb_money.Enabled = true;
            rdb_Discount.Enabled = true;
            txt_address.Clear();
            txt_afterDiscount.Text="0";
            txt_age.Clear();
            txt_compint.Clear();
            txt_discount.Text = "0";
            txt_name.Clear();
            txt_pay.Text = "0";
            txt_phone.Clear();
            txt_rent.Text = "0";
            txt_total.Text = "0";
            rdb_CurrentPatient.Checked = true;
            dt2.Clear();
            txt_discount.Enabled = true;


        }
        private void label21_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_order.Rows.Count>0)
                {
                    if (rdb_client.Checked==false&&rdb_Compamy.Checked==false)
                    {
                        MessageBox.Show("من فضلك قم بتحديد نوع الفاتورة اهالي ام شركات");
                        return;
                    }

                    if (txt_name.Text==""&& Cmb_customer.Text == "" || txt_address.Text==""||txt_age.Text=="")
                    {
                        MessageBox.Show("من فضلك قم باادخال بيانات العميل كاملة");
                        return;
                    }
                    if (txt_compint.Text=="")
                    {
                        MessageBox.Show("من فضلك قم باادخال الشكوي");

                        return;
                    }
                    if (cmb_Doctor.Text == "")
                    {
                        MessageBox.Show("من فضلك قم باادخال الطبيب المعالج للمريض");

                        return;
                    }
                    if (cmb_DoctorOfCenter.Text == ""||cmb_Techincal.Text=="")
                    {
                        MessageBox.Show("من فضلك قم باادخال طبيب الحالة");
                        cmb_DoctorOfCenter.Focus();

                        return;
                    }
                    if (cmb_Techincal.Text == "" || cmb_Techincal.Text == "")
                    {
                        MessageBox.Show("من فضلك قم باادخال الفني");
                        cmb_Techincal.Focus();

                        return;
                    }
                    if (Cmb_category.Text == "")
                    {
                        MessageBox.Show("من فضلك قم بااختيار فئة الفحص");

                        return;
                    }
                    if (cmb_items.Text == "")
                    {
                        MessageBox.Show("من فضلك قم بااختيار نوع الفحص");

                        return;
                    }

                    if (rdb_client.Checked==true)
                    {
                        if (rdb_NewPatient.Checked==true)
                        {
                            c.addCustomer(txt_name.Text, txt_address.Text, txt_phone.Text, Convert.ToInt32(txt_age.Text), dtb_visit.Value);
                            txt_idcust.Text = c.LastIdCustomer().Rows[0][0].ToString();

                            t.AddTickets(dtb_visit.Value, dtp_recive.Value, Convert.ToDecimal(txt_total.Text), Convert.ToDecimal(txt_pay.Text),
                                Convert.ToDecimal(txt_rent.Text), Convert.ToInt32(txt_idcust.Text), names, Convert.ToInt32(cmb_Doctor.SelectedValue),
                                Convert.ToInt32(cmb_branches.SelectedValue), Convert.ToInt32(cmb_Stock.SelectedValue), dtb_kashf.Value,
                                txt_compint.Text, Convert.ToInt32(cmb_DoctorOfCenter.SelectedValue), Convert.ToInt32(cmb_Techincal.SelectedValue), txt_username.Text);
                            txt_IdTicket.Text = t.LastIdTicket().Rows[0][0].ToString();
                            for (int i = 0; i < dgv_order.Rows.Count; i++)
                            {
                                t.AddTicketDetails(Convert.ToInt32(txt_IdTicket.Text), Convert.ToInt32(dgv_order.Rows[i].Cells[0].Value),
                                    Convert.ToDecimal(dgv_order.Rows[i].Cells[2].Value));
                            }
                            t.AddTickestDiscount(Convert.ToInt32(txt_IdTicket.Text), Convert.ToDecimal(txt_discount.Text));
                            MessageBox.Show("تم حفظ الفاتورة بنجاح");
                        }
                        else if (rdb_CurrentPatient.Checked==true)
                        {

                            t.AddTickets(dtb_visit.Value, dtp_recive.Value, Convert.ToDecimal(txt_total.Text), Convert.ToDecimal(txt_pay.Text),
                                Convert.ToDecimal(txt_rent.Text), Convert.ToInt32(Cmb_customer.SelectedValue), names, Convert.ToInt32(cmb_Doctor.SelectedValue),
                                Convert.ToInt32(cmb_branches.SelectedValue), Convert.ToInt32(cmb_Stock.SelectedValue), dtb_kashf.Value,
                                txt_compint.Text, Convert.ToInt32(cmb_DoctorOfCenter.SelectedValue), Convert.ToInt32(cmb_Techincal.SelectedValue), txt_username.Text);
                            txt_IdTicket.Text = t.LastIdTicket().Rows[0][0].ToString();
                            for (int i = 0; i < dgv_order.Rows.Count; i++)
                            {
                                t.AddTicketDetails(Convert.ToInt32(txt_IdTicket.Text), Convert.ToInt32(dgv_order.Rows[i].Cells[0].Value),
                                    Convert.ToDecimal(dgv_order.Rows[i].Cells[2].Value));
                            }
                            t.AddTickestDiscount(Convert.ToInt32(txt_IdTicket.Text), Convert.ToDecimal(txt_discount.Text));
                            MessageBox.Show("تم حفظ الفاتورة بنجاح");
                        }
                       
                    }
                    else if (rdb_Compamy.Checked==true)
                    {
                        if (cmb_Company.Text=="")
                        {
                            MessageBox.Show("من فضلك قم بااختيار شركه");
                            return;
                        }
                        if (rdb_NewPatient.Checked == true)
                        {
                            c.addCustomer(txt_name.Text, txt_address.Text, txt_phone.Text, Convert.ToInt32(txt_age.Text), dtb_visit.Value);
                            txt_idcust.Text = c.LastIdCustomer().Rows[0][0].ToString();

                            t.AddTickets(dtb_visit.Value, dtp_recive.Value, Convert.ToDecimal(txt_total.Text), Convert.ToDecimal(txt_pay.Text),
                                Convert.ToDecimal(txt_rent.Text), Convert.ToInt32(txt_idcust.Text), names, Convert.ToInt32(cmb_Doctor.SelectedValue),
                                Convert.ToInt32(cmb_branches.SelectedValue), Convert.ToInt32(cmb_Stock.SelectedValue), dtb_kashf.Value,
                                txt_compint.Text, Convert.ToInt32(cmb_DoctorOfCenter.SelectedValue), Convert.ToInt32(cmb_Techincal.SelectedValue), txt_username.Text);
                            txt_IdTicket.Text = t.LastIdTicket().Rows[0][0].ToString();
                            for (int i = 0; i < dgv_order.Rows.Count; i++)
                            {
                                t.AddTicketDetails(Convert.ToInt32(txt_IdTicket.Text), Convert.ToInt32(dgv_order.Rows[i].Cells[0].Value),
                                    Convert.ToDecimal(dgv_order.Rows[i].Cells[2].Value));
                            }
                            t.AddTickestDiscount(Convert.ToInt32(txt_IdTicket.Text), Convert.ToDecimal(txt_discount.Text));
                            MessageBox.Show("تم حفظ الفاتورة بنجاح");
                        }
                        else if (rdb_CurrentPatient.Checked == true)
                        {

                            t.AddTickets(dtb_visit.Value, dtp_recive.Value, Convert.ToDecimal(txt_total.Text), Convert.ToDecimal(txt_pay.Text),
                                Convert.ToDecimal(txt_rent.Text), Convert.ToInt32(Cmb_customer.SelectedValue), names, Convert.ToInt32(cmb_Doctor.SelectedValue),
                                Convert.ToInt32(cmb_branches.SelectedValue), Convert.ToInt32(cmb_Stock.SelectedValue), dtb_kashf.Value,
                                txt_compint.Text, Convert.ToInt32(cmb_DoctorOfCenter.SelectedValue), Convert.ToInt32(cmb_Techincal.SelectedValue), txt_username.Text);
                            txt_IdTicket.Text = t.LastIdTicket().Rows[0][0].ToString();
                            for (int i = 0; i < dgv_order.Rows.Count; i++)
                            {
                                t.AddTicketDetails(Convert.ToInt32(txt_IdTicket.Text), Convert.ToInt32(dgv_order.Rows[i].Cells[0].Value),
                                    Convert.ToDecimal(dgv_order.Rows[i].Cells[2].Value));
                            }
                            t.AddTickestDiscount(Convert.ToInt32(txt_IdTicket.Text), Convert.ToDecimal(txt_discount.Text));
                            MessageBox.Show("تم حفظ الفاتورة بنجاح");
                        }
                        t.AddTicketCompany(Convert.ToInt32(txt_IdTicket.Text), Convert.ToInt32(cmb_Company.SelectedValue));

                    }


                    s.add_insertStock(Convert.ToInt32(cmb_Stock.SelectedValue), Convert.ToDecimal(txt_pay.Text), dtb_visit.Value, txt_username.Text, "فاتورة حجز اشعة رقم "+txt_IdTicket.Text);

                    clear();
                    SelectTicketEmployee();

                }
               
                else
                {
                  
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txt_afterDiscount_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void cmb_Techincal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgv_order_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (rdb_Discount.Checked == true)
            {
                Discount();
                pay();
            }
            else
            {
                DiscountMoney();
                pay();
            }
            totalOrder();
        }

        private void txt_discount_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == '.' && txt_discount.Text.ToString().IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar((System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_DoctorOfCenter dc = new Frm_DoctorOfCenter();
            dc.ShowDialog();
            DoctorOfCenter();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frm_Techincal ft = new Frm_Techincal();
            ft.ShowDialog();
            Techincal();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_Doctor fd = new Frm_Doctor();
            fd.ShowDialog();
            doctor();
        }

        private void cmb_Company_SelectionChangeCommitted(object sender, EventArgs e)
        {
          
            if (cmb_Company.Text!="")
            {
                rdb_Discount.Checked = true;
                txt_discount.Enabled = false;
                rdb_money.Enabled = false;
                rdb_Discount.Enabled = false;

                dt.Clear();
                dt = cm.SelectDiscount(Convert.ToInt32(cmb_Company.SelectedValue));
                txt_discount.Text = dt.Rows[0][0].ToString();

                totalOrder();
                Discount();
                pay();
 
            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
    }

