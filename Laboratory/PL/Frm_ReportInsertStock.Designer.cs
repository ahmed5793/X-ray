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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ReportInsertStock));
            this.cmb_Stock = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DateTo = new System.Windows.Forms.DateTimePicker();
            this.DateFrom = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridControlInsert = new DevExpress.XtraGrid.GridControl();
            this.gridViewInsert = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_search = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.cmb_UserBranch = new System.Windows.Forms.ComboBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlInsert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewInsert)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_Stock
            // 
            this.cmb_Stock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Stock.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_Stock.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Stock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Stock.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Stock.FormattingEnabled = true;
            this.cmb_Stock.Location = new System.Drawing.Point(691, 79);
            this.cmb_Stock.Name = "cmb_Stock";
            this.cmb_Stock.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_Stock.Size = new System.Drawing.Size(233, 27);
            this.cmb_Stock.TabIndex = 112;
            this.cmb_Stock.SelectionChangeCommitted += new System.EventHandler(this.cmb_Stock_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Yellow;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(929, 82);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(67, 19);
            this.label7.TabIndex = 111;
            this.label7.Text = "إسم الخزنة";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.BackColor = System.Drawing.Color.Beige;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(641, 505);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 110;
            this.label1.Text = "إجمالى المبالغ المضافة\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Yellow;
            this.textBox1.Location = new System.Drawing.Point(462, 503);
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
            this.DateTo.Location = new System.Drawing.Point(383, 81);
            this.DateTo.Name = "DateTo";
            this.DateTo.ShowUpDown = true;
            this.DateTo.Size = new System.Drawing.Size(158, 25);
            this.DateTo.TabIndex = 108;
            // 
            // DateFrom
            // 
            this.DateFrom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DateFrom.CustomFormat = "   dd/MM/yyyy       *      tt  mm:hh    ";
            this.DateFrom.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateFrom.Location = new System.Drawing.Point(383, 41);
            this.DateFrom.Name = "DateFrom";
            this.DateFrom.ShowUpDown = true;
            this.DateFrom.Size = new System.Drawing.Size(159, 25);
            this.DateFrom.TabIndex = 107;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.BackColor = System.Drawing.Color.Yellow;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(550, 81);
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
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(548, 42);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(47, 24);
            this.label3.TabIndex = 104;
            this.label3.Text = " : من";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Location = new System.Drawing.Point(3, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1017, 365);
            this.groupBox1.TabIndex = 160;
            this.groupBox1.TabStop = false;
            // 
            // gridControlInsert
            // 
            this.gridControlInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlInsert.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridControlInsert.Location = new System.Drawing.Point(12, 133);
            this.gridControlInsert.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.gridControlInsert.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControlInsert.MainView = this.gridViewInsert;
            this.gridControlInsert.Name = "gridControlInsert";
            this.gridControlInsert.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridControlInsert.Size = new System.Drawing.Size(1004, 337);
            this.gridControlInsert.TabIndex = 127;
            this.gridControlInsert.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewInsert});
            // 
            // gridViewInsert
            // 
            this.gridViewInsert.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridViewInsert.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridViewInsert.Appearance.FocusedCell.BackColor = System.Drawing.Color.Aqua;
            this.gridViewInsert.Appearance.FocusedCell.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridViewInsert.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gridViewInsert.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridViewInsert.Appearance.FocusedCell.Options.UseFont = true;
            this.gridViewInsert.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridViewInsert.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.gridViewInsert.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewInsert.Appearance.FocusedCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewInsert.Appearance.FocusedCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.gridViewInsert.Appearance.FocusedRow.BackColor = System.Drawing.Color.Yellow;
            this.gridViewInsert.Appearance.FocusedRow.BorderColor = System.Drawing.Color.Black;
            this.gridViewInsert.Appearance.FocusedRow.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridViewInsert.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewInsert.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewInsert.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridViewInsert.Appearance.FocusedRow.Options.UseFont = true;
            this.gridViewInsert.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewInsert.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.gridViewInsert.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewInsert.Appearance.FocusedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewInsert.Appearance.FocusedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.gridViewInsert.Appearance.HeaderPanel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.gridViewInsert.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Yellow;
            this.gridViewInsert.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewInsert.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewInsert.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewInsert.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewInsert.Appearance.Row.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridViewInsert.Appearance.Row.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridViewInsert.Appearance.Row.Options.UseFont = true;
            this.gridViewInsert.Appearance.Row.Options.UseTextOptions = true;
            this.gridViewInsert.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewInsert.Appearance.SelectedRow.BackColor = System.Drawing.Color.Yellow;
            this.gridViewInsert.Appearance.SelectedRow.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridViewInsert.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewInsert.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewInsert.Appearance.SelectedRow.Options.UseFont = true;
            this.gridViewInsert.Appearance.SelectedRow.Options.UseForeColor = true;
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
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.BackColor = System.Drawing.Color.Ivory;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(316, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(299, 28);
            this.label6.TabIndex = 162;
            this.label6.Text = "عرض تقرير الارصدة المضافة الى الخزنة";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_search
            // 
            this.btn_search.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_search.Appearance.BackColor = System.Drawing.Color.Black;
            this.btn_search.Appearance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_search.Appearance.Options.UseBackColor = true;
            this.btn_search.Appearance.Options.UseFont = true;
            this.btn_search.Appearance.Options.UseForeColor = true;
            this.btn_search.Appearance.Options.UseTextOptions = true;
            this.btn_search.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btn_search.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btn_search.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btn_search.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.ImageOptions.Image")));
            this.btn_search.Location = new System.Drawing.Point(197, 54);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(134, 38);
            this.btn_search.TabIndex = 208;
            this.btn_search.Text = "بحث  ";
            this.btn_search.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
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
            this.simpleButton1.Location = new System.Drawing.Point(217, 498);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(144, 32);
            this.simpleButton1.TabIndex = 213;
            this.simpleButton1.Text = "طباعة التقرير";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // cmb_UserBranch
            // 
            this.cmb_UserBranch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_UserBranch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_UserBranch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_UserBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_UserBranch.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_UserBranch.FormattingEnabled = true;
            this.cmb_UserBranch.Location = new System.Drawing.Point(691, 39);
            this.cmb_UserBranch.Name = "cmb_UserBranch";
            this.cmb_UserBranch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_UserBranch.Size = new System.Drawing.Size(233, 26);
            this.cmb_UserBranch.TabIndex = 212;
            this.cmb_UserBranch.SelectionChangeCommitted += new System.EventHandler(this.cmb_UserBranch_SelectionChangeCommitted);
            // 
            // txt_username
            // 
            this.txt_username.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_username.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(691, 3);
            this.txt_username.Name = "txt_username";
            this.txt_username.ReadOnly = true;
            this.txt_username.Size = new System.Drawing.Size(233, 25);
            this.txt_username.TabIndex = 209;
            this.txt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Yellow;
            this.label18.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(929, 5);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(81, 19);
            this.label18.TabIndex = 210;
            this.label18.Text = "اسم المستخدم";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Yellow;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(930, 42);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 19);
            this.label13.TabIndex = 211;
            this.label13.Text = "الفرع";
            // 
            // Frm_ReportInsertStock
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1022, 542);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.cmb_UserBranch);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.gridControlInsert);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmb_Stock);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DateTo);
            this.Controls.Add(this.DateFrom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(967, 580);
            this.Name = "Frm_ReportInsertStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقرير الارصدة المضافة إلى الخزنة";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_ReportInsertStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlInsert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewInsert)).EndInit();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl gridControlInsert;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewInsert;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SimpleButton btn_search;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        public System.Windows.Forms.ComboBox cmb_UserBranch;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label13;
    }
}