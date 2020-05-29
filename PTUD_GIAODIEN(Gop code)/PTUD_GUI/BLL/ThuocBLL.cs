using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace BLL
{
    public class ThuocBLL
    {
        QLQTDataContext qt;
        public ThuocBLL()
        {
            qt = new QLQTDataContext();
        }
        public List<eThuoc> LayThongTinThuoc()
        {
            var dsThuoc = qt.Thuocs.ToList();
            List<eThuoc> dst = new List<eThuoc>();
            foreach (Thuocs ts in dsThuoc)
            {
                eThuoc t = new eThuoc();
                t.MaThuoc = ts.MaThuoc;
                t.MaLoaiThuoc = ts.MaLoaiThuoc;
                t.TenThuoc = ts.TenThuoc;
                t.TrangThai = ts.TrangThai;
                t.MoTa = ts.MoTa;
                dst.Add(t);
            }
            return dst;
        }

        public void ThemThongTinThuoc(eThuoc thuocMoi)
        {
            Thuocs temp = new Thuocs();
            temp.MaLoaiThuoc = thuocMoi.MaLoaiThuoc;
            temp.MaThuoc = thuocMoi.MaThuoc;
            temp.TenThuoc = thuocMoi.TenThuoc;
            temp.TrangThai = thuocMoi.TrangThai;
            temp.MoTa = thuocMoi.MoTa;

            qt.Thuocs.InsertOnSubmit(temp);
            qt.SubmitChanges();

        }

        public void CapNhatThongTinThuoc(string mt, string mlt, string tt, string mota, int trt)
        {
            IQueryable<Thuocs> thuoc = qt.Thuocs.Where(t => t.MaThuoc.Equals(mt));

            thuoc.First().MaThuoc = mt;
            thuoc.First().MaLoaiThuoc = mlt;
            thuoc.First().TenThuoc = tt;
            thuoc.First().MoTa = mota;
            thuoc.First().TrangThai = trt;

            qt.SubmitChanges();
        }
    }
}
