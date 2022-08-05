using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
               int, decimal, float, double, bool --> Değer Tip 
               array, class, interface --> Referans Tip

             */

            int sayi1 = 10;
            int sayi2 = 30;

            sayi1 = sayi2;

            sayi2 = 65;
            // sayi1 = ?? --> 30


            int[] sayilar1 = new int[] {10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };

            sayilar1 = sayilar2;

            sayilar2[0] = 999;
            // sayilar1[0] = ?? --> 999 ---> Çünkü sayilar1 dizisinin referans aldığı değeri değiştirdik.
            //                               Yani sayilar2 dizisinin referans değerini sayilar1' e atamış olduk.
            //                               Bu durumda beslendikleri kaynak aynı ve bu yüzden sayılar2[0] değeri
            //                               değişince sayilar1'in de 0. indeksi 999 olur.

            foreach (var sayi in sayilar1)
            {
                Console.WriteLine("sayilar1 :" + sayi);
            }

            Console.WriteLine("***************");

            foreach (var sayi in sayilar2)
            {
                Console.WriteLine("sayilar2 :" + sayi);
            }

        }
    }
}
