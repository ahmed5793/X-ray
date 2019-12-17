namespace Laboratory.BL
{
    partial class Frm_CompanyItemXray
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
            this.Cmb_category = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmb_items = new System.Windows.Forms.ComboBox();
            this.cmb_Company = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.Txt_Price = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_visit = new System.Windows.Forms.DataGridView();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_visit)).BeginInit();
            this.SuspendLayout();
            // 
            // Cmb_category
            // 
            this.Cmb_category.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Cmb_category.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Cmb_category.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_category.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_category.FormattingEnabled = true;
            this.Cmb_category.ItemHeight = 24;
            this.Cmb_category.Location = new System.Drawing.Point(134, 59);
            this.Cmb_category.Name = "Cmb_category";
            this.Cmb_category.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Cmb_category.Size = new System.Drawing.Size(367, 32);
            this.Cmb_category.TabIndex = 1;
            this.Cmb_category.SelectionChangeCommitted += new System.EventHandler(this.Cmb_category_SelectionChangeCommitted);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(506, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 24);
            this.label9.TabIndex = 90;
            this.label9.Text = "نوع الفحص";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(514, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 24);
            this.label10.TabIndex = 91;
            this.label10.Text = "الجهاز";
            // 
            // cmb_items
            // 
            this.cmb_items.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmb_items.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_items.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_items.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_items.FormattingEnabled = true;
            this.cmb_items.ItemHeight = 24;
            this.cmb_items.Location = new System.Drawing.Point(134, 102);
            this.cmb_items.Name = "cmb_items";
            this.cmb_items.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_items.Size = new System.Drawing.Size(367, 32);
            this.cmb_items.TabIndex = 2;
            this.cmb_items.SelectionChangeCommitted += new System.EventHandler(this.cmb_items_SelectionChangeCommitted);
            // 
            // cmb_Company
            // 
            this.cmb_Company.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmb_Company.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_Company.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Company.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Company.FormattingEnabled = true;
            this.cmb_Company.Location = new System.Drawing.Point(134, 15);
            this.cmb_Company.Name = "cmb_Company";
            this.cmb_Company.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_Company.Size = new System.Drawing.Size(366, 32);
            this.cmb_Company.TabIndex = 0;
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(506, 20);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(91, 24);
            this.label21.TabIndex = 93;
            this.label21.Text = "اسم الشركة";
            // 
            // Txt_Price
            // 
            this.Txt_Price.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_Price.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Price.Location = new System.Drawing.Point(471, 150);
            this.Txt_Price.Name = "Txt_Price";
            this.Txt_Price.Size = new System.Drawing.Size(127, 32);
            this.Txt_Price.TabIndex = 3;
            this.Txt_Price.Text = "0";
            this.Txt_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Price_KeyPress);
            this.Txt_Price.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Txt_Price_MouseMove);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(598, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 24);
            this.label2.TabIndex = 96;
            this.label2.Text = "السعر";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(3, 150);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 32);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.MouseLeave += new System.EventHandler(this.textBox1_MouseLeave);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 24);
            this.label1.TabIndex = 98;
            this.label1.Text = "القيمة الذى يتحملها المريض";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.dgv_visit);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Location = new System.Drawing.Point(3, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(665, 234);
            this.groupBox1.TabIndex = 101;
            this.groupBox1.TabStop = false;
            // 
            // dgv_visit
            // 
            this.dgv_visit.AllowUserToAddRows = false;
            this.dgv_visit.AllowUserToDeleteRows = false;
            this.dgv_visit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_visit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_visit.BackgroundColor = System.Drawing.Color.Maroon;
            this.dgv_visit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_visit.Location = new System.Drawing.Point(6, 57);
            this.dgv_visit.Name = "dgv_visit";
            this.dgv_visit.ReadOnly = true;
            this.dgv_visit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_visit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_visit.ShowEditingIcon = false;
            this.dgv_visit.Size = new System.Drawing.Size(653, 170);
            this.dgv_visit.TabIndex = 102;
            this.dgv_visit.DoubleClick += new System.EventHandler(this.dgv_visit_DoubleClick);
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.SeaShell;
            this.label22.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(347, 22);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(242, 24);
            this.label22.TabIndex = 101;
            this.label22.Text = "بحث بأسم الشركة أو نوع الفحص";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(100, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(233, 32);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btn_print
            // 
            this.btn_print.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_print.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.Location = new System.Drawing.Point(147, 217);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(200, 40);
            this.btn_print.TabIndex = 103;
            this.btn_print.Text = "تعديل البيانات";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_save.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(377, 217);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(200, 40);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "حفظ";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // Frm_CompanyItemXray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(671, 495);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_Price);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cmb_category);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmb_items);
            this.Controls.Add(this.cmb_Company);
            this.Controls.Add(this.label21);
            this.MinimumSize = new System.Drawing.Size(687, 533);
            this.Name = "Frm_CompanyItemXray";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة الفحوصات للشركات";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_visit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox Cmb_category;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.ComboBox cmb_items;
        public System.Windows.Forms.ComboBox cmb_Company;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox Txt_Price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.DataGridView dgv_visit;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_save;
    }
}