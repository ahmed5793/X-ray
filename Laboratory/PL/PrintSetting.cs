using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using Laboratory.BL;

namespace Laboratory.PL
{
    public partial class PrintSetting : Form
    {
        DataTable dt = new DataTable();
        Users u = new Users();
        public PrintSetting()
        {
            InitializeComponent();
          
            

            print();
            GetSetting();

        }

        void GetSetting()
        {
            cmb_barcode.Text = Properties.Settings.Default.PrintNameBarcode;


            cmb_invoice.Text = Properties.Settings.Default.PrintNameInvoice;
        }
        void saveSetting()
        {
            Properties.Settings.Default.PrintNameBarcode = cmb_barcode.Text;


            Properties.Settings.Default.PrintNameInvoice = cmb_invoice.Text;
            Properties.Settings.Default.Save();
        }
        
        void print()
        {
            try
            {
                foreach (string item in PrinterSettings.InstalledPrinters)
                {

                    cmb_barcode.Items.Add(item);
                    cmb_invoice.Items.Add(item);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }
           
        private void PrintSetting_Load(object sender, EventArgs e)
        {
            lable1.Hide();
            cmb_invoice.Hide();
        }
   
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (cmb_barcode.Text=="")
            {
                MessageBox.Show("يرجي اختيار طابعه لطابعه الباركود");
                return;
            }
            //if (cmb_invoice.Text == "")
            
            //{
            //        MessageBox.Show("يرجي اختيار طابعه لطابعه الفاتورة");
            //        return;
            //}
            else
            {
                //    cmb_barcode.Text = Properties.Settings.Default.PrintNameBarcode;
                //    cmb_barcode.Text = Properties.Settings.Default.PrintNameInvoice;

                saveSetting();
                MessageBox.Show("تم الحفظ بنجاح");
                cmb_barcode.SelectedIndex = -1;
                cmb_invoice.SelectedIndex = -1;



            }
           

        }
    }
}
