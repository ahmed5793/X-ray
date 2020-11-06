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
    public partial class Report_PayCustomer : Form
    {
        Stock s = new Stock();
        Customer c = new Customer();
       
        public Report_PayCustomer()
        {
            InitializeComponent();
            Stock();


        }
        void Stock()
        {
            try
            {
                cmb_Stock.DataSource = s.Compo_Stock();
                cmb_Stock.DisplayMember = "Name_Stock";
                cmb_Stock.ValueMember = "ID_Stock";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void Report_PayCustomer_Load(object sender, EventArgs e)
        {

        }
        void Calc_Amount()
        {
            try
          {
                decimal total = 0;
            for (int i = 0; i < gridView1.DataRowCount; i++)
            {
                DataRow row = gridView1.GetDataRow(i);
                total += Convert.ToDecimal(row[2].ToString());

            }

                label3.Text = total.ToString("₱ #,#0.0");
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
                gridControl1.DataSource = c.SelectCustomerPay(Convert.ToInt32(cmb_Stock.SelectedValue), DateFrom.Value, DateTo.Value);
                Calc_Amount();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
