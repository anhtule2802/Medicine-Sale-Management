using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eLoaiThuoc
    {
        public string MaLoaiThuoc { get; set; }
        public string TenLoaiThuoc { get; set; }

        public eLoaiThuoc()
        {
            this.MaLoaiThuoc = "";
            this.TenLoaiThuoc = "";
        }

        public eLoaiThuoc(string mlt, string tlt)
        {
            this.MaLoaiThuoc = mlt;
            this.TenLoaiThuoc = tlt;
        }
    }
}
