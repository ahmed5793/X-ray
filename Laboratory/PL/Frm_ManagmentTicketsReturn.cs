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
        CategoryXRaya c = new CategoryXRaya();

        public Frm_ManagmentTicketsReturn()
        {
            InitializeComponent();
            
            Permision();
        }
        void Permision()
        {
            try
            {
               
                // select Category XRay
             

                Cmb_CategoryItem.Enabled = false;
                dt.Clear();
                dt = u.SelectUserBranch(Program.salesman);

                if (dt.Rows.Count > 0)
                {
                    cmb_UserBranch.DataSource = u.SelectUserBranch(Program.salesman);
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
        //void calc()
        //{
        //    decimal totall = 0;
        //    for (int i = 0; i < gridView1.RowCount ; i++)
        //    {
        //        DataRow row = gridView1.GetDataRow(i);
        //        totall += Convert.ToDecimal(row[7]);
        //    }
        //    textBox1.Text = Math.Round(totall,1).ToString();
        //}
        private void Frm_ManagmentTicketsReturn_Load(object sender, EventArgs e)
        {
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_UserBranch.Text != "")
                {
                    if (rdb_All.Checked==true)
                    {
                        dt.Clear();
                        dt = t.selectSearchTicketsReturnDate(cmb_UserBranch.Text, DateFrom.Value, DateTo.Value);
                        gridControl1.DataSource = dt;
                    }
                    else
                    {
                        dt.Clear();
                        dt = t.selectSearchTicketsReturnDateCategory(cmb_UserBranch.Text, DateFrom.Value, DateTo.Value, Convert.ToInt32(Cmb_CategoryItem.SelectedValue));
                        gridControl1.DataSource = dt;
                    }
                
                    //calc();
                }
            
                else
            {
                MessageBox.Show("لابد من وجود فرع");
            }
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Btn_Print_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                gridControl1.ShowRibbonPrintPreview();
            }
            else
            {
                MessageBox.Show(" لا يوجد بيانات للطباعة");

            }
        }

        private void cmb_UserBranch_SelectionChangeCommitted(object sender, EventArgs e)
        {
         
           
        }

        private void cmb_UserBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
        //    try
        //    {
        //        gridControl1.DataSource = t.selectTicketsReturn(cmb_UserBranch.Text);
        //        //calc();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        }

        private void rdb_All_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_All.Checked==true)
            {
                gridControl1.DataSource = null;
                Cmb_CategoryItem.Enabled = false;
                Cmb_CategoryItem.SelectedIndex = -1;
            }
        }

        private void rdb_one_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_one.Checked == true)
            {
                gridControl1.DataSource = null;
                Cmb_CategoryItem.DataSource = c.selectCategoryXRaya();
                Cmb_CategoryItem.DisplayMember = "الفئات";
                Cmb_CategoryItem.ValueMember = "ID_CtegoryXrays";
                Cmb_CategoryItem.Enabled = true;
               
            }
        }
    }
}
