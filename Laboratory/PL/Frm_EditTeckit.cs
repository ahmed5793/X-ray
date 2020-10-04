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
    public partial class Frm_EditTeckit : Form
    {
        Techincal tc = new Techincal();
        DoctorOfCenter dc = new DoctorOfCenter();
        Branches b = new Branches();
        Tickets t = new Tickets();
        Frm_ManagmentTickets fmt = new Frm_ManagmentTickets();
        public Frm_EditTeckit()
        {
            InitializeComponent();
            txt_username.Text = Program.salesman;
            DoctorOfCenter();
            Techincal();
            brnches();
        }
        void DoctorOfCenter()
        {
            cmb_DoctorOfCenter.DataSource = dc.CompoDoctor_OFCENTER();
            cmb_DoctorOfCenter.DisplayMember = "Doc_Name";
            cmb_DoctorOfCenter.ValueMember = "Doc_ID";
            cmb_DoctorOfCenter.SelectedIndex = -1;
        }
        void Techincal()
        {
            cmb_Techincal.DataSource = tc.CompoTechibncal();
            cmb_Techincal.DisplayMember = "Tech_Name";
            cmb_Techincal.ValueMember = "Techincal_ID";
            cmb_Techincal.SelectedIndex = -1;
        }
        void brnches()
        {
            cmb_branches.DataSource = b.SelectCompBranches();
            cmb_branches.DisplayMember = "Name";
            cmb_branches.ValueMember = "Branch_ID";
            cmb_branches.SelectedIndex = -1;
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_Techincal.Text=="")
                {
                    MessageBox.Show("لا بد من تحديد إسم الفنى الجديد");
                    cmb_Techincal.Focus();
                    return;
                }
                if (cmb_DoctorOfCenter.Text=="")
                {
                    MessageBox.Show("لا بد من تحديد إسم الدكتور الجديد");
                    cmb_DoctorOfCenter.Focus();
                    return;
                }
                if (cmb_branches.Text=="")
                {
                    MessageBox.Show("لا بد من تحديد إسم الفرع الجديد");
                    cmb_branches.Focus();
                    return;
                }
                else if (MessageBox.Show("هل تريد تأكيد التعديل على الحجز","عملية التعديل",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    t.Update_TeckietInformation(Convert.ToInt32(txt_idtickets.Text), Convert.ToInt32(cmb_Techincal.SelectedValue),
                Convert.ToInt32(cmb_DoctorOfCenter.SelectedValue),dtb_kashf.Value,dtp_recive.Value,
                Convert.ToInt32(cmb_branches.SelectedValue),txt_username.Text, Txt_NewNotes.Text);
                    MessageBox.Show("تم حفظ التعديلات بنجاح");
                }
                else
                {
                    MessageBox.Show("تم إلغاء التعديلات الحجز");

                }
                this.Close();
                fmt.gridControl1.DataSource = t.SelectSearchticketsBranchDate(Convert.ToInt32(fmt.cmb_branches.SelectedValue), fmt.FromDate.Value, fmt.ToDate.Value);

            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
               
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txt_doctorOfCenter_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_techincal_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frm_EditTeckit_Load(object sender, EventArgs e)
        {

        }
    }
}
