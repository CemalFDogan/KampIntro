using System;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {


            // Burada "ICreditManager" olarak yazsaydık aynı sonuçları döndürür.
            // ICreditManager x = new TransportCreditManager();
            Console.WriteLine();

            TransportCreditManager transportCreditManager = new TransportCreditManager();
           // transportCreditManager.Calculate();
            
            Console.WriteLine();

            ConsumerLoanManager consumerLoanManager = new ConsumerLoanManager();
           // consumerLoanManager.Calculate();

            Console.WriteLine();

            HousingLoanManager housingLoanManager = new HousingLoanManager();
            // housingLoanManager.Calculate();


            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.Apply(transportCreditManager);

        }
    }
}
