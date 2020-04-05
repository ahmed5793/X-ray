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
    public partial class Frm_Branches : Form
    {
        Stock s = new Stock();
        Branches b = new Branches();
        DataTable dt = new DataTable();
        Store st = new Store();

        public Frm_Branches()
        {
            InitializeComponent();
            Function();
        }
        void Function()
        {
            try
            {

                cmb_Stock.DataSource = s.select_Stock();
                cmb_Stock.DisplayMember = "إسم الخزنة";
                cmb_Stock.ValueMember = "رقم الخزنة";

                cmb_store.DataSource = st.Select_ComboStore();
                cmb_store.DisplayMember = "Store_name";
                cmb_store.ValueMember = "id_store";
                dataGridView1.DataSource = b.SelectBranches();
                Btn_Update.Enabled = false;
                dataGridView1.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        
        }
        private void Frm_Branches_Load(object sender, EventArgs e)
        {
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
        
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            dt.Clear();
            dt = b.SearchBranches(txt_search.Text);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count>0)
            {
                Btn_Update.Enabled = true;
                txt_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txt_address.Text= dataGridView1.CurrentRow.Cells[2].Value.ToString();
                cmb_Stock.Text= dataGridView1.CurrentRow.Cells[3].Value.ToString();
                cmb_store.Text= dataGridView1.CurrentRow.Cells[4].Value.ToString();

            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
           
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txt_address.Clear();
            txt_name.Clear();
            Btn_Update.Enabled = false;
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count>3)
                {
                    MessageBox.Show("ليس لديك صلاحية ان تضيف اكتر من ثلاث فروع الرجاء الرجوع الي مسئول النظام");
                    return;
                }
                if (txt_name.Text == "")
                {
                    MessageBox.Show("عزيزى المستخدم قم باادخال اسم الفرع");
                    return;
                }
                if (cmb_Stock.Text == "")
                {
                    MessageBox.Show("عزيزى المستخدم قم بااختياراسم الخزنة");
                    return;
                }
                if (cmb_store.Text == "")
                {
                    MessageBox.Show("عزيزى المستخدم قمبااختيار اسم المخزن");
                    return;
                }
                else
                {
                    b.AddBranches(txt_name.Text, txt_address.Text, Convert.ToInt32(cmb_Stock.SelectedValue), Convert.ToInt32(cmb_store.SelectedValue));
                    MessageBox.Show("تم الاضافة بنجاح");
                    txt_address.Clear();
                    txt_name.Clear();
                    dataGridView1.DataSource = b.SelectBranches();               
                    Btn_Update.Enabled = false;
                }
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_name.Text == "")
                {
                    MessageBox.Show("عزيزى المستخدم قم باادخال اسم الفرع");
                    return;
                }
                if (cmb_Stock.Text == "")
                {
                    MessageBox.Show("عزيزى المستخدم قم بااختياراسم الخزنة");
                    return;
                }
                if (cmb_store.Text == "")
                {
                    MessageBox.Show("عزيزى المستخدم قمبااختيار اسم المخزن");
                    return;
                }
                else
                {
                    b.UpdateBranches(txt_name.Text, txt_address.Text, Convert.ToInt32(cmb_Stock.SelectedValue), Convert.ToInt32(cmb_store.SelectedValue),
                        Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                    MessageBox.Show("تم التعديل بنجاح");
                    txt_address.Clear();
                    txt_name.Clear();
                    dataGridView1.DataSource = b.SelectBranches();                
                    Btn_Update.Enabled = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
