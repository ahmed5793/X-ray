namespace Laboratory.PL
{
    partial class Frm_Payouts
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
            this.cmb_Stock = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Cmb_customer = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmb_Stock
            // 
            this.cmb_Stock.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_Stock.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Stock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Stock.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Stock.FormattingEnabled = true;
            this.cmb_Stock.Location = new System.Drawing.Point(3, 2);
            this.cmb_Stock.Name = "cmb_Stock";
            this.cmb_Stock.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_Stock.Size = new System.Drawing.Size(172, 32);
            this.cmb_Stock.TabIndex = 86;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(181, 8);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 24);
            this.label14.TabIndex = 85;
            this.label14.Text = "خزينة";
            // 
            // Cmb_customer
            // 
            this.Cmb_customer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Cmb_customer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_customer.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_customer.FormattingEnabled = true;
            this.Cmb_customer.Location = new System.Drawing.Point(349, 5);
            this.Cmb_customer.Name = "Cmb_customer";
            this.Cmb_customer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Cmb_customer.Size = new System.Drawing.Size(320, 32);
            this.Cmb_customer.TabIndex = 94;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(711, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 24);
            this.label5.TabIndex = 93;
            this.label5.Text = "اسم المريض";
            // 
            // Frm_Payouts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 488);
            this.Controls.Add(this.Cmb_customer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_Stock);
            this.Controls.Add(this.label14);
            this.Name = "Frm_Payouts";
            this.Text = "Frm_Payouts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cmb_Stock;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.ComboBox Cmb_customer;
        private System.Windows.Forms.Label label5;
    }
}