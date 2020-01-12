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
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                total += Convert.ToDecimal(dataGridView1.Rows[i].Cells[6].Value);
            }
            textBox1.Text = Math.Round(total,1).ToString();
        }
        Techincal Techincal = new Techincal();
        public Frm_ReportTechnicalShift()
        {
            InitializeComponent(); 
            comboBox1.DataSource = Techincal.Select_ComboTechnical();
            comboBox1.DisplayMember = "Tech_Name";
            comboBox1.ValueMember = "Techincal_ID";
            Calc();
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
            try
            {
                if (comboBox1.Text != string.Empty)
                {
                    dt.Clear();
                    dt = Techincal.Report_TechnicalShift(comboBox1.Text, DateFrom.Value, DateTo.Value);
                    dataGridView1.DataSource = dt;
                    textBox1.Text = dataGridView1.Rows.Count.ToString();
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
    }
}
