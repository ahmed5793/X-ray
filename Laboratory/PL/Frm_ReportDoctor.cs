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
    public partial class Frm_ReportDoctor : Form
    {
        Doctors Doctors = new Doctors();
        public Frm_ReportDoctor()
        {
            InitializeComponent();
            comboBox1.DataSource = Doctors.Select_ComboDoctor();
            comboBox1.DisplayMember = "Doc_Name";
            comboBox1.ValueMember = "Doc_ID";
        
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                if (comboBox1.Text != string.Empty)
                {
                    dt.Clear();
                    dt = Doctors.Search_ReportDoctor(Convert.ToInt32(comboBox1.SelectedValue), DateFrom.Value, DateTo.Value);
                    dataGridView1.DataSource = dt;
                    textBox1.Text = dataGridView1.Rows.Count.ToString();

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

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text != String.Empty)
                {
                    dataGridView1.DataSource = Doctors.Select_ReportDoctor(Convert.ToInt32(comboBox1.SelectedValue));
                    textBox1.Text = dataGridView1.Rows.Count.ToString();

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
                dt = Doctors.vildateOutDoctor(Convert.ToInt32(comboBox1.SelectedValue));
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("يرجي العلم بان اسم الطبيب غير مسجل من قبل ", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                    comboBox1.Focus();
                    comboBox1.SelectAll();
                    return;
                }
                dt.Dispose();
            }
        }
    }
}
