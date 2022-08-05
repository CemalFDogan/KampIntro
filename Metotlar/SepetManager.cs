using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        // naming convention
        // syntax
        public void Ekle(Product urun) 
        {
            Console.WriteLine($"Tebrikler! {urun.Adi} sepete eklendi.");
        }

        public void Ekle2(string urunAdi, string açiklama, double fiyat, int stokAdeti)
        {
            Console.WriteLine($"Tebrikler! {urunAdi}, {açiklama}, {fiyat}₺ sepete eklendi.");
        }
    }
}
