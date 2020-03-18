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
            this.button1 = new DevExpress.XtraEditors.SimpleButton();
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
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Appearance.BackColor = System.Drawing.Color.White;
            this.button1.Appearance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Appearance.ForeColor = System.Drawing.Color.White;
            this.button1.Appearance.Options.UseBackColor = true;
            this.button1.Appearance.Options.UseFont = true;
            this.button1.Appearance.Options.UseForeColor = true;
            this.button1.Appearance.Options.UseTextOptions = true;
            this.button1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.button1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.button1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.button1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Save.ImageOptions.Image")));
            this.button1.Location = new System.Drawing.Point(108, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 37);
            this.button1.TabIndex = 171;
            this.button1.Text = "إضافة";
            this.button1.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Frm_TypeShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(396, 228);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Txt_Salary);
            this.Controls.Add(this.label5);
            this.MaximizeBox = false;
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
        private DevExpress.XtraEditors.SimpleButton button1;
    }
}