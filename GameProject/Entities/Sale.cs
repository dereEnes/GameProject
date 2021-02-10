using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    class Sale:IEntity
    {
        public int SaleId { get; set; }
        public DateTime DateOfSale { get; set; }
    }
}
