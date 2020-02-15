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
    public partial class Frm_ReportPAyCustomerCompany : Form
    {
        Customer C = new Customer();
        public Frm_ReportPAyCustomerCompany()
        {
            InitializeComponent();
            label7.Hide();
          
            comboBox2.Hide();
          
            btn_search.Hide();
            gridControl1.DataSource = C.Select_AllPayCustomerCompany();
            Calc();
        }
        void Calc()
        {
            decimal total = 0;
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                DataRow row = gridView1.GetDataRow(i);
                total += Convert.ToDecimal(row[3].ToString());

            }
            txt_TotalPurshacing.Text = total.ToString("₱ #,##0.0");
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //DataTable dt = new DataTable();
            //try
            //{
            //    dt.Clear();
            //    dt = C.Search_AllPayCustomerCompany(textBox1.Text);
            //    gridControl1.DataSource = dt;
            //    Calc();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    dt.Dispose();
            //}
        }

        private void Frm_ReportPAyCustomerCompany_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_Leave(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                if (comboBox2.Text != "")
                {
                    dt.Clear();
                    dt = C.validate_CustomerName(Convert.ToInt32(comboBox2.SelectedValue));
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("إسم العميل غير موجود لا بد من إختيار إسم العميل من القائمة");
                        comboBox2.Focus();
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
            label7.Hide();
            label4.Hide();
            label5.Hide();
            comboBox2.Hide();
            DateFrom.Hide();
            DateTo.Hide();
            btn_search.Hide();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
            label7.Hide();
            label4.Show();
            label5.Show();
            comboBox2.Hide();
            DateFrom.Show();
            DateTo.Show();
            btn_search.Show();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            comboBox2.DataSource = C.SelectCompoCustomerCompany();
            comboBox2.DisplayMember = "Cust_Name";
            comboBox2.ValueMember = "Cust_ID";
         
            label7.Show();
            label4.Show();
            label5.Show();
            comboBox2.Show();
            DateFrom.Show();
            DateTo.Show();
            btn_search.Show();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            DataTable dt5 = new DataTable();
            try
            {
                if (radioButton2.Checked == true)
                {
                    dt5.Clear();
                    dt5 = C.Search_AllPayCustomerCompanyDate(DateFrom.Value, DateTo.Value);
                    gridControl1.DataSource = dt5;
                }
                else if (radioButton3.Checked == true)
                {
                    if (comboBox2.Text != "")
                    {
                        dt5.Clear();
                        dt5 = C.Search_AllPayCustomerCompanyDateAndName(comboBox2.Text, DateFrom.Value, DateTo.Value);
                        gridControl1.DataSource = dt5;
                    }
                }
                Calc();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }
    }
}
