namespace Laboratory.PL
{
    partial class Frm_ReportInsertStock
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
            this.cmb_Stock = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DateTo = new System.Windows.Forms.DateTimePicker();
            this.DateFrom = new System.Windows.Forms.DateTimePicker();
            this.btn_search = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridControlInsert = new DevExpress.XtraGrid.GridControl();
            this.gridViewInsert = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridControlPull = new DevExpress.XtraGrid.GridControl();
            this.gridViewPull = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_UserBranch = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlInsert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewInsert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPull)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPull)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_Stock
            // 
            this.cmb_Stock.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmb_Stock.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_Stock.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Stock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Stock.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Stock.FormattingEnabled = true;
            this.cmb_Stock.Location = new System.Drawing.Point(377, 3);
            this.cmb_Stock.Name = "cmb_Stock";
            this.cmb_Stock.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_Stock.Size = new System.Drawing.Size(218, 32);
            this.cmb_Stock.TabIndex = 112;
            this.cmb_Stock.SelectionChangeCommitted += new System.EventHandler(this.cmb_Stock_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Yellow;
            this.label7.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(600, 4);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(100, 29);
            this.label7.TabIndex = 111;
            this.label7.Text = "إسم الخزنة";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.Color.Beige;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(375, 114);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 110;
            this.label1.Text = "إجمالى المبالغ المضافة\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Yellow;
            this.textBox1.Location = new System.Drawing.Point(200, 111);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(171, 30);
            this.textBox1.TabIndex = 109;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DateTo
            // 
            this.DateTo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DateTo.CustomFormat = "   dd/MM/yyyy       *      tt  mm:hh    ";
            this.DateTo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTo.Location = new System.Drawing.Point(355, 44);
            this.DateTo.Name = "DateTo";
            this.DateTo.ShowUpDown = true;
            this.DateTo.Size = new System.Drawing.Size(106, 25);
            this.DateTo.TabIndex = 108;
            // 
            // DateFrom
            // 
            this.DateFrom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DateFrom.CustomFormat = "   dd/MM/yyyy       *      tt  mm:hh    ";
            this.DateFrom.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateFrom.Location = new System.Drawing.Point(542, 45);
            this.DateFrom.Name = "DateFrom";
            this.DateFrom.ShowUpDown = true;
            this.DateFrom.Size = new System.Drawing.Size(110, 25);
            this.DateFrom.TabIndex = 107;
            // 
            // btn_search
            // 
            this.btn_search.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_search.BackColor = System.Drawing.Color.Black;
            this.btn_search.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.Yellow;
            this.btn_search.Location = new System.Drawing.Point(135, 18);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(129, 43);
            this.btn_search.TabIndex = 106;
            this.btn_search.Text = "بحث";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.BackColor = System.Drawing.Color.LightGray;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(467, 45);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(45, 25);
            this.label4.TabIndex = 105;
            this.label4.Text = "إلى :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(656, 46);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(47, 24);
            this.label3.TabIndex = 104;
            this.label3.Text = " : من";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Location = new System.Drawing.Point(5, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1051, 157);
            this.groupBox1.TabIndex = 160;
            this.groupBox1.TabStop = false;
            // 
            // gridControlInsert
            // 
            this.gridControlInsert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlInsert.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridControlInsert.Location = new System.Drawing.Point(16, 166);
            this.gridControlInsert.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.gridControlInsert.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControlInsert.MainView = this.gridViewInsert;
            this.gridControlInsert.Name = "gridControlInsert";
            this.gridControlInsert.Size = new System.Drawing.Size(1036, 132);
            this.gridControlInsert.TabIndex = 127;
            this.gridControlInsert.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewInsert});
            // 
            // gridViewInsert
            // 
            this.gridViewInsert.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewInsert.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridViewInsert.Appearance.HeaderPanel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewInsert.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Yellow;
            this.gridViewInsert.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewInsert.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewInsert.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewInsert.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewInsert.Appearance.Row.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewInsert.Appearance.Row.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridViewInsert.Appearance.Row.Options.UseFont = true;
            this.gridViewInsert.Appearance.Row.Options.UseTextOptions = true;
            this.gridViewInsert.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewInsert.AppearancePrint.HeaderPanel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewInsert.AppearancePrint.HeaderPanel.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridViewInsert.AppearancePrint.HeaderPanel.Options.UseFont = true;
            this.gridViewInsert.AppearancePrint.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewInsert.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewInsert.AppearancePrint.Row.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewInsert.AppearancePrint.Row.Options.UseFont = true;
            this.gridViewInsert.AppearancePrint.Row.Options.UseTextOptions = true;
            this.gridViewInsert.AppearancePrint.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewInsert.GridControl = this.gridControlInsert;
            this.gridViewInsert.Name = "gridViewInsert";
            this.gridViewInsert.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewInsert.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewInsert.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gridViewInsert.OptionsBehavior.Editable = false;
            this.gridViewInsert.OptionsBehavior.ReadOnly = true;
            this.gridViewInsert.OptionsPrint.PrintPreview = true;
            this.gridViewInsert.OptionsView.ShowFooter = true;
            this.gridViewInsert.OptionsView.ShowGroupPanel = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Location = new System.Drawing.Point(5, 349);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1047, 185);
            this.groupBox2.TabIndex = 161;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // gridControlPull
            // 
            this.gridControlPull.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlPull.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridControlPull.Location = new System.Drawing.Point(11, 368);
            this.gridControlPull.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.gridControlPull.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControlPull.MainView = this.gridViewPull;
            this.gridControlPull.Name = "gridControlPull";
            this.gridControlPull.Size = new System.Drawing.Size(1035, 155);
            this.gridControlPull.TabIndex = 127;
            this.gridControlPull.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPull});
            this.gridControlPull.Click += new System.EventHandler(this.gridControlPull_Click);
            // 
            // gridViewPull
            // 
            this.gridViewPull.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewPull.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridViewPull.Appearance.HeaderPanel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewPull.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Yellow;
            this.gridViewPull.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewPull.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewPull.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewPull.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewPull.Appearance.Row.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewPull.Appearance.Row.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridViewPull.Appearance.Row.Options.UseFont = true;
            this.gridViewPull.Appearance.Row.Options.UseTextOptions = true;
            this.gridViewPull.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewPull.AppearancePrint.HeaderPanel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewPull.AppearancePrint.HeaderPanel.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridViewPull.AppearancePrint.HeaderPanel.Options.UseFont = true;
            this.gridViewPull.AppearancePrint.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewPull.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewPull.AppearancePrint.Row.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewPull.AppearancePrint.Row.Options.UseFont = true;
            this.gridViewPull.AppearancePrint.Row.Options.UseTextOptions = true;
            this.gridViewPull.AppearancePrint.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewPull.GridControl = this.gridControlPull;
            this.gridViewPull.Name = "gridViewPull";
            this.gridViewPull.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewPull.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewPull.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gridViewPull.OptionsBehavior.Editable = false;
            this.gridViewPull.OptionsBehavior.ReadOnly = true;
            this.gridViewPull.OptionsPrint.PrintPreview = true;
            this.gridViewPull.OptionsView.ShowFooter = true;
            this.gridViewPull.OptionsView.ShowGroupPanel = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.BackColor = System.Drawing.Color.Beige;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(364, 313);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(200, 30);
            this.label5.TabIndex = 129;
            this.label5.Text = "إجمالى المبالغ المسحوبة\r\n";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Yellow;
            this.textBox2.Location = new System.Drawing.Point(189, 310);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(171, 33);
            this.textBox2.TabIndex = 128;
            this.textBox2.Text = "0";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.Ivory;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(797, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(237, 28);
            this.label6.TabIndex = 162;
            this.label6.Text = "عرض الارصدة المضافة الى الخزنة";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.BackColor = System.Drawing.Color.Ivory;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(784, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(250, 32);
            this.label8.TabIndex = 128;
            this.label8.Text = "عرض الارصدة المسحوبة من الخزنة";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_UserBranch
            // 
            this.cmb_UserBranch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_UserBranch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_UserBranch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_UserBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_UserBranch.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_UserBranch.FormattingEnabled = true;
            this.cmb_UserBranch.Location = new System.Drawing.Point(784, 42);
            this.cmb_UserBranch.Name = "cmb_UserBranch";
            this.cmb_UserBranch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_UserBranch.Size = new System.Drawing.Size(203, 26);
            this.cmb_UserBranch.TabIndex = 181;
            this.cmb_UserBranch.SelectionChangeCommitted += new System.EventHandler(this.cmb_UserBranch_SelectionChangeCommitted);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Yellow;
            this.label13.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(999, 45);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 18);
            this.label13.TabIndex = 180;
            this.label13.Text = "الفرع";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Yellow;
            this.label10.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(995, 11);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(53, 18);
            this.label10.TabIndex = 179;
            this.label10.Text = "المستخدم";
            // 
            // txt_UserName
            // 
            this.txt_UserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_UserName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UserName.Location = new System.Drawing.Point(784, 7);
            this.txt_UserName.Multiline = true;
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.ReadOnly = true;
            this.txt_UserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_UserName.Size = new System.Drawing.Size(203, 25);
            this.txt_UserName.TabIndex = 178;
            this.txt_UserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Frm_ReportInsertStock
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1058, 542);
            this.Controls.Add(this.cmb_UserBranch);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gridControlPull);
            this.Controls.Add(this.gridControlInsert);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmb_Stock);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DateTo);
            this.Controls.Add(this.DateFrom);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(967, 580);
            this.Name = "Frm_ReportInsertStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقرير حركة الخزنة";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_ReportInsertStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlInsert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewInsert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPull)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPull)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Stock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker DateTo;
        private System.Windows.Forms.DateTimePicker DateFrom;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.GridControl gridControlPull;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPull;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl gridControlInsert;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewInsert;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.ComboBox cmb_UserBranch;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_UserName;
    }
}