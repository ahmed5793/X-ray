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
            this.cmb_Stock = new System.Windows.Forms.ComboBox();
            this.cmb_client = new System.Windows.Forms.ComboBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.RdbOneCustomer = new System.Windows.Forms.RadioButton();
            this.RdbAllCustomer = new System.Windows.Forms.RadioButton();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_client = new System.Windows.Forms.Button();
            this.txt_prise = new System.Windows.Forms.TextBox();
            this.txt_rent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbPartPay = new System.Windows.Forms.RadioButton();
            this.RdbAllPay = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_Stock
            // 
            this.cmb_Stock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Stock.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_Stock.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Stock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Stock.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Stock.FormattingEnabled = true;
            this.cmb_Stock.Location = new System.Drawing.Point(12, 28);
            this.cmb_Stock.Name = "cmb_Stock";
            this.cmb_Stock.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_Stock.Size = new System.Drawing.Size(193, 30);
            this.cmb_Stock.TabIndex = 84;
            // 
            // cmb_client
            // 
            this.cmb_client.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_client.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_client.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_client.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_client.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_client.FormattingEnabled = true;
            this.cmb_client.Location = new System.Drawing.Point(287, 17);
            this.cmb_client.Name = "cmb_client";
            this.cmb_client.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_client.Size = new System.Drawing.Size(244, 32);
            this.cmb_client.TabIndex = 29;
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(48, 17);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(179, 30);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "بحث";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // RdbOneCustomer
            // 
            this.RdbOneCustomer.AutoSize = true;
            this.RdbOneCustomer.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbOneCustomer.Location = new System.Drawing.Point(537, 19);
            this.RdbOneCustomer.Name = "RdbOneCustomer";
            this.RdbOneCustomer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RdbOneCustomer.Size = new System.Drawing.Size(97, 26);
            this.RdbOneCustomer.TabIndex = 1;
            this.RdbOneCustomer.Text = "عميل محدد";
            this.RdbOneCustomer.UseVisualStyleBackColor = true;
            this.RdbOneCustomer.CheckedChanged += new System.EventHandler(this.RdbOneCustomer_CheckedChanged);
            // 
            // RdbAllCustomer
            // 
            this.RdbAllCustomer.AutoSize = true;
            this.RdbAllCustomer.Checked = true;
            this.RdbAllCustomer.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbAllCustomer.Location = new System.Drawing.Point(802, 21);
            this.RdbAllCustomer.Name = "RdbAllCustomer";
            this.RdbAllCustomer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RdbAllCustomer.Size = new System.Drawing.Size(96, 26);
            this.RdbAllCustomer.TabIndex = 0;
            this.RdbAllCustomer.TabStop = true;
            this.RdbAllCustomer.Text = "كل العملاء ";
            this.RdbAllCustomer.UseVisualStyleBackColor = true;
            this.RdbAllCustomer.CheckedChanged += new System.EventHandler(this.RdbAllCustomer_CheckedChanged);
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.White;
            this.label19.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(211, 28);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(60, 29);
            this.label19.TabIndex = 83;
            this.label19.Text = "خزينة";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_client);
            this.groupBox2.Controls.Add(this.txt_prise);
            this.groupBox2.Controls.Add(this.txt_rent);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.rdbPartPay);
            this.groupBox2.Controls.Add(this.RdbAllPay);
            this.groupBox2.Location = new System.Drawing.Point(12, 410);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(935, 87);
            this.groupBox2.TabIndex = 79;
            this.groupBox2.TabStop = false;
            // 
            // btn_client
            // 
            this.btn_client.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_client.Location = new System.Drawing.Point(374, 27);
            this.btn_client.Name = "btn_client";
            this.btn_client.Size = new System.Drawing.Size(126, 46);
            this.btn_client.TabIndex = 65;
            this.btn_client.Text = "دفع ";
            this.btn_client.UseVisualStyleBackColor = true;
            this.btn_client.Click += new System.EventHandler(this.btn_client_Click);
            // 
            // txt_prise
            // 
            this.txt_prise.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prise.Location = new System.Drawing.Point(506, 38);
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
            this.txt_rent.Location = new System.Drawing.Point(6, 35);
            this.txt_rent.Name = "txt_rent";
            this.txt_rent.ReadOnly = true;
            this.txt_rent.Size = new System.Drawing.Size(127, 29);
            this.txt_rent.TabIndex = 62;
            this.txt_rent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(142, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 22);
            this.label2.TabIndex = 61;
            this.label2.Text = "اجمالي المبالغ المتبقيه";
            // 
            // rdbPartPay
            // 
            this.rdbPartPay.AutoSize = true;
            this.rdbPartPay.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPartPay.Location = new System.Drawing.Point(628, 38);
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
            this.RdbAllPay.AutoSize = true;
            this.RdbAllPay.Checked = true;
            this.RdbAllPay.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbAllPay.Location = new System.Drawing.Point(775, 38);
            this.RdbAllPay.Name = "RdbAllPay";
            this.RdbAllPay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RdbAllPay.Size = new System.Drawing.Size(149, 26);
            this.RdbAllPay.TabIndex = 0;
            this.RdbAllPay.TabStop = true;
            this.RdbAllPay.Text = "تسديد المبلغ بالكامل";
            this.RdbAllPay.UseVisualStyleBackColor = true;
            this.RdbAllPay.CheckedChanged += new System.EventHandler(this.RdbAllPay_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(880, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 24);
            this.label3.TabIndex = 81;
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
            this.dataGridView1.Location = new System.Drawing.Point(6, 131);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(963, 273);
            this.dataGridView1.TabIndex = 80;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_client);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.RdbOneCustomer);
            this.groupBox1.Controls.Add(this.RdbAllCustomer);
            this.groupBox1.Location = new System.Drawing.Point(6, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(941, 61);
            this.groupBox1.TabIndex = 77;
            this.groupBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(695, 34);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(179, 26);
            this.dateTimePicker1.TabIndex = 82;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(381, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 29);
            this.label1.TabIndex = 78;
            this.label1.Text = "المبالغ المتبقيه علي العملاء";
            // 
            // Frm_PayClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 506);
            this.Controls.Add(this.cmb_Stock);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Name = "Frm_PayClient";
            this.Text = "Frm_PayClient";
            this.Load += new System.EventHandler(this.Frm_PayClient_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cmb_Stock;
        public System.Windows.Forms.ComboBox cmb_client;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.RadioButton RdbOneCustomer;
        private System.Windows.Forms.RadioButton RdbAllCustomer;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_client;
        private System.Windows.Forms.TextBox txt_prise;
        private System.Windows.Forms.TextBox txt_rent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbPartPay;
        private System.Windows.Forms.RadioButton RdbAllPay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
    }
}