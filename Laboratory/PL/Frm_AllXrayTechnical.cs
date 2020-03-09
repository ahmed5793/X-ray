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
    public partial class Frm_AllXrayTechnical : Form
    {
        Techincal Techincal = new Techincal();

        public Frm_AllXrayTechnical()
        {
            InitializeComponent();

            comboBox1.DataSource = Techincal.Select_ComboTechnical();
            comboBox1.DisplayMember = "Tech_Name";
            comboBox1.ValueMember = "Techincal_ID";

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text!="")
                {
                    gridControl1.DataSource = Techincal.Technical_ItemXray(Convert.ToInt32(comboBox1.SelectedValue));

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
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
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                dt.Dispose();
            }
       
        }

        private void DateFrom_ValueChanged(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }

        private void Frm_AllXrayTechnical_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();

            try
            {
                if (comboBox1.Text != string.Empty)
                {
                    dt.Clear();
                    dt = Techincal.Search_Technical_ItemXray(Convert.ToInt32(comboBox1.SelectedValue), DateFrom.Value, DateTo.Value);
                    gridControl1.DataSource = dt;

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
