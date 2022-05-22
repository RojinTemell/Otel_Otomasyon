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
    public partial class Odeme_Yap : Form
    {
        public Odeme_Yap()
        {
            InitializeComponent();
        }

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
    }
}
