﻿using System;
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
                    Frm_Report sr = new Frm_Report();

                    DataSetRevenue dso = new DataSetRevenue();
                    DataTable dt1 = new DataTable();
                    DataTable dt2 = new DataTable();
                    ////////////
                    dt1.Clear();
                    dt1 = t.ReportRevenueAllDetails(cmb_branches.Text, dtb_from.Value, dtb_to.Value);



                    sr.documentViewer1.Refresh();
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
                    sr.documentViewer1.Refresh();
                    dso.Tables["Masrofat"].Clear();
                  


                        dso.Tables["Masrofat"].Rows.Add(dt2.Rows[0][0]);
                    
                    report.DataSource = dso;
                    report.Parameters["Branch"].Value = cmb_branches.Text;
                    report.Parameters["FromDate"].Value = dtb_from.Text;
                    report.Parameters["Todate"].Value = dtb_to.Text;
                    sr.documentViewer1.DocumentSource = report;
                    report.Parameters["Branch"].Visible = false;
                    report.Parameters["FromDate"].Visible = false;
                    report.Parameters["Todate"].Visible = false;
                  // documentViewer1.Refresh();
                  //  documentViewer1.DocumentSource = report;
                    // sr.documentViewer1.Enabled = true;

                    sr.ShowDialog();

                }
                else if(rdb_All.Checked==true)
                {
                    XtraReportRevenueDetailsAllBranch reportB = new XtraReportRevenueDetailsAllBranch();
                    Frm_Report sr1 = new Frm_Report();
                    
                    DataSetRevenue dso1= new DataSetRevenue();
                    DataTable dt1 = new DataTable();
                    ////////////
                    dt1.Clear();
                    dt1 = t.Report_RevenueDetails_AllBranch( dtb_from.Value, dtb_to.Value);



                    sr1.documentViewer1.Refresh();
                    dso1.Tables["DataTableAllBranch"].Clear();
                    for (int n = 0; n < dt1.Rows.Count; n++)
                    {
                        dso1.Tables["DataTableAllBranch"].Rows.Add(dt1.Rows[n][0], dt1.Rows[n][1], dt1.Rows[n][2],
                           dt1.Rows[n][3], dt1.Rows[n][4], dt1.Rows[n][5], dt1.Rows[n][6],
                           dt1.Rows[n][7], dt1.Rows[n][8], dt1.Rows[n][9], dt1.Rows[n][10],
                           dt1.Rows[n][11], dt1.Rows[n][12], dt1.Rows[n][13], dt1.Rows[n][14],
                           dt1.Rows[n][15]);
                    }

                    reportB.DataSource = dso1;
                    reportB.Parameters["FromDate"].Value = dtb_from.Text;
                    reportB.Parameters["ToDate"].Value = dtb_to.Text;
                    sr1.documentViewer1.DocumentSource = reportB;
                    reportB.Parameters["FromDate"].Visible = false;
                    reportB.Parameters["ToDate"].Visible = false;
                    // documentViewer1.Refresh();
                     // documentViewer1.DocumentSource = reportB;
                     sr1.documentViewer1.Enabled = true;

                    sr1.ShowDialog();
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
            }
           
        }
    }
}
