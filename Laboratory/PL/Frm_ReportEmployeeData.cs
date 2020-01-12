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
    public partial class Frm_ReportEmployeeData : Form
    {
        Employee E = new Employee();
        public Frm_ReportEmployeeData()
        {
            InitializeComponent();
            dataGridView1.DataSource = E.SelectEmployee();
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
        }

        private void Frm_ReportEmployeeData_Load(object sender, EventArgs e)
        {

        }
    }
}
