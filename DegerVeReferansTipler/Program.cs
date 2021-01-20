using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);//30

            int[] sayilar1 = new int[] { 10,20,30};
            int[] sayilar2 = new int[] { 100,200,300};
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            Console.WriteLine(sayilar1[0]);//999

            //int,decimal,float,double,bool = değer tipi
            //array,class,interface = referans tipi

            //stack and heap
            //sayi1=10 stackte gerçekleşir
            //sayi2=30 stackte gerçekleşir
            //sayilar1 stackte new denildiği anda heapte bir alan oluştur ve değerleri oraya yaz demektir.
            //heap[10,20,30]-101 == stack sayilar1-101
            //stack sayilar2 - 102 == heap [100,200,300] - 102
            //sayilar1 = sayilar2 dediğin anda 101 adresini 102 yapar . 101 ile bağlantısı kesilir.
            //sayilar2 nin 0. elemanını 999 yapıyorsun.
            //sayilar1 102 adresini tuttuğu için [0]. elemanı 999 olur
            //garbage collector diğer 101 adresini siler çünkü artık stackte bunu tutan yok.
            //---------YAZILIMDA EN ÖNEMLİ OLAY SÜRDÜRÜLEBİLİRLİKTİR!!!!-------------
        }
    }
}
