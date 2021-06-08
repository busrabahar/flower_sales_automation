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
    public partial class formKullaniciGirisi : Form
    {
        public formKullaniciGirisi()
        {
            InitializeComponent();
        }

        private void labelKullaniciAdi_Click(object sender, EventArgs e)
        {

        }

        private void labelSifre_Click(object sender, EventArgs e)
        {

        }

        private void textBoxKullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSifreGoster.CheckState == CheckState.Checked)
            {
                textBoxSifre.UseSystemPasswordChar = true;
                checkBoxSifreGoster.Text = " Göster ";

            }

           else  if (checkBoxSifreGoster.CheckState == CheckState.Unchecked)
            {
                textBoxSifre.UseSystemPasswordChar = false;
                checkBoxSifreGoster.Text = "Gizle ";

            }
        }
        //kullanıcı tablosundan yeni nesne türettik.
        Classlar.Kullanici k = new Classlar.Kullanici();

        private void butonGiris_Click(object sender, EventArgs e)
        {
            //oluşturdugumuz kullanıcı girişi metoduna girilen şifre ve kullanıcı adını atıp doğruluğunu kontrol ediyoruz. 
            k.KullaniciGirisi(textBoxSifre, textBoxKullaniciAdi);
        }

        private void butonIptal_Click(object sender, EventArgs e)
        {

            formAnaSayfa anasayfa = new formAnaSayfa();
            formKullaniciGirisi.ActiveForm.Visible = false;
            anasayfa.Show();
        }
    }
}
