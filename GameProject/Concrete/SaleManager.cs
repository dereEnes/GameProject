using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class SaleManager : ISaleService
    {
        public void Sale(Member member, Game game)
        {
            Console.WriteLine("{0} İsimli oyun {1} fiyatına {2} kullanıcısına satışı gerçekleşmiştir. ",game.GameName,game.GamePrice,member.MemberName);
        }
    }
}
