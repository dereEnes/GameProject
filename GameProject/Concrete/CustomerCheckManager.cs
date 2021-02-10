using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class CustomerCheckManager : ICustomerCheckManager
    {
        public bool CheckUser(Member member)
        {
            return true;
        }
    }
}
