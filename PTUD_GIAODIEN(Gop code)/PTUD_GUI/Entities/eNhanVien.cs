using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eNhanVien
    {
        public string MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public string GioiTinh { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public int TinhTrang { get; set; }

        public eNhanVien()
        {
            this.MaNhanVien = "";
            this.TenNhanVien = "";
            this.GioiTinh = "";
            this.SDT = "";
            this.DiaChi = "";
            this.Email = "";
            this.TinhTrang = 1;
        }

        public eNhanVien(string mnv, string tnv, string gt, string sdt, string dc, string e, int tt)
        {
            this.MaNhanVien = mnv;
            this.TenNhanVien = tnv;
            this.GioiTinh = gt;
            this.SDT = sdt;
            this.DiaChi = dc;
            this.Email = e;
            this.TinhTrang = tt;
        }
    }
}
