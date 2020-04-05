using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Laboratory.BL;
using DevExpress.XtraEditors.Repository;

namespace Laboratory.PL
{
    public partial class Frm_DataRevaltionTicket : DevExpress.XtraEditors.XtraForm
    {
        private static Frm_DataRevaltionTicket farm;

        static void STATUESCllosed(object sender, FormClosedEventArgs e)
        {
            farm = null;
        }
        public static Frm_DataRevaltionTicket getmain
        {
            get
            {
                if (farm == null)
                {
                    farm = new Frm_DataRevaltionTicket();
                    farm.FormClosed += new FormClosedEventHandler(STATUESCllosed);
                }
                return farm;
            }
        }
 
         


      


        Branches b = new Branches();
        Tickets t = new Tickets();
        string x = DateTime.Now.ToShortDateString();


        public Frm_DataRevaltionTicket()
        {
            InitializeComponent();
            if (farm == null)
            {
                farm = this;
            }
            Function();
            ////dataGridView1.Columns[2].DefaultCellStyle.Format = "hh:mm tt";

            //RepositoryItemTextEdit textEdit = new RepositoryItemTextEdit();
            //textEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            //textEdit.Mask.EditMask = "dd/MM/yyyy hh:mm tt";
            //textEdit.Mask.UseMaskAsDisplayFormat = true;

            //gridControl1.RepositoryItems.Add(textEdit);
            //gridView1.Columns["تاريخ الكشف"].ColumnEdit = textEdit;


        }
        void Function()
        {
            try
            {

                comboBox1.DataSource = b.SelectCompBranches();
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "Branch_ID";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            } 
        }
        private void Frm_DataRevaltionTicket_Load(object sender, EventArgs e)
        {
            Lable_Date.Text=DateTime.Now.ToString("dd/MM/yyyy");
            lable_day.Text = DateTime.Now.ToString("dddd", new System.Globalization.CultureInfo("ar-EG"));
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
         
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //for (int i = 0; i < dataGridView1.Columns.Count; i++)
            //{
            //    gridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;

            //    gridView1.Columns[i].SortMode = grid;
            //}
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {

                gridControl1.DataSource = t.selectDataRevlation(Convert.ToInt32(comboBox1.SelectedValue), Convert.ToDateTime(x));



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}