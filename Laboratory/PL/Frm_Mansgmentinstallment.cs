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
    public partial class Frm_Mansgmentinstallment : Form
    {
        Installment i = new Installment();
        DataTable dt = new DataTable();
        public Frm_Mansgmentinstallment()
        {
            InitializeComponent();
            gridControl1.DataSource = i.Selectinstallment();
            gridView1.Columns[0].Visible= false;
        }

        private void Frm_Mansgmentinstallment_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            dt.Clear();
            dt = i.SelectFromDateinstallment(DateFrom.Value, DateTo.Value);
            gridControl1.DataSource = dt;
        }
    }
}
