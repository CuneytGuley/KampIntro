using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer() { Id = 1, TcNo = "12345678901", FirstName = "Adem", LastName = "Aksoy", Birth = 2001 };
            Gamer gamer2 = new Gamer() { Id = 2, TcNo = "23456789012", FirstName = "Asrın", LastName = "Çıkrıkçı", Birth = 2002 };
            Gamer gamer3 = new Gamer() { Id = 3, TcNo = "34567890123", FirstName = "Kerim", LastName = "Şahin", Birth = 1994 };

            Games games1 = new Games() { GameId = 1, GameName = "Game 1", GameFiyat = 165.00 };
            Games games2 = new Games() { GameId = 2, GameName = "Game 2", GameFiyat = 125.75 };
            Games games3 = new Games() { GameId = 3, GameName = "Game 3", GameFiyat = 99.50 };

            Kampanya kampanya1 = new Kampanya() { KampanyaId = 1, KampanyaName = "Öğrenci kampanyası", IndirimOranı = 0.25 };
            Kampanya kampanya2 = new Kampanya() { KampanyaId = 2, KampanyaName = "Tatil kampanyası", IndirimOranı = 0.35 };
            Kampanya kampanya3 = new Kampanya() { KampanyaId = 3, KampanyaName = "Black Friday kampanyası", IndirimOranı = 0.50 };

            Console.WriteLine("Hello World!");
            Console.WriteLine("                                                         ");

            Register register = new Register();
            register.CheckDevlet(gamer1);
            register.Add(gamer1);
            register.Delete(gamer2);
            register.CheckDevlet(gamer3);
            register.Update(gamer3);

            Console.WriteLine("                                                         ");

            KampanyaManager kampanyaManager = new KampanyaManager();
            kampanyaManager.Add(kampanya1);
            kampanyaManager.Delete(kampanya2);
            kampanyaManager.Update(kampanya3);


        }
    }
}