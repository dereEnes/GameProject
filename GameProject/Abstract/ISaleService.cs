using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface ISaleService
    {
        void Sale(Member member,Game game);
    }
}
