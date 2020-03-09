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
        DataTable dt = new DataTable();

        public Frm_ManagmentTicketsReturn()
        {
            InitializeComponent();
        }
        void calc()
        {
            decimal totall = 0;
            for (int i = 0; i <= gridView1.RowCount - 1; i++)
            {
                DataRow row = gridView1.GetDataRow(i);
                totall += Convert.ToDecimal(row[7]);

            }
            textBox1.Text = Math.Round(totall, 2).ToString();
        }

        private void Frm_ManagmentTicketsReturn_Load(object sender, EventArgs e)
        {
            FromDate.Hide();
            ToDate.Hide();
            label2.Hide();
            label3.Hide();
            Btn_Search.Hide();
            gridControl1.DataSource = t.selectTicketsReturn();
            calc();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            FromDate.Hide();
            ToDate.Hide();
            label2.Hide();
            label3.Hide();
            Btn_Search.Hide();
            gridControl1.DataSource = t.selectTicketsReturn();
            calc();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gridControl1.DataSource = null;
            FromDate.Show();
            ToDate.Show();
            label2.Show();
            label3.Show();
            Btn_Search.Show();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dt = t.SelectSearchticketsDate(FromDate.Value, ToDate.Value);
            gridControl1.DataSource = dt;
            calc();
        }
    }
}
