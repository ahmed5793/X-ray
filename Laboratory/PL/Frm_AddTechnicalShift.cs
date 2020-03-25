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
    public partial class Frm_AddTechnicalShift : Form
    {
        Techincal Techincal = new Techincal();
        Branches b = new Branches();
        Users U = new Users();
        DataTable dt = new DataTable();
        public Frm_AddTechnicalShift()
        {
            InitializeComponent();
            Btn_DeleteShift.Enabled = false;
            Btn_UpdateShift.Enabled = false;
            Txt_SalesMAn.Text = Program.salesman;
            comboBox1.DataSource = Techincal.Select_ComboTechnical();
            comboBox1.DisplayMember = "Tech_Name";
            comboBox1.ValueMember = "Techincal_ID";
            comboBox2.DataSource = Techincal.Select_ComboTypeShift();
            comboBox2.DisplayMember = "Type_Shift";
            comboBox2.ValueMember = "ID_Shift";

            Cmb_Branch.DataSource = b.SelectCompBranches();
            Cmb_Branch.DisplayMember = "Name";
            Cmb_Branch.ValueMember = "Branch_ID";
            Cmb_Branch.SelectedIndex = -1 ;
            gridControl1.DataSource = Techincal.Select_TechnicalShift();
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (comboBox1.Text != "")
            {
                dt.Clear();
                dt = Techincal.vildateTechincal(Convert.ToInt32(comboBox1.SelectedValue));
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("يرجي العلم بان اسم الفني غير مسجل من قبل يرجي تسجيل هذا الاسم في شاشه الفني", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                    comboBox1.Focus();
                    comboBox1.SelectAll();
                    return;
                }
                dt.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_TypeShift frm = new Frm_TypeShift();
            try
            {
                frm.ShowDialog();
                comboBox2.DataSource = Techincal.Select_ComboTypeShift();
                comboBox2.DisplayMember = "Type_Shift";
                comboBox2.ValueMember = "ID_Shift";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                frm.Close();
            }
        }

        private void comboBox2_Leave(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (comboBox2.Text != "")
            {
                dt.Clear();
                dt = Techincal.Validate_TypeShift(Convert.ToInt32(comboBox2.SelectedValue));
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("يرجي العلم بان نوع الشيفت غير مسجل من قبل يرجي تسجيل هذا النوع في شاشه نوع الشيفت", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                    comboBox2.Focus();
                    comboBox2.SelectAll();
                    return;
                }
                dt.Dispose();
            }
        }

        private void Btn_AddShift_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
         
        }

        private void Btn_UpdateShift_Click(object sender, EventArgs e)
        {
            
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    dt.Clear();
            //    dt = Techincal.Search_TechnicalShift(txt_search.Text);
            //    dataGridView1.DataSource = dt;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            try
            {
                if (Cmb_Branch.Text == "")
                {
                    MessageBox.Show("يرجى تحديد الفرع الذى عمل به الفنى فى هذا الشيفت");
                    return;
                }
                if (comboBox2.Text == "")
                {
                    MessageBox.Show("يرجى تحديد نوع الشيفت");
                    return;
                }
                if (Txt_Cost.Text == "0" || Txt_Cost.Text == "")
                {
                    MessageBox.Show("يرجى تحديد سعر الشيفت");
                    return;
                }
               
                if (comboBox1.Text != "" && comboBox2.Text != "")
                {
                    Techincal.Add_TechnicalShift(Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(comboBox2.SelectedValue),
                       (dateTimePicker1.Text), (dateTimePicker3.Text), (dateTimePicker2.Text), Convert.ToDecimal(Txt_Cost.Text)
                         , Txt_SalesMAn.Text, Convert.ToInt32(Cmb_Branch.SelectedValue));
                    MessageBox.Show("تم إضافة الشيفت بنجاح");
                    Txt_Cost.Text = "0";
                    gridControl1.DataSource = Techincal.Select_TechnicalShift();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "")
                {
                    MessageBox.Show("لا بد من تحديد إسم الفنى ");
                    return;
                }
                if (comboBox2.Text == "")
                {
                    MessageBox.Show("لا بد من تحديد نوع الشيفت ");
                    return;
                }
                if (Cmb_Branch.Text == "")
                {
                    MessageBox.Show("يرجى تحديد الفرع الذى عمل به الفنى فى هذا الشيفت");
                    return;
                }
                if (Txt_Cost.Text == "0" || Txt_Cost.Text == "")
                {
                    MessageBox.Show("يرجى تحديد سعر الشيفت");
                    return;
                }
                if (MessageBox.Show("هل تريد تعديل الشيفت", "عملية التعديل", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Techincal.Update_TechnicalShift(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الشيفت")), Convert.ToInt32(comboBox1.SelectedValue),
                        Convert.ToInt32(comboBox2.SelectedValue), (dateTimePicker1.Text), (dateTimePicker3.Text),
                        (dateTimePicker2.Text), Convert.ToDecimal(Txt_Cost.Text), Txt_SalesMAn.Text, Convert.ToInt32(Cmb_Branch.SelectedValue));
                    MessageBox.Show("تم تعديل الشيفت بنجاح", "عملية التعديل");

                }
                else
                {
                    MessageBox.Show("تم إلغاء تعديل الشيفت ", "عملية التعديل");

                }
                Txt_Cost.Text = "0";
                gridControl1.DataSource = Techincal.Select_TechnicalShift();
                comboBox1.Enabled = true;
                Btn_AddShift.Enabled = true;
                gridControl1.Enabled = true;
                Btn_UpdateShift.Enabled = false;
                Btn_DeleteShift.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void simpleButton1_Click_2(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("هل تريد مسح الشيفت", "عملية المسح", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Techincal.Delete_TechnicalShift(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الشيفت")));
                    MessageBox.Show("تم مسح الشيفت بنجاح");
                }
                else
                {
                    MessageBox.Show("تم إلغاء مسح الشيفت ");
                }

                Txt_Cost.Text = "0";
                gridControl1.DataSource = Techincal.Select_TechnicalShift();
                comboBox1.Enabled = true;
                Btn_AddShift.Enabled = true;
                gridControl1.Enabled = true;
                Btn_UpdateShift.Enabled = false;
                Btn_DeleteShift.Enabled = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (gridView1.RowCount > 0 && gridView1.SelectedRowsCount > 0)
                {
                    comboBox1.Enabled = false;
                    Btn_AddShift.Enabled = false;
                    Btn_UpdateShift.Enabled = true;
                    Btn_DeleteShift.Enabled = true;
                    gridControl1.Enabled = false;
                    
                    comboBox1.Text = gridView1.GetFocusedRowCellValue("إسم الفنى").ToString();
                    comboBox2.Text = gridView1.GetFocusedRowCellValue("نوع الشيفت").ToString();
                    Txt_Cost.Text = gridView1.GetFocusedRowCellValue("سعر الشيفت").ToString();
                    Cmb_Branch.Text = gridView1.GetFocusedRowCellValue("الفرع").ToString();
                    dateTimePicker1.Value = Convert.ToDateTime(gridView1.GetFocusedRowCellValue("تاريخ الشيفت"));
                    dateTimePicker3.Value = Convert.ToDateTime(gridView1.GetFocusedRowCellValue("من وقت"));
                    dateTimePicker2.Value = Convert.ToDateTime(gridView1.GetFocusedRowCellValue("إلى وقت"));

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
