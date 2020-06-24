using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
   public class CepTelefonu:Urunler
    {
        public string Ozellikler { get; set; }
        public string Marka { get; set; }

        public CepTelefonu(string ad, double fiyat, string marka)
        {
            this.UrunAdi = ad;
            this.Fiyat = fiyat;
            this.Marka = marka;
        }

        public override double KdvUygula()
        {
            return Fiyat * 1.18;
        }
    }
}
