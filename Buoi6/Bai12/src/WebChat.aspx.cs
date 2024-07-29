using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bai12.src
{
    public partial class WebChat : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {//Lấy name và color check có thông tin chưa, chưa có thì điều hướng lại về trang SignIn, rồi thì Tạo List Member mới và thêm Member vào
            string name = Request.Form["txtUsername"];
            string color = Request.Form["txtColor"];
            ArrayList sessionArr = (ArrayList)Application["members"];
            
            if (name == null || color == null)
            {
                Response.Redirect("SignIn.html");
            }
            else
            {
                Member member = (Member)Session["member"];
                member.nickName = name;
                member.color = color;
                foreach (Member m in sessionArr)
                {
                    if (name == m.nickName)
                    {
                        m.color = color;
                        return;
                    }
                }
                sessionArr.Add(new Member(name, color));
            }   
        }
    }
}