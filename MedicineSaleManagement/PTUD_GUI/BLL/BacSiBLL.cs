using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;

namespace BLL
{
    public class BacSiBLL
    {
        QLQTDataContext qt;
        public BacSiBLL()
        {
            qt = new QLQTDataContext();
        }
        public List<eBacSi>LayThongTinBacSi()
        {
            var dsBacSi = qt.BacSis.ToList();
            List<eBacSi> dsbs = new List<eBacSi>();
            foreach (BacSis item in dsBacSi)
            {
                eBacSi bs = new eBacSi();
                bs.MaBacSi = item.MaBacSi;
                bs.TenBacSi = item.TenBacSi;
                bs.Khoa = item.Khoa;
                bs.GioiTinh = item.GioiTinh;
                bs.DiaChi = item.DiaChi;
                bs.Email = item.Email;
                dsbs.Add(bs);
            }
            return dsbs;
        }
    }
}
