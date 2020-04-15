namespace Laboratory.PL
{
    partial class Frm_ManagmentUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ManagmentUser));
            this.txt_User = new System.Windows.Forms.TextBox();
            this.txt_PassRealy = new System.Windows.Forms.TextBox();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Update = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlInsert = new DevExpress.XtraGrid.GridControl();
            this.gridViewInsert = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlInsert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewInsert)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_User
            // 
            this.txt_User.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_User.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_User.Location = new System.Drawing.Point(274, 69);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(324, 32);
            this.txt_User.TabIndex = 47;
            this.txt_User.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_User.Leave += new System.EventHandler(this.txt_User_Leave);
            // 
            // txt_PassRealy
            // 
            this.txt_PassRealy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_PassRealy.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PassRealy.Location = new System.Drawing.Point(274, 169);
            this.txt_PassRealy.Name = "txt_PassRealy";
            this.txt_PassRealy.PasswordChar = '*';
            this.txt_PassRealy.Size = new System.Drawing.Size(324, 32);
            this.txt_PassRealy.TabIndex = 49;
            this.txt_PassRealy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_PassRealy.UseSystemPasswordChar = true;
            // 
            // txt_Pass
            // 
            this.txt_Pass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_Pass.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pass.Location = new System.Drawing.Point(274, 124);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.PasswordChar = '*';
            this.txt_Pass.Size = new System.Drawing.Size(324, 32);
            this.txt_Pass.TabIndex = 48;
            this.txt_Pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Pass.UseSystemPasswordChar = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(274, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox1.Size = new System.Drawing.Size(325, 32);
            this.comboBox1.TabIndex = 59;
            this.comboBox1.Leave += new System.EventHandler(this.comboBox1_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.txt_Pass);
            this.groupBox1.Controls.Add(this.txt_PassRealy);
            this.groupBox1.Controls.Add(this.txt_User);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(652, 217);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Arial Black", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 33);
            this.label1.TabIndex = 63;
            this.label1.Text = "Employee Name";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("Arial Black", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 33);
            this.label3.TabIndex = 62;
            this.label3.Text = "PASSWORD";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Arial Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 27);
            this.label2.TabIndex = 61;
            this.label2.Text = "CONFIRM PASSWORD";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Font = new System.Drawing.Font("Arial Black", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 33);
            this.label4.TabIndex = 60;
            this.label4.Text = "USER NAME";
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
            this.Btn_Delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Delete.ImageOptions.Image")));
            this.Btn_Delete.Location = new System.Drawing.Point(85, 238);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(129, 32);
            this.Btn_Delete.TabIndex = 183;
            this.Btn_Delete.Text = "Delete";
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_New_Click);
            // 
            // Btn_Update
            // 
            this.Btn_Update.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.Btn_Update.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Update.ImageOptions.Image")));
            this.Btn_Update.Location = new System.Drawing.Point(277, 238);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(129, 32);
            this.Btn_Update.TabIndex = 182;
            this.Btn_Update.Text = "Update";
            this.Btn_Update.Click += new System.EventHandler(this.simpleButton1_Click);
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
            this.Btn_Add.Location = new System.Drawing.Point(473, 238);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(129, 32);
            this.Btn_Add.TabIndex = 181;
            this.Btn_Add.Text = "Save";
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // gridControlInsert
            // 
            this.gridControlInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlInsert.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridControlInsert.Location = new System.Drawing.Point(3, 288);
            this.gridControlInsert.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.gridControlInsert.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControlInsert.MainView = this.gridViewInsert;
            this.gridControlInsert.Name = "gridControlInsert";
            this.gridControlInsert.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridControlInsert.Size = new System.Drawing.Size(661, 242);
            this.gridControlInsert.TabIndex = 184;
            this.gridControlInsert.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewInsert});
            this.gridControlInsert.DoubleClick += new System.EventHandler(this.gridControlInsert_DoubleClick);
            // 
            // gridViewInsert
            // 
            this.gridViewInsert.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewInsert.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridViewInsert.Appearance.FocusedCell.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.gridViewInsert.Appearance.FocusedCell.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewInsert.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gridViewInsert.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridViewInsert.Appearance.FocusedCell.Options.UseFont = true;
            this.gridViewInsert.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridViewInsert.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.gridViewInsert.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewInsert.Appearance.FocusedCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewInsert.Appearance.FocusedCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.gridViewInsert.Appearance.FocusedRow.BackColor = System.Drawing.Color.Yellow;
            this.gridViewInsert.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.Yellow;
            this.gridViewInsert.Appearance.FocusedRow.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewInsert.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewInsert.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewInsert.Appearance.FocusedRow.Options.UseFont = true;
            this.gridViewInsert.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewInsert.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.gridViewInsert.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewInsert.Appearance.FocusedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewInsert.Appearance.FocusedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.gridViewInsert.Appearance.HeaderPanel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewInsert.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Yellow;
            this.gridViewInsert.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewInsert.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewInsert.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewInsert.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewInsert.Appearance.Row.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewInsert.Appearance.Row.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridViewInsert.Appearance.Row.Options.UseFont = true;
            this.gridViewInsert.Appearance.Row.Options.UseTextOptions = true;
            this.gridViewInsert.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewInsert.AppearancePrint.HeaderPanel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewInsert.AppearancePrint.HeaderPanel.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridViewInsert.AppearancePrint.HeaderPanel.Options.UseFont = true;
            this.gridViewInsert.AppearancePrint.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewInsert.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewInsert.AppearancePrint.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewInsert.AppearancePrint.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.gridViewInsert.AppearancePrint.Row.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewInsert.AppearancePrint.Row.Options.UseFont = true;
            this.gridViewInsert.AppearancePrint.Row.Options.UseTextOptions = true;
            this.gridViewInsert.AppearancePrint.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewInsert.AppearancePrint.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewInsert.AppearancePrint.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.gridViewInsert.GridControl = this.gridControlInsert;
            this.gridViewInsert.Name = "gridViewInsert";
            this.gridViewInsert.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewInsert.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewInsert.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gridViewInsert.OptionsBehavior.Editable = false;
            this.gridViewInsert.OptionsBehavior.ReadOnly = true;
            this.gridViewInsert.OptionsPrint.PrintPreview = true;
            this.gridViewInsert.OptionsView.ShowFooter = true;
            // 
            // Frm_ManagmentUser
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(665, 531);
            this.Controls.Add(this.gridControlInsert);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.Btn_Update);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(681, 569);
            this.MinimumSize = new System.Drawing.Size(681, 569);
            this.Name = "Frm_ManagmentUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة مستخدم جديد";
            this.Load += new System.EventHandler(this.Frm_ManagmentUser_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlInsert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewInsert)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_User;
        private System.Windows.Forms.TextBox txt_PassRealy;
        private System.Windows.Forms.TextBox txt_Pass;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton Btn_Delete;
        private DevExpress.XtraEditors.SimpleButton Btn_Update;
        private DevExpress.XtraEditors.SimpleButton Btn_Add;
        private DevExpress.XtraGrid.GridControl gridControlInsert;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewInsert;
    }
}