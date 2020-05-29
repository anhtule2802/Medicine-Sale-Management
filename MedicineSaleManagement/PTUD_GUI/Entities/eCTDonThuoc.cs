using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eCTDonThuoc
    {
        public string MaDonThuoc { get; set; }
        public string MaThuoc { get; set; }
        public int SoLuong { get; set; }
        public string DVT { get; set; }
        public string GhiChu { set; get; }

        public eCTDonThuoc()
        {
            this.MaDonThuoc = "";
            this.MaThuoc = "";
            this.SoLuong = 0;
            this.DVT = "";
            this.GhiChu = "";
        }

        public eCTDonThuoc(string mdt, string mt, int sl, string dvt, string gc)
        {
            this.MaDonThuoc = mdt;
            this.MaThuoc = mt;
            this.SoLuong = sl;
            this.DVT = dvt;
            this.GhiChu = gc;
        }
    }
}
