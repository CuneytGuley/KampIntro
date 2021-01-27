using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IOperationManager
    {
        void Sell(Games games, Gamer gamer);
        void CampaignSell(Games games, Kampanya kampanya, Gamer gamer );
    }

    class Sale : IOperationManager
    {
        public void CampaignSell(Games games, Kampanya kampanya, Gamer gamer)
        {
            throw new NotImplementedException();
        }

        public void Sell(Games games, Gamer gamer)
        {
            Console.WriteLine(games.GameName + " isimli oyun " + gamer.FirstName + " " + gamer.LastName + " satılmıştır.");
        }
    }

    class CampaignSale : IOperationManager
    {
        public void CampaignSell(Games games, Kampanya kampanya, Gamer gamer)
        {
            Console.WriteLine(games.GameName + " isimli oyun " + kampanya.KampanyaName + " ile " + gamer.FirstName + " " + gamer.LastName + " satılmıştır.");
        }

        public void Sell(Games games, Gamer gamer)
        {
            throw new NotImplementedException();
        }
    }

}
