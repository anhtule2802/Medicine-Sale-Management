using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entities;

namespace PTUD_GUI
{
    public partial class UCQuanLiThuoc : UserControl
    {
        
        bool isThem = false;
        bool isSua = false;
        BindingSource bsThuoc;
        ThuocBLL thuocBLL;
        LoaiThuocBLL loaiThuocBLL;

        List<eThuoc> dsThuoc;
        List<eLoaiThuoc> dsLoaiThuoc;
        public UCQuanLiThuoc()
        {
            InitializeComponent();
            thuocBLL = new ThuocBLL();
            loaiThuocBLL = new LoaiThuocBLL();

            dsThuoc = new List<eThuoc>();
            dsLoaiThuoc = new List<eLoaiThuoc>();
            bsThuoc = new BindingSource();

            
        }

        private void EnableControl(bool e)
        {
            txtTenThuoc.ReadOnly = txtMoTaBenh.ReadOnly = !e;
            cboLoaiThuoc.Enabled = btnLuu.Enabled = rdoTrangThai1.Enabled = rdoTrangThai2.Enabled = e;
        }

        private void clearTXT()
        {
            cboLoaiThuoc.SelectedIndex = 0;
            txtTenThuoc.Clear();
            txtMoTaBenh.Clear();
            rdoTrangThai1.Checked = true;
        }

        private void HienThiThongTinThuoc()
        {
            
            dsThuoc = thuocBLL.LayThongTinThuoc();
            dsLoaiThuoc = loaiThuocBLL.LayThongTinLoaiThuoc();
            var gridviewInfo = dsThuoc
                .Join(dsLoaiThuoc, t => t.MaLoaiThuoc, lt => lt.MaLoaiThuoc, (t, lt) => new { t, lt })
                .Where(_t => _t.t.TrangThai == 1)
                .Select(_t1 => new
                {
                    MaThuoc = _t1.t.MaThuoc,
                    LoaiThuoc = _t1.lt.TenLoaiThuoc,
                    TenThuoc = _t1.t.TenThuoc,
                    MoTa = _t1.t.MoTa,
                    TrangThai = _t1.t.TrangThai
                }).ToList();


            
            bsThuoc.DataSource = gridviewInfo;
            dgvDanhSachThuoc.DataSource = bsThuoc;
        }

        private void cbbInfo()
        {
            dsLoaiThuoc = loaiThuocBLL.LayThongTinLoaiThuoc();
            cboLoaiThuoc.DataSource = dsLoaiThuoc;
            cboLoaiThuoc.ValueMember = "MaLoaiThuoc";
            cboLoaiThuoc.DisplayMember = "TenLoaiThuoc";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            dsThuoc = thuocBLL.LayThongTinThuoc();
            if(isThem == false)
            {
                isThem = true;
                EnableControl(true);
                btnThem.Text = "Hủy";
                btnLuu.Enabled = true;
                btnSua.Enabled = false;
                btnThem.BackColor = Color.Red;
                if (dsThuoc.Count == 0)
                {
                    txtMaThuoc.Text = "1";
                }
                else
                {
                    txtMaThuoc.Text = (Convert.ToInt32(dsThuoc.Last().MaThuoc) + 1).ToString();
                }
                dgvDanhSachThuoc.Enabled = false;
                clearTXT();
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
            if(isSua == false)
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

        private void HienThiThongTinColtrol()
        {
            if(dgvDanhSachThuoc.SelectedCells.Count > 0)
            {
                cboLoaiThuoc.Text = dgvDanhSachThuoc.SelectedCells[0].OwningRow.Cells["LoaiThuoc"].Value.ToString();
                txtMaThuoc.Text = dgvDanhSachThuoc.SelectedCells[0].OwningRow.Cells["MaThuoc"].Value.ToString();
                txtTenThuoc.Text = dgvDanhSachThuoc.SelectedCells[0].OwningRow.Cells["TenThuoc"].Value.ToString();
                txtMoTaBenh.Text = dgvDanhSachThuoc.SelectedCells[0].OwningRow.Cells["MoTa"].Value.ToString();
                if((int)dgvDanhSachThuoc.SelectedCells[0].OwningRow.Cells["TrangThai"].Value == 1)
                {
                    rdoTrangThai1.Checked = true;
                }
                else
                {
                    rdoTrangThai2.Checked = true;
                }

            }
        }

        private void dgvDanhSachThuoc_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            HienThiThongTinColtrol();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                CheckError();
                if (isThem == true)
                {
                    eThuoc newThuoc = new eThuoc();
                    newThuoc.MaLoaiThuoc = cboLoaiThuoc.SelectedValue.ToString();
                    newThuoc.MaThuoc = txtMaThuoc.Text;
                    newThuoc.TenThuoc = txtTenThuoc.Text;
                    newThuoc.MoTa = txtMoTaBenh.Text;
                    if (rdoTrangThai1.Checked == true)
                    {
                        newThuoc.TrangThai = 1;
                    }
                    else
                    {
                        newThuoc.TrangThai = 0;
                    }
                    thuocBLL.ThemThongTinThuoc(newThuoc);
                    MessageBox.Show("Them thanh cong");
                    clearTXT();
                    isThem = false;
                    btnThem.Text = "Them";
                    btnSua.Enabled = true;
                    btnLuu.Enabled = false;
                    dgvDanhSachThuoc.Enabled = true;
                    UCQuanLiThuoc_Load(sender, e);
                }
                else
                {
                    int trangThai;
                    string maThuoc = txtMaThuoc.Text;
                    string maLoaiThuoc = cboLoaiThuoc.SelectedValue.ToString();
                    string tenThuoc = txtTenThuoc.Text;
                    string moTa = txtMoTaBenh.Text;
                    if (rdoTrangThai1.Checked == true)
                    {
                        trangThai = 1;
                    }
                    else
                    {
                        trangThai = 0;
                    }
                    thuocBLL.CapNhatThongTinThuoc(maThuoc, maLoaiThuoc, tenThuoc, moTa, trangThai);
                    MessageBox.Show("Cap nhat thanh cong");
                    isSua = false;
                    btnSua.Text = "Sua";
                    btnThem.Enabled = true;
                    btnLuu.Enabled = false;
                    dgvDanhSachThuoc.Enabled = true;
                    UCQuanLiThuoc_Load(sender, e);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void UCQuanLiThuoc_Load(object sender, EventArgs e)
        {
            HienThiThongTinThuoc();
            cbbInfo();
            EnableControl(false);
        }

        private void txtTenThuoc_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if(ctr.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(ctr, "Khong duoc bo trong");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtMoTaBenh_Leave(object sender, EventArgs e)
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

        private void CheckError()
        {
            if(txtTenThuoc.Text.Trim().Length == 0 || txtMoTaBenh.Text.Trim().Length == 0)
            {
                throw new Exception("Vui long nhap day du thong tin");
            }
        }
    }
}
