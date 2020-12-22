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
    public partial class Frm_Masrofat : Form
    {
        Masrofat m = new Masrofat();
        Stock s = new Stock();
        Users u = new Users();
        Branches b = new Branches();
        private static Frm_Masrofat farm;
        static void STATUESCllosed(object sender, FormClosedEventArgs e)
        {
            farm = null;
        }
        public static Frm_Masrofat getmain
        {
            get
            {
                if (farm == null)
                {
                    farm = new Frm_Masrofat();
                    farm.FormClosed += new FormClosedEventHandler(STATUESCllosed);
                }
                return farm;
            }
        }
        void Permision()
        {
           


         

                dt.Clear();
                dt = u.SelectUserBranch(txt_username.Text);

                if (dt.Rows.Count > 0)
                {
                    cmb_UserBranch.Enabled = true;
                    cmb_UserBranch.DataSource = u.SelectUserBranch(txt_username.Text);
                    cmb_UserBranch.DisplayMember = "Name";
                    cmb_UserBranch.ValueMember = "Branch_ID";
                    cmb_UserBranch.SelectedIndex = -1;

                    cmb_Stock.DataSource = s.SelectStockBranch(Convert.ToInt32(cmb_UserBranch.SelectedValue));
                    cmb_Stock.DisplayMember = "Name_Stock";
                    cmb_Stock.ValueMember = "ID_Stock";
                }
            
            else
            {
                //cmb_UserBranch.DataSource = b.SelectCompBranches();
                //cmb_UserBranch.DisplayMember = "Name";
                //cmb_UserBranch.ValueMember = "Branch_ID";
                //cmb_UserBranch.SelectedIndex = -1;
                Stock();
                
                
                cmb_UserBranch.Enabled = false;
              

            }
        }
        void Stock()
        {

            cmb_Stock.DataSource = s.Compo_Stock();
            cmb_Stock.DisplayMember = "Name_Stock";
            cmb_Stock.ValueMember = "ID_Stock";
            cmb_Stock.SelectedIndex = -1;

        }
        void SelectMasrofatType()
        {
            comboBox1.DataSource = m.SelectReserve();
            comboBox1.DisplayMember = "masrof_type";
            comboBox1.ValueMember = "ID_masrof";

        }
        public Frm_Masrofat()
        {
            InitializeComponent();

            if (farm == null)
            {
                farm = this;
            }
            Function();
        }
        void Function()
        {
            try
            {

                txt_username.Text = Program.salesman;
                SelectMasrofatType();
                Permision();

                gridControl1.DataSource = m.SelectReserveDetails();


                textBox1.Hide();
                Btn_Delete.Enabled = false;
                Btn_Update.Enabled = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_GenderJob_Click(object sender, EventArgs e)
        {
            Frm_MasrofGender g = new Frm_MasrofGender();
            g.ShowDialog();
            comboBox1.DataSource = m.SelectReserve();
            g.Dispose();
        }
        DataTable dt = new DataTable();
        private void btn_save_Click(object sender, EventArgs e)
        {
           
        }

        private void Frm_Masrofat_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        
        }

        private void txt_amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && txt_amount.Text.ToString().IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                e.Handled = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (MessageBox.Show("هل تريد تعديل المصروف","تعديل المصروف",MessageBoxButtons.YesNo , MessageBoxIcon.Question)==DialogResult.Yes)
            //    {
            //        m.UpdateResrveDetails(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),Convert.ToInt32(comboBox1.SelectedValue),
            //            txt_notes.Text, Convert.ToDecimal(txt_amount.Text),dateTimePicker1.Value,Convert.ToInt32(cmb_Stock.SelectedValue),txt_username.Text);
            //        MessageBox.Show("تم تعديل المصروف بنجاح");
            //    }
            //    else
            //    {
            //        MessageBox.Show("تم إلغاء تعديل المصروف ");
            //    }
            //    dataGridView1.DataSource = m.SelectReserveDetails();
            //    txt_notes.Clear();
            //    txt_amount.Clear();
            //    textBox1.Clear();
            //    Btn_Delete.Enabled = false;
            //    Btn_Update.Enabled = false;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void Btn_New_Click(object sender, EventArgs e)
        {
            

        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
           
        }
        void clear()
        {
            txt_notes.Clear();
            txt_amount.Clear();
            textBox1.Clear();
            Btn_Delete.Enabled = false;
            Btn_Update.Enabled = false;
            Btn_Add.Enabled = true;
            cmb_Stock.Enabled = true;
            txt_amount.Enabled = true;
            dateTimePicker1.Value = DateTime.Now;
            cmb_UserBranch.Enabled = true;
            cmb_Stock.Enabled = true;
            dateTimePicker1.Enabled = true;

        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_amount.Text == "" || txt_amount.Text=="0")
                {
                    MessageBox.Show("من فضلك ادخال المبلغ ");
                    return;
                }
                if (cmb_Stock.Text == "")
                {
                    MessageBox.Show("لا بد من تحديد الخزنة ");
                    return;
                }
                //if (cmb_UserBranch.Text=="")
                //{
                //    MessageBox.Show("لا بد من تحديد الفرع ");
                //    return;
                //}
              
                if (comboBox1.Text == "")
                {
                    MessageBox.Show("لا بد من تحديد نوع المصروف ");
                    return;
                }
                dt.Clear();
                dt = s.Select_moneyStock(Convert.ToInt32(cmb_Stock.SelectedValue));
                if (dt.Rows.Count > 0)
                {
                    if (Convert.ToDecimal(txt_amount.Text) > Convert.ToDecimal(dt.Rows[0][0]))
                    {
                        MessageBox.Show("رصيد الخزنة الحالى غير كافى ");
                        return;
                    }
                }
                if (comboBox1.Text != string.Empty)
                {
                    
                   
                        m.AddReserveDetails(Convert.ToInt32(comboBox1.SelectedValue), txt_notes.Text,
                        Convert.ToDecimal(txt_amount.Text), dateTimePicker1.Value, Convert.ToInt32(cmb_Stock.SelectedValue),
                        txt_username.Text);
                    
                 
                    s.Add_StockPull(Convert.ToInt32(cmb_Stock.SelectedValue), Convert.ToDecimal(txt_amount.Text), dateTimePicker1.Value, txt_username.Text, "مصروفات " + "لل" + comboBox1.Text);
                    MessageBox.Show("تم التسجيل بنجاح", "عمليه التسجيل");
                    gridControl1.DataSource = m.SelectReserveDetails();
                    clear();
                }
                else
                {
                    MessageBox.Show("من فضلك قم بااختيار نوع المصروف");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmb_UserBranch_SelectionChangeCommitted(object sender, EventArgs e)
        {

            dt.Clear();
            dt = u.SelectUserBranch(txt_username.Text);

            if (dt.Rows.Count > 0)
            {
                

                cmb_Stock.DataSource = s.SelectStockBranch(Convert.ToInt32(cmb_UserBranch.SelectedValue));
                cmb_Stock.DisplayMember = "Name_Stock";
                cmb_Stock.ValueMember = "ID_Stock";
            }

            else
            {
                //cmb_UserBranch.DataSource = b.SelectCompBranches();
                //cmb_UserBranch.DisplayMember = "Name";
                //cmb_UserBranch.ValueMember = "Branch_ID";
                //cmb_UserBranch.SelectedIndex = -1;
                Stock();


                cmb_UserBranch.Enabled = false;


            }


            //cmb_Stock.DataSource = s.SelectStockBranch(Convert.ToInt32(cmb_UserBranch.SelectedValue));
            //cmb_Stock.DisplayMember = "Name_Stock";
            //cmb_Stock.ValueMember = "ID_Stock";
        }

        private void cmb_UserBranch_SelectedIndexChanged(object sender, EventArgs e)
        {

            cmb_Stock.DataSource = s.SelectStockBranch(Convert.ToInt32(cmb_UserBranch.SelectedValue));
            cmb_Stock.DisplayMember = "Name_Stock";
            cmb_Stock.ValueMember = "ID_Stock";
        }

        private void Btn_Update_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("هل تريد مسح المصروف", "مسح المصروف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    s.add_insertStock(Convert.ToInt32(cmb_Stock.SelectedValue), Convert.ToDecimal(txt_amount.Text), DateTime.Now, txt_username.Text, "مسح مصروف " + " " + comboBox1.Text + " " + "من شاشة المصروفات");
                   m.DeleteReserveDetails(Convert.ToInt32(textBox1.Text));
                    MessageBox.Show("تم مسح المصروف بنجاح");
                }
                else
                {
                    MessageBox.Show("تم إلغاء مسح المصروف ");
                }
                gridControl1.DataSource = m.SelectReserveDetails();
                clear();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void txt_amount_MouseMove(object sender, MouseEventArgs e)
        {
            if (txt_amount.Text=="")
            {
                txt_amount.Text = "0";
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            try
            {

                if (gridView1.RowCount > 0)
                {
                    Btn_Delete.Enabled = true;
                    Btn_Update.Enabled = true;
                    Btn_Add.Enabled = false;
                    cmb_Stock.Enabled = false;
                    cmb_UserBranch.Enabled = false;
                    txt_amount.Enabled = false;
                    dateTimePicker1.Enabled = false;
                    textBox1.Text = gridView1.GetFocusedRowCellValue("رقم المصروف").ToString();
                    comboBox1.Text = gridView1.GetFocusedRowCellValue("نوع المصروف").ToString();
                    txt_notes.Text = gridView1.GetFocusedRowCellValue("ملاحظات").ToString();
                    txt_amount.Text = gridView1.GetFocusedRowCellValue("المبلغ").ToString();
                    cmb_Stock.Text = gridView1.GetFocusedRowCellValue("إسم الخزنة").ToString();
                    dateTimePicker1.Text = gridView1.GetFocusedRowCellValue("التاريخ").ToString();
                    textBox1.Text = gridView1.GetFocusedRowCellValue("رقم المصروف").ToString();

                    // cmb_UserBranch.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void Btn_Update_Click_2(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("هل تريد تعديل المصروف", "تعديل المصروف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    m.UpdateMasrofatDetails(Convert.ToInt32(textBox1.Text), Convert.ToInt32(comboBox1.SelectedValue),txt_notes.Text);
                    MessageBox.Show("تم تعديل المصروف بنجاح");
                }
                else
                {
                    MessageBox.Show("تم إلغاء تعديل المصروف ");
                }
                gridControl1.DataSource = m.SelectReserveDetails();
                clear();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }
    }
}
