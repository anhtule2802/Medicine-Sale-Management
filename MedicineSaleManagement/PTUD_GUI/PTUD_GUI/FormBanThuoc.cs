using PTUD_GUI.Properties;
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
    public partial class FormBanThuoc : Form
    {
        int PanelWidth;
        bool isCollapsed;
        public FormBanThuoc()
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
            if(isCollapsed)
            {
                panelLeft.Width = panelLeft.Width + 10;
                if(panelLeft.Width >= PanelWidth)
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
        //button Menu
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

        //
        //Button Trang chính
        //
        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            MovePanel(btnTrangChinh);
        }

        //
        //button bán thuốc không kê đơn
        //
        private void btnBanThuoc_Click(object sender, EventArgs e)
        {
            
            MovePanel(btnBanThuocKhongKeDon);
            UCBanThuocKhongKeDon uctkkd = new UCBanThuocKhongKeDon();
            AddControlToPanel(uctkkd);
        }

        //
        //button bán thuốc kê đơn
        //
        private void btnBanThuocKeDon_Click(object sender, EventArgs e)
        {
            MovePanel(btnBanThuocKeDon);
            UCBanThuocKeDon uctkd = new UCBanThuocKeDon();
            AddControlToPanel(uctkd);
        }

        //
        //button danh sách hóa đơn
        //
        private void btnDSHD_Click(object sender, EventArgs e)
        {
            MovePanel(btnDSHD);
            using(FormDSHD dshd = new FormDSHD())
            {
                dshd.ShowDialog();
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

       
        //
        //button shutdown
        //
        private void buttonShutDown_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có chắc muốn thoát chương trình không?", "Thoát", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

       

        
    }
}
