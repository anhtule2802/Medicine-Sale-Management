using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace BLL
{
    public class LoaiThuocBLL
    {
        QLQTDataContext qt;
        public LoaiThuocBLL()
        {
            qt = new QLQTDataContext();
        }
        public List<eLoaiThuoc> LayThongTinLoaiThuoc()
        {
            var dsLoaiThuoc = qt.LoaiThuocs.ToList();
            List<eLoaiThuoc> dslt = new List<eLoaiThuoc>();
            foreach (LoaiThuocs lt in dsLoaiThuoc)
            {
                eLoaiThuoc l = new eLoaiThuoc();
                l.MaLoaiThuoc = lt.MaLoaiThuoc;
                l.TenLoaiThuoc = lt.TenLoaiThuoc;
                dslt.Add(l);
            }
            return dslt;

        }
    }
}
