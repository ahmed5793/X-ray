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
    public partial class Frm_ExportItemToCompany : Form
    {
        Company cm = new Company();
        ItemsXRaya i = new ItemsXRaya();
        DataTable dt = new DataTable();
        public Frm_ExportItemToCompany()
        {
            InitializeComponent();
            company();
        }
        void company()
        {
            cmb_Company.DataSource = cm.SelectCompany();
            cmb_Company.DisplayMember = "اسم الشركه";
            cmb_Company.ValueMember = "Comp_ID";
            cmb_Company.SelectedIndex = -1;
            dataGridView1.DataSource = i.SelectItemXRaya();

        }
        private void Frm_ExportItemToCompany_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            try
            {

          
       
            if (backgroundWorker1.IsBusy)
            {
                MessageBox.Show("جارى حفظ البيانات");
            }
            else
            {
                progressBar1.Show();



                progressBar1.Maximum = dataGridView1.Rows.Count;
                backgroundWorker1.RunWorkerAsync();
            }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
        }

        private void backgroundWorker1_DoWork_1(object sender, DoWorkEventArgs e)
        {

            try
            {
                if (dataGridView1.Rows.Count > 0)
                {


                    if (cmb_Company.Text != "")
                    {
                        cmb_Company.Enabled = false;
                        dt.Clear();
                        dt = cm.Validate_CompanyNAme(Convert.ToInt32(cmb_Company.SelectedValue));
                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("إسم الشركة غير موجود لا بد من إختيار إسم لشركة من القائمة");
                            cmb_Company.Focus();
                            return;
                        }
                    }

                    if (cmb_Company.Text == "") { MessageBox.Show("لا بد من إختيار إسم الشركة"); return; }
                    DataTable dt1 = new DataTable();

                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {


                        dt1.Clear();
                        dt1 = cm.selectItemCompany(Convert.ToInt32(cmb_Company.SelectedValue), Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value));
                        if (dt1.Rows.Count==0)
                        {

                            cm.Add_Company_ItemsXray(Convert.ToInt32(cmb_Company.SelectedValue), Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value), Convert.ToDecimal(0)
                            , Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value));

                        }
                        else
                        {
                            MessageBox.Show(" تم اضافات الفحوصات الى نفس الشركة من قبل", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            cmb_Company.Enabled = true;
                            return;


                        }



                        backgroundWorker1.ReportProgress(i);

                        if (progressBar1.Value <= dataGridView1.Rows.Count)
                        {

                            progressBar1.Value += 1;

                            label3.Text = progressBar1.Value.ToString() + "/" + dataGridView1.Rows.Count;


                        }

                    }
                

                    MessageBox.Show("تم حفظ الداتا بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    cmb_Company.Enabled = true;
                    progressBar1.Value = 0;
                    label3.Text ="0";
                      
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

        private void backgroundWorker1_RunWorkerCompleted_1(object sender, RunWorkerCompletedEventArgs e)
        {
          

        }
    }
}
