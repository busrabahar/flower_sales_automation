using CicekSatisOtomasyonu.Formlar;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CicekSatisOtomasyonu.Classlar
{
    class Kullanici
    {
        SqlConnection baglanti = new SqlConnection(Veritabani.strbaglanti);
        private string adisoyadi;
        private string telefon;
        string adres;
        string email;
        string kullaniciadi;
        string sifre;
        string gorevi;
        string resim;
    
        //Butun Alanları kapsulluyoruz.
        public string AdiSoyadi
        {
            get
            { return adisoyadi; }
            set
            { adisoyadi = value; }
        }

        public string Telefon { get => telefon; set => telefon = value; }
        public string Adres { get => adres; set => adres = value; }
        public string Email { get => email; set => email = value; }
        public string Kullaniciadi { get => kullaniciadi; set => kullaniciadi = value; }
        public string Sifre { get => sifre; set => sifre = value; }
        public string Gorevi { get => gorevi; set => gorevi = value; }
        public string Resim { get => resim; set => resim = value; }

        //KULLANICI GİRİŞİ İÇİN METOT
        public void KullaniciGirisi(TextBox  textBoxSifre, TextBox textBoxKullaniciAdi )
        {
          


            //Kullanıcı adı veya şifrede boş olup olmadığının kontrolü yapılıyor.;
            if (textBoxKullaniciAdi.Text == "" || textBoxSifre.Text == "")
            {
                MessageBox.Show("Kullanıcı adı ve/veya şifre boş geçilemez!","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            //Boş geçilmezse sql bağlantısını açıyoruz.
            else
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("select *from kullanici where kullaniciadi='" + textBoxKullaniciAdi.Text + "' and sifre='" + textBoxSifre.Text + "'", baglanti);
                SqlDataReader dr = komut.ExecuteReader();
                //Kullanıcı adı ve şifrenin dogru girip girilmediğinin kontrolünü yapıyoruz;
                if (dr.Read())
                {
                    if (dr["gorevi"].ToString() == "yönetici")  //GİRİŞ YAPAN ÜYE Mİ ADMİN Mİ OLDUĞUNU KONTROL EDİYOR.
                    {
                        formCicekSatisYonetici ciceksatisYonetici = new formCicekSatisYonetici();
                        formKullaniciGirisi.ActiveForm.Visible = false;
                        ciceksatisYonetici.Show();
                    }
              else
                    {
                        //doğru girildiyse cicek satış sayfasını açıyoruz.
                        formCicekSatisSayfaUye ciceksatissayfa = new formCicekSatisSayfaUye();
                        formKullaniciGirisi.ActiveForm.Visible = false;
                        ciceksatissayfa.Show();
                    }
                

                }
                else
                {
                    MessageBox.Show("Kullanıcı adı ve/veya şifrenizi kontrol ediniz!!", "Uyarı-2", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                baglanti.Close();

            }
        }

        public void YeniKullanici(string _AdiSoyadi, string _TelNo, string _Adres, string _Email, string _KullaniciAdi,string _Sifre, string _SifreTekrar, string _Gorevi, string _Resim )
        {
            AdiSoyadi = _AdiSoyadi;
            Telefon = _TelNo;
            Adres = _Adres;
            Email = _Email;
            Kullaniciadi = _KullaniciAdi;
            Sifre = _Sifre;
            Gorevi = _Gorevi;
            Resim = _Resim;
            if(Sifre==_SifreTekrar) //girilen iki şifrenin doğruluğu kontrol ediliyor.
            
           {
                baglanti.Open();
                //YENİ KULLANICIYI KAYDEDİYORUZ:
                SqlCommand komut = new SqlCommand("insert into kullanici values('" + AdiSoyadi + "','" + Telefon + "','" + Adres + "','" + Email + "','" + Kullaniciadi + "','" + Sifre + "','" + Gorevi + "','" + Resim + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Yeni kullanıcı eklendi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {

                MessageBox.Show("Şifreler uyuşmuyor!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        
      

    }
}
