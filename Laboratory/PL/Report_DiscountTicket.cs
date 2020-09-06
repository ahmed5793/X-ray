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
namespace Laboratory.BL
{
    public partial class Report_DiscountTicket : Form
    {
        Branches b = new Branches();
        Tickets t = new Tickets();
        public Report_DiscountTicket()
        {
            InitializeComponent();
            branch();
        }
        void branch()
        {
            try
            {
                cmb_Branch.DataSource = b.SelectCompBranches();
                cmb_Branch.DisplayMember = "Name";
                cmb_Branch.ValueMember = "Branch_ID";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void Report_DiscountTicket_Load(object sender, EventArgs e)
        {

        }
        void Calc_AmountPull()
        {
            decimal total = 0;
            for (int i = 0; i < gridView1.DataRowCount; i++)
            {
                DataRow row = gridView1.GetDataRow(i);
                total += Convert.ToDecimal(row[7].ToString());

            }
            textBox2.Text = total.ToString("₱ #,#0.0");

        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
               gridControl1.DataSource= t.SelectDiscountTicketsBranch(cmb_Branch.Text,Convert.ToDateTime(DateFrom.Text),Convert.ToDateTime(DateTo.Text));
                Calc_AmountPull();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
