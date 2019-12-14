namespace Laboratory.PL
{
    partial class Frm_Search_Ticket
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_day = new System.Windows.Forms.Label();
            this.cmb_branches = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.dgv_visit = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_visit)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_day);
            this.groupBox1.Controls.Add(this.cmb_branches);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txt_username);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(987, 51);
            this.groupBox1.TabIndex = 100;
            this.groupBox1.TabStop = false;
            // 
            // label_day
            // 
            this.label_day.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_day.AutoSize = true;
            this.label_day.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_day.Location = new System.Drawing.Point(476, 12);
            this.label_day.Name = "label_day";
            this.label_day.Size = new System.Drawing.Size(36, 24);
            this.label_day.TabIndex = 85;
            this.label_day.Text = "فرع";
            // 
            // cmb_branches
            // 
            this.cmb_branches.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmb_branches.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_branches.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_branches.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_branches.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_branches.FormattingEnabled = true;
            this.cmb_branches.Location = new System.Drawing.Point(33, 9);
            this.cmb_branches.Name = "cmb_branches";
            this.cmb_branches.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_branches.Size = new System.Drawing.Size(233, 32);
            this.cmb_branches.TabIndex = 84;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(877, 16);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(106, 24);
            this.label18.TabIndex = 57;
            this.label18.Text = "اسم المستخدم";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(272, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 24);
            this.label13.TabIndex = 83;
            this.label13.Text = "فرع";
            // 
            // txt_username
            // 
            this.txt_username.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_username.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(638, 9);
            this.txt_username.Name = "txt_username";
            this.txt_username.ReadOnly = true;
            this.txt_username.Size = new System.Drawing.Size(233, 32);
            this.txt_username.TabIndex = 56;
            this.txt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.dgv_visit.Location = new System.Drawing.Point(12, 112);
            this.dgv_visit.Name = "dgv_visit";
            this.dgv_visit.ReadOnly = true;
            this.dgv_visit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_visit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_visit.ShowEditingIcon = false;
            this.dgv_visit.Size = new System.Drawing.Size(987, 332);
            this.dgv_visit.TabIndex = 99;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(636, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 86;
            this.label1.Text = "اسم المستخدم";
            // 
            // txt_search
            // 
            this.txt_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_search.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(252, 68);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(378, 32);
            this.txt_search.TabIndex = 86;
            this.txt_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // btn_print
            // 
            this.btn_print.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_print.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.Location = new System.Drawing.Point(324, 475);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(200, 40);
            this.btn_print.TabIndex = 103;
            this.btn_print.Text = "طباعة فاتورة";
            this.btn_print.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_save.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(559, 475);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(200, 40);
            this.btn_save.TabIndex = 102;
            this.btn_save.Text = "عرض  تفاصيل الفاتورة";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(106, 475);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 40);
            this.button1.TabIndex = 104;
            this.button1.Text = "طباعة باركود";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Frm_Search_Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 527);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_visit);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_Search_Ticket";
            this.Text = "Frm_Search_Ticket";
            this.Load += new System.EventHandler(this.Frm_Search_Ticket_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_visit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_day;
        public System.Windows.Forms.ComboBox cmb_branches;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label18;
        public System.Windows.Forms.DataGridView dgv_visit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button button1;
    }
}