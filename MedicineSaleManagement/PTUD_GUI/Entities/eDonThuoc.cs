using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eDonThuoc
    {
        public string MaDonThuoc { get; set; }
        public string MaBacSi { get; set; }
        public string MaBenhNhan { get; set; }
        public DateTime NgayKe { get; set; }
        public string MoTaBenh { get; set; }

        public eDonThuoc()
        {
            this.MaDonThuoc = "";
            this.MaBacSi = "";
            this.MaBenhNhan = "";
            this.NgayKe = DateTime.Now;
            this.MoTaBenh = "";
        }

        public eDonThuoc(string mdt, string mbs, string mbn, DateTime nk, string mtb)
        {
            this.MaDonThuoc = mdt;
            this.MaBacSi = mbs;
            this.MaBenhNhan = mbn;
            this.NgayKe = nk;
            this.MoTaBenh = mtb;
        }
    }
}
