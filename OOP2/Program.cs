using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Engin Demiroğ
            GercekMusteri muster1 = new GercekMusteri();
            muster1.Id = 1;
            muster1.MusteriNo = "12345";
            muster1.Adi = "Engin";
            muster1.Soyadi = "Demiroğ";
            muster1.TcNo = "12345678910";

            //kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";


            //Gerçek Müşteri - Tüzel Müşteri ikisi farklı müşterilerdir.
            //SOLID


            Musteri musteri3 = new GercekMusteri();//new : bellekteki referans no Musteri hem gercekmusterinin hemde tuzelmusterinin referansını tutabiliyor.
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Ekle(muster1);
            customerManager.Ekle(musteri2);
        }
    }
}
