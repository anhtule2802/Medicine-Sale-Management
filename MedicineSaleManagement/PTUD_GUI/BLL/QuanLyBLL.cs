using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;
namespace BLL
{
    public class QuanLyBLL
    {
        QLQTDataContext qt;
        public QuanLyBLL()
        {
            qt = new QLQTDataContext();
        }
        public List<eQuanLy> LayThongTinQuanLy()
        {
            var dsQuanLy = qt.QuanLys.ToList();
            List<eQuanLy> dsQL = new List<eQuanLy>();
            foreach (QuanLys qls in dsQuanLy)
            {
                eQuanLy qln = new eQuanLy();
                qln.MaNQL = qls.MaNQL;
                qln.TenNQL = qls.TenNQL;
                dsQL.Add(qln);
            }
            return dsQL;
        }
    }
}
