using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager İhtiyacKrediManager = new IhtiyacKrediManager();
            

            IKrediManager tasitKrediManager = new TasitKrediManager();
            

            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(tasitKrediManager,  new FileLoggerService());

            List<IKrediManager> krediler = new List<IKrediManager>() {İhtiyacKrediManager, tasitKrediManager };
           //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}


//Interfaceleri birbirinin alternatifi olan ama kod içerikleri farklı olan içerikler için kullanırız.