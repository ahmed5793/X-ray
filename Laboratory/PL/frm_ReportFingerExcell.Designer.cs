namespace Laboratory.PL
{
    partial class frm_ReportFingerExcell
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ReportFingerExcell));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cmb_year = new System.Windows.Forms.ComboBox();
            this.cmb_month = new System.Windows.Forms.ComboBox();
            this.label_client = new System.Windows.Forms.Label();
            this.cmb_clients = new System.Windows.Forms.ComboBox();
            this.lable_year = new System.Windows.Forms.Label();
            this.lable_mothe = new System.Windows.Forms.Label();
            this.cmb_user_branch = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.DateFrom = new System.Windows.Forms.DateTimePicker();
            this.lable_day = new System.Windows.Forms.Label();
            this.rdb_monthe = new System.Windows.Forms.RadioButton();
            this.rdb_day = new System.Windows.Forms.RadioButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_monthe = new DevExpress.XtraEditors.SimpleButton();
            this.DAY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(1, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(920, 349);
            this.groupBox1.TabIndex = 207;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DAY,
            this.Column2,
            this.Column,
            this.Column1});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Blue;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Blue;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(914, 330);
            this.dataGridView1.TabIndex = 52;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(0, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(920, 333);
            this.groupBox2.TabIndex = 208;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 16);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView2.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView2.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Blue;
            this.dataGridView2.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dataGridView2.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Blue;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(914, 314);
            this.dataGridView2.TabIndex = 52;
            // 
            // cmb_year
            // 
            this.cmb_year.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmb_year.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_year.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_year.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_year.FormattingEnabled = true;
            this.cmb_year.Location = new System.Drawing.Point(147, 77);
            this.cmb_year.Name = "cmb_year";
            this.cmb_year.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_year.Size = new System.Drawing.Size(132, 32);
            this.cmb_year.TabIndex = 206;
            // 
            // cmb_month
            // 
            this.cmb_month.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmb_month.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_month.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_month.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_month.FormattingEnabled = true;
            this.cmb_month.Location = new System.Drawing.Point(452, 77);
            this.cmb_month.Name = "cmb_month";
            this.cmb_month.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_month.Size = new System.Drawing.Size(149, 32);
            this.cmb_month.TabIndex = 205;
            // 
            // label_client
            // 
            this.label_client.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_client.AutoSize = true;
            this.label_client.BackColor = System.Drawing.Color.Black;
            this.label_client.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_client.ForeColor = System.Drawing.Color.White;
            this.label_client.Location = new System.Drawing.Point(286, 14);
            this.label_client.Name = "label_client";
            this.label_client.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_client.Size = new System.Drawing.Size(118, 31);
            this.label_client.TabIndex = 199;
            this.label_client.Text = "إسم الموظف";
            // 
            // cmb_clients
            // 
            this.cmb_clients.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmb_clients.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_clients.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_clients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_clients.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_clients.FormattingEnabled = true;
            this.cmb_clients.Location = new System.Drawing.Point(12, 12);
            this.cmb_clients.Name = "cmb_clients";
            this.cmb_clients.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_clients.Size = new System.Drawing.Size(264, 32);
            this.cmb_clients.TabIndex = 198;
            // 
            // lable_year
            // 
            this.lable_year.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lable_year.BackColor = System.Drawing.Color.Black;
            this.lable_year.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable_year.ForeColor = System.Drawing.Color.White;
            this.lable_year.Location = new System.Drawing.Point(286, 78);
            this.lable_year.Name = "lable_year";
            this.lable_year.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lable_year.Size = new System.Drawing.Size(106, 31);
            this.lable_year.TabIndex = 202;
            this.lable_year.Text = "YEAR";
            this.lable_year.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lable_mothe
            // 
            this.lable_mothe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lable_mothe.BackColor = System.Drawing.Color.Black;
            this.lable_mothe.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable_mothe.ForeColor = System.Drawing.Color.White;
            this.lable_mothe.Location = new System.Drawing.Point(607, 74);
            this.lable_mothe.Name = "lable_mothe";
            this.lable_mothe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lable_mothe.Size = new System.Drawing.Size(138, 38);
            this.lable_mothe.TabIndex = 201;
            this.lable_mothe.Text = "MONTHE";
            this.lable_mothe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_user_branch
            // 
            this.cmb_user_branch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmb_user_branch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_user_branch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_user_branch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_user_branch.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_user_branch.FormattingEnabled = true;
            this.cmb_user_branch.Location = new System.Drawing.Point(441, 18);
            this.cmb_user_branch.Name = "cmb_user_branch";
            this.cmb_user_branch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_user_branch.Size = new System.Drawing.Size(233, 26);
            this.cmb_user_branch.TabIndex = 210;
            this.cmb_user_branch.SelectionChangeCommitted += new System.EventHandler(this.cmb_UserBranch_SelectionChangeCommitted);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Black;
            this.label13.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(691, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 31);
            this.label13.TabIndex = 209;
            this.label13.Text = "الفرع";
            // 
            // DateFrom
            // 
            this.DateFrom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DateFrom.CustomFormat = "   dd/MM/yyyy   ";
            this.DateFrom.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateFrom.Location = new System.Drawing.Point(344, 77);
            this.DateFrom.Name = "DateFrom";
            this.DateFrom.ShowUpDown = true;
            this.DateFrom.Size = new System.Drawing.Size(181, 32);
            this.DateFrom.TabIndex = 123;
            // 
            // lable_day
            // 
            this.lable_day.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lable_day.BackColor = System.Drawing.Color.Black;
            this.lable_day.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable_day.ForeColor = System.Drawing.Color.Yellow;
            this.lable_day.Location = new System.Drawing.Point(544, 74);
            this.lable_day.Name = "lable_day";
            this.lable_day.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lable_day.Size = new System.Drawing.Size(96, 36);
            this.lable_day.TabIndex = 121;
            this.lable_day.Text = "التاريخ";
            this.lable_day.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdb_monthe
            // 
            this.rdb_monthe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdb_monthe.AutoSize = true;
            this.rdb_monthe.Checked = true;
            this.rdb_monthe.Font = new System.Drawing.Font("Droid Arabic Kufi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_monthe.Location = new System.Drawing.Point(772, 33);
            this.rdb_monthe.Name = "rdb_monthe";
            this.rdb_monthe.Size = new System.Drawing.Size(155, 40);
            this.rdb_monthe.TabIndex = 212;
            this.rdb_monthe.TabStop = true;
            this.rdb_monthe.Text = "تقرير شهري ";
            this.rdb_monthe.UseVisualStyleBackColor = true;
            this.rdb_monthe.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdb_day
            // 
            this.rdb_day.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdb_day.AutoSize = true;
            this.rdb_day.Font = new System.Drawing.Font("Droid Arabic Kufi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_day.Location = new System.Drawing.Point(783, 79);
            this.rdb_day.Name = "rdb_day";
            this.rdb_day.Size = new System.Drawing.Size(138, 40);
            this.rdb_day.TabIndex = 213;
            this.rdb_day.Text = "تقرير يومي";
            this.rdb_day.UseVisualStyleBackColor = true;
            this.rdb_day.CheckedChanged += new System.EventHandler(this.rdb_day_CheckedChanged);
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
            this.simpleButton1.Location = new System.Drawing.Point(368, 490);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(144, 32);
            this.simpleButton1.TabIndex = 214;
            this.simpleButton1.Text = "طباعه تقرير";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // btn_monthe
            // 
            this.btn_monthe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_monthe.Appearance.BackColor = System.Drawing.Color.Black;
            this.btn_monthe.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_monthe.Appearance.ForeColor = System.Drawing.Color.Yellow;
            this.btn_monthe.Appearance.Options.UseBackColor = true;
            this.btn_monthe.Appearance.Options.UseFont = true;
            this.btn_monthe.Appearance.Options.UseForeColor = true;
            this.btn_monthe.Appearance.Options.UseTextOptions = true;
            this.btn_monthe.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btn_monthe.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btn_monthe.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btn_monthe.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_monthe.ImageOptions.Image")));
            this.btn_monthe.Location = new System.Drawing.Point(12, 70);
            this.btn_monthe.Name = "btn_monthe";
            this.btn_monthe.Size = new System.Drawing.Size(129, 46);
            this.btn_monthe.TabIndex = 208;
            this.btn_monthe.Text = "بحث";
            this.btn_monthe.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // DAY
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DAY.DefaultCellStyle = dataGridViewCellStyle3;
            this.DAY.HeaderText = "التاريخ";
            this.DAY.Name = "DAY";
            this.DAY.ReadOnly = true;
            // 
            // Column2
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column2.HeaderText = "اليوم";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "t";
            dataGridViewCellStyle5.NullValue = null;
            this.Column.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column.HeaderText = "وقت الحضور";
            this.Column.Name = "Column";
            this.Column.ReadOnly = true;
            // 
            // Column1
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Format = "t";
            this.Column1.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column1.HeaderText = "وقت الانصراف";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // frm_ReportFingerExcell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(939, 534);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.rdb_day);
            this.Controls.Add(this.rdb_monthe);
            this.Controls.Add(this.cmb_user_branch);
            this.Controls.Add(this.DateFrom);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lable_day);
            this.Controls.Add(this.btn_monthe);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmb_year);
            this.Controls.Add(this.cmb_month);
            this.Controls.Add(this.label_client);
            this.Controls.Add(this.cmb_clients);
            this.Controls.Add(this.lable_year);
            this.Controls.Add(this.lable_mothe);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frm_ReportFingerExcell";
            this.Text = "frm_ReportFingerExcell";
            this.Load += new System.EventHandler(this.frm_ReportFingerExcell_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ComboBox cmb_year;
        public System.Windows.Forms.ComboBox cmb_month;
        private System.Windows.Forms.Label label_client;
        public System.Windows.Forms.ComboBox cmb_clients;
        private System.Windows.Forms.Label lable_year;
        private System.Windows.Forms.Label lable_mothe;
        private DevExpress.XtraEditors.SimpleButton btn_monthe;
        public System.Windows.Forms.ComboBox cmb_user_branch;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker DateFrom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lable_day;
        private System.Windows.Forms.RadioButton rdb_monthe;
        private System.Windows.Forms.RadioButton rdb_day;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DAY;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}