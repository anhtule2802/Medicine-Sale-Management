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
    public partial class UCKeDonThuoc : UserControl
    {
        BindingSource bs, bsTimkiem, bsThuocDaChon;
        public FormDSDT formDSDT = new FormDSDT();
        public FormDSBN formDSBN = new FormDSBN();
        public FormKeDonThuoc formKDT = new FormKeDonThuoc();
        BenhNhanBLL bnBLL;
        LoaiThuocBLL LoaiTBLL;
        ThuocBLL tBLL;
        DonThuocBLL dtBLL;
        CTDonThuocBLL ctdtBLL;
        LoThuocBLL ltBLL;
        List<eThuoc> dsT;
        List<eLoThuoc> dsLT;
        List<eLoaiThuoc> dsLoaiT;
        List<eDonThuoc> dsDT;
        List<eBenhNhan> dsBN;
        List<eCTDonThuoc> dsCTDT;
        public UCKeDonThuoc()
        {
            InitializeComponent();
            KhaiBao();
            dsBN = bnBLL.LayThongTinBenhNhan();
            HienThiThongTinThuoc();
            DateTime dt = DateTime.Today;
            lblDate.Text = dt.ToString("dd/MM/yyyy");
            AutoComplete();
            btnHuy.Enabled = false;
            btnThem.Enabled = false;
            textBoxTimKiemThuocKD.Text = "Nhập tên thuốc";
            textBoxTimKiemThuocKD.ForeColor = Color.Gray;
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["FormKeDonThuoc"];

        }
        #region CacHamHoTro
        private void AutoComplete()
        {
            textBoxTimKiemThuocKD.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxTimKiemThuocKD.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            foreach (var item in dsT)
            {
                col.Add(item.TenThuoc);
            }
            textBoxTimKiemThuocKD.AutoCompleteCustomSource = col;
        }
        private void txtTenKhachHangKD_TextChanged(object sender, EventArgs e)
        {
            Regex ten = new Regex("^[a-zA-Z_ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶ" +
            "ẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễệỉịọỏốồổỗộớờởỡợ" +
            "ụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ\\s]+$");
            if (txtTenKhachHangKD.Text == "")
            {
                errorProvider1.SetError(txtTenKhachHangKD, "");
            }
            else
            {
                if (!ten.IsMatch(txtTenKhachHangKD.Text))
                {
                    errorProvider1.SetError(txtTenKhachHangKD, "Không được dùng số hoặc kí tự đặc biệt");
                }
                else
                {
                    errorProvider1.SetError(txtTenKhachHangKD, "");
                }
            }
        }
        public void GetValue(String MaBN, String tkh, String ns, String gt,String sdt,String diachi)
        {// khai báo 1 hàm với 2 tham số đầu vào là str1, và str2 nó sẽ đưa dữ liệu vào 2 lable
            tbMaBN.Text = MaBN;
            txtTenKhachHangKD.Text = tkh;
            txtNamSinhKD.Text = ns;
            tbSDT.Text = sdt;
            cbbTP.Text = diachi;
            txtTenKhachHangKD.Enabled = false;
            txtNamSinhKD.Enabled = false;
            rdNam.Enabled = false;
            rdNu.Enabled = false;
            tbSDT.Enabled = false;
            cbbTP.Enabled = false;
            if (gt == "Nam")
            {
                rdNam.Checked = true;
            }
            if (gt == "Nu")
            {
                rdNu.Checked = true;
            }
        }
        private void dgvDanhSachThuocKD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvDanhSachThuocKD.CurrentRow.Index;
            string maThuoc = dgvDanhSachThuocKD.CurrentRow.Cells[0].Value.ToString();
            dgvDanhSachThuocKD.Rows[index].Selected = true;
            if (dgvThuocDaChonKD.Rows.Count == 0)
            {
                btnThem.Enabled = true;
            }
            else
            {
                for (int j = 0; j < dgvThuocDaChonKD.Rows.Count; j++)
                {
                    if (maThuoc == dgvThuocDaChonKD.Rows[j].Cells[3].Value.ToString())
                    {
                        MessageBox.Show("Thuốc đã có trong đơn thuốc");
                        textBoxTimKiemThuocKD.Text = "Nhập tên thuốc";
                        textBoxTimKiemThuocKD.ForeColor = Color.Gray;
                        btnThem.Enabled = false;
                        break;
                    }
                    else
                    {
                        btnThem.Enabled = true;
                    }
                }
            }
        }
        private bool ThongBaoLoi()
        {
            tbSDT.MaxLength = 12;
            Regex ten = new Regex("^[a-zA-Z_ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶ" +
            "ẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễệỉịọỏốồổỗộớờởỡợ" +
            "ụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ\\s]+$");
            Regex namsinh = new Regex("^(19|20)[0-9]{2}$");
            Regex mota = new Regex("^[a-zA-Z_ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶ" +
            "ẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễệỉịọỏốồổỗộớờởỡợ" +
            "ụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ\\s]+$");
            Regex sdt = new Regex("^[0-9]{10}$");
            if (!ten.IsMatch(txtTenKhachHangKD.Text))
            {
                MessageBox.Show("Thiếu hoặc sai tên bệnh nhân, Vui lòng kiểm tra lại");
                return false;
            }
            if (rdNam.Checked == false && rdNu.Checked == false)
            {
                MessageBox.Show("Chưa chọn giới tính, Vui lòng kiểm tra lại");
                return false;
            }
            if (!namsinh.IsMatch(txtNamSinhKD.Text))
            {
                MessageBox.Show("Thiếu hoặc sai năm sinh (1970 - 2018), Vui lòng kiểm tra lại");
                return false;
            }
            if (!sdt.IsMatch(tbSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại");
                return false;
            }
            if (cbbTP.Text == "")
            {
                MessageBox.Show("Vui lòng chọn thành phố");
                return false;
            }
            if (!mota.IsMatch(txtLoaiBenhKD.Text))
            {
                MessageBox.Show("Thiếu hoặc sai thông tin mô tả, Vui lòng kiểm tra lại");
                return false;
            }

            if (dgvThuocDaChonKD.Rows.Count == 0)
            {
                MessageBox.Show("Đơn thuốc chưa có thuốc, Vui lòng kiểm tra lại");
                return false;
            }
            for (int i = 0; i < dgvThuocDaChonKD.Rows.Count; i++)
            {
                if (dgvThuocDaChonKD.Rows[i].Cells[1].Value.ToString() == "0")
                {
                    MessageBox.Show("Vui lòng nhập số lượng thuốc");
                    return false;
                }
            }
            return true;
        }
        private void KhaiBao()
        {
            bsTimkiem = new BindingSource();
            bsThuocDaChon = new BindingSource();
            tBLL = new ThuocBLL();
            ltBLL = new LoThuocBLL();
            LoaiTBLL = new LoaiThuocBLL();
            dtBLL = new DonThuocBLL();
            bnBLL = new BenhNhanBLL();
            ctdtBLL = new CTDonThuocBLL();
            dsBN = new List<eBenhNhan>();
            dsLT = new List<eLoThuoc>();
            dsLoaiT = new List<eLoaiThuoc>();
            dsT = new List<eThuoc>();
            dsDT = new List<eDonThuoc>();
            dsCTDT = new List<eCTDonThuoc>();
        }

        private void HienThiThongTinThuoc()
        {
            dsT = tBLL.LayThongTinThuoc();
            dsLoaiT = LoaiTBLL.LayThongTinLoaiThuoc();
            bs = new BindingSource();
            var gridviewInfo = dsLoaiT
                .Join(dsT, lt1 => lt1.MaLoaiThuoc, t => t.MaLoaiThuoc, (lt1, t) => new
                {
                    MaThuoc = t.MaThuoc,
                    TenThuoc = t.TenThuoc,
                    MoTa = t.MoTa,
                    LoaiBenh = lt1.TenLoaiThuoc,
                }).ToList();
            bs.DataSource = gridviewInfo;
            dgvDanhSachThuocKD.DataSource = bs;
            dgvDanhSachThuocKD.Focus();
            dgvDanhSachThuocKD.Columns[0].HeaderText = "Mã thuốc";
            dgvDanhSachThuocKD.Columns[1].HeaderText = "Tên thuốc";
            dgvDanhSachThuocKD.Columns[2].HeaderText = "Mô Tả";
            dgvDanhSachThuocKD.Columns[3].HeaderText = "Tên loại thuốc";
            dgvDanhSachThuocKD.Columns[0].Width = 50;
            dgvDanhSachThuocKD.Columns[1].Width = 150;
            dgvDanhSachThuocKD.Columns[2].Width = 50;
            dgvDanhSachThuocKD.Columns[3].Width = 57;
        }
        private void tbSDT_TextChanged(object sender, EventArgs e)
        {
            Regex sdt = new Regex("^[0-9]{10}$");
            if(tbSDT.Text=="")
            {
                errorProvider1.SetError(tbSDT, "");
            }
            else
            {
                if(!sdt.IsMatch(tbSDT.Text))
                {
                    errorProvider1.SetError(tbSDT, "Không dùng chữ hoặc kí tự đặc biệt");
                }
                else
                {
                    errorProvider1.SetError(tbSDT, "");
                }
            }
        }
        private void txtNamSinhKD_TextChanged(object sender, EventArgs e)
        {
            Regex namsinh = new Regex("^(19|20)[0-9]{2}$");
            if (txtNamSinhKD.Text == "")
            {
                errorProvider1.SetError(txtNamSinhKD, "");
            }
            else
            {
                if (!namsinh.IsMatch(txtNamSinhKD.Text))
                {
                    errorProvider1.SetError(txtNamSinhKD, "Không dùng chữ hoặc kí tự đặc biệt,năm sinh(1900-2099)");
                }
                else
                {
                    errorProvider1.SetError(txtNamSinhKD, "");
                }
            }
        }

        private void txtLoaiBenhKD_TextChanged(object sender, EventArgs e)
        {
            Regex mota = new Regex("^[a-zA-Z_ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶ" +
            "ẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễệỉịọỏốồổỗộớờởỡợ" +
            "ụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ\\s]+$");
            if (txtLoaiBenhKD.Text == "")
            {
                errorProvider1.SetError(txtLoaiBenhKD, "");
            }
            else
            {
                if (!mota.IsMatch(txtLoaiBenhKD.Text))
                {
                    errorProvider1.SetError(txtLoaiBenhKD, "Không dùng số hoặc kí tự đặc biệt");
                }
                else
                    errorProvider1.SetError(txtLoaiBenhKD, "");
            }
        }

        private void textBoxTimKiemThuocKD_Enter(object sender, EventArgs e)
        {
            if (textBoxTimKiemThuocKD.Text == "Nhập tên thuốc")
            {
                textBoxTimKiemThuocKD.Text = "";
                textBoxTimKiemThuocKD.ForeColor = Color.Black;
            }
        }

        private void textBoxTimKiemThuocKD_Leave(object sender, EventArgs e)
        {
            if (textBoxTimKiemThuocKD.Text == "")
            {
                textBoxTimKiemThuocKD.Text = "Nhập tên thuốc";
                textBoxTimKiemThuocKD.ForeColor = Color.Gray;
            }
        }

        private void dgvThuocDaChonKD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnHuy.Enabled = true;
        }
        #endregion
        private void UCKeDonThuoc_Load(object sender, EventArgs e)
        {
            tbMaBN.Text =(dsBN.Count + 1).ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maThuoc = dgvDanhSachThuocKD.CurrentRow.Cells[0].Value.ToString();
            dsLT = ltBLL.LayThongTinLoThuoc();
            if (textBoxTimKiemThuocKD.Text == "Nhập tên thuốc") /*Them thuoc khong can tim kiem*/
            {
                if (dgvDanhSachThuocKD.CurrentRow.Index >= 0)
                {
                    var gridviewInfo = dsLT
                        .Where(t1 => t1.MaThuoc.Contains(maThuoc))
                        .Select(t2 => new
                        {
                            DVT = t2.DVT,
                        }).ToList();
                    bsThuocDaChon.Add(bs.Current);
                    dgvThuocDaChonKD.DataSource = bsThuocDaChon;
                    foreach (var item in gridviewInfo)
                    {
                        dgvThuocDaChonKD.Rows[dgvThuocDaChonKD.Rows.Count - 1].Cells["donvicol"].Value = item.DVT;
                    }
                    dgvThuocDaChonKD.Columns[0].DisplayIndex = 4;
                    dgvThuocDaChonKD.Columns[1].DisplayIndex = 5;
                    dgvThuocDaChonKD.Columns[2].DisplayIndex = 6;
                    dgvThuocDaChonKD.Columns[2].Width = 223;
                    dgvThuocDaChonKD.Columns[4].HeaderText = "Tên Thuốc";
                    dgvThuocDaChonKD.Columns[3].Visible = false;
                    dgvThuocDaChonKD.Columns[5].Visible = false;
                    dgvThuocDaChonKD.Columns[6].Visible = false;
                    dgvThuocDaChonKD.Rows[dgvThuocDaChonKD.Rows.Count - 1].Cells[1].Value = 1;
                    dgvThuocDaChonKD.Rows[dgvThuocDaChonKD.Rows.Count - 1].Cells[2].Value = "3 viên/1 ngày";
                    bs.RemoveCurrent();
                }
            }
            else /*Tim kiem thuoc roi them*/
            {
                int i;
                dgvDanhSachThuocKD.DataSource = bs;
                for (i = 0; i < bs.Count; i++)
                {
                    if (maThuoc == dgvDanhSachThuocKD.Rows[i].Cells[0].Value.ToString())
                    {
                        dgvDanhSachThuocKD.CurrentCell = dgvDanhSachThuocKD.Rows[i].Cells[0];
                        dgvDanhSachThuocKD.CurrentCell.Selected = true;
                    }
                }
                var gridviewInfo = dsLT
                    .Where(t1 => t1.MaThuoc.Contains(maThuoc))
                    .Select(t2 => new
                    {
                        DVT = t2.DVT,
                    }).ToList();
                bsThuocDaChon.Add(bs.Current);
                dgvThuocDaChonKD.DataSource = bsThuocDaChon;
                foreach (var item in gridviewInfo)
                {
                    dgvThuocDaChonKD.Rows[dgvThuocDaChonKD.Rows.Count - 1].Cells["donvicol"].Value = item.DVT;
                }
                dgvThuocDaChonKD.Columns[0].DisplayIndex = 4;
                dgvThuocDaChonKD.Columns[1].DisplayIndex = 5;
                dgvThuocDaChonKD.Columns[2].DisplayIndex = 6;
                dgvThuocDaChonKD.Columns[4].HeaderText = "Tên Thuốc";
                dgvThuocDaChonKD.Columns[3].Visible = false;
                dgvThuocDaChonKD.Columns[5].Visible = false;
                dgvThuocDaChonKD.Columns[6].Visible = false;
                dgvThuocDaChonKD.Rows[dgvThuocDaChonKD.Rows.Count - 1].Cells[1].Value = 1;
                dgvThuocDaChonKD.Rows[dgvThuocDaChonKD.Rows.Count - 1].Cells[2].Value = "3 viên/1 ngày";
                bs.RemoveCurrent();
                textBoxTimKiemThuocKD.Text = "Nhập tên thuốc";
                textBoxTimKiemThuocKD.ForeColor = Color.Gray;
            }
            btnThem.Enabled = false;
            dgvDanhSachThuocKD.ClearSelection();
            dgvThuocDaChonKD.ClearSelection();
        }

        private void btnLapDonThuoc_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["FormKeDonThuoc"];
            dsDT = dtBLL.LayThongTinDonThuoc();
            string maDT =(dsDT.Count + 1).ToString();
            DialogResult DR = MessageBox.Show("Bạn có muốn lập đơn thuốc hay không ?", "Lập đơn thuốc", MessageBoxButtons.OKCancel);
            if (DialogResult.OK == DR)
            {
                if (ThongBaoLoi() == false)
                {

                }
                else
                {
                    eDonThuoc dtmoi1 = new eDonThuoc();
                    eBenhNhan bnmoi1 = new eBenhNhan();
                    eCTDonThuoc ctdtmoi1 = new eCTDonThuoc();
                    //Lưu vào csdl Bệnh Nhân
                    bnmoi1.MaBenhNhan = tbMaBN.Text;
                    bnmoi1.TenBenhNhan = txtTenKhachHangKD.Text;
                    bnmoi1.SDT = tbSDT.Text;
                    bnmoi1.DiaChi = cbbTP.Text;
                    if (rdNam.Checked)
                    {
                        bnmoi1.GioiTinh = "Nam";
                    }
                    if (rdNu.Checked)
                    {
                        bnmoi1.GioiTinh = "Nu";
                    }
                    bnmoi1.NamSinh = Convert.ToInt32(txtNamSinhKD.Text);
                    if (bnBLL.InsertBenhNhan(bnmoi1) == 0)
                    {
                    }
                    else
                    {
                        bnBLL.InsertBenhNhan(bnmoi1);
                    }
                    //-----------------------------------//
                    //Lưu vào csdl đơn thuốc
                    dtmoi1.MaDonThuoc = maDT;
                    dtmoi1.MaBenhNhan = bnmoi1.MaBenhNhan;
                    dtmoi1.MaBacSi = ((FormKeDonThuoc)f).lblMa.Text;
                    dtmoi1.MoTaBenh = txtLoaiBenhKD.Text;
                    //-----------------------------------//
                    int kq = dtBLL.InsertDonThuoc(dtmoi1);
                    if (kq == 1)
                    {
                        //Lưu vào csdl CTHoaDon
                        int countCTDT = dgvThuocDaChonKD.Rows.Count;
                        for (int i = 0; i <= countCTDT - 1; i++)
                        {
                            ctdtmoi1.MaThuoc = Convert.ToString(dgvThuocDaChonKD.Rows[i].Cells[3].Value);
                            ctdtmoi1.MaDonThuoc = dtmoi1.MaDonThuoc;
                            ctdtmoi1.SoLuong = Convert.ToInt32(dgvThuocDaChonKD.Rows[i].Cells[1].Value);
                            ctdtmoi1.DVT = Convert.ToString(dgvThuocDaChonKD.Rows[i].Cells[0].Value);
                            ctdtmoi1.GhiChu = Convert.ToString(dgvThuocDaChonKD.Rows[i].Cells[2].Value);
                            ctdtBLL.InsertCTDonThuoc(ctdtmoi1);
                        }
                        //-----------------------------------
                        MessageBox.Show("Lập đơn thuốc thành công !");
                        dgvThuocDaChonKD.Rows.Clear();
                        txtTenKhachHangKD.Clear();
                        txtNamSinhKD.Clear();
                        txtLoaiBenhKD.Clear();
                        txtLoaiBenhKD.Clear();
                        tbSDT.Clear();
                        cbbTP.Text = "";
                        HienThiThongTinThuoc();
                        rdNam.Checked = false;
                        rdNu.Checked = false;
                        btnHuy.Enabled = false;
                        UCKeDonThuoc_Load(sender, e);
                    }
                    else
                        MessageBox.Show("Sai hoặc thiếu thông tin, vui lòng kiểm tra lại!");
                }
            }
            if (DialogResult.Cancel == DR)
            {
            }
        }
        private void btnTaoLai_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("Bạn có muốn tạo lại đơn thuốc hay không ?", "Tạo lại", MessageBoxButtons.OKCancel);
            if (DialogResult.OK == DR)
            {
                dgvThuocDaChonKD.Rows.Clear();
                btnThem.Enabled = true;
                HienThiThongTinThuoc();
                textBoxTimKiemThuocKD.Text = "Nhập tên thuốc";
                textBoxTimKiemThuocKD.ForeColor = Color.Gray;
                txtLoaiBenhKD.Clear();
                txtNamSinhKD.Clear();
                txtTenKhachHangKD.Clear();
                tbSDT.Clear();
                cbbTP.Text = "";
                btnThem.Enabled = false;
                rdNam.Enabled = true;
                rdNu.Enabled = true;
                rdNam.Checked = false;
                rdNu.Checked = false;
                txtTenKhachHangKD.Enabled = true;
                txtNamSinhKD.Enabled = true;
                tbSDT.Enabled = true;
                cbbTP.Enabled = true;
                UCKeDonThuoc_Load(sender,e);
            }
            if (DialogResult.Cancel == DR)
            {
            }
        }
        private void textBoxTimKiemThuocKD_TextChanged(object sender, EventArgs e)
        {
            if (textBoxTimKiemThuocKD.Text == "Nhập tên thuốc" || textBoxTimKiemThuocKD.Text == "")
            {
                dgvDanhSachThuocKD.DataSource = bs;
            }
            else
            {
                var newList = dsLoaiT.Join(dsT, lt1 => lt1.MaLoaiThuoc, t => t.MaLoaiThuoc, (lt1, t) => new { lt1, t })
                .Where(t1 => t1.t.TenThuoc.Contains(textBoxTimKiemThuocKD.Text))
                .Select(t2 => new
                {
                    MaThuoc = t2.t.MaThuoc,
                    TenThuoc = t2.t.TenThuoc,
                    MoTa = t2.t.MoTa,
                    LoaiBenh = t2.lt1.TenLoaiThuoc,
                }).ToList();
                bsTimkiem.DataSource = newList;
                dgvDanhSachThuocKD.DataSource = bsTimkiem;
            }
        }

        private void dgvThuocDaChonKD_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(SoLuong_KeyPress);
            if (dgvThuocDaChonKD.CurrentCell.ColumnIndex == 1) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(SoLuong_KeyPress);
                }
            }
        }
        private void SoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgvDanhSachThuocKD_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvDanhSachThuocKD.ClearSelection();
        }


        private void btnDSBN_Click(object sender, EventArgs e)
        {
            if (formDSBN.IsDisposed == true)
            {
                formDSBN = new FormDSBN();
            }
            formDSBN.HienThiThongTinBenhNhan();
            formDSBN.MyGetData = new FormDSBN.GetString(GetValue);
            formDSBN.ShowDialog();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (dgvThuocDaChonKD.CurrentRow.Index >= 0)
            {
                bs.Add(bsThuocDaChon.Current);
                dgvDanhSachThuocKD.DataSource = bs;
                bsThuocDaChon.RemoveCurrent();
                if (dgvThuocDaChonKD.Rows.Count == 0)
                {
                    btnHuy.Enabled = false;
                    HienThiThongTinThuoc();
                }
            }
            btnHuy.Enabled = false;
            dgvThuocDaChonKD.ClearSelection();
        }
    }
}
