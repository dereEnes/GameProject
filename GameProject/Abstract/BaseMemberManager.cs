using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
     abstract class BaseMemberManager:IMemberService
    {
       
        public virtual void Add(Member member)
        {
            
                Console.WriteLine("{0} {1} Adlı kullanıcı Eklendi", member.MemberName, member.MemberLastName);
            
           
        }
        public void Update(Member member)
        {
            Console.WriteLine("{0} {1} Adlı kullanıcı Güncellendi", member.MemberName, member.MemberLastName);
        }
        public void Delete(Member member)
        {
            Console.WriteLine("{0} {1} Adlı kullanıcı Silindi", member.MemberName, member.MemberLastName);
        }
    }
}
