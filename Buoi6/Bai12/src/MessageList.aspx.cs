using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;

namespace Bai12.src
{
    public partial class MessageList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ArrayList arr = (ArrayList)Application["content"];
            if (arr != null )
            {//Lấy list content (các tin nhắn) và in ra màn hình với bên phải là tin nhắn của member tại session đó (đang lỗi)
                Member member = (Member)Session["member"];
                foreach(Message m in arr)
                {
                    if(member.nickName == m.user)
                    {
                        Response.Write("<div style='display: flex; flex-direction: row-reverse'><p style='color:" + m.color + "; padding: 8px; border-radius: 15px; background-color: #cccccc; width: fit-content'><b>" + m.user + ":&nbsp;" + m.message + "&nbsp;(" + m.timeStamp + ")</b></p></div>");
                    }
                    else
                    {
                        Response.Write("<p style='color:" + m.color + "; padding: 8px; border-radius: 15px; background-color: #cccccc; width: fit-content'>" + m.user + ":&nbsp;" + m.message + "&nbsp;(" + m.timeStamp + ")</p>");
                    }
                }
            }
        }
    }
}