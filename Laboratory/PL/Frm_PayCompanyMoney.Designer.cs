﻿namespace Laboratory.PL
{
    partial class Frm_PayCompanyMoney
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
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_SalesMAn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Cmb_Branch = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cmb_Stock = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_client = new System.Windows.Forms.Button();
            this.txt_prise = new System.Windows.Forms.TextBox();
            this.txt_rent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbPartPay = new System.Windows.Forms.RadioButton();
            this.RdbAllPay = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.RdbOneCustomer = new System.Windows.Forms.RadioButton();
            this.RdbAllCustomer = new System.Windows.Forms.RadioButton();
            this.cmb_company = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(512, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 22);
            this.label5.TabIndex = 107;
            this.label5.Text = "إسم المستخدم";
            // 
            // Txt_SalesMAn
            // 
            this.Txt_SalesMAn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_SalesMAn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_SalesMAn.Location = new System.Drawing.Point(430, 81);
            this.Txt_SalesMAn.Multiline = true;
            this.Txt_SalesMAn.Name = "Txt_SalesMAn";
            this.Txt_SalesMAn.ReadOnly = true;
            this.Txt_SalesMAn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_SalesMAn.Size = new System.Drawing.Size(256, 32);
            this.Txt_SalesMAn.TabIndex = 96;
            this.Txt_SalesMAn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(274, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 29);
            this.label4.TabIndex = 105;
            this.label4.Text = "الفرع";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cmb_Branch
            // 
            this.Cmb_Branch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Cmb_Branch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_Branch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Branch.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Branch.FormattingEnabled = true;
            this.Cmb_Branch.Location = new System.Drawing.Point(3, 47);
            this.Cmb_Branch.Name = "Cmb_Branch";
            this.Cmb_Branch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Cmb_Branch.Size = new System.Drawing.Size(265, 30);
            this.Cmb_Branch.TabIndex = 106;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.White;
            this.label19.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(252, 92);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(100, 29);
            this.label19.TabIndex = 103;
            this.label19.Text = "إسم الخزنة";
            // 
            // cmb_Stock
            // 
            this.cmb_Stock.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_Stock.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Stock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Stock.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Stock.FormattingEnabled = true;
            this.cmb_Stock.Location = new System.Drawing.Point(3, 92);
            this.cmb_Stock.Name = "cmb_Stock";
            this.cmb_Stock.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_Stock.Size = new System.Drawing.Size(244, 30);
            this.cmb_Stock.TabIndex = 104;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btn_client);
            this.groupBox2.Controls.Add(this.txt_prise);
            this.groupBox2.Controls.Add(this.txt_rent);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.rdbPartPay);
            this.groupBox2.Controls.Add(this.RdbAllPay);
            this.groupBox2.Location = new System.Drawing.Point(3, 468);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(984, 78);
            this.groupBox2.TabIndex = 99;
            this.groupBox2.TabStop = false;
            // 
            // btn_client
            // 
            this.btn_client.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_client.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_client.Location = new System.Drawing.Point(362, 16);
            this.btn_client.Name = "btn_client";
            this.btn_client.Size = new System.Drawing.Size(126, 46);
            this.btn_client.TabIndex = 65;
            this.btn_client.Text = "دفع ";
            this.btn_client.UseVisualStyleBackColor = true;
            this.btn_client.Click += new System.EventHandler(this.btn_client_Click);
            // 
            // txt_prise
            // 
            this.txt_prise.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txt_prise.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prise.Location = new System.Drawing.Point(531, 23);
            this.txt_prise.MaxLength = 8;
            this.txt_prise.Name = "txt_prise";
            this.txt_prise.Size = new System.Drawing.Size(116, 27);
            this.txt_prise.TabIndex = 63;
            this.txt_prise.Text = "0";
            this.txt_prise.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_prise.Click += new System.EventHandler(this.txt_prise_Click);
            this.txt_prise.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txt_prise_MouseMove);
            // 
            // txt_rent
            // 
            this.txt_rent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_rent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_rent.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rent.Location = new System.Drawing.Point(6, 26);
            this.txt_rent.Name = "txt_rent";
            this.txt_rent.ReadOnly = true;
            this.txt_rent.Size = new System.Drawing.Size(127, 29);
            this.txt_rent.TabIndex = 62;
            this.txt_rent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(142, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 22);
            this.label2.TabIndex = 61;
            this.label2.Text = "اجمالي المبالغ المتبقيه";
            // 
            // rdbPartPay
            // 
            this.rdbPartPay.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.rdbPartPay.AutoSize = true;
            this.rdbPartPay.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPartPay.Location = new System.Drawing.Point(686, 26);
            this.rdbPartPay.Name = "rdbPartPay";
            this.rdbPartPay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdbPartPay.Size = new System.Drawing.Size(122, 26);
            this.rdbPartPay.TabIndex = 1;
            this.rdbPartPay.Text = "تسديد جزء منه";
            this.rdbPartPay.UseVisualStyleBackColor = true;
            this.rdbPartPay.CheckedChanged += new System.EventHandler(this.rdbPartPay_CheckedChanged);
            // 
            // RdbAllPay
            // 
            this.RdbAllPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RdbAllPay.AutoSize = true;
            this.RdbAllPay.Checked = true;
            this.RdbAllPay.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbAllPay.Location = new System.Drawing.Point(824, 29);
            this.RdbAllPay.Name = "RdbAllPay";
            this.RdbAllPay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RdbAllPay.Size = new System.Drawing.Size(149, 26);
            this.RdbAllPay.TabIndex = 0;
            this.RdbAllPay.TabStop = true;
            this.RdbAllPay.Text = "تسديد المبلغ بالكامل";
            this.RdbAllPay.UseVisualStyleBackColor = true;
            this.RdbAllPay.CheckedChanged += new System.EventHandler(this.RdbAllPay_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(797, 85);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(179, 26);
            this.dateTimePicker1.TabIndex = 102;
            // 
            // RdbOneCustomer
            // 
            this.RdbOneCustomer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RdbOneCustomer.AutoSize = true;
            this.RdbOneCustomer.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbOneCustomer.Location = new System.Drawing.Point(656, 21);
            this.RdbOneCustomer.Name = "RdbOneCustomer";
            this.RdbOneCustomer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RdbOneCustomer.Size = new System.Drawing.Size(107, 26);
            this.RdbOneCustomer.TabIndex = 1;
            this.RdbOneCustomer.Text = "شركة محددة";
            this.RdbOneCustomer.UseVisualStyleBackColor = true;
            this.RdbOneCustomer.CheckedChanged += new System.EventHandler(this.RdbOneCustomer_CheckedChanged);
            // 
            // RdbAllCustomer
            // 
            this.RdbAllCustomer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RdbAllCustomer.AutoSize = true;
            this.RdbAllCustomer.Checked = true;
            this.RdbAllCustomer.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbAllCustomer.Location = new System.Drawing.Point(793, 21);
            this.RdbAllCustomer.Name = "RdbAllCustomer";
            this.RdbAllCustomer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RdbAllCustomer.Size = new System.Drawing.Size(105, 26);
            this.RdbAllCustomer.TabIndex = 0;
            this.RdbAllCustomer.TabStop = true;
            this.RdbAllCustomer.Text = "كل الشركات ";
            this.RdbAllCustomer.UseVisualStyleBackColor = true;
            this.RdbAllCustomer.CheckedChanged += new System.EventHandler(this.RdbAllCustomer_CheckedChanged);
            // 
            // cmb_company
            // 
            this.cmb_company.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmb_company.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_company.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_company.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_company.FormattingEnabled = true;
            this.cmb_company.Location = new System.Drawing.Point(306, 19);
            this.cmb_company.Name = "cmb_company";
            this.cmb_company.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_company.Size = new System.Drawing.Size(330, 32);
            this.cmb_company.TabIndex = 29;
            this.cmb_company.SelectionChangeCommitted += new System.EventHandler(this.cmb_company_SelectionChangeCommitted);
            this.cmb_company.Leave += new System.EventHandler(this.cmb_company_Leave);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(842, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 24);
            this.label3.TabIndex = 101;
            this.label3.Text = "تاريخ الدفع";
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
            this.dataGridView1.Location = new System.Drawing.Point(4, 190);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(989, 275);
            this.dataGridView1.TabIndex = 100;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cmb_company);
            this.groupBox1.Controls.Add(this.RdbOneCustomer);
            this.groupBox1.Controls.Add(this.RdbAllCustomer);
            this.groupBox1.Location = new System.Drawing.Point(4, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(989, 61);
            this.groupBox1.TabIndex = 97;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(425, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 29);
            this.label1.TabIndex = 98;
            this.label1.Text = "المبالغ المتبقيه علي الشركات";
            // 
            // Frm_PayCompanyMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(997, 553);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txt_SalesMAn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Cmb_Branch);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.cmb_Stock);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(1013, 591);
            this.Name = "Frm_PayCompanyMoney";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدفوعات الشركات";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_SalesMAn;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox Cmb_Branch;
        private System.Windows.Forms.Label label19;
        public System.Windows.Forms.ComboBox cmb_Stock;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_client;
        private System.Windows.Forms.TextBox txt_prise;
        private System.Windows.Forms.TextBox txt_rent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbPartPay;
        private System.Windows.Forms.RadioButton RdbAllPay;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton RdbOneCustomer;
        private System.Windows.Forms.RadioButton RdbAllCustomer;
        public System.Windows.Forms.ComboBox cmb_company;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}