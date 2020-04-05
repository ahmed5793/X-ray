using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.PivotGrid.PivotTable;
using Laboratory.BL;

namespace Laboratory.PL
{
    public partial class Frm_ManagmentTicketsReturn : Form
    {
        Branches b = new Branches();
        Tickets t = new Tickets();
        DataTable dt = new DataTable();
        Users u = new Users();

        public Frm_ManagmentTicketsReturn()
        {
            InitializeComponent();
            txt_username.Text = Program.salesman;
            Permision();
        }
        void Permision()
        {
            try
            {
                dt.Clear();
                dt = u.SelectUserBranch(txt_username.Text);

                if (dt.Rows.Count > 0)
                {
                    cmb_UserBranch.DataSource = u.SelectUserBranch(txt_username.Text);
                    cmb_UserBranch.DisplayMember = "Name";
                    cmb_UserBranch.ValueMember = "Branch_ID";
                }
                else
                {
                    cmb_UserBranch.DataSource = b.SelectCompBranches();
                    cmb_UserBranch.DisplayMember = "Name";
                    cmb_UserBranch.ValueMember = "Branch_ID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
       
        }
        void calc()
        {
            decimal totall = 0;
            for (int i = 0; i < gridView1.RowCount ; i++)
            {
                DataRow row = gridView1.GetDataRow(i);
                totall += Convert.ToDecimal(row[7]);
            }
            textBox1.Text = Math.Round(totall,1).ToString();
        }
        private void Frm_ManagmentTicketsReturn_Load(object sender, EventArgs e)
        {
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_UserBranch.Text != "")
                {
                    dt.Clear();
                    dt = t.selectSearchTicketsReturnDate(cmb_UserBranch.Text, DateFrom.Value, DateTo.Value);
                    gridControl1.DataSource = dt;
                    calc();
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

        private void cmb_UserBranch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                gridControl1.DataSource = t.selectTicketsReturn(cmb_UserBranch.Text);
                calc();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void cmb_UserBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                gridControl1.DataSource = t.selectTicketsReturn(cmb_UserBranch.Text);
                calc();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
