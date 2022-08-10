using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    // Eğer ki bir nesnede bir değeri kullanmak zorunda gibi görünmüyorsa, o nesneye ait değilmiş gibi duruyorsa o alan
    // demek ki orada soyutlama hatası yapıyoruz.
    class Customer
    {
        public int Id { get; set; }
        public string CustomerNumber { get; set; }
        
    }
}
