using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bai12.src
{
    public partial class SendMsg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {//Lấy input và danh sách các tin nhắn, lấy thông tin và cho vào object message
            string msg = Request.Form["txtMessage"];
            ArrayList content = (ArrayList)Application["content"];
            Member member = (Member)Session["member"];
            string date = DateTime.Now.ToShortTimeString();
            content.Add(new Message(member.nickName, msg, date, member.color));
            Response.Redirect("PostMsg.html");
        }
    }
}