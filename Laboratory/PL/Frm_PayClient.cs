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
        DataTable dt = new DataTable();
        decimal total = 0;

        public Frm_PayClient()
        {
            InitializeComponent();
            cmb_client.Hide();
            txt_prise.Enabled = false;

            btn_client.Hide();
            rdbPartPay.Hide();
            RdbAllPay.Hide();
            cmb_Stock.DataSource = s.Compo_Stock();
            cmb_Stock.DisplayMember = "Name_Stock";
            cmb_Stock.ValueMember = "ID_Stock";
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                total += Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value);

            }
            txt_rent.Text = Math.Round(total, 2).ToString();

        }

        private void RdbAllCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbAllCustomer.Checked==true)
            {
                dataGridView1.DataSource = c.selectClientRent();
            }
        }
    }
}
