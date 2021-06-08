using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CicekSatisOtomasyonu.Formlar
{
    public partial class formCicekSatisYonetici : Form
    {


        public formCicekSatisYonetici()
        {
            InitializeComponent();
        }
        
        //YÖNETİCİ SAYFASINDA İSTENİLEN BİLGİLERİ GETİRMEK İÇİN FORM OLUŞTURUYORUZ.
        private void FormGetir(Form frm)
        {
            panelSayfalar.Controls.Clear();
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Left;
            panelSayfalar.Controls.Add(frm);
            frm.Show();

        }

        private void formCicekSatisYonetici_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cicekSatisOtomasyonDataSet.Kullanici' table. You can move, or remove it, as needed.
            this.kullaniciTableAdapter.Fill(this.cicekSatisOtomasyonDataSet.Kullanici);

        }

        private void butonYeniUyeEkle_Click(object sender, EventArgs e)
        {
            formYeniKullanici yenikullanici = new formYeniKullanici();
            FormGetir(yenikullanici);
        }

        private void butonCikis_Click(object sender, EventArgs e)
        {

            formKullaniciGirisi girisyap = new formKullaniciGirisi();
            formCicekSatisYonetici.ActiveForm.Visible = false;
            girisyap.Show();
        }

       
        private void butonUyeleriListele_Click(object sender, EventArgs e)
        {
            Formlar.formKullaniciListele liste = new Formlar.formKullaniciListele();
            FormGetir(liste);

        }

        private void butonCicekEkle_Click(object sender, EventArgs e)
        { 

            Formlar.formCicekEkle yenicicek = new Formlar.formCicekEkle();
            FormGetir(yenicicek);
        }

        private void butonCicekleriListele_Click(object sender, EventArgs e)
        {

            Formlar.formCicekListele ciceklistele = new Formlar.formCicekListele();
            FormGetir(ciceklistele);
        }
    }
}
