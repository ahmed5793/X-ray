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

using Laboratory.RPT_Order;
using DevExpress.XtraGrid.Views.Grid;

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
                    gridControl1.DataSource = DoctorOfCenter.Select_NumberCases_DoctorOfCenter(Convert.ToInt32(comboBox1.SelectedValue));

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

        private void button1_Click(object sender, EventArgs e)
        {
            //frm_SingelReport s = new frm_SingelReport();
            //Rpt_NumberCases nc = new Rpt_NumberCases();

          


          

            //    s.documentViewer1.Refresh();
            //nc.Parameters["DateFrom"].Value = DateFrom.Value;

            //nc.Parameters["DateTo"].Value = DateTo.Value;
            //nc.Parameters["Id_DoctorOfCenter"].Value = Convert.ToInt32(comboBox1.SelectedValue);

           //nc.DataSource = DoctorOfCenter.Search_NumberCases_DoctorOfCenter(Convert.ToInt32(comboBox1.SelectedValue), DateFrom.Value, DateTo.Value);
           // nc.Parameters["DateFrom"].Visible = false;
           // nc.Parameters["DateTo"].Visible = false;
           // //nc.Parameters["Id_DoctorOfCenter"].Visible = false;
        

           // s.documentViewer1.DocumentSource = nc;
          

           //     s.ShowDialog();


            
        

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
           
           
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

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
                        e.Appearance.BackColor = i % 2 == 0 ? Color.LightPink : Color.Red;
            }
            else e.Appearance.BackColor = e.RowHandle % 2 == 0 ? Color.Gold : Color.Green;
        }
    }
}
