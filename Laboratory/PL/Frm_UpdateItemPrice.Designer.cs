namespace Laboratory.PL
{
    partial class Frm_UpdateItemPrice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_UpdateItemPrice));
            this.radio_company = new System.Windows.Forms.RadioButton();
            this.radio_pay = new System.Windows.Forms.RadioButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.radio_plas = new System.Windows.Forms.RadioButton();
            this.radio_mins = new System.Windows.Forms.RadioButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Txt_price = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // radio_company
            // 
            this.radio_company.AutoSize = true;
            this.radio_company.Font = new System.Drawing.Font("Droid Arabic Kufi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_company.Location = new System.Drawing.Point(85, 27);
            this.radio_company.Name = "radio_company";
            this.radio_company.Size = new System.Drawing.Size(96, 40);
            this.radio_company.TabIndex = 0;
            this.radio_company.Text = "شركات";
            this.radio_company.UseVisualStyleBackColor = true;
            // 
            // radio_pay
            // 
            this.radio_pay.AutoSize = true;
            this.radio_pay.Checked = true;
            this.radio_pay.Font = new System.Drawing.Font("Droid Arabic Kufi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_pay.Location = new System.Drawing.Point(258, 27);
            this.radio_pay.Name = "radio_pay";
            this.radio_pay.Size = new System.Drawing.Size(82, 40);
            this.radio_pay.TabIndex = 1;
            this.radio_pay.TabStop = true;
            this.radio_pay.Text = "نقدى";
            this.radio_pay.UseVisualStyleBackColor = true;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.radio_pay);
            this.groupControl1.Controls.Add(this.radio_company);
            this.groupControl1.Location = new System.Drawing.Point(118, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(368, 68);
            this.groupControl1.TabIndex = 8;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.Txt_price);
            this.groupControl2.Controls.Add(this.radio_plas);
            this.groupControl2.Controls.Add(this.radio_mins);
            this.groupControl2.Location = new System.Drawing.Point(12, 96);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(567, 98);
            this.groupControl2.TabIndex = 9;
            // 
            // radio_plas
            // 
            this.radio_plas.AutoSize = true;
            this.radio_plas.Checked = true;
            this.radio_plas.Font = new System.Drawing.Font("Droid Arabic Kufi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_plas.Location = new System.Drawing.Point(469, 39);
            this.radio_plas.Name = "radio_plas";
            this.radio_plas.Size = new System.Drawing.Size(79, 40);
            this.radio_plas.TabIndex = 9;
            this.radio_plas.TabStop = true;
            this.radio_plas.Text = "زيادة";
            this.radio_plas.UseVisualStyleBackColor = true;
            // 
            // radio_mins
            // 
            this.radio_mins.AutoSize = true;
            this.radio_mins.Font = new System.Drawing.Font("Droid Arabic Kufi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_mins.Location = new System.Drawing.Point(377, 39);
            this.radio_mins.Name = "radio_mins";
            this.radio_mins.Size = new System.Drawing.Size(78, 40);
            this.radio_mins.TabIndex = 8;
            this.radio_mins.Text = "نقص";
            this.radio_mins.UseVisualStyleBackColor = true;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "حفظ";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Droid Arabic Kufi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(196, 202);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(177, 63);
            this.bunifuFlatButton1.TabIndex = 7;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // Txt_price
            // 
            this.Txt_price.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_price.Location = new System.Drawing.Point(85, 44);
            this.Txt_price.Name = "Txt_price";
            this.Txt_price.Size = new System.Drawing.Size(266, 29);
            this.Txt_price.TabIndex = 10;
            this.Txt_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // Frm_UpdateItemPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(591, 271);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.bunifuFlatButton1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(607, 310);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(607, 310);
            this.Name = "Frm_UpdateItemPrice";
            this.Text = "تعديل في اسعار  كل الفحوصات";
            this.Load += new System.EventHandler(this.Frm_UpdateItemPrice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radio_company;
        private System.Windows.Forms.RadioButton radio_pay;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.RadioButton radio_plas;
        private System.Windows.Forms.RadioButton radio_mins;
        private System.Windows.Forms.TextBox Txt_price;
    }
}