using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Laboratory.BL;
namespace Laboratory.RPT
{
    public partial class Frm_ReportMoveStock : DevExpress.XtraEditors.XtraForm
    {
        Stock s = new Stock(); 
 
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        public Frm_ReportMoveStock()
        {
            InitializeComponent();
            Stock();
        }
        void Stock()
        {
            cmb_Stock.DataSource = s.Compo_Stock();
            cmb_Stock.DisplayMember = "Name_Stock";
            cmb_Stock.ValueMember = "ID_Stock";
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                DataSetMoveStock dso = new DataSetMoveStock();
                Frm_ReportMoveStock frm = new Frm_ReportMoveStock();
                Rpt_MoveStock rpt = new Rpt_MoveStock();

            dso.Tables["Insert_Stock"].Clear();
            dso.Tables["Stock_Pull"].Clear();
            dt1.Clear();
            dt1 = s.ReportMoveInserStock(Convert.ToInt32(cmb_Stock.SelectedValue),dtb_from.Value,dtb_to.Value);
            dt2.Clear();
            dt2 = s.ReportMovePullStock(Convert.ToInt32(cmb_Stock.SelectedValue), dtb_from.Value, dtb_to.Value);
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                dso.Tables["Insert_Stock"].Rows.Add(dt1.Rows[i][0], 
                   (dt1.Rows[i][1]),(dt1.Rows[i][2]),
                    dt1.Rows[i][3],dt1.Rows[i][4]);
            }
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
              dso.Tables["Stock_Pull"].Rows.Add(dt2.Rows[i][0], (dt2.Rows[i][1])
                  , (dt2.Rows[i][2]), dt2.Rows[i][3], dt2.Rows[i][4]);
            }
           
              frm.documentViewer1.Refresh();
                rpt.DataSource = dso;
                rpt.Parameters["Id_Stock"].Value = Convert.ToInt32(cmb_Stock.SelectedValue);
                rpt.Parameters["Date_From"].Value = (dtb_from.Value);
                rpt.Parameters["Date_To"].Value = (dtb_to.Value);
                frm.documentViewer1.DocumentSource = rpt;
               rpt.Parameters["Id_Stock"].Visible = false;
               frm.documentViewer1.Enabled = true;
               documentViewer1.DocumentSource = rpt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }

        }
    }
}