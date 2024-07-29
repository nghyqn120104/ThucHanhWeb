using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bai10
{
    public partial class Bai10 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                String content = Request.Form["txtNoiDung"];
                Response.Write("Content: " + content);

                HttpPostedFile file = Request.Files["inputFile"];
                String cF = Request.Form["inputFile"];
                if (file == null) { Response.Write("<br>Lỗi file: " + cF); }
                else
                {
                    file.SaveAs(Server.MapPath("./App_Data\\" + file.FileName));
                }
                Response.End();
            }
        }
    }
}