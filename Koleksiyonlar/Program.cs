using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------Array------------");

            string[] isimler = new string[] { "Engin", "Kerem", "Murat", "Halil" };

            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);

            isimler = new string[5];        // Burada aynı ada sahip başka bir array oluşturduğumuz için 
            isimler[4] = "İlker";           // sonradan atadığımız 4. indeksteki İlker'i yazdı ama
            Console.WriteLine(isimler[4]);  // en başında tanımlamış olduğumuz şeylere ulaşamıyoruz.
            Console.WriteLine(isimler[0]);

            Console.WriteLine("----------------------List-------------");

            //List<string> isimler2 = new List<string>();     // 1. YOL
            //isimler2.Add("Engin");

            List<string> isimler2 = new List<string> { "Engin", "Kerem", "Murat", "Halil" };

            Console.WriteLine("\n" + "Yeni eleman eklenmeden önce");

            foreach (string isim in isimler2)
            {
                Console.WriteLine(isim);
            }

            Console.WriteLine("\n" + "Yeni eleman eklendikten sonra");

            isimler2.Add("Cemal");
            foreach (string isim in isimler2)
            {
                Console.WriteLine(isim);
            }
        }
    }
}
