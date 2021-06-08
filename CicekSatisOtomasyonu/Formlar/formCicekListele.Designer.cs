namespace CicekSatisOtomasyonu.Formlar
{
    partial class formCicekListele
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.butonMarkaModelGuncelle = new System.Windows.Forms.Button();
            this.labelYeniModel = new System.Windows.Forms.Label();
            this.labelYeniMarka = new System.Windows.Forms.Label();
            this.butonSil = new System.Windows.Forms.Button();
            this.butonResimSec = new System.Windows.Forms.Button();
            this.butonIptal = new System.Windows.Forms.Button();
            this.butonGuncelle = new System.Windows.Forms.Button();
            this.labelCicekStokAdedi = new System.Windows.Forms.Label();
            this.labelUrunKodu = new System.Windows.Forms.Label();
            this.labelUrunAciklamasi = new System.Windows.Forms.Label();
            this.textBoxUrunKodu = new System.Windows.Forms.TextBox();
            this.textBoxUrunAciklamasi = new System.Windows.Forms.TextBox();
            this.textBoxCicekStokAdedi = new System.Windows.Forms.TextBox();
            this.comboBoxRenk = new System.Windows.Forms.ComboBox();
            this.tBLRenkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cicekSatisOtomasyonDataSet2 = new CicekSatisOtomasyonu.CicekSatisOtomasyonDataSet2();
            this.labelCicekCesidi = new System.Windows.Forms.Label();
            this.labelCicekAdedi = new System.Windows.Forms.Label();
            this.comboBoxCicekCesidi = new System.Windows.Forms.ComboBox();
            this.tBLCesitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelRenk = new System.Windows.Forms.Label();
            this.textBoxFiyati = new System.Windows.Forms.TextBox();
            this.labelFiyati = new System.Windows.Forms.Label();
            this.pictureBoxCicekYukle = new System.Windows.Forms.PictureBox();
            this.textBoxCicekAdedi = new System.Windows.Forms.TextBox();
            this.tBLCesitTableAdapter = new CicekSatisOtomasyonu.CicekSatisOtomasyonDataSet2TableAdapters.TBLCesitTableAdapter();
            this.tBLRenkTableAdapter = new CicekSatisOtomasyonu.CicekSatisOtomasyonDataSet2TableAdapters.TBLRenkTableAdapter();
            this.textBoxId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBLRenkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cicekSatisOtomasyonDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLCesitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCicekYukle)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1176, 247);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBoxId);
            this.panel1.Controls.Add(this.butonMarkaModelGuncelle);
            this.panel1.Controls.Add(this.labelYeniModel);
            this.panel1.Controls.Add(this.labelYeniMarka);
            this.panel1.Controls.Add(this.butonSil);
            this.panel1.Controls.Add(this.butonResimSec);
            this.panel1.Controls.Add(this.butonIptal);
            this.panel1.Controls.Add(this.butonGuncelle);
            this.panel1.Controls.Add(this.labelCicekStokAdedi);
            this.panel1.Controls.Add(this.labelUrunKodu);
            this.panel1.Controls.Add(this.labelUrunAciklamasi);
            this.panel1.Controls.Add(this.textBoxUrunKodu);
            this.panel1.Controls.Add(this.textBoxUrunAciklamasi);
            this.panel1.Controls.Add(this.textBoxCicekStokAdedi);
            this.panel1.Controls.Add(this.comboBoxRenk);
            this.panel1.Controls.Add(this.labelCicekCesidi);
            this.panel1.Controls.Add(this.labelCicekAdedi);
            this.panel1.Controls.Add(this.comboBoxCicekCesidi);
            this.panel1.Controls.Add(this.labelRenk);
            this.panel1.Controls.Add(this.textBoxFiyati);
            this.panel1.Controls.Add(this.labelFiyati);
            this.panel1.Controls.Add(this.pictureBoxCicekYukle);
            this.panel1.Controls.Add(this.textBoxCicekAdedi);
            this.panel1.Location = new System.Drawing.Point(1, 151);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1176, 417);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // butonMarkaModelGuncelle
            // 
            this.butonMarkaModelGuncelle.BackColor = System.Drawing.Color.Black;
            this.butonMarkaModelGuncelle.Font = new System.Drawing.Font("Sitka Banner", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.butonMarkaModelGuncelle.ForeColor = System.Drawing.Color.LightPink;
            this.butonMarkaModelGuncelle.Location = new System.Drawing.Point(817, 9);
            this.butonMarkaModelGuncelle.Name = "butonMarkaModelGuncelle";
            this.butonMarkaModelGuncelle.Size = new System.Drawing.Size(91, 102);
            this.butonMarkaModelGuncelle.TabIndex = 60;
            this.butonMarkaModelGuncelle.Text = "Marka Model Güncelle";
            this.butonMarkaModelGuncelle.UseVisualStyleBackColor = false;
            this.butonMarkaModelGuncelle.Click += new System.EventHandler(this.butonMarkaModelGuncelle_Click);
            // 
            // labelYeniModel
            // 
            this.labelYeniModel.AutoSize = true;
            this.labelYeniModel.Font = new System.Drawing.Font("Sitka Banner", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelYeniModel.ForeColor = System.Drawing.Color.LightPink;
            this.labelYeniModel.Location = new System.Drawing.Point(709, 48);
            this.labelYeniModel.Name = "labelYeniModel";
            this.labelYeniModel.Size = new System.Drawing.Size(102, 29);
            this.labelYeniModel.TabIndex = 59;
            this.labelYeniModel.Text = "Yeni Model";
            // 
            // labelYeniMarka
            // 
            this.labelYeniMarka.AutoSize = true;
            this.labelYeniMarka.Font = new System.Drawing.Font("Sitka Banner", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelYeniMarka.ForeColor = System.Drawing.Color.LightPink;
            this.labelYeniMarka.Location = new System.Drawing.Point(704, 10);
            this.labelYeniMarka.Name = "labelYeniMarka";
            this.labelYeniMarka.Size = new System.Drawing.Size(107, 29);
            this.labelYeniMarka.TabIndex = 58;
            this.labelYeniMarka.Text = "Yeni Marka";
            // 
            // butonSil
            // 
            this.butonSil.BackColor = System.Drawing.Color.Black;
            this.butonSil.Font = new System.Drawing.Font("Sitka Banner", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.butonSil.ForeColor = System.Drawing.Color.LightPink;
            this.butonSil.Location = new System.Drawing.Point(365, 130);
            this.butonSil.Name = "butonSil";
            this.butonSil.Size = new System.Drawing.Size(86, 38);
            this.butonSil.TabIndex = 57;
            this.butonSil.Text = "Sil";
            this.butonSil.UseVisualStyleBackColor = false;
            this.butonSil.Click += new System.EventHandler(this.butonSil_Click);
            // 
            // butonResimSec
            // 
            this.butonResimSec.BackColor = System.Drawing.Color.Black;
            this.butonResimSec.Font = new System.Drawing.Font("Sitka Banner", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.butonResimSec.ForeColor = System.Drawing.Color.LightPink;
            this.butonResimSec.Location = new System.Drawing.Point(558, 125);
            this.butonResimSec.Name = "butonResimSec";
            this.butonResimSec.Size = new System.Drawing.Size(107, 38);
            this.butonResimSec.TabIndex = 56;
            this.butonResimSec.Text = "Resim Seç";
            this.butonResimSec.UseVisualStyleBackColor = false;
            this.butonResimSec.Click += new System.EventHandler(this.butonResimSec_Click);
            // 
            // butonIptal
            // 
            this.butonIptal.BackColor = System.Drawing.Color.Black;
            this.butonIptal.Font = new System.Drawing.Font("Sitka Banner", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.butonIptal.ForeColor = System.Drawing.Color.LightPink;
            this.butonIptal.Location = new System.Drawing.Point(457, 130);
            this.butonIptal.Name = "butonIptal";
            this.butonIptal.Size = new System.Drawing.Size(88, 38);
            this.butonIptal.TabIndex = 55;
            this.butonIptal.Text = "İptal";
            this.butonIptal.UseVisualStyleBackColor = false;
            this.butonIptal.Click += new System.EventHandler(this.butonIptal_Click);
            // 
            // butonGuncelle
            // 
            this.butonGuncelle.BackColor = System.Drawing.Color.Black;
            this.butonGuncelle.Font = new System.Drawing.Font("Sitka Banner", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.butonGuncelle.ForeColor = System.Drawing.Color.LightPink;
            this.butonGuncelle.Location = new System.Drawing.Point(268, 130);
            this.butonGuncelle.Name = "butonGuncelle";
            this.butonGuncelle.Size = new System.Drawing.Size(91, 38);
            this.butonGuncelle.TabIndex = 54;
            this.butonGuncelle.Text = "Güncelle";
            this.butonGuncelle.UseVisualStyleBackColor = false;
            this.butonGuncelle.Click += new System.EventHandler(this.butonGuncelle_Click);
            // 
            // labelCicekStokAdedi
            // 
            this.labelCicekStokAdedi.AutoSize = true;
            this.labelCicekStokAdedi.Font = new System.Drawing.Font("Sitka Banner", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelCicekStokAdedi.ForeColor = System.Drawing.Color.LightPink;
            this.labelCicekStokAdedi.Location = new System.Drawing.Point(243, 91);
            this.labelCicekStokAdedi.Name = "labelCicekStokAdedi";
            this.labelCicekStokAdedi.Size = new System.Drawing.Size(138, 28);
            this.labelCicekStokAdedi.TabIndex = 53;
            this.labelCicekStokAdedi.Text = "Çiçek Stok Adedi";
            // 
            // labelUrunKodu
            // 
            this.labelUrunKodu.AutoSize = true;
            this.labelUrunKodu.Font = new System.Drawing.Font("Sitka Banner", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelUrunKodu.ForeColor = System.Drawing.Color.LightPink;
            this.labelUrunKodu.Location = new System.Drawing.Point(243, 49);
            this.labelUrunKodu.Name = "labelUrunKodu";
            this.labelUrunKodu.Size = new System.Drawing.Size(96, 28);
            this.labelUrunKodu.TabIndex = 52;
            this.labelUrunKodu.Text = "Ürün Kodu";
            // 
            // labelUrunAciklamasi
            // 
            this.labelUrunAciklamasi.AutoSize = true;
            this.labelUrunAciklamasi.Font = new System.Drawing.Font("Sitka Banner", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelUrunAciklamasi.ForeColor = System.Drawing.Color.LightPink;
            this.labelUrunAciklamasi.Location = new System.Drawing.Point(243, 12);
            this.labelUrunAciklamasi.Name = "labelUrunAciklamasi";
            this.labelUrunAciklamasi.Size = new System.Drawing.Size(139, 28);
            this.labelUrunAciklamasi.TabIndex = 51;
            this.labelUrunAciklamasi.Text = "Ürün Açıklaması";
            this.labelUrunAciklamasi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxUrunKodu
            // 
            this.textBoxUrunKodu.Location = new System.Drawing.Point(388, 55);
            this.textBoxUrunKodu.Name = "textBoxUrunKodu";
            this.textBoxUrunKodu.Size = new System.Drawing.Size(139, 22);
            this.textBoxUrunKodu.TabIndex = 50;
            // 
            // textBoxUrunAciklamasi
            // 
            this.textBoxUrunAciklamasi.Location = new System.Drawing.Point(388, 18);
            this.textBoxUrunAciklamasi.Name = "textBoxUrunAciklamasi";
            this.textBoxUrunAciklamasi.Size = new System.Drawing.Size(139, 22);
            this.textBoxUrunAciklamasi.TabIndex = 49;
            // 
            // textBoxCicekStokAdedi
            // 
            this.textBoxCicekStokAdedi.Location = new System.Drawing.Point(387, 97);
            this.textBoxCicekStokAdedi.Name = "textBoxCicekStokAdedi";
            this.textBoxCicekStokAdedi.Size = new System.Drawing.Size(140, 22);
            this.textBoxCicekStokAdedi.TabIndex = 48;
            // 
            // comboBoxRenk
            // 
            this.comboBoxRenk.DataSource = this.tBLRenkBindingSource;
            this.comboBoxRenk.DisplayMember = "Renk";
            this.comboBoxRenk.FormattingEnabled = true;
            this.comboBoxRenk.Location = new System.Drawing.Point(110, 55);
            this.comboBoxRenk.Name = "comboBoxRenk";
            this.comboBoxRenk.Size = new System.Drawing.Size(127, 24);
            this.comboBoxRenk.TabIndex = 47;
            // 
            // tBLRenkBindingSource
            // 
            this.tBLRenkBindingSource.DataMember = "TBLRenk";
            this.tBLRenkBindingSource.DataSource = this.cicekSatisOtomasyonDataSet2;
            // 
            // cicekSatisOtomasyonDataSet2
            // 
            this.cicekSatisOtomasyonDataSet2.DataSetName = "CicekSatisOtomasyonDataSet2";
            this.cicekSatisOtomasyonDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelCicekCesidi
            // 
            this.labelCicekCesidi.AutoSize = true;
            this.labelCicekCesidi.Font = new System.Drawing.Font("Sitka Banner", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelCicekCesidi.ForeColor = System.Drawing.Color.LightPink;
            this.labelCicekCesidi.Location = new System.Drawing.Point(3, 9);
            this.labelCicekCesidi.Name = "labelCicekCesidi";
            this.labelCicekCesidi.Size = new System.Drawing.Size(101, 28);
            this.labelCicekCesidi.TabIndex = 43;
            this.labelCicekCesidi.Text = "Çiçek Çesidi";
            // 
            // labelCicekAdedi
            // 
            this.labelCicekAdedi.AutoSize = true;
            this.labelCicekAdedi.Font = new System.Drawing.Font("Sitka Banner", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelCicekAdedi.ForeColor = System.Drawing.Color.LightPink;
            this.labelCicekAdedi.Location = new System.Drawing.Point(7, 141);
            this.labelCicekAdedi.Name = "labelCicekAdedi";
            this.labelCicekAdedi.Size = new System.Drawing.Size(99, 28);
            this.labelCicekAdedi.TabIndex = 46;
            this.labelCicekAdedi.Text = "Çiçek Adedi";
            // 
            // comboBoxCicekCesidi
            // 
            this.comboBoxCicekCesidi.DataSource = this.tBLCesitBindingSource;
            this.comboBoxCicekCesidi.DisplayMember = "Cesit";
            this.comboBoxCicekCesidi.FormattingEnabled = true;
            this.comboBoxCicekCesidi.Location = new System.Drawing.Point(110, 16);
            this.comboBoxCicekCesidi.Name = "comboBoxCicekCesidi";
            this.comboBoxCicekCesidi.Size = new System.Drawing.Size(127, 24);
            this.comboBoxCicekCesidi.TabIndex = 39;
            // 
            // tBLCesitBindingSource
            // 
            this.tBLCesitBindingSource.DataMember = "TBLCesit";
            this.tBLCesitBindingSource.DataSource = this.cicekSatisOtomasyonDataSet2;
            // 
            // labelRenk
            // 
            this.labelRenk.AutoSize = true;
            this.labelRenk.Font = new System.Drawing.Font("Sitka Banner", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelRenk.ForeColor = System.Drawing.Color.LightPink;
            this.labelRenk.Location = new System.Drawing.Point(7, 51);
            this.labelRenk.Name = "labelRenk";
            this.labelRenk.Size = new System.Drawing.Size(51, 28);
            this.labelRenk.TabIndex = 45;
            this.labelRenk.Text = "Renk";
            // 
            // textBoxFiyati
            // 
            this.textBoxFiyati.Location = new System.Drawing.Point(110, 97);
            this.textBoxFiyati.Name = "textBoxFiyati";
            this.textBoxFiyati.Size = new System.Drawing.Size(127, 22);
            this.textBoxFiyati.TabIndex = 40;
            // 
            // labelFiyati
            // 
            this.labelFiyati.AutoSize = true;
            this.labelFiyati.Font = new System.Drawing.Font("Sitka Banner", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelFiyati.ForeColor = System.Drawing.Color.LightPink;
            this.labelFiyati.Location = new System.Drawing.Point(7, 97);
            this.labelFiyati.Name = "labelFiyati";
            this.labelFiyati.Size = new System.Drawing.Size(58, 28);
            this.labelFiyati.TabIndex = 44;
            this.labelFiyati.Text = "Fiyatı";
            // 
            // pictureBoxCicekYukle
            // 
            this.pictureBoxCicekYukle.Image = global::CicekSatisOtomasyonu.Properties.Resources.roseandcure_logo;
            this.pictureBoxCicekYukle.InitialImage = null;
            this.pictureBoxCicekYukle.Location = new System.Drawing.Point(558, -1);
            this.pictureBoxCicekYukle.Name = "pictureBoxCicekYukle";
            this.pictureBoxCicekYukle.Size = new System.Drawing.Size(130, 120);
            this.pictureBoxCicekYukle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCicekYukle.TabIndex = 41;
            this.pictureBoxCicekYukle.TabStop = false;
            this.pictureBoxCicekYukle.Click += new System.EventHandler(this.pictureBoxCicekYukle_Click);
            // 
            // textBoxCicekAdedi
            // 
            this.textBoxCicekAdedi.Location = new System.Drawing.Point(110, 146);
            this.textBoxCicekAdedi.Name = "textBoxCicekAdedi";
            this.textBoxCicekAdedi.Size = new System.Drawing.Size(127, 22);
            this.textBoxCicekAdedi.TabIndex = 42;
            // 
            // tBLCesitTableAdapter
            // 
            this.tBLCesitTableAdapter.ClearBeforeFill = true;
            // 
            // tBLRenkTableAdapter
            // 
            this.tBLRenkTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(709, 130);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(138, 22);
            this.textBoxId.TabIndex = 61;
            // 
            // formCicekListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1177, 568);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "formCicekListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Çiçek Listeleme Sayfası";
            this.Load += new System.EventHandler(this.formCicekListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBLRenkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cicekSatisOtomasyonDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLCesitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCicekYukle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button butonSil;
        private System.Windows.Forms.Button butonResimSec;
        private System.Windows.Forms.Button butonIptal;
        private System.Windows.Forms.Button butonGuncelle;
        private System.Windows.Forms.Label labelCicekStokAdedi;
        private System.Windows.Forms.Label labelUrunKodu;
        private System.Windows.Forms.Label labelUrunAciklamasi;
        private System.Windows.Forms.TextBox textBoxUrunKodu;
        private System.Windows.Forms.TextBox textBoxUrunAciklamasi;
        private System.Windows.Forms.TextBox textBoxCicekStokAdedi;
        private System.Windows.Forms.ComboBox comboBoxRenk;
        private System.Windows.Forms.Label labelCicekCesidi;
        private System.Windows.Forms.Label labelCicekAdedi;
        private System.Windows.Forms.ComboBox comboBoxCicekCesidi;
        private System.Windows.Forms.Label labelRenk;
        private System.Windows.Forms.TextBox textBoxFiyati;
        private System.Windows.Forms.Label labelFiyati;
        private System.Windows.Forms.PictureBox pictureBoxCicekYukle;
        private System.Windows.Forms.TextBox textBoxCicekAdedi;
        private System.Windows.Forms.Button butonMarkaModelGuncelle;
        private System.Windows.Forms.Label labelYeniModel;
        private System.Windows.Forms.Label labelYeniMarka;
        private CicekSatisOtomasyonDataSet2 cicekSatisOtomasyonDataSet2;
        private System.Windows.Forms.BindingSource tBLCesitBindingSource;
        private CicekSatisOtomasyonDataSet2TableAdapters.TBLCesitTableAdapter tBLCesitTableAdapter;
        private System.Windows.Forms.BindingSource tBLRenkBindingSource;
        private CicekSatisOtomasyonDataSet2TableAdapters.TBLRenkTableAdapter tBLRenkTableAdapter;
        private System.Windows.Forms.TextBox textBoxId;
    }
}