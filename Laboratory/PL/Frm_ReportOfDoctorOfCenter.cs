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
    public partial class Frm_ReportOfDoctorOfCenter : Form
    {
        DoctorOfCenter DoctorOfCenter = new DoctorOfCenter();
        public Frm_ReportOfDoctorOfCenter()
        {
            InitializeComponent();
            comboBox1.DataSource= DoctorOfCenter.CompoDoctor_OFCENTER();
            comboBox1.DisplayMember = "Doc_Name";
            comboBox1.ValueMember = "Doc_ID";
            dataGridView1.DataSource = DoctorOfCenter.Select_ReportDoctorOfCenter(Convert.ToInt32(comboBox1.SelectedValue));
            textBox1.Text = dataGridView1.Rows.Count.ToString();

        }

        private void Frm_ReportOfDoctorOfCenter_Load(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                if (comboBox1.Text != string.Empty)
                {
                    dt.Clear();
                    dt = DoctorOfCenter.Search_ReportDoctorOfCenter(Convert.ToInt32(comboBox1.SelectedValue), DateFrom.Value, DateTo.Value);
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text!=String.Empty)
                {
                    dataGridView1.DataSource = DoctorOfCenter.Select_ReportDoctorOfCenter(Convert.ToInt32(comboBox1.SelectedValue));
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
