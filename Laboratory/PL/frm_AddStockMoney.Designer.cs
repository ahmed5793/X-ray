namespace Laboratory.PL
{
    partial class frm_AddStockMoney
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_CurrentBalance = new System.Windows.Forms.TextBox();
            this.txt_addbalance = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_reason = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Date_insert = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_Stock = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(241, 247);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(78, 22);
            this.label1.TabIndex = 54;
            this.label1.Text = "نوع الايداع";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(35, 243);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(195, 32);
            this.textBox1.TabIndex = 53;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Black;
            this.btn_save.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_save.Location = new System.Drawing.Point(101, 391);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(132, 40);
            this.btn_save.TabIndex = 52;
            this.btn_save.Text = "إضافة الايداع";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_CurrentBalance
            // 
            this.txt_CurrentBalance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CurrentBalance.Location = new System.Drawing.Point(35, 60);
            this.txt_CurrentBalance.Multiline = true;
            this.txt_CurrentBalance.Name = "txt_CurrentBalance";
            this.txt_CurrentBalance.ReadOnly = true;
            this.txt_CurrentBalance.Size = new System.Drawing.Size(195, 31);
            this.txt_CurrentBalance.TabIndex = 51;
            this.txt_CurrentBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_addbalance
            // 
            this.txt_addbalance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_addbalance.Location = new System.Drawing.Point(35, 105);
            this.txt_addbalance.Multiline = true;
            this.txt_addbalance.Name = "txt_addbalance";
            this.txt_addbalance.Size = new System.Drawing.Size(195, 28);
            this.txt_addbalance.TabIndex = 50;
            this.txt_addbalance.Text = "0";
            this.txt_addbalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_addbalance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_addbalance_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Yellow;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(236, 315);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(90, 22);
            this.label7.TabIndex = 49;
            this.label7.Text = "سبب الايداع:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Yellow;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(241, 197);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(87, 22);
            this.label6.TabIndex = 48;
            this.label6.Text = "اسم المودع:";
            // 
            // txt_reason
            // 
            this.txt_reason.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_reason.Location = new System.Drawing.Point(35, 291);
            this.txt_reason.Multiline = true;
            this.txt_reason.Name = "txt_reason";
            this.txt_reason.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_reason.Size = new System.Drawing.Size(195, 73);
            this.txt_reason.TabIndex = 47;
            this.txt_reason.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(35, 193);
            this.txt_name.Multiline = true;
            this.txt_name.Name = "txt_name";
            this.txt_name.ReadOnly = true;
            this.txt_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_name.Size = new System.Drawing.Size(195, 32);
            this.txt_name.TabIndex = 46;
            this.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Yellow;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(244, 150);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(94, 22);
            this.label4.TabIndex = 45;
            this.label4.Text = "تاريخ الايداع:";
            // 
            // Date_insert
            // 
            this.Date_insert.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_insert.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date_insert.Location = new System.Drawing.Point(35, 149);
            this.Date_insert.Name = "Date_insert";
            this.Date_insert.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Date_insert.Size = new System.Drawing.Size(195, 26);
            this.Date_insert.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(244, 109);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(128, 22);
            this.label2.TabIndex = 43;
            this.label2.Text = "اضافة رصيد جديد:";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.ForeColor = System.Drawing.Color.Red;
            this.lblMoney.Location = new System.Drawing.Point(103, 61);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(16, 13);
            this.lblMoney.TabIndex = 42;
            this.lblMoney.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Yellow;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(292, 27);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(80, 22);
            this.label5.TabIndex = 41;
            this.label5.Text = "اختر خزنة:";
            // 
            // cmb_Stock
            // 
            this.cmb_Stock.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_Stock.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Stock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Stock.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Stock.FormattingEnabled = true;
            this.cmb_Stock.Location = new System.Drawing.Point(12, 22);
            this.cmb_Stock.Name = "cmb_Stock";
            this.cmb_Stock.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_Stock.Size = new System.Drawing.Size(251, 27);
            this.cmb_Stock.TabIndex = 40;
            this.cmb_Stock.SelectedIndexChanged += new System.EventHandler(this.cmb_Stock_SelectedIndexChanged);
            this.cmb_Stock.SelectionChangeCommitted += new System.EventHandler(this.cmb_Stock_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(235, 63);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(159, 24);
            this.label3.TabIndex = 39;
            this.label3.Text = "رصيد الخزنة الحالى هو:";
            // 
            // frm_AddStockMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(403, 444);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_CurrentBalance);
            this.Controls.Add(this.txt_addbalance);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_reason);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Date_insert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_Stock);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(419, 482);
            this.MinimumSize = new System.Drawing.Size(419, 482);
            this.Name = "frm_AddStockMoney";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إيداع رصيد ف الخزنة";
            this.Load += new System.EventHandler(this.frm_AddStockMoney_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_CurrentBalance;
        private System.Windows.Forms.TextBox txt_addbalance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_reason;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker Date_insert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_Stock;
        private System.Windows.Forms.Label label3;
    }
}