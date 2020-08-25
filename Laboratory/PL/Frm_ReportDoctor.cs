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
        DataTable dt = new DataTable();
        public Frm_ReportDoctor()
        {
            InitializeComponent();
            Function();
        }
        void Function()
        {
            try
            {
                comboBox1.DataSource = Doctors.Select_ComboDoctor();
                comboBox1.DisplayMember = "Doc_Name";
                comboBox1.ValueMember = "Doc_ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void Calc()
        {
            decimal total = 0;
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                DataRow r = gridView1.GetDataRow(i);
                total += Convert.ToDecimal(r[5].ToString());
            }
            textBox2.Text = total.ToString();
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text != String.Empty)
                {
                    gridControl1.DataSource = Doctors.Select_ReportDoctor(Convert.ToInt32(comboBox1.SelectedValue));
                    textBox1.Text = gridView1.RowCount.ToString();
                    Calc();

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

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text != string.Empty)
                {
                    dt.Clear();
                    dt = Doctors.Search_ReportDoctor(Convert.ToInt32(comboBox1.SelectedValue), DateFrom.Value, DateTo.Value);
                    gridControl1.DataSource = dt;
                    textBox1.Text = gridView1.RowCount.ToString();
                    Calc();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void Btn_Print_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {

                gridControl1.ShowRibbonPrintPreview();
            }
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode==Keys.Enter)
                {
                    if (comboBox1.Text != String.Empty)
                    {
                        gridControl1.DataSource = Doctors.Select_ReportDoctor(Convert.ToInt32(comboBox1.SelectedValue));
                        textBox1.Text = gridView1.RowCount.ToString();
                        Calc();

                    }
                }
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Frm_ReportDoctor_Load(object sender, EventArgs e)
        {

        }
    }
}
