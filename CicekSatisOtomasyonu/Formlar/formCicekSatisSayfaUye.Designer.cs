namespace CicekSatisOtomasyonu
{
    partial class formCicekSatisSayfaUye
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
            this.tableAdapterManager1 = new CicekSatisOtomasyonu.CicekSatisOtomasyonDataSetTableAdapters.TableAdapterManager();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panelUrun = new System.Windows.Forms.Panel();
            this.butonSepeteEkle = new System.Windows.Forms.Button();
            this.butonTemizle = new System.Windows.Forms.Button();
            this.textBoxUrunKodu = new System.Windows.Forms.TextBox();
            this.textBoxCicekAdedi = new System.Windows.Forms.TextBox();
            this.labelUrunKodu = new System.Windows.Forms.Label();
            this.labelCicekAdedi = new System.Windows.Forms.Label();
            this.textBoxFiyat = new System.Windows.Forms.TextBox();
            this.textBoxRenk = new System.Windows.Forms.TextBox();
            this.textBoxUrunCesit = new System.Windows.Forms.TextBox();
            this.textBoxUrunId = new System.Windows.Forms.TextBox();
            this.labelFiyat = new System.Windows.Forms.Label();
            this.labelRenk = new System.Windows.Forms.Label();
            this.labelUrunCesit = new System.Windows.Forms.Label();
            this.labelUrunId = new System.Windows.Forms.Label();
            this.panelKullanici = new System.Windows.Forms.Panel();
            this.textBoxKullaniciId = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxTelefon = new System.Windows.Forms.TextBox();
            this.textBoxAdiSoyadi = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelTelefon = new System.Windows.Forms.Label();
            this.labelAdiSoyadi = new System.Windows.Forms.Label();
            this.labelKullaniciIsmi = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.butonSatisOnay = new System.Windows.Forms.Button();
            this.labelOdemeTuru = new System.Windows.Forms.Label();
            this.comboBoxOdemeTuru = new System.Windows.Forms.ComboBox();
            this.butonCikis = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxToplamTutar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelToplamTutar = new System.Windows.Forms.Label();
            this.cicekSatisOtomasyonDataSet3 = new CicekSatisOtomasyonu.CicekSatisOtomasyonDataSet3();
            this.urunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.urunTableAdapter = new CicekSatisOtomasyonu.CicekSatisOtomasyonDataSet3TableAdapters.UrunTableAdapter();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunCesitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.renkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cicekAdetiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAciklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunKoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunStokAdediDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panelUrun.SuspendLayout();
            this.panelKullanici.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cicekSatisOtomasyonDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.KullaniciTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = CicekSatisOtomasyonu.CicekSatisOtomasyonDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.89096F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.10903F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 202F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1019, 637);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(4, 130);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1011, 227);
            this.panel2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.urunCesitDataGridViewTextBoxColumn,
            this.renkDataGridViewTextBoxColumn,
            this.fiyatDataGridViewTextBoxColumn,
            this.resimDataGridViewTextBoxColumn,
            this.cicekAdetiDataGridViewTextBoxColumn,
            this.urunAciklamaDataGridViewTextBoxColumn,
            this.urunKoduDataGridViewTextBoxColumn,
            this.urunStokAdediDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.urunBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1011, 227);
            this.dataGridView1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 617F));
            this.tableLayoutPanel2.Controls.Add(this.panelUrun, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panelKullanici, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1011, 119);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panelUrun
            // 
            this.panelUrun.Controls.Add(this.butonSepeteEkle);
            this.panelUrun.Controls.Add(this.butonTemizle);
            this.panelUrun.Controls.Add(this.textBoxUrunKodu);
            this.panelUrun.Controls.Add(this.textBoxCicekAdedi);
            this.panelUrun.Controls.Add(this.labelUrunKodu);
            this.panelUrun.Controls.Add(this.labelCicekAdedi);
            this.panelUrun.Controls.Add(this.textBoxFiyat);
            this.panelUrun.Controls.Add(this.textBoxRenk);
            this.panelUrun.Controls.Add(this.textBoxUrunCesit);
            this.panelUrun.Controls.Add(this.textBoxUrunId);
            this.panelUrun.Controls.Add(this.labelFiyat);
            this.panelUrun.Controls.Add(this.labelRenk);
            this.panelUrun.Controls.Add(this.labelUrunCesit);
            this.panelUrun.Controls.Add(this.labelUrunId);
            this.panelUrun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUrun.Location = new System.Drawing.Point(396, 4);
            this.panelUrun.Name = "panelUrun";
            this.panelUrun.Size = new System.Drawing.Size(611, 111);
            this.panelUrun.TabIndex = 1;
            this.panelUrun.Paint += new System.Windows.Forms.PaintEventHandler(this.panelUrun_Paint);
            // 
            // butonSepeteEkle
            // 
            this.butonSepeteEkle.BackColor = System.Drawing.Color.Black;
            this.butonSepeteEkle.Font = new System.Drawing.Font("Sitka Banner", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.butonSepeteEkle.ForeColor = System.Drawing.Color.LightPink;
            this.butonSepeteEkle.Location = new System.Drawing.Point(528, -2);
            this.butonSepeteEkle.Name = "butonSepeteEkle";
            this.butonSepeteEkle.Size = new System.Drawing.Size(75, 58);
            this.butonSepeteEkle.TabIndex = 24;
            this.butonSepeteEkle.Text = "Sepete Ekle";
            this.butonSepeteEkle.UseVisualStyleBackColor = false;
            this.butonSepeteEkle.Click += new System.EventHandler(this.butonSepeteEkle_Click);
            // 
            // butonTemizle
            // 
            this.butonTemizle.BackColor = System.Drawing.Color.Black;
            this.butonTemizle.Font = new System.Drawing.Font("Sitka Banner", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.butonTemizle.ForeColor = System.Drawing.Color.LightPink;
            this.butonTemizle.Location = new System.Drawing.Point(528, 59);
            this.butonTemizle.Name = "butonTemizle";
            this.butonTemizle.Size = new System.Drawing.Size(75, 48);
            this.butonTemizle.TabIndex = 23;
            this.butonTemizle.Text = "Temizle";
            this.butonTemizle.UseVisualStyleBackColor = false;
            this.butonTemizle.Click += new System.EventHandler(this.butonTemizle_Click);
            // 
            // textBoxUrunKodu
            // 
            this.textBoxUrunKodu.Location = new System.Drawing.Point(378, 34);
            this.textBoxUrunKodu.Name = "textBoxUrunKodu";
            this.textBoxUrunKodu.Size = new System.Drawing.Size(143, 22);
            this.textBoxUrunKodu.TabIndex = 22;
            // 
            // textBoxCicekAdedi
            // 
            this.textBoxCicekAdedi.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxCicekAdedi.Location = new System.Drawing.Point(378, 1);
            this.textBoxCicekAdedi.Name = "textBoxCicekAdedi";
            this.textBoxCicekAdedi.Size = new System.Drawing.Size(143, 22);
            this.textBoxCicekAdedi.TabIndex = 20;
            // 
            // labelUrunKodu
            // 
            this.labelUrunKodu.AutoSize = true;
            this.labelUrunKodu.Font = new System.Drawing.Font("Sitka Banner", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelUrunKodu.ForeColor = System.Drawing.Color.LightPink;
            this.labelUrunKodu.Location = new System.Drawing.Point(282, 34);
            this.labelUrunKodu.Name = "labelUrunKodu";
            this.labelUrunKodu.Size = new System.Drawing.Size(76, 21);
            this.labelUrunKodu.TabIndex = 18;
            this.labelUrunKodu.Text = "Ürün Kodu";
            // 
            // labelCicekAdedi
            // 
            this.labelCicekAdedi.AutoSize = true;
            this.labelCicekAdedi.Font = new System.Drawing.Font("Sitka Banner", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelCicekAdedi.ForeColor = System.Drawing.Color.LightPink;
            this.labelCicekAdedi.Location = new System.Drawing.Point(278, 0);
            this.labelCicekAdedi.Name = "labelCicekAdedi";
            this.labelCicekAdedi.Size = new System.Drawing.Size(79, 21);
            this.labelCicekAdedi.TabIndex = 16;
            this.labelCicekAdedi.Text = "Çiçek Adedi";
            // 
            // textBoxFiyat
            // 
            this.textBoxFiyat.Location = new System.Drawing.Point(104, 87);
            this.textBoxFiyat.Name = "textBoxFiyat";
            this.textBoxFiyat.Size = new System.Drawing.Size(143, 22);
            this.textBoxFiyat.TabIndex = 15;
            // 
            // textBoxRenk
            // 
            this.textBoxRenk.Location = new System.Drawing.Point(104, 61);
            this.textBoxRenk.Name = "textBoxRenk";
            this.textBoxRenk.Size = new System.Drawing.Size(143, 22);
            this.textBoxRenk.TabIndex = 14;
            // 
            // textBoxUrunCesit
            // 
            this.textBoxUrunCesit.Location = new System.Drawing.Point(104, 33);
            this.textBoxUrunCesit.Name = "textBoxUrunCesit";
            this.textBoxUrunCesit.Size = new System.Drawing.Size(143, 22);
            this.textBoxUrunCesit.TabIndex = 13;
            // 
            // textBoxUrunId
            // 
            this.textBoxUrunId.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxUrunId.Location = new System.Drawing.Point(104, 5);
            this.textBoxUrunId.Name = "textBoxUrunId";
            this.textBoxUrunId.Size = new System.Drawing.Size(143, 22);
            this.textBoxUrunId.TabIndex = 12;
            // 
            // labelFiyat
            // 
            this.labelFiyat.AutoSize = true;
            this.labelFiyat.Font = new System.Drawing.Font("Sitka Banner", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFiyat.ForeColor = System.Drawing.Color.LightPink;
            this.labelFiyat.Location = new System.Drawing.Point(4, 90);
            this.labelFiyat.Name = "labelFiyat";
            this.labelFiyat.Size = new System.Drawing.Size(42, 21);
            this.labelFiyat.TabIndex = 11;
            this.labelFiyat.Text = "Fiyat";
            // 
            // labelRenk
            // 
            this.labelRenk.AutoSize = true;
            this.labelRenk.Font = new System.Drawing.Font("Sitka Banner", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelRenk.ForeColor = System.Drawing.Color.LightPink;
            this.labelRenk.Location = new System.Drawing.Point(4, 60);
            this.labelRenk.Name = "labelRenk";
            this.labelRenk.Size = new System.Drawing.Size(40, 21);
            this.labelRenk.TabIndex = 10;
            this.labelRenk.Text = "Renk";
            // 
            // labelUrunCesit
            // 
            this.labelUrunCesit.AutoSize = true;
            this.labelUrunCesit.Font = new System.Drawing.Font("Sitka Banner", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelUrunCesit.ForeColor = System.Drawing.Color.LightPink;
            this.labelUrunCesit.Location = new System.Drawing.Point(4, 32);
            this.labelUrunCesit.Name = "labelUrunCesit";
            this.labelUrunCesit.Size = new System.Drawing.Size(73, 21);
            this.labelUrunCesit.TabIndex = 9;
            this.labelUrunCesit.Text = "Ürün Çeşit";
            // 
            // labelUrunId
            // 
            this.labelUrunId.AutoSize = true;
            this.labelUrunId.Font = new System.Drawing.Font("Sitka Banner", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelUrunId.ForeColor = System.Drawing.Color.LightPink;
            this.labelUrunId.Location = new System.Drawing.Point(4, 4);
            this.labelUrunId.Name = "labelUrunId";
            this.labelUrunId.Size = new System.Drawing.Size(57, 21);
            this.labelUrunId.TabIndex = 8;
            this.labelUrunId.Text = "Ürün Id";
            // 
            // panelKullanici
            // 
            this.panelKullanici.Controls.Add(this.textBoxKullaniciId);
            this.panelKullanici.Controls.Add(this.textBoxEmail);
            this.panelKullanici.Controls.Add(this.textBoxTelefon);
            this.panelKullanici.Controls.Add(this.textBoxAdiSoyadi);
            this.panelKullanici.Controls.Add(this.labelEmail);
            this.panelKullanici.Controls.Add(this.labelTelefon);
            this.panelKullanici.Controls.Add(this.labelAdiSoyadi);
            this.panelKullanici.Controls.Add(this.labelKullaniciIsmi);
            this.panelKullanici.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelKullanici.Location = new System.Drawing.Point(4, 4);
            this.panelKullanici.Name = "panelKullanici";
            this.panelKullanici.Size = new System.Drawing.Size(385, 111);
            this.panelKullanici.TabIndex = 0;
            // 
            // textBoxKullaniciId
            // 
            this.textBoxKullaniciId.Location = new System.Drawing.Point(99, 5);
            this.textBoxKullaniciId.Name = "textBoxKullaniciId";
            this.textBoxKullaniciId.Size = new System.Drawing.Size(143, 22);
            this.textBoxKullaniciId.TabIndex = 8;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(99, 85);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(143, 22);
            this.textBoxEmail.TabIndex = 7;
            // 
            // textBoxTelefon
            // 
            this.textBoxTelefon.Location = new System.Drawing.Point(99, 59);
            this.textBoxTelefon.Name = "textBoxTelefon";
            this.textBoxTelefon.Size = new System.Drawing.Size(143, 22);
            this.textBoxTelefon.TabIndex = 6;
            // 
            // textBoxAdiSoyadi
            // 
            this.textBoxAdiSoyadi.Location = new System.Drawing.Point(99, 31);
            this.textBoxAdiSoyadi.Name = "textBoxAdiSoyadi";
            this.textBoxAdiSoyadi.Size = new System.Drawing.Size(143, 22);
            this.textBoxAdiSoyadi.TabIndex = 5;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Sitka Banner", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelEmail.ForeColor = System.Drawing.Color.LightPink;
            this.labelEmail.Location = new System.Drawing.Point(3, 84);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(50, 21);
            this.labelEmail.TabIndex = 3;
            this.labelEmail.Text = "E-mail";
            // 
            // labelTelefon
            // 
            this.labelTelefon.AutoSize = true;
            this.labelTelefon.Font = new System.Drawing.Font("Sitka Banner", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTelefon.ForeColor = System.Drawing.Color.LightPink;
            this.labelTelefon.Location = new System.Drawing.Point(-1, 58);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(54, 21);
            this.labelTelefon.TabIndex = 2;
            this.labelTelefon.Text = "Telefon";
            // 
            // labelAdiSoyadi
            // 
            this.labelAdiSoyadi.AutoSize = true;
            this.labelAdiSoyadi.Font = new System.Drawing.Font("Sitka Banner", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAdiSoyadi.ForeColor = System.Drawing.Color.LightPink;
            this.labelAdiSoyadi.Location = new System.Drawing.Point(-1, 30);
            this.labelAdiSoyadi.Name = "labelAdiSoyadi";
            this.labelAdiSoyadi.Size = new System.Drawing.Size(76, 21);
            this.labelAdiSoyadi.TabIndex = 1;
            this.labelAdiSoyadi.Text = "Adı Soyadı";
            // 
            // labelKullaniciIsmi
            // 
            this.labelKullaniciIsmi.AutoSize = true;
            this.labelKullaniciIsmi.Font = new System.Drawing.Font("Sitka Banner", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKullaniciIsmi.ForeColor = System.Drawing.Color.LightPink;
            this.labelKullaniciIsmi.Location = new System.Drawing.Point(-1, 2);
            this.labelKullaniciIsmi.Name = "labelKullaniciIsmi";
            this.labelKullaniciIsmi.Size = new System.Drawing.Size(80, 21);
            this.labelKullaniciIsmi.TabIndex = 0;
            this.labelKullaniciIsmi.Text = "Kullanıcı Id";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 606F));
            this.tableLayoutPanel3.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 364);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1011, 196);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.butonSatisOnay);
            this.panel4.Controls.Add(this.labelOdemeTuru);
            this.panel4.Controls.Add(this.comboBoxOdemeTuru);
            this.panel4.Controls.Add(this.butonCikis);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(407, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(600, 188);
            this.panel4.TabIndex = 2;
            // 
            // butonSatisOnay
            // 
            this.butonSatisOnay.BackColor = System.Drawing.Color.Black;
            this.butonSatisOnay.Font = new System.Drawing.Font("Sitka Banner", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.butonSatisOnay.ForeColor = System.Drawing.Color.LightPink;
            this.butonSatisOnay.Location = new System.Drawing.Point(419, 19);
            this.butonSatisOnay.Name = "butonSatisOnay";
            this.butonSatisOnay.Size = new System.Drawing.Size(159, 117);
            this.butonSatisOnay.TabIndex = 27;
            this.butonSatisOnay.Text = "Satış Onay";
            this.butonSatisOnay.UseVisualStyleBackColor = false;
            // 
            // labelOdemeTuru
            // 
            this.labelOdemeTuru.AutoSize = true;
            this.labelOdemeTuru.Font = new System.Drawing.Font("Sitka Banner", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOdemeTuru.ForeColor = System.Drawing.Color.LightPink;
            this.labelOdemeTuru.Location = new System.Drawing.Point(3, 42);
            this.labelOdemeTuru.Name = "labelOdemeTuru";
            this.labelOdemeTuru.Size = new System.Drawing.Size(114, 29);
            this.labelOdemeTuru.TabIndex = 4;
            this.labelOdemeTuru.Text = "Ödeme Türü";
            // 
            // comboBoxOdemeTuru
            // 
            this.comboBoxOdemeTuru.FormattingEnabled = true;
            this.comboBoxOdemeTuru.Items.AddRange(new object[] {
            "Nakit"});
            this.comboBoxOdemeTuru.Location = new System.Drawing.Point(123, 47);
            this.comboBoxOdemeTuru.Name = "comboBoxOdemeTuru";
            this.comboBoxOdemeTuru.Size = new System.Drawing.Size(191, 24);
            this.comboBoxOdemeTuru.TabIndex = 3;
            // 
            // butonCikis
            // 
            this.butonCikis.BackColor = System.Drawing.Color.Black;
            this.butonCikis.Font = new System.Drawing.Font("Sitka Banner", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.butonCikis.ForeColor = System.Drawing.Color.LightPink;
            this.butonCikis.Location = new System.Drawing.Point(4, 105);
            this.butonCikis.Name = "butonCikis";
            this.butonCikis.Size = new System.Drawing.Size(79, 34);
            this.butonCikis.TabIndex = 26;
            this.butonCikis.Text = "ÇIKIŞ";
            this.butonCikis.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Banner", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Tomato;
            this.label3.Location = new System.Drawing.Point(202, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "ÖDEME BÖLÜMÜ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBoxToplamTutar);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.labelToplamTutar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(396, 188);
            this.panel3.TabIndex = 1;
            // 
            // textBoxToplamTutar
            // 
            this.textBoxToplamTutar.BackColor = System.Drawing.Color.Tomato;
            this.textBoxToplamTutar.Location = new System.Drawing.Point(166, 55);
            this.textBoxToplamTutar.Name = "textBoxToplamTutar";
            this.textBoxToplamTutar.Size = new System.Drawing.Size(147, 22);
            this.textBoxToplamTutar.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.LightPink;
            this.label2.Location = new System.Drawing.Point(319, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "TL";
            // 
            // labelToplamTutar
            // 
            this.labelToplamTutar.AutoSize = true;
            this.labelToplamTutar.Font = new System.Drawing.Font("Sitka Banner", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelToplamTutar.ForeColor = System.Drawing.Color.LightPink;
            this.labelToplamTutar.Location = new System.Drawing.Point(-7, 40);
            this.labelToplamTutar.Name = "labelToplamTutar";
            this.labelToplamTutar.Size = new System.Drawing.Size(173, 40);
            this.labelToplamTutar.TabIndex = 1;
            this.labelToplamTutar.Text = "Toplam Tutar";
            // 
            // cicekSatisOtomasyonDataSet3
            // 
            this.cicekSatisOtomasyonDataSet3.DataSetName = "CicekSatisOtomasyonDataSet3";
            this.cicekSatisOtomasyonDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // urunBindingSource
            // 
            this.urunBindingSource.DataMember = "Urun";
            this.urunBindingSource.DataSource = this.cicekSatisOtomasyonDataSet3;
            // 
            // urunTableAdapter
            // 
            this.urunTableAdapter.ClearBeforeFill = true;
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // urunCesitDataGridViewTextBoxColumn
            // 
            this.urunCesitDataGridViewTextBoxColumn.DataPropertyName = "UrunCesit";
            this.urunCesitDataGridViewTextBoxColumn.HeaderText = "UrunCesit";
            this.urunCesitDataGridViewTextBoxColumn.Name = "urunCesitDataGridViewTextBoxColumn";
            // 
            // renkDataGridViewTextBoxColumn
            // 
            this.renkDataGridViewTextBoxColumn.DataPropertyName = "Renk";
            this.renkDataGridViewTextBoxColumn.HeaderText = "Renk";
            this.renkDataGridViewTextBoxColumn.Name = "renkDataGridViewTextBoxColumn";
            // 
            // fiyatDataGridViewTextBoxColumn
            // 
            this.fiyatDataGridViewTextBoxColumn.DataPropertyName = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn.HeaderText = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn.Name = "fiyatDataGridViewTextBoxColumn";
            // 
            // resimDataGridViewTextBoxColumn
            // 
            this.resimDataGridViewTextBoxColumn.DataPropertyName = "Resim";
            this.resimDataGridViewTextBoxColumn.HeaderText = "Resim";
            this.resimDataGridViewTextBoxColumn.Name = "resimDataGridViewTextBoxColumn";
            // 
            // cicekAdetiDataGridViewTextBoxColumn
            // 
            this.cicekAdetiDataGridViewTextBoxColumn.DataPropertyName = "CicekAdeti";
            this.cicekAdetiDataGridViewTextBoxColumn.HeaderText = "CicekAdeti";
            this.cicekAdetiDataGridViewTextBoxColumn.Name = "cicekAdetiDataGridViewTextBoxColumn";
            // 
            // urunAciklamaDataGridViewTextBoxColumn
            // 
            this.urunAciklamaDataGridViewTextBoxColumn.DataPropertyName = "UrunAciklama";
            this.urunAciklamaDataGridViewTextBoxColumn.HeaderText = "UrunAciklama";
            this.urunAciklamaDataGridViewTextBoxColumn.Name = "urunAciklamaDataGridViewTextBoxColumn";
            // 
            // urunKoduDataGridViewTextBoxColumn
            // 
            this.urunKoduDataGridViewTextBoxColumn.DataPropertyName = "UrunKodu";
            this.urunKoduDataGridViewTextBoxColumn.HeaderText = "UrunKodu";
            this.urunKoduDataGridViewTextBoxColumn.Name = "urunKoduDataGridViewTextBoxColumn";
            // 
            // urunStokAdediDataGridViewTextBoxColumn
            // 
            this.urunStokAdediDataGridViewTextBoxColumn.DataPropertyName = "UrunStokAdedi";
            this.urunStokAdediDataGridViewTextBoxColumn.HeaderText = "UrunStokAdedi";
            this.urunStokAdediDataGridViewTextBoxColumn.Name = "urunStokAdediDataGridViewTextBoxColumn";
            // 
            // formCicekSatisSayfaUye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1018, 619);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "formCicekSatisSayfaUye";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Çiçek Satış(üye)";
            this.Load += new System.EventHandler(this.formCicekSatisSayfaUye_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panelUrun.ResumeLayout(false);
            this.panelUrun.PerformLayout();
            this.panelKullanici.ResumeLayout(false);
            this.panelKullanici.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cicekSatisOtomasyonDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CicekSatisOtomasyonDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelUrun;
        private System.Windows.Forms.Panel panelKullanici;
        private System.Windows.Forms.Label labelKullaniciIsmi;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button butonSepeteEkle;
        private System.Windows.Forms.Button butonTemizle;
        private System.Windows.Forms.TextBox textBoxUrunKodu;
        private System.Windows.Forms.TextBox textBoxCicekAdedi;
        private System.Windows.Forms.Label labelUrunKodu;
        private System.Windows.Forms.Label labelCicekAdedi;
        private System.Windows.Forms.TextBox textBoxFiyat;
        private System.Windows.Forms.TextBox textBoxRenk;
        private System.Windows.Forms.TextBox textBoxUrunCesit;
        private System.Windows.Forms.TextBox textBoxUrunId;
        private System.Windows.Forms.Label labelFiyat;
        private System.Windows.Forms.Label labelRenk;
        private System.Windows.Forms.Label labelUrunCesit;
        private System.Windows.Forms.Label labelUrunId;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxTelefon;
        private System.Windows.Forms.TextBox textBoxAdiSoyadi;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelTelefon;
        private System.Windows.Forms.Label labelAdiSoyadi;
        private System.Windows.Forms.Label labelOdemeTuru;
        private System.Windows.Forms.ComboBox comboBoxOdemeTuru;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxToplamTutar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelToplamTutar;
        private System.Windows.Forms.Button butonSatisOnay;
        private System.Windows.Forms.Button butonCikis;
        private System.Windows.Forms.TextBox textBoxKullaniciId;
        private CicekSatisOtomasyonDataSet3 cicekSatisOtomasyonDataSet3;
        private System.Windows.Forms.BindingSource urunBindingSource;
        private CicekSatisOtomasyonDataSet3TableAdapters.UrunTableAdapter urunTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunCesitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn renkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cicekAdetiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAciklamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunKoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunStokAdediDataGridViewTextBoxColumn;
    }
}