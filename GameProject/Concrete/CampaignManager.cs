using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.PersentageOfDiscount+" Eklendi.");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.PersentageOfDiscount+" Silindi");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.PersentageOfDiscount+" Güncellendi");
        }
    }
}
