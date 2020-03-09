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
    public partial class Frm_AddEmployeeShift : Form
    {
        Employee E = new Employee();
        public Frm_AddEmployeeShift()
        {
            InitializeComponent();
            Btn_DeleteShift.Enabled = false;
            Btn_UpdateShift.Enabled = false;
            dataGridView1.DataSource = E.Select_EmployeeShift();

        }

        private void Btn_UpdateShift_Click(object sender, EventArgs e)
        {
           
        }

        private void Frm_AddEmployeeShift_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = E.selectEmployeeGenderSalary();
            comboBox1.DisplayMember = "Emp_Name";
            comboBox1.ValueMember = "Emp_ID";
            if (comboBox1.Text!="")
            {
                textBox1.Text = E.selectEmployeeRoleshift(Convert.ToInt32(comboBox1.SelectedValue)).Rows[0][0].ToString();

            }

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //comboBox1.DataSource = E.selectEmployeeGenderSalary();
            //comboBox1.DisplayMember = "Emp_Name";
            //comboBox1.ValueMember = "Emp_ID";

            textBox1.Text = E.selectEmployeeRoleshift(Convert.ToInt32(comboBox1.SelectedValue)).Rows[0][0].ToString();
        }

        private void Btn_DeleteShift_Click(object sender, EventArgs e)
        {
        }

        private void Btn_AddShift_Click(object sender, EventArgs e)
        {
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            dt.Clear();
            dt = E.Search_EmployeeShift(txt_search.Text);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count > 0 && dataGridView1.SelectedRows.Count > 0)
                {
                    comboBox1.Enabled = false;
                    Btn_AddShift.Enabled = false;
                    Btn_UpdateShift.Enabled = true;
                    Btn_DeleteShift.Enabled = true;
                    comboBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    textBox1.Text= dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    Txt_Cost.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                    dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[3].Value);
                    dateTimePicker3.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[4].Value);
                    dateTimePicker2.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[5].Value);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
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

        private void Btn_AddShift_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (Txt_Cost.Text == "0" && Txt_Cost.Text == "")
                {
                    MessageBox.Show("يرجى تحديد سعر الشيفت");
                    return;
                }
                if (comboBox1.Text != "")
                {
                    E.Add_EmployeeShift(Convert.ToInt32(comboBox1.SelectedValue),
                       (dateTimePicker1.Text), (dateTimePicker3.Text), (dateTimePicker2.Text), Convert.ToDecimal(Txt_Cost.Text));
                    MessageBox.Show("تم إضافة الشيفت بنجاح");
                    Txt_Cost.Text = "0";
                    dataGridView1.DataSource = E.Select_EmployeeShift();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "")
                {
                    MessageBox.Show("لا بد من تحديد إسم الموظف ");
                    return;
                }


                if (MessageBox.Show("هل تريد تعديل الشيفت", "عملية التعديل", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    E.Update_EmployeeShift(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value), Convert.ToInt32(comboBox1.SelectedValue),
                         (dateTimePicker1.Text), (dateTimePicker3.Text),
                        (dateTimePicker2.Text), Convert.ToDecimal(Txt_Cost.Text));
                    MessageBox.Show("تم تعديل الشيفت بنجاح", "عملية التعديل");
                    Txt_Cost.Text = "0";
                    dataGridView1.DataSource = E.Select_EmployeeShift();
                }
                else
                {
                    MessageBox.Show("تم إلغاء تعديل الشيفت ", "عملية التعديل");
                    Txt_Cost.Text = "0";
                    dataGridView1.DataSource = E.Select_EmployeeShift();
                }
                comboBox1.Enabled = true;
                Btn_AddShift.Enabled = true;
                Btn_UpdateShift.Enabled = false;
                Btn_DeleteShift.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_DeleteShift_Click_1(object sender, EventArgs e)
        {

            try
            {
                if (MessageBox.Show("هل تريد مسح الشيفت", "عملية المسح", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    E.Delete_TechnicalShift(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                    MessageBox.Show("تم مسح الشيفت بنجاح");
                    Txt_Cost.Text = "0";
                    dataGridView1.DataSource = E.Select_EmployeeShift();
                }
                else
                {
                    MessageBox.Show("تم إلغاء مسح الشيفت ");
                    Txt_Cost.Text = "0";
                    dataGridView1.DataSource = E.Select_EmployeeShift();
                }
                comboBox1.Enabled = true;
                Btn_AddShift.Enabled = true;
                Btn_UpdateShift.Enabled = false;
                Btn_DeleteShift.Enabled = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
