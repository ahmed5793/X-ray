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


namespace Laboratory.RPT.Order
{
    public partial class Frm_Report : Form
    {
        public Frm_Report()
        {
            InitializeComponent();
        }

        //DataTable dt1 = new DataTable();
        //DataTable dt2 = new DataTable();
        //DataTable dt3 = new DataTable();
        //DataTable dt4 = new DataTable();
         
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                Tickets t = new Tickets();

                ////////////
             
               
                Frm_Report sr = new Frm_Report();

                Rpt_Revenue report = new Rpt_Revenue();
                

                // DataSetRevenue dso = new DataSetRevenue();

                //dt1.Clear();
                //dt1 = t.Report_ReveuneBranches(dtb_from.Value, dtb_to.Value);

                //dt2.Clear();
                //dt2 = t.Report_ReveuneBranchesDiscount(dtb_from.Value, dtb_to.Value);
                //dt3.Clear();
                //dt3 = t.Report_ReveuneBranchesMoney(dtb_from.Value, dtb_to.Value);

                //dt4.Clear();
                //dt4 = t.Report_ReveuneBranchesReturn(dtb_from.Value, dtb_to.Value);
                //sr.documentViewer1.Refresh();
                //dso.Tables["DataTableCount"].Clear();
                //dso.Tables["DataTableMoney"].Clear();
                //dso.Tables["DataTableDiscount"].Clear();
                //dso.Tables["DataTableReturn"].Clear();
                //for (int i = 0; i < dt1.Rows.Count; i++)
                //{



                //    dso.Tables["DataTableCount"].Rows.Add(dt1.Rows[i][0], dt1.Rows[i][1], dt1.Rows[i][2],
                //       dt1.Rows[i][3]);
                //}


                //for (int i = 0; i < dt3.Rows.Count; i++)
                //{



                //    dso.Tables["DataTableMoney"].Rows.Add(dt3.Rows[i][0], dt3.Rows[i][1], dt3.Rows[i][2],
                //       dt3.Rows[i][3]);
                //}
                //   for (int i = 0; i < dt2.Rows.Count; i++)
                //{



                //    dso.Tables["DataTableDiscount"].Rows.Add(dt2.Rows[i][0], dt2.Rows[i][1], dt2.Rows[i][2],
                //       dt2.Rows[i][3]);
                //}
                //for (int i = 0; i < dt4.Rows.Count; i++)
                //{



                //    dso.Tables["DataTableReturn"].Rows.Add(dt4.Rows[i][0], dt4.Rows[i][1], dt4.Rows[i][2],
                //       dt4.Rows[i][3]);
                //}

                sr.crystalReportViewer1.Refresh();
                report.SetDatabaseLogon("DB_A54A03_LastLaboratory_admin", "Titonasser1994", "sql5033.site4now.net", "DB_A54A03_LastLaboratory");
            
                report.SetParameterValue("@Date_From", dtb_from.Text);
                report.SetParameterValue("@Date_To", dtb_to.Text);

                crystalReportViewer1.ReportSource = report;
              //  sr.documentViewer1.Enabled = true;

                ///sr.documentViewer1.DocumentSource = report;


                //report.DataSource = dso;
                //report.Parameters["DateFrom"].Value = dtb_from.Value;
                //report.Parameters["DateTo"].Value = dtb_to.Value;
                //sr.documentViewer1.DocumentSource = report;
                //report.Parameters["DateFrom"].Visible = false;
                //report.Parameters["DateTo"].Visible = false;
              
              //  sr.ShowDialog();
               
            }
            catch (Exception ex)
            {

               MessageBox.Show(ex.Message);
            }
        }
    }
}
