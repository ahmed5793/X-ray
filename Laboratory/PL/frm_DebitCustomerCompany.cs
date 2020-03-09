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
    public partial class frm_DebitCustomerCompany : Form
    {
        Customer C = new Customer();
        public frm_DebitCustomerCompany()
        {
            InitializeComponent();
            dataGridViewList.DataSource = C.selectClientRentComopany();
            Calc();
        }
        void Calc()
        {
            decimal total = 0;
            for (int i = 0; i <= dataGridViewList.Rows.Count - 1; i++)
            {
                total += Convert.ToDecimal(dataGridViewList.Rows[i].Cells[2].Value);

            }
            txt_TotalPurshacing.Text = Math.Round(total, 1).ToString();
        }
        private void frm_DebitCustomerCompany_Load(object sender, EventArgs e)
        {

        }
    }
}
