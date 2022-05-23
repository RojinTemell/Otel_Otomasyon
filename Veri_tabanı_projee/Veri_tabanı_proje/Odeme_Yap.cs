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
    public partial class Odeme_Yap : Form 
    {
        public Odeme_Yap()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-56SRHAG;Initial Catalog=otel_rezervasyon;Integrated Security=True");
        //sena SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-52OSE7G;Initial Catalog=otel_rezervasyon;Integrated Security=True");
        //rojin SqlConnection baglanti = new SqlConnection("Data Source = DESKTOP-N6SCB07; Initial Catalog = otel_rezervasyon; Integrated Security = True");
        private void lblSKT_Click(object sender, EventArgs e)
        {

        }

        private void txtKrediKartNo_MouseClick(object sender, MouseEventArgs e)
        {
            txtKrediKartNo.Text = "";
        }

        private void txtCVV_MouseClick(object sender, MouseEventArgs e)
        {
            txtCVV.Text = "";
        }
        int TabanFiyat;
        int Tutar;
        public void tutarHesapla()
        {

            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select * from tblOdalar where oda_taban_fiyat=@tabanFiyat");
            SqlParameter prm1 = new SqlParameter("tabanFiyat", TabanFiyat);
            cmd.Parameters.Add(prm1);
            Tutar = Convert.ToInt32(TabanFiyat * 0.85);
            baglanti.Close();

        }
       

        private void btnKaydet_Click_1(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into tblKartBilgileri (kart_numarasi,kart_cvv,kart_skt_ay,kart_skt_yil) values ('" + txtKrediKartNo.Text.ToString() + "','" + txtCVV.Text.ToString() + "','" + cmbAy.Text.ToString() + "','" + cmbYıl.Text.ToString() + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kart bilgileri eklendi.\n Ödeme yapabilirsiniz.");
            txtCVV.Clear();
            txtKrediKartNo.Clear();
            if (rb60GunOncedenRez.Checked == true)
            {
                tutarHesapla();
                txtTutar.Text = Tutar.ToString();
            }
            else if (rbOnOdemeRez.Checked == true)
            {

            }
            else if (rbStandartRez.Checked == true)
            {

            }
            else if (rbTesvikRez.Checked == true)
            {

            }
            else
            {
                MessageBox.Show("Seçim yaptığınızdan emin olun.");
            }
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            RezervasyonYap_ekran rz = new RezervasyonYap_ekran();
            rz.Show();
            this.Hide();
        }

        private void btnHemenOde_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ödemeniz alınmıştır.");
        }
    }
}
