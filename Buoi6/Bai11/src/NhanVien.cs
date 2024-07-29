using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bai11.src
{
    public class NhanVien
    {
        String hoTen;
        DateTime namSinh;
        public NhanVien(String hoTen, DateTime namSinh)
        { 
            this.hoTen = hoTen; 
            this.namSinh = namSinh;
        }
        public String getHoTen()
        {
            return this.hoTen;
        }
        public DateTime getNamSinh()
        {
            return this.namSinh;
        }
        public void setHoTen(String hoTen)
        {
            this.hoTen = hoTen;
        }
        public void setNamSinh(DateTime namSinh)
        {
            this.namSinh = namSinh;
        }
    }
}