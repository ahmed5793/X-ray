namespace Laboratory.PL
{
    partial class Frm_AddTechnicalShift
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AddTechnicalShift));
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Txt_Cost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Btn_AddShift = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_UpdateShift = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_DeleteShift = new DevExpress.XtraEditors.SimpleButton();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_SalesMAn = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Cmb_Branch = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Yellow;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(856, 83);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(59, 19);
            this.label7.TabIndex = 102;
            this.label7.Text = "إسم الفنى";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(577, 80);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox1.Size = new System.Drawing.Size(273, 27);
            this.comboBox1.TabIndex = 101;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            this.comboBox1.Leave += new System.EventHandler(this.comboBox1_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(856, 125);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 104;
            this.label1.Text = "نوع الشيفت";
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(577, 121);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox2.Size = new System.Drawing.Size(273, 27);
            this.comboBox2.TabIndex = 103;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.comboBox2.SelectionChangeCommitted += new System.EventHandler(this.comboBox2_SelectionChangeCommitted);
            this.comboBox2.SelectedValueChanged += new System.EventHandler(this.comboBox2_SelectedValueChanged);
            this.comboBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox2_KeyDown);
            this.comboBox2.Leave += new System.EventHandler(this.comboBox2_Leave);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(515, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 28);
            this.button1.TabIndex = 105;
            this.button1.Text = "+++";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Txt_Cost
            // 
            this.Txt_Cost.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Cost.Location = new System.Drawing.Point(12, 127);
            this.Txt_Cost.MaxLength = 11;
            this.Txt_Cost.Name = "Txt_Cost";
            this.Txt_Cost.ReadOnly = true;
            this.Txt_Cost.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Txt_Cost.Size = new System.Drawing.Size(143, 26);
            this.Txt_Cost.TabIndex = 116;
            this.Txt_Cost.Text = "0";
            this.Txt_Cost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_Cost.Click += new System.EventHandler(this.Txt_Cost_Click);
            this.Txt_Cost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Cost_KeyPress);
            this.Txt_Cost.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Txt_Cost_MouseMove);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Yellow;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(161, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 19);
            this.label5.TabIndex = 117;
            this.label5.Text = "سعر الشيفت";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "   dd/MM/yyyy    ";
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(9, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(146, 26);
            this.dateTimePicker1.TabIndex = 118;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(161, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 119;
            this.label2.Text = "التاريخ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(161, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 121;
            this.label3.Text = "إلى وقت";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "";
            this.dateTimePicker2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(12, 85);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(143, 26);
            this.dateTimePicker2.TabIndex = 120;
            this.dateTimePicker2.Value = new System.DateTime(2020, 1, 2, 0, 18, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Yellow;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(161, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 19);
            this.label4.TabIndex = 123;
            this.label4.Text = "من وقت";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "tt HH:MM";
            this.dateTimePicker3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker3.Location = new System.Drawing.Point(12, 45);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.ShowUpDown = true;
            this.dateTimePicker3.Size = new System.Drawing.Size(143, 26);
            this.dateTimePicker3.TabIndex = 122;
            this.dateTimePicker3.Value = new System.DateTime(2020, 1, 2, 18, 43, 0, 0);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.gridControl1);
            this.groupBox2.Location = new System.Drawing.Point(3, 247);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(946, 288);
            this.groupBox2.TabIndex = 127;
            this.groupBox2.TabStop = false;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridControl1.Location = new System.Drawing.Point(7, 16);
            this.gridControl1.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.gridControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridControl1.Size = new System.Drawing.Size(932, 263);
            this.gridControl1.TabIndex = 129;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.Aqua;
            this.gridView1.Appearance.FocusedCell.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedCell.Options.UseFont = true;
            this.gridView1.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridView1.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.gridView1.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FocusedCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.FocusedCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.Yellow;
            this.gridView1.Appearance.FocusedRow.BorderColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.FocusedRow.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView1.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FocusedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.FocusedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Yellow;
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.Row.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.Row.Options.UseTextOptions = true;
            this.gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.Yellow;
            this.gridView1.Appearance.SelectedRow.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView1.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView1.AppearancePrint.HeaderPanel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.AppearancePrint.HeaderPanel.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridView1.AppearancePrint.HeaderPanel.Options.UseFont = true;
            this.gridView1.AppearancePrint.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.AppearancePrint.Row.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.AppearancePrint.Row.Options.UseFont = true;
            this.gridView1.AppearancePrint.Row.Options.UseTextOptions = true;
            this.gridView1.AppearancePrint.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsPrint.PrintPreview = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // Btn_AddShift
            // 
            this.Btn_AddShift.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_AddShift.Appearance.BackColor = System.Drawing.Color.Black;
            this.Btn_AddShift.Appearance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AddShift.Appearance.ForeColor = System.Drawing.Color.White;
            this.Btn_AddShift.Appearance.Options.UseBackColor = true;
            this.Btn_AddShift.Appearance.Options.UseFont = true;
            this.Btn_AddShift.Appearance.Options.UseForeColor = true;
            this.Btn_AddShift.Appearance.Options.UseTextOptions = true;
            this.Btn_AddShift.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Btn_AddShift.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Btn_AddShift.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.Btn_AddShift.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_AddShift.ImageOptions.Image")));
            this.Btn_AddShift.Location = new System.Drawing.Point(539, 195);
            this.Btn_AddShift.Name = "Btn_AddShift";
            this.Btn_AddShift.Size = new System.Drawing.Size(167, 32);
            this.Btn_AddShift.TabIndex = 165;
            this.Btn_AddShift.Text = "إضافة الشيفت للفنى";
            this.Btn_AddShift.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Btn_UpdateShift
            // 
            this.Btn_UpdateShift.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_UpdateShift.Appearance.BackColor = System.Drawing.Color.Black;
            this.Btn_UpdateShift.Appearance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_UpdateShift.Appearance.ForeColor = System.Drawing.Color.White;
            this.Btn_UpdateShift.Appearance.Options.UseBackColor = true;
            this.Btn_UpdateShift.Appearance.Options.UseFont = true;
            this.Btn_UpdateShift.Appearance.Options.UseForeColor = true;
            this.Btn_UpdateShift.Appearance.Options.UseTextOptions = true;
            this.Btn_UpdateShift.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Btn_UpdateShift.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Btn_UpdateShift.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.Btn_UpdateShift.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.Btn_UpdateShift.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.Btn_UpdateShift.AppearanceDisabled.Options.UseBackColor = true;
            this.Btn_UpdateShift.AppearanceDisabled.Options.UseForeColor = true;
            this.Btn_UpdateShift.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_UpdateShift.ImageOptions.Image")));
            this.Btn_UpdateShift.Location = new System.Drawing.Point(313, 195);
            this.Btn_UpdateShift.Name = "Btn_UpdateShift";
            this.Btn_UpdateShift.Size = new System.Drawing.Size(167, 32);
            this.Btn_UpdateShift.TabIndex = 166;
            this.Btn_UpdateShift.Text = "تعديل الشيفت للفنى";
            this.Btn_UpdateShift.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // Btn_DeleteShift
            // 
            this.Btn_DeleteShift.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_DeleteShift.Appearance.BackColor = System.Drawing.Color.Black;
            this.Btn_DeleteShift.Appearance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_DeleteShift.Appearance.ForeColor = System.Drawing.Color.White;
            this.Btn_DeleteShift.Appearance.Options.UseBackColor = true;
            this.Btn_DeleteShift.Appearance.Options.UseFont = true;
            this.Btn_DeleteShift.Appearance.Options.UseForeColor = true;
            this.Btn_DeleteShift.Appearance.Options.UseTextOptions = true;
            this.Btn_DeleteShift.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Btn_DeleteShift.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Btn_DeleteShift.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.Btn_DeleteShift.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_DeleteShift.ImageOptions.Image")));
            this.Btn_DeleteShift.Location = new System.Drawing.Point(80, 195);
            this.Btn_DeleteShift.Name = "Btn_DeleteShift";
            this.Btn_DeleteShift.Size = new System.Drawing.Size(167, 32);
            this.Btn_DeleteShift.TabIndex = 167;
            this.Btn_DeleteShift.Text = "مسح الشيفت للفنى";
            this.Btn_DeleteShift.Click += new System.EventHandler(this.simpleButton1_Click_2);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Yellow;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(855, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 19);
            this.label8.TabIndex = 178;
            this.label8.Text = "إسم المستخدم";
            // 
            // Txt_SalesMAn
            // 
            this.Txt_SalesMAn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_SalesMAn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_SalesMAn.Location = new System.Drawing.Point(577, 5);
            this.Txt_SalesMAn.Multiline = true;
            this.Txt_SalesMAn.Name = "Txt_SalesMAn";
            this.Txt_SalesMAn.ReadOnly = true;
            this.Txt_SalesMAn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_SalesMAn.Size = new System.Drawing.Size(273, 27);
            this.Txt_SalesMAn.TabIndex = 175;
            this.Txt_SalesMAn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Yellow;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(857, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 19);
            this.label9.TabIndex = 176;
            this.label9.Text = "الفرع";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cmb_Branch
            // 
            this.Cmb_Branch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cmb_Branch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Cmb_Branch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_Branch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Branch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Branch.FormattingEnabled = true;
            this.Cmb_Branch.Location = new System.Drawing.Point(577, 41);
            this.Cmb_Branch.Name = "Cmb_Branch";
            this.Cmb_Branch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Cmb_Branch.Size = new System.Drawing.Size(275, 27);
            this.Cmb_Branch.TabIndex = 177;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(386, 5);
            this.textBox1.MaxLength = 11;
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(79, 26);
            this.textBox1.TabIndex = 179;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.simpleButton1.Location = new System.Drawing.Point(741, 195);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(154, 32);
            this.simpleButton1.TabIndex = 180;
            this.simpleButton1.Text = "جديد";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click_3);
            // 
            // Frm_AddTechnicalShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(951, 542);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Txt_SalesMAn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Cmb_Branch);
            this.Controls.Add(this.Btn_DeleteShift);
            this.Controls.Add(this.Btn_UpdateShift);
            this.Controls.Add(this.Btn_AddShift);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Txt_Cost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1);
            this.MinimumSize = new System.Drawing.Size(967, 580);
            this.Name = "Frm_AddTechnicalShift";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة إضافة الشيفتات للفنين";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_AddTechnicalShift_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Txt_Cost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton Btn_AddShift;
        private DevExpress.XtraEditors.SimpleButton Btn_UpdateShift;
        private DevExpress.XtraEditors.SimpleButton Btn_DeleteShift;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Txt_SalesMAn;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.ComboBox Cmb_Branch;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.TextBox textBox1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}