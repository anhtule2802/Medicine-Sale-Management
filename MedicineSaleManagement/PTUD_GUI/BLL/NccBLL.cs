using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace BLL
{
    public class NccBLL
    {
        QLQTDataContext qt;
        public NccBLL()
        {
            qt = new QLQTDataContext();
        }

        public List<eNCC> LayThongTinNCC()
        {
            var dsNCC = qt.NCCs.ToList();
            List<eNCC> dsncc = new List<eNCC>();
            foreach (NCCs item in dsNCC)
            {
                eNCC ncc = new eNCC();
                ncc.MaNCC = item.MaNCC;
                ncc.TenNCC = item.TenNCC;
                dsncc.Add(ncc);
            }
            return dsncc;
        }
    }
}
