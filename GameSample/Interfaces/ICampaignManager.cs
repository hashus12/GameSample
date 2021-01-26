using System;
using System.Collections.Generic;
using System.Text;

namespace GameSample.Interfaces
{
    interface ICampaignManager
    {
        public void Save(ICampaign campaign);
        public void Update(ICampaign campaign);
        public void Delete(ICampaign campaign);
    }
}
