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
    public partial class Frm_DebitSuppliers : Form
    {
        Suppliers Suppliers = new Suppliers();
        public Frm_DebitSuppliers()
        {
            InitializeComponent();
            gridControl1.DataSource = Suppliers.Select_DepitSupplier();
            Calc();
        }
        void Calc()
        {
            decimal total = 0;
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                DataRow r = gridView1.GetDataRow(i);
                total += Convert.ToDecimal(r[2].ToString());
            }
            txt_reb7h.Text = Math.Round(total, 2).ToString();
        }

        private void Frm_DebitSuppliers_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Btn_Print_Click(object sender, EventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }
    }
}
