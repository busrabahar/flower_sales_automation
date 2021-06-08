namespace CicekSatisOtomasyonu.Formlar
{
    partial class formCicekEkle
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
            this.comboBoxCicekCesidi = new System.Windows.Forms.ComboBox();
            this.tBLCesitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cicekSatisOtomasyonDataSet2 = new CicekSatisOtomasyonu.CicekSatisOtomasyonDataSet2();
            this.textBoxFiyati = new System.Windows.Forms.TextBox();
            this.textBoxCicekAdedi = new System.Windows.Forms.TextBox();
            this.textBoxCicekStokAdedi = new System.Windows.Forms.TextBox();
            this.textBoxUrunAciklamasi = new System.Windows.Forms.TextBox();
            this.textBoxUrunKodu = new System.Windows.Forms.TextBox();
            this.labelCicekCesidi = new System.Windows.Forms.Label();
            this.labelFiyati = new System.Windows.Forms.Label();
            this.labelRenk = new System.Windows.Forms.Label();
            this.labelCicekAdedi = new System.Windows.Forms.Label();
            this.labelUrunAciklamasi = new System.Windows.Forms.Label();
            this.labelUrunKodu = new System.Windows.Forms.Label();
            this.labelCicekStokAdedi = new System.Windows.Forms.Label();
            this.butonEkle = new System.Windows.Forms.Button();
            this.butonIptal = new System.Windows.Forms.Button();
            this.butonResimSec = new System.Windows.Forms.Button();
            this.pictureBoxCicekYukle = new System.Windows.Forms.PictureBox();
            this.comboBoxRenk = new System.Windows.Forms.ComboBox();
            this.fKTBLRenkTBLCesitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBLCesitTableAdapter = new CicekSatisOtomasyonu.CicekSatisOtomasyonDataSet2TableAdapters.TBLCesitTableAdapter();
            this.tBLRenkTableAdapter = new CicekSatisOtomasyonu.CicekSatisOtomasyonDataSet2TableAdapters.TBLRenkTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tBLCesitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cicekSatisOtomasyonDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCicekYukle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTBLRenkTBLCesitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCicekCesidi
            // 
            this.comboBoxCicekCesidi.DataSource = this.tBLCesitBindingSource;
            this.comboBoxCicekCesidi.DisplayMember = "Cesit";
            this.comboBoxCicekCesidi.FormattingEnabled = true;
            this.comboBoxCicekCesidi.Location = new System.Drawing.Point(186, 50);
            this.comboBoxCicekCesidi.Name = "comboBoxCicekCesidi";
            this.comboBoxCicekCesidi.Size = new System.Drawing.Size(172, 24);
            this.comboBoxCicekCesidi.TabIndex = 0;
            // 
            // tBLCesitBindingSource
            // 
            this.tBLCesitBindingSource.DataMember = "TBLCesit";
            this.tBLCesitBindingSource.DataSource = this.cicekSatisOtomasyonDataSet2;
            // 
            // cicekSatisOtomasyonDataSet2
            // 
            this.cicekSatisOtomasyonDataSet2.DataSetName = "CicekSatisOtomasyonDataSet2";
            this.cicekSatisOtomasyonDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBoxFiyati
            // 
            this.textBoxFiyati.Location = new System.Drawing.Point(186, 140);
            this.textBoxFiyati.Name = "textBoxFiyati";
            this.textBoxFiyati.Size = new System.Drawing.Size(172, 22);
            this.textBoxFiyati.TabIndex = 2;
            // 
            // textBoxCicekAdedi
            // 
            this.textBoxCicekAdedi.Location = new System.Drawing.Point(186, 184);
            this.textBoxCicekAdedi.Name = "textBoxCicekAdedi";
            this.textBoxCicekAdedi.Size = new System.Drawing.Size(172, 22);
            this.textBoxCicekAdedi.TabIndex = 5;
            // 
            // textBoxCicekStokAdedi
            // 
            this.textBoxCicekStokAdedi.Location = new System.Drawing.Point(186, 325);
            this.textBoxCicekStokAdedi.Name = "textBoxCicekStokAdedi";
            this.textBoxCicekStokAdedi.Size = new System.Drawing.Size(172, 22);
            this.textBoxCicekStokAdedi.TabIndex = 6;
            this.textBoxCicekStokAdedi.TextChanged += new System.EventHandler(this.textBoxCicekStokAdedi_TextChanged);
            // 
            // textBoxUrunAciklamasi
            // 
            this.textBoxUrunAciklamasi.Location = new System.Drawing.Point(186, 229);
            this.textBoxUrunAciklamasi.Name = "textBoxUrunAciklamasi";
            this.textBoxUrunAciklamasi.Size = new System.Drawing.Size(172, 22);
            this.textBoxUrunAciklamasi.TabIndex = 7;
            this.textBoxUrunAciklamasi.TextChanged += new System.EventHandler(this.textBoxUrunAciklamasi_TextChanged);
            // 
            // textBoxUrunKodu
            // 
            this.textBoxUrunKodu.Location = new System.Drawing.Point(186, 277);
            this.textBoxUrunKodu.Name = "textBoxUrunKodu";
            this.textBoxUrunKodu.Size = new System.Drawing.Size(172, 22);
            this.textBoxUrunKodu.TabIndex = 8;
            this.textBoxUrunKodu.TextChanged += new System.EventHandler(this.textBoxUrunKodu_TextChanged);
            // 
            // labelCicekCesidi
            // 
            this.labelCicekCesidi.AutoSize = true;
            this.labelCicekCesidi.Font = new System.Drawing.Font("Sitka Banner", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelCicekCesidi.ForeColor = System.Drawing.Color.LightPink;
            this.labelCicekCesidi.Location = new System.Drawing.Point(12, 40);
            this.labelCicekCesidi.Name = "labelCicekCesidi";
            this.labelCicekCesidi.Size = new System.Drawing.Size(130, 35);
            this.labelCicekCesidi.TabIndex = 9;
            this.labelCicekCesidi.Text = "Çiçek Çesidi";
            this.labelCicekCesidi.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelFiyati
            // 
            this.labelFiyati.AutoSize = true;
            this.labelFiyati.Font = new System.Drawing.Font("Sitka Banner", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelFiyati.ForeColor = System.Drawing.Color.LightPink;
            this.labelFiyati.Location = new System.Drawing.Point(12, 129);
            this.labelFiyati.Name = "labelFiyati";
            this.labelFiyati.Size = new System.Drawing.Size(72, 35);
            this.labelFiyati.TabIndex = 10;
            this.labelFiyati.Text = "Fiyatı";
            // 
            // labelRenk
            // 
            this.labelRenk.AutoSize = true;
            this.labelRenk.Font = new System.Drawing.Font("Sitka Banner", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelRenk.ForeColor = System.Drawing.Color.LightPink;
            this.labelRenk.Location = new System.Drawing.Point(12, 83);
            this.labelRenk.Name = "labelRenk";
            this.labelRenk.Size = new System.Drawing.Size(65, 35);
            this.labelRenk.TabIndex = 11;
            this.labelRenk.Text = "Renk";
            // 
            // labelCicekAdedi
            // 
            this.labelCicekAdedi.AutoSize = true;
            this.labelCicekAdedi.Font = new System.Drawing.Font("Sitka Banner", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelCicekAdedi.ForeColor = System.Drawing.Color.LightPink;
            this.labelCicekAdedi.Location = new System.Drawing.Point(12, 173);
            this.labelCicekAdedi.Name = "labelCicekAdedi";
            this.labelCicekAdedi.Size = new System.Drawing.Size(126, 35);
            this.labelCicekAdedi.TabIndex = 12;
            this.labelCicekAdedi.Text = "Çiçek Adedi";
            // 
            // labelUrunAciklamasi
            // 
            this.labelUrunAciklamasi.AutoSize = true;
            this.labelUrunAciklamasi.Font = new System.Drawing.Font("Sitka Banner", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelUrunAciklamasi.ForeColor = System.Drawing.Color.LightPink;
            this.labelUrunAciklamasi.Location = new System.Drawing.Point(12, 219);
            this.labelUrunAciklamasi.Name = "labelUrunAciklamasi";
            this.labelUrunAciklamasi.Size = new System.Drawing.Size(177, 35);
            this.labelUrunAciklamasi.TabIndex = 13;
            this.labelUrunAciklamasi.Text = "Ürün Açıklaması";
            this.labelUrunAciklamasi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelUrunAciklamasi.Click += new System.EventHandler(this.labelUrunAciklamasi_Click);
            // 
            // labelUrunKodu
            // 
            this.labelUrunKodu.AutoSize = true;
            this.labelUrunKodu.Font = new System.Drawing.Font("Sitka Banner", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelUrunKodu.ForeColor = System.Drawing.Color.LightPink;
            this.labelUrunKodu.Location = new System.Drawing.Point(12, 267);
            this.labelUrunKodu.Name = "labelUrunKodu";
            this.labelUrunKodu.Size = new System.Drawing.Size(121, 35);
            this.labelUrunKodu.TabIndex = 14;
            this.labelUrunKodu.Text = "Ürün Kodu";
            this.labelUrunKodu.Click += new System.EventHandler(this.labelUrunKodu_Click);
            // 
            // labelCicekStokAdedi
            // 
            this.labelCicekStokAdedi.AutoSize = true;
            this.labelCicekStokAdedi.Font = new System.Drawing.Font("Sitka Banner", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelCicekStokAdedi.ForeColor = System.Drawing.Color.LightPink;
            this.labelCicekStokAdedi.Location = new System.Drawing.Point(12, 315);
            this.labelCicekStokAdedi.Name = "labelCicekStokAdedi";
            this.labelCicekStokAdedi.Size = new System.Drawing.Size(175, 35);
            this.labelCicekStokAdedi.TabIndex = 15;
            this.labelCicekStokAdedi.Text = "Çiçek Stok Adedi";
            this.labelCicekStokAdedi.Click += new System.EventHandler(this.labelCicekStokAdedi_Click);
            // 
            // butonEkle
            // 
            this.butonEkle.BackColor = System.Drawing.Color.Black;
            this.butonEkle.Font = new System.Drawing.Font("Sitka Banner", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.butonEkle.ForeColor = System.Drawing.Color.LightPink;
            this.butonEkle.Location = new System.Drawing.Point(90, 369);
            this.butonEkle.Name = "butonEkle";
            this.butonEkle.Size = new System.Drawing.Size(114, 48);
            this.butonEkle.TabIndex = 16;
            this.butonEkle.Text = "Ekle";
            this.butonEkle.UseVisualStyleBackColor = false;
            this.butonEkle.Click += new System.EventHandler(this.butonEkle_Click);
            // 
            // butonIptal
            // 
            this.butonIptal.BackColor = System.Drawing.Color.Black;
            this.butonIptal.Font = new System.Drawing.Font("Sitka Banner", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.butonIptal.ForeColor = System.Drawing.Color.LightPink;
            this.butonIptal.Location = new System.Drawing.Point(244, 369);
            this.butonIptal.Name = "butonIptal";
            this.butonIptal.Size = new System.Drawing.Size(114, 48);
            this.butonIptal.TabIndex = 17;
            this.butonIptal.Text = "İptal";
            this.butonIptal.UseVisualStyleBackColor = false;
            this.butonIptal.Click += new System.EventHandler(this.butonIptal_Click);
            // 
            // butonResimSec
            // 
            this.butonResimSec.BackColor = System.Drawing.Color.Black;
            this.butonResimSec.Font = new System.Drawing.Font("Sitka Banner", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.butonResimSec.ForeColor = System.Drawing.Color.LightPink;
            this.butonResimSec.Location = new System.Drawing.Point(388, 219);
            this.butonResimSec.Name = "butonResimSec";
            this.butonResimSec.Size = new System.Drawing.Size(142, 61);
            this.butonResimSec.TabIndex = 18;
            this.butonResimSec.Text = "Resim Seç";
            this.butonResimSec.UseVisualStyleBackColor = false;
            this.butonResimSec.Click += new System.EventHandler(this.butonResimSec_Click);
            // 
            // pictureBoxCicekYukle
            // 
            this.pictureBoxCicekYukle.Image = global::CicekSatisOtomasyonu.Properties.Resources.roseandcure_logo;
            this.pictureBoxCicekYukle.InitialImage = null;
            this.pictureBoxCicekYukle.Location = new System.Drawing.Point(373, 40);
            this.pictureBoxCicekYukle.Name = "pictureBoxCicekYukle";
            this.pictureBoxCicekYukle.Size = new System.Drawing.Size(174, 147);
            this.pictureBoxCicekYukle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCicekYukle.TabIndex = 4;
            this.pictureBoxCicekYukle.TabStop = false;
            // 
            // comboBoxRenk
            // 
            this.comboBoxRenk.DataSource = this.fKTBLRenkTBLCesitBindingSource;
            this.comboBoxRenk.DisplayMember = "Renk";
            this.comboBoxRenk.FormattingEnabled = true;
            this.comboBoxRenk.Location = new System.Drawing.Point(186, 93);
            this.comboBoxRenk.Name = "comboBoxRenk";
            this.comboBoxRenk.Size = new System.Drawing.Size(172, 24);
            this.comboBoxRenk.TabIndex = 19;
            this.comboBoxRenk.SelectedIndexChanged += new System.EventHandler(this.comboBoxRenk_SelectedIndexChanged);
            // 
            // fKTBLRenkTBLCesitBindingSource
            // 
            this.fKTBLRenkTBLCesitBindingSource.DataMember = "FK_TBLRenk_TBLCesit";
            this.fKTBLRenkTBLCesitBindingSource.DataSource = this.tBLCesitBindingSource;
            // 
            // tBLCesitTableAdapter
            // 
            this.tBLCesitTableAdapter.ClearBeforeFill = true;
            // 
            // tBLRenkTableAdapter
            // 
            this.tBLRenkTableAdapter.ClearBeforeFill = true;
            // 
            // formCicekEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(576, 433);
            this.Controls.Add(this.comboBoxRenk);
            this.Controls.Add(this.butonResimSec);
            this.Controls.Add(this.butonIptal);
            this.Controls.Add(this.butonEkle);
            this.Controls.Add(this.labelCicekStokAdedi);
            this.Controls.Add(this.labelUrunKodu);
            this.Controls.Add(this.labelUrunAciklamasi);
            this.Controls.Add(this.labelCicekAdedi);
            this.Controls.Add(this.labelRenk);
            this.Controls.Add(this.labelFiyati);
            this.Controls.Add(this.labelCicekCesidi);
            this.Controls.Add(this.textBoxUrunKodu);
            this.Controls.Add(this.textBoxUrunAciklamasi);
            this.Controls.Add(this.textBoxCicekStokAdedi);
            this.Controls.Add(this.textBoxCicekAdedi);
            this.Controls.Add(this.pictureBoxCicekYukle);
            this.Controls.Add(this.textBoxFiyati);
            this.Controls.Add(this.comboBoxCicekCesidi);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Name = "formCicekEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Çiçek Ekleme Sayfası";
            this.Load += new System.EventHandler(this.formCicekEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBLCesitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cicekSatisOtomasyonDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCicekYukle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTBLRenkTBLCesitBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCicekCesidi;
        private System.Windows.Forms.TextBox textBoxFiyati;
        private System.Windows.Forms.PictureBox pictureBoxCicekYukle;
        private System.Windows.Forms.TextBox textBoxCicekAdedi;
        private System.Windows.Forms.TextBox textBoxCicekStokAdedi;
        private System.Windows.Forms.TextBox textBoxUrunAciklamasi;
        private System.Windows.Forms.TextBox textBoxUrunKodu;
        private System.Windows.Forms.Label labelCicekCesidi;
        private System.Windows.Forms.Label labelFiyati;
        private System.Windows.Forms.Label labelRenk;
        private System.Windows.Forms.Label labelCicekAdedi;
        private System.Windows.Forms.Label labelUrunAciklamasi;
        private System.Windows.Forms.Label labelUrunKodu;
        private System.Windows.Forms.Label labelCicekStokAdedi;
        private System.Windows.Forms.Button butonEkle;
        private System.Windows.Forms.Button butonIptal;
        private System.Windows.Forms.Button butonResimSec;
        private System.Windows.Forms.ComboBox comboBoxRenk;
        private CicekSatisOtomasyonDataSet2 cicekSatisOtomasyonDataSet2;
        private System.Windows.Forms.BindingSource tBLCesitBindingSource;
        private CicekSatisOtomasyonDataSet2TableAdapters.TBLCesitTableAdapter tBLCesitTableAdapter;
        private System.Windows.Forms.BindingSource fKTBLRenkTBLCesitBindingSource;
        private CicekSatisOtomasyonDataSet2TableAdapters.TBLRenkTableAdapter tBLRenkTableAdapter;
    }
}