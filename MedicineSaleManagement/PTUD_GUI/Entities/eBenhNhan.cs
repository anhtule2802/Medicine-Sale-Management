using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eBenhNhan
    {
        public string MaBenhNhan { get; set; }
        public string TenBenhNhan { get; set; }
        public int NamSinh { get; set; }
        public string GioiTinh { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }

        public eBenhNhan()
        {
            this.MaBenhNhan = "";
            this.TenBenhNhan = "";
            this.NamSinh = 0;
            this.GioiTinh = "";
            this.SDT = "";
            this.DiaChi = "";
        }

        public eBenhNhan(string mbn, string tbn, int ns, string gt, string sdt, string dc)
        {
            this.MaBenhNhan = mbn;
            this.TenBenhNhan = tbn;
            this.NamSinh = ns;
            this.GioiTinh = gt;
            this.SDT = sdt;
            this.DiaChi = dc;
        }
    }
}
