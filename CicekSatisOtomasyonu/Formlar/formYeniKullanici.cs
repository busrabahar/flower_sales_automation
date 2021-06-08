using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CicekSatisOtomasyonu
{
    public partial class formYeniKullanici : Form
    {
        public formYeniKullanici()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //YENİ KULLANICI İÇİN FOTOĞRAF EKLİYORUZ
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
        
                pictureBox1.ImageLocation = file.FileName;
            
        }

        private void butonIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Classlar.Kullanici k = new Classlar.Kullanici();

        private void butonEkle_Click(object sender, EventArgs e)
        {

            k.YeniKullanici(textBoxAdiSoyadi.Text, textBoxTelefonNo.Text, textBoxAdres.Text, textBoxEmail.Text, textBoxKullaniciAdi.Text, textBoxSifre.Text, textBoxSifreTekrar.Text, textBoxGörevi.Text, pictureBox1.ImageLocation);


        }
    }
}
