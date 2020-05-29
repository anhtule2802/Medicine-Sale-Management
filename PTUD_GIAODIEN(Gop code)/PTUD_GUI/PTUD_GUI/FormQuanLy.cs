using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTUD_GUI
{
    public partial class FormQuanLy : Form
    {
        int PanelWidth;
        bool isCollapsed;
        public FormQuanLy()
        {
            InitializeComponent();
            PanelWidth = panelLeft.Width;
            isCollapsed = false;
            timerTime.Start();
        }

        //
        //Thêm control chức năng vào panel
        //
        private void AddControlToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControl.Controls.Clear();
            panelControl.Controls.Add(c);
        }

        //
        //Thu phóng thanh menu
        //
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelLeft.Width = panelLeft.Width + 10;
                if (panelLeft.Width >= PanelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                panelLeft.Width = panelLeft.Width - 10;
                if (panelLeft.Width <= 75)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        //
        //Hiện giờ
        //
        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labelTime.Text = dt.ToString("HH:mm:ss");
        }

        //
        //button menu
        //
        private void btnMenu_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        //
        //Di chuyển thanh trỏ chức năng
        //
        private void MovePanel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }

        private void btnShutDown_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có chắc muốn thoát chương trình không?", "Thoát", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //
        //button Đăng xuất
        //
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            FormDangNhap dn = new FormDangNhap();
            DialogResult dialog = MessageBox.Show("Bạn có chắc muốn đăng xuất không?", "Đăng xuất", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
               dn.Show();
               this.Hide();
            }
            
        }

        //
        //button trang chính
        //
        private void btnTrangChinh_Click(object sender, EventArgs e)
        {
            MovePanel(btnTrangChinh);
        }

        //
        //button quản lí thuốc
        //
        private void btnQuanLiThuoc_Click(object sender, EventArgs e)
        {
            MovePanel(btnQuanLiThuoc);
            UCQuanLiThuoc qlt = new UCQuanLiThuoc();
            AddControlToPanel(qlt);
        }

        //
        //button quản lí lô thuốc
        //
        private void btnQuanLiLoThuoc_Click(object sender, EventArgs e)
        {
            MovePanel(btnQuanLiLoThuoc);
            UCQuanLiLoThuoc qllt = new UCQuanLiLoThuoc();
            AddControlToPanel(qllt);
        }

        //
        //button quản lí nhân viên
        //
        private void btnQuanLiNhanVien_Click(object sender, EventArgs e)
        {
            MovePanel(btnQuanLiNhanVien);
            UCQuanLiNhanVien qlnv = new UCQuanLiNhanVien();
            AddControlToPanel(qlnv);
        }
    }
}
