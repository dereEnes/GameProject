using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    class Campaign:IEntity
    {
        public int CampaignId { get; set; }
        public int PersentageOfDiscount { get; set; }
        public DateTime DateOfStarts { get; set; }
        public DateTime DateOfFinish { get; set; }
    }
}
