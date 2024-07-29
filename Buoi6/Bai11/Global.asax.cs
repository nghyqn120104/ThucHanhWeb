using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Bai11
{
    public class Global : System.Web.HttpApplication
    {
        protected void Session_Start(object sender, EventArgs e)
        {
            Session["danhSach"] = new ArrayList();
        }
    }
}