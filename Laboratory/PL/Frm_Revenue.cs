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
    public partial class Frm_Revenue : Form
    {
        Masrofat m = new Masrofat();
        Users u = new Users();
        Branches b = new Branches();
        Tickets t = new Tickets();
        DataTable dt10 = new DataTable();
        void Calc_Total()
        {
            decimal total = 0;

            for (int i = 0; i < gridView1.RowCount; i++)
            {
                DataRow row = gridView1.GetDataRow(i);
                total += Convert.ToDecimal(row[2].ToString());

            }
            Txt_Total.Text = total.ToString();

        }
        void Calc_Masrofat()
        {
            decimal total = 0;
            for (int i = 0; i < dt10.Rows.Count; i++)
            {
                total += Convert.ToDecimal(dt10.Rows[i][2]);

            }
            Txt_Masrofat.Text = total.ToString();
        }
        public Frm_Revenue()
        {
            InitializeComponent();
            txt_username.Text = Program.salesman;
            Permision();
        }
        void Permision()
        {
            try
            {
                dt10.Clear();
                dt10 = u.SelectUserBranch(txt_username.Text);

                if (dt10.Rows.Count > 0)
                {
                    cmb_branches.DataSource = u.SelectUserBranch(txt_username.Text);
                    cmb_branches.DisplayMember = "Name";
                    cmb_branches.ValueMember = "Branch_ID";
                }
                else
                {
                    cmb_branches.DataSource = b.SelectCompBranches();
                    cmb_branches.DisplayMember = "Name";
                    cmb_branches.ValueMember = "Branch_ID";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_branches.Text!="")
                {
                    gridControl1.DataSource = t.Report_StockMoneyCategoryXray(cmb_branches.Text, FromDate.Value, ToDate.Value);
                    dt10.Clear();
                    dt10 = m.search_AllMasrofatBranch(FromDate.Value, ToDate.Value, Convert.ToInt32(cmb_branches.SelectedValue));
                    Calc_Masrofat();
                    Calc_Total();
                    textBox1.Text = (Convert.ToDecimal(Txt_Total.Text) - Convert.ToDecimal(Txt_Masrofat.Text)).ToString();

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
    }
}
