using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention - metotlar büyük harfle başlar Orn: Ekle
        //syntax
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler. " + urun.StokAdedi + "  adet  " + urun.Adi + "  Sepete eklendi. ");
        }


        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urunAdi);
        }
         
        


    }
}
