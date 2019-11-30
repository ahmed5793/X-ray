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
    public partial class Frm_EmpSarf : Form
    {
        Employee E = new Employee();
        Stock s = new Stock();
        DataTable dt = new DataTable();
        public Frm_EmpSarf()
        {
            InitializeComponent();
            cmb_employeeName.DataSource = E.SelectCompoEmployee();
            cmb_employeeName.DisplayMember = "Emp_Name";
            cmb_employeeName.ValueMember = "Emp_ID";

            cmb_stock.DataSource = s.select_Stock();
            cmb_stock.DisplayMember = "إسم الخزنة";
            cmb_stock.ValueMember = "رقم الخزنة";


        }

        private void Frm_EmpSarf_Load(object sender, EventArgs e)
        {

        }

        private void cmb_employeeName_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cmb_employeeName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmb_employeeName.Text != "")
            {
                dt.Clear();
                dt = E.SelectCHECKSalaryEmployee(Convert.ToInt32(cmb_employeeName.SelectedValue));
                if (dt.Rows.Count > 0)
                {
                    Txt_salary.Text = dt.Rows[0][1].ToString();
                    txt_salf.Text = dt.Rows[0][2].ToString();
                    txt_total.Text = dt.Rows[0][3].ToString();
                }
            }
        }
    }
}
