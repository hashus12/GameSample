using GameSample.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSample.Managers
{
    class CampaignManager: ICampaignManager
    {
        public void Save(ICampaign campaign)
        {
            Console.WriteLine(campaign.CompaignName + " " + campaign.CompaignName + " kayıt edildi.");
        }
        public void Update(ICampaign campaign)
        {
            Console.WriteLine(campaign.CompaignName + " " + campaign.CompaignName + " güncellendi.");
        }
        public void Delete(ICampaign campaign)
        {
            Console.WriteLine(campaign.CompaignName + " " + campaign.CompaignName + " silindi.");
        }
    }
}
