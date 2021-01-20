using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();//class örneği
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            //****stook takip sistemi

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)//in urunler :hepsini tek tek gezsin.Ekrana bassın.Başa döner tekar , o anki elemana isim takmak amacıyla urun ismi takarız Urun ise tipidir.Tipini veririz.var keywordü de Urun olduğunu anlar
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----------------");
            }

            Console.WriteLine("---------------Metotlar--------------");
            //instance - class örneği
            //encapsulation - tam olarak bir aşağıdaki olayy
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);  //metotlar reusability sağlar.
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12,5);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12,4);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12,3);

        }
    }
}
