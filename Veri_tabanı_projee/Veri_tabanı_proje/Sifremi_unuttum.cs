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
    public partial class Sifremi_unuttum : Form
    {
        public Sifremi_unuttum()
        {
            InitializeComponent();
        }
        //reyyan SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-56SRHAG;Initial Catalog=otel_rezervasyon;Integrated Security=True");
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-52OSE7G;Initial Catalog=otel_rezervasyon;Integrated Security=True");
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
        }

        private void Sifremi_unuttum_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
        }

        private void btn_girisYap_Click(object sender, EventArgs e)
        {
            sifremiUnuttum(txtbox_kullanici_adi,txtbox_sifre,txtbox_sifreTekrar);
        }
        SqlCommand komut;
        SqlDataReader read;
        public void sifremiUnuttum(Bunifu.Framework.UI.BunifuMaterialTextbox kullanıcıAd, Bunifu.Framework.UI.BunifuMaterialTextbox sifre, Bunifu.Framework.UI.BunifuMaterialTextbox sifreTekrar)
        {
            if (sifre.Text == sifreTekrar.Text)
            {
                baglanti.Open();
                komut = new SqlCommand("select *from tblYoneticiler where Yonetici_mail= '" + kullanıcıAd.Text + "'", baglanti);
                read = komut.ExecuteReader();
                if (read.Read() == true)
                {
                    baglanti.Close();
                    baglanti.Open();
                    komut = new SqlCommand("update tblYoneticiler set Yonetici_sifre='" + sifre.Text + "' where Yonetici_mail= '" + kullanıcıAd.Text + "'", baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Şifreniz başarıyla değiştirildi.", "Başarılı!");
                    Yönetici_giris anaForm = new Yönetici_giris();
                    anaForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Bilgilerinizi kontrol ediniz.", "Hata");
                }
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("Şifreler uyuşmuyor ya da boş bıraktınız.", "Uyarı");
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Form1 anaForm = new Form1();
            anaForm.Show();
            this.Hide();
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
