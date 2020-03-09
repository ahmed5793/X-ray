namespace Laboratory.PL
{
    partial class Frm_DetailsCompay
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
            this.txt_prise = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_prise
            // 
            this.txt_prise.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prise.Location = new System.Drawing.Point(4, 59);
            this.txt_prise.Multiline = true;
            this.txt_prise.Name = "txt_prise";
            this.txt_prise.ReadOnly = true;
            this.txt_prise.Size = new System.Drawing.Size(412, 242);
            this.txt_prise.TabIndex = 5;
            this.txt_prise.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(130, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "الاوراق المطلوبة";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Frm_DetailsCompay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(418, 312);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_prise);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_DetailsCompay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة الاوراق المطلوبة للشركة";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txt_prise;
        private System.Windows.Forms.Label label1;
    }
}