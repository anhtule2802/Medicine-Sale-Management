using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;
namespace BLL
{
    public class TaiKhoanBLL
    {
        QLQTDataContext qt;
        public TaiKhoanBLL()
        {
            this.qt = new QLQTDataContext();
        }
        public List<eTaiKhoan> LayThongTinTaiKhoan()
        {
            var dsTaiKhoan = qt.TaiKhoans.ToList();
            List<eTaiKhoan> dsTK = new List<eTaiKhoan>();
            foreach (TaiKhoans tkn in dsTaiKhoan)
            {
                eTaiKhoan tks = new eTaiKhoan();
                tks.UserName = tkn.Username;
                tks.Pass = tkn.Pass;
                tks.LoaiTK = tkn.LoaiTK;
                tks.MaBS = tkn.MaBacSi;
                tks.MaNV = tkn.MaNhanVien;
                tks.MaNQL = tkn.MaNQL;
                dsTK.Add(tks);
            }
            return dsTK;
        }

        public void DoiMKTaiKhoan(string user, string pass)
        {
            IQueryable<TaiKhoans> taikhoan = qt.TaiKhoans.Where(nv => nv.Username.Equals(user));
            taikhoan.First().Pass = pass;
            qt.SubmitChanges();
        }
    }
}
