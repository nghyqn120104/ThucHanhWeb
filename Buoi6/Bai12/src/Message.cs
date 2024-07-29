using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bai12.src
{
    public class Message
    {
        public string user, message, timeStamp, color;
        public Message() { }
        
        public Message(string user, string mess, string time, string color)
        {
            this.user = user;
            this.message = mess;
            this.timeStamp = time;
            this.color = color;
        }
    }
}