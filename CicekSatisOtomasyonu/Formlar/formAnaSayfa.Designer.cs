namespace CicekSatisOtomasyonu
{
    partial class formAnaSayfa
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
            this.butonKayitOl = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.butonUyeOl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.LightPink;
            this.label1.Location = new System.Drawing.Point(199, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "RosesDeBus";
            // 
            // butonKayitOl
            // 
            this.butonKayitOl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.butonKayitOl.Font = new System.Drawing.Font("Sitka Banner", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.butonKayitOl.ForeColor = System.Drawing.Color.LightPink;
            this.butonKayitOl.Location = new System.Drawing.Point(355, 129);
            this.butonKayitOl.Name = "butonKayitOl";
            this.butonKayitOl.Size = new System.Drawing.Size(181, 99);
            this.butonKayitOl.TabIndex = 1;
            this.butonKayitOl.Text = "Kayıt Ol!";
            this.butonKayitOl.UseVisualStyleBackColor = false;
            this.butonKayitOl.Click += new System.EventHandler(this.butonKayitOl_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::CicekSatisOtomasyonu.Properties.Resources.roseandcure_logo;
            this.pictureBox1.InitialImage = global::CicekSatisOtomasyonu.Properties.Resources.roseandcure_logo;
            this.pictureBox1.Location = new System.Drawing.Point(540, 292);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // butonUyeOl
            // 
            this.butonUyeOl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.butonUyeOl.Font = new System.Drawing.Font("Sitka Banner", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.butonUyeOl.ForeColor = System.Drawing.Color.LightPink;
            this.butonUyeOl.Location = new System.Drawing.Point(50, 129);
            this.butonUyeOl.Name = "butonUyeOl";
            this.butonUyeOl.Size = new System.Drawing.Size(186, 99);
            this.butonUyeOl.TabIndex = 3;
            this.butonUyeOl.Text = "Üye Girisi";
            this.butonUyeOl.UseVisualStyleBackColor = false;
            this.butonUyeOl.Click += new System.EventHandler(this.butonUyeOl_Click);
            // 
            // formAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(621, 353);
            this.Controls.Add(this.butonUyeOl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.butonKayitOl);
            this.Controls.Add(this.label1);
            this.Name = "formAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Çiçek Satış Otomasyonu Ana Sayfa";
            this.Load += new System.EventHandler(this.formAnaSayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butonKayitOl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button butonUyeOl;
    }
}

