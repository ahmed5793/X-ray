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
            //SELECTALLDOCTOR();
         



        }

        //void SELECTALLDOCTOR()
        //{

        //    DataTable dt = new DataTable();
        //    DataTable dt2 = new DataTable();
        //    dt.Clear();
        //     dt = Doctors.Select_ALLReportDoctor();




        //    var total = 0;
        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        //for (int j = 0; j < dt.Rows[i][j]; j++)
        //        //{
        //        //    if (dt.Rows[i][0])

        //        //        continue;




        //         //   total += Convert.ToInt32(dt.Rows[i][j]);

        //        //}
        //        // display 
        //        // totals.Add(total);
        //        // you haev the value add it whenever you want
        //        dt.Rows[i]["TOTAL"] = total;
        //        total = 0;
        //        gridControl1.DataSource = dt;
        //    }


        //}

        void searchDatetAllDoctor()
        {
            try
            {

            



            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            dt.Clear();
            dt = Doctors.Search_ALLReportDoctor(DateFrom.Value, DateTo.Value);
                if (dt.Rows.Count == 0)
                {
                    gridControl1.DataSource = null;
                }
                else
                {


                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        dt2.Clear();
                        dt2 = Doctors.SelectDateCountDoctorOut(Convert.ToInt32(dt.Rows[i]["Doc_ID"]), DateFrom.Value, DateTo.Value);
                        for (int y = 0; y < dt2.Rows.Count; y++)
                        {
                            int COUNT = Convert.ToInt32(dt2.Rows[y][0]);
                            decimal VALUE = Convert.ToDecimal(dt2.Rows[y][1]);


                            dt.Rows[i]["COUNT"] = COUNT;
                            dt.Rows[i]["VALUE"] = Math.Round(VALUE, 2);




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
        void SelectAllDoctor()
        {
           
            //DataTable dt = new DataTable();
            //DataTable dt2 = new DataTable();
            //dt.Clear();
            //dt = Doctors.Select_ALLReportDoctor();
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    dt2.Clear();
            //    dt2 = Doctors.SelectCountDoctorOut(Convert.ToInt32(dt.Rows[i]["Doc_ID"]));
            //    for (int y = 0; y < dt2.Rows.Count; y++)
            //    {

                  
            //        dt.Rows[i]["COUNT"] = Convert.ToInt32(dt2.Rows[y][0]);

            //        dt.Rows[i]["VALUE"] = Convert.ToDecimal(dt2.Rows[y][1]);
            //        dt.Rows[i]["TOTAL"] = Convert.ToDecimal(dt2.Rows[y][2]);

            //    }
            //    gridControl1.DataSource = dt;
            //}
         

        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
          
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
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
            //GridView gView = (GridView)sender;
            //if (!gView.IsValidRowHandle(e.RowHandle)) return;
            //int parent = gView.GetParentRowHandle(e.RowHandle);
            //if (gView.IsGroupRow(parent))
            //{
            //    for (int i = 0; i < gView.GetChildRowCount(parent); i++)
            //        if (gView.GetChildRowHandle(parent, i) == e.RowHandle)
            //            e.Appearance.BackColor = i % 2 == 0 ? Color.White : Color.Yellow;
            //}
            //else e.Appearance.BackColor = e.RowHandle % 2 == 0 ? Color.White : Color.Yellow;
        }

        private void Frm_AllCasesOFOutDoctor_Load(object sender, EventArgs e)
        {
            //SelectAllDoctor();
            //gridView1.Columns["Doc_ID"].Visible = false;
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

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
          
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
           
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
