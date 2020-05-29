using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace BLL
{
    public class HoaDonBLL
    {
        QLQTDataContext qt;
        public HoaDonBLL()
        {
            qt = new QLQTDataContext();
        }
        public List<eHoaDon>LayThongTinHoaDon()
        {
            var dsHoaDon = qt.HoaDons.ToList();
            List<eHoaDon> dshd = new List<eHoaDon>();
            foreach (HoaDons item in dsHoaDon)
            {
                eHoaDon hd = new eHoaDon();
                hd.MaHoaDon = item.MaHoaDon;
                hd.MaDonThuoc = item.MaDonThuoc;
                hd.MaBenhNhan = item.MaBenhNhan;
                hd.MaNhanVien = item.MaNhanVien;
                hd.NgayLapHD = item.NgayLapHD;
                hd.TongTien = item.TongTien;
                dshd.Add(hd);
            }
            return dshd;
        }

        public void ThemThongTinHoaDon(eHoaDon newHD)
        {
            HoaDons temp = new HoaDons();
            temp.MaHoaDon = newHD.MaHoaDon;
            temp.MaDonThuoc = newHD.MaDonThuoc;
            temp.MaBenhNhan = newHD.MaBenhNhan;
            temp.MaNhanVien = newHD.MaNhanVien;
            temp.NgayLapHD = newHD.NgayLapHD;
            temp.TongTien = newHD.TongTien;
            qt.HoaDons.InsertOnSubmit(temp);
            qt.SubmitChanges();
        }
    }
}
