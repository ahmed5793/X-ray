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

namespace Laboratory.PL
{
    public partial class frm_SerielNumber : DevExpress.XtraEditors.XtraForm
    {
        public frm_SerielNumber()
        {
            InitializeComponent();
        }
        string x = "0";
     
        public void frm_SerielNumber_Load(object sender, EventArgs e)
        {
            try
            {

          

            string serial = IDENTIFIER("Win32_DisKDrive", "SerialNumber");
            string signature = IDENTIFIER("Win32_DisKDrive", "signature");
            textBox1.Text = signature;//رقم الهارد
            textBox2.Text = serial;//رقم الماذر 0بورد

            x = (Convert.ToDecimal(signature) * 12345 - 3).ToString();

            x = (Convert.ToDecimal(x) + Convert.ToDecimal(signature)).ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private string IDENTIFIER(string WimClass, string Property)
        {




            string result = "";
            System.Management.ManagementClass mc = new System.Management.ManagementClass(WimClass);
            System.Management.ManagementObjectCollection moc = mc.GetInstances();
            foreach (System.Management.ManagementObject mo in moc)
            {
                if (result == "")
                {
                    try
                    {
                        result = mo[Property].ToString();
                        break;
                    }
                    catch
                    {


                    }
                }
            }
            return result;
        }
          
        private void Btn_SelectProduct_Click(object sender, EventArgs e)
        {
            try
            {

          
            if (textBox3.Text=="")
            {
                MessageBox.Show("من فضلك قم باادخال كود التفعيل لتسجيل عمليه الدخول", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBox3.Text==x)
            {
                MessageBox.Show("تم تفعيل البرنامج بنجاح","تأكيد",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Properties.Settings.Default.ProudectKey = "YES";
                Properties.Settings.Default.Save();
                    this.Close();
            }
            else
            {
                MessageBox.Show("كود التفعيل خطاء", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }
    }
}