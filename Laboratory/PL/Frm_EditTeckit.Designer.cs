namespace Laboratory.PL
{
    partial class Frm_EditTeckit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_EditTeckit));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label28 = new System.Windows.Forms.Label();
            this.Txt_OldNotes = new System.Windows.Forms.TextBox();
            this.txt_branch = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_dateRecive = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_timeKa4f = new System.Windows.Forms.TextBox();
            this.txt_techincal = new System.Windows.Forms.TextBox();
            this.txt_doctorOfCenter = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_NewNotes = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.cmb_branches = new System.Windows.Forms.ComboBox();
            this.dtb_kashf = new System.Windows.Forms.DateTimePicker();
            this.dtp_recive = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_DoctorOfCenter = new System.Windows.Forms.ComboBox();
            this.cmb_Techincal = new System.Windows.Forms.ComboBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.Btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.txt_idtickets = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label28);
            this.groupBox2.Controls.Add(this.Txt_OldNotes);
            this.groupBox2.Controls.Add(this.txt_branch);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txt_dateRecive);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_timeKa4f);
            this.groupBox2.Controls.Add(this.txt_techincal);
            this.groupBox2.Controls.Add(this.txt_doctorOfCenter);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(454, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(434, 323);
            this.groupBox2.TabIndex = 118;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "بيانات الفحص قبل التعديل";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label28
            // 
            this.label28.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.White;
            this.label28.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(328, 254);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(71, 24);
            this.label28.TabIndex = 140;
            this.label28.Text = "ملاحظات";
            // 
            // Txt_OldNotes
            // 
            this.Txt_OldNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Txt_OldNotes.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_OldNotes.Location = new System.Drawing.Point(6, 223);
            this.Txt_OldNotes.MaxLength = 3000;
            this.Txt_OldNotes.Multiline = true;
            this.Txt_OldNotes.Name = "Txt_OldNotes";
            this.Txt_OldNotes.ReadOnly = true;
            this.Txt_OldNotes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Txt_OldNotes.Size = new System.Drawing.Size(316, 80);
            this.Txt_OldNotes.TabIndex = 139;
            this.Txt_OldNotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_branch
            // 
            this.txt_branch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_branch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_branch.Location = new System.Drawing.Point(6, 182);
            this.txt_branch.Name = "txt_branch";
            this.txt_branch.ReadOnly = true;
            this.txt_branch.Size = new System.Drawing.Size(314, 26);
            this.txt_branch.TabIndex = 138;
            this.txt_branch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(325, 184);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 24);
            this.label13.TabIndex = 137;
            this.label13.Text = "مكان الفحص";
            // 
            // txt_dateRecive
            // 
            this.txt_dateRecive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_dateRecive.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dateRecive.Location = new System.Drawing.Point(6, 142);
            this.txt_dateRecive.Name = "txt_dateRecive";
            this.txt_dateRecive.ReadOnly = true;
            this.txt_dateRecive.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_dateRecive.Size = new System.Drawing.Size(314, 26);
            this.txt_dateRecive.TabIndex = 136;
            this.txt_dateRecive.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(322, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 24);
            this.label7.TabIndex = 135;
            this.label7.Text = "تاريخ الاستلام";
            // 
            // txt_timeKa4f
            // 
            this.txt_timeKa4f.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_timeKa4f.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timeKa4f.Location = new System.Drawing.Point(6, 104);
            this.txt_timeKa4f.Name = "txt_timeKa4f";
            this.txt_timeKa4f.ReadOnly = true;
            this.txt_timeKa4f.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_timeKa4f.Size = new System.Drawing.Size(314, 26);
            this.txt_timeKa4f.TabIndex = 121;
            this.txt_timeKa4f.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_techincal
            // 
            this.txt_techincal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_techincal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_techincal.Location = new System.Drawing.Point(6, 26);
            this.txt_techincal.Name = "txt_techincal";
            this.txt_techincal.ReadOnly = true;
            this.txt_techincal.Size = new System.Drawing.Size(316, 26);
            this.txt_techincal.TabIndex = 133;
            this.txt_techincal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_techincal.TextChanged += new System.EventHandler(this.txt_techincal_TextChanged);
            // 
            // txt_doctorOfCenter
            // 
            this.txt_doctorOfCenter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_doctorOfCenter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_doctorOfCenter.Location = new System.Drawing.Point(6, 64);
            this.txt_doctorOfCenter.Name = "txt_doctorOfCenter";
            this.txt_doctorOfCenter.ReadOnly = true;
            this.txt_doctorOfCenter.Size = new System.Drawing.Size(315, 26);
            this.txt_doctorOfCenter.TabIndex = 134;
            this.txt_doctorOfCenter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_doctorOfCenter.TextChanged += new System.EventHandler(this.txt_doctorOfCenter_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(326, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 24);
            this.label12.TabIndex = 98;
            this.label12.Text = "فنى الحالة ";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.White;
            this.label23.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(323, 66);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(99, 24);
            this.label23.TabIndex = 96;
            this.label23.Text = "طبيب الحالة ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(323, 106);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(98, 24);
            this.label17.TabIndex = 104;
            this.label17.Text = "وقت الكشف ";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.Txt_NewNotes);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.cmb_branches);
            this.groupBox1.Controls.Add(this.dtb_kashf);
            this.groupBox1.Controls.Add(this.dtp_recive);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmb_DoctorOfCenter);
            this.groupBox1.Controls.Add(this.cmb_Techincal);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 323);
            this.groupBox1.TabIndex = 119;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات الفحص الجديده";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(333, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 24);
            this.label8.TabIndex = 145;
            this.label8.Text = "ملاحظات";
            // 
            // Txt_NewNotes
            // 
            this.Txt_NewNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Txt_NewNotes.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NewNotes.Location = new System.Drawing.Point(11, 223);
            this.Txt_NewNotes.MaxLength = 3000;
            this.Txt_NewNotes.Multiline = true;
            this.Txt_NewNotes.Name = "Txt_NewNotes";
            this.Txt_NewNotes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Txt_NewNotes.Size = new System.Drawing.Size(316, 80);
            this.Txt_NewNotes.TabIndex = 144;
            this.Txt_NewNotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.White;
            this.label21.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(333, 184);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(99, 24);
            this.label21.TabIndex = 143;
            this.label21.Text = "مكان الفحص";
            // 
            // cmb_branches
            // 
            this.cmb_branches.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_branches.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_branches.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_branches.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_branches.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_branches.FormattingEnabled = true;
            this.cmb_branches.Location = new System.Drawing.Point(65, 183);
            this.cmb_branches.Name = "cmb_branches";
            this.cmb_branches.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_branches.Size = new System.Drawing.Size(262, 26);
            this.cmb_branches.TabIndex = 142;
            // 
            // dtb_kashf
            // 
            this.dtb_kashf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtb_kashf.CustomFormat = "   dd/MM/yyyy       *      tt  mm:hh     ";
            this.dtb_kashf.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtb_kashf.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtb_kashf.Location = new System.Drawing.Point(65, 105);
            this.dtb_kashf.Name = "dtb_kashf";
            this.dtb_kashf.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtb_kashf.ShowUpDown = true;
            this.dtb_kashf.Size = new System.Drawing.Size(262, 25);
            this.dtb_kashf.TabIndex = 141;
            // 
            // dtp_recive
            // 
            this.dtp_recive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_recive.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_recive.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_recive.Location = new System.Drawing.Point(185, 144);
            this.dtp_recive.Name = "dtp_recive";
            this.dtp_recive.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtp_recive.Size = new System.Drawing.Size(140, 25);
            this.dtp_recive.TabIndex = 140;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(331, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 24);
            this.label3.TabIndex = 139;
            this.label3.Text = "تاريخ الاستلام";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(336, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 24);
            this.label4.TabIndex = 137;
            this.label4.Text = "فنى الحالة ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(332, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 24);
            this.label5.TabIndex = 136;
            this.label5.Text = "طبيب الحالة ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(332, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 24);
            this.label6.TabIndex = 138;
            this.label6.Text = "وقت الكشف ";
            // 
            // cmb_DoctorOfCenter
            // 
            this.cmb_DoctorOfCenter.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmb_DoctorOfCenter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_DoctorOfCenter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_DoctorOfCenter.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_DoctorOfCenter.FormattingEnabled = true;
            this.cmb_DoctorOfCenter.Location = new System.Drawing.Point(68, 67);
            this.cmb_DoctorOfCenter.Name = "cmb_DoctorOfCenter";
            this.cmb_DoctorOfCenter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_DoctorOfCenter.Size = new System.Drawing.Size(261, 26);
            this.cmb_DoctorOfCenter.TabIndex = 97;
            // 
            // cmb_Techincal
            // 
            this.cmb_Techincal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmb_Techincal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_Techincal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Techincal.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Techincal.FormattingEnabled = true;
            this.cmb_Techincal.Location = new System.Drawing.Point(68, 27);
            this.cmb_Techincal.Name = "cmb_Techincal";
            this.cmb_Techincal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_Techincal.Size = new System.Drawing.Size(261, 26);
            this.cmb_Techincal.TabIndex = 92;
            // 
            // txt_username
            // 
            this.txt_username.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_username.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(306, 8);
            this.txt_username.Name = "txt_username";
            this.txt_username.ReadOnly = true;
            this.txt_username.Size = new System.Drawing.Size(259, 25);
            this.txt_username.TabIndex = 120;
            this.txt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(571, 10);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(75, 18);
            this.label18.TabIndex = 121;
            this.label18.Text = "اسم المستخدم";
            // 
            // Btn_Save
            // 
            this.Btn_Save.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Save.Appearance.BackColor = System.Drawing.Color.Black;
            this.Btn_Save.Appearance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Save.Appearance.ForeColor = System.Drawing.Color.White;
            this.Btn_Save.Appearance.Options.UseBackColor = true;
            this.Btn_Save.Appearance.Options.UseFont = true;
            this.Btn_Save.Appearance.Options.UseForeColor = true;
            this.Btn_Save.Appearance.Options.UseTextOptions = true;
            this.Btn_Save.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Btn_Save.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Btn_Save.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.Btn_Save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Save.ImageOptions.Image")));
            this.Btn_Save.Location = new System.Drawing.Point(343, 467);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(208, 48);
            this.Btn_Save.TabIndex = 181;
            this.Btn_Save.Text = "حفظ التعديلات للفاتوره";
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // txt_idtickets
            // 
            this.txt_idtickets.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_idtickets.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idtickets.Location = new System.Drawing.Point(441, 44);
            this.txt_idtickets.Name = "txt_idtickets";
            this.txt_idtickets.ReadOnly = true;
            this.txt_idtickets.Size = new System.Drawing.Size(124, 26);
            this.txt_idtickets.TabIndex = 182;
            this.txt_idtickets.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(306, 83);
            this.txt_name.Name = "txt_name";
            this.txt_name.ReadOnly = true;
            this.txt_name.Size = new System.Drawing.Size(259, 26);
            this.txt_name.TabIndex = 183;
            this.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(571, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 184;
            this.label1.Text = "إسم العميل";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(571, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 24);
            this.label2.TabIndex = 185;
            this.label2.Text = "رقم الحجز";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm_EditTeckit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(893, 527);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_idtickets);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_EditTeckit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة تعديل بيانات الحجز";
            this.Load += new System.EventHandler(this.Frm_EditTeckit_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox txt_timeKa4f;
        public System.Windows.Forms.TextBox txt_techincal;
        public System.Windows.Forms.TextBox txt_doctorOfCenter;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label label23;
        public System.Windows.Forms.Label label17;
        public System.Windows.Forms.TextBox txt_dateRecive;
        public System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox cmb_DoctorOfCenter;
        public System.Windows.Forms.ComboBox cmb_Techincal;
        private System.Windows.Forms.DateTimePicker dtb_kashf;
        private System.Windows.Forms.DateTimePicker dtp_recive;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label18;
        public System.Windows.Forms.TextBox txt_branch;
        public System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label21;
        public System.Windows.Forms.ComboBox cmb_branches;
        private DevExpress.XtraEditors.SimpleButton Btn_Save;
        public System.Windows.Forms.TextBox txt_idtickets;
        public System.Windows.Forms.TextBox txt_name;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox Txt_OldNotes;
        public System.Windows.Forms.TextBox Txt_NewNotes;
    }
}