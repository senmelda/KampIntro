using System;

namespace sınıfdeneme
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.UrunAdi = "Spor Ayakkabı";
            urun1.UrunFiyat = 125;
            urun1.Kategori = "Ayakkabı";

            Urun urun2 = new Urun();
            urun2.UrunAdi = "Suç ve Ceza";
            urun2.UrunFiyat = 25;
            urun2.Kategori = "Kitap";

            Urun urun3 = new Urun();
            urun3.UrunAdi = "Çalışma Masası";
            urun3.UrunFiyat = 225;
            urun3.Kategori = "Ev ve Yaşam";

            Urun urun4 = new Urun();
            urun4.UrunAdi = "Saç Kurutma Makinesi";
            urun4.UrunFiyat = 87;
            urun4.Kategori = "Saç Makineleri ve Aksesuarları";

            Urun urun5 = new Urun();
            urun5.UrunAdi = "Ortopedik Yastık";
            urun5.UrunFiyat = 154;
            urun5.Kategori = "Ev ve Yaşam";

            Urun[] urunler = new Urun[]
            {
      urun1,urun2,urun3,urun4,urun5
            };

            for (int i = 0; i <= urunler.Length; i++)
            {
                Console.WriteLine("Ürünün Adı: " + urunler[i].UrunAdi);
                Console.WriteLine("Ürünün Fiyatı : " + urunler[i].UrunFiyat);
                Console.WriteLine("Kategori : " + urunler[i].Kategori);
            }

            foreach (var urun in urunler)
            {
                Console.WriteLine("ÜRÜN ADI : " + urun.UrunAdi + "\nÜRÜN FİYATI : " + urun.UrunFiyat + "\nKATEGORİ :  " + urun.Kategori);
            }
            
            int j = 0;
            while (j < urunler.Length)
            {
                Console.WriteLine("Ürün adı: " + urunler[j].UrunAdi);
                Console.WriteLine("Ürün fiyatı: " + urunler[j].UrunFiyat);
                Console.WriteLine("Kategori: " + urunler[j].Kategori);
                j++;
            }
        }
    }

    class Urun
    {
        public string UrunAdi { get; set; }
        public int UrunFiyat { get; set; }
        public string Kategori { get; set; }
    }
}
