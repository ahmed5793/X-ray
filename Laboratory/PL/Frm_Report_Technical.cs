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
    public partial class Frm_Report_DetailsTechnical : Form
    {
        Techincal Techincal = new Techincal();
        public Frm_Report_DetailsTechnical()
        {
            InitializeComponent();
            comboBox1.DataSource = Techincal.Select_ComboTechnical();
            comboBox1.DisplayMember = "Tech_Name";
            comboBox1.ValueMember = "Techincal_ID";
            dataGridView1.DataSource = Techincal.Select_ReportTechnical(Convert.ToInt32(comboBox1.SelectedValue));
            textBox1.Text = dataGridView1.Rows.Count.ToString();
        }
        DataTable dt = new DataTable();

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text != string.Empty)
                {
                    dt.Clear();
                    dt = Techincal.Search_ReportTechnical(Convert.ToInt32(comboBox1.SelectedValue), DateFrom.Value, DateTo.Value);
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
                    dataGridView1.DataSource = Techincal.Select_ReportTechnical(Convert.ToInt32(comboBox1.SelectedValue));
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
            if (comboBox1.Text != "")
            {
                dt.Clear();
                dt = Techincal.vildateTechincal(Convert.ToInt32(comboBox1.SelectedValue));
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("يرجي العلم بان اسم الفني غير مسجل من قبل يرجي تسجيل هذا الاسم في شاشه الفني", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                    comboBox1.Focus();
                    comboBox1.SelectAll();
                    return;
                }
            }
        }
    }
}
