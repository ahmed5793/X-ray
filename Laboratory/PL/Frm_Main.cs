using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratory.PL
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void hghjvmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void إضافةاصنافلمخزنToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void تحويلأصنافمنمخزنلمخزنToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Add_Store_Click(object sender, EventArgs e)
        {
            Frm_AddStore frm_AddStore = new Frm_AddStore();
            frm_AddStore.ShowDialog();
        }

        private void Add_Product_Click(object sender, EventArgs e)
        {
            Add_Product ap = new Add_Product();
            ap.ShowDialog();
        }

        private void Add_customer_Click(object sender, EventArgs e)
        {
            
        }

        private void Add_masrof_Click(object sender, EventArgs e)
        {
            Frm_Masrofat fm = new Frm_Masrofat();
            fm.ShowDialog();
        }

        private void Add_Stock_Click(object sender, EventArgs e)
        {
            frm_AddStock fas = new frm_AddStock();
            fas.ShowDialog();
        }

        private void Stock_Pull_Click(object sender, EventArgs e)
        {
            Frm_StockPull fsp = new Frm_StockPull();
            fsp.ShowDialog();
        }

        private void Insert_Stock_Click(object sender, EventArgs e)
        {
            frm_AddStockMoney fasm = new frm_AddStockMoney();
            fasm.ShowDialog();
        }

        private void Stock_Transfair_Click(object sender, EventArgs e)
        {
            Frm_StockTransfair fst = new Frm_StockTransfair();
            fst.ShowDialog();
        }

        private void Add_Customer_Click_1(object sender, EventArgs e)
        {
            Frm_Customer fc = new Frm_Customer();
            fc.ShowDialog();
        }

        private void إضافةشركةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Company frm_Company = new Frm_Company();
            frm_Company.ShowDialog();

        }

        private void Add_Doctor_Click(object sender, EventArgs e)
        {
            Frm_Doctor frm_Doctor = new Frm_Doctor();
         
                frm_Doctor.Show();
        }

        private void Store_Management_ButtonClick(object sender, EventArgs e)
        {

        }

        private void Add_Employee_Click(object sender, EventArgs e)
        {
            Frm_Employee frm_Employee = new Frm_Employee();
           frm_Employee.Show();

        }

        private void السلفياتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Salf frm_Salf = new Frm_Salf();
         
                frm_Salf.Show();
       
        }

        private void صرفالمرتباتToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_EmpSarf frm_EmpSarf = new Frm_EmpSarf();
            frm_EmpSarf.Show();
        }

        private void Add_XRays_Click(object sender, EventArgs e)
        {
            Frm_ItemsXRaya frm_ItemsXRaya = new Frm_ItemsXRaya();
       
                frm_ItemsXRaya.Show();
          
        }

        private void Category_XRay_Click(object sender, EventArgs e)
        {
            Frm_CategoryXRaya frm_CategoryX = new Frm_CategoryXRaya();
           
                frm_CategoryX.Show();
         
        }

        private void Main_data_Click(object sender, EventArgs e)
        {

        }

        private void Add_Branche_Click(object sender, EventArgs e)
        {
            Frm_Branches frm_Branches = new Frm_Branches();
            frm_Branches.Show();

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void Add_Masrof_Click_1(object sender, EventArgs e)
        {
            Frm_Masrofat frm_Masrofat = new Frm_Masrofat();
            frm_Masrofat.Show();
        }

        private void Report_Masrofat_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {

        }

        private void AddStore_Click(object sender, EventArgs e)
        {
            Frm_AddStore frm_AddStore = new Frm_AddStore();
            frm_AddStore.Show();
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            Add_Product add_Product = new Add_Product();
            add_Product.Show();
        }
    }
}
