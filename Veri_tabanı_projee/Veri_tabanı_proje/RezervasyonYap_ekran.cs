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
    public partial class RezervasyonYap_ekran : Form
    {
        public RezervasyonYap_ekran()
        {
            InitializeComponent();
        }
        string reztip;

        //reyyan SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-56SRHAG;Initial Catalog=otel_rezervasyon;Integrated Security=True");
        //sena SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-52OSE7G;Initial Catalog=otel_rezervasyon;Integrated Security=True");
        SqlConnection baglanti = new SqlConnection("Data Source = DESKTOP-N6SCB07; Initial Catalog = otel_rezervasyon; Integrated Security = True");

        private void btnRezerveEt_Click(object sender, EventArgs e)
        {

            if (rbOnOdemeRez.Checked == true)
            {
                reztip = "Ön Ödemeli";
            }
            else if (rb60GunOncedenRez.Checked == true)
            {
                reztip = "60 Gün Önceden";
            }
            else if (rbStandartRez.Checked == true)
            {
                reztip = "Standart";
            }
            else if (rbTesvikRez.Checked == true)
            {
                reztip = "Teşvik";
            }

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into tblMusteriler (musteri_adi,musteri_soyadi,musteri_mail,musteri_tel) " +
              "values ('" + txtAd.Text.ToString() + "','" + txtSoyad.Text.ToString() + "','" + txtMail.Text.ToString() + "','" + txtTelefon.Text.ToString() + "')   ", baglanti);

            SqlCommand komut2 = new SqlCommand("insert into tblRezervasyon (giris_tarihi,cikis_tarihi,rezervasyon_tip_adi) " +
              "values ('" + dtpGirisTarih.Value.ToString("yyyy-MM-dd") + "','" + dtpCikisTarih.Value.ToString("yyyy-MM-dd") + "','" + reztip.ToString() + "') ", baglanti);
            komut.ExecuteNonQuery();
            komut2.ExecuteNonQuery();
            TimeSpan fark = dtpGirisTarih.Value - DateTime.Now;


            if ((reztip == "Ön Ödemeli" && (fark.TotalDays) > 90)||(reztip == "60 Gün Önceden" && (fark.TotalDays) > 60)|| reztip == "Teşvik" || reztip == "Standart")
            {
                Odeme_Yap odeme_Yap = new Odeme_Yap();
                odeme_Yap.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı giriş\nÖn Ödeme için 90 gün önceden rezervasyon almalısınız");

            }

            baglanti.Close();





        }

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            Form1 anaForm = new Form1();
            anaForm.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("->Ön ödemeli rezervasyon yapmak için en az 90 gün önceden rezevasyon yapmanız gerekir.Bu rezervasyon tipinde iptal işleminde geri ödeme yoktur fakat ek bir ücretle rezervasyon günü değiştirilebilir.\n" +
                "->60 gün önceden yapılan rezervasyon tipinde konaklama günlerinden 30 ila 45 gün içinde ödeme yapılması gereklidir aksi takdirde rezervasyon iptal edilir.\n" +
                "->Standart rezervasyon tipinde ödeme konaklama sonunda alınır ve eğer konaklamaya 3 günden az bir zaman kala iptal edilirse veya konaklamanın ilk günü otele gelinmezse karttan ceza fiyatı çekilir.Bu rezervasyon tipi herhangi bir zamanda yapılabilir ve değiştirilebilir.\n" +
                "->Teşvik rezervasyon tipinde ücret konaklama sonunda ödenir, iptal ve gün değiştirme konuları standart rezervasyondaki gibidir.Kalınacak her gece için oda fiyatları değişebilir ve bu değişim mevcut bir rezervasyonu etkilemez.");
        }
    }
}