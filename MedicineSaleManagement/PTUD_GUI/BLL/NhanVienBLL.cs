using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace BLL
{
    public class NhanVienBLL
    {

        QLQTDataContext qt;

        public NhanVienBLL()
        {
            qt = new QLQTDataContext();
        }

        public List<eNhanVien> LayThongTinNhanVien()
        {
            var dsNhanVien = qt.NhanViens.ToList();
            List<eNhanVien> dsnv = new List<eNhanVien>();
            foreach (var item in dsNhanVien)
            {
                eNhanVien nv = new eNhanVien();
                nv.MaNhanVien = item.MaNhanVien;
                nv.TenNhanVien = item.TenNhanVien;
                nv.GioiTinh = item.GioiTinh;
                nv.SDT = item.SDT;
                nv.DiaChi = item.DiaChi;
                nv.Email = item.Email;
                nv.TinhTrang = item.TinhTrang;
                dsnv.Add(nv);
            }
            return dsnv;
        }
        public List<eNVBanThuoc> LayThongTinNhanVienBanThuoc()
        {

            var dsNVBanThuoc = qt.NVBanThuocs
                .Join(qt.NhanViens, bt => bt.MaNhanVien, nv => nv.MaNhanVien, (bt, nv) => new { bt, nv}).ToList();

            List<eNVBanThuoc> dsnvbt = new List<eNVBanThuoc>();
            foreach (var item in dsNVBanThuoc)
            {
                eNVBanThuoc nv = new eNVBanThuoc();
                nv.MaNhanVien = item.bt.MaNhanVien;
                nv.TenNhanVien = item.nv.TenNhanVien;
                nv.SDT = item.nv.SDT;
                nv.DiaChi = item.nv.DiaChi;
                nv.Email = item.nv.Email;
                nv.CaLamViec = item.bt.CaLamViec;
                nv.GioiTinh = item.nv.GioiTinh;
                nv.NgayLamViec = item.bt.NgayLamViec;
                nv.TinhTrang = item.nv.TinhTrang;
                dsnvbt.Add(nv);
            }
            return dsnvbt;


        }

        public List<eNVThongKe> LayThongTinNhanVienThongKe()
        {
            var dsNVThongKe = qt.NVThongKes
                .Join(qt.NhanViens, tk => tk.MaNhanVien, nv => nv.MaNhanVien, (tk, nv) => new { tk, nv }).ToList();
            List<eNVThongKe> dsnvtk = new List<eNVThongKe>();
            foreach (var item in dsNVThongKe)
            {
                eNVThongKe nv = new eNVThongKe();
                nv.MaNhanVien = item.tk.MaNhanVien;
                nv.TenNhanVien = item.nv.TenNhanVien;
                nv.GioiTinh = item.nv.GioiTinh;
                nv.SDT = item.nv.SDT;
                nv.DiaChi = item.nv.DiaChi;
                nv.Email = item.nv.Email;
                nv.NgayLamViec = item.tk.NgayLamViec;
                nv.TinhTrang = item.nv.TinhTrang;
                dsnvtk.Add(nv);
            }
            return dsnvtk;
        }

        public void ThemNhanVien(eNhanVien nvMoi)
        {
            NhanViens temp = new NhanViens();
            temp.MaNhanVien = nvMoi.MaNhanVien;
            temp.TenNhanVien = nvMoi.TenNhanVien;
            temp.GioiTinh = nvMoi.GioiTinh;
            temp.SDT = nvMoi.SDT;
            temp.DiaChi = nvMoi.DiaChi;
            temp.Email = nvMoi.Email;
            temp.TinhTrang = nvMoi.TinhTrang;

            qt.NhanViens.InsertOnSubmit(temp);
            qt.SubmitChanges();
            
        }

        public void ThemNVBanThuoc(eNVBanThuoc nvMoi)
        {
            NVBanThuocs temp = new NVBanThuocs();
            temp.MaNhanVien = nvMoi.MaNhanVien;
            temp.NgayLamViec = nvMoi.NgayLamViec;
            temp.CaLamViec = nvMoi.CaLamViec;

            qt.NVBanThuocs.InsertOnSubmit(temp);
            qt.SubmitChanges();
        }

        public void ThemNVThongKe(eNVThongKe nvMoi)
        {
            NVThongKes temp = new NVThongKes();
            temp.MaNhanVien = nvMoi.MaNhanVien;
            temp.NgayLamViec = nvMoi.NgayLamViec;

            qt.NVThongKes.InsertOnSubmit(temp);
            qt.SubmitChanges();
        }

        public void CapNhatThongTinNhanVien(string mnv, string tnv, string gt, string sdt, string dc, string e, int tt)
        {
            IQueryable<NhanViens> nhanvien = qt.NhanViens.Where(nv => nv.MaNhanVien.Equals(mnv));

            nhanvien.First().MaNhanVien = mnv;
            nhanvien.First().TenNhanVien = tnv;
            nhanvien.First().GioiTinh = gt;
            nhanvien.First().SDT = sdt;
            nhanvien.First().DiaChi = dc;
            nhanvien.First().Email = e;
            nhanvien.First().TinhTrang = tt;

            qt.SubmitChanges();
        }

        public void CapNhatThongTinNVBT(string mnv, DateTime nlv, string clv)
        {
            IQueryable<NVBanThuocs> nhanvien = qt.NVBanThuocs.Where(nv => nv.MaNhanVien.Equals(mnv));

            nhanvien.First().MaNhanVien = mnv;
            nhanvien.First().NgayLamViec = nlv;
            nhanvien.First().CaLamViec = clv;

            qt.SubmitChanges();
        }

        public void CapNhatThongTinNVTK(string mnv, DateTime nlv)
        {
            IQueryable<NVThongKes> nhanvien = qt.NVThongKes.Where(nv => nv.MaNhanVien.Equals(mnv));

            nhanvien.First().MaNhanVien = mnv;
            nhanvien.First().NgayLamViec = nlv;

            qt.SubmitChanges();
        }

        public bool XoaThongTinNVBT(string mnv)
        {
            NVBanThuocs nvtemp = qt.NVBanThuocs.Where(nv => nv.MaNhanVien.Equals(mnv)).FirstOrDefault();
            if(nvtemp != null)
            {
                qt.NVBanThuocs.DeleteOnSubmit(nvtemp);
                qt.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool XoaThongTinNVTK(string mnv)
        {
            NVThongKes nvtemp = qt.NVThongKes.Where(nv => nv.MaNhanVien.Equals(mnv)).FirstOrDefault();
            if (nvtemp != null)
            {
                qt.NVThongKes.DeleteOnSubmit(nvtemp);
                qt.SubmitChanges();
                return true;
            }
            return false;
        }
    }
}
