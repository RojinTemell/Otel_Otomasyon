using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veri_tabanı_proje
{
    public class StandartRezervasyon:RezervasyonTipi
    {
        public override double OdemeFiyati(double TabanFiyat)
        {
            Fiyat = TabanFiyat;
            return Fiyat;
        }
    }
}
