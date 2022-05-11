using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veri_tabanı_proje
{
    public class Yonetici
    {
        public string Ad { get;private set; }
        public string Soyad { get; private set; }
        public string Sifre { get { return sifre; } set { sifre = value; } }
        private string sifre;
        public string Mail { get { return mail; } set { mail = value; } }
        private string mail;

        private List<Musteri> musteri;
        private List<Calisan> calisan;
        public Yonetici()
        {
            musteri = new List<Musteri>();
            calisan = new List<Calisan>();

        }

       
    }
}
