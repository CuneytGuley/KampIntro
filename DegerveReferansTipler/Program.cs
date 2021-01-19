using System;

<<<<<<< HEAD
namespace DegerVeReferansTipler
=======
namespace DegerveReferansTipler
>>>>>>> 311be2011e65b77c0b629927bdeb391cf3db196d
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;

<<<<<<< HEAD
            Console.WriteLine(sayi1);

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;

            Console.WriteLine(sayilar1[0]);

            //int,decimal,float,bool değer tipi değişkenler
            //array, class, interface referans tip değişkenler
            //sayilar1 = sayilar2 dediğimizde iki array in referans değerlerini yani bellekteki adreslerini eşitliyor
=======
>>>>>>> 311be2011e65b77c0b629927bdeb391cf3db196d
            

        }
    }
}
