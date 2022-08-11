using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //----------------------------------------------------------------------------------
            // credit

            // Burada "ICreditManager" olarak yazsaydık aynı sonuçları döndürür.
            // ICreditManager x = new TransportCreditManager();
            Console.WriteLine();

            TransportCreditManager transportCreditManager = new TransportCreditManager();
           // transportCreditManager.Calculate();
            
          //  Console.WriteLine();

            ConsumerLoanManager consumerLoanManager = new ConsumerLoanManager();
           // consumerLoanManager.Calculate();

           // Console.WriteLine();

            HousingLoanManager housingLoanManager = new HousingLoanManager();
            // housingLoanManager.Calculate();

            //-------------------------------------------------------------------------------
            // log
            ILoggerService dataBaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();


            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.Apply(transportCreditManager, dataBaseLoggerService);


            List<ICreditManager> credits = new List<ICreditManager>() {consumerLoanManager, transportCreditManager};
            //  applicationManager.GiveCreditPreInformation(credits);

            
        }
    }
}
