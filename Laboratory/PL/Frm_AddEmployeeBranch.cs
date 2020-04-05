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
    public partial class Frm_AddEmployeeBranch : Form
    {
        Employee E = new Employee();
        Branches b = new Branches();
        Users u = new Users();
        public Frm_AddEmployeeBranch()
        {
            InitializeComponent();
            Permision();
            //cmb_branch.DataSource = b.SelectCompBranches();
            //cmb_branch.DisplayMember = "Name";
            //cmb_branch.ValueMember = "Branch_ID";
            Select_Employee();
            dataGridView1.DataSource = E.SelectEmployeeBranch();
            Btn_Add.Enabled = true;
            Btn_Update.Enabled = false;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[2].Visible = false;
        }
        void Select_Employee()
        {
            try
            {
                cmb_employee.DataSource = E.SelectCompoEmployee();
                cmb_employee.DisplayMember = "Emp_Name";
                cmb_employee.ValueMember = "Emp_ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void Permision()
        {
            try
            {
                dt.Clear();
                dt = u.SelectUserBranch(Program.salesman);

                if (dt.Rows.Count > 0)
                {
                    cmb_branch.DataSource = u.SelectUserBranch(Program.salesman);
                    cmb_branch.DisplayMember = "Name";
                    cmb_branch.ValueMember = "Branch_ID";

                }
                else
                {
                    cmb_branch.DataSource = b.SelectCompBranches();
                    cmb_branch.DisplayMember = "Name";
                    cmb_branch.ValueMember = "Branch_ID";

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        DataTable dt = new DataTable();
        private void btn_save_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    cmb_branch.Enabled = true;
                    Btn_Add.Enabled = false;
                    Btn_Update.Enabled = true;
                    cmb_employee.Enabled = false;
                    cmb_branch.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    cmb_employee.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message) ;
                MessageBox.Show(ex.StackTrace) ;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            dt.Clear();
            dt = E.SearchEmployeeBranch(txt_search.Text);
            dataGridView1.DataSource = dt;
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            if (cmb_employee.Text == "")
            {
                MessageBox.Show("من فضلك قم بااختيار الموظف");
                return;
            }
            if (cmb_branch.Text == "")
            {
                MessageBox.Show("من فضلك قم بااختيار الفرع");
                return;
            }
            dt.Clear();
            dt = E.VildateEmployeeBranch(Convert.ToInt32(cmb_employee.SelectedValue));
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("لايمكن تسجيل الموظف اكثر من فرع");
                dataGridView1.DataSource = E.SelectEmployeeBranch();

                return;
            }
            E.AddEmployeeBranch(Convert.ToInt32(cmb_branch.SelectedValue), Convert.ToInt32(cmb_employee.SelectedValue));
            MessageBox.Show("تم الاضافة بنجاح");
            dataGridView1.DataSource = E.SelectEmployeeBranch();

            Btn_Add.Enabled = true;
            Btn_Update.Enabled = false;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_employee.Text == "")
                {
                    MessageBox.Show("من فضلك قم بااختيار الموظف");
                    return;
                }
                if (cmb_branch.Text == "")
                {
                    MessageBox.Show("من فضلك قم بااختيار الفرع");
                    return;
                }
                E.UpdateEmployeeBranch(Convert.ToInt32(cmb_branch.SelectedValue), Convert.ToInt32(cmb_employee.SelectedValue));
                MessageBox.Show("تم التعديل بنجاح");
                dataGridView1.DataSource = E.SelectEmployeeBranch();
                Btn_Add.Enabled = true;
                Btn_Update.Enabled = false;
                cmb_branch.Enabled = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }
    }
}
