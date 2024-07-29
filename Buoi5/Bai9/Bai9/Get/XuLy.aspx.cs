using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bai9.Bai9.Get
{
    public partial class XuLy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string result = "<h4>CPU</h4>";
            result += "<br/>Tên VXL: " + Request.QueryString["Name"];
            result += "<br/>Hãng SX: " + Request.QueryString["Brand"];
            result += "<br/>Ngày ra mắt: " + Request.QueryString["Date"];
            result += "<br/>Giá: " + Request.QueryString["Price"];
            Response.Write(result);
            Response.End();
        }
    }
}