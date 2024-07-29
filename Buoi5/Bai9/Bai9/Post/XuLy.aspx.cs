using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Bai9.Bai9.Post
{
    public partial class XuLy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string result = "<h2>CPU</h2>";
            result += "<br>Tên VXL: " + Request.Form["Name"];
            result += "<br>Hãng: " + Request.Form["Brand"];
            result += "<br>Ngày SX: " + Request.Form["Date"];
            result += "<br>Giá: " + Request.Form["Price"];
            Response.Write(result);
            Response.End();
        }
    }
}