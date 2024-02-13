using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Tourism_Company.PL
{
    public partial class Form_restore : Form
    {
        SqlConnection con = new SqlConnection(@"server=.;database=master;integrated security=true");
        SqlCommand cmd;
        public Form_restore()
        {
            InitializeComponent();
        }

        private void Btn_file_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
        }

        private void Btn_backUp_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("قم بتحديد المسار من الكمبيوتر");
                }
                else
                {
                    string query = "  ALTER Database TourismCompany SET OFFLINE WITH ROLLBACK IMMEDIATE;Restore Database TourismCompany from Disk='" + textBox1.Text + "' WITH REPLACE";

                    con.Open();
                    cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("تم استرجاع النسخه الاحتياطيه بنجاح", "استرجاع نسخه احتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
