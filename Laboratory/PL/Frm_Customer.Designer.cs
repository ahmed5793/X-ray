namespace Laboratory.PL
{
    partial class Frm_Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Customer));
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_idnational = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Update = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(512, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "بحث";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_search);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(785, 270);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(232, 19);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(262, 32);
            this.txt_search.TabIndex = 0;
            this.txt_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Maroon;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(767, 206);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_idnational);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_age);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.txt_phone);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_address);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(791, 172);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // txt_idnational
            // 
            this.txt_idnational.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idnational.Location = new System.Drawing.Point(6, 117);
            this.txt_idnational.MaxLength = 3000;
            this.txt_idnational.Name = "txt_idnational";
            this.txt_idnational.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_idnational.Size = new System.Drawing.Size(264, 32);
            this.txt_idnational.TabIndex = 99;
            this.txt_idnational.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_idnational.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_idnational_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 100;
            this.label1.Text = "الرقم القومي";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(155, 25);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(46, 24);
            this.label22.TabIndex = 98;
            this.label22.Text = "النوع";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(17, 70);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(196, 26);
            this.dateTimePicker1.TabIndex = 32;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ذكر",
            "انثي"});
            this.comboBox1.Location = new System.Drawing.Point(9, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox1.Size = new System.Drawing.Size(143, 32);
            this.comboBox1.TabIndex = 97;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(228, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 24);
            this.label7.TabIndex = 31;
            this.label7.Text = "تاريخ التسجيل";
            // 
            // txt_age
            // 
            this.txt_age.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_age.Location = new System.Drawing.Point(210, 22);
            this.txt_age.MaxLength = 11;
            this.txt_age.Name = "txt_age";
            this.txt_age.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_age.Size = new System.Drawing.Size(90, 32);
            this.txt_age.TabIndex = 25;
            this.txt_age.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_age.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_age_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(305, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 24);
            this.label4.TabIndex = 26;
            this.label4.Text = "السن";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(362, 22);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(312, 32);
            this.txt_name.TabIndex = 0;
            this.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_phone
            // 
            this.txt_phone.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phone.Location = new System.Drawing.Point(382, 70);
            this.txt_phone.MaxLength = 3000;
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_phone.Size = new System.Drawing.Size(291, 32);
            this.txt_phone.TabIndex = 2;
            this.txt_phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_phone_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(686, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "اسم المريض";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(680, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "رقم الموبايل ";
            // 
            // txt_address
            // 
            this.txt_address.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address.Location = new System.Drawing.Point(382, 117);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(292, 32);
            this.txt_address.TabIndex = 1;
            this.txt_address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(699, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "العنوان";
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
            this.simpleButton1.Location = new System.Drawing.Point(565, 181);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(129, 32);
            this.simpleButton1.TabIndex = 177;
            this.simpleButton1.Text = "تسجيل جديد";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Btn_Update
            // 
            this.Btn_Update.Appearance.BackColor = System.Drawing.Color.Black;
            this.Btn_Update.Appearance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Update.Appearance.ForeColor = System.Drawing.Color.White;
            this.Btn_Update.Appearance.Options.UseBackColor = true;
            this.Btn_Update.Appearance.Options.UseFont = true;
            this.Btn_Update.Appearance.Options.UseForeColor = true;
            this.Btn_Update.Appearance.Options.UseTextOptions = true;
            this.Btn_Update.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Btn_Update.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Btn_Update.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.Btn_Update.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.Btn_Update.Location = new System.Drawing.Point(153, 180);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(153, 32);
            this.Btn_Update.TabIndex = 176;
            this.Btn_Update.Text = "تعديل بيانات ";
            this.Btn_Update.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // Btn_Add
            // 
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
            this.Btn_Add.Location = new System.Drawing.Point(368, 181);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(140, 32);
            this.Btn_Add.TabIndex = 175;
            this.Btn_Add.Text = "حفظ";
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Frm_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 494);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.Btn_Update);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 532);
            this.MinimumSize = new System.Drawing.Size(816, 532);
            this.Name = "Frm_Customer";
            this.Text = "شاشة تسجيل العملاء";
            this.Load += new System.EventHandler(this.Frm_Customer_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_search;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label22;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txt_idnational;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton Btn_Update;
        private DevExpress.XtraEditors.SimpleButton Btn_Add;
    }
}