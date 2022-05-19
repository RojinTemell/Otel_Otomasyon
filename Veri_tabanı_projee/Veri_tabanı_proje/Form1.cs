using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veri_tabanı_proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_yoneticiGiris_Click(object sender, EventArgs e)
        {

        }

        private void btn_rezervYap_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_rezervasyonYap_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_yoneticiGirisi_Click(object sender, EventArgs e)
        {
         
        }

        private void btn_yoneticiGirisi_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btn_rezervasyon_yap_Click(object sender, EventArgs e)
        {
        }

        private void btn_yoneticiGirisi_Click_2(object sender, EventArgs e)
        {
            Yönetici_giris yonetici_giris = new Yönetici_giris();
            yonetici_giris.Show();
            this.Hide();
        }

        private void btn_rezervasyon_yap_Click_1(object sender, EventArgs e)
        {
            RezervasyonYap_ekran rezervasyonYap = new RezervasyonYap_ekran();
            rezervasyonYap.Show();
            this.Hide();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
