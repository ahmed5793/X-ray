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
using Laboratory.RPT_Order;
using DevExpress.XtraReports.UI;
using Tulpep.NotificationWindow;

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


        public Frm_Tickets()
        {
            InitializeComponent();
            Function();
            cmb_statues.SelectedIndex = 0;
            txt_pay.Enabled = true;

        }
        void Function()
        {
            Cmb_customer.Show();
            txt_name.Hide();
            cmb_Company.Enabled = false;
            txt_username.Text = Program.salesman;
            brnches();
            Customer();
            doctor();
            txt_phone.Enabled = false;
            txt_age.Enabled = false;
            txt_address.Enabled = false;
            Btn_DetailsCompany.Hide();
            txt_pay.Enabled = false;
        }
        void Permision()
        {
            try
            {

           
            //dt.Clear();
            //dt = u.SelectUserBranch(txt_username.Text);

            //if (dt.Rows.Count > 0)
            //{
            //    cmb_UserBranch.DataSource = u.SelectUserBranch(txt_username.Text);
            //    cmb_UserBranch.DisplayMember = "Name";
            //    cmb_UserBranch.ValueMember = "Branch_ID";

            //    cmb_Stock.DataSource = s.SelectStockBranch(Convert.ToInt32(cmb_UserBranch.SelectedValue));
            //    cmb_Stock.DisplayMember = "Name_Stock";
            //    cmb_Stock.ValueMember = "ID_Stock";
            //}
            //else
            //{
                cmb_UserBranch.DataSource = b.SelectCompBranches();
                cmb_UserBranch.DisplayMember = "Name";
                cmb_UserBranch.ValueMember = "Branch_ID";
                cmb_UserBranch.SelectedIndex = -1;
                cmb_Stock.DataSource = s.SelectStockBranch(Convert.ToInt32(cmb_UserBranch.SelectedValue));
                cmb_Stock.DisplayMember = "Name_Stock";
                cmb_Stock.ValueMember = "ID_Stock";
                //Stock();
                //}
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void rezizse()
        {
            try { 
            dgv_order.RowHeadersWidth = 20;
            dgv_order.Columns[1].Width = 180;
            dgv_order.Columns[2].Width = 90;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void SelectdataTable()
        {
            try { 
            dt2.Columns.Add("رقم الفحص");
            dt2.Columns.Add("اسم الفحص");
            dt2.Columns.Add("قيمة الفحص");
            dt2.Columns.Add("الخصم");
            dgv_order.DataSource = dt2;
            dgv_order.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        void company()
        {
            try { 
            cmb_Company.DataSource = cm.SelectCompany();
            cmb_Company.DisplayMember = "اسم الشركه";
            cmb_Company.ValueMember = "Comp_ID";
            cmb_Company.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        void doctor()
        {
            try { 
            cmb_Doctor.DataSource = d.SelectDoctor();
            cmb_Doctor.DisplayMember = "اسم الطبيب ";
            cmb_Doctor.ValueMember = "Doc_ID";
            cmb_Doctor.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        void brnches()
        {
            try
            { 
            cmb_branches.DataSource = b.SelectCompBranches();
            cmb_branches.DisplayMember = "Name";
            cmb_branches.ValueMember = "Branch_ID";
            cmb_branches.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

     
        void Customer()
        {
            try { 
            Cmb_customer.DataSource = c.SelectCompoCustomer();
            Cmb_customer.DisplayMember = "Cust_Name";
            Cmb_customer.ValueMember = "Cust_ID";
            Cmb_customer.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        void CategoryXraya()
        {
            try { 

            Cmb_category.DataSource = cx.selectCategoryXRaya();
            Cmb_category.DisplayMember = "الفئات";
            Cmb_category.ValueMember = "ID_CtegoryXrays";
            Cmb_category.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        void DoctorOfCenter()
        {
            try { 
            cmb_DoctorOfCenter.DataSource = dc.CompoDoctor_OFCENTER();
            cmb_DoctorOfCenter.DisplayMember = "Doc_Name";
            cmb_DoctorOfCenter.ValueMember = "Doc_ID";
            cmb_DoctorOfCenter.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        void Techincal()
        {
            try { 
            cmb_Techincal.DataSource = tc.CompoTechibncal();
            cmb_Techincal.DisplayMember = "Tech_Name";
            cmb_Techincal.ValueMember = "Techincal_ID";
            cmb_Techincal.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        Users u = new Users();
        void Function_Load()
        {
            try
            {
                Permision();
                rdb_discountPatient.Enabled = false;
                rdb_MoneyPatient.Enabled = false;
                Txt_addtionPayment.Enabled = false;
                Txt_rentCompany.Enabled = false;
                CategoryXraya();
                SelectdataTable();
                rezizse();
                txt_idcust.Hide();
                txt_IdTicket.Hide();
                totalOrder();
                DoctorOfCenter();
                Techincal();
                txt_idntational.Enabled = false;
                comboBox1.Enabled = false;
            }
            catch (Exception )
            {
                return;
                //MessageBox.Show(ex.Message);
            }
        }
        private void Frm_Tickets_Load(object sender, EventArgs e)
        {
            Function_Load();
        }
        void SelectTicketEmployee()
        {
            //if (rdb_CurrentPatient.Checked==true)
            //{
            //    dt.Clear();
            //    dt = t.SelectTicketEmployee(Convert.ToInt32(Cmb_customer.SelectedValue));


            //}


        }
        void Patient_PaymentRateMony()
        {
            try
            {
                if (Txt_addtionPayment.Text != "" && Txt_PricePayment.Text != "")
                {
                    if (Txt_addtionPayment.Text == "0")
                    {
                        Txt_addtionPayment.Text = "0";
                        //Txt_PricePayment.Text = "0";
                    }
                    else
                    {

                        decimal Amount = Convert.ToDecimal(txt_afterDiscount.Text);
                        decimal Discount = Convert.ToDecimal(Txt_PricePayment.Text);
                        decimal Total = Amount - Discount ;
                        Txt_PricePayment.Text = Math.Round(Total, 1).ToString();
                    }
                }
                else
                {

                    Txt_addtionPayment.Text = "0";
                    Txt_PricePayment.Text = "0";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        void Patient_PaymentRate()
        {
            try { 
            if (Txt_addtionPayment.Text != "" && Txt_PricePayment.Text != "")
            {
                if (Txt_addtionPayment.Text == "0")
                {
                    Txt_addtionPayment.Text = "0";
                    Txt_PricePayment.Text = "0";
                }
                else
                {
                    decimal Amount = Convert.ToDecimal(txt_afterDiscount.Text);
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
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        void Rent_Company()
        {
            try { 
            if (txt_afterDiscount.Text != "" && Txt_PricePayment.Text != "")
            {
                decimal Total = Convert.ToDecimal(txt_afterDiscount.Text) - Convert.ToDecimal(Txt_PricePayment.Text);
                Txt_rentCompany.Text = Math.Round(Total, 1).ToString();
            }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void totalOrder()
        {
            try { 
            decimal total = 0;
            for (int i = 0; i < dgv_order.Rows.Count; i++)
            {
                total += Convert.ToDecimal(dgv_order.Rows[i].Cells[2].Value);
            }
            txt_total.Text = Math.Round(total, 1).ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        public void pay()
        {
            try
            {

            decimal x = 0;
            
            if (txt_afterDiscount.Text != "" &&  txt_pay.Text != "")
            {
                //if (txt_pay.Text=="")
                //{
                //    txt_pay.Text = "0";
                //}
                if (cmb_statues.Text == "شركات")
                {
                    decimal totainv = Convert.ToDecimal(Txt_PricePayment.Text) - Convert.ToDecimal(txt_pay.Text);
                    txt_rent.Text = Math.Round(totainv, 1).ToString();
                }
                if (cmb_statues.Text == "نقدى")
                {
                    decimal totainv = Convert.ToDecimal(txt_afterDiscount.Text) - Convert.ToDecimal(txt_pay.Text);
                    txt_rent.Text = Math.Round(totainv, 1).ToString();
                }
            }
            else if (txt_pay.Text=="" && Txt_addtionPayment.Text=="")
            {
                if (cmb_statues.Text == "شركات")
                {
                    decimal totainv = Convert.ToDecimal(Txt_PricePayment.Text) - x;
                    txt_rent.Text = Math.Round(totainv, 1).ToString();
                }
                if (cmb_statues.Text == "نقدى")
                {
                    decimal totainv = Convert.ToDecimal(txt_afterDiscount.Text) - x;
                    txt_rent.Text = Math.Round(totainv, 1).ToString();
                }
            }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
               
            }

        }
        public void Discount()
        {
            try { 
            decimal x = 0;
            if (txt_total.Text != string.Empty && txt_discount.Text != string.Empty)
            {


                decimal discount = Convert.ToDecimal(txt_total.Text) - (Convert.ToDecimal(txt_total.Text) * (Convert.ToDecimal(txt_discount.Text) / 100));
                txt_afterDiscount.Text = Math.Round(discount, 1).ToString();
            }
            else
            {
                //txt_discount.Text = "0";
                decimal discount = Convert.ToDecimal(txt_total.Text) - x;
                txt_afterDiscount.Text = Math.Round(discount, 1).ToString();
                totalOrder();
            }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void DiscountMoney()
        {
            try { 
            decimal x = 0;
            if (txt_total.Text != string.Empty && txt_discount.Text != string.Empty)
            {


                decimal discount = Convert.ToDecimal(txt_total.Text) - Convert.ToDecimal(txt_discount.Text);
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
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        private void rdb_Compamy_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdb_client_CheckedChanged(object sender, EventArgs e)
        {

        }
        DataTable dt = new DataTable();
        private void Cmb_category_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //if (cmb_statues.Text=="")
            //{
            //    MessageBox.Show("من فضلك قم بااختيار طريقه التعامل اولا");
            //    Cmb_category.SelectedIndex = -1;
            //    cmb_statues.Focus();
            //    cmb_items.DataSource = null;
            //    return;
            //}
            try { 
                if (cmb_statues.Text == "نقدى")
                {
                    //dt.Clear();
                    //dt = ix.SelectCtegoryItems(Convert.ToInt32(Cmb_category.SelectedValue));
                    //if (dt.Rows.Count > 0)
                    //{
                        cmb_items.DataSource = ix.SelectCtegoryItems(Convert.ToInt32(Cmb_category.SelectedValue));
                        cmb_items.DisplayMember = "Name";
                        cmb_items.ValueMember = "ID_ItemsXrays";
                        cmb_items.SelectedIndex = -1;

                    //}
                    //else
                    //{
                    //    cmb_items.DataSource = null;
                    //}
                }

                //dt = ix.SelectCtegoryItems(Convert.ToInt32(Cmb_category.SelectedValue));
                //if (dt.Rows.Count > 0)
                //{
                //    cmb_items.DataSource = t.VildateselectItemXrayCompany(Convert.ToInt32(Cmb_category.SelectedValue));
                //    cmb_items.DisplayMember = "Name";
                //    cmb_items.ValueMember = "ID_ItemsXrays";
                //}
                //else
                //{
                //    cmb_items.DataSource = null;
                //}

                else if (cmb_statues.Text == "شركات")
                {
                if (cmb_Company.Text == "")
                {
                    //Cmb_category.DataSource = null;
                    //cmb_items.DataSource = null;
                    cmb_Company.Focus();
                    MessageBox.Show("من فضلك قم بااختيار الشركة");
                    Cmb_category.SelectedIndex=-1;
                    cmb_items.DataSource = null;
                        return;
                }                   
                    else /*if (Cmb_category.Text != "")*/
                    {
                        dt.Clear();
                        dt = t.VildateselectItemXrayCompany(Convert.ToInt32(cmb_Company.SelectedValue), Convert.ToInt32(Cmb_category.SelectedValue));
                        if (dt.Rows.Count > 0)
                        {
                            cmb_items.DataSource = t.VildateselectItemXrayCompany(Convert.ToInt32(cmb_Company.SelectedValue), Convert.ToInt32(Cmb_category.SelectedValue));
                            cmb_items.DisplayMember = "Name";
                            cmb_items.ValueMember = "ID_ItemsXrays";
                            cmb_items.SelectedIndex = -1;
                        }
                        //else
                        //{
                        //    cmb_items.DataSource = null;
                        //}
                    }
               
                
        }

                //dt.Clear();

                //dt = ix.SelectCtegoryItems(Convert.ToInt32(Cmb_category.SelectedValue));
                //if (dt.Rows.Count > 0)
                //{
                //    cmb_items.DataSource = ix.SelectCtegoryItems(Convert.ToInt32(Cmb_category.SelectedValue));
                //    cmb_items.DisplayMember = "Name";
                //    cmb_items.ValueMember = "ID_ItemsXrays";
                //}
                //else
                //{
                //    cmb_items.DataSource = null;
                //}
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    

        private void Cmb_category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cmb_customer_SelectionChangeCommitted(object sender, EventArgs e)
        {
        try {  
                dt.Clear();
                dt = c.SelectDataCompoCustomer(Convert.ToInt32(Cmb_customer.SelectedValue));
                if (dt.Rows.Count > 0)
                {
                    txt_phone.Text = dt.Rows[0][0].ToString();
                    txt_address.Text = dt.Rows[0][1].ToString();
                    txt_age.Text = dt.Rows[0][2].ToString();
                    comboBox1.Text = dt.Rows[0][3].ToString();
                    txt_idntational.Text = dt.Rows[0][4].ToString();
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
        catch (Exception ex)
        {

            MessageBox.Show(ex.Message);
        }
    }

        private void rdb_NewPatient_CheckedChanged(object sender, EventArgs e)
        {
        try {
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
                txt_idntational.Clear();
                txt_idntational.Enabled = true;
                comboBox1.Enabled = true;

            }
        }
        catch (Exception ex)
        {

            MessageBox.Show(ex.Message);
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
                txt_idntational.Enabled = false;
                comboBox1.Enabled = false;

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
            try { 
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
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Cmb_customer_KeyDown(object sender, KeyEventArgs e)
        {
            try { 
            dt.Clear();
            dt = c.SelectDataCompoCustomer(Convert.ToInt32(Cmb_customer.SelectedValue));
            if (dt.Rows.Count > 0)
            {
                txt_phone.Text = dt.Rows[0][0].ToString();
                txt_address.Text = dt.Rows[0][1].ToString();
                txt_age.Text = dt.Rows[0][2].ToString();

            }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txt_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            try { 
            if (e.KeyChar == '.' && txt_total.Text.ToString().IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar((System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)))
            {
                e.Handled = true;
            }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void text_discount_KeyPress(object sender, KeyPressEventArgs e)
        {
            try { 
            if (e.KeyChar == '.' && txt_discount.Text.ToString().IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar((System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)))
            {
                e.Handled = true;
            }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txt_pay_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == '.' && txt_pay.Text.ToString().IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
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
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //DiscountMoney();
            if (txt_discount.Text == "")
            {
                txt_discount.Text = "0";
            }
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
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //Discount();
            if (txt_discount.Text == "")
            {
                txt_discount.Text = "0";
            }
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
        }

        private void txt_discount_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txt_discount.Text == "")
                {
                    txt_discount.Text = "0";
                }
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
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
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
            try { 
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
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
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
            try {
                rdb_MoneyPatient.Enabled = false;
                rdb_discountPatient.Enabled = false;
                timer1.Enabled = true;
                dtb_visit.Value = Convert.ToDateTime(DateTime.Now.ToLongTimeString());
                Btn_Save.Enabled = true;
            rdb_money.Enabled = true;
            rdb_Discount.Enabled = true;
            txt_address.Clear();
            txt_idcust.Clear();
            txt_IdTicket.Clear();
            txt_age.Clear();
            txt_compint.Clear();          
            txt_name.Clear();
            txt_idntational.Clear();
            txt_phone.Clear();
            dt2.Clear();
            rdb_CurrentPatient.Checked = true;
            txt_discount.Enabled = true;
            txt_discount.Text = "0";
            txt_afterDiscount.Text = "0";
            Txt_PricePayment.Text = "0";
            Txt_addtionPayment.Text = "0";
            Txt_rentCompany.Text = "0";
            txt_reasonAddition.Clear();
            txt_rent.Text = "0";
            txt_total.Text = "0";
            txt_pay.Text = "0";
            //cmb_statues.SelectedIndex = -1;
            cmb_branches.SelectedIndex = -1;
                cmb_statues.SelectedIndex = 0;
            cmb_items.SelectedIndex = -1;
            Cmb_category.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;
            cmb_Doctor.SelectedIndex = -1;
            cmb_Techincal.SelectedIndex = -1;
            cmb_DoctorOfCenter.SelectedIndex = -1;
            cmb_Company.SelectedIndex = -1;
            Cmb_customer.SelectedIndex = -1;
            cmb_UserBranch.SelectedIndex = -1;
            cmb_Stock.SelectedIndex = -1;
            cmb_Company.Enabled = false;
            txt_pay.Enabled = true;
                Btn_DetailsCompany.Hide();
                Txt_addtionPayment.Enabled = false;
                Txt_rentCompany.Enabled = false;
                Txt_PricePayment.Enabled = false;
                rdb_MoneyPatient.Enabled = false;
                rdb_discountPatient.Enabled = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void label21_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

        }

     
        private void txt_afterDiscount_KeyUp(object sender, KeyEventArgs e)
        {
                
                Patient_PaymentRate();
                Rent_Company();
            
           
           
        }

        private void cmb_Techincal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgv_order_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            try { 
            totalOrder();

            if (rdb_Discount.Checked == true)
            {
                Discount();
            
            }
            else
            {
                DiscountMoney();
              
            }
            
            Patient_PaymentRate();
            Rent_Company();
            pay();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void txt_discount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && txt_discount.Text.ToString().IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {            
        }
        private void button3_Click(object sender, EventArgs e)
        {           
        }
        private void button2_Click(object sender, EventArgs e)
        {           
        }
        private void cmb_Company_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try { 
            if (cmb_statues.Text=="شركات")
            {

            if (cmb_Company.Text != "")
            {
                //rdb_Discount.Checked = true;
                //txt_discount.Enabled = false;
                //rdb_money.Enabled = false;
                //rdb_Discount.Enabled = false;
                totalOrder();
                Discount();
                pay();

                //Cmb_category.SelectedIndex = -1;
                //cmb_items.SelectedIndex = -1;
                //label26.Show();
                //label27.Show();
                //Txt_addtionPayment.Show();
                //Txt_PricePayment.Show();
                //label29.Show();
                Txt_rentCompany.Show();
                // label24.Hide();
                txt_discount.Enabled = false;
                rdb_Discount.Enabled = false;
                rdb_money.Enabled = false;
                txt_afterDiscount.Enabled = false;
                dt2.Clear();
                Txt_PricePayment.Text = "0";
                Txt_addtionPayment.Text = "0";
                Txt_rentCompany.Text = "0";
                txt_reasonAddition.Clear();
                txt_discount.Text = "0";
                txt_rent.Text = "0";
                txt_total.Text = "0";
                txt_pay.Text = "0";
                cmb_Company.Enabled = true;
                Txt_PricePayment.Enabled = true;
                Txt_addtionPayment.Enabled = true;
                dgv_order.Columns[3].Visible = true;
                        if (Cmb_category.Text=="")
                        {
                            cmb_items.DataSource = null;
                        }
                        else if (Cmb_category.Text != "")
                        {
                            dt.Clear();
                            dt = t.VildateselectItemXrayCompany(Convert.ToInt32(cmb_Company.SelectedValue), Convert.ToInt32(Cmb_category.SelectedValue));
                            if (dt.Rows.Count > 0)
                            {

                                cmb_items.DataSource = t.VildateselectItemXrayCompany(Convert.ToInt32(cmb_Company.SelectedValue), Convert.ToInt32(Cmb_category.SelectedValue));
                                cmb_items.DisplayMember = "Name";
                                cmb_items.ValueMember = "ID_ItemsXrays";
                                cmb_items.SelectedIndex = -1;
                            }
                            //else
                            //{
                            //    cmb_items.DataSource = null;
                            //}
                        }
            }

            }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
        }

        private void cmb_statues_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try { 
            if (cmb_statues.Text == "شركات")
            {
                //label26.Show();
                //label27.Show();
                //Txt_addtionPayment.Show();
                //Txt_PricePayment.Show();
                //label29.Show();
                Txt_rentCompany.Enabled=true;
                txt_discount.Enabled=false;
                rdb_Discount.Enabled = false;
                rdb_money.Enabled = false;
                txt_afterDiscount.Enabled = false;
                txt_pay.Enabled = false;
                dt2.Clear();
                Txt_PricePayment.Text = "0";
                Txt_addtionPayment.Text = "0";
                Txt_rentCompany.Text = "0";
                txt_reasonAddition.Clear();
                txt_discount.Text = "0";
                txt_rent.Text = "0";
                txt_total.Text = "0";
                txt_pay.Text = "0";
                cmb_Company.Enabled = true;
                Txt_PricePayment.Enabled = true;
                Txt_addtionPayment.Enabled = true;
                dgv_order.Columns[3].Visible = true ;
                company();
                Patient_PaymentRate();
                Btn_DetailsCompany.Show();
                Cmb_category.SelectedIndex = -1;
                cmb_items.SelectedIndex = -1;
                    rdb_MoneyPatient.Enabled = true;
                    rdb_discountPatient.Enabled = true;
            }
            else if (cmb_statues.Text== "نقدى")
            {
                    rdb_MoneyPatient.Enabled = false;
                    rdb_discountPatient.Enabled = false;
                    Cmb_category.SelectedIndex = -1;
                cmb_items.DataSource = null;
                label24.Show();
                //label26.Hide();
                //label27.Hide();
                //label29.Hide();
                rdb_Discount.Enabled = true;
                rdb_money.Enabled = true;
                txt_afterDiscount.Enabled = true;
                txt_discount.Enabled = true;
                dgv_order.Columns[3].Visible = false;
                dt2.Clear();
                Txt_PricePayment.Text = "0";
                Txt_addtionPayment.Text = "0";
                Txt_rentCompany.Text = "0";
                txt_reasonAddition.Clear();
                txt_discount.Text = "0";
                txt_rent.Text = "0";
                txt_total.Text = "0";
                txt_pay.Text = "0";
                cmb_Company.DataSource = null;
                cmb_Company.Enabled = false;
                Txt_PricePayment.Enabled = false;
                Txt_addtionPayment.Enabled = false;
                Txt_rentCompany.Enabled = false; 
                txt_pay.Enabled = true; 
                Btn_DetailsCompany.Hide();
            }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void txt_addition_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && Txt_addtionPayment.Text.ToString().IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar((System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)))
            {
                e.Handled = true;
            }
        }

        private void cmb_Techincal_Leave(object sender, EventArgs e)
        {
            try { 
            if (cmb_Techincal.Text!="")
            {
                dt.Clear();
                dt = tc.vildateTechincal(Convert.ToInt32(cmb_Techincal.SelectedValue));
                if (dt.Rows.Count==0)
                {
                    MessageBox.Show("يرجي العلم بان اسم الفني غير مسجل من قبل يرجي تسجيل هذا الاسم في شاشه الفني", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error,MessageBoxDefaultButton.Button1);
                 
                    cmb_Techincal.Focus();
                    cmb_Techincal.SelectAll();
                    return;
                } 
            }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void cmb_DoctorOfCenter_Leave(object sender, EventArgs e)
        {
            try { 
            if (cmb_DoctorOfCenter.Text != "")
            {
                dt.Clear();
                dt = dc.vildateDoctorOfCenter(Convert.ToInt32(cmb_DoctorOfCenter.SelectedValue));
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("يرجي العلم بان اسم طبيب الاشعة غير مسجل من قبل ", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                    cmb_DoctorOfCenter.Focus();
                    cmb_DoctorOfCenter.SelectAll();
                    return;
                }

            }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void cmb_items_Leave(object sender, EventArgs e)
        {
            try { 
            if (Cmb_category.Text !="" && cmb_items.Text!="" )
            {            
            dt.Clear();
            dt = ix.VildateItem(Convert.ToInt32(Cmb_category.SelectedValue), Convert.ToInt32(cmb_items.SelectedValue));
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("يرجي العلم بان الاشعة المسجلة غير مسجلة في هذا القسم");
                    cmb_items.Text = "";
                    return;
                }
            }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Cmb_category_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (cmb_statues.Text == "نقدى")
                {
                    //dt.Clear();
                    //dt = ix.SelectCtegoryItems(Convert.ToInt32(Cmb_category.SelectedValue));
                    //if (dt.Rows.Count > 0)
                    //{
                    cmb_items.DataSource = ix.SelectCtegoryItems(Convert.ToInt32(Cmb_category.SelectedValue));
                    cmb_items.DisplayMember = "Name";
                    cmb_items.ValueMember = "ID_ItemsXrays";
                    cmb_items.SelectedIndex = -1;

                    //}
                    //else
                    //{
                    //    cmb_items.DataSource = null;
                    //}
                }

                //dt = ix.SelectCtegoryItems(Convert.ToInt32(Cmb_category.SelectedValue));
                //if (dt.Rows.Count > 0)
                //{
                //    cmb_items.DataSource = t.VildateselectItemXrayCompany(Convert.ToInt32(Cmb_category.SelectedValue));
                //    cmb_items.DisplayMember = "Name";
                //    cmb_items.ValueMember = "ID_ItemsXrays";
                //}
                //else
                //{
                //    cmb_items.DataSource = null;
                //}

                else if (cmb_statues.Text == "شركات")
                {
                    if (cmb_Company.Text == "")
                    {
                        //Cmb_category.DataSource = null;
                        //cmb_items.DataSource = null;
                        cmb_Company.Focus();
                        MessageBox.Show("من فضلك قم بااختيار الشركة");
                        Cmb_category.SelectedIndex = -1;
                        cmb_items.DataSource = null;
                        return;
                    }
                    else if (Cmb_category.Text != "")
                    {
                        dt.Clear();
                        dt = t.VildateselectItemXrayCompany(Convert.ToInt32(cmb_Company.SelectedValue), Convert.ToInt32(Cmb_category.SelectedValue));
                        if (dt.Rows.Count > 0)
                        {
                            cmb_items.DataSource = t.VildateselectItemXrayCompany(Convert.ToInt32(cmb_Company.SelectedValue), Convert.ToInt32(Cmb_category.SelectedValue));
                            cmb_items.DisplayMember = "Name";
                            cmb_items.ValueMember = "ID_ItemsXrays";
                            cmb_items.SelectedIndex = -1;
                        }
                        //else
                        //{
                        //    cmb_items.DataSource = null;
                        //}
                    }


                }

                //dt.Clear();

                //dt = ix.SelectCtegoryItems(Convert.ToInt32(Cmb_category.SelectedValue));
                //if (dt.Rows.Count > 0)
                //{
                //    cmb_items.DataSource = ix.SelectCtegoryItems(Convert.ToInt32(Cmb_category.SelectedValue));
                //    cmb_items.DisplayMember = "Name";
                //    cmb_items.ValueMember = "ID_ItemsXrays";
                //}
                //else
                //{
                //    cmb_items.DataSource = null;
                //}
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Cmb_category_Leave(object sender, EventArgs e)
        {
            try { 
            if (Cmb_category.Text != "")
            {
                dt.Clear();
                dt = cx.Validate_CategoryXray(Convert.ToInt32(Cmb_category.SelectedValue));
                if (dt.Rows.Count == 0)
                {
                    cmb_items.DataSource = null;
                    MessageBox.Show("عزيزيى المستخدم يرجي العلم بان اسم الجهاز غير مسجل ");
                }
            }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void cmb_statues_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_statues.Text== "نقدى")
            {
                txt_pay.Enabled = true;
              
            }
            else if (cmb_statues.Text == "شركات")
            {
                txt_pay.Enabled = false;
            }
        }

        private void Txt_addtionPayment_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (e.KeyChar == '.' && Txt_addtionPayment.Text.ToString().IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar((System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)))
            {
                e.Handled = true;
            }

        
        }

        private void Txt_addtionPayment_KeyUp(object sender, KeyEventArgs e)
        {
            if (rdb_discountPatient.Checked==true)
            {
                Patient_PaymentRate();
                Rent_Company();
                pay();
            }
            else if(rdb_MoneyPatient.Checked==true)
            {
                Patient_PaymentRateMony();
                Rent_Company();
                pay();
            }
           
        }
        private void Txt_PricePayment_KeyUp(object sender, KeyEventArgs e)
        {
            try {
               
                if (rdb_discountPatient.Checked == true)
                {

                    Patient_PaymentRate();
                    Rent_Company();
                    pay();
                }
                else if (rdb_MoneyPatient.Checked == true)
                {
                    //Patient_PaymentRateMony();
                    Rent_Company();
                    pay();
                }
                if (cmb_statues.Text == "شركات")
            {
                if (Convert.ToDecimal(Txt_addtionPayment.Text) > 0 || Convert.ToDecimal(Txt_PricePayment.Text) > 0)
                    {
                    txt_pay.Enabled = true;
                }
                else if (Convert.ToDecimal(Txt_addtionPayment.Text) <= 0 || (Txt_addtionPayment.Text) == "")
                {
                    txt_pay.Enabled = false;

                }
            }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Txt_addtionPayment_MouseLeave(object sender, EventArgs e)
        {
            try { 
            if (Txt_addtionPayment.Text=="")
            {
                Txt_addtionPayment.Text = "0";
            }
            if (Convert.ToDecimal(Txt_addtionPayment.Text )> 0 || Txt_addtionPayment.Text=="")
            {
                txt_pay.Enabled = true;
            }
            else
            {
                txt_pay.Enabled = false;
            }
                if (rdb_discountPatient.Checked == true)
                {
                    Patient_PaymentRate();
                    Rent_Company();
                    pay();
                }
                else if (rdb_MoneyPatient.Checked == true)
                {
                    Patient_PaymentRateMony();
                    Rent_Company();
                    pay();
                }
           
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void cmb_Company_Leave(object sender, EventArgs e)
        {
            
            DataTable dt2 = new DataTable();
            try
            {
                if (cmb_Company.Text != "")
                {
                    dt2.Clear();
                    dt2 = cm.Validate_CompanyNAme(Convert.ToInt32(cmb_Company.SelectedValue));
                    if (dt2.Rows.Count == 0)
                    {
                        MessageBox.Show("إسم الشركة غير صحيح");
                        cmb_Company.Focus();
                        cmb_Company.SelectAll();
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
                dt2.Dispose();
            }
        }

        private void Txt_addtionPayment_Click(object sender, EventArgs e)
        {
            Txt_addtionPayment.Text="";
        }

        private void txt_discount_Click(object sender, EventArgs e)
        {
            txt_discount.Text="";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txt_rent_Click(object sender, EventArgs e)
        {
          
        }

        private void txt_pay_Click(object sender, EventArgs e)
        {
            if (txt_pay.Text=="0")
            {
                txt_pay.Text = "";

            }
            else
            {
                txt_pay.SelectAll();
            }
        }

        private void cmb_Doctor_Leave(object sender, EventArgs e)
        {
            try { 
            DataTable dt = new DataTable();
            if (cmb_Doctor.Text != "")
            {
                dt.Clear();
                dt = d.vildateOutDoctor(Convert.ToInt32(cmb_Doctor.SelectedValue));
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("يرجي العلم بان اسم الطبيب غير مسجل من قبل ", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                    cmb_Doctor.Focus();
                    cmb_Doctor.SelectAll();
                    return;
                }
                dt.Dispose();
            }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_DetailsCompany_Click(object sender, EventArgs e)
        {
        }

        private void Txt_addtionPayment_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void Txt_addtionPayment_TextChanged(object sender, EventArgs e)
        {
            if (Txt_addtionPayment.Text == ".")
            {
                Txt_addtionPayment.Text = "";
            }
           
        }

        private void txt_pay_TextChanged(object sender, EventArgs e)
        {
            if (txt_pay.Text==".")
            {
                txt_pay.Text = "";
            }

        }

        private void txt_total_TextChanged(object sender, EventArgs e)
        {
        }
        private void txt_discount_TextChanged(object sender, EventArgs e)
        {
            if (txt_discount.Text == ".")
            {
                txt_discount.Text = "";
            }
        }

        private void txt_pay_MouseLeave(object sender, EventArgs e)
        {
            if (txt_pay.Text=="")
            {
                txt_pay.Text = "0";
            }
            pay();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            try { 
            clear();
            Customer();
           
            cmb_statues.Enabled = true;
        
            txt_pay.Enabled = true;
            cmb_items.Enabled = true;
            Cmb_category.Enabled = true;
            Cmb_customer.Enabled = true;
            cmb_Doctor.Enabled = true;
            cmb_DoctorOfCenter.Enabled = true;
            cmb_Techincal.Enabled = true;
            cmb_branches.Enabled = true;
            cmb_Stock.Enabled = true;
            cmb_UserBranch.Enabled = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {         
            //    Rpt_OrderPay report = new Rpt_OrderPay();
            //    s.documentViewer1.Refresh();
            //    DataTable dt5 = new DataTable();
            //    dt5.Clear();
            //    dt5 = t.ReportInvoiceTicketPay(Convert.ToInt32(dgv_visit.CurrentRow.Cells[0].Value));
            //    report.Parameters["@idTicket"].Value = Convert.ToInt32(dgv_visit.CurrentRow.Cells[0].Value);
            //    report.DataSource = dt5;

            //    s.documentViewer1.DocumentSource = report;
            //    report.Parameters["@idTicket"].Visible = false;
            //    s.ShowDialog();

            //Rpt_OrderCompany oc = new Rpt_OrderCompany();

            //s.documentViewer1.Refresh();

            //oc.DataSource = t.ReportInvoiceTicketCompany(Convert.ToInt32(dgv_visit.CurrentRow.Cells[0].Value));

            //oc.Parameters["@idTicket"].Value = Convert.ToInt32(dgv_visit.CurrentRow.Cells[0].Value);

            //s.documentViewer1.DocumentSource = oc;
            //oc.Parameters["@idTicket"].Visible = false;
            //s.ShowDialog();
            try
            {
                if (dgv_order.Rows.Count > 0)
                {
                    if (cmb_UserBranch.Text == "")
                    {
                        MessageBox.Show("من فضلك قم بتحديد الفرع التي يتم من خلاله الحجز وتاكد من وجود الخزنة   ");
                        return;
                    }
                    if (cmb_branches.Text == "")
                    {
                        MessageBox.Show("من فضلك قم بتحديد الفرع التي يتم الفحص به   ");
                        return;
                    }
                    if (cmb_statues.Text == "")
                    {
                        MessageBox.Show("من فضلك قم بتحديد طريقة التعامل");
                        return;
                    }
                    if (cmb_Doctor.Text == "")
                    {
                        MessageBox.Show("من فضلك قم باادخال الطبيب المعالج للمريض");
                        return;
                    }
                    if (cmb_DoctorOfCenter.Text == "")
                    {
                        MessageBox.Show("من فضلك قم باادخال طبيب الحالة");
                        cmb_DoctorOfCenter.Focus();
                        return;
                    }
                    if (cmb_Techincal.Text == "")
                    {
                        MessageBox.Show("من فضلك قم باادخال الفني");
                        cmb_Techincal.Focus();
                        return;
                    }
                    //if (txt_compint.Text == "")
                    //{
                    //    MessageBox.Show("من فضلك قم باادخال الشكوي");
                    //    return;
                    //}


                    //if (Cmb_category.Text == "")
                    //{
                    //    MessageBox.Show("من فضلك قم بااختيار فئة الفحص");

                    //    return;
                    //}
                    //if (cmb_items.Text == "")
                    //{
                    //    MessageBox.Show("من فضلك قم بااختيار نوع الفحص");
                    //    return;
                    //}
                    
                    if (cmb_statues.Text == "نقدى")
                    {


                      decimal  mb = Convert.ToDecimal(txt_total.Text) - Convert.ToDecimal(txt_afterDiscount.Text);
                        if (rdb_NewPatient.Checked == true)
                        {
                            
                            if (txt_name.Text == "")
                            {
                                MessageBox.Show("من فضلك قم باادخال إسم العميل  ");
                                txt_name.Focus();
                                return;
                            }
                            if (comboBox1.Text == "")
                            {
                                MessageBox.Show("من فضلك قم بتحديد النوع ");
                                comboBox1.Focus();
                                return;
                            }
                            if (txt_age.Text == "")
                            {
                                MessageBox.Show("من فضلك قم بتحديد سن العميل ");
                                txt_age.Focus();
                                return;
                            }
                            Btn_Save.Enabled = false;

                            c.addCustomer(txt_name.Text, txt_address.Text, txt_phone.Text, Convert.ToInt32(txt_age.Text), dtb_visit.Value, comboBox1.Text, txt_idntational.Text);
                            txt_idcust.Text = c.LastIdCustomer().Rows[0][0].ToString();
                            c.Add_CustomerTotalBalance(Convert.ToInt32(txt_idcust.Text));

                            //t.AddTickets(dtb_visit.Value, dtp_recive.Value, Convert.ToDecimal(txt_total.Text), Convert.ToDecimal(txt_pay.Text),
                            //    Convert.ToDecimal(txt_rent.Text), Convert.ToInt32(txt_idcust.Text), cmb_statues.Text, Convert.ToInt32(cmb_Doctor.SelectedValue),
                            //    Convert.ToInt32(cmb_branches.SelectedValue), Convert.ToInt32(cmb_Stock.SelectedValue), dtb_kashf.Value,
                            //    txt_compint.Text, Convert.ToInt32(cmb_DoctorOfCenter.SelectedValue), Convert.ToInt32(cmb_Techincal.SelectedValue), txt_username.Text,
                            //    cmb_UserBranch.Text, Convert.ToDecimal(Txt_addtionPayment.Text), txt_reasonAddition.Text, Convert.ToDecimal(txt_afterDiscount.Text),
                            //    Convert.ToDecimal(Txt_PricePayment.Text),"active");
                        
                                DataTable dt = new DataTable();
                            dt.Clear();
                                dt = t.AddTickets(dtb_visit.Value, dtp_recive.Value, Convert.ToDecimal(txt_total.Text), Convert.ToDecimal(txt_pay.Text),
                                Convert.ToDecimal(txt_rent.Text), Convert.ToInt32(txt_idcust.Text), cmb_statues.Text, Convert.ToInt32(cmb_Doctor.SelectedValue),
                                Convert.ToInt32(cmb_branches.SelectedValue), Convert.ToInt32(cmb_Stock.SelectedValue), dtb_kashf.Value,
                                txt_compint.Text, Convert.ToInt32(cmb_DoctorOfCenter.SelectedValue), Convert.ToInt32(cmb_Techincal.SelectedValue), txt_username.Text,
                                cmb_UserBranch.Text, Convert.ToDecimal(Txt_addtionPayment.Text), txt_reasonAddition.Text, Convert.ToDecimal(txt_afterDiscount.Text),
                                Convert.ToDecimal(Txt_PricePayment.Text), "active");
                                int ID = int.Parse(dt.Rows[0][0].ToString());

                                txt_IdTicket.Text =ID.ToString();

                           // decimal mb = Convert.ToDecimal(txt_total.Text) - Convert.ToDecimal(txt_afterDiscount.Text);
                            t.AddTickestDiscount(Convert.ToInt32(txt_IdTicket.Text), mb);
                            //txt_IdTicket.Text = t.LastIdTicket().Rows[0][0].ToString();


                            if (Convert.ToDecimal(txt_pay.Text) > 0)
                                {
                                    s.add_insertStock(Convert.ToInt32(cmb_Stock.SelectedValue), Convert.ToDecimal(txt_pay.Text), dtb_visit.Value,
                                                      txt_username.Text, "فاتورة حجز اشعة  رقم " + (txt_IdTicket.Text)+ " " + "للعميل"+ " " + txt_name.Text);
                                }
                            
                          

                            for (int i = 0; i < dgv_order.Rows.Count; i++)
                            {
                                t.AddTicketDetails(Convert.ToInt32(txt_IdTicket.Text), Convert.ToInt32(dgv_order.Rows[i].Cells[0].Value),
                                    Convert.ToDecimal(dgv_order.Rows[i].Cells[2].Value));
                            }


                            dt.Clear();
                            dt = c.Select_CustomertotalBAlance(Convert.ToInt32(txt_idcust.Text));
                            decimal mno = Convert.ToDecimal(dt.Rows[0][0]) + Convert.ToDecimal(txt_rent.Text);
                            c.Update_CustomerTotalBalance(Convert.ToInt32(txt_idcust.Text), mno);
                            c.Add_CustomerAccountStatment(Convert.ToInt32(txt_idcust.Text), Convert.ToDecimal(txt_pay.Text), 
                                Convert.ToDecimal(txt_afterDiscount.Text)
                                 , dtb_visit.Value, mno, Convert.ToInt32(cmb_Stock.SelectedValue)
                                 , txt_username.Text, Convert.ToInt32(cmb_UserBranch.SelectedValue), "حجز أشعة ورقم الحجز" + " " +(txt_IdTicket.Text));
                           
                            
                            ///////////////////////////////////
                            ///
                            //for (int i = 0; i < dgv_order.Rows.Count; i++)
                            //{
                              
                            //        t.addticketsReturn(Convert.ToInt32(txt_IdTicket.Text), Convert.ToInt32(cmb_Stock.SelectedValue), cmb_UserBranch.Text,
                            //            txt_name.Text, txt_name.Text, dgv_order.Rows[i].Cells[1].Value.ToString(), dtb_visit.Value
                            //            , 0, ".", Convert.ToDecimal(dgv_order.Rows[i].Cells[2].Value),
                            //              Convert.ToDecimal(txt_pay.Text), txt_username.Text,
                            //              Convert.ToInt32(dgv_order.Rows[i].Cells[0].Value), Convert.ToInt32(cmb_UserBranch.SelectedValue));
                                

                            //    t.Add_Revenue(Convert.ToInt32(cmb_UserBranch.SelectedValue), Convert.ToInt32(txt_IdTicket.Text),
                            //        Convert.ToInt32(dgv_order.Rows[i].Cells[0].Value), Convert.ToDecimal(dgv_order.Rows[i].Cells[2].Value)
                            //        , mb, Convert.ToDecimal(txt_pay.Text), Convert.ToDecimal(txt_rent.Text), dtb_visit.Value);
                            //}

                            MessageBox.Show("تم حفظ الفاتورة بنجاح");



                        }
                        else if (rdb_CurrentPatient.Checked == true)
                        {
                            if (Cmb_customer.Text == "")
                            {
                                MessageBox.Show("من فضلك قم باادخال إسم العميل  ");
                                Cmb_customer.Focus();
                                return;
                            }
                            Btn_Save.Enabled = false;
                            dt.Clear();
                         dt=   t.AddTickets(dtb_visit.Value, dtp_recive.Value, Convert.ToDecimal(txt_total.Text), Convert.ToDecimal(txt_pay.Text),
                                Convert.ToDecimal(txt_rent.Text), Convert.ToInt32(Cmb_customer.SelectedValue), cmb_statues.Text, Convert.ToInt32(cmb_Doctor.SelectedValue),
                                Convert.ToInt32(cmb_branches.SelectedValue), Convert.ToInt32(cmb_Stock.SelectedValue), dtb_kashf.Value,
                                txt_compint.Text, Convert.ToInt32(cmb_DoctorOfCenter.SelectedValue), Convert.ToInt32(cmb_Techincal.SelectedValue), txt_username.Text,
                                    cmb_UserBranch.Text, Convert.ToDecimal(Txt_addtionPayment.Text), txt_reasonAddition.Text, Convert.ToDecimal(txt_afterDiscount.Text),
                                    Convert.ToDecimal(Txt_PricePayment.Text), "active");
                            int ID = int.Parse(dt.Rows[0][0].ToString());

                            txt_IdTicket.Text = ID.ToString();

                          
                            t.AddTickestDiscount(Convert.ToInt32(txt_IdTicket.Text), mb);
                            //txt_IdTicket.Text = t.LastIdTicket().Rows[0][0].ToString();

                            if (Convert.ToDecimal(txt_pay.Text) > 0)
                            {
                                s.add_insertStock(Convert.ToInt32(cmb_Stock.SelectedValue), Convert.ToDecimal(txt_pay.Text), dtb_visit.Value,
                                                  txt_username.Text, "فاتورة حجز اشعة رقم " + (txt_IdTicket.Text) + " " + "للعميل" + " "+ Cmb_customer.Text);
                            }

                            for (int i = 0; i < dgv_order.Rows.Count; i++)
                            {
                                t.AddTicketDetails(Convert.ToInt32(txt_IdTicket.Text), Convert.ToInt32(dgv_order.Rows[i].Cells[0].Value),
                                    Convert.ToDecimal(dgv_order.Rows[i].Cells[2].Value));
                            }

                            dt.Clear();
                            dt = c.Select_CustomertotalBAlance(Convert.ToInt32(Cmb_customer.SelectedValue));
                            decimal mno = Convert.ToDecimal(dt.Rows[0][0]) + Convert.ToDecimal(txt_rent.Text);
                            c.Update_CustomerTotalBalance(Convert.ToInt32(Cmb_customer.SelectedValue), mno);
                            c.Add_CustomerAccountStatment(Convert.ToInt32(Cmb_customer.SelectedValue), Convert.ToDecimal(txt_pay.Text),
                                Convert.ToDecimal(txt_afterDiscount.Text)
                                 , dtb_visit.Value, mno, Convert.ToInt32(cmb_Stock.SelectedValue)
                                 , txt_username.Text, Convert.ToInt32(cmb_UserBranch.SelectedValue), "حجز أشعة ورقم الحجز" + " " + (txt_IdTicket.Text));

                            //for (int i = 0; i < dgv_order.Rows.Count; i++)
                            //{

                            //        t.addticketsReturn(Convert.ToInt32(txt_IdTicket.Text), Convert.ToInt32(cmb_Stock.SelectedValue), cmb_UserBranch.Text,
                            //            Cmb_customer.Text, cmb_statues.Text, dgv_order.Rows[i].Cells[1].Value.ToString(), dtb_visit.Value
                            //            , 0, ".", Convert.ToDecimal(dgv_order.Rows[i].Cells[2].Value),
                            //              Convert.ToDecimal(txt_pay.Text), txt_username.Text, Convert.ToInt32(dgv_order.Rows[i].Cells[0].Value),
                            //              Convert.ToInt32(cmb_UserBranch.SelectedValue));


                            //    t.Add_Revenue(Convert.ToInt32(cmb_UserBranch.SelectedValue), Convert.ToInt32(txt_IdTicket.Text),
                            //        Convert.ToInt32(dgv_order.Rows[i].Cells[0].Value), Convert.ToDecimal(dgv_order.Rows[i].Cells[2].Value)
                            //        , mb, Convert.ToDecimal(txt_pay.Text), Convert.ToDecimal(txt_rent.Text), dtb_visit.Value);
                            //}

                            MessageBox.Show("تم حفظ الفاتورة بنجاح");
                    

                        }
                       
                        //decimal mb = Convert.ToDecimal(txt_total.Text) - Convert.ToDecimal(txt_afterDiscount.Text);
                        //t.AddTickestDiscount(Convert.ToInt32(txt_IdTicket.Text), mb);
                        ////////////
                     

                        
                        //////////////
                        //DataTable dt1 = new DataTable();
                        //dt1.Clear();

                        //dt1 = t.ReportInvoiceTicketPay(Convert.ToInt32(txt_IdTicket.Text));
                        //frm_SingelReport sr = new frm_SingelReport();

                        //Rpt_OrderPay report = new Rpt_OrderPay();
                        //RPT.Order.DataSetOrderPay dso = new RPT.Order.DataSetOrderPay();
                        //sr.documentViewer1.Refresh();
                        //dso.Tables["DataTable1"].Clear();
                        //for (int i = 0; i < dt1.Rows.Count; i++)
                        //{
                        //    //dso.Tables["DataTable1"].Rows.Add(Convert.ToInt32(dt1.Rows[i][0]), dt1.Rows[i][1], dt1.Rows[i][2],
                        //    //    Convert.ToDecimal(dt1.Rows[i][3]), dt1.Rows[i][4], dt1.Rows[i][5], Convert.ToInt32(dt1.Rows[i][6]),
                        //    //    Convert.ToDateTime(dt1.Rows[i][7]),Convert.ToDateTime(dt1.Rows[i][8]), dt1.Rows[i][9], dt1.Rows[i][10],
                        //    //    dt1.Rows[i][11], dt1.Rows[i][12], dt1.Rows[i][13],Convert.ToDecimal(dt1.Rows[i][14]), 
                        //    //    Convert.ToDecimal(dt1.Rows[i][15]), Convert.ToDecimal(dt1.Rows[i][16]),dt1.Rows[i][17], dt1.Rows[i][18],
                        //    //    dt1.Rows[i][19], Convert.ToDateTime(dt1.Rows[i][20]), Convert.ToDecimal(dt1.Rows[i][21]),
                        //    //    dt1.Rows[i][22], Convert.ToDecimal(dt1.Rows[i][23]), dt1.Rows[i][24], Convert.ToInt32(dt1.Rows[i][25]),
                        //    //    Convert.ToInt32(dt1.Rows[i][26]),Convert.ToInt32(dt1.Rows[i][27]));


                        //    dso.Tables["DataTable1"].Rows.Add(dt1.Rows[i][0], dt1.Rows[i][1], dt1.Rows[i][2],
                        //       dt1.Rows[i][3], dt1.Rows[i][4], dt1.Rows[i][5],dt1.Rows[i][6],
                        //       dt1.Rows[i][7], dt1.Rows[i][8], dt1.Rows[i][9], dt1.Rows[i][10],
                        //       dt1.Rows[i][11], dt1.Rows[i][12], dt1.Rows[i][13], dt1.Rows[i][14],
                        //       dt1.Rows[i][15], dt1.Rows[i][16], dt1.Rows[i][17], dt1.Rows[i][18],
                        //       dt1.Rows[i][19],dt1.Rows[i][20], dt1.Rows[i][21],
                        //       dt1.Rows[i][22], dt1.Rows[i][23], dt1.Rows[i][24], dt1.Rows[i][25],
                        //       dt1.Rows[i][26], dt1.Rows[i][27], dt1.Rows[i][28], dt1.Rows[i][29]);
                        //}
                        //report.DataSource = dso;
                        //report.Parameters["idTicket"].Value = Convert.ToInt32(txt_IdTicket.Text);
                        //sr.documentViewer1.DocumentSource = report;
                        //report.Parameters["idTicket"].Visible = false;
                        //sr.documentViewer1.Enabled = true;
                        //sr.ShowDialog();

                    }
                    else if (cmb_statues.Text == "شركات")
                    {
                      
                        if (cmb_Company.Text == "")
                        {
                            MessageBox.Show("من فضلك قم بااختيار شركه");
                            return;
                        }
                        if (rdb_NewPatient.Checked == true)
                        {
                            if (txt_name.Text == "")
                            {
                                MessageBox.Show("من فضلك قم باادخال إسم العميل ");
                                txt_name.Focus();
                                return;
                            }
                            if (comboBox1.Text == "")
                            {
                                MessageBox.Show("من فضلك قم بتحديد النوع ");
                                comboBox1.Focus();
                                return;
                            }
                            //if (txt_age.Text == "")
                            //{
                            //    MessageBox.Show("من فضلك قم بتحديد سن العميل ");
                            //    txt_age.Focus();
                            //    return;
                            //}
                            Btn_Save.Enabled = false;
                            c.addCustomer(txt_name.Text, txt_address.Text, txt_phone.Text, Convert.ToInt32(txt_age.Text), dtb_visit.Value, comboBox1.Text, txt_idntational.Text);
                            txt_idcust.Text = c.LastIdCustomer().Rows[0][0].ToString();                      
                            c.Add_CustomerTotalBalance(Convert.ToInt32(txt_idcust.Text));
                            dt.Clear();
                            dt=  t.AddTickets(dtb_visit.Value, dtp_recive.Value, Convert.ToDecimal(txt_total.Text), Convert.ToDecimal(txt_pay.Text),
                                Convert.ToDecimal(txt_rent.Text), Convert.ToInt32(txt_idcust.Text), cmb_statues.Text, Convert.ToInt32(cmb_Doctor.SelectedValue),
                                Convert.ToInt32(cmb_branches.SelectedValue), Convert.ToInt32(cmb_Stock.SelectedValue), dtb_kashf.Value,
                                txt_compint.Text, Convert.ToInt32(cmb_DoctorOfCenter.SelectedValue), Convert.ToInt32(cmb_Techincal.SelectedValue), txt_username.Text,
                                    cmb_UserBranch.Text, Convert.ToDecimal(Txt_addtionPayment.Text), txt_reasonAddition.Text, Convert.ToDecimal(txt_afterDiscount.Text),
                                    Convert.ToDecimal(Txt_PricePayment.Text), "active");
                            int ID = int.Parse(dt.Rows[0][0].ToString());

                            txt_IdTicket.Text = ID.ToString();
                            //txt_IdTicket.Text = t.LastIdTicket().Rows[0][0].ToString();

                            if (Convert.ToDecimal(txt_pay.Text) > 0)
                            {
                                s.add_insertStock(Convert.ToInt32(cmb_Stock.SelectedValue), Convert.ToDecimal(txt_pay.Text), dtb_visit.Value,
                                                  txt_username.Text, "فاتورة حجز اشعة رقم " + (txt_IdTicket.Text) + " " + "للعميل"+ " "+ txt_name.Text);
                            }
                            t.AddTickestDiscount(Convert.ToInt32(txt_IdTicket.Text), Convert.ToDecimal(txt_discount.Text));
            
                            for (int i = 0; i < dgv_order.Rows.Count; i++)
                            {
                                t.AddTicketDetails(Convert.ToInt32(txt_IdTicket.Text), Convert.ToInt32(dgv_order.Rows[i].Cells[0].Value),
                                    Convert.ToDecimal(dgv_order.Rows[i].Cells[2].Value));
                            }


                            dt.Clear();
                            dt = c.Select_CustomertotalBAlance(Convert.ToInt32(txt_idcust.Text));
                            decimal mno1 = Convert.ToDecimal(dt.Rows[0][0]) + Convert.ToDecimal(txt_rent.Text);
                            c.Update_CustomerTotalBalance(Convert.ToInt32(txt_idcust.Text), mno1);
                            c.Add_CustomerAccountStatment(Convert.ToInt32(txt_idcust.Text), Convert.ToDecimal(txt_pay.Text),
                                Convert.ToDecimal(Txt_PricePayment.Text)
                                 , dtb_visit.Value, mno1, Convert.ToInt32(cmb_Stock.SelectedValue)
                                 , txt_username.Text, Convert.ToInt32(cmb_UserBranch.SelectedValue), "حجز أشعة ورقم الحجز" + " " +( txt_IdTicket.Text));

                            ///////////////////////

                            dt.Clear();
                            dt = cm.Select_CompanyTotalMoney(Convert.ToInt32(cmb_Company.SelectedValue));
                            decimal mno = Convert.ToDecimal(dt.Rows[0][0]) + Convert.ToDecimal(Txt_rentCompany.Text);
                            cm.Update_CompanyTotalMoney(Convert.ToInt32(cmb_Company.SelectedValue), mno);
                            cm.ADD_Company_TotalRent(Convert.ToInt32(cmb_Company.SelectedValue), 0, Convert.ToDecimal(Txt_rentCompany.Text)
                                 , dtb_visit.Value, mno, "حجز أشعة ورقم الحجز   " + " " +( txt_IdTicket.Text) + " " + "إلى" + " " + txt_name.Text, Convert.ToInt32(cmb_Stock.SelectedValue)
                                 , Convert.ToInt32(cmb_UserBranch.SelectedValue), txt_username.Text);

                            //////////////////////////////////
                            //for (int i = 0; i < dgv_order.Rows.Count; i++)
                            //{
                               
                            //        t.addticketsReturn(Convert.ToInt32(txt_IdTicket.Text), Convert.ToInt32(cmb_Stock.SelectedValue), cmb_UserBranch.Text,
                            //            txt_name.Text, cmb_statues.Text, dgv_order.Rows[i].Cells[1].Value.ToString(), dtb_visit.Value
                            //            , 0, ".", Convert.ToDecimal(dgv_order.Rows[i].Cells[2].Value),
                            //              Convert.ToDecimal(txt_pay.Text), txt_username.Text,
                            //              Convert.ToInt32(dgv_order.Rows[i].Cells[0].Value), Convert.ToInt32(cmb_UserBranch.SelectedValue));
                                

                            //    t.Add_Revenue(Convert.ToInt32(cmb_UserBranch.SelectedValue), Convert.ToInt32(txt_IdTicket.Text),
                            //        Convert.ToInt32(dgv_order.Rows[i].Cells[0].Value), Convert.ToDecimal(dgv_order.Rows[i].Cells[2].Value)
                            //        , 0, Convert.ToDecimal(txt_pay.Text), Convert.ToDecimal(txt_rent.Text), dtb_visit.Value);
                            //}





                            MessageBox.Show("تم حفظ الفاتورة بنجاح");

             
                        }

                        else if (rdb_CurrentPatient.Checked == true)
                        {
                            if (Cmb_customer.Text == "")
                            {
                                MessageBox.Show("من فضلك قم باادخال إسم العميل  ");
                                Cmb_customer.Focus();
                                return;
                            }
                            Btn_Save.Enabled = false;
                            dt.Clear();
                         dt=   t.AddTickets(dtb_visit.Value, dtp_recive.Value, Convert.ToDecimal(txt_total.Text), Convert.ToDecimal(txt_pay.Text),
                                Convert.ToDecimal(txt_rent.Text), Convert.ToInt32(Cmb_customer.SelectedValue), cmb_statues.Text, Convert.ToInt32(cmb_Doctor.SelectedValue),
                                Convert.ToInt32(cmb_branches.SelectedValue), Convert.ToInt32(cmb_Stock.SelectedValue), dtb_kashf.Value,
                                txt_compint.Text, Convert.ToInt32(cmb_DoctorOfCenter.SelectedValue), Convert.ToInt32(cmb_Techincal.SelectedValue), txt_username.Text,
                                    cmb_UserBranch.Text, Convert.ToDecimal(Txt_addtionPayment.Text), txt_reasonAddition.Text, Convert.ToDecimal(txt_afterDiscount.Text),
                                    Convert.ToDecimal(Txt_PricePayment.Text), "active");
                            int ID = int.Parse(dt.Rows[0][0].ToString());

                            txt_IdTicket.Text = ID.ToString();
                            //txt_IdTicket.Text = t.LastIdTicket().Rows[0][0].ToString();
                            if (Convert.ToDecimal(txt_pay.Text) > 0)
                            {
                                s.add_insertStock(Convert.ToInt32(cmb_Stock.SelectedValue), Convert.ToDecimal(txt_pay.Text), dtb_visit.Value,
                                                  txt_username.Text, "فاتورة حجز اشعة رقم " + (txt_IdTicket.Text) + " " + "للعميل" + " " +Cmb_customer.Text);
                            }
                            t.AddTickestDiscount(Convert.ToInt32(txt_IdTicket.Text), Convert.ToDecimal(txt_discount.Text));
                            for (int i = 0; i < dgv_order.Rows.Count; i++)
                            {
                                t.AddTicketDetails(Convert.ToInt32(txt_IdTicket.Text), Convert.ToInt32(dgv_order.Rows[i].Cells[0].Value),
                                    Convert.ToDecimal(dgv_order.Rows[i].Cells[2].Value));
                            }
                     

                            dt.Clear();
                            dt = c.Select_CustomertotalBAlance(Convert.ToInt32(Cmb_customer.SelectedValue));
                            decimal mno2 = Convert.ToDecimal(dt.Rows[0][0]) + Convert.ToDecimal(txt_rent.Text);
                            c.Update_CustomerTotalBalance(Convert.ToInt32(Cmb_customer.SelectedValue), mno2);
                            c.Add_CustomerAccountStatment(Convert.ToInt32(Cmb_customer.SelectedValue), Convert.ToDecimal(txt_pay.Text),
                                Convert.ToDecimal(Txt_PricePayment.Text)
                                 , dtb_visit.Value, mno2, Convert.ToInt32(cmb_Stock.SelectedValue)
                                 , txt_username.Text, Convert.ToInt32(cmb_UserBranch.SelectedValue), "حجز أشعة ورقم الحجز" + " " + (txt_IdTicket.Text));


                            //////////////////

                            dt.Clear();
                            dt = cm.Select_CompanyTotalMoney(Convert.ToInt32(cmb_Company.SelectedValue));
                            decimal mno = Convert.ToDecimal(dt.Rows[0][0]) + Convert.ToDecimal(Txt_rentCompany.Text);
                            cm.Update_CompanyTotalMoney(Convert.ToInt32(cmb_Company.SelectedValue), mno);
                            cm.ADD_Company_TotalRent(Convert.ToInt32(cmb_Company.SelectedValue), 0, Convert.ToDecimal(Txt_rentCompany.Text)
                                 , dtb_visit.Value, mno, "حجز أشعة ورقم الحجز   " + " " +( txt_IdTicket.Text) +" "+ "إلى" +" "+ Cmb_customer.Text , Convert.ToInt32(cmb_Stock.SelectedValue)
                                 , Convert.ToInt32(cmb_UserBranch.SelectedValue), txt_username.Text);

                            //for (int i = 0; i < dgv_order.Rows.Count; i++)
                            //{
                             
                            //        t.addticketsReturn(Convert.ToInt32(txt_IdTicket.Text), Convert.ToInt32(cmb_Stock.SelectedValue), cmb_UserBranch.Text,
                            //            Cmb_customer.Text, cmb_statues.Text, dgv_order.Rows[i].Cells[1].Value.ToString(), dtb_visit.Value
                            //            , 0, ".", Convert.ToDecimal(dgv_order.Rows[i].Cells[2].Value),
                            //              Convert.ToDecimal(txt_pay.Text), txt_username.Text,
                            //              Convert.ToInt32(dgv_order.Rows[i].Cells[0].Value), Convert.ToInt32(cmb_UserBranch.SelectedValue));
                              
                               

                            //    t.Add_Revenue(Convert.ToInt32(cmb_UserBranch.SelectedValue), Convert.ToInt32(txt_IdTicket.Text),
                            //        Convert.ToInt32(dgv_order.Rows[i].Cells[0].Value), Convert.ToDecimal(dgv_order.Rows[i].Cells[2].Value)
                            //        , 0, Convert.ToDecimal(txt_pay.Text), Convert.ToDecimal(txt_rent.Text), dtb_visit.Value);
                            //}



                            MessageBox.Show("تم حفظ الفاتورة بنجاح");                      
                        }
                      
                        

                        t.AddTicketCompany(Convert.ToInt32(txt_IdTicket.Text), Convert.ToInt32(cmb_Company.SelectedValue), Convert.ToDecimal(Txt_rentCompany.Text));
                        
                        
                        //////////
                      
                      
                        /////////////  print Teckiet

                        //DataTable dt1 = new DataTable();
                        //dt1.Clear();
                        //dt1 = t.ReportInvoiceTicketCompany(Convert.ToInt32(txt_IdTicket.Text));
                        //frm_SingelReport sr = new frm_SingelReport();

                        //RPT.Order.Rpt_TeckietCompanyOrder oc = new RPT.Order.Rpt_TeckietCompanyOrder();
                        //RPT.Order.DataSetOrderCompany dso1 = new RPT.Order.DataSetOrderCompany();
                        
                        //dso1.Tables["dataCompany"].Clear();
                        //for (int i = 0; i < dt1.Rows.Count; i++)
                        //{
                          

                        //    dso1.Tables["dataCompany"].Rows.Add(dt1.Rows[i][0], dt1.Rows[i][1], dt1.Rows[i][2],
                        //       dt1.Rows[i][3], dt1.Rows[i][4], dt1.Rows[i][5], dt1.Rows[i][6], dt1.Rows[i][7],
                        //       dt1.Rows[i][8], dt1.Rows[i][9], dt1.Rows[i][10], dt1.Rows[i][11], dt1.Rows[i][12], dt1.Rows[i][13],
                        //       dt1.Rows[i][14],dt1.Rows[i][15], dt1.Rows[i][16],
                        //       dt1.Rows[i][17], dt1.Rows[i][18], dt1.Rows[i][19], dt1.Rows[i][20], dt1.Rows[i][21],dt1.Rows[i][22],
                        //       dt1.Rows[i][23], dt1.Rows[i][24], dt1.Rows[i][25], dt1.Rows[i][26],
                        //       dt1.Rows[i][27], dt1.Rows[i][28], dt1.Rows[i][29],
                        //       dt1.Rows[i][30], dt1.Rows[i][31], dt1.Rows[i][32]);

                        //}
                        //sr.documentViewer1.Refresh();
                        //oc.DataSource = dso1;
                        //oc.Parameters["idTicket"].Value = Convert.ToInt32(txt_IdTicket.Text);                    
                        
                        //sr.documentViewer1.DocumentSource = oc;
                        //oc.Parameters["idTicket"].Visible = false;
                        //sr.documentViewer1.Enabled = true;
                        //sr.ShowDialog();
                      
                    
                    }



                    /////////////////

                    /////////////////
                   

         
                    cmb_statues.Enabled = false;
                    cmb_items.Enabled = false;
                    Cmb_category.Enabled = false;
                    Cmb_customer.Enabled = false;
                    cmb_Doctor.Enabled = false;
                    cmb_DoctorOfCenter.Enabled = false;
                    cmb_Techincal.Enabled = false;
                    cmb_branches.Enabled = false;
                    cmb_Stock.Enabled = false;
                    cmb_UserBranch.Enabled = false;
                
                    
                  
                }

                else
                {
                    MessageBox.Show("لا بد من إختيار فحص أولا أو إستكمال بيانات الفحص بشكل صحيح");
                   
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
              
               // Btn_Save.Enabled = true;
            }
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            try
            {

            if (txt_IdTicket.Text!="")
            {
                DataSet1 ds1 = new DataSet1();
                    //  DataTable dt = new DataTable();
                    //dt.Clear();
                    //dt = t.PrintBarcode(Convert.ToInt32(txt_IdTicket.Text));
                    //RPT.RPT_Barcode rb = new RPT.RPT_Barcode();

                    //sr.documentViewer1.Refresh();

                    //ds1.Tables["DataTable1"].Clear();
                    //for (int i = 0; i < dt.Rows.Count; i++)
                    //{
                    //    ds1.Tables["DataTable1"].Rows.Add(Convert.ToInt32(dt.Rows[i][0]), dt.Rows[i][1], dt.Rows[i][2],
                    //        dt.Rows[i][3], Convert.ToDateTime(dt.Rows[i][4]));
                    //}
                    //rb.DataSource = ds1;
                    //rb.Parameters["idTicket"].Value = Convert.ToInt32(txt_IdTicket.Text);

                    ////sr.documentViewer1.DocumentSource = rb;
                    //rb.Parameters["idTicket"].Visible = false;


                    //string printerName = Properties.Settings.Default.PrintNameBarcode;




                    ////Specify the printer name.
                    //rb.PrinterName = printerName;

                    ////Create the document.
                    //rb.CreateDocument();

                    //ReportPrintTool pt = new ReportPrintTool(rb);
                    //pt.Print();


                    //sr.ShowDialog();

                    frm_SingelReport sr = new frm_SingelReport();

                    RPT.Order.CrystalReport2 cr = new RPT.Order.CrystalReport2();

                DataTable dt = new DataTable();
                dt.Clear();
                dt = t.PrintBarcode(Convert.ToInt32(txt_IdTicket.Text));

                sr.documentViewer1.Refresh();

                ds1.Tables["DataTable1"].Clear();
                ds1.Tables["DataTable1"].Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ds1.Tables["DataTable1"].Rows.Add(Convert.ToInt32(dt.Rows[i][0]), dt.Rows[i][1], dt.Rows[i][2],
                         dt.Rows[i][3], Convert.ToDateTime(dt.Rows[i][4]));
                }
                cr.SetDataSource(ds1);

                sr.documentViewer1.DocumentSource = cr;
                sr.documentViewer1.Refresh();
                System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                cr.PrintOptions.PrinterName = Properties.Settings.Default.PrintNameBarcode;
                cr.PrintToPrinter(1, true, 0, 0);
                sr.Close();
                cr.Dispose();


                clear();
                Customer();

                cmb_statues.Enabled = true;
                cmb_items.Enabled = true;
                Cmb_category.Enabled = true;
                Cmb_customer.Enabled = true;
                cmb_Doctor.Enabled = true;
                cmb_DoctorOfCenter.Enabled = true;
                cmb_Techincal.Enabled = true;
                cmb_branches.Enabled = true;
                cmb_Stock.Enabled = true;
                cmb_UserBranch.Enabled = true;
            }
            else
            {
                MessageBox.Show("لا بد من وجود فاتورة لطباعة الباركود ");
                return;
            }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
               
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                Frm_DetailsCompay frmdc = new Frm_DetailsCompay();
                if (cmb_Company.Text != string.Empty)
                {
                    dt.Clear();
                    dt = cm.Select_DetailsCompany(Convert.ToInt32(cmb_Company.SelectedValue));
                    frmdc.txt_prise.Text = dt.Rows[0][0].ToString();
                    frmdc.ShowDialog();

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

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            Frm_Doctor fd = new Frm_Doctor();
            fd.ShowDialog();
            doctor();

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Frm_Techincal ft = new Frm_Techincal();
            ft.ShowDialog();
            Techincal();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Frm_DoctorOfCenter dc = new Frm_DoctorOfCenter();
            dc.ShowDialog();
            DoctorOfCenter();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_order.Rows.Count > 0)
                {
                    MessageBox.Show("لايمكن عمل اكثر من فحص في نفس الفاتورة", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (cmb_statues.Text == "")
                {
                    MessageBox.Show("من فضلك قم بتحديد طريقة التعامل للفاتورة");
                    cmb_statues.Focus();

                    return;
                }
                for (int i = 0; i < dgv_order.Rows.Count; i++)
                {


                    if (Convert.ToInt32(cmb_items.SelectedValue) == Convert.ToInt32(dgv_order.Rows[i].Cells[0].Value))
                    {
                        Console.Beep();
                        MessageBox.Show("هذا الاشعة مسجلة من قبل ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return;
                    }
                }
                if (Cmb_category.Text == "")
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
                    if (cmb_statues.Text == "نقدى")
                    {
                        decimal x1;
                        dt.Clear();
                        dt = ix.SelectPriseItem(Convert.ToInt32(cmb_items.SelectedValue));
                        x1 = Convert.ToDecimal(dt.Rows[0][0].ToString());
                        DataRow r = dt2.NewRow();
                        r[0] = cmb_items.SelectedValue;
                        r[1] = cmb_items.Text;
                        r[2] = x1;
                        r[3] = 0;

                        dt2.Rows.Add(r);
                        Console.Beep();
                        dgv_order.DataSource = dt2;
                        dgv_order.Columns[3].Visible = false;
                        totalOrder();
                        if (rdb_Discount.Checked == true)
                        {
                            Discount();
                        }
                        else
                        {
                            DiscountMoney();
                        }
                        //Patient_PaymentRate();
                        //Rent_Company();
                        pay();

                    }

                    else if (cmb_statues.Text == "شركات")
                    {
                        DataTable dt12 = new DataTable();

                        DataRow r = dt2.NewRow();
                        if (rdb_discountPatient.Checked == true)
                        {
                            Txt_addtionPayment.Enabled = true;
                            Txt_PricePayment.Enabled = false;
                        }
                        else
                        {
                            Txt_addtionPayment.Enabled = false;
                            Txt_PricePayment.Enabled = true;
                        }
                        dt12 = t.VildateXrayCompany(Convert.ToInt32(cmb_items.SelectedValue), Convert.ToInt32(cmb_Company.SelectedValue));
                        if (dt12.Rows.Count > 0)
                        {
                            dt.Clear();
                            dt = cm.Select_PriceXrayCompany(Convert.ToInt32(cmb_Company.SelectedValue), Convert.ToInt32(cmb_items.SelectedValue));
                            decimal y;
                            decimal x;
                            x = Convert.ToDecimal(dt.Rows[0][0].ToString());
                            y = Convert.ToDecimal(dt.Rows[0][1].ToString());
                            r[0] = cmb_items.SelectedValue;
                            r[1] = cmb_items.Text;
                            r[2] = x;
                            r[3] = y;
                        }

                        else if (dt12.Rows.Count == 0)
                        {
                            decimal x1;
                            dt.Clear();
                            dt = ix.SelectPriseItem(Convert.ToInt32(cmb_items.SelectedValue));
                            x1 = Convert.ToDecimal(dt.Rows[0][0].ToString());
                            r[0] = cmb_items.SelectedValue;
                            r[1] = cmb_items.Text;
                            r[2] = x1;
                            r[3] = 0;
                        }
                        dt2.Rows.Add(r);
                        Console.Beep();
                        dgv_order.DataSource = dt2;
                        dgv_order.Columns[3].Visible = true;
                        totalOrder();
                        if (rdb_Discount.Checked == true)
                        {
                            Discount();
                        }
                        else
                        {
                            DiscountMoney();
                        }
                        Patient_PaymentRate();
                        Rent_Company();
                        pay();
                     

                    }


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void cmb_UserBranch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cmb_items_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_UserBranch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmb_Stock.DataSource = s.SelectStockBranch(Convert.ToInt32(cmb_UserBranch.SelectedValue));
            cmb_Stock.DisplayMember = "Name_Stock";
            cmb_Stock.ValueMember = "ID_Stock";
        }

        private void txt_discount_MouseLeave(object sender, EventArgs e)
        {
            if (txt_discount.Text == "")
            {
                txt_discount.Text = "0";
            }
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
        }

        private void Txt_PricePayment_TextChanged(object sender, EventArgs e)
        {
            if (Txt_addtionPayment.Text == ".")
            {
                Txt_addtionPayment.Text = "";
            }


        }

        private void txt_age_MouseMove(object sender, MouseEventArgs e)
        {
            if (txt_age.Text=="")
            {
                txt_age.Text = "0";
            }
        }

        private void txt_age_TextChanged(object sender, EventArgs e)
        {
            if (txt_age.Text=="")
            {
                txt_age.Text = "0";
            }
        }

        private void txt_age_Click(object sender, EventArgs e)
        {
            txt_age.SelectAll();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dtb_visit.Value = Convert.ToDateTime(DateTime.Now.ToLongTimeString());
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdb_MoneyPatient.Checked == true)
            {
                Txt_addtionPayment.Enabled = false;                
                Txt_PricePayment.Enabled = true;
            }
            else
            {
                Txt_addtionPayment.Enabled = true;
                Txt_PricePayment.Enabled = false;
            }
            Txt_addtionPayment.Text = "0";
            Txt_PricePayment.Text = "0";
            Patient_PaymentRateMony();
            Rent_Company();
            pay();

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdb_discountPatient.Checked==true)
            {
                Txt_addtionPayment.Enabled = true;
          
                Txt_PricePayment.Enabled = false;
            }
            else
            {
                Txt_addtionPayment.Enabled = false;
                Txt_PricePayment.Enabled = true;
            }
            Txt_PricePayment.Text = "0";
            Txt_addtionPayment.Text = "0";
            Patient_PaymentRate();
            Rent_Company();
            pay();


        }

        private void txt_afterDiscount_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_PricePayment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && Txt_PricePayment.Text.ToString().IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar((System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)))
            {
                e.Handled = true;
            }
        }

        private void Txt_PricePayment_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                if (Txt_PricePayment.Text == "")
                {
                    Txt_PricePayment.Text = "0";
                }
                if (Convert.ToDecimal(Txt_PricePayment.Text) > 0 || Txt_PricePayment.Text != "")
                {
                    txt_pay.Enabled = true;
                }
                else
                {
                    txt_pay.Enabled = false;
                }
                if (rdb_discountPatient.Checked == true)
                {
                    Patient_PaymentRate();
                    Rent_Company();
                    pay();
                }
                else if (rdb_MoneyPatient.Checked == true)
                {
                    //Patient_PaymentRateMony();
                    Rent_Company();
                    pay();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Txt_PricePayment_Click(object sender, EventArgs e)
        {
            Txt_PricePayment.Text = "";
        }

        private void groupBox4_Enter_1(object sender, EventArgs e)
        {

        }

        private void cmb_items_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void simpleButton5_Click_1(object sender, EventArgs e)
        {
            try
            {

                if (txt_IdTicket.Text != "")
                {

                    if (cmb_statues.Text == "نقدى")
                    {
                        ////////////
                        DataTable dt1 = new DataTable();
                        dt1.Clear();
                        dt1 = t.ReportInvoiceTicketPay(Convert.ToInt32(txt_IdTicket.Text));
                        frm_SingelReport sr = new frm_SingelReport();

                        Rpt_OrderPay report = new Rpt_OrderPay();
                        RPT.Order.DataSetOrderPay dso = new RPT.Order.DataSetOrderPay();
                        sr.documentViewer1.Refresh();
                        dso.Tables["DataTable1"].Clear();
                        for (int i = 0; i < dt1.Rows.Count; i++)
                        {



                            dso.Tables["DataTable1"].Rows.Add(dt1.Rows[i][0], dt1.Rows[i][1], dt1.Rows[i][2],
                               dt1.Rows[i][3], dt1.Rows[i][4], dt1.Rows[i][5], dt1.Rows[i][6],
                               dt1.Rows[i][7], dt1.Rows[i][8], dt1.Rows[i][9], dt1.Rows[i][10],
                               dt1.Rows[i][11], dt1.Rows[i][12], dt1.Rows[i][13], dt1.Rows[i][14],
                               dt1.Rows[i][15], dt1.Rows[i][16], dt1.Rows[i][17], dt1.Rows[i][18],
                               dt1.Rows[i][19], dt1.Rows[i][20], dt1.Rows[i][21],
                               dt1.Rows[i][22], dt1.Rows[i][23], dt1.Rows[i][24], dt1.Rows[i][25],
                               dt1.Rows[i][26], dt1.Rows[i][27], dt1.Rows[i][28], dt1.Rows[i][29]);
                        }
                        report.DataSource = dso;
                        report.Parameters["idTicket"].Value = Convert.ToInt32(txt_IdTicket.Text);
                        sr.documentViewer1.DocumentSource = report;
                        report.Parameters["idTicket"].Visible = false;
                        sr.documentViewer1.Enabled = true;
                        sr.ShowDialog();
                    }

                    else if (cmb_statues.Text == "شركات")
                    {

                        DataTable dt1 = new DataTable();
                        dt1.Clear();
                        dt1 = t.ReportInvoiceTicketCompany(Convert.ToInt32(txt_IdTicket.Text));
                        frm_SingelReport sr = new frm_SingelReport();

                        RPT.Order.Rpt_TeckietCompanyOrder oc = new RPT.Order.Rpt_TeckietCompanyOrder();
                        RPT.Order.DataSetOrderCompany dso1 = new RPT.Order.DataSetOrderCompany();

                        dso1.Tables["dataCompany"].Clear();
                        for (int i = 0; i < dt1.Rows.Count; i++)
                        {


                            dso1.Tables["dataCompany"].Rows.Add(dt1.Rows[i][0], dt1.Rows[i][1], dt1.Rows[i][2],
                               dt1.Rows[i][3], dt1.Rows[i][4], dt1.Rows[i][5], dt1.Rows[i][6], dt1.Rows[i][7],
                               dt1.Rows[i][8], dt1.Rows[i][9], dt1.Rows[i][10], dt1.Rows[i][11], dt1.Rows[i][12], dt1.Rows[i][13],
                               dt1.Rows[i][14], dt1.Rows[i][15], dt1.Rows[i][16],
                               dt1.Rows[i][17], dt1.Rows[i][18], dt1.Rows[i][19], dt1.Rows[i][20], dt1.Rows[i][21], dt1.Rows[i][22],
                               dt1.Rows[i][23], dt1.Rows[i][24], dt1.Rows[i][25], dt1.Rows[i][26],
                               dt1.Rows[i][27], dt1.Rows[i][28], dt1.Rows[i][29],
                               dt1.Rows[i][30], dt1.Rows[i][31], dt1.Rows[i][32]);

                        }
                        sr.documentViewer1.Refresh();
                        oc.DataSource = dso1;
                        oc.Parameters["idTicket"].Value = Convert.ToInt32(txt_IdTicket.Text);

                        sr.documentViewer1.DocumentSource = oc;
                        oc.Parameters["idTicket"].Visible = false;
                        sr.documentViewer1.Enabled = true;
                        sr.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        //private void ؤ(object sender, EventArgs e)
        //{

        //}
    }
    }

