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
    }
}