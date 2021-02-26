using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //PersonelFinanceCreditManager personelFinanceCreditManager = new PersonelFinanceCreditManager();
            //personelFinanceCreditManager.Calculate();

            //CarCreditManager carCreditManager = new CarCreditManager();
            //carCreditManager.Calculate();

            //HouseCreditManager houseCreditManager = new HouseCreditManager();
            //houseCreditManager.Calculate();

            //Console.WriteLine("------------------interface ile-----");
            ////Interface alınan sınıf, alan sınıfın referansını tutabilir.
            ICreditManager personelFinanceCreditManager1 = new PersonelFinanceCreditManager();
            //personelFinanceCreditManager1.Calculate();

            ICreditManager carCreditManager1 = new CarCreditManager();
            //carCreditManager1.Calculate();

            ICreditManager houseCreditManager1 = new HouseCreditManager();
            //houseCreditManager1.Calculate();
            //Console.WriteLine("----interface referans gönderimiyle-----");
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();


            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.DoApplication(personelFinanceCreditManager1,fileLoggerService);
            //applicationManager.DoApplication(carCreditManager1);
            //applicationManager.DoApplication(houseCreditManager1);

            List<ICreditManager> credits = new List<ICreditManager>() {personelFinanceCreditManager1, carCreditManager1, houseCreditManager1 };

            //applicationManager.CreditPreView(credits);
        }
    }
}
