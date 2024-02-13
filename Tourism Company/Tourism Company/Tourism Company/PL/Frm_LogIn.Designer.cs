namespace Tourism_Company.PL
{
    partial class Frm_LogIn
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
            this.lableTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Pass = new System.Windows.Forms.TextBox();
            this.Txt_name = new System.Windows.Forms.TextBox();
            this.Btn_ok = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lableTime
            // 
            this.lableTime.AutoSize = true;
            this.lableTime.BackColor = System.Drawing.Color.DarkBlue;
            this.lableTime.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableTime.ForeColor = System.Drawing.Color.White;
            this.lableTime.Location = new System.Drawing.Point(170, -50);
            this.lableTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lableTime.Name = "lableTime";
            this.lableTime.Size = new System.Drawing.Size(0, 34);
            this.lableTime.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkBlue;
            this.label2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "الرقم السري :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkBlue;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "اسم المستخدم :";
            // 
            // Txt_Pass
            // 
            this.Txt_Pass.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Pass.Location = new System.Drawing.Point(174, 143);
            this.Txt_Pass.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Txt_Pass.Name = "Txt_Pass";
            this.Txt_Pass.PasswordChar = '*';
            this.Txt_Pass.Size = new System.Drawing.Size(251, 39);
            this.Txt_Pass.TabIndex = 7;
            this.Txt_Pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Txt_name
            // 
            this.Txt_name.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_name.Location = new System.Drawing.Point(174, 51);
            this.Txt_name.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Txt_name.Name = "Txt_name";
            this.Txt_name.Size = new System.Drawing.Size(251, 39);
            this.Txt_name.TabIndex = 6;
            this.Txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Btn_ok
            // 
            this.Btn_ok.BackColor = System.Drawing.Color.DarkBlue;
            this.Btn_ok.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ok.ForeColor = System.Drawing.Color.White;
            this.Btn_ok.Location = new System.Drawing.Point(174, 209);
            this.Btn_ok.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_ok.Name = "Btn_ok";
            this.Btn_ok.Size = new System.Drawing.Size(143, 64);
            this.Btn_ok.TabIndex = 8;
            this.Btn_ok.Text = "دخول";
            this.Btn_ok.UseVisualStyleBackColor = false;
            this.Btn_ok.Click += new System.EventHandler(this.Btn_ok_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Tourism_Company.Properties.Resources._2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(432, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 267);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(689, 282);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lableTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_Pass);
            this.Controls.Add(this.Txt_name);
            this.Controls.Add(this.Btn_ok);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(588, 321);
            this.Name = "Frm_LogIn";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تسجيل الدخول";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lableTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Pass;
        private System.Windows.Forms.TextBox Txt_name;
        private System.Windows.Forms.Button Btn_ok;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}