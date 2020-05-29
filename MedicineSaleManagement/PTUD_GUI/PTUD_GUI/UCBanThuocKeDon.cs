using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using BLL;
using Entities;

namespace PTUD_GUI
{
    public partial class UCBanThuocKeDon : UserControl
    {
        bool isThem = false;
        decimal tongTien = 0;
        BindingSource bsTimKiem, bsDonThuoc, bsCTDonThuoc, bsThuocDaChon;
        ThuocBLL thuocBLL;
        LoThuocBLL loThuocBLL;
        DonThuocBLL donThuocBLL;
        CTDonThuocBLL ctDonThuocBLL;
        BacSiBLL bacsiBLL;
        BenhNhanBLL benhnhanBLL;
        HoaDonBLL hoadonBLL;
        CTHoaDonBLL cthdBLL;

        List<eThuoc> dsThuoc;
        List<eLoThuoc> dsLoThuoc;
        List<eDonThuoc> dsDonThuoc;
        List<eCTDonThuoc> dsCTDonThuoc;
        List<eBacSi> dsBacSi;
        List<eBenhNhan> dsBenhNhan;
        List<eHoaDon> dsHoaDon;
        List<eCTHoaDon> dsCTHD;
        public UCBanThuocKeDon()
        {
            InitializeComponent();
            bsTimKiem = new BindingSource();
            bsDonThuoc = new BindingSource();
            bsCTDonThuoc = new BindingSource();
            bsThuocDaChon = new BindingSource();
            thuocBLL = new ThuocBLL();
            loThuocBLL = new LoThuocBLL();
            donThuocBLL = new DonThuocBLL();
            ctDonThuocBLL = new CTDonThuocBLL();
            bacsiBLL = new BacSiBLL();
            benhnhanBLL = new BenhNhanBLL();
            hoadonBLL = new HoaDonBLL();
            cthdBLL = new CTHoaDonBLL();

            dsThuoc = new List<eThuoc>();
            dsLoThuoc = new List<eLoThuoc>();
            dsDonThuoc = new List<eDonThuoc>();
            dsCTDonThuoc = new List<eCTDonThuoc>();
            dsBacSi = new List<eBacSi>();
            dsBenhNhan = new List<eBenhNhan>();
            dsHoaDon = new List<eHoaDon>();
            dsCTHD = new List<eCTHoaDon>();
            DateTime dt = DateTime.Today;
            lblDate.Text = dt.ToString("dd/MM/yyyy");
            HienThiDonThuoc();
            EnableControl();
            AutoComplete();
        }


        private void UCBanThuocKeDon_Load(object sender, EventArgs e)
        {
            HienThiDonThuoc();
            EnableControl();
            AutoComplete();
        }

        private void HienThiDonThuoc()
        {
            dsDonThuoc = donThuocBLL.LayThongTinDonThuoc();
            dsBenhNhan = benhnhanBLL.LayThongTinBenhNhan();
            var gridviewInfo = dsDonThuoc
                .Join(dsBenhNhan, dt => dt.MaBenhNhan, bn => bn.MaBenhNhan, (dt, bn) => new
                {
                    MaDonThuoc = dt.MaDonThuoc,
                    NgayKeDon = dt.NgayKe,
                    MoTaBenh = dt.MoTaBenh,
                    TenBenhNhan = bn.TenBenhNhan
                }).ToList();
            bsDonThuoc.DataSource = gridviewInfo;
            dgvDanhSachDonThuocKD.DataSource = bsDonThuoc;
        }

        

        private void HienThiCTDonThuoc(string maDT)
        {
            dsCTDonThuoc = ctDonThuocBLL.LayThongTinCTDonThuoc();
            dsThuoc = thuocBLL.LayThongTinThuoc();
            var gridviewInfo = dsCTDonThuoc
                .Join(dsThuoc, ct => ct.MaThuoc, t => t.MaThuoc, (ct, t) => new { ct, t })
                .Where(_ct => _ct.ct.MaDonThuoc.Contains(maDT))
                .Select(_ct => new {
                    MaThuoc = _ct.t.MaThuoc,
                    TenThuoc = _ct.t.TenThuoc,
                    DVT = _ct.ct.DVT,
                    SoLuong = _ct.ct.SoLuong
                }).ToList();
            bsCTDonThuoc.DataSource = gridviewInfo;
            dgvDanhSachThuocKD.DataSource = bsCTDonThuoc;
        }

        

