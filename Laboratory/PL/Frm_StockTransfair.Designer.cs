namespace Laboratory.PL
{
    partial class Frm_StockTransfair
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_StockTransfair));
            this.label2 = new System.Windows.Forms.Label();
            this.txt_addbalance = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Cmb_StrockTo = new System.Windows.Forms.ComboBox();
            this.txt_CurrentBalance1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_reason = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Date_insert = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_StockFrom = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_save = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(218, 132);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(159, 24);
            this.label2.TabIndex = 87;
            this.label2.Text = "رصيد الخزنة الحالى هو:";
            // 
            // txt_addbalance
            // 
            this.txt_addbalance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_addbalance.Location = new System.Drawing.Point(12, 172);
            this.txt_addbalance.Multiline = true;
            this.txt_addbalance.Name = "txt_addbalance";
            this.txt_addbalance.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_addbalance.Size = new System.Drawing.Size(195, 28);
            this.txt_addbalance.TabIndex = 86;
            this.txt_addbalance.Text = "0";
            this.txt_addbalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_addbalance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_addbalance_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(217, 176);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(130, 22);
            this.label8.TabIndex = 85;
            this.label8.Text = "المبلغ المراد تحويله";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 128);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(195, 31);
            this.textBox1.TabIndex = 84;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(251, 93);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(116, 22);
            this.label1.TabIndex = 83;
            this.label1.Text = "تحويل الى الخزنة";
            // 
            // Cmb_StrockTo
            // 
            this.Cmb_StrockTo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Cmb_StrockTo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_StrockTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_StrockTo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_StrockTo.FormattingEnabled = true;
            this.Cmb_StrockTo.Location = new System.Drawing.Point(12, 90);
            this.Cmb_StrockTo.Name = "Cmb_StrockTo";
            this.Cmb_StrockTo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Cmb_StrockTo.Size = new System.Drawing.Size(228, 27);
            this.Cmb_StrockTo.TabIndex = 82;
            this.Cmb_StrockTo.SelectedIndexChanged += new System.EventHandler(this.Cmb_StrockTo_SelectedIndexChanged);
            this.Cmb_StrockTo.SelectionChangeCommitted += new System.EventHandler(this.Cmb_StrockTo_SelectionChangeCommitted);
            // 
            // txt_CurrentBalance1
            // 
            this.txt_CurrentBalance1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CurrentBalance1.Location = new System.Drawing.Point(12, 50);
            this.txt_CurrentBalance1.Multiline = true;
            this.txt_CurrentBalance1.Name = "txt_CurrentBalance1";
            this.txt_CurrentBalance1.ReadOnly = true;
            this.txt_CurrentBalance1.Size = new System.Drawing.Size(195, 31);
            this.txt_CurrentBalance1.TabIndex = 80;
            this.txt_CurrentBalance1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(215, 336);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(97, 22);
            this.label7.TabIndex = 79;
            this.label7.Text = "سبب التحويل:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(221, 268);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(94, 22);
            this.label6.TabIndex = 78;
            this.label6.Text = "اسم الموظف:";
            // 
            // txt_reason
            // 
            this.txt_reason.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_reason.Location = new System.Drawing.Point(12, 312);
            this.txt_reason.Multiline = true;
            this.txt_reason.Name = "txt_reason";
            this.txt_reason.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_reason.Size = new System.Drawing.Size(195, 73);
            this.txt_reason.TabIndex = 77;
            this.txt_reason.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(12, 262);
            this.txt_name.Multiline = true;
            this.txt_name.Name = "txt_name";
            this.txt_name.ReadOnly = true;
            this.txt_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_name.Size = new System.Drawing.Size(195, 32);
            this.txt_name.TabIndex = 76;
            this.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(218, 220);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(101, 22);
            this.label4.TabIndex = 75;
            this.label4.Text = "تاريخ التحويل:";
            // 
            // Date_insert
            // 
            this.Date_insert.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_insert.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date_insert.Location = new System.Drawing.Point(12, 217);
            this.Date_insert.Name = "Date_insert";
            this.Date_insert.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Date_insert.Size = new System.Drawing.Size(195, 26);
            this.Date_insert.TabIndex = 74;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(256, 12);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(115, 22);
            this.label5.TabIndex = 73;
            this.label5.Text = "تحويل من الخزنة";
            // 
            // cmb_StockFrom
            // 
            this.cmb_StockFrom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_StockFrom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_StockFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_StockFrom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_StockFrom.FormattingEnabled = true;
            this.cmb_StockFrom.Location = new System.Drawing.Point(9, 12);
            this.cmb_StockFrom.Name = "cmb_StockFrom";
            this.cmb_StockFrom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_StockFrom.Size = new System.Drawing.Size(238, 27);
            this.cmb_StockFrom.TabIndex = 72;
            this.cmb_StockFrom.SelectedIndexChanged += new System.EventHandler(this.cmb_StockFrom_SelectedIndexChanged);
            this.cmb_StockFrom.SelectionChangeCommitted += new System.EventHandler(this.cmb_StockFrom_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(212, 53);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(159, 24);
            this.label3.TabIndex = 71;
            this.label3.Text = "رصيد الخزنة الحالى هو:";
            // 
            // btn_save
            // 
            this.btn_save.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Appearance.Options.UseFont = true;
            this.btn_save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btn_save.Location = new System.Drawing.Point(129, 408);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(152, 45);
            this.btn_save.TabIndex = 88;
            this.btn_save.Text = " حفظ";
            this.btn_save.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Frm_StockTransfair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(386, 474);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_addbalance);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cmb_StrockTo);
            this.Controls.Add(this.txt_CurrentBalance1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_reason);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Date_insert);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_StockFrom);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(402, 513);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(402, 513);
            this.Name = "Frm_StockTransfair";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تحويل رصيد من خزنة إلى خزنة";
            this.Load += new System.EventHandler(this.Frm_StockTransfair_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_addbalance;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cmb_StrockTo;
        private System.Windows.Forms.TextBox txt_CurrentBalance1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_reason;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker Date_insert;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_StockFrom;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btn_save;
    }
}