using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNumber = "12345";
            customer1.CustomerFirstName = "Cemal Faruk";
            customer1.CustomerLastName = "DOĞAN";
            customer1.IdentityNumber = "2222222222";

            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CompanyName ="Kodlama.io";
            customer2.CustomerNumber = "54321";
            customer2.TaxNumber = "122333";


            // Gerçek Müşteri - Tüzel Müşteri
            // SOLID

            
            // Aşağıda customer3 ve customer4'ü Customer tipinde olmasına rağmen oluşturulan nesneler farklı bir kaynaktan
            // oluşturulabildi. Çünkü inheritance ile Customer class'ı base class oldu ve kendisinden yararlanan class'ların
            // da referans değerlerine ulaşabilir oldu.
            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            

        }
    }
}
