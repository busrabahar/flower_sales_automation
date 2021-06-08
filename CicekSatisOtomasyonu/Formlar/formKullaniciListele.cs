using CicekSatisOtomasyonu.Classlar;
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
    public partial class formKullaniciListele : Form
    {
        SqlConnection baglanti = new SqlConnection(Veritabani.strbaglanti);
        public formKullaniciListele()
        {
            InitializeComponent();
        }

        private void formKullaniciListele_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cicekSatisOtomasyonDataSet3.Kullanici' table. You can move, or remove it, as needed.
            this.kullaniciTableAdapter.Fill(this.cicekSatisOtomasyonDataSet3.Kullanici);

        }

        private void butonUyeSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            
            SqlCommand komut = new SqlCommand("delete from kullanici where ID='" + dataGridView1.CurrentRow.Cells[0].Value + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kullanıcı Silindi!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
