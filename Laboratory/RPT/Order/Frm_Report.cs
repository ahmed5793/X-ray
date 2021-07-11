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

namespace Laboratory.RPT.Order
{
    public partial class Frm_Report : Form
    {
        public Frm_Report()
        {
            InitializeComponent();
            cmb_branches.Enabled = false;
        }

   
         
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                DataSetRevenue dso = new DataSetRevenue();
                DataTable dt1 = new DataTable();
                DataTable dt2 = new DataTable();
                DataTable dt3 = new DataTable();
                Tickets t = new Tickets();
              
                Masrofat m = new Masrofat();

                if (rdb_one.Checked == true)
                {


                    if (cmb_branches.Text == "")
                    {
                        MessageBox.Show("لابد من وجود فرع");
                        return;
                    }


                    ////////////

                    //  Rpt_Revenue report = new Rpt_Revenue();
                    Rpt_DevRevenue report = new Rpt_DevRevenue();
                  //  Frm_Report sr = new Frm_Report();

                  

                    ////////////
                    dt1.Clear();
                    dt1 = t.ReportRevenueAllDetails(cmb_branches.Text, dtb_from.Value, dtb_to.Value);



                    documentViewer1.Refresh();
                    dso.Tables["DataTable"].Clear();
                    for (int i = 0; i < dt1.Rows.Count; i++)
                    {



                        dso.Tables["DataTable"].Rows.Add(dt1.Rows[i][0], dt1.Rows[i][1], dt1.Rows[i][2],
                           dt1.Rows[i][3], dt1.Rows[i][4], dt1.Rows[i][5], dt1.Rows[i][6],
                           dt1.Rows[i][7], dt1.Rows[i][8], dt1.Rows[i][9], dt1.Rows[i][10],
                           dt1.Rows[i][11], dt1.Rows[i][12], dt1.Rows[i][13], dt1.Rows[i][14],
                           dt1.Rows[i][15]);
                    }


                    dt2 = m.Report_RevenueDetails_Masrofat_OneBranch(cmb_branches.Text, dtb_from.Value,
                        dtb_to.Value);
                   documentViewer1.Refresh();
                    dso.Tables["Masrofat"].Clear();
                    dso.Tables["Masrofat"].Rows.Add(dt2.Rows[0][0]);


                    dt3.Clear();
                    dt3 = t.SelectPermissionMoneyCustomer(Convert.ToInt32(cmb_branches.SelectedValue),
                        dtb_from.Value, dtb_to.Value);
                    dso.Tables["PerimissionOneBranch"].Clear();
                    dso.Tables["PerimissionOneBranch"].Rows.Add(dt3.Rows[0][0]);

                    report.DataSource = dso;
                    report.Parameters["Branch"].Value = cmb_branches.Text;
                    report.Parameters["FromDate"].Value = dtb_from.Text;
                    report.Parameters["Todate"].Value = dtb_to.Text;
                 
                    report.Parameters["Branch"].Visible = false;
                    report.Parameters["FromDate"].Visible = false;
                    report.Parameters["Todate"].Visible = false;
                  
                    documentViewer1.DocumentSource = report;
                  
                    report.CreateDocument();
                  

                }
                else if(rdb_All.Checked==true)
                {
                    XtraReportRevenueDetailsAllBranch reportB = new XtraReportRevenueDetailsAllBranch();
                    Frm_Report sr1 = new Frm_Report();
                    
                   
                    ////////////
                    dt1.Clear();
                    dt1 = t.Report_RevenueDetails_AllBranch( dtb_from.Value, dtb_to.Value);



                    sr1.documentViewer1.Refresh();
                    dso.Tables["DataTableAllBranch"].Clear();
                    for (int n = 0; n < dt1.Rows.Count; n++)
                    {
                        dso.Tables["DataTableAllBranch"].Rows.Add(dt1.Rows[n][0], dt1.Rows[n][1], dt1.Rows[n][2],
                           dt1.Rows[n][3], dt1.Rows[n][4], dt1.Rows[n][5], dt1.Rows[n][6],
                           dt1.Rows[n][7], dt1.Rows[n][8], dt1.Rows[n][9], dt1.Rows[n][10],
                           dt1.Rows[n][11], dt1.Rows[n][12], dt1.Rows[n][13], dt1.Rows[n][14],
                           dt1.Rows[n][15]);
                    }

                    dt2 = m.Report_RevenueDetails_Masrofat_AllBranch(dtb_from.Value, dtb_to.Value);
                    sr1.documentViewer1.Refresh();
                    dso.Tables["MasrofatAllBranch"].Clear();
                    dso.Tables["MasrofatAllBranch"].Rows.Add(dt2.Rows[0][0]);

                    dt3.Clear();
                    dt3 = t.SelectPermissionMoneyCustomerAllBranch(dtb_from.Value, dtb_to.Value);
                    dso.Tables["PerimissionAllBranch"].Clear();
                    dso.Tables["PerimissionAllBranch"].Rows.Add(dt3.Rows[0][0]);

                    reportB.DataSource = dso;
                    reportB.Parameters["FromDate"].Value = dtb_from.Text;
                    reportB.Parameters["ToDate"].Value = dtb_to.Text;
                    reportB.Parameters["FromDate"].Visible = false;
                    reportB.Parameters["ToDate"].Visible = false;
                    // documentViewer1.Refresh();
                      documentViewer1.DocumentSource = reportB;
                  
                    reportB.CreateDocument();
                 
                }
               











