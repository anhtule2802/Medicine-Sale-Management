using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eCTHoaDon
    {
        public string MaHoaDon { get; set; }
        public string MaLoThuoc { get; set; }
        public string DVT { get; set; }
        public int SoLuong { get; set; }
        public decimal GiaBan { get; set; }

        public eCTHoaDon()
        {
            this.MaHoaDon = "";
            this.MaLoThuoc = "";
            this.DVT = "";
            this.SoLuong = 0;
            this.GiaBan = 0m;
        }

        public eCTHoaDon(string mhd, string mlt, string dvt, int sl, decimal gb)
        {
            this.MaHoaDon = mhd;
            this.MaLoThuoc = mlt;
            this.DVT = dvt;
            this.SoLuong = sl;
            this.GiaBan = gb;
        }
    }
}
