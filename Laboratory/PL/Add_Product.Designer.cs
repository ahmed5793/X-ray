namespace Laboratory.PL
{
    partial class Add_Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Product));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_seeling = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_phr = new System.Windows.Forms.TextBox();
            this.dataGridViewPR = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.Btn_New = new DevExpress.XtraEditors.SimpleButton();
            this.btn_update = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPR)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.txt_seeling);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txt_name);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txt_phr);
            this.groupBox3.Location = new System.Drawing.Point(2, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(604, 124);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            // 
            // txt_seeling
            // 
            this.txt_seeling.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_seeling.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_seeling.Location = new System.Drawing.Point(50, 75);
            this.txt_seeling.Name = "txt_seeling";
            this.txt_seeling.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_seeling.Size = new System.Drawing.Size(164, 26);
            this.txt_seeling.TabIndex = 2;
            this.txt_seeling.Text = "0";
            this.txt_seeling.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_seeling.Click += new System.EventHandler(this.txt_seeling_Click);
            this.txt_seeling.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_seeling_MouseClick);
            this.txt_seeling.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_seeling_KeyPress);
            this.txt_seeling.Leave += new System.EventHandler(this.txt_seeling_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Black;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(491, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 19);
            this.label10.TabIndex = 7;
            this.label10.Text = "سعر الشراء";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Black;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(220, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 19);
            this.label11.TabIndex = 5;
            this.label11.Text = "سعر البيع";
            // 
            // txt_name
            // 
            this.txt_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_name.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(130, 20);
            this.txt_name.Multiline = true;
            this.txt_name.Name = "txt_name";
            this.txt_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_name.Size = new System.Drawing.Size(316, 28);
            this.txt_name.TabIndex = 0;
            this.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Black;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(452, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 19);
            this.label13.TabIndex = 1;
            this.label13.Text = "اسم المنتج";
            // 
            // txt_phr
            // 
            this.txt_phr.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phr.Location = new System.Drawing.Point(328, 75);
            this.txt_phr.Name = "txt_phr";
            this.txt_phr.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_phr.Size = new System.Drawing.Size(157, 26);
            this.txt_phr.TabIndex = 1;
            this.txt_phr.Text = "0";
            this.txt_phr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_phr.Click += new System.EventHandler(this.txt_phr_Click);
            this.txt_phr.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_phr_MouseClick);
            this.txt_phr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_phr_KeyPress);
            this.txt_phr.Leave += new System.EventHandler(this.txt_phr_Leave);
            // 
            // dataGridViewPR
            // 
            this.dataGridViewPR.AllowUserToAddRows = false;
            this.dataGridViewPR.AllowUserToDeleteRows = false;
            this.dataGridViewPR.AllowUserToResizeRows = false;
            this.dataGridViewPR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPR.Location = new System.Drawing.Point(9, 236);
            this.dataGridViewPR.MultiSelect = false;
            this.dataGridViewPR.Name = "dataGridViewPR";
            this.dataGridViewPR.ReadOnly = true;
            this.dataGridViewPR.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewPR.Size = new System.Drawing.Size(597, 285);
            this.dataGridViewPR.TabIndex = 22;
            this.dataGridViewPR.DoubleClick += new System.EventHandler(this.dataGridViewPR_DoubleClick);
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Black;
            this.label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.Control;
            this.label15.Location = new System.Drawing.Point(361, 207);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 19);
            this.label15.TabIndex = 21;
            this.label15.Text = "بحث بااسم الصنف";
            // 
            // txt_search
            // 
            this.txt_search.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_search.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(147, 201);
            this.txt_search.Name = "txt_search";
            this.txt_search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_search.Size = new System.Drawing.Size(208, 29);
            this.txt_search.TabIndex = 8;
            this.txt_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // Btn_New
            // 
            this.Btn_New.Appearance.BackColor = System.Drawing.Color.Black;
            this.Btn_New.Appearance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_New.Appearance.ForeColor = System.Drawing.Color.White;
            this.Btn_New.Appearance.Options.UseBackColor = true;
            this.Btn_New.Appearance.Options.UseFont = true;
            this.Btn_New.Appearance.Options.UseForeColor = true;
            this.Btn_New.Appearance.Options.UseTextOptions = true;
            this.Btn_New.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Btn_New.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Btn_New.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.Btn_New.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_New.ImageOptions.Image")));
            this.Btn_New.Location = new System.Drawing.Point(410, 138);
            this.Btn_New.Name = "Btn_New";
            this.Btn_New.Size = new System.Drawing.Size(129, 32);
            this.Btn_New.TabIndex = 177;
            this.Btn_New.Text = "تسجيل جديد";
            this.Btn_New.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btn_update
            // 
            this.btn_update.Appearance.BackColor = System.Drawing.Color.Black;
            this.btn_update.Appearance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_update.Appearance.Options.UseBackColor = true;
            this.btn_update.Appearance.Options.UseFont = true;
            this.btn_update.Appearance.Options.UseForeColor = true;
            this.btn_update.Appearance.Options.UseTextOptions = true;
            this.btn_update.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btn_update.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btn_update.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btn_update.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_update.ImageOptions.Image")));
            this.btn_update.Location = new System.Drawing.Point(70, 138);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(129, 32);
            this.btn_update.TabIndex = 176;
            this.btn_update.Text = "تعديل بيانات ";
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click_1);
            // 
            // Btn_Add
            // 
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
            this.Btn_Add.Location = new System.Drawing.Point(245, 138);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(129, 32);
            this.Btn_Add.TabIndex = 175;
            this.Btn_Add.Text = "حفظ";
            this.Btn_Add.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // Add_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(611, 525);
            this.Controls.Add(this.Btn_New);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.dataGridViewPR);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.groupBox3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(627, 563);
            this.MinimumSize = new System.Drawing.Size(627, 563);
            this.Name = "Add_Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة صنف";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.TextBox txt_seeling;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_phr;
        private System.Windows.Forms.DataGridView dataGridViewPR;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_search;
        private DevExpress.XtraEditors.SimpleButton Btn_New;
        private DevExpress.XtraEditors.SimpleButton btn_update;
        private DevExpress.XtraEditors.SimpleButton Btn_Add;
    }
}