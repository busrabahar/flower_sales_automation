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
    public partial class formCicekEkle : Form
    {
        public formCicekEkle()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void formCicekEkle_Load(object sender, EventArgs e)
        {
           
            this.tBLRenkTableAdapter.Fill(this.cicekSatisOtomasyonDataSet2.TBLRenk);
            this.tBLCesitTableAdapter.Fill(this.cicekSatisOtomasyonDataSet2.TBLCesit);

        }

        private void butonIptal_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void butonResimSec_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            pictureBoxCicekYukle.ImageLocation = file.FileName;

        }

        Classlar.Cicek cicek = new Classlar.Cicek();

        private void butonEkle_Click(object sender, EventArgs e)
        {

            string sorgu2 = "insert into urun values('" + comboBoxCicekCesidi.Text + "','" + comboBoxRenk.Text + "',@Fiyat,'" + pictureBoxCicekYukle.ImageLocation + "','" + textBoxCicekAdedi.Text + "','" + textBoxUrunAciklamasi.Text + "','" + textBoxUrunKodu.Text + "','" + textBoxCicekStokAdedi.Text + "')";

            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@Fiyat",double.Parse(textBoxFiyati.Text));
            cicek.ESG(komut2, sorgu2);

        }

        private void labelCicekStokAdedi_Click(object sender, EventArgs e)
        {

        }

        private void labelUrunKodu_Click(object sender, EventArgs e)
        {

        }

        private void labelUrunAciklamasi_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUrunKodu_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUrunAciklamasi_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCicekStokAdedi_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxRenk_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
