using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veri_tabanı_proje
{
    public class IRezervasyonTipi
    {
        public DateTime GirisTarihi { get; set; }
        public DateTime CikisTarihi { get; set; }
        public Musteri Ad { get; set; }
        public Musteri Soyad { get; set; }
        public Musteri TelefonNo { get; set; }
    }
}
