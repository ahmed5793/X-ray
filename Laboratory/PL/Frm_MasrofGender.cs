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
    public partial class Frm_MasrofGender : Form
    {
        Masrofat m = new Masrofat();
        public Frm_MasrofGender()
        {
            InitializeComponent();
            selectMasrof();
        }
        void selectMasrof()
        {
            try
            {
                gridControl2.DataSource = m.selectmasrofatType();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                m.UpdatemasrofatType(txt_name.Text, Convert.ToInt32(gridView2.GetFocusedRowCellValue("ID_masrof")));
                MessageBox.Show("تم التعديل بنجاح","تعديل ",MessageBoxButtons.OK,MessageBoxIcon.Information);
                gridControl2.DataSource = m.selectmasrofatType();
                txt_name.Clear();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            if (txt_name.Text != string.Empty)
            {
                m.AddReserve(txt_name.Text);
                MessageBox.Show("تم التسجيل بنجاح", "عمليه التسجيل", MessageBoxButtons.OK);

                Frm_Masrofat.getmain.comboBox1.DataSource = m.SelectReserve();

                Frm_Masrofat.getmain.comboBox1.DisplayMember = "masrof_type";
                Frm_Masrofat.getmain.comboBox1.ValueMember = "ID_masrof";
               // this.Close();
            }

            else
            {
                MessageBox.Show("من فضلك لابد من كتابه نوع المصروف");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Frm_MasrofGender_Load(object sender, EventArgs e)
        {

        }

        private void gridControl2_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (gridView2.RowCount>0)
                {
                   
                    btn_save.Enabled = false;
                    btn_remove.Enabled = true;
                    btn_update.Enabled = true;
                 
                    txt_name.Text = gridView2.GetFocusedRowCellValue("masrof_type").ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            try
            {
                m.DeleteemasrofatType(Convert.ToInt32(gridView2.GetFocusedRowCellValue("ID_masrof")));
                MessageBox.Show("تم المسح بنجاح", "تعديل ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gridControl2.DataSource = m.selectmasrofatType();
                txt_name.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("من فضلك قم بمسح تفاصيل المصروف من شاشه الصمروفات قبل مسح نوع المصروف");
                MessageBox.Show(ex.Message);
                

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                btn_save.Enabled = true;
                btn_remove.Enabled = false;
                btn_update.Enabled = false;
                txt_name.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
