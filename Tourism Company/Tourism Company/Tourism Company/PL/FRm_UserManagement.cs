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
    public partial class FRm_UserManagement : Form
    {
        Permession p = new Permession();
        Users u = new Users();
        public FRm_UserManagement()
        {
            InitializeComponent();
            dataGridViewList.DataSource = u.SelectUsers();
            btn_delete.Enabled = false;
            btn_update.Enabled = false;
            button1.Hide();
        }
        void delete()
        {
            txt_Fullname.Text = "";
            txt_User.Text = "";
            txt_Pass.Text = "";
            txt_PassRealy.Text = "";


        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_User.Text == string.Empty && txt_Pass.Text == string.Empty  )
                {
                    MessageBox.Show("من فضلك ادخل البيانات كامله");
                    return;
                }
                else if (txt_PassRealy.Text == string.Empty && txt_Fullname.Text == string.Empty)
                {
                    MessageBox.Show("من فضلك ادخل البيانات كامله");
                    return;
                }
               else if (txt_Pass.Text != txt_PassRealy.Text)
                {
                    MessageBox.Show("كلمه السر غير متطابقه");
                    txt_PassRealy.Focus();

                    return;



                }
                else if (comboBox1.Text=="ADMIN")
                {
                    p.Add_UserBAsicInformation(txt_User.Text, 1, 1, 1, 1);
                    p.Add_UserBookingTickets(txt_User.Text, 1, 1);
                    p.Add_UserArba7andMasrofat(txt_User.Text, 1, 1, 1);
                    p.AddUsers_BankStock(txt_User.Text, 1, 1, 1, 1, 1, 1, 1, 1,1,1, 1, 1, 1);
                    p.AddUser_Permssion(txt_User.Text, 1, 1);
                    u.AddUser(txt_User.Text, txt_Pass.Text, comboBox1.Text, txt_Fullname.Text);

                    MessageBox.Show("تم اضافه المستخدم بنجاح");
                    dataGridViewList.DataSource = u.SelectUsers();
                    txt_Fullname.Text = "";
                    txt_Pass.Text = "";
                    txt_PassRealy.Text = "";
                    txt_User.Text = "";

                    txt_Fullname.Focus();
                }
                else if (comboBox1.Text== "SALES")
                {
                    p.Add_UserBAsicInformation(txt_User.Text, 0, 0, 0, 0);
                    p.Add_UserBookingTickets(txt_User.Text, 0, 0);
                    p.Add_UserArba7andMasrofat(txt_User.Text, 0, 0, 0);
                    p.AddUsers_BankStock(txt_User.Text, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
                    p.AddUser_Permssion(txt_User.Text, 0, 0);
                    u.AddUser(txt_User.Text, txt_Pass.Text, comboBox1.Text, txt_Fullname.Text);

                    MessageBox.Show("تم اضافه المستخدم بنجاح");
                    dataGridViewList.DataSource = u.SelectUsers();
                    txt_Fullname.Text = "";
                    txt_Pass.Text = "";
                    txt_PassRealy.Text = "";
                    txt_User.Text = "";

                    txt_Fullname.Focus();
                }

                //else
                //{
                //    u.AddUser(txt_User.Text, txt_Pass.Text, comboBox1.Text, txt_Fullname.Text);
                 
                //    MessageBox.Show("تم اضافه المستخدم بنجاح");
                //    dataGridViewList.DataSource = u.SelectUsers();
                //    txt_Fullname.Text = "";
                //    txt_Pass.Text = "";
                //    txt_PassRealy.Text = "";
                //    txt_User.Text = "";

                //    txt_Fullname.Focus();
                //}
        
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Txt_PassRealy_Validated(object sender, EventArgs e)
        {
            if (txt_Pass.Text != txt_PassRealy.Text)
            {
                MessageBox.Show("كلمه السر غير متطابقه");

                return;

            }
        }

        private void Btn_update_Click(object sender, EventArgs e)
        {
            try
            {
            

                if (txt_Pass.Text == "")
                {
                    MessageBox.Show("يرجى كتابة الباسورد");
                    txt_Pass.Focus();
                }
                else if (txt_Fullname.Text == "")
                {
                    MessageBox.Show("يرجي التأكد من إسم الكاشير");
                }
                else if (txt_User.Text == "")
                {
                    MessageBox.Show("يرجي التأكد من إسم المستخدم");
                }

                else if (MessageBox.Show("هل تريد تعديل بيانات المستخدم", "تعديل بيانات المستخدم", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (txt_Pass.Text != txt_PassRealy.Text)
                    {
                        MessageBox.Show("كلمه السر غير متطابقه");
                        return;

                    }
                    u.UpdateUsers(txt_User.Text, txt_Pass.Text, comboBox1.Text);
                    MessageBox.Show("تم التعديل بنجاح", "تعديل بيانات المستخدم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    u.SelectUsers();
                    delete();
                    btn_delete.Enabled = false;
                    btn_update.Enabled = false;
                    btn_save.Show();
                    button1.Hide();

                }

                else
                {
                    MessageBox.Show("لم يتم التعديل ", "تعديل بيانات المستخدم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DataGridViewList_DoubleClick(object sender, EventArgs e)
        {
            txt_User.Text = dataGridViewList.CurrentRow.Cells[0].Value.ToString();
            txt_Pass.Text = dataGridViewList.CurrentRow.Cells[1].Value.ToString();
            comboBox1.Text = dataGridViewList.CurrentRow.Cells[2].Value.ToString();
            txt_Fullname.Text = dataGridViewList.CurrentRow.Cells[3].Value.ToString();
            txt_PassRealy.Text = txt_Pass.Text;
            txt_Fullname.Enabled = true;
            txt_User.Enabled = true;
            btn_save.Hide();
            button1.Show();
            btn_update.Enabled = true;
            btn_delete.Enabled = true;
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("هل تريد مسح هذا المستخدم", "عملية مسح مستخدم", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {

                    u.deleteusers(txt_User.Text);
                    p.Delete_Users_basicInformation(txt_User.Text);
                    p.Delete_UserBookingTickets(txt_User.Text);
                    p.Delete_UserArba7andMasrofat(txt_User.Text);
                    p.DeleteUsers_BankStock(txt_User.Text);
                    p.DeleteUser_Permssion(txt_User.Text);
                    MessageBox.Show("تم مسح المستخدم بنجاح", "عملية مسح مستخدم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridViewList.DataSource = u.SelectUsers();
                    delete();
                    btn_delete.Enabled = false;
                    btn_update.Enabled = false;
                    btn_save.Show();
                    button1.Hide();
                }
                else
                {
                    MessageBox.Show("لم يتم مسح المستخدم", "عملية مسح مستخدم", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    delete();
                    btn_delete.Enabled = false;
                    btn_update.Enabled = false;
                    btn_save.Show();
                    button1.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            delete();
            btn_delete.Enabled = false;
            btn_update.Enabled = false;
            btn_save.Show();
            button1.Hide();
        }
    }
}
