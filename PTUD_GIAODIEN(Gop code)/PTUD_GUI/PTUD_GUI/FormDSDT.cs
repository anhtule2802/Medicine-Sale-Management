using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using BLL;
namespace PTUD_GUI
{
    public partial class FormDSDT : Form
    {
        DonThuocBLL dtBLL;
        List<eDonThuoc> dsDT;
        CTDonThuocBLL ctdtBLL;
        List<eCTDonThuoc> dsCTDT;
        BindingSource bsDSDT;
        BacSiBLL bsBLL;
        List<eBacSi> dsBS;
        public FormDSDT()
        {
            InitializeComponent();
            bsDSDT = new BindingSource();
            ctdtBLL = new CTDonThuocBLL();
            dsCTDT = new List<eCTDonThuoc>();
            dtBLL = new DonThuocBLL();
            dsDT = new List<eDonThuoc>();
            bsBLL = new BacSiBLL();
            dsBS = new List<eBacSi>();
            dsBS = bsBLL.LayThongTinBacSi();
            dsDT = dtBLL.LayThongTinDonThuoc();
            HienThiThongTinDonThuoc();
            DateTime dt = DateTime.Today;
            lblDate.Text = dt.ToString("dd/MM/yyyy");
            AutoComplete();
            tbTimKiemDT.Text = "Nhập mã đơn thuốc hoặc theo ngày";
            tbTimKiemDT.ForeColor = Color.Gray;
        }
        #region CacHamHoTro
        public void LoadDataGridViewCTDT(DataGridView gdv, List<eCTDonThuoc> l)
        {
            dgvCTDT.DataSource = l;
            dgvCTDT.Columns[4].Width = 132;
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }
        #endregion

        private void HienThiThongTinDonThuoc()
        {
            DateTime temp = DateTime.Now;
            var gridviewInfo = dsDT.Join(dsBS, dt => dt.MaBacSi, bs => bs.MaBacSi,(dt,bs) => new { dt,bs})
                .Where(dt1 => dt1.dt.NgayKe.ToString("dd/MM/yyyy").Equals(temp.ToString("dd/MM/yyyy")))
            .Select(dt2 => new
            {
                MaDonThuoc = dt2.dt.MaDonThuoc,
                TenBacSi = dt2.bs.TenBacSi,
                MaBenhNhan = dt2.dt.MaBenhNhan,
                NgayKe = dt2.dt.NgayKe,
                MoTaBenh = dt2.dt.MoTaBenh
            }).ToList();
            bsDSDT.DataSource = gridviewInfo;
            dgvDSDT.DataSource = bsDSDT;
            dgvDSDT.Focus();
            dgvDSDT.Columns[0].HeaderText = "Mã Đơn Thuốc";
            dgvDSDT.Columns[1].HeaderText = "Tên Bác Sĩ";
            dgvDSDT.Columns[2].HeaderText = "Mã Bệnh Nhân";
            dgvDSDT.Columns[3].HeaderText = "Mã Ngày Kê";
            dgvDSDT.Columns[4].HeaderText = "Mã Mô Tả Bệnh";
            dgvDSDT.Columns[4].Width = 130;
        }

        private void tbTimKiemDT_TextChanged(object sender, EventArgs e)
        {
            if (tbTimKiemDT.Text == "Nhập mã đơn thuốc hoặc theo ngày")
            {
                HienThiThongTinDonThuoc();
            }
            else
            {
                var newList = dsDT.Join(dsBS, dt => dt.MaBacSi, bs => bs.MaBacSi, (dt, bs) => new { dt, bs })
                    .Where(t1 => t1.dt.MaDonThuoc.Contains(tbTimKiemDT.Text) || t1.dt.NgayKe.ToString("dd/MM/yyyy") == tbTimKiemDT.Text)
                .Select(t2 => new
                {
                    MaDonThuoc = t2.dt.MaDonThuoc,
                    TenBacSi = t2.bs.TenBacSi,
                    MaBenhNhan = t2.dt.MaBenhNhan,
                    NgayKe = t2.dt.NgayKe,
                    MoTaBenh = t2.dt.MoTaBenh
                }).ToList();
                bsDSDT.DataSource = newList;
                dgvDSDT.DataSource = bsDSDT;
            }
        }

        private void dgvDSDT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index1 = dgvDSDT.CurrentRow.Index;
            dgvDSDT.Rows[index1].Selected = true;
            string madonthuoc = dgvDSDT.Rows[index1].Cells[0].Value.ToString();
            dsCTDT = ctdtBLL.LayDonThuocBoiMaDonThuoc(madonthuoc);
            LoadDataGridViewCTDT(dgvCTDT, dsCTDT);
            dgvCTDT.ClearSelection();
        }

        private void tbTimKiemDT_Enter(object sender, EventArgs e)
        {
            if (tbTimKiemDT.Text == "Nhập mã đơn thuốc hoặc theo ngày")
            {
                tbTimKiemDT.Text = "";
                tbTimKiemDT.ForeColor = Color.Black;
            }
        }

        private void tbTimKiemDT_Leave(object sender, EventArgs e)
        {
            if (tbTimKiemDT.Text == "")
            {
                tbTimKiemDT.Text = "Nhập mã đơn thuốc hoặc theo ngày";
                tbTimKiemDT.ForeColor = Color.Gray;
            }
        }

        private void AutoComplete()
        {
            tbTimKiemDT.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tbTimKiemDT.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            foreach (var item in dsDT)
            {
                col.Add(item.MaDonThuoc);
                col.Add(item.NgayKe.ToString("dd/MM/yyyy"));
            }
            tbTimKiemDT.AutoCompleteCustomSource = col;
        }

        private void dgvDSDT_DoubleClick(object sender, EventArgs e)
        {
            int index1 = dgvDSDT.CurrentRow.Index;
            dgvDSDT.Rows[index1].Selected = true;
        }
    }
}
