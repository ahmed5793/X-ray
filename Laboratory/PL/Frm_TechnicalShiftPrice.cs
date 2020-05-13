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
    public partial class Frm_TechnicalShiftPrice : Form
    {
        Techincal Techincal = new Techincal();
        DataTable dt = new DataTable();

        public Frm_TechnicalShiftPrice()
        {
            InitializeComponent();
            Function();
        }
        void Function()
        {
            try
            {
                Btn_UpdateShift.Enabled = false;
                comboBox1.DataSource = Techincal.Select_ComboTechnical();
                comboBox1.DisplayMember = "Tech_Name";
                comboBox1.ValueMember = "Techincal_ID";
                comboBox1.SelectedIndex = -1;

                comboBox2.DataSource = Techincal.Select_ComboTypeShift();
                comboBox2.DisplayMember = "Type_Shift";
                comboBox2.ValueMember = "ID_Shift";
                comboBox2.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            gridControl1.DataSource = Techincal.Select_TechnicalShiftPrice(Convert.ToInt32(comboBox1.SelectedValue));

        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
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

        private void comboBox2_Leave(object sender, EventArgs e)
        {
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
                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                frm.Close();
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (gridView1.RowCount>0)
                {
                    comboBox1.Enabled = false;
                    comboBox2.Enabled = true;
                    Btn_AddShift.Enabled = false;
                    Btn_UpdateShift.Enabled = true;
                    comboBox1.Text = gridView1.GetFocusedRowCellValue(" إسم الفنى").ToString();
                    comboBox2.Text = gridView1.GetFocusedRowCellValue("نوع الشيفت").ToString();
                    Txt_Cost.Text = gridView1.GetFocusedRowCellValue("السعر").ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Txt_Cost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && Txt_Cost.Text.ToString().IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void Txt_Cost_Click(object sender, EventArgs e)
        {
            if (Txt_Cost.Text == "0")
            {
                Txt_Cost.Text = "";
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Txt_Cost.Text = "0";
            comboBox2.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;
            gridControl1.DataSource = null;
            comboBox1.Enabled = true;
            Btn_AddShift.Enabled = true;
            gridControl1.Enabled = true;
            Btn_UpdateShift.Enabled = false;
         
        }

        private void Btn_AddShift_Click(object sender, EventArgs e)
        {
            try
            {
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
                    for (int i = 0; i < gridView1.RowCount; i++)
                    {
                        DataRow row = gridView1.GetDataRow(i);
                        if (comboBox1.Text == row[0].ToString() &&
                            comboBox2.Text == row[1].ToString())
                        {
                            MessageBox.Show("تم إضافة هذا الشيفت  لنفس الفني من قبل ");
                            return;
                        }
                    }

                    Techincal.add_TechnicalShiftPrice(Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(comboBox2.SelectedValue),
                        Convert.ToDecimal(Txt_Cost.Text));
                    MessageBox.Show("تم إضافة الشيفت بنجاح");
                    Txt_Cost.Text = "0";
                    comboBox2.SelectedIndex = -1;
                    comboBox1.SelectedIndex = -1;
                    gridControl1.DataSource = Techincal.Select_TechnicalShiftPrice(Convert.ToInt32(comboBox1.SelectedValue));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void Btn_UpdateShift_Click(object sender, EventArgs e)
        {
            try
            {
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
                   
                    Techincal.Update_TechnicalShiftPrice(Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(comboBox2.SelectedValue),
                        Convert.ToDecimal(Txt_Cost.Text));
                    MessageBox.Show("تم تعديل الشيفت للفننى بنجاح");
                    Txt_Cost.Text = "0";
                    comboBox2.SelectedIndex = -1;
                    comboBox1.SelectedIndex = -1;
                    gridControl1.DataSource = Techincal.Select_TechnicalShiftPrice(Convert.ToInt32(comboBox1.SelectedValue));
                    Btn_AddShift.Enabled = true;
                    Btn_UpdateShift.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }
    }
}
