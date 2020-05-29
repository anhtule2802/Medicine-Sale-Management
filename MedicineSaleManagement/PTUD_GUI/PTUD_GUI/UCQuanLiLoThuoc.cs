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
    public partial class UCQuanLiLoThuoc : UserControl
    {
        bool isThem = false;
        bool isSua = false;

        

        NccBLL nccBLL;
        LoThuocBLL lothuocBLL;
        ThuocBLL thuocBLL;
        BindingSource bsLoThuocBan, bsLoThuocKho;

        List<eNCC> dsNCC;
        List<eLoThuoc> dsLoThuoc;
        List<eThuoc> dsThuoc;

        public UCQuanLiLoThuoc()
        {
            InitializeComponent();

            nccBLL = new NccBLL();
            lothuocBLL = new LoThuocBLL();
            thuocBLL = new ThuocBLL();

            dsNCC = new List<eNCC>();
            dsLoThuoc = new List<eLoThuoc>();
            dsThuoc = new List<eThuoc>();

            bsLoThuocBan = new BindingSource();
            bsLoThuocKho = new BindingSource();

            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            dsLoThuoc = lothuocBLL.LayThongTinLoThuoc().OrderBy(o => o.MaLoThuoc).ToList();
            if (isThem == false)
            {
                isThem = true;
                EnableControl(true);
                btnThem.Text = "Hủy";
                btnLuu.Enabled = true;
                btnSua.Enabled = false;
                btnThem.BackColor = Color.Red;
                ClearTXT();
                if(dsLoThuoc.Count == 0)
                {
                    txtMaLoThuoc.Text = "1";
                }
                else
                {
                    txtMaLoThuoc.Text = (Convert.ToInt32(dsLoThuoc.Last().MaLoThuoc) + 1).ToString();
                }
                dgvDanhSachThuoc.Enabled = false;
                
            }
            else
            {
                isThem = false;
                EnableControl(false);
                btnThem.Text = "Thêm";
                btnLuu.Enabled = false;
                btnSua.Enabled = true;
                btnThem.BackColor = Color.DodgerBlue;
                dgvDanhSachThuoc.Enabled = true;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
            if (isSua == false)
            {
                isSua = true;
                EnableControl(true);
                btnSua.Text = "Hủy";
                btnLuu.Enabled = true;
                btnThem.Enabled = false;
                btnSua.BackColor = Color.Red;
                dgvDanhSachThuoc.Enabled = false;
                
            }
            else
            {
                isSua = false;
                EnableControl(false);
                btnSua.Text = "Sửa";
                btnLuu.Enabled = false;
                btnThem.Enabled = true;
                btnSua.BackColor = Color.LimeGreen;
                dgvDanhSachThuoc.Enabled = true;
            }
        }

        private void EnableControl(bool e)
        {
            txtGiaBan.ReadOnly = !e;
            cboLoaiThuoc.Enabled = cbbNCC.Enabled = cbbDVT.Enabled = nmrSL.Enabled = dtpNgayNhap.Enabled = dtpNgayHetHan.Enabled
                = rdoTinhTrang1.Enabled = rdoTinhTrang2.Enabled = e;

        }

        private void ClearTXT()
        {
            cboLoaiThuoc.SelectedIndex = 0;
            cbbNCC.SelectedIndex = 0;
            cbbDVT.SelectedIndex = 0;
            nmrSL.Value = 10;
            rdoTinhTrang1.Checked = true;
            dtpNgayNhap.Value = DateTime.Now;
            dtpNgayHetHan.Value = DateTime.Now.AddDays(10);
            txtGiaBan.Clear();
        }

        private void CbbInfo()
        {
            dsNCC = nccBLL.LayThongTinNCC();
            dsThuoc = thuocBLL.LayThongTinThuoc();

            cbbNCC.DataSource = dsNCC;
            cbbNCC.ValueMember = "MaNCC";
            cbbNCC.DisplayMember = "TenNCC";

            cboLoaiThuoc.DataSource = dsThuoc;
            cboLoaiThuoc.ValueMember = "MaThuoc";
            cboLoaiThuoc.DisplayMember = "TenThuoc";
        }

        private void HienThiThongTinLoThuoc()
        {
            dsThuoc = thuocBLL.LayThongTinThuoc();
            dsLoThuoc = lothuocBLL.LayThongTinLoThuoc();
            dsNCC = nccBLL.LayThongTinNCC();

            var gridViewInfo = dsThuoc
                .Join(dsLoThuoc, t => t.MaThuoc, lt => lt.MaThuoc, (t, lt) => new { t, lt })
                .Where(w => w.lt.TrangThai == 1)
                .Select(s => new
                {
                    MaLoThuoc = s.lt.MaLoThuoc,
                    MaNCC = s.lt.MaNCC,
                    TenThuoc = s.t.TenThuoc,
                    DVT = s.lt.DVT,
                    SoLuong = s.lt.SoLuong,
                    NgayNhap = s.lt.NgayNhap.ToString("dd/MM/yyyy"),
                    NgayHetHan = s.lt.NgayHetHan.ToString("dd/MM/yyyy"),
                    TinhTrang = s.lt.TrangThai,
                    GiaBan = s.lt.DonGia
                }).ToList();
               

            bsLoThuocBan.DataSource = gridViewInfo;
            dgvDanhSachThuoc.DataSource = bsLoThuocBan;
                
        }

        private void dgvDanhSachThuoc_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            HienThiThongTinControl();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                CheckError();
                if (isThem == true)
                {
                    eLoThuoc newLT = new eLoThuoc();
                    newLT.MaLoThuoc = txtMaLoThuoc.Text;
                    newLT.MaThuoc = cboLoaiThuoc.SelectedValue.ToString();
                    newLT.MaNCC = cbbNCC.SelectedValue.ToString();
                    newLT.DVT = cbbDVT.Text;
                    newLT.SoLuong = Convert.ToInt32(nmrSL.Value);
                    newLT.DonGia = Convert.ToDecimal(txtGiaBan.Text);
                    newLT.NgayNhap = dtpNgayNhap.Value;
                    newLT.NgayHetHan = dtpNgayHetHan.Value;
                    newLT.TrangThai = 0;
                    lothuocBLL.ThemThongTinLoThuoc(newLT);
                    MessageBox.Show("Them thanh cong");
                    ClearTXT();
                    EnableControl(false);
                    isThem = false;
                    btnThem.Text = "Them";
                    btnSua.Enabled = true;
                    btnLuu.Enabled = false;
                    btnThem.BackColor = Color.DodgerBlue;
                    UCQuanLiLoThuoc_Load(sender, e);
                    dgvDanhSachThuoc.Enabled = true;
                }
                else
                {
                    string mlt = txtMaLoThuoc.Text;
                    string mncc = cboLoaiThuoc.SelectedValue.ToString();
                    string mt = cboLoaiThuoc.SelectedValue.ToString();
                    string dvt = cbbDVT.Text;
                    int sl = Convert.ToInt32(nmrSL.Value);
                    decimal dg = Convert.ToDecimal(txtGiaBan.Text);
                    DateTime nn = dtpNgayNhap.Value;
                    DateTime nhh = dtpNgayHetHan.Value;
                    int tt = 0;
                    lothuocBLL.CapNhatThongTinLoThuoc(mlt, mncc, mt, sl, dvt, dg, nn, nhh, tt);
                    isSua = false;
                    btnSua.Text = "Sua";
                    btnThem.Enabled = true;
                    btnLuu.Enabled = false;
                    btnSua.BackColor = Color.LimeGreen;
                    UCQuanLiLoThuoc_Load(sender, e);
                    dgvDanhSachThuoc.Enabled = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void UCQuanLiLoThuoc_Load(object sender, EventArgs e)
        {
            EnableControl(false);
            CbbInfo();
            HienThiThongTinLoThuoc();
        }

        private void txtGiaBan_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if(!Regex.IsMatch(ctr.Text, "[0-9]([.,][0-9]{1,3})?$"))
            {
                errorProvider1.SetError(ctr, "Gia ban khong hop le");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void HienThiThongTinControl()
        {
            if(dgvDanhSachThuoc.SelectedCells.Count > 0)
            {
                txtMaLoThuoc.Text = dgvDanhSachThuoc.SelectedCells[0].OwningRow.Cells["MaLoThuoc"].Value.ToString();
                cbbNCC.SelectedValue = dgvDanhSachThuoc.SelectedCells[0].OwningRow.Cells["MaNCC"].Value;
                cbbDVT.Text = dgvDanhSachThuoc.SelectedCells[0].OwningRow.Cells["DVT"].Value.ToString();
                nmrSL.Value = Convert.ToInt32(dgvDanhSachThuoc.SelectedCells[0].OwningRow.Cells["SoLuong"].Value);
                //dtpNgayNhap.Text = dgvDanhSachThuoc.SelectedCells[0].OwningRow.Cells["NgayNhap"].Value.ToString();
                //dtpNgayHetHan.Text = dgvDanhSachThuoc.SelectedCells[0].OwningRow.Cells["NgayHetHan"].Value.ToString();
                dtpNgayNhap.Value = DateTime.ParseExact(dgvDanhSachThuoc.SelectedCells[0].OwningRow.Cells["NgayNhap"].Value.ToString(), "dd/MM/yyyy", null);
                dtpNgayHetHan.Value = DateTime.ParseExact(dgvDanhSachThuoc.SelectedCells[0].OwningRow.Cells["NgayHetHan"].Value.ToString(), "dd/MM/yyyy", null);
                txtGiaBan.Text = dgvDanhSachThuoc.SelectedCells[0].OwningRow.Cells["GiaBan"].Value.ToString();

            }
        }

        private void txtGiaBan_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if(ctr.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(ctr, "Gia ban khong duoc de trong");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void dtpNgayHetHan_ValueChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            TimeSpan temp = dtpNgayHetHan.Value - dtpNgayNhap.Value;
            int day = temp.Days + 1;
            if(day < 10)
            {
                errorProvider1.SetError(ctr, "Ngay het han va ngay nhap phai cach nhau 10 ngay");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void CheckError()
        {
            TimeSpan temp = dtpNgayHetHan.Value - dtpNgayNhap.Value;
            int day = temp.Days + 1;
            if (day < 10)
            {
                throw new Exception("Ngay nhap khong hop le, vui long nhap lai");
            }
            else if(!Regex.IsMatch(txtGiaBan.Text, "[0-9]([.,][0-9]{1,3})?$"))
            {
                throw new Exception("Gia ban khong hop le, vui long nhap lai");
            }
            else if(txtGiaBan.Text.Trim().Length == 0)
            {
                throw new Exception("Vui long nhap day du thong tin ");
            }
        }
    }
}
