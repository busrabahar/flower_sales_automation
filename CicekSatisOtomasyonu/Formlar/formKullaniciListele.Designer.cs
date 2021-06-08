namespace CicekSatisOtomasyonu.Formlar
{
    partial class formKullaniciListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formKullaniciListele));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cicekSatisOtomasyonDataSet3 = new CicekSatisOtomasyonu.CicekSatisOtomasyonDataSet3();
            this.cicekSatisOtomasyonDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kullaniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kullaniciTableAdapter = new CicekSatisOtomasyonu.CicekSatisOtomasyonDataSet3TableAdapters.KullaniciTableAdapter();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adiSoyadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goreviDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Gorevi = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelMail = new System.Windows.Forms.Label();
            this.labelAdres = new System.Windows.Forms.Label();
            this.labelTelefon = new System.Windows.Forms.Label();
            this.labelAdiSoyadi = new System.Windows.Forms.Label();
            this.textBoxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.textBoxGörevi = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxTelefonNo = new System.Windows.Forms.TextBox();
            this.textBoxAdres = new System.Windows.Forms.TextBox();
            this.textBoxAdiSoyadi = new System.Windows.Forms.TextBox();
            this.butonUyeSil = new System.Windows.Forms.Button();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cicekSatisOtomasyonDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cicekSatisOtomasyonDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.adiSoyadiDataGridViewTextBoxColumn,
            this.telNoDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.kullaniciAdiDataGridViewTextBoxColumn,
            this.sifreDataGridViewTextBoxColumn,
            this.goreviDataGridViewTextBoxColumn,
            this.resimDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kullaniciBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(765, 212);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cicekSatisOtomasyonDataSet3
            // 
            this.cicekSatisOtomasyonDataSet3.DataSetName = "CicekSatisOtomasyonDataSet3";
            this.cicekSatisOtomasyonDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cicekSatisOtomasyonDataSet3BindingSource
            // 
            this.cicekSatisOtomasyonDataSet3BindingSource.DataSource = this.cicekSatisOtomasyonDataSet3;
            this.cicekSatisOtomasyonDataSet3BindingSource.Position = 0;
            // 
            // kullaniciBindingSource
            // 
            this.kullaniciBindingSource.DataMember = "Kullanici";
            this.kullaniciBindingSource.DataSource = this.cicekSatisOtomasyonDataSet3BindingSource;
            // 
            // kullaniciTableAdapter
            // 
            this.kullaniciTableAdapter.ClearBeforeFill = true;
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adiSoyadiDataGridViewTextBoxColumn
            // 
            this.adiSoyadiDataGridViewTextBoxColumn.DataPropertyName = "AdiSoyadi";
            this.adiSoyadiDataGridViewTextBoxColumn.HeaderText = "AdiSoyadi";
            this.adiSoyadiDataGridViewTextBoxColumn.Name = "adiSoyadiDataGridViewTextBoxColumn";
            // 
            // telNoDataGridViewTextBoxColumn
            // 
            this.telNoDataGridViewTextBoxColumn.DataPropertyName = "TelNo";
            this.telNoDataGridViewTextBoxColumn.HeaderText = "TelNo";
            this.telNoDataGridViewTextBoxColumn.Name = "telNoDataGridViewTextBoxColumn";
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "Adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // kullaniciAdiDataGridViewTextBoxColumn
            // 
            this.kullaniciAdiDataGridViewTextBoxColumn.DataPropertyName = "KullaniciAdi";
            this.kullaniciAdiDataGridViewTextBoxColumn.HeaderText = "KullaniciAdi";
            this.kullaniciAdiDataGridViewTextBoxColumn.Name = "kullaniciAdiDataGridViewTextBoxColumn";
            // 
            // sifreDataGridViewTextBoxColumn
            // 
            this.sifreDataGridViewTextBoxColumn.DataPropertyName = "Sifre";
            this.sifreDataGridViewTextBoxColumn.HeaderText = "Sifre";
            this.sifreDataGridViewTextBoxColumn.Name = "sifreDataGridViewTextBoxColumn";
            this.sifreDataGridViewTextBoxColumn.Visible = false;
            // 
            // goreviDataGridViewTextBoxColumn
            // 
            this.goreviDataGridViewTextBoxColumn.DataPropertyName = "Gorevi";
            this.goreviDataGridViewTextBoxColumn.HeaderText = "Gorevi";
            this.goreviDataGridViewTextBoxColumn.Name = "goreviDataGridViewTextBoxColumn";
            // 
            // resimDataGridViewTextBoxColumn
            // 
            this.resimDataGridViewTextBoxColumn.DataPropertyName = "Resim";
            this.resimDataGridViewTextBoxColumn.HeaderText = "Resim";
            this.resimDataGridViewTextBoxColumn.Name = "resimDataGridViewTextBoxColumn";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(612, 218);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // Gorevi
            // 
            this.Gorevi.AutoSize = true;
            this.Gorevi.Font = new System.Drawing.Font("Sitka Banner", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Gorevi.ForeColor = System.Drawing.Color.LightPink;
            this.Gorevi.Location = new System.Drawing.Point(312, 278);
            this.Gorevi.Name = "Gorevi";
            this.Gorevi.Size = new System.Drawing.Size(63, 28);
            this.Gorevi.TabIndex = 35;
            this.Gorevi.Text = "Görevi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Sitka Banner", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.ForeColor = System.Drawing.Color.LightPink;
            this.label5.Location = new System.Drawing.Point(312, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 28);
            this.label5.TabIndex = 32;
            this.label5.Text = "Kullanıcı Adı";
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Font = new System.Drawing.Font("Sitka Banner", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelMail.ForeColor = System.Drawing.Color.LightPink;
            this.labelMail.Location = new System.Drawing.Point(312, 220);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(63, 28);
            this.labelMail.TabIndex = 31;
            this.labelMail.Text = "E-mail";
            // 
            // labelAdres
            // 
            this.labelAdres.AutoSize = true;
            this.labelAdres.Font = new System.Drawing.Font("Sitka Banner", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelAdres.ForeColor = System.Drawing.Color.LightPink;
            this.labelAdres.Location = new System.Drawing.Point(18, 274);
            this.labelAdres.Name = "labelAdres";
            this.labelAdres.Size = new System.Drawing.Size(57, 28);
            this.labelAdres.TabIndex = 30;
            this.labelAdres.Text = "Adres";
            // 
            // labelTelefon
            // 
            this.labelTelefon.AutoSize = true;
            this.labelTelefon.Font = new System.Drawing.Font("Sitka Banner", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelTelefon.ForeColor = System.Drawing.Color.LightPink;
            this.labelTelefon.Location = new System.Drawing.Point(12, 246);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(93, 28);
            this.labelTelefon.TabIndex = 29;
            this.labelTelefon.Text = "Telefon No";
            // 
            // labelAdiSoyadi
            // 
            this.labelAdiSoyadi.AutoSize = true;
            this.labelAdiSoyadi.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelAdiSoyadi.Font = new System.Drawing.Font("Sitka Banner", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAdiSoyadi.ForeColor = System.Drawing.Color.LightPink;
            this.labelAdiSoyadi.Location = new System.Drawing.Point(10, 218);
            this.labelAdiSoyadi.Name = "labelAdiSoyadi";
            this.labelAdiSoyadi.Size = new System.Drawing.Size(95, 28);
            this.labelAdiSoyadi.TabIndex = 28;
            this.labelAdiSoyadi.Text = "Adı Soyadı";
            // 
            // textBoxKullaniciAdi
            // 
            this.textBoxKullaniciAdi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kullaniciBindingSource, "KullaniciAdi", true));
            this.textBoxKullaniciAdi.Location = new System.Drawing.Point(428, 252);
            this.textBoxKullaniciAdi.Name = "textBoxKullaniciAdi";
            this.textBoxKullaniciAdi.Size = new System.Drawing.Size(178, 22);
            this.textBoxKullaniciAdi.TabIndex = 27;
            // 
            // textBoxGörevi
            // 
            this.textBoxGörevi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kullaniciBindingSource, "Gorevi", true));
            this.textBoxGörevi.Location = new System.Drawing.Point(428, 284);
            this.textBoxGörevi.Name = "textBoxGörevi";
            this.textBoxGörevi.Size = new System.Drawing.Size(178, 22);
            this.textBoxGörevi.TabIndex = 24;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kullaniciBindingSource, "Email", true));
            this.textBoxEmail.Location = new System.Drawing.Point(428, 223);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(178, 22);
            this.textBoxEmail.TabIndex = 23;
            // 
            // textBoxTelefonNo
            // 
            this.textBoxTelefonNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kullaniciBindingSource, "TelNo", true));
            this.textBoxTelefonNo.Location = new System.Drawing.Point(128, 252);
            this.textBoxTelefonNo.Name = "textBoxTelefonNo";
            this.textBoxTelefonNo.Size = new System.Drawing.Size(178, 22);
            this.textBoxTelefonNo.TabIndex = 22;
            // 
            // textBoxAdres
            // 
            this.textBoxAdres.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kullaniciBindingSource, "Adres", true));
            this.textBoxAdres.Location = new System.Drawing.Point(128, 280);
            this.textBoxAdres.Name = "textBoxAdres";
            this.textBoxAdres.Size = new System.Drawing.Size(178, 22);
            this.textBoxAdres.TabIndex = 21;
            // 
            // textBoxAdiSoyadi
            // 
            this.textBoxAdiSoyadi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kullaniciBindingSource, "AdiSoyadi", true));
            this.textBoxAdiSoyadi.Location = new System.Drawing.Point(128, 224);
            this.textBoxAdiSoyadi.Name = "textBoxAdiSoyadi";
            this.textBoxAdiSoyadi.Size = new System.Drawing.Size(178, 22);
            this.textBoxAdiSoyadi.TabIndex = 20;
            // 
            // butonUyeSil
            // 
            this.butonUyeSil.BackColor = System.Drawing.Color.Black;
            this.butonUyeSil.Font = new System.Drawing.Font("Sitka Banner", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.butonUyeSil.ForeColor = System.Drawing.Color.LightPink;
            this.butonUyeSil.Location = new System.Drawing.Point(612, 306);
            this.butonUyeSil.Name = "butonUyeSil";
            this.butonUyeSil.Size = new System.Drawing.Size(106, 49);
            this.butonUyeSil.TabIndex = 37;
            this.butonUyeSil.Text = "Üye Sil";
            this.butonUyeSil.UseVisualStyleBackColor = false;
            this.butonUyeSil.Click += new System.EventHandler(this.butonUyeSil_Click);
            // 
            // textBoxId
            // 
            this.textBoxId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kullaniciBindingSource, "AdiSoyadi", true));
            this.textBoxId.Location = new System.Drawing.Point(612, 361);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(106, 22);
            this.textBoxId.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.LightPink;
            this.label1.Location = new System.Drawing.Point(544, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 28);
            this.label1.TabIndex = 39;
            this.label1.Text = "Üye Id";
            // 
            // formKullaniciListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(765, 495);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.butonUyeSil);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Gorevi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelMail);
            this.Controls.Add(this.labelAdres);
            this.Controls.Add(this.labelTelefon);
            this.Controls.Add(this.labelAdiSoyadi);
            this.Controls.Add(this.textBoxKullaniciAdi);
            this.Controls.Add(this.textBoxGörevi);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxTelefonNo);
            this.Controls.Add(this.textBoxAdres);
            this.Controls.Add(this.textBoxAdiSoyadi);
            this.Controls.Add(this.dataGridView1);
            this.Name = "formKullaniciListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Listeleme Sayfası";
            this.Load += new System.EventHandler(this.formKullaniciListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cicekSatisOtomasyonDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cicekSatisOtomasyonDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource cicekSatisOtomasyonDataSet3BindingSource;
        private CicekSatisOtomasyonDataSet3 cicekSatisOtomasyonDataSet3;
        private System.Windows.Forms.BindingSource kullaniciBindingSource;
        private CicekSatisOtomasyonDataSet3TableAdapters.KullaniciTableAdapter kullaniciTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adiSoyadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goreviDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resimDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Gorevi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Label labelAdres;
        private System.Windows.Forms.Label labelTelefon;
        private System.Windows.Forms.Label labelAdiSoyadi;
        private System.Windows.Forms.TextBox textBoxKullaniciAdi;
        private System.Windows.Forms.TextBox textBoxGörevi;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxTelefonNo;
        private System.Windows.Forms.TextBox textBoxAdres;
        private System.Windows.Forms.TextBox textBoxAdiSoyadi;
        private System.Windows.Forms.Button butonUyeSil;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label1;
    }
}