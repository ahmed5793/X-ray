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
    public partial class Frm_ReportPaySuppliers : Form
    {
        Suppliers Suppliers = new Suppliers();

        public Frm_ReportPaySuppliers()
        {
            InitializeComponent();
            label2.Hide();
            label7.Hide();
            label4.Hide();
            label5.Hide();
            comboBox2.Hide();
            DateFrom.Hide();
            DateTo.Hide();
            btn_search.Hide();
            gridControl1.DataSource = Suppliers.Report_PaySupplier();
            Calc();
        }
        void Calc()
        {
            decimal total = 0;
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                DataRow row = gridView1.GetDataRow(i);
                total += Convert.ToDecimal(row[1].ToString());

            }
            txt_TotalPurshacing.Text = total.ToString("₱ #,##0.0");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        //    DataTable dt = new DataTable();

        //    try
        //    {
        //        dt.Clear();
        //        dt = Suppliers.Search_PaySupplier(textBox1.Text);
        //        gridControl1.DataSource = dt;
        //        Calc();

        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message);
        //    }
        //    finally
        //    {
        //        dt.Dispose();
        //    }




        }

        private void Frm_ReportPaySuppliers_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
        
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
          
            label2.Show();
            label7.Hide();
            label4.Hide();
            label5.Hide();
            comboBox2.Hide();
            DateFrom.Hide();
            DateTo.Hide();
            btn_search.Hide();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label2.Hide();
            label7.Hide();
            label4.Show();
            label5.Show();
            comboBox2.Hide();
            DateFrom.Show();
            DateTo.Show();
            btn_search.Show();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            comboBox2.DataSource = Suppliers.CompoBoxSuppliers();
            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "Sup_id";
            label2.Hide();
            label7.Show();
            label4.Show();
            label5.Show();
            comboBox2.Show();
            DateFrom.Show();
            DateTo.Show();
            btn_search.Show();
        }

        private void comboBox2_Leave(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                if (comboBox2.Text != "")
                {
                    dt.Clear();
                    dt = Suppliers.Validate_SuppliersName(Convert.ToInt32(comboBox2.SelectedValue));
                    if (dt.Rows.Count == 0)
                    {
                        Console.Beep();
                        MessageBox.Show("هذا الاسم غير موجود فى قائمة الموردين");
                        comboBox2.Focus();
                        comboBox2.SelectAll();
                        return;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DataTable dt5 = new DataTable();
            try
            {
                if (radioButton2.Checked == true)
                {
                    dt5.Clear();
                    dt5 = Suppliers.Search_PaySupplierDate(DateFrom.Value, DateTo.Value);
                    gridControl1.DataSource = dt5;
                }
                else if (radioButton3.Checked == true)
                {
                    if (comboBox2.Text != "")
                    {
                        dt5.Clear();
                        dt5 = Suppliers.Search_PaySupplierDateAndName(comboBox2.Text, DateFrom.Value, DateTo.Value);
                        gridControl1.DataSource = dt5;
                    }
                }
                Calc();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
