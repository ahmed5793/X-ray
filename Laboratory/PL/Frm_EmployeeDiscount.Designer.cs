﻿namespace Laboratory.PL
{
    partial class Frm_EmployeeDiscount
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
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_Money = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_reason = new System.Windows.Forms.TextBox();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Date_insert = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_Employee = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Black;
            this.btn_save.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(197, 227);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(132, 40);
            this.btn_save.TabIndex = 74;
            this.btn_save.Text = "حفظ";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_Money
            // 
            this.txt_Money.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Money.Location = new System.Drawing.Point(26, 104);
            this.txt_Money.Multiline = true;
            this.txt_Money.Name = "txt_Money";
            this.txt_Money.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Money.Size = new System.Drawing.Size(99, 28);
            this.txt_Money.TabIndex = 71;
            this.txt_Money.Text = "0";
            this.txt_Money.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Money.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Money_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Yellow;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(448, 176);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(91, 22);
            this.label7.TabIndex = 82;
            this.label7.Text = "سبب الخصم:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Yellow;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(321, 9);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(95, 22);
            this.label6.TabIndex = 81;
            this.label6.Text = "اسم المستخدم";
            // 
            // txt_reason
            // 
            this.txt_reason.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_reason.Location = new System.Drawing.Point(26, 148);
            this.txt_reason.Multiline = true;
            this.txt_reason.Name = "txt_reason";
            this.txt_reason.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_reason.Size = new System.Drawing.Size(409, 73);
            this.txt_reason.TabIndex = 73;
            this.txt_reason.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_UserName
            // 
            this.txt_UserName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UserName.Location = new System.Drawing.Point(120, 6);
            this.txt_UserName.Multiline = true;
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.ReadOnly = true;
            this.txt_UserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_UserName.Size = new System.Drawing.Size(195, 32);
            this.txt_UserName.TabIndex = 72;
            this.txt_UserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Yellow;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(441, 113);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(100, 22);
            this.label4.TabIndex = 80;
            this.label4.Text = "تاريخ الخصم :";
            // 
            // Date_insert
            // 
            this.Date_insert.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_insert.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date_insert.Location = new System.Drawing.Point(325, 110);
            this.Date_insert.Name = "Date_insert";
            this.Date_insert.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Date_insert.ShowUpDown = true;
            this.Date_insert.Size = new System.Drawing.Size(110, 26);
            this.Date_insert.TabIndex = 79;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(158, 110);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(93, 22);
            this.label2.TabIndex = 78;
            this.label2.Text = "مبلغ الخصم :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Yellow;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(441, 65);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(87, 22);
            this.label5.TabIndex = 76;
            this.label5.Text = "اسم الموظف";
            // 
            // cmb_Employee
            // 
            this.cmb_Employee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_Employee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Employee.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Employee.FormattingEnabled = true;
            this.cmb_Employee.Location = new System.Drawing.Point(93, 60);
            this.cmb_Employee.Name = "cmb_Employee";
            this.cmb_Employee.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_Employee.Size = new System.Drawing.Size(306, 27);
            this.cmb_Employee.TabIndex = 70;
            this.cmb_Employee.Leave += new System.EventHandler(this.cmb_Employee_Leave);
            // 
            // Frm_EmployeeDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(566, 279);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_Money);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_reason);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Date_insert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_Employee);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Name = "Frm_EmployeeDiscount";
            this.Text = "شاشه خصومات الموظفين";
            this.Load += new System.EventHandler(this.Frm_EmployeeDiscount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_Money;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_reason;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker Date_insert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_Employee;
    }
}