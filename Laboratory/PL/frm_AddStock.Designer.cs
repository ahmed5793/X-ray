namespace Laboratory.PL
{
    partial class frm_AddStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AddStock));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.btn_update = new DevExpress.XtraEditors.SimpleButton();
            this.btn_new = new DevExpress.XtraEditors.SimpleButton();
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
            this.dataGridView1.Location = new System.Drawing.Point(6, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(469, 213);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(9, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(486, 232);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btn_delete);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 104);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(269, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(64, 26);
            this.textBox1.TabIndex = 26;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(341, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 27;
            this.label2.Text = "رقم الخزنة";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(97, 59);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(236, 26);
            this.txt_name.TabIndex = 0;
            this.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(8, 31);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(56, 40);
            this.btn_delete.TabIndex = 5;
            this.btn_delete.Text = "حذف ";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(339, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "إسم الخزنة";
            this.label5.Click += new System.EventHandler(this.label5_Click);
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
            this.Btn_Add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_AddShift.ImageOptions.Image")));
            this.Btn_Add.Location = new System.Drawing.Point(195, 125);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(129, 32);
            this.Btn_Add.TabIndex = 169;
            this.Btn_Add.Text = "حفظ";
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
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
            this.btn_update.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btn_update.Location = new System.Drawing.Point(30, 125);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(129, 32);
            this.btn_update.TabIndex = 170;
            this.btn_update.Text = "تعديل بيانات ";
            this.btn_update.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btn_new
            // 
            this.btn_new.Appearance.BackColor = System.Drawing.Color.Black;
            this.btn_new.Appearance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_new.Appearance.Options.UseBackColor = true;
            this.btn_new.Appearance.Options.UseFont = true;
            this.btn_new.Appearance.Options.UseForeColor = true;
            this.btn_new.Appearance.Options.UseTextOptions = true;
            this.btn_new.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btn_new.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btn_new.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btn_new.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image1")));
            this.btn_new.Location = new System.Drawing.Point(360, 125);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(129, 32);
            this.btn_new.TabIndex = 171;
            this.btn_new.Text = "تسجيل جديد";
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click_1);
            // 
            // frm_AddStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(501, 416);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(517, 454);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(517, 454);
            this.Name = "frm_AddStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة خزنة ";
            this.Load += new System.EventHandler(this.frm_AddStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton Btn_Add;
        private DevExpress.XtraEditors.SimpleButton btn_update;
        private DevExpress.XtraEditors.SimpleButton btn_new;
    }
}