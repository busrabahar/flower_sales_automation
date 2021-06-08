namespace CicekSatisOtomasyonu.Formlar
{
    partial class formCicekSatisYonetici
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
            this.butonCikis = new System.Windows.Forms.Button();
            this.butonCicekEkle = new System.Windows.Forms.Button();
            this.butonCicekleriListele = new System.Windows.Forms.Button();
            this.butonYorumlarıGoruntule = new System.Windows.Forms.Button();
            this.butonSiparisleriGoruntule = new System.Windows.Forms.Button();
            this.butonUyeleriListele = new System.Windows.Forms.Button();
            this.butonYeniUyeEkle = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelSayfalar = new System.Windows.Forms.Panel();
            this.cicekSatisOtomasyonDataSet = new CicekSatisOtomasyonu.CicekSatisOtomasyonDataSet();
            this.kullaniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kullaniciTableAdapter = new CicekSatisOtomasyonu.CicekSatisOtomasyonDataSetTableAdapters.KullaniciTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cicekSatisOtomasyonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // butonCikis
            // 
            this.butonCikis.Font = new System.Drawing.Font("Sitka Banner", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.butonCikis.Location = new System.Drawing.Point(763, 27);
            this.butonCikis.Name = "butonCikis";
            this.butonCikis.Size = new System.Drawing.Size(103, 115);
            this.butonCikis.TabIndex = 6;
            this.butonCikis.Text = "Çıkıs";
            this.butonCikis.UseVisualStyleBackColor = true;
            this.butonCikis.Click += new System.EventHandler(this.butonCikis_Click);
            // 
            // butonCicekEkle
            // 
            this.butonCicekEkle.Font = new System.Drawing.Font("Sitka Banner", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.butonCicekEkle.Location = new System.Drawing.Point(9, 27);
            this.butonCicekEkle.Name = "butonCicekEkle";
            this.butonCicekEkle.Size = new System.Drawing.Size(81, 116);
            this.butonCicekEkle.TabIndex = 0;
            this.butonCicekEkle.Text = "Cicek Ekle";
            this.butonCicekEkle.UseVisualStyleBackColor = true;
            this.butonCicekEkle.Click += new System.EventHandler(this.butonCicekEkle_Click);
            // 
            // butonCicekleriListele
            // 
            this.butonCicekleriListele.Font = new System.Drawing.Font("Sitka Banner", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.butonCicekleriListele.Location = new System.Drawing.Point(96, 27);
            this.butonCicekleriListele.Name = "butonCicekleriListele";
            this.butonCicekleriListele.Size = new System.Drawing.Size(128, 116);
            this.butonCicekleriListele.TabIndex = 1;
            this.butonCicekleriListele.Text = "Cicekleri Listele";
            this.butonCicekleriListele.UseVisualStyleBackColor = true;
            this.butonCicekleriListele.Click += new System.EventHandler(this.butonCicekleriListele_Click);
            // 
            // butonYorumlarıGoruntule
            // 
            this.butonYorumlarıGoruntule.Font = new System.Drawing.Font("Sitka Banner", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.butonYorumlarıGoruntule.Location = new System.Drawing.Point(230, 27);
            this.butonYorumlarıGoruntule.Name = "butonYorumlarıGoruntule";
            this.butonYorumlarıGoruntule.Size = new System.Drawing.Size(144, 116);
            this.butonYorumlarıGoruntule.TabIndex = 2;
            this.butonYorumlarıGoruntule.Text = "Yorumları Görüntüle";
            this.butonYorumlarıGoruntule.UseVisualStyleBackColor = true;
            // 
            // butonSiparisleriGoruntule
            // 
            this.butonSiparisleriGoruntule.Font = new System.Drawing.Font("Sitka Banner", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.butonSiparisleriGoruntule.Location = new System.Drawing.Point(380, 27);
            this.butonSiparisleriGoruntule.Name = "butonSiparisleriGoruntule";
            this.butonSiparisleriGoruntule.Size = new System.Drawing.Size(147, 116);
            this.butonSiparisleriGoruntule.TabIndex = 3;
            this.butonSiparisleriGoruntule.Text = "Siparisleri Görüntüle";
            this.butonSiparisleriGoruntule.UseVisualStyleBackColor = true;
            // 
            // butonUyeleriListele
            // 
            this.butonUyeleriListele.Font = new System.Drawing.Font("Sitka Banner", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.butonUyeleriListele.Location = new System.Drawing.Point(533, 27);
            this.butonUyeleriListele.Name = "butonUyeleriListele";
            this.butonUyeleriListele.Size = new System.Drawing.Size(109, 116);
            this.butonUyeleriListele.TabIndex = 4;
            this.butonUyeleriListele.Text = " Üyeleri Listele";
            this.butonUyeleriListele.UseVisualStyleBackColor = true;
            this.butonUyeleriListele.Click += new System.EventHandler(this.butonUyeleriListele_Click);
            // 
            // butonYeniUyeEkle
            // 
            this.butonYeniUyeEkle.Font = new System.Drawing.Font("Sitka Banner", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.butonYeniUyeEkle.Location = new System.Drawing.Point(648, 27);
            this.butonYeniUyeEkle.Name = "butonYeniUyeEkle";
            this.butonYeniUyeEkle.Size = new System.Drawing.Size(109, 116);
            this.butonYeniUyeEkle.TabIndex = 5;
            this.butonYeniUyeEkle.Text = "Yeni Üye Ekle";
            this.butonYeniUyeEkle.UseVisualStyleBackColor = true;
            this.butonYeniUyeEkle.Click += new System.EventHandler(this.butonYeniUyeEkle_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.butonCikis);
            this.panel1.Controls.Add(this.butonYeniUyeEkle);
            this.panel1.Controls.Add(this.butonUyeleriListele);
            this.panel1.Controls.Add(this.butonSiparisleriGoruntule);
            this.panel1.Controls.Add(this.butonYorumlarıGoruntule);
            this.panel1.Controls.Add(this.butonCicekleriListele);
            this.panel1.Controls.Add(this.butonCicekEkle);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(940, 158);
            this.panel1.TabIndex = 9;
            // 
            // panelSayfalar
            // 
            this.panelSayfalar.Location = new System.Drawing.Point(3, 166);
            this.panelSayfalar.Name = "panelSayfalar";
            this.panelSayfalar.Size = new System.Drawing.Size(940, 426);
            this.panelSayfalar.TabIndex = 10;
            // 
            // cicekSatisOtomasyonDataSet
            // 
            this.cicekSatisOtomasyonDataSet.DataSetName = "CicekSatisOtomasyonDataSet";
            this.cicekSatisOtomasyonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kullaniciBindingSource
            // 
            this.kullaniciBindingSource.DataMember = "Kullanici";
            this.kullaniciBindingSource.DataSource = this.cicekSatisOtomasyonDataSet;
            // 
            // kullaniciTableAdapter
            // 
            this.kullaniciTableAdapter.ClearBeforeFill = true;
            // 
            // formCicekSatisYonetici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(884, 595);
            this.Controls.Add(this.panelSayfalar);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "formCicekSatisYonetici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Çiçek Satış(yönetici)";
            this.Load += new System.EventHandler(this.formCicekSatisYonetici_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cicekSatisOtomasyonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button butonCikis;
        private System.Windows.Forms.Button butonCicekEkle;
        private System.Windows.Forms.Button butonCicekleriListele;
        private System.Windows.Forms.Button butonYorumlarıGoruntule;
        private System.Windows.Forms.Button butonSiparisleriGoruntule;
        private System.Windows.Forms.Button butonUyeleriListele;
        private System.Windows.Forms.Button butonYeniUyeEkle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelSayfalar;
        private CicekSatisOtomasyonDataSet cicekSatisOtomasyonDataSet;
        private System.Windows.Forms.BindingSource kullaniciBindingSource;
        private CicekSatisOtomasyonDataSetTableAdapters.KullaniciTableAdapter kullaniciTableAdapter;
    }
}