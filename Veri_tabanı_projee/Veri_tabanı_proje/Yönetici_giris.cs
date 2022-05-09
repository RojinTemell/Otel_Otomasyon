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
    public partial class Yönetici_giris : Form
    {
        public Yönetici_giris()
        {
            InitializeComponent();
        }

        private void btn_yoneticiGiris_Click(object sender, EventArgs e)
        {
            if(txtbox_yoneticiMail.Text=="" || txtbox_yoneticiSifre.Text=="")
            {
                MessageBox.Show("Lütfen alanları doldurunuz!");
            }
            else if((txtbox_yoneticiMail.Text== "reyyan@gmail.com") && (txtbox_yoneticiSifre.Text=="reyyan"))
            {
                MessageBox.Show("Başarıyla giriş yaptınız!");
                Yonetici_Ekran yonetici_ekran = new Yonetici_Ekran();
                yonetici_ekran.Show();
                this.Hide();
            }
            else if ((txtbox_yoneticiMail.Text == "sena@gmail.com") && (txtbox_yoneticiSifre.Text == "sena"))
            {
                MessageBox.Show("Başarıyla giriş yaptınız!");
                Yonetici_Ekran yonetici_ekran = new Yonetici_Ekran();
                yonetici_ekran.Show();
                this.Hide();
            }
            else if ((txtbox_yoneticiMail.Text == "rojin@gmail.com") && (txtbox_yoneticiSifre.Text == "rojin"))
            {
                MessageBox.Show("Başarıyla giriş yaptınız!");
                Yonetici_Ekran yonetici_ekran = new Yonetici_Ekran();
                yonetici_ekran.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Lütfen bilgileri doğru giriniz!");
            }
        }
        
    }
}
