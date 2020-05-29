using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entities;
namespace PTUD_GUI
{
    public partial class FormDangNhap : Form
    {
        List<eTaiKhoan> dsTK;
        List<eNhanVien> dsNV;
        NhanVienBLL nvBLL;
        TaiKhoanBLL tkBLL;
        BacSiBLL bsBLL;
        List<eBacSi> dsBS;
        List<int> myList;
        QuanLyBLL qlBLL;
        List<eQuanLy> dsQL;
        public FormDangNhap()
        {
            InitializeComponent();
            myList = new List<int>();
            dsQL = new List<eQuanLy>();
            qlBLL = new QuanLyBLL();
            dsTK = new List<eTaiKhoan>();
            tkBLL = new TaiKhoanBLL();
            dsBS = new List<eBacSi>();
            bsBLL = new BacSiBLL();
            nvBLL = new NhanVienBLL();
            dsNV = new List<eNhanVien>();
            //dsQL = qlBLL.layThongTinQuanLy();
            //dsNV = nvBLL.LayThongTinNhanVien();
            //dsTK = tkBLL.layThongTinTaiKhoan();
            //dsBS = bsBLL.LayThongTinBacSi();
            txtMatKhau.PasswordChar = '*';
        }

        private void buttonShutDown_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có chắc muốn thoát chương trình không?", "Thoát", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //
        //button Đăng nhập
        //
        private void button1_Click(object sender, EventArgs e)
        {
            dsQL = qlBLL.LayThongTinQuanLy();
            dsNV = nvBLL.LayThongTinNhanVien();
            dsTK = tkBLL.LayThongTinTaiKhoan();
            dsBS = bsBLL.LayThongTinBacSi();
            var taiKhoan = dsTK.Where(tk => tk.UserName == txtTaiKhoan.Text && tk.Pass == txtMatKhau.Text)
                .Select(tk => tk.LoaiTK).FirstOrDefault();
            var taiKhoanTest = dsTK.Where(tk => tk.UserName == txtTaiKhoan.Text && tk.Pass == txtMatKhau.Text)
                            .Select(tk => tk.LoaiTK).Any();
            if (taiKhoanTest==false)
            {
                MessageBox.Show("Sai mat khau vui long nhap lai");
            }
            else
            {
            if (taiKhoan == "BS")
            {
                FormKeDonThuoc kd = new FormKeDonThuoc();
                var tenBS = dsBS.Join(dsTK, tk => tk.MaBacSi, bs => bs.MaBS, (tk, bs) => new { tk, bs })
                    .Where(bs1 => bs1.bs.MaBS == bs1.tk.MaBacSi)
                    .Select(bs2 => bs2.tk.TenBacSi).FirstOrDefault();
                var maBS = dsBS.Join(dsTK, tk => tk.MaBacSi, bs => bs.MaBS, (tk, bs) => new { tk, bs })
                .Where(bs1 => bs1.bs.MaBS == bs1.tk.MaBacSi)
                .Select(bs2 => bs2.tk.MaBacSi).FirstOrDefault();
                kd.lblTen.Text = tenBS.ToString();
                kd.lblMa.Text = maBS.ToString();
                kd.Show();
                this.Hide();
            }
            if (taiKhoan == "NVBH")
            {
                FormBanThuoc dn = new FormBanThuoc();
                var tenNV = dsNV.Join(dsTK, tk => tk.MaNhanVien, bs => bs.MaNV, (tk, bs) => new { tk, bs })
                .Where(bs1 => bs1.bs.MaNV == bs1.tk.MaNhanVien)
                .Select(bs2 => bs2.tk.TenNhanVien).FirstOrDefault();
                var maNV = dsNV.Join(dsTK, tk => tk.MaNhanVien, bs => bs.MaNV, (tk, bs) => new { tk, bs })
                .Where(bs1 => bs1.bs.MaNV == bs1.tk.MaNhanVien)
                .Select(bs2 => bs2.tk.MaNhanVien).FirstOrDefault();
                dn.lblTen.Text=tenNV.ToString(); //tạo label vào form bán hàng để hiển thị tên lên form
                dn.lblMa.Text=maNV.ToString();
                dn.Show();
                this.Hide();
            }
            if (taiKhoan == "NVTK")
            {
                FormThongKe tk = new FormThongKe();
                var tenNV = dsNV.Join(dsTK, tk1 => tk1.MaNhanVien, bs => bs.MaNV, (tk1, bs) => new { tk1, bs })
                .Where(bs1 => bs1.bs.MaNV == bs1.tk1.MaNhanVien)
                .Select(bs2 => bs2.tk1.TenNhanVien).FirstOrDefault();
                var maNV = dsNV.Join(dsTK, tk2 => tk2.MaNhanVien, bs => bs.MaNV, (tk2, bs) => new { tk2, bs })
                .Where(bs1 => bs1.bs.MaNV == bs1.tk2.MaNhanVien)
                .Select(bs2 => bs2.tk2.MaNhanVien).FirstOrDefault();
                tk.lblTen.Text=tenNV.ToString(); //tạo label vào form bán hàng để hiển thị tên lên form
                tk.lblMa.Text=maNV.ToString();
                tk.Show();
                this.Hide();
            }
            if (taiKhoan == "QL")
            {
                FormQuanLy ql = new FormQuanLy();
                var tenQL = dsQL.Join(dsTK, tk => tk.MaNQL, bs => bs.MaNQL, (tk, bs) => new { tk, bs })
                .Where(bs1 => bs1.bs.MaNQL == bs1.tk.MaNQL)
                .Select(bs2 => bs2.tk.TenNQL).FirstOrDefault();
                var maQL = dsQL.Join(dsTK, tk => tk.MaNQL, bs => bs.MaNQL, (tk, bs) => new { tk, bs })
                .Where(bs1 => bs1.bs.MaNQL == bs1.tk.MaNQL)
                .Select(bs2 => bs2.tk.MaNQL).FirstOrDefault();
                ql.lblTen.Text=tenQL.ToString(); //tạo label vào form quản lý để hiển thị tên lên form
                ql.lblMa.Text=maQL.ToString();
                ql.Show();
                this.Hide();
            }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            FormDoiMatKhau dmk = new FormDoiMatKhau();
            dmk.ShowDialog();
        }

        private void txtTaiKhoan_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                this.buttonDangNhap.PerformClick();
            }
        }

      
    }
}
