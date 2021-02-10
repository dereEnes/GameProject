using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface IMemberService
    {
        void Add(Member member);
        void Update(Member member);
        void Delete(Member member);

    }
}
