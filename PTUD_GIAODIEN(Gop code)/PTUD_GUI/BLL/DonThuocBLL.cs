using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace BLL
{
    public class DonThuocBLL
    {
        QLQTDataContext qt;
        public DonThuocBLL()
        {
            qt = new QLQTDataContext();
        }
        public List<eDonThuoc> LayThongTinDonThuoc()
        {
            var dsDonThuoc = qt.DonThuocs.ToList();
            List<eDonThuoc> dsdt = new List<eDonThuoc>();
            foreach (DonThuocs item in dsDonThuoc)
            {
                eDonThuoc dt = new eDonThuoc();
                dt.MaDonThuoc = item.MaDonThuoc;
                dt.MaBacSi = item.MaBacSi;
                dt.MaBenhNhan = item.MaBenhNhan;
                dt.MoTaBenh = item.MoTaBenh;
                dt.NgayKe = item.NgayKe;
                dsdt.Add(dt);
            }
            return dsdt;
        }
        public int InsertDonThuoc(eDonThuoc dtmoi)
        {
            if (CheckExisted(dtmoi.MaDonThuoc))
                return 0;
            DonThuocs mdttemp = new DonThuocs();
            mdttemp.MaDonThuoc = dtmoi.MaDonThuoc;
            mdttemp.MaBenhNhan = dtmoi.MaBenhNhan;
            mdttemp.NgayKe = dtmoi.NgayKe;
            mdttemp.MaBacSi = dtmoi.MaBacSi;
            mdttemp.MoTaBenh = dtmoi.MoTaBenh;
            qt.DonThuocs.InsertOnSubmit(mdttemp);
            qt.SubmitChanges();
            return 1;
        }
        public bool CheckExisted(string maDonThuoc)
        {
            DonThuocs mdttemp = qt.DonThuocs.Where(x => x.MaDonThuoc == maDonThuoc).FirstOrDefault();
            if (mdttemp != null)
                return true;
            return false;
        }
    }
}
