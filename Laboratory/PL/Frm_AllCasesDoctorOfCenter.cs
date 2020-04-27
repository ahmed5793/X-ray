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
        DataTable dt = new DataTable();

        public Frm_AllCasesDoctorOfCenter()
        {
            InitializeComponent();

            Function();
        }
        void Function()
        {
            try
            {
            //    comboBox1.DataSource = DoctorOfCenter.CompoDoctor_OFCENTER();
            //    comboBox1.DisplayMember = "Doc_Name";
            //    comboBox1.ValueMember = "Doc_ID";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        void searchDatetAllDoctor()
        {

            try
            {


            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            dt.Clear();
            dt = DoctorOfCenter.Search_ALLReportDoctorOfCenter(DateFrom.Value, DateTo.Value);
            if (dt.Rows.Count == 0)
            {
                gridControl1.DataSource = null;
            }
            else
            {


                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt2.Clear();
                    dt2 = DoctorOfCenter.SelectDateCountDoctorOfCenter(Convert.ToInt32(dt.Rows[i]["Doc_ID"]), DateFrom.Value, DateTo.Value);
                    for (int y = 0; y < dt2.Rows.Count; y++)
                    {
                        int COUNT = Convert.ToInt32(dt2.Rows[y][0]);
                        decimal VALUE = Convert.ToDecimal(dt2.Rows[y][1]);
                        //decimal TOTAL = Convert.ToDecimal(dt2.Rows[y][2]);

                        dt.Rows[i]["COUNT"] = COUNT;
                        dt.Rows[i]["VALUE"] = Math.Round(VALUE, 2);
                        //dt.Rows[i]["TOTAL"] = Math.Round(TOTAL, 2);



                    }
                    gridControl1.DataSource = dt;
                    gridView1.Columns["Doc_ID"].Visible = false;
                }

            }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //try
            //{
            //    if (comboBox1.Text != String.Empty)
            //    {
            //        gridControl1.DataSource = DoctorOfCenter.Select_NumberCases_DoctorOfCenter(Convert.ToInt32(comboBox1.SelectedValue));

            //    }
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message);
            //}
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            //if (comboBox1.Text != "")
            //{
            //    dt.Clear();
                //dt = DoctorOfCenter.vildateDoctorOfCenter(Convert.ToInt32(comboBox1.SelectedValue));
            //    if (dt.Rows.Count == 0)
            //    {
            //        MessageBox.Show("يرجي العلم بان اسم طبيب الاشعة غير مسجل من قبل ", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

            //        comboBox1.Focus();
            //        comboBox1.SelectAll();
            //        return;
            //    }
            //    dt.Dispose();
            //}
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
            //GridView gView = (GridView)sender;
            //if (!gView.IsValidRowHandle(e.RowHandle)) return;
            //int parent = gView.GetParentRowHandle(e.RowHandle);
            //if (gView.IsGroupRow(parent))
            //{
            //    for (int i = 0; i < gView.GetChildRowCount(parent); i++)
            //        if (gView.GetChildRowHandle(parent, i) == e.RowHandle)
            //            e.Appearance.BackColor = i % 2 == 0 ? Color.LightPink : Color.Red;
            //}
            //else e.Appearance.BackColor = e.RowHandle % 2 == 0 ? Color.Gold : Color.Green;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            try
            {
                searchDatetAllDoctor();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        
        }

        private void Btn_Print_Click(object sender, EventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }
    }
}
