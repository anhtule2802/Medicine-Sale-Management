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
    public partial class FormDSHD : Form
    {
        BindingSource bs;
        HoaDonBLL hoadonBLL;
        List<eHoaDon> dsHoaDon;
        public FormDSHD()
        {
            InitializeComponent();
            bs = new BindingSource();
            hoadonBLL = new HoaDonBLL();
            dsHoaDon = new List<eHoaDon>();
            HienThiHoaDon();
        }

        private void FormDSHD_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Today;
            lblDate.Text = dt.ToString("dd/MM/yyyy");
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void HienThiHoaDon()
        {
            dsHoaDon = hoadonBLL.LayThongTinHoaDon();
            bs.DataSource = dsHoaDon;
            dataGridView1.DataSource = bs;
        }
    }
}
