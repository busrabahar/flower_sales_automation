using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CicekSatisOtomasyonu.Classlar
{
    class Cicek
    {
        //Çiçek İÇİN VERİTABANINDA YAPICLACAK İŞLEMLER İÇİN AÇILAN CLASS

        SqlConnection baglanti = new SqlConnection(Veritabani.strbaglanti);

        public int ESG(SqlCommand komut, string sorgu )
        {

            // URUN EKLEME İCİN FONKSİYON
            int sonuc = 0;
            komut.CommandText = sorgu;
            komut.Connection = baglanti;
            if (baglanti.State == System.Data.ConnectionState.Closed) //Eğer bağlantı durumu kapalıysa;
            
                baglanti.Open();

                try
                {

                    sonuc = komut.ExecuteNonQuery();
                    MessageBox.Show("Islem basarili.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception ex)
                {
                    string hata = ex.Message;
                MessageBox.Show("Islem basarili degil!.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                finally
                {
                    baglanti.Close();
                }

                return sonuc;
            
        }
    }
}
