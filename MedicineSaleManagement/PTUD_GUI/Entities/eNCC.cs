using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eNCC
    {
        public string MaNCC { get; set; }
        public string TenNCC { get; set; }

        public eNCC()
        {
            this.MaNCC = "";
            this.TenNCC = "";
        }
        public eNCC(string mncc, string tncc)
        {
            this.MaNCC = mncc;
            this.TenNCC = tncc;
        }
    }
}
