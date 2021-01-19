using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD

=======
>>>>>>> 311be2011e65b77c0b629927bdeb391cf3db196d
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";
<<<<<<< HEAD

            Urun[] urunler = new Urun[] {urun1, urun2 };

            //Type safe -- tip güvenli
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("***************");
            }

            Console.WriteLine("------------Metotlar------------");
            //instance - örnek
            //encapsulation
=======
M
            Urun[] urunler = new Urun[] {urun1,urun2};

            foreach (var urun in urunler)
            {
                Console.WriteLine("urun.Adi");
                Console.WriteLine("urun.Fiyati");
                Console.WriteLine("urun.Aciklama");
                Console.WriteLine("------------------------");
            }

            Console.WriteLine("--------Metotlar---------");
>>>>>>> 311be2011e65b77c0b629927bdeb391cf3db196d

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
<<<<<<< HEAD

            sepetManager.Ekle2("Armut", "Santamaria", 12, 10);
            sepetManager.Ekle2("Elma", "Amasya elması", 12, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12, 8);

        }
    }
}


//Dont repeat yourself - DRY - Clean Code - Best Practice
=======
            
            sepetManager.Ekle2
            
            }
    }
}

//Dont repeat yourself - DRY - Clean Code - Best Practice
>>>>>>> 311be2011e65b77c0b629927bdeb391cf3db196d
