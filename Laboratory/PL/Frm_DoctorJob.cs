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
    public partial class Frm_DoctorJob : Form
    {
        Doctors d = new Doctors();
        public Frm_DoctorJob()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
          
        }

        private void Frm_DoctorJob_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "")
            {
                MessageBox.Show("");
                return;
            }
            d.AddDepartmentDoctor(txt_name.Text);
            MessageBox.Show("تم الاضافة");
            txt_name.Clear();
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
