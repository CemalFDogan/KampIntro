using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class TransportCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Taşıt Kredisi hesaplandı.");
        }

        public void Repat()
        {
            throw new NotImplementedException();
        }
    }
}
