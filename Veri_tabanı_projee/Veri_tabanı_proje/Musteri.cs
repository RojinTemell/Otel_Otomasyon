using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veri_tabanı_proje
{
    public class Musteri
    {
        public string Ad { get; private set; }
        public string Soyad { get; private set; }
        public string Mail { get { return mail; } set { mail = value; } }
        private string mail;
        public short CVV { get { return cvv; } set { cvv = value; } }
        private short cvv;
        public short SKT { get { return skt; } set { skt = value; } }
        private short skt;
        public long Hesapno { get { return hesapno; } set { hesapno = value; } }
        private long hesapno;

        public Musteri()
        { }
        
        
    }
}
