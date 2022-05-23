using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veri_tabanı_proje
{
    public abstract class RezervasyonTipi
    {
        public DateTime GirisTarihi { get; set; }
        public DateTime CikisTarihi { get; set; }
        public Musteri Ad { get; set; }
        public Musteri Soyad { get; set; }
        public Musteri Mail { get; set; }
        public Musteri TelefonNo { get; set; }
        public double Fiyat { get; set; }
        public double TabanFiyat{ get; set; }
        public RezervasyonTipi( )
        {

        }
        public virtual double OdemeFiyati(double TabanFiyat)
        {
            return Fiyat;
        }
    }
}
