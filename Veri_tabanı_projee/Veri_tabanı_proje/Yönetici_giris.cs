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
    public partial class Yönetici_giris : Form
    {
        public Yönetici_giris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-56SRHAG;Initial Catalog=otel_rezervasyon;Integrated Security=True");
       // sena SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-52OSE7G;Initial Catalog=otel_rezervasyon;Integrated Security=True");
        private void btn_yoneticiGiris_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            label2.Visible = true;
        }

        private void Yönetici_giris_Load(object sender, EventArgs e)
        {
            label2.Visible = false;
        }

        private void btn_girisYap_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sql = "select Yonetici_mail,Yonetici_sifre from tblYoneticiler where Yonetici_mail=@ymail AND Yonetici_sifre=@ysifre";
                SqlParameter prm1 = new SqlParameter("ymail", txt_kullanici_adi.Text.Trim());
                SqlParameter prm2 = new SqlParameter("ysifre", txt_sifre.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    Yonetici_Ekran yoneticiEkran = new Yonetici_Ekran();
                    yoneticiEkran.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Giriş reddedildi. Lütfen tekrar deneyiniz.");

            }
        }

        private void linkLabel_sifremiUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sifremi_unuttum sifUnut = new Sifremi_unuttum();
            sifUnut.Show();
            this.Hide();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Form1 anaForm = new Form1();
            anaForm.Show();
            this.Hide();
        }
    }
}
