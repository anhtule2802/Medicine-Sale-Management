using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eQuanLy
    {
        public string MaNQL { get; set; }
        public string TenNQL { get; set; }
        public eQuanLy()
        {
            this.MaNQL = "";
            this.TenNQL = "";
        }
        public eQuanLy(string ma,string ten)
        {
            this.MaNQL = ma;
            this.TenNQL = ten;
        }
    }
}
