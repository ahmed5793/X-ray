namespace Laboratory.PL
{
    partial class UpdateSalf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateSalf));
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_employeeName = new System.Windows.Forms.ComboBox();
            this.txt_date = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_salf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_UpdateSalary = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(617, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 24);
            this.label8.TabIndex = 47;
            this.label8.Text = "اسم الموظف";
            // 
            // cmb_employeeName
            // 
            this.cmb_employeeName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_employeeName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_employeeName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_employeeName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_employeeName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_employeeName.FormattingEnabled = true;
            this.cmb_employeeName.Location = new System.Drawing.Point(367, 16);
            this.cmb_employeeName.Name = "cmb_employeeName";
            this.cmb_employeeName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_employeeName.Size = new System.Drawing.Size(244, 32);
            this.cmb_employeeName.TabIndex = 46;
            this.cmb_employeeName.SelectionChangeCommitted += new System.EventHandler(this.cmb_employeeName_SelectionChangeCommitted);
            // 
            // txt_date
            // 
            this.txt_date.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_date.Location = new System.Drawing.Point(6, 103);
            this.txt_date.MaxLength = 11;
            this.txt_date.Name = "txt_date";
            this.txt_date.ReadOnly = true;
            this.txt_date.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_date.Size = new System.Drawing.Size(227, 32);
            this.txt_date.TabIndex = 44;
            this.txt_date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(239, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 45;
            this.label3.Text = "التاريخ";
            // 
            // txt_salf
            // 
            this.txt_salf.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_salf.Location = new System.Drawing.Point(33, 18);
            this.txt_salf.MaxLength = 11;
            this.txt_salf.Name = "txt_salf";
            this.txt_salf.ReadOnly = true;
            this.txt_salf.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_salf.Size = new System.Drawing.Size(164, 32);
            this.txt_salf.TabIndex = 42;
            this.txt_salf.Text = "0";
            this.txt_salf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(239, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 43;
            this.label2.Text = "السلف";
            // 
            // Txt_UpdateSalary
            // 
            this.Txt_UpdateSalary.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_UpdateSalary.Location = new System.Drawing.Point(393, 85);
            this.Txt_UpdateSalary.MaxLength = 11;
            this.Txt_UpdateSalary.Name = "Txt_UpdateSalary";
            this.Txt_UpdateSalary.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Txt_UpdateSalary.Size = new System.Drawing.Size(164, 32);
            this.Txt_UpdateSalary.TabIndex = 40;
            this.Txt_UpdateSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_UpdateSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_UpdateSalary_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(577, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 24);
            this.label9.TabIndex = 41;
            this.label9.Text = "التعديل علي السلف";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cmb_employeeName);
            this.groupBox1.Controls.Add(this.txt_date);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_salf);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Txt_UpdateSalary);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.MaximumSize = new System.Drawing.Size(728, 147);
            this.groupBox1.MinimumSize = new System.Drawing.Size(728, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(728, 147);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(298, 174);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(129, 34);
            this.simpleButton1.TabIndex = 48;
            this.simpleButton1.Text = "تعديل";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // UpdateSalf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(752, 211);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.groupBox1);
            this.Name = "UpdateSalf";
            this.Text = "تعديل علي السلف";
            this.Load += new System.EventHandler(this.UpdateSalf_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.ComboBox cmb_employeeName;
        private System.Windows.Forms.TextBox txt_date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_salf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_UpdateSalary;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}