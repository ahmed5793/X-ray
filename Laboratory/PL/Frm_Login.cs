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
    public partial class Frm_Login : Form
    {
        Users U = new Users();
        Permession p = new Permession();
        //Frm_Main frm = new Frm_Main();
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
            try
            {
                Frm_Main fm = new Frm_Main();

                if (txt_User.Text == "")
                {
                    MessageBox.Show("PLEASE INSERT USER NAME");
                    return;
                }
                if (txt_Pass.Text == "")
                {
                    MessageBox.Show("PLEASE INSERT PASSWORD");
                    return;
                }
                else
                {
                    DataTable dt = U.Logins(txt_User.Text, txt_Pass.Text);
                 
                    if (dt.Rows.Count > 0)
                    {
                       
                        dt2.Clear();
                        dt2 = p.Select_UserBAsicInformation(txt_User.Text);
                        if (dt2.Rows.Count>=1)
                        {
                            if (Convert.ToInt32(dt2.Rows[0][0])==0)
                            {
                                Frm_Main.getmain.Add_Branche.Enabled=false;
                            }
                           else if (Convert.ToInt32(dt2.Rows[0][0]) == 1)
                            {
                                Frm_Main.getmain.Add_Branche.Enabled = true;
                            }
                            ///////
                            if (Convert.ToInt32(dt2.Rows[0][1]) == 0)
                            {
                                Frm_Main.getmain.Validate_Users.Enabled = false;
                            }
                            else if (Convert.ToInt32(dt2.Rows[0][1]) == 1)
                            {
                                Frm_Main.getmain.Validate_Users.Enabled = true;
                            }
                            ///////
                            if (Convert.ToInt32(dt2.Rows[0][2]) == 0)
                            {
                                Frm_Main.getmain.Category_XRay.Enabled = false;
                            }
                            else if (Convert.ToInt32(dt2.Rows[0][2]) == 1)
                            {
                                Frm_Main.getmain.Category_XRay.Enabled = true;
                            }
                            /////////
                            if (Convert.ToInt32(dt2.Rows[0][3]) == 0)
                            {
                                Frm_Main.getmain.Add_XRays.Enabled = false;
                            }
                            else if (Convert.ToInt32(dt2.Rows[0][3]) == 1)
                            {
                                Frm_Main.getmain.Add_XRays.Enabled = true;
                            }
                        }
                        Program.salesman = dt.Rows[0][1].ToString();
                        Console.Beep();
                        this.Hide();
                        fm.ShowDialog();
                    }

                    else
                    {
                        MessageBox.Show("Incorrect password or username");
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}