using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace BLL
{
    public class LoThuocBLL
    {
        QLQTDataContext qt;
        public LoThuocBLL()
        {
            qt = new QLQTDataContext();
        }
        public List<eLoThuoc> LayThongTinLoThuoc()
        {
            var dsLoThuoc = qt.LoThuocs.ToList();
            List<eLoThuoc> dslt = new List<eLoThuoc>();
            foreach(LoThuocs lt in dsLoThuoc)
            {
                eLoThuoc l = new eLoThuoc();
                l.MaLoThuoc = lt.MaLoThuoc;
                l.MaThuoc = lt.MaThuoc;
                l.MaNCC = lt.MaNCC;
                l.SoLuong = lt.SoLuong;
                l.DVT = lt.DVT;
                l.DonGia = lt.DonGia;
                l.NgayNhap = lt.NgayNhap;
                l.NgayHetHan = lt.NgayHetHan;
                l.TrangThai = lt.TrangThai;
                dslt.Add(l);
            }
            return dslt;
        }

        public void CapNhatSoLuongLoThuoc(string mlt, int sl)
        {
            IQueryable<LoThuocs> lothuoc = qt.LoThuocs.Where(w => w.MaLoThuoc.Equals(mlt));

            lothuoc.First().MaLoThuoc = mlt;
            lothuoc.First().SoLuong = sl;

            qt.SubmitChanges();
        }

        public void ThemThongTinLoThuoc(eLoThuoc newLoThuoc)
        {
            LoThuocs temp = new LoThuocs();
            temp.MaLoThuoc = newLoThuoc.MaLoThuoc;
            temp.MaNCC = newLoThuoc.MaNCC;
            temp.MaThuoc = newLoThuoc.MaThuoc;
            temp.SoLuong = newLoThuoc.SoLuong;
            temp.DVT = newLoThuoc.DVT;
            temp.DonGia = newLoThuoc.DonGia;
            temp.NgayNhap = newLoThuoc.NgayNhap;
            temp.NgayHetHan = newLoThuoc.NgayHetHan;
            temp.TrangThai = newLoThuoc.TrangThai;

            qt.LoThuocs.InsertOnSubmit(temp);
            qt.SubmitChanges();
        }

        public void CapNhatThongTinLoThuoc(string mlt, string mncc, string mt, int sl, string dvt, decimal dg, DateTime ngay1, DateTime ngay2 , int tt)
        {
            IQueryable<LoThuocs> loThuoc = qt.LoThuocs.Where(w => w.MaLoThuoc.Equals(mlt));

            loThuoc.First().MaLoThuoc = mlt;
            loThuoc.First().MaNCC = mncc;
            loThuoc.First().MaThuoc = mt;
            loThuoc.First().SoLuong = sl;
            loThuoc.First().DVT = dvt;
            loThuoc.First().DonGia = dg;
            loThuoc.First().NgayNhap = ngay1;
            loThuoc.First().NgayHetHan = ngay2;
            loThuoc.First().TrangThai = tt;

            qt.SubmitChanges();
        }

    }
}
