namespace Laboratory.PL
{
    partial class Frm_PaySuppliers
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
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_Stock = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.RdbOneSuppliers = new System.Windows.Forms.RadioButton();
            this.RdbAllSuppliers = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_prise = new System.Windows.Forms.TextBox();
            this.txt_rent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.rdbPartPay = new System.Windows.Forms.RadioButton();
            this.RdbAllPay = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Txt_sales = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(61, 28);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(102, 29);
            this.label7.TabIndex = 47;
            this.label7.Text = "اختر خزنة:";
            // 
            // cmb_Stock
            // 
            this.cmb_Stock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Stock.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_Stock.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Stock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Stock.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Stock.FormattingEnabled = true;
            this.cmb_Stock.Location = new System.Drawing.Point(18, 60);
            this.cmb_Stock.Name = "cmb_Stock";
            this.cmb_Stock.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_Stock.Size = new System.Drawing.Size(195, 37);
            this.cmb_Stock.TabIndex = 46;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(401, 74);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox1.Size = new System.Drawing.Size(244, 32);
            this.comboBox1.TabIndex = 29;
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(290, 74);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(103, 30);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "بحث";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // RdbOneSuppliers
            // 
            this.RdbOneSuppliers.AutoSize = true;
            this.RdbOneSuppliers.BackColor = System.Drawing.Color.Black;
            this.RdbOneSuppliers.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbOneSuppliers.ForeColor = System.Drawing.Color.White;
            this.RdbOneSuppliers.Location = new System.Drawing.Point(651, 80);
            this.RdbOneSuppliers.Name = "RdbOneSuppliers";
            this.RdbOneSuppliers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RdbOneSuppliers.Size = new System.Drawing.Size(97, 26);
            this.RdbOneSuppliers.TabIndex = 1;
            this.RdbOneSuppliers.Text = "مورد محدد";
            this.RdbOneSuppliers.UseVisualStyleBackColor = false;
            // 
            // RdbAllSuppliers
            // 
            this.RdbAllSuppliers.AutoSize = true;
            this.RdbAllSuppliers.BackColor = System.Drawing.Color.Black;
            this.RdbAllSuppliers.Checked = true;
            this.RdbAllSuppliers.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbAllSuppliers.ForeColor = System.Drawing.Color.White;
            this.RdbAllSuppliers.Location = new System.Drawing.Point(769, 80);
            this.RdbAllSuppliers.Name = "RdbAllSuppliers";
            this.RdbAllSuppliers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RdbAllSuppliers.Size = new System.Drawing.Size(104, 26);
            this.RdbAllSuppliers.TabIndex = 0;
            this.RdbAllSuppliers.TabStop = true;
            this.RdbAllSuppliers.Text = "كل الموردين";
            this.RdbAllSuppliers.UseVisualStyleBackColor = false;
            this.RdbAllSuppliers.CheckedChanged += new System.EventHandler(this.RdbAllSuppliers_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_prise);
            this.groupBox2.Controls.Add(this.txt_rent);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnPay);
            this.groupBox2.Controls.Add(this.rdbPartPay);
            this.groupBox2.Controls.Add(this.RdbAllPay);
            this.groupBox2.Location = new System.Drawing.Point(4, 389);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(894, 87);
            this.groupBox2.TabIndex = 73;
            this.groupBox2.TabStop = false;
            // 
            // txt_prise
            // 
            this.txt_prise.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prise.Location = new System.Drawing.Point(444, 30);
            this.txt_prise.MaxLength = 8;
            this.txt_prise.Name = "txt_prise";
            this.txt_prise.Size = new System.Drawing.Size(116, 27);
            this.txt_prise.TabIndex = 63;
            this.txt_prise.Text = "0";
            this.txt_prise.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_prise.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_prise_KeyPress);
            // 
            // txt_rent
            // 
            this.txt_rent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_rent.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rent.Location = new System.Drawing.Point(24, 42);
            this.txt_rent.Name = "txt_rent";
            this.txt_rent.ReadOnly = true;
            this.txt_rent.Size = new System.Drawing.Size(127, 29);
            this.txt_rent.TabIndex = 62;
            this.txt_rent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 22);
            this.label2.TabIndex = 61;
            this.label2.Text = "اجمالي المبالغ المتبقيه";
            // 
            // btnPay
            // 
            this.btnPay.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(296, 19);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(126, 46);
            this.btnPay.TabIndex = 3;
            this.btnPay.Text = "تسديد المحدد";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // rdbPartPay
            // 
            this.rdbPartPay.AutoSize = true;
            this.rdbPartPay.BackColor = System.Drawing.Color.Black;
            this.rdbPartPay.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPartPay.ForeColor = System.Drawing.Color.White;
            this.rdbPartPay.Location = new System.Drawing.Point(578, 31);
            this.rdbPartPay.Name = "rdbPartPay";
            this.rdbPartPay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdbPartPay.Size = new System.Drawing.Size(122, 26);
            this.rdbPartPay.TabIndex = 1;
            this.rdbPartPay.Text = "تسديد جزء منه";
            this.rdbPartPay.UseVisualStyleBackColor = false;
            // 
            // RdbAllPay
            // 
            this.RdbAllPay.AutoSize = true;
            this.RdbAllPay.BackColor = System.Drawing.Color.Black;
            this.RdbAllPay.Checked = true;
            this.RdbAllPay.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbAllPay.ForeColor = System.Drawing.Color.White;
            this.RdbAllPay.Location = new System.Drawing.Point(735, 31);
            this.RdbAllPay.Name = "RdbAllPay";
            this.RdbAllPay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RdbAllPay.Size = new System.Drawing.Size(149, 26);
            this.RdbAllPay.TabIndex = 0;
            this.RdbAllPay.TabStop = true;
            this.RdbAllPay.Text = "تسديد المبلغ بالكامل";
            this.RdbAllPay.UseVisualStyleBackColor = false;
            this.RdbAllPay.CheckedChanged += new System.EventHandler(this.RdbAllPay_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 8);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(189, 26);
            this.dateTimePicker1.TabIndex = 76;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(453, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 29);
            this.label1.TabIndex = 72;
            this.label1.Text = "المبالغ المتبقيه للموردين ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView1.GridColor = System.Drawing.Color.DimGray;
            this.dataGridView1.Location = new System.Drawing.Point(10, 167);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(888, 222);
            this.dataGridView1.TabIndex = 74;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Txt_sales);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmb_Stock);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.RdbOneSuppliers);
            this.groupBox1.Controls.Add(this.RdbAllSuppliers);
            this.groupBox1.Location = new System.Drawing.Point(10, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(885, 123);
            this.groupBox1.TabIndex = 71;
            this.groupBox1.TabStop = false;
            // 
            // Txt_sales
            // 
            this.Txt_sales.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_sales.Location = new System.Drawing.Point(528, 19);
            this.Txt_sales.Name = "Txt_sales";
            this.Txt_sales.ReadOnly = true;
            this.Txt_sales.Size = new System.Drawing.Size(231, 32);
            this.Txt_sales.TabIndex = 58;
            this.Txt_sales.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(765, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 57;
            this.label4.Text = "اسم المستخدم";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(217, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 24);
            this.label3.TabIndex = 75;
            this.label3.Text = "تاريخ الدفع";
            // 
            // Frm_PaySuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(907, 480);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(923, 519);
            this.MinimumSize = new System.Drawing.Size(923, 519);
            this.Name = "Frm_PaySuppliers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدفوعات مورد";
            this.Load += new System.EventHandler(this.Frm_PaySuppliers_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_Stock;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.RadioButton RdbOneSuppliers;
        private System.Windows.Forms.RadioButton RdbAllSuppliers;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_prise;
        private System.Windows.Forms.TextBox txt_rent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.RadioButton rdbPartPay;
        private System.Windows.Forms.RadioButton RdbAllPay;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox Txt_sales;
        public System.Windows.Forms.Label label4;
    }
}