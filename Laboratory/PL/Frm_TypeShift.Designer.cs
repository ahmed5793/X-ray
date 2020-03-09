namespace Laboratory.PL
{
    partial class Frm_TypeShift
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_TypeShift));
            this.Txt_Salary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_prod = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // Txt_Salary
            // 
            this.Txt_Salary.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Salary.Location = new System.Drawing.Point(41, 55);
            this.Txt_Salary.MaxLength = 11;
            this.Txt_Salary.Name = "Txt_Salary";
            this.Txt_Salary.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Txt_Salary.Size = new System.Drawing.Size(333, 32);
            this.Txt_Salary.TabIndex = 0;
            this.Txt_Salary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(155, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 24);
            this.label5.TabIndex = 115;
            this.label5.Text = "نوع الشيفت";
            // 
            // btn_prod
            // 
            this.btn_prod.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prod.Appearance.Options.UseFont = true;
            this.btn_prod.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_prod.ImageOptions.Image")));
            this.btn_prod.Location = new System.Drawing.Point(123, 132);
            this.btn_prod.Name = "btn_prod";
            this.btn_prod.Size = new System.Drawing.Size(152, 45);
            this.btn_prod.TabIndex = 118;
            this.btn_prod.Text = "اضافة";
            this.btn_prod.Click += new System.EventHandler(this.btn_prod_Click);
            // 
            // Frm_TypeShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(396, 228);
            this.Controls.Add(this.btn_prod);
            this.Controls.Add(this.Txt_Salary);
            this.Controls.Add(this.label5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(412, 267);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(412, 266);
            this.Name = "Frm_TypeShift";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة إضافة نوع الشيفت";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Txt_Salary;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton btn_prod;
    }
}