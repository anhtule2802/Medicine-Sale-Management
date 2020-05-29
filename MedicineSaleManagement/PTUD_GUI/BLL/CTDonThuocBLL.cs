using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace BLL
{
    public class CTDonThuocBLL
    {
        QLQTDataContext qt;
        public CTDonThuocBLL()
        {
            qt = new QLQTDataContext();
        }
        public List<eCTDonThuoc> LayThongTinCTDonThuoc()
        {
            var dsCTDonThuoc = qt.CTDonThuocs.ToList();
            List<eCTDonThuoc> ctdt = new List<eCTDonThuoc>();
            foreach (CTDonThuocs item in dsCTDonThuoc)
            {
                eCTDonThuoc ct = new eCTDonThuoc();
                ct.MaDonThuoc = item.MaDonThuoc;
                ct.MaThuoc = item.MaThuoc;
                ct.DVT = item.DVT;
                ct.SoLuong = item.SoLuong;
                ct.GhiChu = item.GhiChu;
                ctdt.Add(ct);
            }
            return ctdt;
        }
        public List<eCTDonThuoc> LayDonThuocBoiMaDonThuoc(string MaDT)
        {
            var dsdt = qt.CTDonThuocs.Where(x => x.MaDonThuoc == MaDT).ToList();
            List<eCTDonThuoc> ctdt = new List<eCTDonThuoc>();
            foreach (CTDonThuocs ctdttemps in dsdt)
            {
                eCTDonThuoc ctdtnew = new eCTDonThuoc();
                ctdtnew.MaDonThuoc = ctdttemps.MaDonThuoc;
                ctdtnew.MaThuoc = ctdttemps.MaThuoc;
                ctdtnew.SoLuong = Convert.ToInt32(ctdttemps.SoLuong);
                ctdtnew.DVT = ctdttemps.DVT;
                ctdtnew.GhiChu = ctdttemps.GhiChu;
                ctdt.Add(ctdtnew);
            }
            return ctdt;
        }
        public int InsertCTDonThuoc(eCTDonThuoc ctdtmoi)
        {
            CTDonThuocs ctdttemp = new CTDonThuocs();
            ctdttemp.MaThuoc = ctdtmoi.MaThuoc;
            ctdttemp.MaDonThuoc = ctdtmoi.MaDonThuoc;
            ctdttemp.SoLuong = ctdtmoi.SoLuong;
            ctdttemp.DVT = ctdtmoi.DVT;
            qt.CTDonThuocs.InsertOnSubmit(ctdttemp);
            ctdttemp.GhiChu = ctdtmoi.GhiChu;
            qt.SubmitChanges();
            return 1;
        }
    }

}
