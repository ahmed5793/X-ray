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
    public partial class Frm_AllPAyCompsny : Form
    {
        Company cm = new Company();
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();

        public Frm_AllPAyCompsny()
        {
            InitializeComponent();
            company();
            dt.Clear();
            dt = cm.Select_AllpAyOfCompany(Convert.ToInt32(cmb_Company.SelectedValue));
            dt2.Clear();
            dt2 = cm.Select_CompanyTotalMoney(Convert.ToInt32(cmb_Company.SelectedValue));
            textBox1.Text = dt2.Rows[0][0].ToString();
        }
        void company()
        {
            cmb_Company.DataSource = cm.SelectCompany();
            cmb_Company.DisplayMember = "اسم الشركه";
            cmb_Company.ValueMember = "Comp_ID";
        }
        //void Calc()
        //{
        //    double sumNetPrice = 0;
        //    for (int i = 0; i < gridView1.DataRowCount; ++i)
        //    {
        //        DataRow row = gridView1.GetDataRow(i);
        //        sumNetPrice += Convert.ToDouble(row[1].ToString());
        //    }
        //    textBox1.Text = sumNetPrice.ToString("₱ #,##0.0");
        //    //decimal Total = 0;
        //    //for (int i = 0; i < gridView1.RowCount; i++)
        //    //{
        //    //    Total += Convert.ToDecimal(grid)
        //    //}
        //    //textBox1.Text = Math.Round(Total, 1).ToString();
        //}
        private void btn_search_Click(object sender, EventArgs e)
        {
          
        }

        private void cmb_Company_Leave(object sender, EventArgs e)
        {
            try
            {
                if (cmb_Company.Text != "")
                {
                    dt2.Clear();
                    dt2 = cm.Validate_CompanyNAme(Convert.ToInt32(cmb_Company.SelectedValue));
                    if (dt2.Rows.Count == 0)
                    {
                        MessageBox.Show("إسم الشركة غير صحيح");
                        cmb_Company.Focus();
                        cmb_Company.SelectAll();
                        return;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
          
        }

        private void cmb_Company_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (cmb_Company.Text != "")
                {
                    dt.Clear();
                    dt = cm.Select_AllpAyOfCompany(Convert.ToInt32(cmb_Company.SelectedValue));
                    gridControl1.DataSource = dt;
                    dt2.Clear();
                    dt2 = cm.Select_CompanyTotalMoney(Convert.ToInt32(cmb_Company.SelectedValue));
                    textBox1.Text = dt2.Rows[0][0].ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_Company.Text != "")
                {
                    dt.Clear();
                    dt = cm.Search_AllpAyOfCompany(Convert.ToInt32(cmb_Company.SelectedValue), DateFrom.Value, DateTo.Value);
                    gridControl1.DataSource = dt;
                }
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

        private void Frm_AllPAyCompsny_Load(object sender, EventArgs e)
        {

        }
    }
}
