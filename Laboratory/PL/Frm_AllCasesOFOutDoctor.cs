using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using Laboratory.BL;
namespace Laboratory.PL
{
    public partial class Frm_AllCasesOFOutDoctor : Form
    {
        Doctors Doctors = new Doctors();

        public Frm_AllCasesOFOutDoctor()
        {
            InitializeComponent();
            Function();
        }
        void Function()
        {
            try
            {
                comboBox1.Enabled = false;
                checkBox1.Checked = false;
                gridControl1.DataSource = Doctors.Select_ALLReportDoctor();

                comboBox1.DataSource = Doctors.Select_ComboDoctor();
                comboBox1.DisplayMember = "Doc_Name";
                comboBox1.ValueMember = "Doc_ID";
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

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text != String.Empty)
                {
                    gridControl1.DataSource = Doctors.Select_AllCasesOfOutDoctor(Convert.ToInt32(comboBox1.SelectedValue));

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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }

        private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            GridView gView = (GridView)sender;
            if (!gView.IsValidRowHandle(e.RowHandle)) return;
            int parent = gView.GetParentRowHandle(e.RowHandle);
            if (gView.IsGroupRow(parent))
            {
                for (int i = 0; i < gView.GetChildRowCount(parent); i++)
                    if (gView.GetChildRowHandle(parent, i) == e.RowHandle)
                        e.Appearance.BackColor = i % 2 == 0 ? Color.White : Color.Blue;
            }
            else e.Appearance.BackColor = e.RowHandle % 2 == 0 ? Color.White : Color.Blue;
        }

        private void Frm_AllCasesOFOutDoctor_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                if (checkBox1.Checked == true)
                {
                   


                    if (comboBox1.Text != string.Empty)
                    {
                        dt.Clear();
                        dt = Doctors.Search_AllCasesOfOutDoctor(Convert.ToInt32(comboBox1.SelectedValue), DateFrom.Value, DateTo.Value);
                        gridControl1.DataSource = dt;

                    }
                }
                
                
              else
            {
                    gridControl1.DataSource = Doctors.Search_ALLReportDoctor(DateFrom.Value, DateTo.Value);


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

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (comboBox1.Text != String.Empty)
                {
                    gridControl1.DataSource = Doctors.Select_AllCasesOfOutDoctor(Convert.ToInt32(comboBox1.SelectedValue));

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                comboBox1.Enabled = true;
                gridView1.Columns.Clear();
                comboBox1.DataSource = Doctors.Select_ComboDoctor();
                comboBox1.DisplayMember = "Doc_Name";
                comboBox1.ValueMember = "Doc_ID";
                comboBox1.SelectedIndex = -1;
            }
            else
            {
              


                comboBox1.Enabled = false;
                comboBox1.DataSource = null;
                gridControl1.DataSource = Doctors.Select_ALLReportDoctor();
            }
        }
    }
}
