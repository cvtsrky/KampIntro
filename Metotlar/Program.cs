using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };
            //type-safe -- tip güvenli
            foreach (Urun urun in urunler)
            {
                Console.WriteLine("Ürün adı: " + urun.Adi);
                Console.WriteLine("Ürün fiyatı: " + urun.Fiyati);
                Console.WriteLine("Ürün açıklaması: " + urun.Aciklama);
                Console.WriteLine("-----------------------------------");

            }

            Console.WriteLine("-----------------Metotlar----------------------");

            //instance - örnek
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12,10);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12,15);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12,11);

        }
    }
}
