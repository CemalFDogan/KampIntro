using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kursu";
            string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";
            string kurs5 = "C#";

            Console.WriteLine("MANUEL olarak çalışan kodlar" + "\n");

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            Console.WriteLine(kurs5);

            Console.WriteLine("********************");

            // Array - Diziler

            string[] kurslar = new string[] {"Yazılım Geliştirici Yetiştirme Kursu", 
                "Programlamaya Başlangıç İçin Temel Kurs", 
                "Java", "Python", "C#" };

            Console.WriteLine("DİNAMİK olarak çalışan kodlar" +"\n");

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For döngüsü bitti" + "\n" + "**********");

            Console.WriteLine("Foreach Döngüsü");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
