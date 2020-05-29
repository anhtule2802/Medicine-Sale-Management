using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eBacSi
    {
        public string MaBacSi { get; set; }
        public string TenBacSi { get; set; }
        public string Khoa { get; set; }
        public string GioiTinh { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }

        public eBacSi()
        {
            this.MaBacSi = "";
            this.TenBacSi = "";
            this.Khoa = "";
            this.GioiTinh = "";
            this.SDT = "";
            this.DiaChi = "";
            this.Email = "";
        }
        public eBacSi(string mbs, string tbs, string k, string gt, string sdt, string dc, string email)
        {
            this.MaBacSi = mbs;
            this.TenBacSi = tbs;
            this.Khoa = k;
            this.GioiTinh = gt;
            this.SDT = sdt;
            this.DiaChi = dc;
            this.Email = email;
        }
    }
}
