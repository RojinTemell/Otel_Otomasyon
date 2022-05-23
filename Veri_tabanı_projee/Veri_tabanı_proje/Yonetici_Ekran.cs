using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Veri_tabanı_proje
{
    public partial class Yonetici_Ekran : Form
    {
        public Yonetici_Ekran()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-56SRHAG;Initial Catalog=otel_rezervasyon;Integrated Security=True");
        // senaSqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-52OSE7G;Initial Catalog=otel_rezervasyon;Integrated Security=True");
       //rojin SqlConnection baglanti = new SqlConnection("Data Source = DESKTOP-N6SCB07; Initial Catalog = otel_rezervasyon; Integrated Security = True");
        private void calisanVerileriGoster()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *from tblCalisan", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["calisan_id"].ToString();
                ekle.SubItems.Add(oku["Yonetici_id"].ToString());
                ekle.SubItems.Add(oku["calisan_adi"].ToString());
                ekle.SubItems.Add(oku["calisan_soyadi"].ToString());
                ekle.SubItems.Add(oku["calisan_sifre"].ToString());
                ekle.SubItems.Add(oku["calisan_maas"].ToString());
                ekle.SubItems.Add(oku["rezervasyon_id"].ToString());
                ekle.SubItems.Add(oku["musteri_id"].ToString());
                ekle.SubItems.Add(oku["oda_id"].ToString());

                listView_calisan.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void musteriVerileriGoster()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from tblMusteriler", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["musteri_id"].ToString();
                ekle.SubItems.Add(oku["musteri_adi"].ToString());
                ekle.SubItems.Add(oku["musteri_soyadi"].ToString());
                ekle.SubItems.Add(oku["musteri_tel"].ToString());
                ekle.SubItems.Add(oku["musteri_mail"].ToString());
               // ekle.SubItems.Add(oku["rezervasyon_id"].ToString());
                ekle.SubItems.Add(oku["kart_id"].ToString());
                ekle.SubItems.Add(oku["oda_id"].ToString());

                listView_musteri.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void odaVerileriGoster()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *from tblOdalar", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["oda_id"].ToString();
                ekle.SubItems.Add(oku["oda_dolu_mu"].ToString());
                ekle.SubItems.Add(oku["oda_taban_fiyat"].ToString());

                listView_oda.Items.Add(ekle);
            }
            baglanti.Close();
        }
        private void Yonetici_Ekran_Load(object sender, EventArgs e)
        {
            calisanVerileriGoster();
            musteriVerileriGoster();
            odaVerileriGoster();
        }

        private void btn_geriDon_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Form1 anaForm = new Form1();
            anaForm.Show();
            this.Hide();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
