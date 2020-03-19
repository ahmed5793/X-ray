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
    public partial class Frm_ManagmentUser : Form
    {
        Users u = new Users();
        Employee E = new Employee();
        DataTable dt = new DataTable();
        Permession P = new Permession();
        public Frm_ManagmentUser()
        {
            InitializeComponent();
            dataGridViewList.DataSource = u.SelectUsers();
            dataGridViewList.Columns[0].Visible = false;
            dataGridViewList.Columns[4].Visible = false;
            comboBox1.DataSource = E.SelectCompoEmployee();
            comboBox1.DisplayMember = "Emp_Name";
            comboBox1.ValueMember = "Emp_ID";

        }

        private void Frm_ManagmentUser_Load(object sender, EventArgs e)
        {
            Btn_Delete.Enabled = false;
            Btn_Update.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewList_DoubleClick(object sender, EventArgs e)
        {
            ; ;
            comboBox1.Enabled = false;
            txt_User.Text = dataGridViewList.CurrentRow.Cells[2].Value.ToString();
            txt_Pass.Text = dataGridViewList.CurrentRow.Cells[3].Value.ToString();
            comboBox1.Text = dataGridViewList.CurrentRow.Cells[1].Value.ToString();
            txt_PassRealy.Text = txt_Pass.Text;
     
           
            Btn_Add.Enabled = false;
            Btn_Update.Enabled = true;
            Btn_Delete.Enabled = true;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

           
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
           
        }

        private void txt_User_Leave(object sender, EventArgs e)
        {
            dt.Clear();
            dt = u.VildateUsers(txt_User.Text);
            if (dt.Rows.Count>0)
            {
                MessageBox.Show("User name already exists Try another name", "", MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
                txt_User.Focus();
                txt_User.Clear();
                return;
            }
            else
            {
                txt_Pass.Focus();
            }
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "")
                {
                    MessageBox.Show("PLEASE INSERT EMPLOYEE NAME");
                    return;
                }
                if (txt_User.Text == "")
                {
                    MessageBox.Show("PLEASE INSERT USER NAME");
                    return;
                }
                if (txt_User.Text == "")
                {
                    MessageBox.Show("PLEASE INSERT PASSWORD");
                    return;
                }

                if (txt_Pass.Text != txt_PassRealy.Text)
                {
                    MessageBox.Show("Password does not match");
                    return;

                }
                dt.Clear();
                dt = E.VildateEmployee(Convert.ToInt32(comboBox1.SelectedValue));
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("It is not possible to register more than one employee account", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                    return;
                }
                Permession p = new Permession();



                p.Add_UserBAsicInformation(txt_User.Text, 0, 0, 0, 0, 0, 0, 0,0,0);

                p.AddUser_Permission(txt_User.Text, 0, 0);

                p.AddUser_Tickets(txt_User.Text, 0, 0, 0, 0, 0, 0, 0,0);

                p.AddUser_Store(txt_User.Text, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                p.AddUserAccount(txt_User.Text, 0, 0, 0, 0, 0, 0, 0, 0, 0,0,0);

                p.AddUserCompany(txt_User.Text, 0, 0, 0, 0, 0, 0, 0);

                p.Add_UserEmployee(txt_User.Text, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                u.AddUser(Convert.ToInt32(comboBox1.SelectedValue), txt_User.Text, txt_Pass.Text);
                dataGridViewList.DataSource = u.SelectUsers();
                MessageBox.Show("Registration saved successfully");


                txt_Pass.Clear();
                txt_User.Clear();
                txt_PassRealy.Clear();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "")
                {
                    MessageBox.Show("PLEASE INSERT EMPLOYEE NAME");
                    return;
                }
                if (txt_User.Text == "")
                {
                    MessageBox.Show("PLEASE INSERT USER NAME");
                    return;
                }
                if (txt_User.Text == "")
                {
                    MessageBox.Show("PLEASE INSERT PASSWORD");
                    return;
                }

                if (txt_Pass.Text != txt_PassRealy.Text)
                {
                    MessageBox.Show("Password does not match");
                    return;

                }
                u.UpdateUsers(Convert.ToInt32(comboBox1.SelectedValue), txt_User.Text, txt_Pass.Text);
                MessageBox.Show("Modify data successfully");
                txt_Pass.Clear();
                txt_User.Clear();
                txt_PassRealy.Clear();
                comboBox1.Enabled = true;
                dataGridViewList.DataSource = u.SelectUsers();

                Btn_Update.Enabled = false;
                Btn_Delete.Enabled = false;
                Btn_Add.Enabled = true;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_New_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("do you want remove USER", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {

                    u.deleteusers(Convert.ToInt32(dataGridViewList.CurrentRow.Cells[4].Value));
                    MessageBox.Show("DONE", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridViewList.DataSource = u.SelectUsers();

                    Btn_Update.Enabled = false;
                    Btn_Add.Enabled = true;
                    Btn_Delete.Enabled = false;

                    txt_Pass.Clear();
                    txt_PassRealy.Clear();
                    txt_User.Clear();

                }
                else
                {
                    MessageBox.Show("The user is not REMOVE", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                    Btn_Update.Enabled = false;
                    Btn_Add.Enabled = true;
                    Btn_Delete.Enabled = false;
                    txt_Pass.Clear();
                    txt_PassRealy.Clear();
                    txt_User.Clear();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }
    }
}
