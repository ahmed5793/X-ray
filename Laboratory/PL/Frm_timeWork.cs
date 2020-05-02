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
    public partial class Frm_timeWork : Form
    {
        Finger f = new Finger();
        public Frm_timeWork()
        {
            InitializeComponent();
            //gridControl1.DataSource = f.selectReservations_dates();
            gridView1.Columns["id"].Visible = false;
            Btn_update.Enabled = false;
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            try
            {

          
            if (cmb_Company.Text=="")
            {
                MessageBox.Show("يرجي اختيار نوع الشيفت");
                return;
            }
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                DataRow row = gridView1.GetDataRow(i);
                if (cmb_Company.Text == row[1].ToString())
                {
                    MessageBox.Show("لايمكن تسجيل نفس الشيفت مرة اخرى");
                    return;
                }
            }

          

            f.AddReservationsdates(Convert.ToDateTime(dateTimePicker2.Value.ToString("hh:mm tt")), Convert.ToDateTime(dateTimePicker1.Value.ToString("hh:mm tt")),cmb_Company.Text);
            MessageBox.Show("تم الحفظ بنجاح");
            //gridControl1.DataSource = f.selectReservations_dates();
            cmb_Company.Enabled = true;
            Btn_Add.Enabled = true;
            Btn_update.Enabled = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_update_Click(object sender, EventArgs e)
        {
            try
            {

            

            f.UpdateReservationsdates(Convert.ToDateTime(dateTimePicker2.Value),
                Convert.ToDateTime(dateTimePicker1.Value), cmb_Company.Text,Convert.ToInt32(gridView1.GetFocusedRowCellValue("id")));
            MessageBox.Show("تم التعديل بنجاح");
            //gridControl1.DataSource = f.selectReservations_dates();
                cmb_Company.Enabled = true;
                Btn_Add.Enabled = true;
                Btn_update.Enabled = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
           

            try
            {
                if (gridView1.RowCount > 0)
                {


                    cmb_Company.Enabled = false;
                    Btn_Add.Enabled = false;
                    Btn_update.Enabled = true;
                    cmb_Company.Text = gridView1.GetFocusedRowCellValue("نوع الشيفت").ToString();
                    dateTimePicker2.Text = gridView1.GetFocusedRowCellValue("حضور").ToString();
                    dateTimePicker1.Text = gridView1.GetFocusedRowCellValue("انصراف").ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
