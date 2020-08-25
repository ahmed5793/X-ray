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
    public partial class Report_StoreProduct : Form
    {
        Product product = new Product();
        public Report_StoreProduct()
        {
            InitializeComponent();
            Select_Product();
        }
        void Select_Product()
        {
            try
            {
                gridControl1.DataSource = product.Select_StoreProduct();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void Report_StoreProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
