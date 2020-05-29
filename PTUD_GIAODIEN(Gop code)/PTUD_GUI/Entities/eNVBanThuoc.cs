using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eNVBanThuoc:eNhanVien
    {
        public string CaLamViec { get; set; }
        public DateTime NgayLamViec { get; set; }

        public eNVBanThuoc()
        {
            this.CaLamViec = "";
            this.NgayLamViec = DateTime.Now;
        }
        public eNVBanThuoc(string clv, DateTime nlv)
        {
            this.CaLamViec = clv;
            this.NgayLamViec = nlv;
        }
    }
}
