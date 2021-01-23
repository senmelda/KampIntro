using System;

namespace Gun4_MyDictionary_Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int> sayilar = new MyDictionary<int>();
            sayilar.Add(79);
            Console.WriteLine(sayilar);
        }
    }
}
