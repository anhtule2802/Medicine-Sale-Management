using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace BLL
{
    public class BenhNhanBLL
    {
        QLQTDataContext qt;
        public BenhNhanBLL()
        {
            qt = new QLQTDataContext();
        }
        public List<eBenhNhan> LayThongTinBenhNhan()
        {
            var dsBenhNhan = qt.BenhNhans.ToList();
            List<eBenhNhan> dsbn = new List<eBenhNhan>();
            foreach (BenhNhans item in dsBenhNhan)
            {
                eBenhNhan bn = new eBenhNhan();
                bn.MaBenhNhan = item.MaBenhNhan;
                bn.TenBenhNhan = item.TenBenhNhan;
                bn.NamSinh = item.NamSinh;
                bn.GioiTinh = item.GioiTinh;
                bn.SDT = item.SDT;
                bn.DiaChi = item.DiaChi;
                dsbn.Add(bn);
            }
            return dsbn;
        }

        public void ThemThongTinBenhNhan(eBenhNhan newBN)
        {
            BenhNhans temp = new BenhNhans();
            temp.MaBenhNhan = newBN.MaBenhNhan;
            temp.TenBenhNhan = newBN.TenBenhNhan;
            temp.NamSinh = newBN.NamSinh;
            temp.GioiTinh = newBN.GioiTinh;
            temp.SDT = newBN.SDT;
            temp.DiaChi = newBN.DiaChi;
            qt.BenhNhans.InsertOnSubmit(temp);
            qt.SubmitChanges();
        }
        public int InsertBenhNhan(eBenhNhan bnmoi)
        {
            if (CheckExisted(bnmoi.MaBenhNhan))
                return 0;
            BenhNhans bntemp = new BenhNhans();
            bntemp.MaBenhNhan = bnmoi.MaBenhNhan;
            bntemp.TenBenhNhan = bnmoi.TenBenhNhan;
            bntemp.NamSinh = bnmoi.NamSinh;
            bntemp.GioiTinh = bnmoi.GioiTinh;
            bntemp.DiaChi = bnmoi.DiaChi;
            bntemp.SDT = bnmoi.SDT;
            qt.BenhNhans.InsertOnSubmit(bntemp);
            qt.SubmitChanges();
            return 1;
        }
        public bool CheckExisted(string maBenhNhan)
        {
            BenhNhans bntemp = qt.BenhNhans.Where(x => x.MaBenhNhan == maBenhNhan).FirstOrDefault();
            if (bntemp != null)
                return true;
            return false;
        }
    }
}
