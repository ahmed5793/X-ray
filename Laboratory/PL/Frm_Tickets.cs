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
       

        public Frm_Tickets()
        {
            InitializeComponent();
            Cmb_customer.Show();
            txt_name.Hide();
            cmb_Company.Enabled = false;

            brnches();
            Stock();
            Customer();
            doctor();
            EmpRole();

            txt_phone.Enabled = false;
            txt_age.Enabled = false;
            txt_address.Enabled = false;

         

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
        void EmpRole()
        {
            cmb_Emprole.DataSource = E.SelectEmpRole();
            cmb_Emprole.DisplayMember = "Roles";
            cmb_Emprole.ValueMember = "ID_EmpRole";
        }


        private void Frm_Tickets_Load(object sender, EventArgs e)
        {
            CategoryXraya();


        }

        private void rdb_Compamy_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_Compamy.Checked == true)
            {
                cmb_Company.Enabled = true;
                company();
            }
        }

        private void rdb_client_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_client.Checked == true)
            {
                cmb_Company.Enabled = false;
                cmb_Company.Items.Clear();
            }
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
            if (e.KeyChar == '.' && txt_price.Text.ToString().IndexOf('.') > -1)
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
            if (e.KeyChar == '.' && text_discount.Text.ToString().IndexOf('.') > -1)
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
            Cmb_employee.DataSource = E.SelectCompoRoleEmployee(Convert.ToInt32(cmb_Emprole.SelectedValue));
            label23.Text = cmb_Emprole.Text;
            Cmb_employee.DisplayMember = "Emp_Name";
            Cmb_employee.ValueMember = "Emp_ID";
            label23.Text = cmb_Emprole.Text;

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cmb_Emprole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
