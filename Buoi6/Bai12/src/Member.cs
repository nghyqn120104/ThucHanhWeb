using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bai12.src
{
    public class Member
    {
        public string nickName, color;
        public Member() { }

        public Member(string nickName, string color)
        {
            this.nickName = nickName;
            this.color = color;
        }
    }
}