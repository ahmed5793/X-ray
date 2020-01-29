﻿using System;
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
    public partial class Frm_ReportEmployeeDiscount : Form
    {
        Employee E = new Employee();
        public Frm_ReportEmployeeDiscount()
        {
            InitializeComponent();
            checkBox1.Checked = true;

            comboBox1.DataSource = E.SelectCompoEmployee();
            comboBox1.DisplayMember = "Emp_Name";
            comboBox1.ValueMember = "Emp_ID";
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked == true)
            {
                dataGridView1.DataSource = E.ReportselecEmployeetDiscount(Convert.ToInt32(comboBox1.SelectedValue), DateFrom.Value, DateTo.Value);

            }
            else
            {
                dataGridView1.DataSource = E.ReportselecDateEmployeetDiscount(DateFrom.Value, DateTo.Value);

            }
            decimal total = 0;
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                total += Convert.ToDecimal(dataGridView1.Rows[i].Cells[1].Value);

            }
            txt_totalpay.Text = Math.Round(total, 2).ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
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

        private void Frm_ReportEmployeeDiscount_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (comboBox1.Text != "")
            {
                dt.Clear();
                dt = E.VildateEmployeeShift(Convert.ToInt32(comboBox1.SelectedValue));
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("يرجي العلم بان اسم الموظف غير مسجل من قبل يرجي تسجيل هذا الاسم في شاشه الموظفين", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                    comboBox1.Focus();
                    comboBox1.SelectAll();
                    return;
                }
                dt.Dispose();
            }
        }
    }
}