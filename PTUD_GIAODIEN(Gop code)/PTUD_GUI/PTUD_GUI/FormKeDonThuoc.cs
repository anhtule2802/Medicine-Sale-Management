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
    public partial class FormKeDonThuoc : Form
    {
        int panelWidth;
        bool isCollapsed;
        public FormKeDonThuoc()
        {
            InitializeComponent();
            panelWidth = panelLeft.Width;
            isCollapsed = false;
            timerTime.Start();
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labelTime.Text = dt.ToString("HH:mm:ss");
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
                if (panelLeft.Width >= panelWidth)
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
        //Di chuyển thanh trỏ chức năng
        //
        private void MovePanel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }

        //
        //button menu
        //
        private void btnMenu_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        //
        //button shutdown
        //
        private void btnShutDown_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có chắc muốn thoát chương trình không?", "Thoát", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
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
        //button kê đơn thuốc
        //
        private void btnKeDonThuoc_Click(object sender, EventArgs e)
        {
            MovePanel(btnKeDonThuoc);
            UCKeDonThuoc kdt = new UCKeDonThuoc();
            AddControlToPanel(kdt);
        }

        //
        //button danh sách đơn thuốc
        //
        private void btnDanhSachDonThuoc_Click(object sender, EventArgs e)
        {
            MovePanel(btnDanhSachDonThuoc);
            using (FormDSDT dsdt = new FormDSDT())
            {
                dsdt.ShowDialog();
            }
        }

        //
        //button đăng xuất
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
    }
}
