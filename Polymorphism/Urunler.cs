using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Urunler
    {
        public string UrunAdi { get; set; }
        public double Fiyat { get; set; }

        public virtual double KdvUygula()
        {
            return Fiyat * 1.08;
        }

        public Urunler(string ad,Double fiyat)
        {
            this.UrunAdi = ad;
            this.Fiyat = fiyat;
        }

        public Urunler()
        {

        }
    }
}
