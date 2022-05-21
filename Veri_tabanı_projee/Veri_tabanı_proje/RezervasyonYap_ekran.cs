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

        //reyyan SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-56SRHAG;Initial Catalog=otel_rezervasyon;Integrated Security=True");
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-52OSE7G;Initial Catalog=otel_rezervasyon;Integrated Security=True");
        private void btn_rezervYap_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rezervasyonunuz başarıyla yapıldı!");
            this.Close();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Form1 anaForm = new Form1();
            anaForm.Show();
            this.Hide();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }
    }
}
