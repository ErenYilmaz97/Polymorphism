using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Tekstil:Urunler
    {
        public string KumasTuru { get; set; }
        public int Beden { get; set; }
        public string UreticiFirma { get; set; }

        public Tekstil(string ad, double fiyat,string kumas, int beden)
        {
            this.UrunAdi = ad;
            this.Fiyat = fiyat;
            this.KumasTuru = kumas;
            this.Beden = beden;
        }

        public override double KdvUygula()
        {
            return Fiyat * 1.01;
        }
    }
}
