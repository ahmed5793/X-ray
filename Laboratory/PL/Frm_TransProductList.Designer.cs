namespace Laboratory.PL
{
    partial class Frm_TransProductList
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Btn_selectProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 1);
            this.dataGridView1.MaximumSize = new System.Drawing.Size(694, 303);
            this.dataGridView1.MinimumSize = new System.Drawing.Size(694, 303);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(694, 303);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // Btn_selectProduct
            // 
            this.Btn_selectProduct.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_selectProduct.BackColor = System.Drawing.Color.Yellow;
            this.Btn_selectProduct.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_selectProduct.ForeColor = System.Drawing.Color.Black;
            this.Btn_selectProduct.Location = new System.Drawing.Point(301, 310);
            this.Btn_selectProduct.Name = "Btn_selectProduct";
            this.Btn_selectProduct.Size = new System.Drawing.Size(126, 42);
            this.Btn_selectProduct.TabIndex = 40;
            this.Btn_selectProduct.Text = "خروج";
            this.Btn_selectProduct.UseVisualStyleBackColor = false;
            this.Btn_selectProduct.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Btn_selectProduct_MouseClick_1);
            // 
            // Frm_TransProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(697, 362);
            this.ControlBox = false;
            this.Controls.Add(this.Btn_selectProduct);
            this.Controls.Add(this.dataGridView1);
            this.MaximumSize = new System.Drawing.Size(713, 400);
            this.MinimumSize = new System.Drawing.Size(713, 400);
            this.Name = "Frm_TransProductList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إختيار صنف";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button Btn_selectProduct;
    }
}