using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace BLL
{
    public class CTHoaDonBLL
    {
        QLQTDataContext qt;
        
        public CTHoaDonBLL()
        {
            qt = new QLQTDataContext();
        }
        public List<eCTHoaDon>LayThongTinCTHoaDon()
        {
            var dsCTHoaDon = qt.CTHoaDons.ToList();
            List<eCTHoaDon> dscthd = new List<eCTHoaDon>();
            foreach (CTHoaDons item in dsCTHoaDon)
            {
                eCTHoaDon ct = new eCTHoaDon();
                ct.MaHoaDon = item.MaHoaDon;
                ct.MaLoThuoc = item.MaLoThuoc;
                ct.DVT = item.DVT;
                ct.SoLuong = item.SoLuong;
                ct.GiaBan = item.GiaBan;
                dscthd.Add(ct);
            }
            return dscthd;
        }
        public void ThemThongTinCTHoaDon(eCTHoaDon newCTHD)
        {
            CTHoaDons temp = new CTHoaDons();
            temp.MaHoaDon = newCTHD.MaHoaDon;
            temp.MaLoThuoc = newCTHD.MaLoThuoc;
            temp.DVT = newCTHD.DVT;
            temp.SoLuong = newCTHD.SoLuong;
            temp.GiaBan = newCTHD.GiaBan;

            qt.CTHoaDons.InsertOnSubmit(temp);
            qt.SubmitChanges();

        }
    }
}
