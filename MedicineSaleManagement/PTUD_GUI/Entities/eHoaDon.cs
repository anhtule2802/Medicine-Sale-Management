using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eHoaDon
    {
        public string MaHoaDon { set; get; }
        public string MaNhanVien { set; get; }
        public string MaDonThuoc { set; get; }
        public string MaBenhNhan { set; get; }
        public decimal TongTien { get; set; }
        public DateTime NgayLapHD { set; get; }

        public eHoaDon()
        {
            this.MaHoaDon = "";
            this.MaNhanVien = "";
            this.MaDonThuoc = "";
            this.MaBenhNhan = "";
            this.TongTien = 0m;
            this.NgayLapHD = DateTime.Now;
        }

        public eHoaDon(string mhd, string mnv, string mdt, string mbn, decimal tt, DateTime nlhd)
        {
            this.MaHoaDon = mhd;
            this.MaNhanVien = mnv;
            this.MaDonThuoc = mdt;
            this.MaBenhNhan = mbn;
            this.TongTien = tt;
            this.NgayLapHD = nlhd;
        }
    }
}
