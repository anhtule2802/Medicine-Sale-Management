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
    public partial class UCThongKeDoanhThu : UserControl
    {
        CTHoaDonBLL cthdBLL;
        List<eHoaDon> dsHD;
        List<eCTHoaDon> dsCTHD;
        HoaDonBLL hdBLL;
        BindingSource bsTKDT, bsTKNT, bsTKTHH;
        LoThuocBLL ltBLL;
        List<eLoThuoc> dsLT;
        public UCThongKeDoanhThu()
        {
            cthdBLL = new CTHoaDonBLL();
            hdBLL = new HoaDonBLL();
            dsHD = new List<eHoaDon>();
            dsCTHD = new List<eCTHoaDon>();
            ltBLL = new LoThuocBLL();
            dsLT = new List<eLoThuoc>();
            InitializeComponent();
            dsLT = ltBLL.LayThongTinLoThuoc();
            dsHD = hdBLL.LayThongTinHoaDon();
            dsCTHD = cthdBLL.LayThongTinCTHoaDon();
            HienThiThongTinThongKe();
            tabControl1.SelectedIndex = 0;
            DateTime day = DateTime.Today;
            lblNgay.Text = day.ToString("dd/MM/yyyy");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DateTime d1 = dateTimePicker1.Value;
            DateTime d2 = dateTimePicker2.Value;
            DateTime d3 = DateTime.ParseExact(d1.ToString("dd/MM/yyyy"), "dd/MM/yyyy", null);
            DateTime d4 = DateTime.ParseExact(d2.ToString("dd/MM/yyyy"), "dd/MM/yyyy", null);
            if (tabControl1.SelectedIndex==0)
            {
                label5.Text = "0";
                double tongTien = 0;
                bsTKDT = new BindingSource();
                var TKDT = dsHD.Where(hd =>  d3<=hd.NgayLapHD && hd.NgayLapHD <= d4)
                    .Select(hd => new
                    {
                        MaHoaDon = hd.MaHoaDon,
                        MaDonThuoc = hd.MaDonThuoc,
                        MaBenhNhan = hd.MaBenhNhan,
                        NgayLapHD = hd.NgayLapHD,
                        TongTien = hd.TongTien
                    }).ToList();
                bsTKDT.DataSource = TKDT;
                dgvTKDoanhThu.DataSource = bsTKDT;
                for (int i = 0; i < dgvTKDoanhThu.Rows.Count; i++)
                {
                    tongTien = tongTien + Convert.ToDouble(dgvTKDoanhThu.Rows[i].Cells[4].Value);
                    label5.Text = tongTien.ToString() + " VND";
                }
            }
            if(tabControl1.SelectedIndex==1)
            {
                var TKTN = dsLT.Where(lt => d3 <= lt.NgayNhap && lt.NgayNhap <= d4)
               .Select(lt => new
               {
                   MaLoThuoc = lt.MaLoThuoc,
                   MaThuoc = lt.MaThuoc,
                   DVT = lt.DVT,
                   NgayNhap = lt.NgayNhap,
                   SoLuong = lt.SoLuong,
                   DonGia = lt.DonGia,
                   NgayHetHan = lt.NgayHetHan
               }).ToList();
                label5.Text = "0";
                double tongtien = 0;
                bsTKNT.DataSource = TKTN;
                dgvTKNhapThuoc.DataSource = bsTKNT;
                for (int i = 0; i < dgvTKNhapThuoc.Rows.Count; i++)
                {
                    tongtien = tongtien + (Convert.ToDouble(dgvTKNhapThuoc.Rows[i].Cells[4].Value) * Convert.ToDouble(dgvTKNhapThuoc.Rows[i].Cells[5].Value));
                    label5.Text = tongtien.ToString() + " VND";
                }
            }

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void HienThiThongTinThongKe()
        {
            label5.Text = "0";
            double tongtien = 0;
            DateTime temp = DateTime.Now;
            bsTKDT = new BindingSource();
            var TKDT = dsHD.Where(hd => hd.NgayLapHD.ToString("dd/MM/yyyy").Equals(temp.ToString("dd/MM/yyyy")))
                .Select(hd => new
                {
                    MaHoaDon = hd.MaHoaDon,
                    MaDonThuoc = hd.MaDonThuoc,
                    MaBenhNhan = hd.MaBenhNhan,
                    NgayLapHD = hd.NgayLapHD,
                    TongTien = hd.TongTien
                }).ToList();
            bsTKDT.DataSource = TKDT;
            dgvTKDoanhThu.DataSource = bsTKDT;
            dgvTKDoanhThu.Columns[0].Width = 180;
            dgvTKDoanhThu.Columns[1].Width = 180;
            dgvTKDoanhThu.Columns[2].Width = 180;
            dgvTKDoanhThu.Columns[3].Width = 190;
            dgvTKDoanhThu.Columns[4].Width = 190;
            dgvTKDoanhThu.Columns[0].HeaderText = "Mã Hóa Đơn";
            dgvTKDoanhThu.Columns[1].HeaderText = "Mã Đơn Thuốc";
            dgvTKDoanhThu.Columns[2].HeaderText = "Mã Bệnh Nhân";
            dgvTKDoanhThu.Columns[3].HeaderText = "Ngày Lập HĐ";
            dgvTKDoanhThu.Columns[4].HeaderText = "Tổng Tiền";
            for (int i = 0; i < dgvTKDoanhThu.Rows.Count; i++)
            {
                tongtien = tongtien + Convert.ToDouble(dgvTKDoanhThu.Rows[i].Cells[4].Value);
                label5.Text = tongtien.ToString() + " VND";
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bsTKDT = new BindingSource();
            bsTKNT = new BindingSource();
            bsTKTHH = new BindingSource();
            DateTime temp = DateTime.Now;
            if (tabControl1.SelectedIndex == 0)
            {
                dateTimePicker1.Value = DateTime.Now;
                dateTimePicker2.Value = DateTime.Now;
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled =true;
                label4.Visible = true;
                label5.Visible = true;
                label5.Text = "0";
                double tongtien = 0;
                var TKDT = dsHD.Where(hd => hd.NgayLapHD.ToString("dd/MM/yyyy").Equals(temp.ToString("dd/MM/yyyy")))
                .Select(hd => new
                {
                    MaHoaDon = hd.MaHoaDon,
                    MaDonThuoc = hd.MaDonThuoc,
                    MaBenhNhan = hd.MaBenhNhan,
                    NgayLapHD = hd.NgayLapHD,
                    TongTien = hd.TongTien
                }).ToList();
                bsTKDT.DataSource = TKDT;
                dgvTKDoanhThu.DataSource = bsTKDT;
                dgvTKDoanhThu.Columns[0].Width = 180;
                dgvTKDoanhThu.Columns[1].Width = 180;
                dgvTKDoanhThu.Columns[2].Width = 180;
                dgvTKDoanhThu.Columns[3].Width = 190;
                dgvTKDoanhThu.Columns[4].Width = 190;
                dgvTKDoanhThu.Columns[0].HeaderText = "Mã Hóa Đơn";
                dgvTKDoanhThu.Columns[1].HeaderText = "Mã Đơn Thuốc";
                dgvTKDoanhThu.Columns[2].HeaderText = "Mã Bệnh Nhân";
                dgvTKDoanhThu.Columns[3].HeaderText = "Ngày Lập HĐ";
                dgvTKDoanhThu.Columns[4].HeaderText = "Tổng Tiền";
                for (int i = 0; i < dgvTKDoanhThu.Rows.Count; i++)
                {
                    tongtien = tongtien + Convert.ToDouble(dgvTKDoanhThu.Rows[i].Cells[4].Value);
                    label5.Text = tongtien.ToString() + " VND";
                }
            }
            if (tabControl1.SelectedIndex == 1)
            {
                dateTimePicker1.Value = DateTime.Now;
                dateTimePicker2.Value = DateTime.Now;
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
                label4.Visible = true;
                label5.Visible = true;
                label5.Text = "0";
                double tongtien = 0;
                var TKTN = dsLT.Where(lt => lt.NgayNhap.ToString("dd/MM/yyyy").Equals(temp.ToString("dd/MM/yyyy")))
                .Select(lt => new
                {
                    MaLoThuoc = lt.MaLoThuoc,
                    MaThuoc = lt.MaThuoc,
                    DVT = lt.DVT,
                    NgayNhap = lt.NgayNhap,
                    SoLuong = lt.SoLuong,
                    DonGia = lt.DonGia,
                    NgayHetHan = lt.NgayHetHan
                }).ToList();
                bsTKNT.DataSource = TKTN;
                dgvTKNhapThuoc.DataSource = bsTKNT;
                dgvTKNhapThuoc.Columns[0].Width = 80;
                dgvTKNhapThuoc.Columns[1].Width = 80;
                dgvTKNhapThuoc.Columns[2].Width = 80;
                dgvTKNhapThuoc.Columns[3].Width = 160;
                dgvTKNhapThuoc.Columns[4].Width = 160;
                dgvTKNhapThuoc.Columns[5].Width = 160;
                dgvTKNhapThuoc.Columns[6].Width = 160;
                dgvTKNhapThuoc.Columns[0].HeaderText = "Mã Lô Thuốc";
                dgvTKNhapThuoc.Columns[1].HeaderText = "Mã Thuốc";
                dgvTKNhapThuoc.Columns[2].HeaderText = "Đơn Vị Tính";
                dgvTKNhapThuoc.Columns[3].HeaderText = "Ngày Nhập";
                dgvTKNhapThuoc.Columns[4].HeaderText = "Số Lượng";
                dgvTKNhapThuoc.Columns[5].HeaderText = "Đơn Giá";
                dgvTKNhapThuoc.Columns[6].HeaderText = "Ngày Hết Hạn";

                for (int i = 0; i < dgvTKNhapThuoc.Rows.Count; i++)
                {
                    tongtien = tongtien + (Convert.ToDouble(dgvTKNhapThuoc.Rows[i].Cells[4].Value) * Convert.ToDouble(dgvTKNhapThuoc.Rows[i].Cells[5].Value));
                    label5.Text = tongtien.ToString()+" VND";
                }
            }
            if (tabControl1.SelectedIndex == 2)
            {
                dateTimePicker1.Value = DateTime.Now;
                dateTimePicker2.Value = DateTime.Today.AddDays(+10);
                var TKTHH = dsLT.Where(lt => dateTimePicker1.Value <= lt.NgayHetHan && lt.NgayHetHan <= dateTimePicker2.Value)
                .Select(lt => new
                {
                    MaLoThuoc = lt.MaLoThuoc,
                    MaThuoc = lt.MaThuoc,
                    DVT = lt.DVT,
                    NgayNhap = lt.NgayNhap,
                    NgayHetHan = lt.NgayHetHan,
                    SoLuong = lt.SoLuong,
                    DonGia = lt.DonGia,
                    MaNCC = lt.MaNCC,
                    TrangThai = lt.TrangThai,
                }).ToList();
                label5.Text = "0";
                bsTKTHH.DataSource = TKTHH;
                dgvTKThuocToiHan.DataSource = bsTKTHH;
                dgvTKThuocToiHan.Columns[0].HeaderText = "Mã Lô Thuốc";
                dgvTKThuocToiHan.Columns[1].HeaderText = "Mã Thuốc";
                dgvTKThuocToiHan.Columns[2].HeaderText = "Đơn Vị Tính";
                dgvTKThuocToiHan.Columns[3].HeaderText = "Ngày Nhập";
                dgvTKThuocToiHan.Columns[4].HeaderText = "Ngày Hết Hạn";
                dgvTKThuocToiHan.Columns[5].HeaderText = "Số Lượng";
                dgvTKThuocToiHan.Columns[6].HeaderText = "Đơn Giá";
                dgvTKThuocToiHan.Columns[7].HeaderText = "Mã NCC";
                dgvTKThuocToiHan.Columns[8].HeaderText = "Trạng Thái";
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
                label4.Visible = false;
                label5.Visible = false;
            }
        }
    }
}
