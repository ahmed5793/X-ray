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
    public partial class Frm_ProductList : Form
    {
        Product Product = new Product();
        public Frm_ProductList()
        {
            InitializeComponent();
            dataGridView1.DataSource = Product.Select_Product();

        }

        private void Btn_selectProduct_Click(object sender, EventArgs e)
        {

        }

        private void Btn_selectProduct_MouseClick(object sender, MouseEventArgs e)
        {
            dataGridView1.DataSource = null;
            this.Close();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {

                dt.Clear();
                dt = Product.Search_Product(textBox1.Text);
                dataGridView1.DataSource = dt;
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

        private void Btn_Update_MouseClick(object sender, MouseEventArgs e)
        {
            dataGridView1.DataSource = null;
            this.Close();
        }
    }
}
