using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class HesapManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + "  adına hesap açılmıştır. " );
            Console.WriteLine("         ");
        }

        public void Liste(Musteri musteri)
        {
            Console.WriteLine(musteri.TcNo + " ; " + musteri.Adi + " ; " + musteri.Soyadi + " ; " + musteri.TelNo + " ; " + musteri.Yasi);
            Console.WriteLine("******************************************************************************");
        }

        public void Silme(Musteri musteri) 
        {
            Console.WriteLine("Hesap Silme İşlemi");
            Console.WriteLine("         ");
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + "  hesabı kapatılmıştır. ");
        }


    } 
}
