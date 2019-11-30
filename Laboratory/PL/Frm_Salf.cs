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
    public partial class Frm_Salf : Form
    {
        Employee E = new Employee();
        DataTable dt = new DataTable();
        public Frm_Salf()
        {
            InitializeComponent();
            dataGridView1.DataSource = E.SelectEmployeeSalf();
            dataGridView1.Columns[0].Visible = false;
           
            btn_new.Hide();
            btn_save.Show();
            btn_update.Enabled = false;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (cmb_employeeName.Text=="")
            {
                MessageBox.Show("قم بااختيار اسم الموظف");
                return;

            }

            if (txt_NameDaen.Text == "")
            {
                MessageBox.Show("قم بااختيار اسم الداين");
                return;

            }

            if (Txt_money.Text == "")
            {
                MessageBox.Show("من فضلك قم بكتابة المبلغ");
                return;

            }
            else
            {
                E.AddEmployee_Salf(txt_NameDaen.Text, dateTimePicker1.Value, dateTimePicker2.Value, txt_note.Text, Convert.ToDecimal(Txt_money.Text), Convert.ToInt32(cmb_employeeName.SelectedValue));
                MessageBox.Show("تم التسجيل بنجاح");
                E.AddEMPSalaryMins(Convert.ToInt32(cmb_employeeName.SelectedValue), dateTimePicker1.Value,
                  Convert.ToDecimal(Txt_money.Text), "false");
                dataGridView1.DataSource = E.SelectEmployeeSalf();
                txt_note.Clear();
                txt_NameDaen.Clear();
                Txt_money.Clear();

                txt_note.Clear();
                txt_NameDaen.Clear();
                Txt_money.Clear();
                btn_new.Hide();
                btn_save.Show();
                btn_update.Enabled = false;
               
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (cmb_employeeName.Text == "")
            {
                MessageBox.Show("قم بااختيار اسم الموظف");
                return;

            }

            if (txt_NameDaen.Text == "")
            {
                MessageBox.Show("قم بااختيار اسم الداين");
                return;

            }

            if (Txt_money.Text == "")
            {
                MessageBox.Show("من فضلك قم بكتابة المبلغ");
                return;

            }
            else
            {
                E.UpdateEmployee_Salf(txt_NameDaen.Text, dateTimePicker1.Value, dateTimePicker2.Value, txt_note.Text, Convert.ToDecimal(Txt_money.Text), Convert.ToInt32(cmb_employeeName.SelectedValue)
                    ,Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                MessageBox.Show("تم التعديل بنجاح");
                txt_note.Clear();
                txt_NameDaen.Clear();
                Txt_money.Clear();
                btn_new.Hide();
                btn_save.Show();
                btn_update.Enabled = false;


            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            txt_note.Clear();
            txt_NameDaen.Clear();
            Txt_money.Clear();
            btn_new.Hide();
            btn_save.Show();
            btn_update.Enabled = false;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count>0)
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
                cmb_employeeName.Text= dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txt_NameDaen.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                dateTimePicker1.Text= dataGridView1.CurrentRow.Cells[3].Value.ToString();
                Txt_money.Text= dataGridView1.CurrentRow.Cells[4].Value.ToString();
                dateTimePicker2.Text= dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txt_note.Text= dataGridView1.CurrentRow.Cells[6].Value.ToString();
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
           
            dt = E.SearchEmployeeSalf(txt_search.Text);
            dataGridView1.DataSource = dt;
        }

        private void Txt_money_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && Txt_money.Text.ToString().IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar((System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)))
            {
                e.Handled = true;
            }
        }

        private void Frm_Salf_Load(object sender, EventArgs e)
        {
            cmb_employeeName.DataSource = E.SelectCompoEmployee();
            cmb_employeeName.DisplayMember = "Emp_Name";
            cmb_employeeName.ValueMember = "Emp_ID";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
