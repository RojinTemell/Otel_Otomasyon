using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veri_tabanı_proje
{
    public  class Rezervasyon
    {
        private List<RezervasyonTipi> rezervasyonTip=new List<RezervasyonTipi>();
        public Rezervasyon(List<RezervasyonTipi> rezervasyonTip)
        {
            this.rezervasyonTip= rezervasyonTip;
        }
    }
}
