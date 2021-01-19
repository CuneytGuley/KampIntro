using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.TcNo = 12345678901;
            musteri1.Adi = "Ahmet";
            musteri1.Soyadi = "Karaçam";
            musteri1.Yasi = 41;
            musteri1.TelNo = 5324551111;

            Musteri musteri2 = new Musteri();
            musteri2.TcNo = 23456789012;
            musteri2.Adi = "Serdar";
            musteri2.Soyadi = "Yeşilçam";
            musteri2.Yasi = 42;
            musteri2.TelNo = 5324553333;

            Musteri musteri3 = new Musteri();
            musteri3.TcNo = 34567890123;
            musteri3.Adi = "Ali";
            musteri3.Soyadi = "Şahin";
            musteri3.Yasi = 43;
            musteri3.TelNo = 5324554444;

            Musteri musteri4  = new Musteri();
            musteri4.TcNo = 45678901234;
            musteri4.Adi = "Cengiz";
            musteri4.Soyadi = "Atmaca";
            musteri4.Yasi = 44;
            musteri4.TelNo = 5324556666;

            Musteri musteri5 = new Musteri();
            musteri5.TcNo = 56789012345;
            musteri5.Adi = "Veli";
            musteri5.Soyadi = "Kara";
            musteri5.Yasi = 45;
            musteri5.TelNo = 5324557777;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4, musteri5 };

            HesapManager hesapManager = new HesapManager();
            foreach (var musteri in musteriler)
            {
                hesapManager.Liste(musteri);
            }

            Console.WriteLine("         ");
            Console.WriteLine("Liste Sonu!");

            Console.WriteLine("Hesap Açılışı");
            Console.WriteLine("         ");
            hesapManager.Ekle(musteri1);

            hesapManager.Silme(musteri5);


        }
    }
}
