using System;
using CicekSatisOtomasyonu.Classlar;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CicekSatisOtomasyonu
{
    public partial class formCicekSatisSayfaUye : Form
    {
        public formCicekSatisSayfaUye()
        {
            InitializeComponent();
        }

        private void panelUrun_Paint(object sender, PaintEventArgs e)
        {

        }

        private void butonTemizle_Click(object sender, EventArgs e)
        {
            textBoxKullaniciId.Text = "";
            textBoxUrunId.Text = "";
        }
        Classlar.Sepet_Satis satis = new Classlar.Sepet_Satis();

        private void textBoxKullaniciId_TextChanged(object sender, EventArgs e)
        {
            if (textBoxKullaniciId.Text == "")
            {
                foreach (Control item in this.panelKullanici.Controls)
                    if (item is TextBox)
                        item.Text = "";
            }
            SqlCommand komut2 = new SqlCommand();
            satis.KullaniciIdAra(komut2, textBoxKullaniciId, textBoxAdiSoyadi, textBoxTelefon, textBoxEmail);
        }



        private void textBoxSeriNo_TextChanged(object sender, EventArgs e)
        {
            if (textBoxUrunId.Text == "")
            {
                foreach (Control item in this.panelUrun.Controls)
                    if (item is TextBox)
                        item.Text = "";
            }
          
            SqlCommand komut2 = new SqlCommand();
            satis.SeriNoAra(komut2,textBoxUrunId,textBoxUrunCesit,textBoxRenk,textBoxFiyat,textBoxCicekAdedi,textBoxUrunKodu);
        }

        private void formCicekSatisSayfaUye_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cicekSatisOtomasyonDataSet3.Urun' table. You can move, or remove it, as needed.
            this.urunTableAdapter.Fill(this.cicekSatisOtomasyonDataSet3.Urun);

        }

        private void butonSepeteEkle_Click(object sender, EventArgs e)
        {
            

        }
    }
}
