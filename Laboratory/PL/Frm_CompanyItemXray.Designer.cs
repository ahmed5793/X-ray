namespace Laboratory.PL
{
    partial class Frm_CompanyItemXray
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CompanyItemXray));
            this.Cmb_category = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmb_items = new System.Windows.Forms.ComboBox();
            this.cmb_Company = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.Txt_Price = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dgv_visit = new System.Windows.Forms.DataGridView();
            this.label22 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Discount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_PriceDiscount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_New = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Update = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_visit)).BeginInit();
            this.SuspendLayout();
            // 
            // Cmb_category
            // 
            this.Cmb_category.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Cmb_category.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.Cmb_category.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_category.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_category.FormattingEnabled = true;
            this.Cmb_category.ItemHeight = 24;
            this.Cmb_category.Location = new System.Drawing.Point(155, 94);
            this.Cmb_category.Name = "Cmb_category";
            this.Cmb_category.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Cmb_category.Size = new System.Drawing.Size(366, 32);
            this.Cmb_category.TabIndex = 1;
            this.Cmb_category.SelectedIndexChanged += new System.EventHandler(this.Cmb_category_SelectedIndexChanged);
            this.Cmb_category.SelectionChangeCommitted += new System.EventHandler(this.Cmb_category_SelectionChangeCommitted);
            this.Cmb_category.Leave += new System.EventHandler(this.Cmb_category_Leave);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(527, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 24);
            this.label9.TabIndex = 90;
            this.label9.Text = "نوع الفحص";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Black;
            this.label10.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(527, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 24);
            this.label10.TabIndex = 91;
            this.label10.Text = "الجهاز";
            // 
            // cmb_items
            // 
            this.cmb_items.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmb_items.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_items.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_items.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_items.FormattingEnabled = true;
            this.cmb_items.ItemHeight = 24;
            this.cmb_items.Location = new System.Drawing.Point(155, 137);
            this.cmb_items.Name = "cmb_items";
            this.cmb_items.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_items.Size = new System.Drawing.Size(366, 32);
            this.cmb_items.TabIndex = 2;
            this.cmb_items.SelectionChangeCommitted += new System.EventHandler(this.cmb_items_SelectionChangeCommitted);
            this.cmb_items.Leave += new System.EventHandler(this.cmb_items_Leave);
            // 
            // cmb_Company
            // 
            this.cmb_Company.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmb_Company.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_Company.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Company.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Company.FormattingEnabled = true;
            this.cmb_Company.Location = new System.Drawing.Point(155, 50);
            this.cmb_Company.Name = "cmb_Company";
            this.cmb_Company.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_Company.Size = new System.Drawing.Size(366, 32);
            this.cmb_Company.TabIndex = 0;
            this.cmb_Company.SelectedIndexChanged += new System.EventHandler(this.cmb_Company_SelectedIndexChanged);
            this.cmb_Company.Leave += new System.EventHandler(this.cmb_Company_Leave);
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Black;
            this.label21.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label21.Location = new System.Drawing.Point(526, 56);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(91, 24);
            this.label21.TabIndex = 93;
            this.label21.Text = "اسم الشركة";
            // 
            // Txt_Price
            // 
            this.Txt_Price.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_Price.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Price.Location = new System.Drawing.Point(489, 207);
            this.Txt_Price.Name = "Txt_Price";
            this.Txt_Price.ReadOnly = true;
            this.Txt_Price.Size = new System.Drawing.Size(165, 32);
            this.Txt_Price.TabIndex = 3;
            this.Txt_Price.Text = "0";
            this.Txt_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Price_KeyPress);
            this.Txt_Price.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Txt_Price_MouseMove);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(486, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 24);
            this.label2.TabIndex = 96;
            this.label2.Text = "السعر للمستهلك العادى";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.dgv_visit);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Location = new System.Drawing.Point(3, 316);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(707, 233);
            this.groupBox1.TabIndex = 101;
            this.groupBox1.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(121, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(233, 32);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dgv_visit
            // 
            this.dgv_visit.AllowUserToAddRows = false;
            this.dgv_visit.AllowUserToDeleteRows = false;
            this.dgv_visit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_visit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_visit.BackgroundColor = System.Drawing.Color.Maroon;
            this.dgv_visit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_visit.Location = new System.Drawing.Point(6, 57);
            this.dgv_visit.Name = "dgv_visit";
            this.dgv_visit.ReadOnly = true;
            this.dgv_visit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_visit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_visit.ShowEditingIcon = false;
            this.dgv_visit.Size = new System.Drawing.Size(695, 169);
            this.dgv_visit.TabIndex = 102;
            this.dgv_visit.DoubleClick += new System.EventHandler(this.dgv_visit_DoubleClick);
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.SeaShell;
            this.label22.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(368, 22);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(242, 24);
            this.label22.TabIndex = 101;
            this.label22.Text = "بحث بأسم الشركة أو نوع الفحص";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "خصم ",
            "أسعار متفق عليها"});
            this.comboBox1.Location = new System.Drawing.Point(232, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox1.Size = new System.Drawing.Size(199, 32);
            this.comboBox1.TabIndex = 104;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(437, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 24);
            this.label3.TabIndex = 105;
            this.label3.Text = "نوع التعامل مع الشركة";
            // 
            // Txt_Discount
            // 
            this.Txt_Discount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_Discount.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Discount.Location = new System.Drawing.Point(304, 207);
            this.Txt_Discount.Name = "Txt_Discount";
            this.Txt_Discount.Size = new System.Drawing.Size(127, 32);
            this.Txt_Discount.TabIndex = 106;
            this.Txt_Discount.Text = "0";
            this.Txt_Discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_Discount.Click += new System.EventHandler(this.Txt_Discount_Click);
            this.Txt_Discount.TextChanged += new System.EventHandler(this.Txt_Discount_TextChanged);
            this.Txt_Discount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Discount_KeyPress);
            this.Txt_Discount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_Discount_KeyUp);
            this.Txt_Discount.MouseLeave += new System.EventHandler(this.Txt_Discount_MouseLeave);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(320, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 24);
            this.label4.TabIndex = 107;
            this.label4.Text = "نسبة الخصم";
            // 
            // Txt_PriceDiscount
            // 
            this.Txt_PriceDiscount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_PriceDiscount.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_PriceDiscount.Location = new System.Drawing.Point(74, 207);
            this.Txt_PriceDiscount.Name = "Txt_PriceDiscount";
            this.Txt_PriceDiscount.Size = new System.Drawing.Size(169, 32);
            this.Txt_PriceDiscount.TabIndex = 108;
            this.Txt_PriceDiscount.Text = "0";
            this.Txt_PriceDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_PriceDiscount.Click += new System.EventHandler(this.Txt_PriceDiscount_Click);
            this.Txt_PriceDiscount.TextChanged += new System.EventHandler(this.Txt_PriceDiscount_TextChanged);
            this.Txt_PriceDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_PriceDiscount_KeyPress);
            this.Txt_PriceDiscount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_PriceDiscount_KeyUp);
            this.Txt_PriceDiscount.Layout += new System.Windows.Forms.LayoutEventHandler(this.Txt_PriceDiscount_Layout);
            this.Txt_PriceDiscount.Leave += new System.EventHandler(this.Txt_PriceDiscount_Leave);
            this.Txt_PriceDiscount.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Txt_PriceDiscount_MouseMove);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(71, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 24);
            this.label5.TabIndex = 109;
            this.label5.Text = "سعر الشركة بعد الخصم";
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_Delete.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Delete.Location = new System.Drawing.Point(22, 12);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(54, 40);
            this.Btn_Delete.TabIndex = 111;
            this.Btn_Delete.Text = "مسح ";
            this.Btn_Delete.UseVisualStyleBackColor = true;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Btn_New
            // 
            this.Btn_New.Appearance.BackColor = System.Drawing.Color.Black;
            this.Btn_New.Appearance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_New.Appearance.ForeColor = System.Drawing.Color.White;
            this.Btn_New.Appearance.Options.UseBackColor = true;
            this.Btn_New.Appearance.Options.UseFont = true;
            this.Btn_New.Appearance.Options.UseForeColor = true;
            this.Btn_New.Appearance.Options.UseTextOptions = true;
            this.Btn_New.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Btn_New.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Btn_New.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.Btn_New.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.Btn_New.Location = new System.Drawing.Point(509, 270);
            this.Btn_New.Name = "Btn_New";
            this.Btn_New.Size = new System.Drawing.Size(129, 32);
            this.Btn_New.TabIndex = 177;
            this.Btn_New.Text = "تسجيل جديد";
            this.Btn_New.Click += new System.EventHandler(this.simpleButton1_Click);
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
            this.Btn_Update.Location = new System.Drawing.Point(105, 270);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(138, 32);
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
            this.Btn_Add.Location = new System.Drawing.Point(313, 270);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(136, 32);
            this.Btn_Add.TabIndex = 175;
            this.Btn_Add.Text = "حفظ";
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Frm_CompanyItemXray
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(713, 554);
            this.Controls.Add(this.Btn_New);
            this.Controls.Add(this.Btn_Update);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.Txt_PriceDiscount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txt_Discount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Txt_Price);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cmb_category);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmb_items);
            this.Controls.Add(this.cmb_Company);
            this.Controls.Add(this.label21);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(687, 533);
            this.Name = "Frm_CompanyItemXray";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة الفحوصات للشركات";
            this.Load += new System.EventHandler(this.Frm_CompanyItemXray_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_visit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox Cmb_category;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.ComboBox cmb_items;
        public System.Windows.Forms.ComboBox cmb_Company;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox Txt_Price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.DataGridView dgv_visit;
        private System.Windows.Forms.Label label22;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Discount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_PriceDiscount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btn_Delete;
        private DevExpress.XtraEditors.SimpleButton Btn_New;
        private DevExpress.XtraEditors.SimpleButton Btn_Update;
        private DevExpress.XtraEditors.SimpleButton Btn_Add;
    }
}