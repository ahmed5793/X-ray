namespace Laboratory.PL
{
    partial class Frm_PayClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_PayClient));
            this.cmb_Stock = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbPartPay = new System.Windows.Forms.RadioButton();
            this.RdbAllPay = new System.Windows.Forms.RadioButton();
            this.txt_prise = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.Txt_CustAccount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Cmb_Branch = new System.Windows.Forms.ComboBox();
            this.Txt_CustAcountAfterDisCount = new System.Windows.Forms.TextBox();
            this.Txt_SalesMAn = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtDisCount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_Stock
            // 
            this.cmb_Stock.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_Stock.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Stock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Stock.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Stock.FormattingEnabled = true;
            this.cmb_Stock.Location = new System.Drawing.Point(46, 51);
            this.cmb_Stock.Name = "cmb_Stock";
            this.cmb_Stock.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_Stock.Size = new System.Drawing.Size(214, 27);
            this.cmb_Stock.TabIndex = 84;
            this.cmb_Stock.SelectedIndexChanged += new System.EventHandler(this.cmb_Stock_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.White;
            this.label19.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(272, 57);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(39, 19);
            this.label19.TabIndex = 83;
            this.label19.Text = "خزينة";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.rdbPartPay);
            this.groupBox2.Controls.Add(this.RdbAllPay);
            this.groupBox2.Controls.Add(this.txt_prise);
            this.groupBox2.Location = new System.Drawing.Point(5, 394);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(841, 62);
            this.groupBox2.TabIndex = 79;
            this.groupBox2.TabStop = false;
            // 
            // rdbPartPay
            // 
            this.rdbPartPay.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.rdbPartPay.AutoSize = true;
            this.rdbPartPay.BackColor = System.Drawing.Color.White;
            this.rdbPartPay.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPartPay.Location = new System.Drawing.Point(193, 20);
            this.rdbPartPay.Name = "rdbPartPay";
            this.rdbPartPay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdbPartPay.Size = new System.Drawing.Size(264, 26);
            this.rdbPartPay.TabIndex = 1;
            this.rdbPartPay.Text = "تسديد جزء من المتبقي للفاتورة المحدة";
            this.rdbPartPay.UseVisualStyleBackColor = false;
            this.rdbPartPay.CheckedChanged += new System.EventHandler(this.rdbPartPay_CheckedChanged);
            // 
            // RdbAllPay
            // 
            this.RdbAllPay.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.RdbAllPay.AutoSize = true;
            this.RdbAllPay.BackColor = System.Drawing.Color.White;
            this.RdbAllPay.Checked = true;
            this.RdbAllPay.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbAllPay.Location = new System.Drawing.Point(569, 20);
            this.RdbAllPay.Name = "RdbAllPay";
            this.RdbAllPay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RdbAllPay.Size = new System.Drawing.Size(253, 26);
            this.RdbAllPay.TabIndex = 0;
            this.RdbAllPay.TabStop = true;
            this.RdbAllPay.Text = "تسديد المبلغ بالكامل للفاتورة المحددة";
            this.RdbAllPay.UseVisualStyleBackColor = false;
            this.RdbAllPay.CheckedChanged += new System.EventHandler(this.RdbAllPay_CheckedChanged);
            // 
            // txt_prise
            // 
            this.txt_prise.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txt_prise.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prise.Location = new System.Drawing.Point(16, 19);
            this.txt_prise.MaxLength = 8;
            this.txt_prise.Name = "txt_prise";
            this.txt_prise.Size = new System.Drawing.Size(171, 27);
            this.txt_prise.TabIndex = 63;
            this.txt_prise.Text = "0";
            this.txt_prise.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_prise.Click += new System.EventHandler(this.txt_prise_Click);
            this.txt_prise.TextChanged += new System.EventHandler(this.txt_prise_TextChanged);
            this.txt_prise.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_prise_KeyPress);
            this.txt_prise.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txt_prise_MouseMove);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(763, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 81;
            this.label3.Text = "تاريخ الدفع";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Controls.Add(this.lookUpEdit1);
            this.groupBox1.Controls.Add(this.Txt_CustAccount);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Cmb_Branch);
            this.groupBox1.Controls.Add(this.Txt_CustAcountAfterDisCount);
            this.groupBox1.Controls.Add(this.cmb_Stock);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.Txt_SalesMAn);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TxtDisCount);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.simpleButton2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(5, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(841, 386);
            this.groupBox1.TabIndex = 77;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lookUpEdit1.Location = new System.Drawing.Point(179, 99);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpEdit1.Properties.Appearance.Options.UseFont = true;
            this.lookUpEdit1.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpEdit1.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search)});
            this.lookUpEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Cust_Name", "Name1", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Center, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Cust_ID", "Name2", 10, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Center, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lookUpEdit1.Properties.DropDownRows = 15;
            this.lookUpEdit1.Properties.NullText = "أسم العميل";
            this.lookUpEdit1.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.StartsWith;
            this.lookUpEdit1.Properties.ShowFooter = false;
            this.lookUpEdit1.Properties.ShowHeader = false;
            this.lookUpEdit1.Properties.ShowPopupShadow = false;
            this.lookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpEdit1.Size = new System.Drawing.Size(517, 26);
            this.lookUpEdit1.TabIndex = 179;
            this.lookUpEdit1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lookUpEdit1_KeyDown);
            // 
            // Txt_CustAccount
            // 
            this.Txt_CustAccount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Txt_CustAccount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_CustAccount.Location = new System.Drawing.Point(280, 263);
            this.Txt_CustAccount.MaxLength = 8;
            this.Txt_CustAccount.Name = "Txt_CustAccount";
            this.Txt_CustAccount.ReadOnly = true;
            this.Txt_CustAccount.Size = new System.Drawing.Size(171, 27);
            this.Txt_CustAccount.TabIndex = 177;
            this.Txt_CustAccount.Text = "0";
            this.Txt_CustAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(271, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 19);
            this.label4.TabIndex = 97;
            this.label4.Text = "الفرع";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(749, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 19);
            this.label5.TabIndex = 99;
            this.label5.Text = "إسم المستخدم";
            // 
            // Cmb_Branch
            // 
            this.Cmb_Branch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Cmb_Branch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_Branch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Branch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Branch.FormattingEnabled = true;
            this.Cmb_Branch.Location = new System.Drawing.Point(46, 11);
            this.Cmb_Branch.Name = "Cmb_Branch";
            this.Cmb_Branch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Cmb_Branch.Size = new System.Drawing.Size(215, 27);
            this.Cmb_Branch.TabIndex = 98;
            this.Cmb_Branch.SelectionChangeCommitted += new System.EventHandler(this.Cmb_Branch_SelectionChangeCommitted);
            // 
            // Txt_CustAcountAfterDisCount
            // 
            this.Txt_CustAcountAfterDisCount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Txt_CustAcountAfterDisCount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_CustAcountAfterDisCount.Location = new System.Drawing.Point(281, 350);
            this.Txt_CustAcountAfterDisCount.MaxLength = 8;
            this.Txt_CustAcountAfterDisCount.Name = "Txt_CustAcountAfterDisCount";
            this.Txt_CustAcountAfterDisCount.ReadOnly = true;
            this.Txt_CustAcountAfterDisCount.Size = new System.Drawing.Size(171, 27);
            this.Txt_CustAcountAfterDisCount.TabIndex = 175;
            this.Txt_CustAcountAfterDisCount.Text = "0";
            this.Txt_CustAcountAfterDisCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_CustAcountAfterDisCount.TextChanged += new System.EventHandler(this.Txt_CustAcountAfterDisCount_TextChanged);
            // 
            // Txt_SalesMAn
            // 
            this.Txt_SalesMAn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_SalesMAn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_SalesMAn.Location = new System.Drawing.Point(528, 15);
            this.Txt_SalesMAn.Multiline = true;
            this.Txt_SalesMAn.Name = "Txt_SalesMAn";
            this.Txt_SalesMAn.ReadOnly = true;
            this.Txt_SalesMAn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_SalesMAn.Size = new System.Drawing.Size(215, 27);
            this.Txt_SalesMAn.TabIndex = 96;
            this.Txt_SalesMAn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(458, 354);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(269, 19);
            this.label8.TabIndex = 176;
            this.label8.Text = "المتبقى على العميل بعد الخصم فى الفاتورة المحددة";
            // 
            // TxtDisCount
            // 
            this.TxtDisCount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TxtDisCount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDisCount.Location = new System.Drawing.Point(281, 307);
            this.TxtDisCount.MaxLength = 8;
            this.TxtDisCount.Name = "TxtDisCount";
            this.TxtDisCount.Size = new System.Drawing.Size(171, 27);
            this.TxtDisCount.TabIndex = 173;
            this.TxtDisCount.Text = "0";
            this.TxtDisCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtDisCount.Click += new System.EventHandler(this.TxtDisCount_Click);
            this.TxtDisCount.TextChanged += new System.EventHandler(this.TxtDisCount_TextChanged);
            this.TxtDisCount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtDisCount_KeyDown);
            this.TxtDisCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDisCount_KeyPress);
            this.TxtDisCount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtDisCount_KeyUp);
            this.TxtDisCount.MouseLeave += new System.EventHandler(this.TxtDisCount_MouseLeave);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(546, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 19);
            this.label7.TabIndex = 174;
            this.label7.Text = "الخصم على الفاتورة المحددة فقط ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(493, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 19);
            this.label2.TabIndex = 172;
            this.label2.Text = "المتبقى على العميل فى الفاتورة المحددة فقط";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.simpleButton2.Location = new System.Drawing.Point(71, 94);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(102, 32);
            this.simpleButton2.TabIndex = 171;
            this.simpleButton2.Text = "بحث";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(702, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 19);
            this.label6.TabIndex = 100;
            this.label6.Text = "إسم العميل";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(528, 55);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(215, 26);
            this.dateTimePicker1.TabIndex = 82;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
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
            this.simpleButton1.Location = new System.Drawing.Point(353, 467);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(179, 37);
            this.simpleButton1.TabIndex = 172;
            this.simpleButton1.Text = "حفظ المدفوع";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
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
            this.dataGridView2.Location = new System.Drawing.Point(7, 135);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView2.Size = new System.Drawing.Size(828, 122);
            this.dataGridView2.TabIndex = 180;
            this.dataGridView2.DoubleClick += new System.EventHandler(this.dataGridView2_DoubleClick);
            // 
            // Frm_PayClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(849, 511);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(865, 549);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(865, 549);
            this.Name = "Frm_PayClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة مدفوعات العملاء ";
            this.Load += new System.EventHandler(this.Frm_PayClient_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ComboBox cmb_Stock;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_prise;
        private System.Windows.Forms.RadioButton rdbPartPay;
        private System.Windows.Forms.RadioButton RdbAllPay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_SalesMAn;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox Cmb_Branch;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.TextBox Txt_CustAccount;
        private System.Windows.Forms.TextBox Txt_CustAcountAfterDisCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtDisCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        public System.Windows.Forms.DataGridView dataGridView2;
    }
}