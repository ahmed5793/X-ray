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
    public partial class Frm_TransferToCompany : Form
    {
        Company c = new Company();
        ItemsXRaya ix = new ItemsXRaya();

        public Frm_TransferToCompany()
        {
            InitializeComponent();
            cmb_Company.DataSource = c.SelectCompany();
            cmb_Company.DisplayMember = "اسم الشركه";
            cmb_Company.ValueMember = "Comp_ID";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Frm_TransferToCompany_Load(object sender, EventArgs e)
        {

        }
        DataTable dt = new DataTable();
        DataTable dt12 = new DataTable();
        Tickets t = new Tickets();
        private void cmb_Company_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
            if (cmb_Company.Text != "")
            {
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    dt12 = c.selectXrayCompanyTransfer(Convert.ToInt32(cmb_Company.SelectedValue), Convert.ToInt32(dataGridView2.Rows[i].Cells[3].Value));


                        dataGridView1.DataSource = dt12;                   
                   
                 
               
                

                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }
    }
}
