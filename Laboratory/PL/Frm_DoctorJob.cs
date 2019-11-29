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
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_name.Text=="")
            {
                MessageBox.Show("");
                return;
            }
            d.AddDepartmentDoctor(txt_name.Text);
            MessageBox.Show("تم الاضافة");
            txt_name.Clear();
            Frm_Doctor.getmain.comboBox1.DataSource = d.CompoDoctorDepatrtment();
            Frm_Doctor.getmain.comboBox1.DisplayMember = "Deplartmen";
            Frm_Doctor.getmain.comboBox1.ValueMember = "ID_Departmen";
        }

        private void Frm_DoctorJob_Load(object sender, EventArgs e)
        {

        }
    }
}
