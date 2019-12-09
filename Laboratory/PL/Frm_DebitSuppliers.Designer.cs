namespace Laboratory.PL
{
    partial class Frm_DebitSuppliers
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
            this.txt_reb7h = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewDebit = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDebit)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_reb7h
            // 
            this.txt_reb7h.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_reb7h.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_reb7h.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_reb7h.ForeColor = System.Drawing.Color.Yellow;
            this.txt_reb7h.Location = new System.Drawing.Point(13, 410);
            this.txt_reb7h.MaximumSize = new System.Drawing.Size(191, 32);
            this.txt_reb7h.MinimumSize = new System.Drawing.Size(191, 32);
            this.txt_reb7h.Name = "txt_reb7h";
            this.txt_reb7h.ReadOnly = true;
            this.txt_reb7h.Size = new System.Drawing.Size(191, 32);
            this.txt_reb7h.TabIndex = 29;
            this.txt_reb7h.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(220, 409);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 31);
            this.label2.TabIndex = 28;
            this.label2.Text = "إجمالى المديونية الموردين";
            // 
            // dataGridViewDebit
            // 
            this.dataGridViewDebit.AllowUserToAddRows = false;
            this.dataGridViewDebit.AllowUserToDeleteRows = false;
            this.dataGridViewDebit.AllowUserToResizeColumns = false;
            this.dataGridViewDebit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDebit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDebit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewDebit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDebit.Location = new System.Drawing.Point(3, 2);
            this.dataGridViewDebit.MultiSelect = false;
            this.dataGridViewDebit.Name = "dataGridViewDebit";
            this.dataGridViewDebit.ReadOnly = true;
            this.dataGridViewDebit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewDebit.Size = new System.Drawing.Size(795, 390);
            this.dataGridViewDebit.TabIndex = 27;
            // 
            // Frm_DebitSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_reb7h);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewDebit);
            this.MinimumSize = new System.Drawing.Size(816, 488);
            this.Name = "Frm_DebitSuppliers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدوينية الموردين";
            this.Load += new System.EventHandler(this.Frm_DebitSuppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDebit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_reb7h;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView dataGridViewDebit;
    }
}