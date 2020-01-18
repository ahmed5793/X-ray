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
    public partial class Frm_ManagmentTicketsReturn : Form
    {

        Tickets t = new Tickets();
        public Frm_ManagmentTicketsReturn()
        {
            InitializeComponent();
        }

        private void Frm_ManagmentTicketsReturn_Load(object sender, EventArgs e)
        {
            FromDate.Hide();
            ToDate.Hide();
            label2.Hide();
            label3.Hide();
            button1.Hide();
            dgv_visit.DataSource = t.selectTicketsReturn();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = t.SelectSearchticketsDate(FromDate.Value, ToDate.Value);
            dgv_visit.DataSource = dt;
            decimal totall = 0;
            for (int i = 0; i <= dgv_visit.Rows.Count - 1; i++)
            {
                totall += Convert.ToDecimal(dgv_visit.Rows[i].Cells[7].Value);

            }
            textBox1.Text = Math.Round(totall, 2).ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            FromDate.Hide();
            ToDate.Hide();
            label2.Hide();
            label3.Hide();
            button1.Hide();
            dgv_visit.DataSource = t.selectTicketsReturn();
            decimal totall = 0;
            for (int i = 0; i <= dgv_visit.Rows.Count - 1; i++)
            {
                totall += Convert.ToDecimal(dgv_visit.Rows[i].Cells[7].Value);

            }
            textBox1.Text = Math.Round(totall, 2).ToString();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dgv_visit.DataSource = null;
            FromDate.Show();
            ToDate.Show();
            label2.Show();
            label3.Show();
            button1.Show();
        }
    }
}
