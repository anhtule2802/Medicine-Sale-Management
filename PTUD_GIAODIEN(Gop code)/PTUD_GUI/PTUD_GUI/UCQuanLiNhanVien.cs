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
    public partial class UCQuanLiNhanVien : UserControl
    {
        
        

        bool isThem = false;
        bool isSua = false;
        NhanVienBLL nhanvienBLL;

        List<eNVBanThuoc> dsNVBT;
        List<eNVThongKe> dsNVTK;
        List<eNhanVien> dsNV;

        BindingSource bsNVBT, bsNVTK;
        public UCQuanLiNhanVien()
        {
            InitializeComponent();
            
            nhanvienBLL = new NhanVienBLL();
            dsNVBT = new List<eNVBanThuoc>();
            dsNVTK = new List<eNVThongKe>();
            dsNV = new List<eNhanVien>();
            bsNVBT = new BindingSource();
            bsNVTK = new BindingSource();

            EnableControl(false);
            HienThiThongTinNhanVien();

            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            dsNV = nhanvienBLL.LayThongTinNhanVien();
            if (isThem == false)
            {
                isThem = true;
                EnableControl(true);
                btnThem.Text = "Hủy";
                btnLuu.Enabled = true;
                btnSua.Enabled = false;
                btnThem.BackColor = Color.Red;
                clearTXT();
                tabpageQLNV.Enabled = false;
                if(dsNV.Count == 0)
                {
                    txtMaNhanVien.Text = "0";
                }
                else
                {
                    txtMaNhanVien.Text = (Convert.ToInt32(dsNV.Last().MaNhanVien) + 1).ToString();
                }
            }
            else
            {
                isThem = false;
                EnableControl(false);
                btnThem.Text = "Thêm";
                btnLuu.Enabled = false;
                btnSua.Enabled = true;
                btnThem.BackColor = Color.DodgerBlue;
                tabpageQLNV.Enabled = true;
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
                tabpageQLNV.Enabled = false;
            }
            else
            {
                isSua = false;
                EnableControl(false);
                btnSua.Text = "Sửa";
                btnLuu.Enabled = false;
                btnThem.Enabled = true;
                btnSua.BackColor = Color.LimeGreen;
                tabpageQLNV.Enabled = true;
            }
        }

        private void EnableControl(bool e)
        {
            txtTenNhanVien.ReadOnly = txtSoDienThoai.ReadOnly = txtEmail.ReadOnly = !e;
            rdNam.Enabled = rdNu.Enabled = cbbThanhPho.Enabled = cboLoaiNhanVien.Enabled = cboCaLamViec.Enabled = dtpNgay.Enabled = e;
        }

        private void clearTXT()
        {
            txtTenNhanVien.Clear();
            txtSoDienThoai.Clear();
            txtEmail.Clear();
            rdNam.Checked = true;
            cbbThanhPho.SelectedIndex = 0;
            cboLoaiNhanVien.SelectedIndex = 0;
            cboCaLamViec.SelectedIndex = 0;
            dtpNgay.Value = DateTime.Now;
            cbTinhTrang1.Checked = true;
        }

        private void HienThiThongTinNhanVien()
        {
            dsNVBT = nhanvienBLL.LayThongTinNhanVienBanThuoc();
            dsNVTK = nhanvienBLL.LayThongTinNhanVienThongKe();

            var dgvInfo1 = dsNVBT.Select(bt => new
            {
                MaNhanVien = bt.MaNhanVien,
                TenNhanVien = bt.TenNhanVien,
                GioiTinh = bt.GioiTinh,
                SDT = bt.SDT,
                DiaChi = bt.DiaChi,
                Email = bt.Email,
                NgayLamViec = bt.NgayLamViec.ToString("dd/MM/yyyy"),
                CaLamViec = bt.CaLamViec,
                TinhTrang = bt.TinhTrang
            }).ToList();

            var dgvInfo2 = dsNVTK.Select(tk => new
            {
                MaNhanVien = tk.MaNhanVien,
                TenNhanVien = tk.TenNhanVien,
                GioiTinh = tk.GioiTinh,
                SDT = tk.SDT,
                DiaChi = tk.DiaChi,
                Email = tk.Email,
                NgayLamViec = tk.NgayLamViec.ToString("dd/MM/yyyy"),
                TinhTrang = tk.TinhTrang
            }).ToList();

            bsNVBT.DataSource = dgvInfo1;
            dgvNVBT.DataSource = bsNVBT;

            bsNVTK.DataSource = dgvInfo2;
            dgvNVTK.DataSource = bsNVTK;
        }

        private void cbTinhTrang1_CheckedChanged(object sender, EventArgs e)
        {
            if(cbTinhTrang1.Checked == true)
            {
                cbTinhTrang2.Checked = false;
            }
            else
            {
                cbTinhTrang2.Checked = true;
            }
        }

        private void cbTinhTrang2_CheckedChanged(object sender, EventArgs e)
        {
            if(cbTinhTrang2.Checked == true)
            {
                cbTinhTrang1.Checked = false;
            }
            else
            {
                cbTinhTrang1.Checked = true;
            }
        }

        private void dgvNVBT_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            HienThiThongTinControl();
        }

        private void dgvNVTK_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            HienThiThongTinControl();
        }

        private void cboLoaiNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLoaiNhanVien.SelectedIndex == 0 && cboLoaiNhanVien.Enabled == true)
            {
                cboCaLamViec.Enabled = true;
            }
            else
            {
                cboCaLamViec.Enabled = false;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                CheckTxt();
                if (isThem == true)
                {
                    eNhanVien newNV = new eNhanVien();
                    eNVBanThuoc newNVBT = new eNVBanThuoc();
                    eNVThongKe newNVTK = new eNVThongKe();
                    newNV.MaNhanVien = txtMaNhanVien.Text;
                    newNV.TenNhanVien = txtTenNhanVien.Text;
                    newNV.SDT = txtSoDienThoai.Text;
                    newNV.Email = txtEmail.Text;
                    newNV.DiaChi = cbbThanhPho.Text;
                    if (rdNam.Checked == true)
                    {
                        newNV.GioiTinh = "nam";
                    }
                    else
                    {
                        newNV.GioiTinh = "nu";
                    }
                    if (cbTinhTrang1.Checked == true)
                    {
                        newNV.TinhTrang = 1;
                    }
                    else
                    {
                        newNV.TinhTrang = 0;
                    }

                    nhanvienBLL.ThemNhanVien(newNV);

                    if (cboLoaiNhanVien.SelectedIndex == 0)//Neu chon loai nhan vien la nhan vien ban thuoc
                    {
                        newNVBT.MaNhanVien = txtMaNhanVien.Text;
                        newNVBT.CaLamViec = cboCaLamViec.Text;
                        newNVBT.NgayLamViec = dtpNgay.Value;
                        nhanvienBLL.ThemNVBanThuoc(newNVBT);
                        tabpageQLNV.Enabled = true;
                        tabpageQLNV.SelectedIndex = 0;
                    }
                    else
                    {
                        newNVTK.MaNhanVien = txtMaNhanVien.Text;
                        newNVTK.NgayLamViec = dtpNgay.Value;
                        nhanvienBLL.ThemNVThongKe(newNVTK);
                        tabpageQLNV.Enabled = true;
                        tabpageQLNV.SelectedIndex = 1;
                    }
                    MessageBox.Show("Them thanh cong");
                    EnableControl(false);
                    isThem = false;
                    btnThem.Text = "Them";
                    btnThem.BackColor = Color.DodgerBlue;
                    btnSua.Enabled = true;
                    btnLuu.Enabled = false;
                    HienThiThongTinNhanVien();
                }
                else
                {
                    string mnv = txtMaNhanVien.Text;
                    string tnv = txtTenNhanVien.Text;
                    string sdt = txtSoDienThoai.Text;
                    string email = txtEmail.Text;
                    string dc = cbbThanhPho.Text;
                    string gt;
                    int tt;
                    if (rdNam.Checked == true)
                    {
                        gt = "nam";
                    }
                    else
                    {
                        gt = "nu";
                    }
                    if (cbTinhTrang1.Checked == true)
                    {
                        tt = 1;
                    }
                    else
                    {
                        tt = 0;
                    }
                    nhanvienBLL.CapNhatThongTinNhanVien(mnv, tnv, gt, sdt, dc, email, tt);
                    if (tabpageQLNV.SelectedIndex == 0)
                    {
                        string mnvBT, caLamViec;
                        DateTime ngayLamViec;
                        if (cboLoaiNhanVien.SelectedIndex == 0)
                        {
                            mnvBT = txtMaNhanVien.Text;
                            caLamViec = cboCaLamViec.Text;
                            ngayLamViec = dtpNgay.Value;
                            nhanvienBLL.CapNhatThongTinNVBT(mnvBT, ngayLamViec, caLamViec);
                            MessageBox.Show("Cap Nhat Thanh Cong");
                            EnableControl(false);
                            isSua = false;
                            btnSua.Text = "Sua";
                            btnSua.BackColor = Color.LimeGreen;
                            btnThem.Enabled = true;
                            btnLuu.Enabled = false;
                            HienThiThongTinNhanVien();
                            tabpageQLNV.Enabled = true;
                        }
                        else
                        {
                            eNVThongKe newNVTK = new eNVThongKe();
                            mnvBT = newNVTK.MaNhanVien = txtMaNhanVien.Text;
                            newNVTK.NgayLamViec = dtpNgay.Value;
                            nhanvienBLL.XoaThongTinNVBT(mnvBT);
                            nhanvienBLL.ThemNVThongKe(newNVTK);
                            MessageBox.Show("Cap Nhat Thanh Cong");
                            EnableControl(false);
                            isSua = false;
                            btnSua.Text = "Sua";
                            btnSua.BackColor = Color.LimeGreen;
                            btnThem.Enabled = true;
                            btnLuu.Enabled = false;
                            HienThiThongTinNhanVien();
                            tabpageQLNV.Enabled = true;
                        }
                    }
                    else
                    {
                        string mnvTK, caLamViec;
                        DateTime ngayLamViec;
                        if (cboLoaiNhanVien.SelectedIndex == 1)
                        {
                            mnvTK = txtMaNhanVien.Text;
                            ngayLamViec = dtpNgay.Value;
                            nhanvienBLL.CapNhatThongTinNVTK(mnvTK, ngayLamViec);
                            MessageBox.Show("Cap Nhat Thanh Cong");
                            EnableControl(false);
                            isSua = false;
                            btnSua.Text = "Sua";
                            btnSua.BackColor = Color.LimeGreen;
                            btnThem.Enabled = true;
                            btnLuu.Enabled = false;
                            HienThiThongTinNhanVien();
                            tabpageQLNV.Enabled = true;
                        }
                        else
                        {
                            eNVBanThuoc newNVBT = new eNVBanThuoc();
                            mnvTK = newNVBT.MaNhanVien = txtMaNhanVien.Text;
                            ngayLamViec = dtpNgay.Value;
                            caLamViec = cboCaLamViec.Text;
                            nhanvienBLL.XoaThongTinNVTK(mnvTK);
                            nhanvienBLL.ThemNVBanThuoc(newNVBT);
                            MessageBox.Show("Cap Nhat Thanh Cong");
                            EnableControl(false);
                            isSua = false;
                            btnSua.Text = "Sua";
                            btnSua.BackColor = Color.LimeGreen;
                            btnThem.Enabled = true;
                            btnLuu.Enabled = false;
                            HienThiThongTinNhanVien();
                            tabpageQLNV.Enabled = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        

        private void HienThiThongTinControl()
        {
            if(tabpageQLNV.SelectedIndex == 0)
            {
                if(dgvNVBT.SelectedCells.Count > 0)
                {
                    txtMaNhanVien.Text = dgvNVBT.SelectedCells[0].OwningRow.Cells["MaNhanVien"].Value.ToString();
                    txtTenNhanVien.Text = dgvNVBT.SelectedCells[0].OwningRow.Cells["TenNhanVien"].Value.ToString();
                    txtSoDienThoai.Text = dgvNVBT.SelectedCells[0].OwningRow.Cells["SDT"].Value.ToString();
                    cbbThanhPho.Text = dgvNVBT.SelectedCells[0].OwningRow.Cells["DiaChi"].Value.ToString();
                    txtEmail.Text = dgvNVBT.SelectedCells[0].OwningRow.Cells["Email"].Value.ToString();
                    cboLoaiNhanVien.SelectedIndex = 0;
                    cboCaLamViec.Text = dgvNVBT.SelectedCells[0].OwningRow.Cells["CaLamViec"].Value.ToString();
                    dtpNgay.Value = DateTime.ParseExact(dgvNVBT.SelectedCells[0].OwningRow.Cells["NgayLamViec"].Value.ToString(), "dd/MM/yyyy", null);
                    if(dgvNVBT.SelectedCells[0].OwningRow.Cells["GioiTinh"].Value.ToString().Equals("nam"))
                    {
                        rdNam.Checked = true;
                    }
                    else
                    {
                        rdNu.Checked = true;
                    }
                    if((int)dgvNVBT.SelectedCells[0].OwningRow.Cells["TinhTrang"].Value == 1)
                    {
                        cbTinhTrang1.Checked = true;
                    }
                    else
                    {
                        cbTinhTrang2.Checked = true;
                    }
                }
            }
            else
            {
                if(dgvNVTK.SelectedCells.Count > 0)
                {
                    txtMaNhanVien.Text = dgvNVTK.SelectedCells[0].OwningRow.Cells["MaNhanVien"].Value.ToString();
                    txtTenNhanVien.Text = dgvNVTK.SelectedCells[0].OwningRow.Cells["TenNhanVien"].Value.ToString();
                    txtSoDienThoai.Text = dgvNVTK.SelectedCells[0].OwningRow.Cells["SDT"].Value.ToString();
                    cbbThanhPho.Text = dgvNVTK.SelectedCells[0].OwningRow.Cells["DiaChi"].Value.ToString();
                    txtEmail.Text = dgvNVTK.SelectedCells[0].OwningRow.Cells["Email"].Value.ToString();
                    cboLoaiNhanVien.SelectedIndex = 1;
                    cboCaLamViec.Text = "";
                    dtpNgay.Value = DateTime.ParseExact(dgvNVTK.SelectedCells[0].OwningRow.Cells["NgayLamViec"].Value.ToString(), "dd/MM/yyyy", null);
                    if (dgvNVTK.SelectedCells[0].OwningRow.Cells["GioiTinh"].Value.ToString().Equals("nam"))
                    {
                        rdNam.Checked = true;
                    }
                    else
                    {
                        rdNu.Checked = true;
                    }
                    if ((int)dgvNVTK.SelectedCells[0].OwningRow.Cells["TinhTrang"].Value == 1)
                    {
                        cbTinhTrang1.Checked = true;
                    }
                    else
                    {
                        cbTinhTrang2.Checked = true;
                    }
                }
            }
        }

        private void txtSoDienThoai_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(ctr, "Khong duoc bo trong");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(ctr, "Khong duoc bo trong");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtSoDienThoai_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if(Regex.IsMatch(ctr.Text, "[^0-9]+"))
            {
                errorProvider1.SetError(ctr, "So dien thoai phai la so");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if(!Regex.IsMatch(ctr.Text, @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9-]+.+.[A-Za-z]{2,4}$"))
            {
                errorProvider1.SetError(ctr, "Email khong hop le");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtTenNhanVien_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(ctr, "Khong duoc bo trong");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void CheckTxt()
        {
            if(Regex.IsMatch(txtSoDienThoai.Text, "[^0-9]+"))
            {
                throw new Exception("So dien thoai khong phu hop, vui long nhap lai");
            }
            else if(!Regex.IsMatch(txtEmail.Text, @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9-]+.+.[A-Za-z]{2,4}$"))
            {
                throw new Exception("Email khong hop le, vui long nhap lai");
            }
            else if(txtTenNhanVien.Text.Trim().Length == 0 || txtSoDienThoai.Text.Trim().Length == 0 || txtEmail.Text.Trim().Length == 0)
            {
                throw new Exception("Vui long nhap day du thong tin");
            }
        }



    }
}
