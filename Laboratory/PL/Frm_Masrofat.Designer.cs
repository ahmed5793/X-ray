namespace Laboratory.PL
{
    partial class Frm_Masrofat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Masrofat));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_UserBranch = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btn_GenderJob = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_Stock = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt_notes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cmb_UserBranch);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txt_username);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.btn_GenderJob);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmb_Stock);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.txt_notes);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.txt_amount);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(886, 204);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmb_UserBranch
            // 
            this.cmb_UserBranch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_UserBranch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_UserBranch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_UserBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_UserBranch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_UserBranch.FormattingEnabled = true;
            this.cmb_UserBranch.Location = new System.Drawing.Point(557, 57);
            this.cmb_UserBranch.Name = "cmb_UserBranch";
            this.cmb_UserBranch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_UserBranch.Size = new System.Drawing.Size(233, 27);
            this.cmb_UserBranch.TabIndex = 120;
            this.cmb_UserBranch.SelectedIndexChanged += new System.EventHandler(this.cmb_UserBranch_SelectedIndexChanged);
            this.cmb_UserBranch.SelectionChangeCommitted += new System.EventHandler(this.cmb_UserBranch_SelectionChangeCommitted);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(796, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 19);
            this.label13.TabIndex = 119;
            this.label13.Text = "الفرع";
            // 
            // txt_username
            // 
            this.txt_username.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_username.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(557, 22);
            this.txt_username.Name = "txt_username";
            this.txt_username.ReadOnly = true;
            this.txt_username.Size = new System.Drawing.Size(233, 26);
            this.txt_username.TabIndex = 79;
            this.txt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label18.Location = new System.Drawing.Point(795, 25);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(81, 19);
            this.label18.TabIndex = 80;
            this.label18.Text = "اسم المستخدم";
            // 
            // btn_GenderJob
            // 
            this.btn_GenderJob.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_GenderJob.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_GenderJob.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GenderJob.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_GenderJob.Location = new System.Drawing.Point(460, 131);
            this.btn_GenderJob.Name = "btn_GenderJob";
            this.btn_GenderJob.Size = new System.Drawing.Size(49, 27);
            this.btn_GenderJob.TabIndex = 38;
            this.btn_GenderJob.Text = "+++";
            this.btn_GenderJob.UseVisualStyleBackColor = false;
            this.btn_GenderJob.Click += new System.EventHandler(this.btn_GenderJob_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(515, 131);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox1.Size = new System.Drawing.Size(275, 27);
            this.comboBox1.TabIndex = 78;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(796, 96);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(68, 19);
            this.label7.TabIndex = 75;
            this.label7.Text = "اختر خزنة:";
            // 
            // cmb_Stock
            // 
            this.cmb_Stock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Stock.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_Stock.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Stock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Stock.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Stock.FormattingEnabled = true;
            this.cmb_Stock.Location = new System.Drawing.Point(557, 93);
            this.cmb_Stock.Name = "cmb_Stock";
            this.cmb_Stock.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_Stock.Size = new System.Drawing.Size(233, 27);
            this.cmb_Stock.TabIndex = 74;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(408, 19);
            this.textBox1.MaxLength = 11;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(85, 26);
            this.textBox1.TabIndex = 76;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_notes
            // 
            this.txt_notes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_notes.Location = new System.Drawing.Point(6, 64);
            this.txt_notes.MaxLength = 11;
            this.txt_notes.Multiline = true;
            this.txt_notes.Name = "txt_notes";
            this.txt_notes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_notes.Size = new System.Drawing.Size(244, 89);
            this.txt_notes.TabIndex = 72;
            this.txt_notes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(256, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 73;
            this.label1.Text = "ملاحظات";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(18, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(210, 26);
            this.dateTimePicker1.TabIndex = 71;
            // 
            // txt_amount
            // 
            this.txt_amount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_amount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_amount.Location = new System.Drawing.Point(624, 167);
            this.txt_amount.MaxLength = 11;
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_amount.Size = new System.Drawing.Size(166, 26);
            this.txt_amount.TabIndex = 2;
            this.txt_amount.Text = "0";
            this.txt_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_amount_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(793, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "نوع المصروف";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(795, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "المبلغ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(233, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "التاريخ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Maroon;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 279);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(879, 257);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.simpleButton1.Location = new System.Drawing.Point(612, 224);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(154, 32);
            this.simpleButton1.TabIndex = 186;
            this.simpleButton1.Text = "تسجيل جديد";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_Delete.Appearance.BackColor = System.Drawing.Color.Black;
            this.Btn_Delete.Appearance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Delete.Appearance.ForeColor = System.Drawing.Color.White;
            this.Btn_Delete.Appearance.Options.UseBackColor = true;
            this.Btn_Delete.Appearance.Options.UseFont = true;
            this.Btn_Delete.Appearance.Options.UseForeColor = true;
            this.Btn_Delete.Appearance.Options.UseTextOptions = true;
            this.Btn_Delete.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Btn_Delete.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Btn_Delete.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.Btn_Delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Update.ImageOptions.Image")));
            this.Btn_Delete.Location = new System.Drawing.Point(144, 224);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(181, 32);
            this.Btn_Delete.TabIndex = 185;
            this.Btn_Delete.Text = "مسح المصروف";
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Update_Click_1);
            // 
            // Btn_Add
            // 
            this.Btn_Add.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_Add.Appearance.BackColor = System.Drawing.Color.Black;
            this.Btn_Add.Appearance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Add.Appearance.ForeColor = System.Drawing.Color.White;
            this.Btn_Add.Appearance.Options.UseBackColor = true;
            this.Btn_Add.Appearance.Options.UseFont = true;
            this.Btn_Add.Appearance.Options.UseForeColor = true;
            this.Btn_Add.Appearance.Options.UseTextOptions = true;
            this.Btn_Add.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Btn_Add.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Btn_Add.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.Btn_Add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Add.ImageOptions.Image")));
            this.Btn_Add.Location = new System.Drawing.Point(399, 224);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(157, 32);
            this.Btn_Add.TabIndex = 184;
            this.Btn_Add.Text = "حفظ المصروف";
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Frm_Masrofat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(894, 538);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_Masrofat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة المصروفات";
            this.Load += new System.EventHandler(this.Frm_Masrofat_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_Stock;
        private System.Windows.Forms.TextBox txt_notes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_GenderJob;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label18;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton Btn_Delete;
        private DevExpress.XtraEditors.SimpleButton Btn_Add;
        public System.Windows.Forms.ComboBox cmb_UserBranch;
        private System.Windows.Forms.Label label13;
    }
}