using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class KampanyaManager
    {
        public void Add(Kampanya kampanya) 
        {
            Console.WriteLine(kampanya.KampanyaName + " kampanyası tanımlanmıştır");
        }

        public void Delete(Kampanya kampanya) 
        {
            Console.WriteLine(kampanya.KampanyaName + " kampanyası silinmiştir");
        }

        public void Update(Kampanya kampanya) 
        {
            Console.WriteLine(kampanya.KampanyaName + " kampanyası güncellenmiştir");
        }

    }
}
