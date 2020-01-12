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
    public partial class Frm_ReportOutDoctorData : Form
    {
        Doctors d = new Doctors();

        public Frm_ReportOutDoctorData()
        {
            InitializeComponent();
            dataGridView1.DataSource = d.SelectDoctor();
        }
    }
}
