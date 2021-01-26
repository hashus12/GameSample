using GameSample.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSample.Entities
{
    class BlackFridayCompaign : ICampaign
    {
        public int Id { get; set; }
        public string CompaignName { get; set; }
        public string Discount { get; set; }
    }
}
