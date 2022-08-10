using System;

namespace Kampİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // type safety - tip güvenliği
            // Do not repeat yourself - Kendini tekrarlama
            // Değer tutucu, alias

            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 8.45;
            double dolarBugun = 8.55;

            if (dolarBugun < dolarDun)
            {
                Console.WriteLine("Dolar DÜŞMÜŞ sembolü");
            }
            else if (dolarBugun > dolarDun)
            {
                Console.WriteLine("Dolar YÜKSELMİŞ sembolü");
            }
            else
            {
                Console.WriteLine("Dolar SABİT sembolü");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);
        }
    }
}
