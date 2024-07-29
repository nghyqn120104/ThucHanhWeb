using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bai12.src
{
    public partial class Members : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ArrayList sessionArr = (ArrayList)Application["members"];
            if (sessionArr != null ) 
            {//Lấy list member và check member tại session đấy, in danh sách member (đang lỗi)
                Member member = (Member)Session["member"];
                foreach (Member m in sessionArr)
                {
                    if (member.nickName == m.nickName)
                    {
                        Response.Write("<p style='text-align: center; padding: 8px; border-radius: 15px; background-color:" + m.color + "'><b><i><u>" + m.nickName + "</b></i></u></p>");
                    }
                    else
                    {
                        Response.Write("<p style='text-align: center; padding: 8px; border-radius: 15px; background-color:" + m.color + "'>" + m.nickName + "</p>");
                    }
                }
                Response.Write("<style>" +
                    "</style>");
            }
            else { }
        }
    }
}