        private void HienThiBenhNhan(string maDT)
        {
            dsBenhNhan = benhnhanBLL.LayThongTinBenhNhan();
            dsDonThuoc = donThuocBLL.LayThongTinDonThuoc();

            var infoBenhNhan = dsDonThuoc
                .Join(dsBenhNhan, dt => dt.MaBenhNhan, bn => bn.MaBenhNhan, (dt, bn) => new { dt, bn })
                .Where(_dt => _dt.dt.MaDonThuoc.Contains(maDT))
                .Select(_dt => new {
                    TenBenhNhan = _dt.bn.TenBenhNhan,
                    GioiTinh = _dt.bn.GioiTinh,
                    NamSinh = _dt.bn.NamSinh,
                    Mota = _dt.dt.MoTaBenh
                }).ToList();

            foreach (var item in infoBenhNhan)
            {
                txtTenKhachHangKD.Text = item.TenBenhNhan;
                txtMoTaKD.Text = item.Mota;
                txtNamSinh.Text = item.NamSinh.ToString();
                if (item.GioiTinh == "nam")
                    rdNam.Checked = true;
                else
                    rdNu.Checked = true;
            }
        }

        private void HienThiBacSi(string maDT)
        {
            bacsiBLL = new BacSiBLL();
            dsBacSi = bacsiBLL.LayThongTinBacSi();
            donThuocBLL = new DonThuocBLL();
            dsDonThuoc = donThuocBLL.LayThongTinDonThuoc();

            var infoBacSi = dsBacSi
                .Join(dsDonThuoc, bs => bs.MaBacSi, dt => dt.MaBacSi, (bs, dt) => new { bs, dt })
                .Where(_dt => _dt.dt.MaDonThuoc.Contains(maDT))
                .Select(_dt => new
                {
                    TenBacSi = _dt.bs.TenBacSi
                }).ToList();
            foreach (var item in infoBacSi)
            {
                txtTenBacSiKD.Text = item.TenBacSi;
            }
        }

        private void dgvThuocDaChonKD_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            tongTien = 0;
            int soLuong;
            decimal donGia;

            try
            {
                Check(dgvThuocDaChonKD.Rows[e.RowIndex].Cells["dongiacol"].Value.ToString());
                soLuong = Convert.ToInt32(dgvThuocDaChonKD.Rows[e.RowIndex].Cells["slton"].Value);
                donGia = Convert.ToDecimal(dgvThuocDaChonKD.Rows[e.RowIndex].Cells["dongiacol"].Value);




                dgvThuocDaChonKD.Rows[e.RowIndex].Cells["tongtiencol"].Value = soLuong * donGia;

                for (int i = 0; i < dgvThuocDaChonKD.Rows.Count; i++)
                {
                    tongTien = tongTien + Convert.ToDecimal(dgvThuocDaChonKD.Rows[i].Cells["tongtiencol"].Value);
                    lblTongTienKD.Text = tongTien.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            tongTien = 0;
            if(dgvThuocDaChonKD.SelectedCells.Count > 0)
            {
                bsCTDonThuoc.Add(bsThuocDaChon.Current);
                dgvDanhSachThuocKD.DataSource = bsCTDonThuoc;
                bsThuocDaChon.RemoveCurrent();

                if(bsThuocDaChon.Count == 0)
                {
                    lblTongTienKD.Text = tongTien.ToString();
                }
                else
                {
                    for(int i = 0; i<dgvThuocDaChonKD.Rows.Count; i++)
                    {
                        tongTien += Convert.ToDecimal(dgvThuocDaChonKD.Rows[i].Cells["tongtiencol"].Value);
                        lblTongTienKD.Text = tongTien.ToString();
                    }
                }
                btnThem.Enabled = true;
                if(dgvThuocDaChonKD.Rows.Count == 0)
                {
                    btnHuy.Enabled = false;
                    btnTaoLaiKD.Enabled = false;
                    btnLapHoaDonKD.Enabled = false;
                }

            }
            lockDgvDonThuoc(dgvThuocDaChonKD.Rows.Count);
        }

        

        private void dgvDanhSachDonThuocKD_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            string maDT = this.dgvDanhSachDonThuocKD.Rows[e.RowIndex].Cells[0].Value.ToString();
            HienThiBacSi(maDT);
            HienThiBenhNhan(maDT);
            HienThiCTDonThuoc(maDT);
            if (dgvDanhSachThuocKD.Rows.Count > 0)
            {
                btnThem.Enabled = true;
            }
        }

