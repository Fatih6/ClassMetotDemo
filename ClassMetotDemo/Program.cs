using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Fatih";
            musteri1.SoyAdi = "Çalışkan";
            musteri1.Bakiye = 20000;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 1;
            musteri2.Adi = "Ali";
            musteri2.SoyAdi = "Taş";
            musteri2.Bakiye = 10000;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 1;
            musteri3.Adi = "Mehmet";
            musteri3.SoyAdi = "Demirel";
            musteri3.Bakiye = 50000;

            Musteri musteri4 = new Musteri();
            musteri4.Id = 1;
            musteri4.Adi = "Ayşe";
            musteri4.SoyAdi = "Gül";
            musteri4.Bakiye = 80000;

                MusteriManager musterimanager = new MusteriManager();
            musterimanager.Ekle(musteri1);
            musterimanager.Ekle(musteri2);
            musterimanager.Ekle(musteri3);
            musterimanager.Ekle(musteri4);

            Console.WriteLine("Müşteri Ekleme Bitti.");
            Console.WriteLine("------------------------");


            musterimanager.Sil(musteri1);
            musterimanager.Sil(musteri2);
            musterimanager.Sil(musteri3);
            musterimanager.Sil(musteri4);
            Console.WriteLine("Müşteri Silme Bitti.");
            Console.WriteLine("------------------------");

            Musteri[] musteriler = new Musteri[] {musteri1, musteri2, musteri3, musteri4 } ;

            musterimanager.Liste(musteriler);
            Console.WriteLine("Müşterileriniz Listelenmiştir.");
            Console.WriteLine("------------------------");
        }
    }
}
