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
    public partial class Frm_AllCasesDoctorOfCenter : Form
    {
        DoctorOfCenter DoctorOfCenter = new DoctorOfCenter();

        public Frm_AllCasesDoctorOfCenter()
        {
            InitializeComponent();
            comboBox1.DataSource = DoctorOfCenter.CompoDoctor_OFCENTER();
            comboBox1.DisplayMember = "Doc_Name";
            comboBox1.ValueMember = "Doc_ID";
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text != String.Empty)
                {
                    dataGridView1.DataSource = DoctorOfCenter.Select_NumberCases_DoctorOfCenter(Convert.ToInt32(comboBox1.SelectedValue));

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                if (comboBox1.Text != string.Empty)
                {
                    dt.Clear();
                    dt = DoctorOfCenter.Search_NumberCases_DoctorOfCenter(Convert.ToInt32(comboBox1.SelectedValue), DateFrom.Value, DateTo.Value);
                    dataGridView1.DataSource = dt;

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
                dt = DoctorOfCenter.vildateDoctorOfCenter(Convert.ToInt32(comboBox1.SelectedValue));
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("يرجي العلم بان اسم طبيب الاشعة غير مسجل من قبل ", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                    comboBox1.Focus();
                    comboBox1.SelectAll();
                    return;
                }
                dt.Dispose();
            }
        }

        private void Frm_AllCasesDoctorOfCenter_Load(object sender, EventArgs e)
        {

        }
    }
}
