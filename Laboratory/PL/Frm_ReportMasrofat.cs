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
    public partial class Frm_ReportMasrofat : Form
    {
        Masrofat M = new Masrofat();
        public Frm_ReportMasrofat()
        {
            InitializeComponent();
            //gridControl1.DataSource = M.select_Masrofat();
            Function();
        }
        void Function()
        {
            try
            {
                Calc_Total();
                Permision();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        void Calc_Total()
        {
            decimal total = 0;
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                DataRow row = gridView1.GetDataRow(i);
                total += Convert.ToDecimal(row[2].ToString());

            }
            textBox1.Text = total.ToString("₱ #,##0.0");

        }
        void Permision()
        {
            Branches b = new Branches();
            DataTable dt = new DataTable();
            Users u = new Users();

            dt.Clear();
            dt = u.SelectUserBranch(Program.salesman);

            if (dt.Rows.Count > 0)
            {
                cmb_UserBranch.DataSource = u.SelectUserBranch(Program.salesman);
                cmb_UserBranch.DisplayMember = "Name";
                cmb_UserBranch.ValueMember = "Branch_ID";
                cmb_UserBranch.SelectedIndex = -1;

            }
            else
            {
                cmb_UserBranch.DataSource = b.SelectCompBranches();
                cmb_UserBranch.DisplayMember = "Name";
                cmb_UserBranch.ValueMember = "Branch_ID";
                cmb_UserBranch.SelectedIndex = -1;
           
            }
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
    
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }
        Masrofat m = new Masrofat();
        private void Frm_ReportMasrofat_Load(object sender, EventArgs e)
        {
            searchControl1.Hide();
            comboBox1.DataSource = m.SelectReserve();
            comboBox1.DisplayMember = "masrof_type";
            comboBox1.ValueMember = "ID_masrof";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
             
                dt.Clear();
                if (checkBox1.Checked == true)
                {


                  
                    dt = M.search_Masrofat(DateFrom.Value, DateTo.Value);
                    gridControl1.DataSource = dt;
                    Calc_Total();
                }
                else
                {
                    if (cmb_UserBranch.Text == "")
                    {
                        MessageBox.Show("يرجي اختيار فرع");
                        return;
                    }
                    if (comboBox1.Text == "")
                    {
                        MessageBox.Show("يرجي اختيار نوع الصمروف");
                        return;
                    }
                    dt = M.search_CategoryMasrofat(DateFrom.Value, DateTo.Value,Convert.ToInt32(comboBox1.SelectedValue),
                        Convert.ToInt32(cmb_UserBranch.SelectedValue));
                    gridControl1.DataSource = dt;
                    Calc_Total();

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
            if (gridView1.RowCount>0)
            {


                gridControl1.ShowRibbonPrintPreview();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                cmb_UserBranch.Enabled = false;
                cmb_UserBranch.DataSource = null;
                comboBox1.Enabled = false;
                comboBox1.DataSource = null;
            }
            else
            {
                Permision();
                comboBox1.DataSource = m.SelectReserve();
                comboBox1.DisplayMember = "masrof_type";
                comboBox1.ValueMember = "ID_masrof";
                cmb_UserBranch.Enabled = true;
                comboBox1.Enabled = true;
            }
         
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {
            //textBox1.Text = gridView1.Columns["price"].SummaryItem.SummaryValue.ToString();
        }
    }
}
