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
    public partial class Frm_Report_Technical : Form
    {
        Techincal Techincal = new Techincal();
        public Frm_Report_Technical()
        {
            InitializeComponent();
            comboBox1.DataSource = Techincal.Select_ComboTechnical();
            comboBox1.DisplayMember = "Tech_Name";
            comboBox1.ValueMember = "Techincal_ID";
            dataGridView1.DataSource = Techincal.Select_ReportTechnical(Convert.ToInt32(comboBox1.SelectedValue));
            textBox1.Text = dataGridView1.Rows.Count.ToString();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
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
    }
}
