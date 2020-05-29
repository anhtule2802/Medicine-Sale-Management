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
    public partial class UCBanThuocKhongKeDon : UserControl
    {
        

        bool isDongY = false;
        bool isThem = false;
        decimal tongTien = 0m;
        BindingSource bsDSLoThuoc, bsThuocDaChon, bsTimKiem;
        LoaiThuocBLL loaithuocBLL;
        ThuocBLL thuocBLL;
        LoThuocBLL loThuocBLL;
        HoaDonBLL hoadonBLL;
        CTHoaDonBLL cthdBLL;
        BenhNhanBLL benhnhanBLL;

        List<eLoaiThuoc> dsLoaiThuoc;
        List<eThuoc> dsThuoc;
        List<eLoThuoc> dsLoThuoc;   
        List<eHoaDon> dsHoaDon;
        List<eCTHoaDon> dsCTHD;
        List<eBenhNhan> dsBenhNhan;
        public UCBanThuocKhongKeDon()
        {
            InitializeComponent();
            bsDSLoThuoc = new BindingSource();
            bsThuocDaChon = new BindingSource();
            bsTimKiem = new BindingSource();

            loaithuocBLL = new LoaiThuocBLL();
            thuocBLL = new ThuocBLL();
            loThuocBLL = new LoThuocBLL();
            hoadonBLL = new HoaDonBLL();
            cthdBLL = new CTHoaDonBLL();
            benhnhanBLL = new BenhNhanBLL();

            dsLoaiThuoc = new List<eLoaiThuoc>();
            dsLoaiThuoc = new List<eLoaiThuoc>();
            dsLoThuoc = new List<eLoThuoc>();
            dsHoaDon = new List<eHoaDon>();
            dsCTHD = new List<eCTHoaDon>();
            dsBenhNhan = new List<eBenhNhan>();

            HienThiLoThuoc();
            AutoComplete2();
            AutoComplete();


            
        }

       

        private void UCBanThuocKhongKeDon_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Today;
            lblDate.Text = dt.ToString("dd/MM/yyyy");
        }

        

        private void HienThiLoThuoc()
        {
            dsLoaiThuoc = loaithuocBLL.LayThongTinLoaiThuoc();
            dsThuoc = thuocBLL.LayThongTinThuoc();
            dsLoThuoc = loThuocBLL.LayThongTinLoThuoc();

            var gridviewInfo = dsLoaiThuoc
               .Join(dsThuoc, lt1 => lt1.MaLoaiThuoc, t => t.MaLoaiThuoc, (lt1, t) => new { lt1, t })
               .Join(dsLoThuoc, _lt1 => _lt1.t.MaThuoc, lt2 => lt2.MaThuoc, (_lt1, lt2) => new { _lt1, lt2 })
               .Where(w => w.lt2.TrangThai == 1)
               .Select(s => new
               {
                   MaThuoc = s._lt1.t.MaThuoc,
                   MaLoThuoc = s.lt2.MaLoThuoc,
                   TenThuoc = s._lt1.t.TenThuoc,
                   DVT = s.lt2.DVT,
                   SoLuong = s.lt2.SoLuong,
                   LoaiBenh = s._lt1.lt1.TenLoaiThuoc,
               }).ToList();
                  
               

            bsDSLoThuoc.DataSource = gridviewInfo;
            dgvDanhSachThuoc.DataSource = bsDSLoThuoc;

        }

        private void dgvThuocDaChon_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            tongTien = 0;
            int soLuong;
            decimal donGia;

            try
            {
                CheckErrorDgv1(dgvThuocDaChon.Rows[e.RowIndex].Cells["dongiacol"].Value.ToString());
                CheckErrorDgv2(dgvThuocDaChon.Rows[e.RowIndex].Cells["soluongcol"].Value.ToString(), Convert.ToInt32(dgvThuocDaChon.Rows[e.RowIndex].Cells["SoLuong"].Value));
                soLuong = Convert.ToInt32(dgvThuocDaChon.Rows[e.RowIndex].Cells["soluongcol"].Value);
                donGia = Convert.ToDecimal(dgvThuocDaChon.Rows[e.RowIndex].Cells["dongiacol"].Value);
                dgvThuocDaChon.Rows[e.RowIndex].Cells["tongtiencol"].Value = soLuong * donGia;

                for (int i = 0; i < dgvThuocDaChon.Rows.Count; i++)
                {
                    tongTien = tongTien + Convert.ToDecimal(dgvThuocDaChon.Rows[i].Cells["tongtiencol"].Value);
                    lblTongTien.Text = tongTien.ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnTaoLai_Click(object sender, EventArgs e)
        {
            lblTongTien.Text = "0";
            BTNthem.Enabled = true;
            BTNHuy.Enabled = false;
            while (dgvThuocDaChon.Rows.Count != 0)
            {
                dgvThuocDaChon.Rows[0].Selected = true;
                bsDSLoThuoc.Add(bsThuocDaChon.Current);
                bsThuocDaChon.RemoveCurrent();
                
            }
            dgvDanhSachThuoc.DataSource = bsDSLoThuoc;
        }

        private void BTNHuy_Click(object sender, EventArgs e)
        {
            tongTien = 0;
            if(dgvThuocDaChon.SelectedCells.Count > 0)
            {
                bsDSLoThuoc.Add(bsThuocDaChon.Current);
                dgvDanhSachThuoc.DataSource = bsDSLoThuoc;
                bsThuocDaChon.RemoveCurrent();
                if (bsThuocDaChon.Count == 0)
                {
                    lblTongTien.Text = tongTien.ToString();
                }
                else
                {
                    for (int i = 0; i < dgvThuocDaChon.Rows.Count; i++)
                    {
                        tongTien += Convert.ToDecimal(dgvThuocDaChon.Rows[i].Cells["tongtiencol"].Value);
                        lblTongTien.Text = tongTien.ToString();
                    }
                }
                BTNthem.Enabled = true;
                if(dgvThuocDaChon.Rows.Count == 0)
                {
                    BTNHuy.Enabled = false;
                    btnLapHoaDon.Enabled = false;
                    btnTaoLai.Enabled = false;
                }
            }
        }

        private void BTNthem_Click(object sender, EventArgs e)
        {
            dsLoThuoc = loThuocBLL.LayThongTinLoThuoc();
            int soLuong;
            decimal donGia;
            string maThuoc = "";
            if (dgvDanhSachThuoc.SelectedCells.Count > 0)
            {
                btnLapHoaDon.Enabled = true;
                btnTaoLai.Enabled = true;
                maThuoc = dgvDanhSachThuoc.SelectedCells[0].OwningRow.Cells["MaThuoc"].Value.ToString();
                
                bsThuocDaChon.Add(bsDSLoThuoc.Current);
                bsDSLoThuoc.RemoveCurrent();
                
                if (isThem == false)
                {
                    dgvThuocDaChon.DataSource = bsThuocDaChon;
                    dgvThuocDaChon.Columns.Add("soluongcol", "Số lượng ban");
                    dgvThuocDaChon.Columns.Add("dongiacol", "Đơn Giá");
                    dgvThuocDaChon.Columns.Add("tongtiencol", "Tổng tiền");
                    isThem = true;
                }
                else
                {
                    dgvThuocDaChon.DataSource = bsThuocDaChon;
                }
                BTNHuy.Enabled = true;

                var thongtinLoThuoc = dsLoThuoc.Where(lt => lt.MaThuoc.Equals(maThuoc) && lt.TrangThai == 1).ToList();
                dgvThuocDaChon.Rows[dgvThuocDaChon.Rows.Count - 1].Cells["soluongcol"].Value = thongtinLoThuoc.First().SoLuong;
                dgvThuocDaChon.Rows[dgvThuocDaChon.Rows.Count - 1].Cells["dongiacol"].Value = thongtinLoThuoc.First().DonGia;
                soLuong = Convert.ToInt32(dgvThuocDaChon.Rows[dgvThuocDaChon.Rows.Count - 1].Cells["soluongcol"].Value);
                donGia = Convert.ToDecimal(dgvThuocDaChon.Rows[dgvThuocDaChon.Rows.Count - 1].Cells["dongiacol"].Value);
                dgvThuocDaChon.Rows[dgvThuocDaChon.Rows.Count - 1].Cells["tongtiencol"].Value = soLuong * donGia;

                tongTien = tongTien + Convert.ToDecimal(dgvThuocDaChon.Rows[dgvThuocDaChon.Rows.Count - 1].Cells["tongtiencol"].Value);
                lblTongTien.Text = tongTien.ToString();



                if (dgvDanhSachThuoc.Rows.Count == 0)
                {
                    BTNthem.Enabled = false;

                }

                dgvThuocDaChon.Columns["tongtiencol"].ReadOnly = true;
                dgvDanhSachThuoc.DataSource = bsDSLoThuoc;
                textBoxTimKiem.Clear();
            }
            
            
        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            dsHoaDon = hoadonBLL.LayThongTinHoaDon();
            dsLoThuoc = loThuocBLL.LayThongTinLoThuoc();
            dsBenhNhan = benhnhanBLL.LayThongTinBenhNhan();
            var timkiemBN = dsBenhNhan.Where(w => w.TenBenhNhan.Equals(txtBenhNhan.Text)).ToList();

            eHoaDon newHD = new eHoaDon();
            eBenhNhan newBN = new eBenhNhan();
            if(dsHoaDon.Count == 0)
            {
                newHD.MaHoaDon = "1";
            }
            else
            {
                newHD.MaHoaDon = (Convert.ToInt32(dsHoaDon.Last().MaHoaDon) + 1).ToString();
            }

            newHD.MaNhanVien = "1";
            if(timkiemBN.Count == 0)
            {
                newHD.MaBenhNhan = newBN.MaBenhNhan = (dsBenhNhan.Count + 1).ToString();
                newBN.TenBenhNhan = txtBenhNhan.Text;
                newBN.NamSinh = Convert.ToInt32(txtNamSinh.Text);
                newBN.SDT = txtSDT.Text;
                newBN.DiaChi = cbbTP.Text;
                if(rdNam.Checked == true)
                {
                    newBN.GioiTinh = "nam";
                }
                else
                {
                    newBN.GioiTinh = "nu";
                }
                benhnhanBLL.ThemThongTinBenhNhan(newBN);
            }
            else
            {
                newHD.MaBenhNhan = timkiemBN.First().MaBenhNhan;
            }
            newHD.NgayLapHD = DateTime.Now;
            newHD.TongTien = Convert.ToDecimal(lblTongTien.Text);
            newHD.MaDonThuoc = null;
            hoadonBLL.ThemThongTinHoaDon(newHD);

            for(int i = 0; i<dgvThuocDaChon.Rows.Count; i++)
            {
                var loThuocTimKiem = dsLoThuoc.Where(w => w.MaLoThuoc.Equals(dgvThuocDaChon.Rows[i].Cells["MaLoThuoc"].Value.ToString()));
                eCTHoaDon newCTHD = new eCTHoaDon();
                if (dsHoaDon.Count == 0)
                {
                    newCTHD.MaHoaDon = "1";
                }
                else
                {
                    newCTHD.MaHoaDon = (Convert.ToInt32(dsHoaDon.Last().MaHoaDon) + 1).ToString();
                }
                newCTHD.MaLoThuoc = dgvThuocDaChon.Rows[i].Cells["MaLoThuoc"].Value.ToString();
                newCTHD.DVT = dgvThuocDaChon.Rows[i].Cells["DVT"].Value.ToString();
                newCTHD.SoLuong = Convert.ToInt32((dgvThuocDaChon.Rows[i].Cells["soluongcol"].Value));
                newCTHD.GiaBan = Convert.ToDecimal((dgvThuocDaChon.Rows[i].Cells["dongiacol"].Value));
                loThuocBLL.CapNhatSoLuongLoThuoc(dgvThuocDaChon.Rows[i].Cells["MaLoThuoc"].Value.ToString(), loThuocTimKiem.First().SoLuong - Convert.ToInt32((dgvThuocDaChon.Rows[i].Cells["soluongcol"].Value)));
                cthdBLL.ThemThongTinCTHoaDon(newCTHD);
            }
            MessageBox.Show("Tao Hoa Don Thanh Cong");
            LoadSauKhiLapHD();
            HienThiLoThuoc();
        }

        private void LoadSauKhiLapHD()
        {
            lblTongTien.Text = "0";
            BTNthem.Enabled = true;
            BTNHuy.Enabled = false;
            while (dgvThuocDaChon.Rows.Count != 0)
            {
                dgvThuocDaChon.Rows[0].Selected = true;
                bsThuocDaChon.RemoveCurrent();

            }
        }

        private void textBoxTimKiem_TextChanged(object sender, EventArgs e)
        {
            dsLoaiThuoc = loaithuocBLL.LayThongTinLoaiThuoc();
            dsThuoc = thuocBLL.LayThongTinThuoc();
            dsLoThuoc = loThuocBLL.LayThongTinLoThuoc();

            if(textBoxTimKiem.Text == "")
            {
                dgvDanhSachThuoc.DataSource = bsDSLoThuoc;
                BTNthem.Enabled = true;
            }
            else
            {
                var gridviewInfo = dsLoaiThuoc
               .Join(dsThuoc, lt1 => lt1.MaLoaiThuoc, t => t.MaLoaiThuoc, (lt1, t) => new { lt1, t })
               .Join(dsLoThuoc, _lt1 => _lt1.t.MaThuoc, lt2 => lt2.MaThuoc, (_lt1, lt2) => new { _lt1, lt2 })
               .Where(tk => tk._lt1.t.TenThuoc.Contains(textBoxTimKiem.Text))
               .Select(s => new
               {
                   MaThuoc = s._lt1.t.MaThuoc,
                   MaLoThuoc = s.lt2.MaLoThuoc,
                   TenThuoc = s._lt1.t.TenThuoc,
                   DVT = s.lt2.DVT,
                   LoaiBenh = s._lt1.lt1.TenLoaiThuoc,
               }).ToList();
                
                bsTimKiem.DataSource = gridviewInfo;
                dgvDanhSachThuoc.DataSource = bsTimKiem;
                BTNthem.Enabled = false;
            }
        }

        private void txtBenhNhan_TextChanged(object sender, EventArgs e)
        {
            dsBenhNhan = benhnhanBLL.LayThongTinBenhNhan();
            var thongtinBN = dsBenhNhan.Where(w => w.TenBenhNhan.Contains(txtBenhNhan.Text)).ToList();
            if (thongtinBN.Count == 0)
            {
                
                DisableControl(true);
                txtBenhNhan.ReadOnly = false;
            }
            else
            {
                DisableControl(false);
                txtBenhNhan.ReadOnly = false;
                if (thongtinBN.First().GioiTinh == "nam")
                {
                    rdNam.Checked = true;
                }
                else
                {
                    rdNu.Checked = true;
                }
                txtNamSinh.Text = thongtinBN.First().NamSinh.ToString();
                cbbTP.Text = thongtinBN.First().DiaChi;
                txtSDT.Text = thongtinBN.First().SDT;
            }
        }

        

        private void AutoComplete()
        {
            dsThuoc = thuocBLL.LayThongTinThuoc();

            textBoxTimKiem.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxTimKiem.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();

            foreach (var item in dsThuoc)
            {
                col.Add(item.TenThuoc);
            }
            textBoxTimKiem.AutoCompleteCustomSource = col;
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            try
            {
                CheckError();
                if (isDongY == false)
                {
                    btnDongY.Text = "Hủy";
                    DisableControl(false);
                    dgvDanhSachThuoc.Enabled = true;
                    BTNthem.Enabled = true;
                    isDongY = true;
                }
                else
                {
                    btnDongY.Text = "Xác nhận";
                    DisableControl(true);
                    dgvDanhSachThuoc.Enabled = false;
                    BTNthem.Enabled = false;
                    isDongY = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgvDanhSachThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(textBoxTimKiem.Text != "")
            {
                int i;
                string maLoThuoc;
                if (dgvDanhSachThuoc.SelectedCells.Count > 0)
                {
                    maLoThuoc = dgvDanhSachThuoc.Rows[e.RowIndex].Cells["MaLoThuoc"].Value.ToString();
                    dgvDanhSachThuoc.DataSource = bsDSLoThuoc;
                    for(i = 0; i<bsDSLoThuoc.Count; i++)
                    {
                        if (dgvDanhSachThuoc.Rows[i].Cells["MaLoThuoc"].Value.ToString().Equals(maLoThuoc))
                            break;
                    }
                    dgvDanhSachThuoc.CurrentCell = dgvDanhSachThuoc.Rows[i].Cells[0];
                    dgvDanhSachThuoc.CurrentCell.Selected = true;
                }
                BTNthem.Enabled = true;


            }
        }

        private void txtBenhNhan_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if(txtBenhNhan.Text.Length == 0)
            {
                errorProvider1.SetError(ctr, "Truong khong duoc de trong");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtNamSinh_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if(txtNamSinh.Text.Length == 0)
            {
                errorProvider1.SetError(ctr, "Khong duoc de trong");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if((Regex.IsMatch(ctr.Text, "[^0-9]+")))
            {
                errorProvider1.SetError(ctr, "So dien thoai khong hop le");
            }
            else
            {
                errorProvider1.Clear();
            }
        }



        private void txtSDT_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (txtSDT.Text.Length == 0)
            {
                errorProvider1.SetError(ctr, "Khong  duoc de trong");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtNamSinh_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if ((Regex.IsMatch(ctr.Text, "[^0-9]+")))
            {
                errorProvider1.SetError(ctr, "Nam sinh khong hop le");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void AutoComplete2()
        {
            dsBenhNhan = benhnhanBLL.LayThongTinBenhNhan();

            txtBenhNhan.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtBenhNhan.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection col2 = new AutoCompleteStringCollection();

            foreach (var item in dsBenhNhan)

            {
                col2.Add(item.TenBenhNhan);
            }
            txtBenhNhan.AutoCompleteCustomSource = col2;

        }

        private void cbbTP_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if(cbbTP.Text.Length == 0)
            {
                errorProvider1.SetError(ctr, "Khong duoc de trong");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void DisableControl(bool e)
        {
            txtBenhNhan.ReadOnly = txtNamSinh.ReadOnly = txtSDT.ReadOnly = !e;
            rdNam.Enabled = rdNu.Enabled = cbbTP.Enabled = e;
        }

        private void CheckError()
        {
            if(Regex.IsMatch(txtNamSinh.Text, "[^0-9]+"))
            {
                throw new Exception("Nam sinh khong hop le, vui long nhap lai");
            }
            else if(Regex.IsMatch(txtSDT.Text, "[^0-9]+"))
            {
                throw new Exception("So dien thoai khong hop le, vui long nhap lai");
            }
            else if(txtBenhNhan.Text.Trim().Length == 0 || txtNamSinh.Text.Trim().Length == 0 || txtSDT.Text.Trim().Length == 0 || cbbTP.Text.Trim().Length == 0)
            {
                throw new Exception("Vui long dien day du thong tin");
            }
            
        }

        private void CheckErrorDgv1(string checkString)
        {
            if (checkString == null)
            {
                throw new Exception("Khong duoc de trong");
            }
            else if (!Regex.IsMatch(checkString, "[0-9]([.,][0-9]{1,3})?$"))
            {
                throw new Exception("Don gia khong hop le, vui long nhap lai");
            }
        }

        private void CheckErrorDgv2(string checkString, int checkNumber)
        {
            if (checkString == null)
            {
                throw new Exception("Khong duoc de trong");
            }
            else if(Regex.IsMatch(checkString, "[^0-9]+"))
            {
                throw new Exception("So luong khong hop le vui long nhap lai");
            }
            else if(Convert.ToInt32(checkString) > checkNumber)
            {
                throw new Exception("So luong nhap vao phai nho hon so luong trong kho");
            }
        }

        

    }
}
