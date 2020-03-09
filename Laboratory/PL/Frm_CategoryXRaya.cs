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
    public partial class Frm_CategoryXRaya : Form
    {
        CategoryXRaya c = new CategoryXRaya();
        public Frm_CategoryXRaya()
        {
            InitializeComponent();
            dataGridView1.DataSource = c.selectCategoryXRaya();
            dataGridView1.Columns[0].Visible = false;
            Btn_Update.Enabled = false;
        }
        private void Frm_CategoryXRaya_Load(object sender, EventArgs e)
        {
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
        }
        private void btn_Update_Click(object sender, EventArgs e)
        {           
        }
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                txt_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                Btn_Add.Enabled = false;
                Btn_Update.Enabled = true;
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = c.searchCategoryXRaya(txt_search.Text);
            dataGridView1.DataSource = dt;
                
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "")
            {
                MessageBox.Show("من فضلك يرجي ادخال قسم الاشعة");
                return;
            }

            c.AddCategoryXRaya(txt_name.Text);
            MessageBox.Show("تم الاضافه  بنجاح", "عمليه الاضافه", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            dataGridView1.DataSource = c.selectCategoryXRaya();
            txt_name.Clear();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Btn_Update.Enabled = true;
            if (txt_name.Text == "")
            {
                MessageBox.Show("من فضلك يرجي ادخال قسم الاشعة");
                return;

            }
            c.UpdateCtegoryXRaya(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value), txt_name.Text);
            MessageBox.Show("تم التعديل  بنجاح", "عمليه التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            dataGridView1.DataSource = c.selectCategoryXRaya();
            txt_name.Clear();
            Btn_Add.Enabled = true;
            Btn_Update.Enabled = false;
        }
    }
}
