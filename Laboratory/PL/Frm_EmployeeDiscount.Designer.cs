namespace Laboratory.PL
{
    partial class Frm_EmployeeDiscount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_EmployeeDiscount));
            this.txt_Money = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_reason = new System.Windows.Forms.TextBox();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Date_insert = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_Employee = new System.Windows.Forms.ComboBox();
            this.cmb_UserBranch = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // txt_Money
            // 
            this.txt_Money.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Money.Location = new System.Drawing.Point(78, 146);
            this.txt_Money.Multiline = true;
            this.txt_Money.Name = "txt_Money";
            this.txt_Money.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Money.Size = new System.Drawing.Size(143, 28);
            this.txt_Money.TabIndex = 71;
            this.txt_Money.Text = "0";
            this.txt_Money.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Money.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Money_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Yellow;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(571, 227);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(91, 22);
            this.label7.TabIndex = 82;
            this.label7.Text = "سبب الخصم:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Yellow;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(421, 9);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(95, 22);
            this.label6.TabIndex = 81;
            this.label6.Text = "اسم المستخدم";
            // 
            // txt_reason
            // 
            this.txt_reason.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_reason.Location = new System.Drawing.Point(28, 200);
            this.txt_reason.Multiline = true;
            this.txt_reason.Name = "txt_reason";
            this.txt_reason.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_reason.Size = new System.Drawing.Size(533, 73);
            this.txt_reason.TabIndex = 73;
            this.txt_reason.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_UserName
            // 
            this.txt_UserName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UserName.Location = new System.Drawing.Point(212, 3);
            this.txt_UserName.Multiline = true;
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.ReadOnly = true;
            this.txt_UserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_UserName.Size = new System.Drawing.Size(203, 32);
            this.txt_UserName.TabIndex = 72;
            this.txt_UserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Yellow;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(491, 151);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(100, 22);
            this.label4.TabIndex = 80;
            this.label4.Text = "تاريخ الخصم :";
            // 
            // Date_insert
            // 
            this.Date_insert.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_insert.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date_insert.Location = new System.Drawing.Point(354, 148);
            this.Date_insert.Name = "Date_insert";
            this.Date_insert.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Date_insert.ShowUpDown = true;
            this.Date_insert.Size = new System.Drawing.Size(131, 26);
            this.Date_insert.TabIndex = 79;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(227, 149);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(93, 22);
            this.label2.TabIndex = 78;
            this.label2.Text = "مبلغ الخصم :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Yellow;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(421, 99);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(87, 22);
            this.label5.TabIndex = 76;
            this.label5.Text = "اسم الموظف";
            // 
            // cmb_Employee
            // 
            this.cmb_Employee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_Employee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Employee.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Employee.FormattingEnabled = true;
            this.cmb_Employee.Location = new System.Drawing.Point(150, 95);
            this.cmb_Employee.Name = "cmb_Employee";
            this.cmb_Employee.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_Employee.Size = new System.Drawing.Size(265, 27);
            this.cmb_Employee.TabIndex = 70;
            this.cmb_Employee.Leave += new System.EventHandler(this.cmb_Employee_Leave);
            // 
            // cmb_UserBranch
            // 
            this.cmb_UserBranch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_UserBranch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_UserBranch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_UserBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_UserBranch.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_UserBranch.FormattingEnabled = true;
            this.cmb_UserBranch.Location = new System.Drawing.Point(212, 50);
            this.cmb_UserBranch.Name = "cmb_UserBranch";
            this.cmb_UserBranch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_UserBranch.Size = new System.Drawing.Size(203, 26);
            this.cmb_UserBranch.TabIndex = 179;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Yellow;
            this.label13.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(420, 53);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 22);
            this.label13.TabIndex = 178;
            this.label13.Text = "الفرع";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.Black;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.Appearance.Options.UseTextOptions = true;
            this.simpleButton1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.simpleButton1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.simpleButton1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(245, 308);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(170, 32);
            this.simpleButton1.TabIndex = 180;
            this.simpleButton1.Text = "حفظ الخصم";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Frm_EmployeeDiscount
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(677, 371);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.cmb_UserBranch);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_Money);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_reason);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Date_insert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_Employee);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_EmployeeDiscount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشه خصومات الموظفين";
            this.Load += new System.EventHandler(this.Frm_EmployeeDiscount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_Money;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_reason;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker Date_insert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_Employee;
        public System.Windows.Forms.ComboBox cmb_UserBranch;
        private System.Windows.Forms.Label label13;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}