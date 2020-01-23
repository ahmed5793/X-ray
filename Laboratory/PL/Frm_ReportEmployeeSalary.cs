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
    public partial class Frm_ReportEmployeeSalary : Form
    {
        Employee E = new Employee();
        public Frm_ReportEmployeeSalary()
        {
            InitializeComponent();
            checkBox1.Checked = true;
        }

        private void Frm_ReportEmployeeSalary_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = E.SelectCompoEmployee();
            comboBox1.DisplayMember = "Emp_Name";
            comboBox1.ValueMember = "Emp_ID";
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                dataGridView1.DataSource = E.RrportEmployeeSalary(Convert.ToInt32(comboBox1.SelectedValue),dateTimePicker1.Text,dateTimePicker2.Text);
            }
            else
            {
                dataGridView1.DataSource = E.RrportEmployeeSalaryDate( dateTimePicker1.Text, dateTimePicker2.Text);

            }
            decimal total = 0;
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                total += Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);

            }
            textBox1.Text = Math.Round(total, 1).ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                comboBox1.Enabled = true;

                comboBox1.DataSource = E.SelectCompoEmployee();
                comboBox1.DisplayMember = "Emp_Name";
                comboBox1.ValueMember = "Emp_ID";
            }
            else
            {
                comboBox1.Enabled = false;

                comboBox1.DataSource = null;
                dataGridView1.DataSource = null;
            }
        }
    }
}
