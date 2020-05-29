using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTUD_GUI
{
    public partial class TrangChinhProject : Form
    {
        public TrangChinhProject()
        {

            Thread th = new Thread(new ThreadStart(formRun));
            th.Start();
            Thread.Sleep(3500);
            InitializeComponent();

            th.Abort();
        }

        private void formRun()
        {
            Application.Run(new SplashScreen());
        }
        private void btnShutDown_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có chắc muốn thoát chương trình không?", "Thoát", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
                //this.Dispose();
            }
        }

        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            FormDangNhap dn = new FormDangNhap();
            dn.Show();
            this.Hide();
        }
    }
}
