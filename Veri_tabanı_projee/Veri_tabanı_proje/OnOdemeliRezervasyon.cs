using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Veri_tabanı_proje
{
    public class OnOdemeliRezervasyon : RezervasyonTipi
    {
        public override double OdemeFiyati(double TabanFiyat)
        {
            Fiyat = TabanFiyat*0.75;
            return Fiyat;
        }
    }
}
