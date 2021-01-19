using System;

namespace ClassOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.UrunKodu = "STOK01";
            urun1.UrunAdi = "ÜRÜN01";
            urun1.UrunFiyati = 111.11;

            Urun urun2 = new Urun();
            urun2.UrunKodu = "STOK02";
            urun2.UrunAdi = "ÜRÜN02";
            urun2.UrunFiyati = 222.22;

            Urun urun3 = new Urun();
            urun3.UrunKodu = "STOK03";
            urun3.UrunAdi = "ÜRÜN03";
            urun3.UrunFiyati = 333.33;

            Urun urun4 = new Urun();
            urun4.UrunKodu = "STOK04";
            urun4.UrunAdi = "ÜRÜN04";
            urun4.UrunFiyati = 444.44;

            Urun[] urunler = new Urun[] {urun1, urun2, urun3, urun4};

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.UrunKodu + " : " + urun.UrunAdi + " : " + urun.UrunFiyati);
            }

            Console.WriteLine("Foreach Döngüsü Bitti");


            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].UrunKodu + " + " + urunler[i].UrunAdi + " : " + urunler[i].UrunFiyati);
            }
            
            Console.WriteLine("For Döngüsü Bitti");


            int x = 0;
            while( x < urunler.Length )
            {
                Console.WriteLine(urunler[x].UrunKodu + " : " + urunler[x].UrunAdi + " : " + urunler[x].UrunFiyati);
                x++;
            }

            Console.WriteLine("While Loop Bitti");
        }
    }

    class Urun
    {
        public string UrunKodu { get; set; }
        public string UrunAdi { get; set; }
        public double UrunFiyati { get; set; }
    }
}
