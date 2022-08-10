using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class HousingLoanManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Ev Kredisi hesaplandı.");
        }

        public void Repat()
        {
            throw new NotImplementedException();
        }
    }
}
