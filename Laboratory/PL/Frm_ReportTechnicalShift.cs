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
    public partial class Frm_ReportTechnicalShift : Form
    {
        void Calc()
        {
            decimal total = 0;
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                DataRow row = gridView1.GetDataRow(i);
                total += Convert.ToDecimal(row[6].ToString());

            }
            textBox1.Text = total.ToString("₱ #,##0.0");
        }
        Techincal Techincal = new Techincal();
        public Frm_ReportTechnicalShift()
        {
            InitializeComponent();
            Function();
        }
        void Function()
        {
            try
            {
                comboBox1.DataSource = Techincal.Select_ComboTechnical();
                comboBox1.DisplayMember = "Tech_Name";
                comboBox1.ValueMember = "Techincal_ID";
                Calc();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }
        DataTable dt = new DataTable();
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

        private void btn_search_Click(object sender, EventArgs e)
        {
        }

        private void Frm_ReportTechnicalShift_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

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
                    dt = Techincal.Report_TechnicalShift(Convert.ToInt32(comboBox1.SelectedValue), DateFrom.Value, DateTo.Value);
                    gridControl1.DataSource = dt;
                    textBox1.Text = gridView1.RowCount.ToString();
                    Calc();
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

        private void Btn_Print_Click(object sender, EventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }
    }
}
