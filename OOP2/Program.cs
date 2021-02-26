using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cevat Sarıkaya
            Individual musteriI1 = new Individual();
            musteriI1.Id = 1;
            musteriI1.CostumerNumber = "12345";
            musteriI1.Name = "Cevat";
            musteriI1.Surname = "Sarıkaya";
            musteriI1.TcNumber = "12345678910";

            //Kodlama.io

            Coorporate musteriC2 = new Coorporate();
            musteriC2.Id = 2;
            musteriC2.CostumerNumber = "54963";
            musteriC2.CompanyName = "Kodlama.io";
            musteriC2.TaxId = "1234567890";

            Costumer musteri3 = new Individual();
            Costumer musteri4 = new Coorporate();

            CostumerManager costumerManager = new CostumerManager();
            costumerManager.Add(musteriI1);
            costumerManager.Add(musteriC2);


        }
    }
}
