using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    public class Member:IEntity
    {
        public int MemberId { get; set; }
        public DateTime DateOfRegister { get; }
        public string MemberName { get; set; }
        public string MemberLastName { get; set; }
        public int YearOfBirth { get; set; }
        public string NationalityId { get; set; }
        public Member()
        {
            this.DateOfRegister = DateTime.Now;
        }
    }
}