                // ----------------------crystal report-----------------------
                //sr.crystalReportViewer1.Refresh();
                //report.SetDatabaseLogon("DB_A54A03_LastLaboratory_admin", "Titonasser1994", "sql5033.site4now.net", "DB_A54A03_LastLaboratory");

                //report.SetParameterValue("@Date_From", dtb_from.Text);
                //report.SetParameterValue("@Date_To", dtb_to.Text);

                //crystalReportViewer1.ReportSource = report;
                //  sr.documentViewer1.Enabled = true;

                ///sr.documentViewer1.DocumentSource = report;




            }
            catch (Exception ex)
            {

               MessageBox.Show(ex.Message);
            }
        }
        void brnches()
        {
            try
            {
                Branches b = new Branches();
                cmb_branches.DataSource = b.SelectCompBranches();
                cmb_branches.DisplayMember = "Name";
                cmb_branches.ValueMember = "Branch_ID";
               // cmb_branches.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void Frm_Report_Load(object sender, EventArgs e)
        {

        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_one.Checked==true)
            {
                cmb_branches.Enabled = true;
                brnches();
            }
           
        }

        private void rdb_All_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_All.Checked==true)
            {
              
                cmb_branches.Enabled = false;
                cmb_branches.DataSource = null;
            }
           
        }

        private void dtb_to_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmb_branches_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void dtb_from_ValueChanged(object sender, EventArgs e)
        {

        }

        private void printPreviewBarItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void printPreviewBarItem31_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void printPreviewBarItem32_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void printPreviewBarItem33_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void printPreviewBarItem34_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void printPreviewBarItem35_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void printPreviewBarItem36_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void printPreviewBarItem37_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void printPreviewBarItem38_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void printPreviewBarItem39_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void printPreviewBarItem40_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void printPreviewBarItem41_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void printPreviewBarItem42_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void printPreviewBarItem43_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void printPreviewBarItem44_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void printPreviewBarItem45_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void printPreviewBarItem46_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void printPreviewBarItem47_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void printPreviewBarItem48_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void printPreviewBarItem49_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void documentViewer1_Load(object sender, EventArgs e)
        {

        }

        private void ribbonStatusBar1_Click(object sender, EventArgs e)
        {

        }

        private void printPreviewStaticItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void progressBarEditItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void ribbonControl1_Click_1(object sender, EventArgs e)
        {

        }

        private void printPreviewBarItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void printPreviewBarItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void printPreviewBarItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void printPreviewBarItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void printPreviewBarItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void printPreviewBarItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void printPreviewBarItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void printPreviewBarItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void printPreviewBarItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void printPreviewBarItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void printPreviewBarItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void printPreviewBarItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void printPreviewBarItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void printPreviewBarItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void printPreviewBarItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void printPreviewBarItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void printPreviewBarItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void printPreviewBarItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void printPreviewBarItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void printPreviewBarItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void printPreviewBarItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void printPreviewBarItem23_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void printPreviewBarItem24_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void printPreviewBarItem25_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void printPreviewBarItem26_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void printPreviewBarItem27_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void printPreviewBarItem28_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void printPreviewBarItem29_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void printPreviewBarItem30_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void printPreviewBarItem50_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void printPreviewBarItem51_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void printPreviewBarItem52_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void printPreviewBarItem53_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void printPreviewBarItem54_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void printPreviewBarItem55_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void printPreviewBarItem56_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void printPreviewBarItem57_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void printPreviewBarItem58_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void printPreviewBarItem59_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void printPreviewBarItem60_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void printPreviewBarItem61_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void printPreviewBarItem62_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void printPreviewBarItem63_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void printPreviewBarItem64_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void printPreviewBarItem65_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void printPreviewBarItem66_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void printPreviewBarItem67_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void printPreviewBarItem68_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void printPreviewBarItem69_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void printPreviewBarItem70_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void printPreviewBarItem71_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void printPreviewBarItem72_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void printPreviewStaticItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void zoomTrackBarEditItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
