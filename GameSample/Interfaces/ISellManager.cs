using GameSample.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSample.Interfaces
{
    interface ISellManager
    {
        public void SellingGames(IPerson gamer);
        public void SellingCampaign(ICampaign campaign);
    }
}
