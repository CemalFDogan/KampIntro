using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        // Method injection
        public void Apply(ICreditManager creditManager, ILoggerService loggerService)
        {
            // Başvuru bilgilerini değerlendirme
            //
            creditManager.Calculate();
            loggerService.Log();
        }

        public void GiveCreditPreInformation(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
