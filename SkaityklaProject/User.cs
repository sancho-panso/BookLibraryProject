
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace SkaityklaProject
{
    class User
    {
        public User()
        {
            Guid g = Guid.NewGuid();
            UserID = g;
            Member = Member.ordinary;

        }
        public Guid UserID { get; set; }
        public UserName UserName { get; set; }
        public Address Address { get; set; }
        public Member Member { get; set; }

        public  void SetMembership( Member member)// ?????
        {
            this.Member = member;
        }

    
    }
}
