using GameSample.Entities;
using GameSample.Interfaces;
using GameSample.Managers;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer();
            gamer.FirstName = "Engin";
            gamer.LastName = "Demiroğ";
            gamer.TcNo = "1248461321655";
            gamer.BirthDay = 1990;

            GamerManager gamerManager = new GamerManager();
            gamerManager.Save(gamer);
            gamerManager.Update(gamer);
            gamerManager.Delete(gamer);

            BlackFridayCompaign blackFridayCampaign = new BlackFridayCompaign();
            blackFridayCampaign.Id = 1;
            blackFridayCampaign.CompaignName = "blackfriday";
            blackFridayCampaign.Discount = "%20";       

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Save(blackFridayCampaign);
            campaignManager.Update(blackFridayCampaign);
            campaignManager.Delete(blackFridayCampaign);

            SellManager sellManager = new SellManager();
            sellManager.SellingGames(gamer);
            sellManager.SellingCampaign(blackFridayCampaign);
        }
      
    }
}
