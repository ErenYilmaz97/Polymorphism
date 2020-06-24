using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Sepet
    {
        private List<Urunler> urunler = new List<Urunler>();   //ÜRÜNLERİ TUTACAK LİSTE

        public double ToplamTutar()
        {
            double toplamtutar = 0;

            foreach (Urunler item in urunler)
            {
                toplamtutar += item.KdvUygula();  //LİSTEDEKİ HER ÜRÜNÜN KDV DAHİL FİYATINI HESAPLA, TOPLAMTUTARA EKLE
            }

            return toplamtutar;
        }

        public void Ekle(Urunler yeniurun)
        {
            urunler.Add(yeniurun);
        }
    }
}
