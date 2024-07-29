using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bai11.src
{
    public partial class XuLy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string hoTen = Request.Form["empName"];
            string namSinh = Request.Form["empBirth"];
            NhanVien nv = new NhanVien(hoTen, DateTime.Parse(namSinh));
            ArrayList lstNV = (ArrayList)Session["danhsach"];
            lstNV.Add(nv);
            int i = 1;
            string outp = "";
            foreach (NhanVien nhanvien in lstNV)
            {
                outp += "<tr><td class=\"dataReveal stt\">" + (i++) + "</td><td>" + nhanvien.getHoTen() + "</td><td>" + nhanvien.getNamSinh().ToString("d") + "</td></tr>";
            }
            tblNhanVien.InnerHtml = outp;
        }
    }
}