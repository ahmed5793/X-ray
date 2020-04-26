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
        DataTable dt = new DataTable();

        public Frm_ReportOfDoctorOfCenter()
        {
            InitializeComponent();
            Function();
        }

        void Function()
        {
            try
            {

                comboBox1.DataSource = DoctorOfCenter.CompoDoctor_OFCENTER();
                comboBox1.DisplayMember = "Doc_Name";
                comboBox1.ValueMember = "Doc_ID";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            } 
        }
        private void Frm_ReportOfDoctorOfCenter_Load(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
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
                    gridControl1.DataSource = DoctorOfCenter.Select_ReportDoctorOfCenter(Convert.ToInt32(comboBox1.SelectedValue));
                    textBox1.Text = gridView1.RowCount.ToString();

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
                dt = DoctorOfCenter.vildateDoctorOfCenter(Convert.ToInt32(comboBox1.SelectedValue));
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("يرجي العلم بان اسم طبيب الاشعة غير مسجل من قبل ", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                    comboBox1.Focus();
                    comboBox1.SelectAll();
                    return;
                }
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            try
            {
                if (comboBox1.Text != string.Empty)
                {
                    dt.Clear();
                    dt = DoctorOfCenter.Search_ReportDoctorOfCenter(Convert.ToInt32(comboBox1.SelectedValue), DateFrom.Value, DateTo.Value);
                    gridControl1.DataSource = dt;
                    textBox1.Text = gridView1.RowCount.ToString();

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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Btn_Print_Click(object sender, EventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }
    }
}
