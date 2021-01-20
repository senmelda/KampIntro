using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention
        //syntax
        public void Ekle(Urun urun)//Urun tipi.urun ismi Bu adım bizim ürün eklememizi sağlar.(Urun urun)
        {
            Console.WriteLine("Tebrikler.Sepete Eklendi." + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler.Sepete Eklendi." + urunAdi);
        }
    }
}


//Manager : bir operasyon tutuyor demektir.
//Sepetle ilgili işlemler gibi

//python da metot def ile yapılır