using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eThuoc
    {
        public string MaThuoc { get; set; }
        public string MaLoaiThuoc { get; set; }
        public string TenThuoc { get; set; }
        public string MoTa { get; set; }
        public int TrangThai { get; set; }

        public eThuoc()
        {
            this.MaThuoc = "";
            this.MaLoaiThuoc = "";
            this.TenThuoc = "";
            this.MoTa = "";
            this.TrangThai = 0;
        }

        public eThuoc(string mt, string mlt, string tt, string ha, string mota, int trt)
        {
            this.MaThuoc = mt;
            this.MaLoaiThuoc = mlt;
            this.TenThuoc = tt;
            this.MoTa = mota;
            this.TrangThai = trt;
        }
    }
}