        private void btnTaoLaiKD_Click(object sender, EventArgs e)
        {
            lblTongTienKD.Text = "0";
            btnThem.Enabled = true;
            btnHuy.Enabled = false;
            while (dgvThuocDaChonKD.Rows.Count != 0)
            {
                dgvThuocDaChonKD.Rows[0].Selected = true;
                bsCTDonThuoc.Add(bsThuocDaChon.Current);
                bsThuocDaChon.RemoveCurrent();
                
            }
            dgvDanhSachThuocKD.DataSource = bsCTDonThuoc;
            lockDgvDonThuoc(dgvThuocDaChonKD.Rows.Count);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            dsLoThuoc = loThuocBLL.LayThongTinLoThuoc();
            int soLuong;
            decimal donGia;
            string maThuoc = "";
            if(dgvDanhSachThuocKD.SelectedCells.Count > 0)
            {
                btnLapHoaDonKD.Enabled = true;
                btnTaoLaiKD.Enabled = true;
                maThuoc = dgvDanhSachThuocKD.SelectedCells[0].OwningRow.Cells["MaThuoc"].Value.ToString();
                bsThuocDaChon.Add(bsCTDonThuoc.Current);
                bsCTDonThuoc.RemoveCurrent();
                if(isThem == false)
                {
                    dgvThuocDaChonKD.Columns.Add("malocol", "MaLoThuoc");
                    dgvThuocDaChonKD.DataSource = bsThuocDaChon;
                    dgvThuocDaChonKD.Columns.Add("slton", "So Luong Con");
                    dgvThuocDaChonKD.Columns.Add("dongiacol", "Don Gia");
                    dgvThuocDaChonKD.Columns.Add("tongtiencol", "TongTien");
                    isThem = true;
                }
                else
                {
                    dgvThuocDaChonKD.DataSource = bsThuocDaChon;
                }
                btnHuy.Enabled = true;
            }

            var thongtinLoThuoc = dsLoThuoc.Where(lt => lt.MaThuoc.Equals(maThuoc)).ToList();
            dgvThuocDaChonKD.Rows[dgvThuocDaChonKD.Rows.Count - 1].Cells["malocol"].Value = thongtinLoThuoc.First().MaLoThuoc;
            dgvThuocDaChonKD.Rows[dgvThuocDaChonKD.Rows.Count - 1].Cells["dongiacol"].Value = thongtinLoThuoc.First().DonGia;
            dgvThuocDaChonKD.Rows[dgvThuocDaChonKD.Rows.Count - 1].Cells["slton"].Value = thongtinLoThuoc.First().SoLuong;
            if((int)dgvThuocDaChonKD.Rows[dgvThuocDaChonKD.Rows.Count - 1].Cells["slton"].Value < (int)dgvThuocDaChonKD.Rows[dgvThuocDaChonKD.Rows.Count - 1].Cells["SoLuong"].Value)
            {
                dgvThuocDaChonKD.Rows[dgvThuocDaChonKD.Rows.Count - 1].Cells["slton"].Style.ForeColor = Color.Red;
            }

            soLuong = Convert.ToInt32(dgvThuocDaChonKD.Rows[dgvThuocDaChonKD.Rows.Count - 1].Cells["slton"].Value);
            donGia = Convert.ToDecimal(dgvThuocDaChonKD.Rows[dgvThuocDaChonKD.Rows.Count - 1].Cells["dongiacol"].Value);
            dgvThuocDaChonKD.Rows[dgvThuocDaChonKD.Rows.Count - 1].Cells["tongtiencol"].Value = soLuong * donGia;

            tongTien = tongTien + Convert.ToDecimal(dgvThuocDaChonKD.Rows[dgvThuocDaChonKD.Rows.Count - 1].Cells["tongtiencol"].Value);
            lblTongTienKD.Text = tongTien.ToString();

            if(dgvDanhSachThuocKD.Rows.Count == 0)
            {
                btnThem.Enabled = false;
            }

            dgvThuocDaChonKD.Columns["tongtiencol"].ReadOnly = true;
            dgvThuocDaChonKD.Columns["slton"].ReadOnly = true;
            lockDgvDonThuoc(dgvThuocDaChonKD.Rows.Count);
        }

