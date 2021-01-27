using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    abstract class GamerService
    {
        public abstract void Add(Gamer gamer);
        public abstract void Delete(Gamer gamer);
        public abstract void Update(Gamer gamer);

        public void CheckDevlet(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " adlı kişi MERNİS e kayıtlıdır.");
        }
    }
    class Register : GamerService
    {
        public override void Add(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " eklendi. ");
        }

        public override void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " silindi. ");
        }

        public override void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " güncellendi. ");
        }

    }


}
