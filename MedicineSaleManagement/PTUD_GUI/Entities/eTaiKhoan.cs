using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eTaiKhoan
    {
        public string UserName { set; get; }
        public string Pass { set; get; }
        public string LoaiTK { set; get; }
        public string MaNV { set; get; }
        public string MaNQL { set; get; }
        public string MaBS { set; get; }
        public eTaiKhoan()
        {
            this.UserName = "";
            this.Pass = "";
            this.LoaiTK = "";
            this.MaNV = "";
            this.MaNQL = "";
            this.MaBS = "";
        }
        public eTaiKhoan(string user,string p,string loaitk,string manv,string manql,string mabs)
        {
            this.UserName = user;
            this.Pass = p;
            this.LoaiTK = loaitk;
            this.MaNV = manv;
            this.MaNQL = manql;
            this.MaBS = mabs;
        }
    }
}
