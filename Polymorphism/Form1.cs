using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polymorphism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Sepet sepet = new Sepet();
            Tekstil tekstil = new Tekstil("Tişört", 20, "Saten", 36);
            sepet.Ekle(tekstil);   //SEPETE EKLE


            CepTelefonu ceptelefonu = new CepTelefonu("S10+", 8000, "Samsung");  //AD FİYAT MARKA DEĞERLERİ GİRİLDİ.
            sepet.Ekle(ceptelefonu);  //SEPETE EKLE

            Ekmek ekmek = new Ekmek("Uno", 10, "Kepekli", 500);
            sepet.Ekle(ekmek);


            MessageBox.Show(sepet.ToplamTutar().ToString());   //EKMEĞİ %8KDVYE GÖRE, TELEFONU %18 KDVYE GÖRE, TEKSTİLİ %1 KDVYE GÖRE HESAPLAR.

        }
    }
}
