using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using WhatsAppApi;

namespace Laboratory.PL
{
    public partial class Frm_SendSmsWhatsApp : DevExpress.XtraEditors.XtraForm
    {
        public Frm_SendSmsWhatsApp()
        {
            InitializeComponent();
        }

        private void Frm_SendSmsWhatsApp_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            WhatsApp wa = new WhatsApp(txt_Number.Text,txt_PASS.Text,txt_Name.Text,true);
            wa.OnConnectSuccess += () =>
                {
                    txt_statues.Text = "CONNECTED...";
                    wa.OnLoginSuccess += (phone, date) =>
                     {
                         txt_statues.Text = "\r\nConnection sucssess!";
                         wa.SendMessage(txt_to.Text, txt_message.Text);
                         txt_statues.Text = "\r\nMessage sent!";
                     };
                    wa.OnLoginFailed += (data) =>
                    {
                        txt_statues.Text += string.Format ("\r\nLogin failed{0}",data);
                    };
                    wa.Login();
            };
            wa.OnConnectFailed += (ex) =>
              {
                  txt_statues.Text += string.Format("\r\nConnect failed{0}", ex.StackTrace);
              };
            wa.Connect();
        }
    }
}