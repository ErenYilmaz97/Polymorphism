using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Ekmek:Urunler
    {
        public string EkmekTuru { get; set; }
        public int Gramaj { get; set; }

        public Ekmek(string ad, double fiyat, string ekmekturu, int gramaj)
        {
            this.UrunAdi = ad;
            this.Fiyat = fiyat;
            this.EkmekTuru = ekmekturu;
            this.Gramaj = gramaj;
        }

        public override double KdvUygula()
        {
            return Fiyat * 1.08;
        }
    }
}
