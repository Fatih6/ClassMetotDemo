using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi +" " + musteri.SoyAdi + " : " + "İsimli Müşteriniz Eklenmiştir.");
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " " + musteri.SoyAdi + " : " + "İsimli Müşteriniz Silinmiştir.");
        }
        public void Liste(Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Adi + " " + musteri.SoyAdi);
            }
        }
    }
}
