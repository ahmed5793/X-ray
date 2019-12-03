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
    public partial class Tranfair_product : Form
    {
        Store Store = new Store();
        Product Product = new Product();
        DataTable dt = new DataTable();
        public Tranfair_product()
        {
            InitializeComponent();
            Cmb_FromStore.DataSource = Store.Select_ComboStore();
            Cmb_FromStore.DisplayMember = "Store_name";
            Cmb_FromStore.ValueMember = "id_store";

            Cmb_ToStore.DataSource = Store.Select_ComboStore();
            Cmb_ToStore.DisplayMember = "Store_name";
            Cmb_ToStore.ValueMember = "id_store";

             txt_num.Text =Product.Select_LastIdTransfair().Rows[0][0].ToString();

            SelectdataTable();
            Rezizse();
        }
        void SelectdataTable()
        {
            dt.Columns.Add("رقم الصنف");
            dt.Columns.Add("اسم الصنف");
            dt.Columns.Add("الكميه المحولة");   
            DataGridView1.DataSource = dt;
        }
        void Rezizse()
        {
            DataGridView1.RowHeadersWidth = 20;
            DataGridView1.Columns[0].Width = 60;
            DataGridView1.Columns[1].Width = 250;
            DataGridView1.Columns[2].Width = 158;

    
        }

        private void Cmb_FromStore_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Cmb_ProdName.DataSource = Product.Select_ComboTransfairProductT(Convert.ToInt32(Cmb_FromStore.SelectedValue));
            Cmb_ProdName.DisplayMember = "Product_Name";
            Cmb_ProdName.ValueMember = "Id_Product";
 
        }

        private void Cmb_ProdName_Enter(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            try
            {
                if (Cmb_ProdName.Text!=string.Empty)
                {
                    dt1.Clear();
                    dt1 = Product.Select_ComboTransfairProductT(Convert.ToInt32(Cmb_FromStore.SelectedValue));
                    if (Convert.ToInt32(DataGridView1.CurrentRow.Cells[0].Value)==Convert.ToInt32(Cmb_ProdName.SelectedValue))
                    {
                        if (Convert.ToInt32(DataGridView1.CurrentRow.Cells[0].Value) == Convert.ToInt32(Cmb_ProdName.SelectedValue))
                        {
                            if (Convert.ToInt32(DataGridView1.CurrentRow.Cells[2].Value) >= Convert.ToInt32(dt.Rows[0][2]))
                            {

                                MessageBox.Show(" الكميه المدخله لهذا الصنف غير متاحه", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            else
                            {
                                int x = 1;                                
                               DataGridView1.CurrentRow.Cells[2].Value = Convert.ToInt32(DataGridView1.CurrentRow.Cells[2].Value) + x;
                                Console.Beep();
                            }

                        }
                    }
                    DataRow dr =dt.NewRow();
                    dr[0] = Cmb_ProdName.SelectedValue;
                    dr[1] = Cmb_ProdName.Text;
                    dr[2] = 1;
                    dt.Rows.Add(dr);
                    DataGridView1.DataSource = dt;
                    Console.Beep();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message) ;
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            txt_num.Text = Product.Select_LastIdTransfair().Rows[0][0].ToString();
            Txt_note.Clear();
            dt.Clear();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cmb_FromStore.Text==string.Empty && Cmb_ToStore.Text==string.Empty)
                {
                    MessageBox.Show("لا بد من وجود مخزن للتحويل");
                    return; 
                }
                if (Cmb_ProdName.Text==string.Empty && DataGridView1.Rows.Count==0)
                {
                    MessageBox.Show("لابد من وجود صنف واحد على الاقل ");
                    return;
                }
                else
                {

                 Product.add_TransFairProduct(Convert.ToInt32(txt_num.Text), Txt_sales.Text,DateTimePicker1.Value, Txt_note.Text);
                    for (int i = 0; i < DataGridView1.Rows.Count; i++)
                    {
                        Product.Add_TransfairDetails(Convert.ToInt32(txt_num.Text),Convert.ToString(Cmb_FromStore.SelectedValue),Convert.ToString(Cmb_ToStore.SelectedValue),
                            Convert.ToInt32(DataGridView1.Rows[i].Cells[0].Value), Convert.ToInt32(DataGridView1.Rows[i].Cells[2].Value));
                    }
                    MessageBox.Show("تم إضافة التحويل بنجاح");

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
