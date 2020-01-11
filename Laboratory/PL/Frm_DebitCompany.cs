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
    public partial class Frm_DebitCompany : Form
    {

        Company cm = new Company();
        DataTable dt = new DataTable();

        public Frm_DebitCompany()
        {
            InitializeComponent();
            company();
            button1.Hide();
        }
        void company()
        {

            cmb_Company.DataSource = cm.SelectCompany();
            cmb_Company.DisplayMember = "اسم الشركه";
            cmb_Company.ValueMember = "Comp_ID";
        }
        //void Calc()
        //{
        //    decimal Total = 0;
        //    for (int i = 0; i < dataGridView1.Rows.Count; i++)
        //    {
        //        Total += Convert.ToDecimal(dataGridView1.Rows[i].Cells[8].Value);
        //    }
        //    textBox1.Text = Math.Round(Total, 1).ToString();
        //}
      
        private void cmb_Company_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_Company.Text != "")
                {
                    dt.Clear();
                    dt = cm.Search_DebitCompany(Convert.ToInt32(cmb_Company.SelectedValue), DateFrom.Value, DateTo.Value);
                    dataGridView1.DataSource = dt;
                    if (dataGridView1.Rows.Count == 0)
                    {
                        button1.Hide();
                    }
                    else
                    {
                        button1.Show();
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void cmb_Company_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
        }

        private void Frm_DebitCompany_Load(object sender, EventArgs e)
        {
        }

        private void cmb_Company_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (cmb_Company.Text != "")
                {
                    dt.Clear();
                    dt = cm.Select_DebitCompany(Convert.ToInt32(cmb_Company.SelectedValue));
                    dataGridView1.DataSource = dt;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void cmb_Company_Leave(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
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
            finally
            {
                dt2.Dispose();
            }
        }
    }
}
