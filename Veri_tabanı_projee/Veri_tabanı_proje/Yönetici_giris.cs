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

        }
    }
}
