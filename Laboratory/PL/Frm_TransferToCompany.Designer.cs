namespace Laboratory.PL
{
    partial class Frm_TransferToCompany
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
            this.cmb_Company = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_reasonAddition = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_total = new System.Windows.Forms.Label();
            this.txt_payLat = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_PricePayment = new System.Windows.Forms.Label();
            this.Txt_addtionPayment = new System.Windows.Forms.TextBox();
            this.txt_rentCust = new System.Windows.Forms.Label();
            this.Txt_rentCompany = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_Stock = new System.Windows.Forms.ComboBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_patientname = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_Company
            // 
            this.cmb_Company.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Company.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_Company.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Company.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Company.FormattingEnabled = true;
            this.cmb_Company.Location = new System.Drawing.Point(157, 95);
            this.cmb_Company.Name = "cmb_Company";
            this.cmb_Company.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_Company.Size = new System.Drawing.Size(294, 32);
            this.cmb_Company.TabIndex = 90;
            this.cmb_Company.SelectionChangeCommitted += new System.EventHandler(this.cmb_Company_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(457, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 37);
            this.label1.TabIndex = 91;
            this.label1.Text = "اسم الشركة";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(252, 4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(15, 62);
            this.dataGridView1.TabIndex = 126;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(258, 146);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView2.Size = new System.Drawing.Size(429, 47);
            this.dataGridView2.TabIndex = 127;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(323, 143);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(247, 37);
            this.label16.TabIndex = 103;
            this.label16.Text = "اجمالي المبلغ المسترد";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(548, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 24);
            this.label11.TabIndex = 99;
            this.label11.Text = "الاجمالي";
            // 
            // txt_reasonAddition
            // 
            this.txt_reasonAddition.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_reasonAddition.Location = new System.Drawing.Point(6, 192);
            this.txt_reasonAddition.MaxLength = 3000;
            this.txt_reasonAddition.Multiline = true;
            this.txt_reasonAddition.Name = "txt_reasonAddition";
            this.txt_reasonAddition.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_reasonAddition.Size = new System.Drawing.Size(532, 39);
            this.txt_reasonAddition.TabIndex = 99;
            this.txt_reasonAddition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.White;
            this.label26.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(481, 77);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(147, 24);
            this.label26.TabIndex = 116;
            this.label26.Text = "نسبة تحمل المريض";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.White;
            this.label27.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(147, 82);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(143, 24);
            this.label27.TabIndex = 118;
            this.label27.Text = "مبلغ تحمل المريض";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.White;
            this.label28.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(548, 199);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(71, 24);
            this.label28.TabIndex = 120;
            this.label28.Text = "ملاحظات";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.White;
            this.label29.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(147, 22);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(149, 24);
            this.label29.TabIndex = 121;
            this.label29.Text = "المتبقي على الشركة";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.Txt_rentCompany);
            this.groupBox3.Controls.Add(this.txt_rentCust);
            this.groupBox3.Controls.Add(this.Txt_PricePayment);
            this.groupBox3.Controls.Add(this.txt_total);
            this.groupBox3.Controls.Add(this.label29);
            this.groupBox3.Controls.Add(this.label28);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Controls.Add(this.Txt_addtionPayment);
            this.groupBox3.Controls.Add(this.txt_reasonAddition);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Location = new System.Drawing.Point(12, 199);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(658, 236);
            this.groupBox3.TabIndex = 92;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "الحسابات";
            // 
            // txt_total
            // 
            this.txt_total.AutoSize = true;
            this.txt_total.BackColor = System.Drawing.Color.White;
            this.txt_total.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.Location = new System.Drawing.Point(377, 16);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(31, 34);
            this.txt_total.TabIndex = 122;
            this.txt_total.Text = "0";
            // 
            // txt_payLat
            // 
            this.txt_payLat.AutoSize = true;
            this.txt_payLat.BackColor = System.Drawing.Color.White;
            this.txt_payLat.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_payLat.Location = new System.Drawing.Point(22, 158);
            this.txt_payLat.Name = "txt_payLat";
            this.txt_payLat.Size = new System.Drawing.Size(31, 34);
            this.txt_payLat.TabIndex = 129;
            this.txt_payLat.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(123, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 24);
            this.label4.TabIndex = 128;
            this.label4.Text = "المدفوع مسبقا";
            // 
            // Txt_PricePayment
            // 
            this.Txt_PricePayment.AutoSize = true;
            this.Txt_PricePayment.BackColor = System.Drawing.Color.White;
            this.Txt_PricePayment.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_PricePayment.Location = new System.Drawing.Point(21, 74);
            this.Txt_PricePayment.Name = "Txt_PricePayment";
            this.Txt_PricePayment.Size = new System.Drawing.Size(31, 34);
            this.Txt_PricePayment.TabIndex = 123;
            this.Txt_PricePayment.Text = "0";
            this.Txt_PricePayment.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Txt_PricePayment_MouseUp);
            // 
            // Txt_addtionPayment
            // 
            this.Txt_addtionPayment.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Txt_addtionPayment.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_addtionPayment.ForeColor = System.Drawing.SystemColors.Info;
            this.Txt_addtionPayment.Location = new System.Drawing.Point(330, 74);
            this.Txt_addtionPayment.Name = "Txt_addtionPayment";
            this.Txt_addtionPayment.Size = new System.Drawing.Size(134, 32);
            this.Txt_addtionPayment.TabIndex = 115;
            this.Txt_addtionPayment.Text = "0";
            this.Txt_addtionPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_addtionPayment.TextChanged += new System.EventHandler(this.Txt_addtionPayment_TextChanged);
            this.Txt_addtionPayment.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_addtionPayment_KeyDown);
            this.Txt_addtionPayment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_addtionPayment_KeyPress);
            this.Txt_addtionPayment.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_addtionPayment_KeyUp);
            this.Txt_addtionPayment.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Txt_addtionPayment_MouseDown);
            // 
            // txt_rentCust
            // 
            this.txt_rentCust.AutoSize = true;
            this.txt_rentCust.BackColor = System.Drawing.Color.White;
            this.txt_rentCust.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rentCust.Location = new System.Drawing.Point(143, 138);
            this.txt_rentCust.Name = "txt_rentCust";
            this.txt_rentCust.Size = new System.Drawing.Size(41, 44);
            this.txt_rentCust.TabIndex = 124;
            this.txt_rentCust.Text = "0";
            // 
            // Txt_rentCompany
            // 
            this.Txt_rentCompany.AutoSize = true;
            this.Txt_rentCompany.BackColor = System.Drawing.Color.White;
            this.Txt_rentCompany.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_rentCompany.Location = new System.Drawing.Point(21, 22);
            this.Txt_rentCompany.Name = "Txt_rentCompany";
            this.Txt_rentCompany.Size = new System.Drawing.Size(31, 34);
            this.Txt_rentCompany.TabIndex = 125;
            this.Txt_rentCompany.Text = "0";
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(178, 441);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(298, 38);
            this.btn_save.TabIndex = 126;
            this.btn_save.Text = "حفظ";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Yellow;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(213, 15);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(46, 22);
            this.label5.TabIndex = 131;
            this.label5.Text = "خزينة";
            // 
            // cmb_Stock
            // 
            this.cmb_Stock.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_Stock.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Stock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Stock.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Stock.FormattingEnabled = true;
            this.cmb_Stock.Location = new System.Drawing.Point(12, 12);
            this.cmb_Stock.Name = "cmb_Stock";
            this.cmb_Stock.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_Stock.Size = new System.Drawing.Size(195, 27);
            this.cmb_Stock.TabIndex = 130;
            // 
            // txt_username
            // 
            this.txt_username.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_username.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(322, 8);
            this.txt_username.Name = "txt_username";
            this.txt_username.ReadOnly = true;
            this.txt_username.Size = new System.Drawing.Size(265, 32);
            this.txt_username.TabIndex = 133;
            this.txt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(588, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 132;
            this.label2.Text = "اسم المستخدم";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(322, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox1.Size = new System.Drawing.Size(265, 32);
            this.comboBox1.TabIndex = 137;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(213, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 135;
            this.label3.Text = "التاريخ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(624, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 24);
            this.label6.TabIndex = 134;
            this.label6.Text = "فرع";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(18, 45);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(147, 34);
            this.dateTimePicker1.TabIndex = 138;
            // 
            // txt_patientname
            // 
            this.txt_patientname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_patientname.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patientname.Location = new System.Drawing.Point(39, 95);
            this.txt_patientname.Name = "txt_patientname";
            this.txt_patientname.ReadOnly = true;
            this.txt_patientname.Size = new System.Drawing.Size(62, 32);
            this.txt_patientname.TabIndex = 139;
            this.txt_patientname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Frm_TransferToCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(699, 486);
            this.Controls.Add(this.txt_patientname);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_Stock);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_payLat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.cmb_Company);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Frm_TransferToCompany";
            this.Text = "Frm_TransferToCompany";
            this.Load += new System.EventHandler(this.Frm_TransferToCompany_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cmb_Company;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_reasonAddition;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label txt_total;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label txt_payLat;
        private System.Windows.Forms.Label Txt_rentCompany;
        private System.Windows.Forms.Label txt_rentCust;
        private System.Windows.Forms.Label Txt_PricePayment;
        private System.Windows.Forms.TextBox Txt_addtionPayment;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_Stock;
        public System.Windows.Forms.TextBox txt_username;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.TextBox txt_patientname;
    }
}