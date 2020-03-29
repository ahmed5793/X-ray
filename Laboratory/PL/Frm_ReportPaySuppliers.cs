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
        DataTable dt5 = new DataTable();
        DataTable dt = new DataTable();
        public Frm_ReportPaySuppliers()
        {
            InitializeComponent();

            comboBox2.DataSource = Suppliers.CompoBoxSuppliers();
            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "Sup_id";
        }
        //void Calc()
        //{
        //    decimal total = 0;
        //    for (int i = 0; i < gridView1.RowCount; i++)
        //    {
        //        DataRow row = gridView1.GetDataRow(i);
        //        total += Convert.ToDecimal(row[1].ToString());
        //    }
        //    txt_TotalPurshacing.Text = total.ToString("₱ #,##0.0");
        //}

        private void comboBox2_Leave(object sender, EventArgs e)
        {
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
                        textBox1.Clear();
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }
        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            gridControl1.DataSource = Suppliers.Report_PaySupplier(Convert.ToInt32(comboBox2.SelectedValue));
            dt5.Clear();
            dt5 = Suppliers.Select_SupplierTotalMoney(Convert.ToInt32(comboBox2.SelectedValue));
            textBox1.Text = dt5.Rows[0][0].ToString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox2.Text != "")
                {
                    dt5.Clear();
                    dt5 = Suppliers.Search_PaySupplierDateAndName(Convert.ToInt32(comboBox2.SelectedValue), DateFrom.Value, DateTo.Value);
                    if (dt5.Rows.Count>0)
                    {
                        gridControl1.DataSource = dt5;
                    }
                    else
                    {
                        gridControl1.DataSource = null;
                        MessageBox.Show("لا يوجد معاملات فى هذه الفتره");
                        return;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }

        }

        private void Btn_Print_Click(object sender, EventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {


            gridControl1.DataSource = Suppliers.Report_PaySupplier(Convert.ToInt32(comboBox2.SelectedValue));
            dt5.Clear();
            dt5 = Suppliers.Select_SupplierTotalMoney(Convert.ToInt32(comboBox2.SelectedValue));
            textBox1.Text = dt5.Rows[0][0].ToString();
        }
    }
}
