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
    public partial class formCicekListele : Form
    {
        public formCicekListele()
        {
            InitializeComponent();
        }
        CicekSatisOtomasyonDataSet2TableAdapters.UrunTableAdapter ds = new CicekSatisOtomasyonDataSet2TableAdapters.UrunTableAdapter();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

            
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            labelYeniMarka.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            labelYeniModel.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxFiyati.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBoxCicekAdedi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBoxUrunAciklamasi.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBoxUrunKodu.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBoxCicekStokAdedi.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            pictureBoxCicekYukle.ImageLocation = dataGridView1.CurrentRow.Cells[8].Value.ToString();




        }

        private void formCicekListele_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cicekSatisOtomasyonDataSet2.TBLRenk' table. You can move, or remove it, as needed.
            this.tBLRenkTableAdapter.Fill(this.cicekSatisOtomasyonDataSet2.TBLRenk);
            // TODO: This line of code loads data into the 'cicekSatisOtomasyonDataSet2.TBLCesit' table. You can move, or remove it, as needed.
            this.tBLCesitTableAdapter.Fill(this.cicekSatisOtomasyonDataSet2.TBLCesit);
            dataGridView1.DataSource = ds.listele2(); //Cicekleri Listeleme
        }

        private void pictureBoxCicekYukle_Click(object sender, EventArgs e)
        {

        }

        private void butonResimSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            pictureBoxCicekYukle.ImageLocation = file.FileName;
        }
        Classlar.Cicek cicek = new Classlar.Cicek();
        private void butonGuncelle_Click(object sender, EventArgs e)
        {
            string sorgu2 = "update urun set uruncesit='" + labelYeniMarka.Text + "',renk='" + labelYeniModel.Text + "',fiyat='" + textBoxFiyati.Text + "',cicekadedi='" + textBoxCicekAdedi.Text + "',urunaciklamasi='" + textBoxUrunAciklamasi.Text +  "',urunstokadedi='" + textBoxCicekStokAdedi +"'where ID='"+textBoxId.Text+ "'";
            SqlCommand komut2 = new SqlCommand();
            cicek.ESG(komut2, sorgu2);
            dataGridView1.DataSource = ds.listele2();
        }

        private void butonMarkaModelGuncelle_Click(object sender, EventArgs e)
        {
            labelYeniMarka.Text = comboBoxCicekCesidi.Text;
            labelYeniModel.Text = comboBoxRenk.Text;
        }

        private void butonSil_Click(object sender, EventArgs e)
        {
            string sorgu2 = "delete from urun where ID='" + dataGridView1.CurrentRow.Cells[0].Value + "'";
            SqlCommand komut2 = new SqlCommand();
            cicek.ESG(komut2, sorgu2);
            dataGridView1.DataSource = ds.listele2();
        }

        private void butonIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
