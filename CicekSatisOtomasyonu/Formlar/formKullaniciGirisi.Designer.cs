namespace CicekSatisOtomasyonu
{
    partial class formKullaniciGirisi
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
            this.labelKullaniciAdi = new System.Windows.Forms.Label();
            this.labelSifre = new System.Windows.Forms.Label();
            this.textBoxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.butonGiris = new System.Windows.Forms.Button();
            this.butonIptal = new System.Windows.Forms.Button();
            this.checkBoxSifreGoster = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelKullaniciAdi
            // 
            this.labelKullaniciAdi.AutoSize = true;
            this.labelKullaniciAdi.Font = new System.Drawing.Font("Sitka Banner", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKullaniciAdi.ForeColor = System.Drawing.Color.LightPink;
            this.labelKullaniciAdi.Location = new System.Drawing.Point(222, 60);
            this.labelKullaniciAdi.Name = "labelKullaniciAdi";
            this.labelKullaniciAdi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelKullaniciAdi.Size = new System.Drawing.Size(155, 39);
            this.labelKullaniciAdi.TabIndex = 0;
            this.labelKullaniciAdi.Text = "Kullanıcı Adı";
            this.labelKullaniciAdi.Click += new System.EventHandler(this.labelKullaniciAdi_Click);
            // 
            // labelSifre
            // 
            this.labelSifre.AutoSize = true;
            this.labelSifre.Font = new System.Drawing.Font("Sitka Banner", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSifre.ForeColor = System.Drawing.Color.LightPink;
            this.labelSifre.Location = new System.Drawing.Point(222, 136);
            this.labelSifre.Name = "labelSifre";
            this.labelSifre.Size = new System.Drawing.Size(68, 39);
            this.labelSifre.TabIndex = 1;
            this.labelSifre.Text = "Sifre";
            this.labelSifre.Click += new System.EventHandler(this.labelSifre_Click);
            // 
            // textBoxKullaniciAdi
            // 
            this.textBoxKullaniciAdi.Location = new System.Drawing.Point(402, 71);
            this.textBoxKullaniciAdi.Name = "textBoxKullaniciAdi";
            this.textBoxKullaniciAdi.Size = new System.Drawing.Size(158, 22);
            this.textBoxKullaniciAdi.TabIndex = 2;
            this.textBoxKullaniciAdi.TextChanged += new System.EventHandler(this.textBoxKullaniciAdi_TextChanged);
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.Location = new System.Drawing.Point(402, 144);
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.Size = new System.Drawing.Size(158, 22);
            this.textBoxSifre.TabIndex = 3;
            this.textBoxSifre.TextChanged += new System.EventHandler(this.textBoxSifre_TextChanged);
            // 
            // butonGiris
            // 
            this.butonGiris.BackColor = System.Drawing.SystemColors.Desktop;
            this.butonGiris.Font = new System.Drawing.Font("Sitka Banner", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.butonGiris.ForeColor = System.Drawing.Color.LightPink;
            this.butonGiris.Location = new System.Drawing.Point(263, 242);
            this.butonGiris.Name = "butonGiris";
            this.butonGiris.Size = new System.Drawing.Size(135, 68);
            this.butonGiris.TabIndex = 4;
            this.butonGiris.Text = "Giris";
            this.butonGiris.UseVisualStyleBackColor = false;
            this.butonGiris.Click += new System.EventHandler(this.butonGiris_Click);
            // 
            // butonIptal
            // 
            this.butonIptal.BackColor = System.Drawing.SystemColors.Desktop;
            this.butonIptal.Font = new System.Drawing.Font("Sitka Banner", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.butonIptal.ForeColor = System.Drawing.Color.LightPink;
            this.butonIptal.Location = new System.Drawing.Point(474, 242);
            this.butonIptal.Name = "butonIptal";
            this.butonIptal.Size = new System.Drawing.Size(122, 68);
            this.butonIptal.TabIndex = 5;
            this.butonIptal.Text = "Iptal";
            this.butonIptal.UseVisualStyleBackColor = false;
            this.butonIptal.Click += new System.EventHandler(this.butonIptal_Click);
            // 
            // checkBoxSifreGoster
            // 
            this.checkBoxSifreGoster.AutoSize = true;
            this.checkBoxSifreGoster.Font = new System.Drawing.Font("Sitka Banner", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.checkBoxSifreGoster.ForeColor = System.Drawing.Color.LightPink;
            this.checkBoxSifreGoster.Location = new System.Drawing.Point(582, 136);
            this.checkBoxSifreGoster.Name = "checkBoxSifreGoster";
            this.checkBoxSifreGoster.Size = new System.Drawing.Size(99, 37);
            this.checkBoxSifreGoster.TabIndex = 6;
            this.checkBoxSifreGoster.Text = "Göster";
            this.checkBoxSifreGoster.UseVisualStyleBackColor = true;
            this.checkBoxSifreGoster.CheckedChanged += new System.EventHandler(this.checkBoxSifreGoster_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CicekSatisOtomasyonu.Properties.Resources.team;
            this.pictureBox1.Location = new System.Drawing.Point(22, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 243);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // formKullaniciGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(692, 398);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBoxSifreGoster);
            this.Controls.Add(this.butonIptal);
            this.Controls.Add(this.butonGiris);
            this.Controls.Add(this.textBoxSifre);
            this.Controls.Add(this.textBoxKullaniciAdi);
            this.Controls.Add(this.labelSifre);
            this.Controls.Add(this.labelKullaniciAdi);
            this.Name = "formKullaniciGirisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Girişi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKullaniciAdi;
        private System.Windows.Forms.Label labelSifre;
        private System.Windows.Forms.TextBox textBoxKullaniciAdi;
        private System.Windows.Forms.TextBox textBoxSifre;
        private System.Windows.Forms.Button butonGiris;
        private System.Windows.Forms.Button butonIptal;
        private System.Windows.Forms.CheckBox checkBoxSifreGoster;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}