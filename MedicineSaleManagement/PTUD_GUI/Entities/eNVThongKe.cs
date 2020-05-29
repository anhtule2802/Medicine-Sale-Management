using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eNVThongKe:eNhanVien
    {
        public DateTime NgayLamViec { get; set; }

        public eNVThongKe()
        {
            this.NgayLamViec = DateTime.Now;
        }
        public eNVThongKe(DateTime nlv)
        {
            this.NgayLamViec = nlv;
        }
    }
}
