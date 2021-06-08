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
    public partial class formAnaSayfa : Form
    {
        public formAnaSayfa()
        {
            InitializeComponent();
        }

        private void formAnaSayfa_Load(object sender, EventArgs e)
        {

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void butonKayitOl_Click(object sender, EventArgs e)
        {
            formYeniKullanici yenikullanici = new formYeniKullanici();
            formAnaSayfa.ActiveForm.Visible = false;
            yenikullanici.Show();
            
        }

        private void butonUyeOl_Click(object sender, EventArgs e)
        {
            formKullaniciGirisi kullanicigirisi = new formKullaniciGirisi();
            formAnaSayfa.ActiveForm.Visible = false;
            kullanicigirisi.Show();
           
        }
    }
}
