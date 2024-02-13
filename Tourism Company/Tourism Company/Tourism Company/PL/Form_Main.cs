using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tourism_Company.BL;



namespace Tourism_Company.PL
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form_Main_Load(object sender, EventArgs e)
        {

        }

        private void Button11_Click(object sender, EventArgs e)
        {

        }

        private void ToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ToolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            Form_Customer C = new Form_Customer();
            C.ShowDialog();
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            Form_Company m = new Form_Company();
            m.ShowDialog();
        }

        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            Frm_Arba7 fa = new Frm_Arba7();
            fa.Show();
        }

        private void ToolStripButton6_Click(object sender, EventArgs e)
        {
            Form_Booking b = new Form_Booking();
            b.ShowDialog();
        }

        private void ToolStripButton7_Click(object sender, EventArgs e)
        {
            Form_AllTicket t = new Form_AllTicket();
            t.ShowDialog();
        }

        private void ToolStripButton8_Click(object sender, EventArgs e)
        {
            
        }

        private void ToolStripButton11_Click(object sender, EventArgs e)
        {
            Form_update FU = new Form_update();
            FU.Show();
        }

        private void ToolStripButton10_Click(object sender, EventArgs e)
        {
            Frm_masrofat fm = new Frm_masrofat();
            fm.Show();
        }

        private void ToolStripButton11_Click_1(object sender, EventArgs e)
        {
            Frm_AllMasrofat fam = new Frm_AllMasrofat();
            fam.Show();
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ToolStripButton12_Click(object sender, EventArgs e)
        {
            Frm_stock fs = new Frm_stock();
            fs.Show();
        }

        private void ToolStripButton13_Click(object sender, EventArgs e)
        {
         
        }

        private void ToolStripButton14_Click(object sender, EventArgs e)
        {
            Frm_AddBank fab = new Frm_AddBank();
            fab.Show();
        }

        private void ToolStripButton15_Click(object sender, EventArgs e)
        {
          
        }

        private void ToolStripButton16_Click(object sender, EventArgs e)
        {
          
        }

        private void ToolStripButton5_Click(object sender, EventArgs e)
        {
           
        }

        private void إيداعرصيدبنكToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void إيداعرصيدخزنةToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void سحبرصيدمنالبنكToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void سحبرصيدمنالخزنةToolStripMenuItem_Click(object sender, EventArgs e)
        {
      
        }

        private void ToolStrip5_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_BankPull fbp = new Frm_BankPull();
            fbp.Show();
        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Frm_StockPull fsp = new Frm_StockPull();
            fsp.Show();
        }

        private void تحويلرصيدمنخزنةلخزنةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_AddBankMoney fam = new Frm_AddBankMoney();
            fam.Show();
        }

        private void تحويلرصيدمنبنكلخزنةToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Frm_StockTransfair s = new Frm_StockTransfair();
            s.Show();
        }

        private void ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Frm_TransfairStockToBank ftstb = new Frm_TransfairStockToBank();
            ftstb.Show();
        }

        private void تحويلرصيدمنبنكلخزنةToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_TransfirBankToStock fs = new Frm_TransfirBankToStock();
            fs.Show();
        }

        private void ToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Frm_ReportInsertStock fr = new Frm_ReportInsertStock();
            fr.Show();
        }

        private void ToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Frm_ReportInsertBAnk fb = new Frm_ReportInsertBAnk();
            fb.Show();
        }

        private void تحويلرصيدمنخزنةلخزنةToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Frm_AddBankMoney fab = new Frm_AddBankMoney();
            fab.Show();
        }

        private void ToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Frm_BankPull fbp = new Frm_BankPull();
            fbp.Show();

        }

        private void تحويلرصيدمنبنكلخزنةToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Frm_addStocMoney fas = new Frm_addStocMoney();
            fas.Show();
        }

        private void ToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            Frm_StockPull fsp = new Frm_StockPull();
            fsp.Show();
        }

        private void ToolStripButton14_Click_1(object sender, EventArgs e)
        {
            Frm_AddBank fab = new Frm_AddBank();
            fab.Show();
        }

        private void ToolStripButton12_Click_1(object sender, EventArgs e)
        {
            Frm_stock s = new Frm_stock();
            s.Show();
        }

        private void ToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Frm_ReportPullStock frps = new Frm_ReportPullStock();
            frps.Show();
        }

        private void تقريرعنتحويلرصيدمنخزنةإلآخزنةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ReortPullBank rpb = new Frm_ReortPullBank();
            rpb.Show();
        }

        private void تقريرعنتحويلرصيدمنخزنةإلىبنكوالعكسToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ReportTransfairStockToStock sts = new Frm_ReportTransfairStockToStock();
            sts.Show();

        }

        private void ToolStripButton4_Click(object sender, EventArgs e)
        {
            Form_Plane p = new Form_Plane();
            p.ShowDialog();
        }

        private void ToolStripButton5_Click_1(object sender, EventArgs e)
        {
            FRm_UserManagement fum = new FRm_UserManagement();
            fum.Show();
        }

        private void ToolStripButton9_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripButton17_Click(object sender, EventArgs e)
        {
            Form_Pay p = new Form_Pay();
            p.ShowDialog();
        }

        private void ToolStripButton3_Click_1(object sender, EventArgs e)
        {
            Frm_Arba7 fa = new Frm_Arba7();
            fa.Show();
        }

        private void ToolStripButton3_Click_2(object sender, EventArgs e)
        {
            Frm_Arba7 fa = new Frm_Arba7();
            fa.Show();
        }

        private void ToolStripButton13_Click_1(object sender, EventArgs e)
        {
            Frm_ValidityUsers vu = new Frm_ValidityUsers();
            vu.Show();
        }

        private void Btn_BackUp_Click(object sender, EventArgs e)
        {
            Form_BackUp fb = new Form_BackUp();
            fb.Show();
        }

        private void Btn_Restore_Click(object sender, EventArgs e)
        {
            Form_restore fr = new Form_restore();
            fr.Show();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Form_Main_Leave(object sender, EventArgs e)
        {
            Application.Exit();
            
        }
    }
}
