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
        public Frm_Mansgmentinstallment()
        {
            InitializeComponent();
            dgv_visit.DataSource = i.Selectinstallment();
        }

        private void Frm_Mansgmentinstallment_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Clear();
            dt = i.SelectFromDateinstallment(FromDate.Value, ToDate.Value);
            dgv_visit.DataSource = dt;
        }
    }
}
