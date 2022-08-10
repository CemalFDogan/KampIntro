using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        public void Apply(ICreditManager creditManager)
        {
            // Başvuru bilgilerini değerlendirme
            //
            creditManager.Calculate();
        }
    }
}
