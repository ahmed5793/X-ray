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
    public partial class Frm_AllXrayTechnical : Form
    {
        Techincal Techincal = new Techincal();

        public Frm_AllXrayTechnical()
        {
            InitializeComponent();
            
        }
     
        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
       
        }

        private void DateFrom_ValueChanged(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void Frm_AllXrayTechnical_Load(object sender, EventArgs e)
        {

        }
        void searchDatetAllDoctor()
        {
            try
            {





                DataTable dt = new DataTable();
                DataTable dt2 = new DataTable();
                dt.Clear();
                dt = Techincal.Search_Technical_ItemXray(DateFrom.Value, DateTo.Value);
                if (dt.Rows.Count == 0)
                {
                    gridControl1.DataSource = null;
                }
                else
                {


                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        dt2.Clear();
                        dt2 = Techincal.SelectDateCountTechincal(Convert.ToInt32(dt.Rows[i]["Techincal_ID"]), DateFrom.Value, DateTo.Value);
                        for (int y = 0; y < dt2.Rows.Count; y++)
                        {
                            int COUNT = Convert.ToInt32(dt2.Rows[y][0]);



                            dt.Rows[i]["COUNT"] = COUNT;





                        }
                        gridControl1.DataSource = dt;
                        gridView1.Columns["Techincal_ID"].Visible = false;

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


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
