using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CicekSatisOtomasyonu.Classlar
{
    class Sepet_Satis
    {
        SqlConnection baglanti = new SqlConnection(Veritabani.strbaglanti);

        public SqlDataReader KullaniciIdAra(SqlCommand komut,TextBox kullaniciId, TextBox adisoyadi, TextBox telefon, TextBox email )
        {
            string sorgu = "select *from kullanici where id='" + kullaniciId.Text + "'";
            komut.CommandText = sorgu;
            komut.Connection = baglanti;
           
            if (baglanti.State == System.Data.ConnectionState.Closed)
                baglanti.Open();
            SqlDataReader dr1 = komut.ExecuteReader();
            while (dr1.Read())
            {
                adisoyadi.Text = dr1["adisoyadi"].ToString();
                telefon.Text = dr1["telefon"].ToString();
                email.Text = dr1["email"].ToString();
            }
            baglanti.Close();

            return dr1;
        }

        public SqlDataReader SeriNoAra(SqlCommand komut, TextBox urunid, TextBox uruncesit, TextBox renk, TextBox fiyat,TextBox cicekadedi,TextBox urunkodu)
        {

            string sorgu = "select *from urun where id='" + urunid.Text + "'";
            komut.CommandText = sorgu;
            komut.Connection = baglanti;

            if (baglanti.State == System.Data.ConnectionState.Closed)
                baglanti.Open();
            SqlDataReader dr1 = komut.ExecuteReader();
            while (dr1.Read())
            {
                
                uruncesit.Text = dr1["UrunCesit"].ToString();
                renk.Text = dr1["Renk"].ToString();
                fiyat.Text = dr1["Fiyat"].ToString();
                cicekadedi.Text = dr1["CicekAdedi"].ToString();
                urunkodu.Text = dr1["UrunKodu"].ToString();

            }
            baglanti.Close();
            return dr1;
        }
    }
}
