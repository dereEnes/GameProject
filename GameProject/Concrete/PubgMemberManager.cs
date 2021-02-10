using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
     class PubgMemberManager : BaseMemberManager
    {
        private ICustomerCheckManager _CustomerCheckManager;
        public PubgMemberManager(ICustomerCheckManager CustomerCheckManager)
        {
            _CustomerCheckManager = CustomerCheckManager;
        }
        public override void Add(Member member)
        {
            if (_CustomerCheckManager.CheckUser(member))
            {
                Console.WriteLine("{0} {1} Adlı kullanıcı Eklendi", member.MemberName, member.MemberLastName);
            }
            else
            {
                Console.WriteLine("Gerçek bir kullanıcı giriniz.");
            }

        }
    }
}
