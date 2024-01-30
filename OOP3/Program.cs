using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        //interfacelerde o interfacei implemente eden classın ref no tutabilmektedir.
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
       
            IKrediManager tasitKrediManager = new TasitKrediManager();
       
            IKrediManager konutKrediManager = new KonutKrediManager();

            BasvuruManager basvuruManager = new BasvuruManager();

            //ya da aşağıdaki gibi de atayabiliriz.
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            //basvuru yap içine kullanacağın loggerı newleyerek de atayabiliriz. new DatabaseLogger() da yazılabilirdi.

            List<ILoggerService> loggers = new List<ILoggerService> { new DatabaseLoggerService(), new FileLoggerService(), new SmsLoggerService() };

            basvuruManager.BasvuruYap(new EsnafKredisiManager(), loggers);
                 //polymorfizm

            
           //basvuruManager.KrediLogBilgilendirmesiYap(loggerService);
            

          
          
            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager, konutKrediManager };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

            //basvuruManager.BasvuruYap(new EsnafKredisiManager(), new List<ILoggerService>
            //{
            //    new DatabaseLoggerService(),
            //    new SmsLoggerService()
            //}


        }
    }
}