        private void txtTimKiemDonThuocKD_TextChanged(object sender, EventArgs e)
        {
            dsDonThuoc = donThuocBLL.LayThongTinDonThuoc();
            dsBenhNhan = benhnhanBLL.LayThongTinBenhNhan();
            var gridviewInfo = dsDonThuoc
                .Join(dsBenhNhan, dt => dt.MaBenhNhan, bn => bn.MaBenhNhan, (dt, bn) => new { dt, bn })
                .Where(w => w.dt.MaDonThuoc.Contains(txtTimKiemDonThuocKD.Text))
                .Select(s => new
                {
                    MaDonThuoc = s.dt.MaDonThuoc,
                    NgayKeDon = s.dt.NgayKe,
                    MoTaBenh = s.dt.MoTaBenh,
                    TenBenhNhan = s.bn.TenBenhNhan
                }).ToList();
                
                    
                
            bsDonThuoc.DataSource = gridviewInfo;
            dgvDanhSachDonThuocKD.DataSource = bsDonThuoc;
        }

        private void btnLapHoaDonKD_Click(object sender, EventArgs e)
        {
            try
            {
                dsHoaDon = hoadonBLL.LayThongTinHoaDon().OrderBy(o => o.MaHoaDon).ToList();
                dsBenhNhan = benhnhanBLL.LayThongTinBenhNhan();
                dsLoThuoc = loThuocBLL.LayThongTinLoThuoc();

                var timKiemBN = dsBenhNhan.Where(w => w.TenBenhNhan.Equals(txtTenKhachHangKD.Text)).ToList();

                eHoaDon newHD = new eHoaDon();
                if (dsHoaDon.Count == 0)
                {
                    newHD.MaHoaDon = "1";
                }
                else
                {
                    newHD.MaHoaDon = (Convert.ToInt32(dsHoaDon.Last().MaHoaDon) + 1).ToString();
                }
                newHD.MaNhanVien = "1";
                newHD.MaBenhNhan = timKiemBN.First().MaBenhNhan;
                newHD.NgayLapHD = DateTime.Now;
                newHD.TongTien = Convert.ToDecimal(lblTongTienKD.Text);
                newHD.MaDonThuoc = dgvDanhSachDonThuocKD.SelectedCells[0].OwningRow.Cells["MaDonThuoc"].Value.ToString();
                hoadonBLL.ThemThongTinHoaDon(newHD);
                for (int i = 0; i < dgvThuocDaChonKD.Rows.Count; i++)
                {
                    Check(dgvThuocDaChonKD.Rows[i].Cells["dongiacol"].Value.ToString());
                    var timKiemLT = dsLoThuoc.Where(w => w.MaLoThuoc.Equals(dgvThuocDaChonKD.Rows[i].Cells["malocol"].Value.ToString())).ToList();

                    eCTHoaDon newCTHD = new eCTHoaDon();
                    if (dsHoaDon.Count == 0)
                    {
                        newCTHD.MaHoaDon = "1";
                    }
                    else
                    {
                        newCTHD.MaHoaDon = (Convert.ToInt32(dsHoaDon.Last().MaHoaDon) + 1).ToString();
                    }
                    newCTHD.MaLoThuoc = dgvThuocDaChonKD.Rows[i].Cells["malocol"].Value.ToString();
                    newCTHD.DVT = dgvThuocDaChonKD.Rows[i].Cells["DVT"].Value.ToString();
                    if ((int)dgvThuocDaChonKD.Rows[i].Cells["SoLuong"].Value <= (int)dgvThuocDaChonKD.Rows[i].Cells["slton"].Value)
                    {
                        newCTHD.SoLuong = Convert.ToInt32((dgvThuocDaChonKD.Rows[i].Cells["SoLuong"].Value));
                        loThuocBLL.CapNhatSoLuongLoThuoc(dgvThuocDaChonKD.Rows[i].Cells["malocol"].Value.ToString(), timKiemLT.First().SoLuong - Convert.ToInt32((dgvThuocDaChonKD.Rows[i].Cells["SoLuong"].Value)));
                    }
                    else
                    {
                        newCTHD.SoLuong = Convert.ToInt32((dgvThuocDaChonKD.Rows[i].Cells["slton"].Value));
                        loThuocBLL.CapNhatSoLuongLoThuoc(dgvThuocDaChonKD.Rows[i].Cells["malocol"].Value.ToString(), timKiemLT.First().SoLuong - Convert.ToInt32((dgvThuocDaChonKD.Rows[i].Cells["slton"].Value)));
                    }

                    newCTHD.GiaBan = Convert.ToDecimal((dgvThuocDaChonKD.Rows[i].Cells["dongiacol"].Value));

                    cthdBLL.ThemThongTinCTHoaDon(newCTHD);
                    MessageBox.Show("Tao Hoa Don Thanh Cong");
                    btnTaoLaiKD_Click(sender, e);
                    UCBanThuocKeDon_Load(sender, e);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void LoadSauKhiLapHD()
        {
            lblTongTienKD.Text = "0";
            btnThem.Enabled = true;
            btnHuy.Enabled = false;
            while (dgvThuocDaChonKD.Rows.Count != 0)
            {
                dgvThuocDaChonKD.Rows[0].Selected = true;
                bsThuocDaChon.RemoveCurrent();

            }
        }

        private void EnableControl()
        {
            panel7.Enabled = false;
            btnThem.Enabled = btnHuy.Enabled = false;
        }
        
        private void DiableBTN()
        {
            if(dgvThuocDaChonKD.Rows.Count > 0)
            {
                btnTaoLaiKD.Enabled = btnLapHoaDonKD.Enabled = true;
            }
            else
            {
                btnTaoLaiKD.Enabled = btnLapHoaDonKD.Enabled = false;
            }
        }
        
        private void lockDgvDonThuoc(int i)
        {
            if(i == 0)
            {
                dgvDanhSachDonThuocKD.Enabled = true;
            }
            else
            {
                dgvDanhSachDonThuocKD.Enabled = false;
            }
        }

        private void AutoComplete()
        {
            dsDonThuoc = donThuocBLL.LayThongTinDonThuoc();
            txtTimKiemDonThuocKD.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtTimKiemDonThuocKD.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();

            foreach (var item in dsDonThuoc)
            {
                col.Add(item.MaDonThuoc);
            }
            txtTimKiemDonThuocKD.AutoCompleteCustomSource = col;
        }

        private void Check(string checkString)
        {
            if(checkString == null)
            {
                throw new Exception ("Khong duoc de trong");
            }
            else if(!Regex.IsMatch(checkString, "[0-9]([.,][0-9]{1,3})?$"))
            {
                throw new Exception("Don gia khong hop le, vui long nhap lai");
            }
        }

        
    }
}
