namespace Laboratory.PL
{
    partial class Frm_ManagmentTickets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ManagmentTickets));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_branches = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ToDate = new System.Windows.Forms.DateTimePicker();
            this.FromDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.button1 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_print = new DevExpress.XtraEditors.SimpleButton();
            this.btn_save = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cmb_branches);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txt_username);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Location = new System.Drawing.Point(8, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(893, 51);
            this.groupBox1.TabIndex = 99;
            this.groupBox1.TabStop = false;
            // 
            // cmb_branches
            // 
            this.cmb_branches.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_branches.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_branches.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_branches.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_branches.FormattingEnabled = true;
            this.cmb_branches.Location = new System.Drawing.Point(56, 12);
            this.cmb_branches.Name = "cmb_branches";
            this.cmb_branches.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_branches.Size = new System.Drawing.Size(233, 32);
            this.cmb_branches.TabIndex = 84;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(293, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 24);
            this.label13.TabIndex = 83;
            this.label13.Text = "مكان الفحص";
            // 
            // txt_username
            // 
            this.txt_username.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_username.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(514, 12);
            this.txt_username.Name = "txt_username";
            this.txt_username.ReadOnly = true;
            this.txt_username.Size = new System.Drawing.Size(233, 32);
            this.txt_username.TabIndex = 56;
            this.txt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label18.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(753, 15);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(106, 24);
            this.label18.TabIndex = 57;
            this.label18.Text = "اسم المستخدم";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.ToDate);
            this.groupBox2.Controls.Add(this.FromDate);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.simpleButton1);
            this.groupBox2.Location = new System.Drawing.Point(7, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(894, 65);
            this.groupBox2.TabIndex = 100;
            this.groupBox2.TabStop = false;
            // 
            // ToDate
            // 
            this.ToDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ToDate.CustomFormat = "dd/MM/yyyy  *  tt mm:hh     ";
            this.ToDate.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ToDate.Location = new System.Drawing.Point(171, 20);
            this.ToDate.Name = "ToDate";
            this.ToDate.ShowUpDown = true;
            this.ToDate.Size = new System.Drawing.Size(287, 32);
            this.ToDate.TabIndex = 211;
            // 
            // FromDate
            // 
            this.FromDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FromDate.CustomFormat = "dd/MM/yyyy  *  tt mm:hh     ";
            this.FromDate.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FromDate.Location = new System.Drawing.Point(543, 20);
            this.FromDate.Name = "FromDate";
            this.FromDate.ShowUpDown = true;
            this.FromDate.Size = new System.Drawing.Size(287, 32);
            this.FromDate.TabIndex = 210;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(836, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 32);
            this.label2.TabIndex = 208;
            this.label2.Text = "من";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(463, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 32);
            this.label3.TabIndex = 209;
            this.label3.Text = "الي";
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
            this.simpleButton1.Location = new System.Drawing.Point(27, 15);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(106, 37);
            this.simpleButton1.TabIndex = 114;
            this.simpleButton1.Text = "بحث";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.gridControl1);
            this.groupBox3.Location = new System.Drawing.Point(4, 130);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(897, 339);
            this.groupBox3.TabIndex = 161;
            this.groupBox3.TabStop = false;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridControl1.Location = new System.Drawing.Point(3, 13);
            this.gridControl1.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.gridControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridControl1.Size = new System.Drawing.Size(888, 320);
            this.gridControl1.TabIndex = 127;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Yellow;
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.Row.Options.UseTextOptions = true;
            this.gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
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
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar1
            // 
            this.bar1.BarName = "Main menu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Appearance.BackColor = System.Drawing.Color.Black;
            this.button1.Appearance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Appearance.ForeColor = System.Drawing.Color.White;
            this.button1.Appearance.Options.UseBackColor = true;
            this.button1.Appearance.Options.UseFont = true;
            this.button1.Appearance.Options.UseForeColor = true;
            this.button1.Appearance.Options.UseTextOptions = true;
            this.button1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.button1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.button1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.button1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("button1.ImageOptions.Image")));
            this.button1.Location = new System.Drawing.Point(33, 486);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 33);
            this.button1.TabIndex = 243;
            this.button1.Text = "طباعة باركود";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_print
            // 
            this.btn_print.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_print.Appearance.BackColor = System.Drawing.Color.Black;
            this.btn_print.Appearance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_print.Appearance.Options.UseBackColor = true;
            this.btn_print.Appearance.Options.UseFont = true;
            this.btn_print.Appearance.Options.UseForeColor = true;
            this.btn_print.Appearance.Options.UseTextOptions = true;
            this.btn_print.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btn_print.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btn_print.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btn_print.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_print.ImageOptions.Image")));
            this.btn_print.Location = new System.Drawing.Point(210, 487);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(144, 33);
            this.btn_print.TabIndex = 242;
            this.btn_print.Text = "طباعة فاتورة";
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_save.Appearance.BackColor = System.Drawing.Color.Black;
            this.btn_save.Appearance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_save.Appearance.Options.UseBackColor = true;
            this.btn_save.Appearance.Options.UseFont = true;
            this.btn_save.Appearance.Options.UseForeColor = true;
            this.btn_save.Appearance.Options.UseTextOptions = true;
            this.btn_save.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btn_save.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btn_save.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btn_save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.ImageOptions.Image")));
            this.btn_save.Location = new System.Drawing.Point(380, 487);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(143, 32);
            this.btn_save.TabIndex = 241;
            this.btn_save.Text = " تفاصيل الفاتورة";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.Black;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Appearance.Options.UseForeColor = true;
            this.simpleButton2.Appearance.Options.UseTextOptions = true;
            this.simpleButton2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.simpleButton2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.simpleButton2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(751, 486);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(133, 32);
            this.simpleButton2.TabIndex = 240;
            this.simpleButton2.Text = "مردوات";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.simpleButton3.Appearance.BackColor = System.Drawing.Color.Black;
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton3.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton3.Appearance.Options.UseBackColor = true;
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.Appearance.Options.UseForeColor = true;
            this.simpleButton3.Appearance.Options.UseTextOptions = true;
            this.simpleButton3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.simpleButton3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.simpleButton3.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(541, 486);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(178, 32);
            this.simpleButton3.TabIndex = 244;
            this.simpleButton3.Text = "تحويل الي جهه اخرى";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // Frm_ManagmentTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(904, 535);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_ManagmentTickets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة الحجوزات";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_ManagmentTickets_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label18;
        public System.Windows.Forms.ComboBox cmb_branches;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar1;
        private System.Windows.Forms.DateTimePicker ToDate;
        private System.Windows.Forms.DateTimePicker FromDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton button1;
        private DevExpress.XtraEditors.SimpleButton btn_print;
        private DevExpress.XtraEditors.SimpleButton btn_save;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
    }
}