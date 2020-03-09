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
    public partial class Frm_SearchSupplierInformation : Form
    {
        Suppliers Suppliers = new Suppliers();
        Frm_ReturnSupplier frm_Return = new Frm_ReturnSupplier();
        public Frm_SearchSupplierInformation()
        {
            InitializeComponent();
            Cmb_Suppliers.DataSource = Suppliers.CompoBoxSuppliers();
            Cmb_Suppliers.DisplayMember = "Name";
            Cmb_Suppliers.ValueMember = "Sup_id";
        }
        void Clear()
        {
            frm_Return.txt_Name.Clear();
            frm_Return.txt_names.Clear();
            frm_Return.txt_num.Clear();
            frm_Return.txt_prise.Clear();
            frm_Return.txt_quantity.Clear();
            frm_Return.txt_sales.Clear();
            frm_Return.txt_total.Clear();
            frm_Return.textBox4.Text = "0";
            frm_Return.Txt_QuantityStore.Text = "0";
            //frm_Return.dt10.Clear();
        }
        private void Cmb_Suppliers_Leave(object sender, EventArgs e)
        {
            DataTable dt = new DataTable(); 
            try
            {
                if (Cmb_Suppliers.Text!="")
                {
                    dt.Clear();
                    dt = Suppliers.Validate_SuppliersName(Convert.ToInt32(Cmb_Suppliers.SelectedValue));
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("هذا الاسم غير موجود فى قائمة الموردين");
                        Cmb_Suppliers.Focus();
                        Cmb_Suppliers.SelectAll();
                        return;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Cmb_Suppliers_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (Cmb_Suppliers.Text != "")
                {
                    dataGridView1.DataSource = Suppliers.SelectSupplierInovice(Convert.ToInt32(Cmb_Suppliers.SelectedValue));
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_SearchSupplierInformation_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_prod_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
