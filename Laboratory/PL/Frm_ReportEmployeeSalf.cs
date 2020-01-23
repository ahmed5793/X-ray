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
    public partial class Frm_ReportEmployeeSalf : Form
    {
        Employee E = new Employee();
        public Frm_ReportEmployeeSalf()
        {
            InitializeComponent();
          
          
        }

        private void Frm_ReportEmployeeSalf_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = E.ReportEmployeeSumSalf();
            decimal total = 0;
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                total += Convert.ToDecimal(dataGridView1.Rows[i].Cells[1].Value);

            }
            txt_totalpay.Text = Math.Round(total, 1).ToString();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                dataGridView1.DataSource = E.ReportEmployeeSumSalf();
                decimal total = 0;
                for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
                {
                    total += Convert.ToDecimal(dataGridView1.Rows[i].Cells[1].Value);

                }
                txt_totalpay.Text = Math.Round(total, 2).ToString();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                dataGridView1.DataSource = E.ReportEmployeeSalf();
                decimal total = 0;
                for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
                {
                    total += Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value);

                }
                txt_totalpay.Text = Math.Round(total, 2).ToString();
            }
        }
    }
}
