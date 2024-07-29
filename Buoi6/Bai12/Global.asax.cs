using Bai12.src;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Bai12
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            Application["members"] = new ArrayList();
            Application["content"] = new ArrayList();
        }
        protected void Session_Start(object sender, EventArgs e)
        {
            Session["member"] = new Member();
        }
    }
}