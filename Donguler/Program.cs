using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);

            //array

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı",
                "Programlamaya başlangıç için temel kurs","Java" ,"C++"};


            for (int i = 1; i < Kurs.Length; i++)
            { 
                Console.WriteLine(kurslar[i]);
            }

            foreach (string [xyz] in kurslar);
            {
                Console.WriteLine();
            }

            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
