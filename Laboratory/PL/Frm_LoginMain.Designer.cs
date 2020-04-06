namespace Laboratory.PL
{
    partial class Frm_LoginMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_LoginMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuThinButton1 = new WindowsFormsControlLibrary1.BunifuThinButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.simpleButton2);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Location = new System.Drawing.Point(4, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 50);
            this.panel1.TabIndex = 12003;
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(258, 6);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(37, 41);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(296, 5);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(37, 41);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Laboratory.Properties.Resources.MOFTA7;
            this.pictureBox1.Location = new System.Drawing.Point(117, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12002;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuThinButton1
            // 
            this.bunifuThinButton1.BackColor = System.Drawing.Color.Crimson;
            this.bunifuThinButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton1.BackgroundImage")));
            this.bunifuThinButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuThinButton1.ButtonText = "LOGIN";
            this.bunifuThinButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton1.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton1.ForeColorHoverState = System.Drawing.Color.Black;
            this.bunifuThinButton1.Iconimage = null;
            this.bunifuThinButton1.IconVisible = true;
            this.bunifuThinButton1.IconZoom = 90D;
            this.bunifuThinButton1.ImageIconOverlay = false;
            this.bunifuThinButton1.Location = new System.Drawing.Point(45, 433);
            this.bunifuThinButton1.Name = "bunifuThinButton1";
            this.bunifuThinButton1.Size = new System.Drawing.Size(245, 39);
            this.bunifuThinButton1.TabIndex = 12001;
            this.bunifuThinButton1.Click += new System.EventHandler(this.bunifuThinButton1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.Red;
            this.checkBox1.Location = new System.Drawing.Point(68, 353);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(203, 32);
            this.checkBox1.TabIndex = 12010;
            this.checkBox1.TabStop = false;
            this.checkBox1.Text = "SHOW PASSOWRD";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txt_Pass
            // 
            this.txt_Pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txt_Pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Pass.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pass.ForeColor = System.Drawing.Color.White;
            this.txt_Pass.Location = new System.Drawing.Point(79, 301);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Size = new System.Drawing.Size(249, 25);
            this.txt_Pass.TabIndex = 12009;
            this.txt_Pass.TabStop = false;
            this.txt_Pass.Text = "PASSWORD";
            this.txt_Pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Pass.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_Pass_MouseClick);
            this.txt_Pass.Leave += new System.EventHandler(this.txt_Pass_Leave);
            this.txt_Pass.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txt_Pass_MouseMove);
            // 
            // txt_User
            // 
            this.txt_User.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txt_User.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_User.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_User.ForeColor = System.Drawing.Color.White;
            this.txt_User.Location = new System.Drawing.Point(81, 228);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(247, 25);
            this.txt_User.TabIndex = 12008;
            this.txt_User.TabStop = false;
            this.txt_User.Text = "USER NAME";
            this.txt_User.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_User.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_User_MouseClick);
            this.txt_User.Leave += new System.EventHandler(this.txt_User_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(23, 271);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 1);
            this.panel2.TabIndex = 12007;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(23, 346);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(270, 1);
            this.panel3.TabIndex = 12006;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(21, 287);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(52, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 12005;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(23, 215);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12004;
            this.pictureBox2.TabStop = false;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Frm_LoginMain
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 505);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bunifuThinButton1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.txt_User);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_LoginMain";
            this.Text = "Frm_LoginMain";
            this.Load += new System.EventHandler(this.Frm_LoginMain_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private WindowsFormsControlLibrary1.BunifuThinButton bunifuThinButton1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.TextBox txt_User;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}