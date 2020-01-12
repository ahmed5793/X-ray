namespace Laboratory.PL
{
    partial class Frm_installment
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_GenderJob = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_new = new System.Windows.Forms.Button();
            this.txt_money = new System.Windows.Forms.TextBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_instalmenttype = new System.Windows.Forms.ComboBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_stock = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Maroon;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(818, 200);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_search);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(17, 244);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(838, 262);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(234, 19);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(262, 32);
            this.txt_search.TabIndex = 0;
            this.txt_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(502, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "بحث";
            // 
            // btn_GenderJob
            // 
            this.btn_GenderJob.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GenderJob.Location = new System.Drawing.Point(220, 18);
            this.btn_GenderJob.Name = "btn_GenderJob";
            this.btn_GenderJob.Size = new System.Drawing.Size(53, 27);
            this.btn_GenderJob.TabIndex = 37;
            this.btn_GenderJob.Text = "---------------";
            this.btn_GenderJob.UseVisualStyleBackColor = true;
            this.btn_GenderJob.Click += new System.EventHandler(this.btn_GenderJob_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(599, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 24);
            this.label8.TabIndex = 34;
            this.label8.Text = "نوع القسط";
            // 
            // btn_new
            // 
            this.btn_new.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.Location = new System.Drawing.Point(484, 128);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(132, 40);
            this.btn_new.TabIndex = 12;
            this.btn_new.Text = "جديد";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // txt_money
            // 
            this.txt_money.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_money.Location = new System.Drawing.Point(95, 66);
            this.txt_money.Name = "txt_money";
            this.txt_money.Size = new System.Drawing.Size(154, 32);
            this.txt_money.TabIndex = 0;
            this.txt_money.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_money.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_money_KeyPress);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(326, 128);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(118, 40);
            this.btn_update.TabIndex = 4;
            this.btn_update.Text = "تعديل بيانات العميل";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(439, 12);
            this.txt_username.MaxLength = 3000;
            this.txt_username.Name = "txt_username";
            this.txt_username.ReadOnly = true;
            this.txt_username.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_username.Size = new System.Drawing.Size(311, 32);
            this.txt_username.TabIndex = 2;
            this.txt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(255, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "المبلغ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(756, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "اسم المستخدم";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btn_GenderJob);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cmb_instalmenttype);
            this.groupBox1.Controls.Add(this.btn_new);
            this.groupBox1.Controls.Add(this.txt_money);
            this.groupBox1.Controls.Add(this.btn_update);
            this.groupBox1.Controls.Add(this.btn_save);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(838, 174);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(422, 72);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(309, 26);
            this.dateTimePicker1.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(737, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 24);
            this.label7.TabIndex = 33;
            this.label7.Text = "تاريخ القسط";
            // 
            // cmb_instalmenttype
            // 
            this.cmb_instalmenttype.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_instalmenttype.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_instalmenttype.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_instalmenttype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_instalmenttype.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_instalmenttype.FormattingEnabled = true;
            this.cmb_instalmenttype.Location = new System.Drawing.Point(279, 16);
            this.cmb_instalmenttype.Name = "cmb_instalmenttype";
            this.cmb_instalmenttype.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_instalmenttype.Size = new System.Drawing.Size(314, 32);
            this.cmb_instalmenttype.TabIndex = 33;
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(484, 128);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(132, 40);
            this.btn_save.TabIndex = 21;
            this.btn_save.Text = "تسجيل بيانات العميل";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 24);
            this.label1.TabIndex = 39;
            this.label1.Text = "خزينة";
            // 
            // cmb_stock
            // 
            this.cmb_stock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_stock.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_stock.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_stock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_stock.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_stock.FormattingEnabled = true;
            this.cmb_stock.Location = new System.Drawing.Point(10, 14);
            this.cmb_stock.Name = "cmb_stock";
            this.cmb_stock.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_stock.Size = new System.Drawing.Size(256, 32);
            this.cmb_stock.TabIndex = 38;
            // 
            // Frm_installment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 518);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cmb_stock);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_username);
            this.Name = "Frm_installment";
            this.Text = "Frm_installment";
            this.Load += new System.EventHandler(this.Frm_installment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_GenderJob;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.TextBox txt_money;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox cmb_instalmenttype;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cmb_stock;
    }
}