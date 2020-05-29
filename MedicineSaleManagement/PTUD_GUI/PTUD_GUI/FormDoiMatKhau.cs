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
    public partial class FormDoiMatKhau : Form
    {
        TaiKhoanBLL tkBLL;
        List<eTaiKhoan> dsTK;
        public FormDoiMatKhau()
        {
            tkBLL = new TaiKhoanBLL();
            dsTK = new List<eTaiKhoan>();
            dsTK = tkBLL.LayThongTinTaiKhoan();
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            var taiKhoan = dsTK.Where(tk => tk.UserName == tbUser.Text && tk.Pass == tbPass.Text).Any();
            var tenTK = dsTK.Where(tk => tk.UserName == tbUser.Text && tk.Pass == tbPass.Text).Select(tk => tk.UserName).FirstOrDefault();
            if (taiKhoan == true)
            {
                if (tbReNPass.Text == tbNPass.Text)
                {
                    string repass = tbReNPass.Text;
                    tkBLL.DoiMKTaiKhoan(tenTK.ToString(), tbReNPass.Text);
                    MessageBox.Show("Đổi mật khẩu thành công");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Mật khẩu mới không giống nhau");
                }
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu cũ");
            }
        }

        private void buttonshutdown_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có chắc muốn thoát không?", "Thoát", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                this.Dispose();
            }
        }
    }
}
