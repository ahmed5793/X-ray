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
    public partial class Frm_PayCompanyMoney : Form
    {
        Users u = new Users();
        Company c = new Company();
        Stock s = new Stock();
        Branches b = new Branches();
        DataTable dt = new DataTable();
        //DataTable dt = new DataTable();

        public Frm_PayCompanyMoney()
        {
            InitializeComponent();
            Function();
        }
        void Function()
        {
            try
            {
                txt_prise.Enabled = false;
                Txt_SalesMAn.Text = Program.salesman;
                Permision();
                Select_Company();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        void Select_Company()
        {
            cmb_company.DataSource = c.SelectAllCompanyMoney();
            cmb_company.DisplayMember = "Comp_Name";
            cmb_company.ValueMember = "ID_Company";
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
        //void Calc()
        //{
        //    decimal total = 0;
        //    for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
        //    {
        //        total += Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value);
        //    }
        //    txt_rent.Text = Math.Round(total,1).ToString();
        //}
        void Stock()
        {
            cmb_Stock.DataSource = s.Compo_Stock();
            cmb_Stock.DisplayMember = "Name_Stock";
            cmb_Stock.ValueMember = "ID_Stock";
        }

        private void RdbOneCustomer_CheckedChanged(object sender, EventArgs e)
        {
           

        }

        private void cmb_company_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void RdbAllPay_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbAllPay.Checked==true)
            {
                txt_prise.Enabled = false;
                txt_prise.Text = "0";
            }
        }

        private void rdbPartPay_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPartPay.Checked==true)
            {
                txt_prise.Enabled = true;
            }
        }

        private void btn_client_Click(object sender, EventArgs e)
        {
           
        }

        private void RdbAllCustomer_CheckedChanged(object sender, EventArgs e)
        {
          
            //dataGridView1.DataSource = c.SelectAllCompanyMoney();
        }

        private void txt_prise_Click(object sender, EventArgs e)
        {
            txt_prise.Text = "";
        }

        private void txt_prise_MouseMove(object sender, MouseEventArgs e)
        {
            if (txt_prise.Text=="")
            {
                txt_prise.Text = "0";
            }
        }
        private void cmb_company_Leave(object sender, EventArgs e)
        {
            try
            {
                if (cmb_company.Text != "")
                {
                    dt.Clear();
                    dt = c.Validate_CompanyNAme(Convert.ToInt32(cmb_company.SelectedValue));
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("إسم الشركة غير موجود لا بد من إختيار إسم الشركة من القائمة");
                        cmb_company.Focus();
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

        private void Cmb_Branch_SelectionChangeCommitted(object sender, EventArgs e)
        {

            cmb_Stock.DataSource = s.SelectStockBranch(Convert.ToInt32(Cmb_Branch.SelectedValue));
            cmb_Stock.DisplayMember = "Name_Stock";
            cmb_Stock.ValueMember = "ID_Stock";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Cmb_Branch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_company.Text!="")
                {
                    dataGridView1.DataSource = c.SelectOneCompanyMoney(Convert.ToInt32(cmb_company.SelectedValue));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                decimal x = 0;
                //decimal total = 0;
                if (dataGridView1.Rows.Count >= 1)
                    if (RdbAllPay.Checked == true)
                    {
                        if (MessageBox.Show("هل تريد دفع المبلغ بالكامل", "عمليه الدفع", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            dt.Clear();
                            dt = c.Select_CompanyTotalMoney(Convert.ToInt32(cmb_company.SelectedValue));
                            decimal mno = Convert.ToDecimal(dt.Rows[0][0]) - Convert.ToDecimal(dataGridView1.CurrentRow.Cells[2].Value);
                            c.Update_CompanyTotalMoney(Convert.ToInt32(cmb_company.SelectedValue), mno);
                            c.ADD_Company_TotalRent(Convert.ToInt32(cmb_company.SelectedValue), Convert.ToDecimal(dataGridView1.CurrentRow.Cells[2].Value)
                                , x, dateTimePicker1.Value, mno, "تسديد كل حساب الشركة القديم", Convert.ToInt32(cmb_Stock.SelectedValue)
                             , Convert.ToInt32(Cmb_Branch.SelectedValue), Txt_SalesMAn.Text);
                            s.add_insertStock(Convert.ToInt32(cmb_Stock.SelectedValue), Convert.ToDecimal(dataGridView1.CurrentRow.Cells[2].Value),
                                               dateTimePicker1.Value, Txt_SalesMAn.Text, "مدفوعات مديونية شركات من الشركة " + " " + cmb_company.Text);
                            MessageBox.Show("تم دفع المبلغ بنجاح");
                            dataGridView1.DataSource = c.SelectOneCompanyMoney(Convert.ToInt32(cmb_company.SelectedValue));
                        }
                        else
                        {
                            MessageBox.Show("تم   الغاء العمليه بنجاح");
                            return;
                        }
                    }
                    else if (rdbPartPay.Checked == true)
                    {
                        decimal z = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value) - Convert.ToDecimal(txt_prise.Text);

                        if (MessageBox.Show("هل تريد جزء من المبلغ ", "عمليه الدفع", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            if (Convert.ToDecimal(txt_prise.Text) > Convert.ToDecimal(dataGridView1.CurrentRow.Cells[2].Value))
                            {
                                MessageBox.Show("المبلغ المدفوع اكبر من المبلغ الموجود حاليا على الشركة  ", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txt_prise.Focus();
                                return;
                            }
                            dt.Clear();
                            dt = c.Select_CompanyTotalMoney(Convert.ToInt32(cmb_company.SelectedValue));
                            decimal mno = Convert.ToDecimal(dt.Rows[0][0]) - Convert.ToDecimal(txt_prise.Text);
                            c.Update_CompanyTotalMoney(Convert.ToInt32(cmb_company.SelectedValue), mno);
                            c.ADD_Company_TotalRent(Convert.ToInt32(cmb_company.SelectedValue), Convert.ToDecimal(dataGridView1.CurrentRow.Cells[2].Value)
                                , x, dateTimePicker1.Value, mno, "تسديد جزء من حساب الشركة القديم", Convert.ToInt32(cmb_Stock.SelectedValue)
                             , Convert.ToInt32(Cmb_Branch.SelectedValue), Txt_SalesMAn.Text);
                            s.add_insertStock(Convert.ToInt32(cmb_Stock.SelectedValue), Convert.ToDecimal(txt_prise.Text),
                                               dateTimePicker1.Value, Txt_SalesMAn.Text, "مدفوعات مديونية شركات من الشركة " + " " + cmb_company.Text);
                            MessageBox.Show("تم دفع المبلغ بنجاح");
                            dataGridView1.DataSource = c.SelectOneCompanyMoney(Convert.ToInt32(cmb_company.SelectedValue));
                        }
                        else
                        {
                            MessageBox.Show("تم   الغاء العمليه بنجاح");
                            return;
                        }
                    }
                txt_prise.Text = "0";
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
                MessageBox.Show(EX.StackTrace);
            }
        }
    }
}
