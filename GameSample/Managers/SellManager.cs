using GameSample.Entities;
using GameSample.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSample.Managers
{
    class SellManager : ISellManager
    {
        public void SellingGames(IPerson gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " oyun satın aldı");
        }
        public void SellingCampaign(ICampaign campaign)
        {
            Console.WriteLine(campaign.CompaignName + " " + campaign.CompaignName + " kampanya satın aldı");
        }

    }
}
