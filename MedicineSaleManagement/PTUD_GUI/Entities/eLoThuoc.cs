using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eLoThuoc
    {
       
        public string MaLoThuoc { get; set; }
        public string MaThuoc { get; set; }
        public string MaNCC { get; set; }
        public string DVT { get; set; }
        public DateTime NgayNhap { get; set; }
        public DateTime NgayHetHan { set; get; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public int TrangThai { get; set; }

        public eLoThuoc()
        {
            this.MaLoThuoc = "";
            this.MaThuoc = "";
            this.MaNCC = "";
            this.DVT = "";
            this.NgayNhap = DateTime.Now;
            this.NgayHetHan = DateTime.Now;
            this.SoLuong = 0;
            this.DonGia = 0m;
            this.TrangThai = 1;
        }

        public eLoThuoc(string mlt, string mt, string mncc, string dvt, DateTime nn, DateTime nhh, int sl, decimal dg, int tt)
        {
            this.MaLoThuoc = mlt;
            this.MaThuoc = mt;
            this.MaNCC = mncc;
            this.DVT = dvt;
            this.NgayNhap = nn;
            this.NgayHetHan = nhh;
            this.SoLuong = sl;
            this.DonGia = dg;
            this.TrangThai = tt;
        }
    }
}
