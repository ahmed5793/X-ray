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
    public partial class Frm_ReportEmployeeShift : Form
    {
        Employee E = new Employee();
        public Frm_ReportEmployeeShift()
        {
            InitializeComponent();
            comboBox1.DataSource = E.selectEmployeeGenderSalary();
            comboBox1.DisplayMember = "Emp_Name";
            comboBox1.ValueMember = "Emp_ID";

        }

        private void Frm_ReportEmployeeShift_Load(object sender, EventArgs e)
        {

        }
        void Calc()
        {
            decimal total = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                total += Convert.ToDecimal(dataGridView1.Rows[i].Cells[6].Value);
            }
            textBox1.Text = Math.Round(total, 1).ToString();
        }
        void CalcCount()
        {

            label5.Text = dataGridView1.Rows.Count.ToString();
          
          
        }
        DataTable dt = new DataTable();
        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text != string.Empty)
                {
                    dt.Clear();
                    dt = E.Report_EmployeeShift(Convert.ToInt32(comboBox1.SelectedValue), DateFrom.Value, DateTo.Value);
                    dataGridView1.DataSource = dt;
                    textBox1.Text = dataGridView1.Rows.Count.ToString();
                    Calc();
                    CalcCount();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                dt.Dispose();
            }
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
