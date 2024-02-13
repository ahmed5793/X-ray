namespace Tourism_Company.PL
{
    partial class Form_AllTicket
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
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rdb_customer = new System.Windows.Forms.RadioButton();
            this.rdb_company = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Maroon;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(794, 343);
            this.dataGridView1.TabIndex = 13;
            // 
            // btn_update
            // 
            this.btn_update.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_update.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(457, 398);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(197, 40);
            this.btn_update.TabIndex = 14;
            this.btn_update.Text = "تعديل بيانات التذكرة";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.Btn_update_Click);
            // 
            // btn_print
            // 
            this.btn_print.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_print.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.Location = new System.Drawing.Point(156, 398);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(173, 40);
            this.btn_print.TabIndex = 15;
            this.btn_print.Text = "مسح  التذكرة المحددة";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.Btn_print_Click);
            // 
            // txt_search
            // 
            this.txt_search.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_search.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(208, 11);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(262, 32);
            this.txt_search.TabIndex = 16;
            this.txt_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_search.TextChanged += new System.EventHandler(this.Txt_search_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(476, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "بحث";
            // 
            // rdb_customer
            // 
            this.rdb_customer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdb_customer.AutoSize = true;
            this.rdb_customer.BackColor = System.Drawing.Color.Black;
            this.rdb_customer.Checked = true;
            this.rdb_customer.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_customer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdb_customer.Location = new System.Drawing.Point(579, 8);
            this.rdb_customer.Name = "rdb_customer";
            this.rdb_customer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdb_customer.Size = new System.Drawing.Size(66, 33);
            this.rdb_customer.TabIndex = 50;
            this.rdb_customer.TabStop = true;
            this.rdb_customer.Text = "أفراد";
            this.rdb_customer.UseVisualStyleBackColor = false;
            this.rdb_customer.CheckedChanged += new System.EventHandler(this.Rdb_customer_CheckedChanged);
            // 
            // rdb_company
            // 
            this.rdb_company.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdb_company.AutoSize = true;
            this.rdb_company.BackColor = System.Drawing.Color.Black;
            this.rdb_company.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_company.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdb_company.Location = new System.Drawing.Point(694, 8);
            this.rdb_company.Name = "rdb_company";
            this.rdb_company.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdb_company.Size = new System.Drawing.Size(87, 33);
            this.rdb_company.TabIndex = 49;
            this.rdb_company.Text = "شركات";
            this.rdb_company.UseVisualStyleBackColor = false;
            this.rdb_company.CheckedChanged += new System.EventHandler(this.Rdb_company_CheckedChanged);
            // 
            // Form_AllTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rdb_customer);
            this.Controls.Add(this.rdb_company);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.dataGridView1);
            this.MinimumSize = new System.Drawing.Size(816, 488);
            this.Name = "Form_AllTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "عرض كل التذاكر المحجوزة";
            this.Load += new System.EventHandler(this.Form_AllTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdb_customer;
        private System.Windows.Forms.RadioButton rdb_company;
    }
}